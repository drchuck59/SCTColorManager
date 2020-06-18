using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCTColorManager
{
    public partial class Form1 : Form
    {
        public static DataTable Clr = new DataSet1.SCTdefineDataTable();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private int RGB2Decimal (int R, int G, int B)
        {
            return R * 65536 + G * 256 + B;
        }

        private void LoadGridView()
        {
            string HC; Color color;
            dataGridView1.DataSource = Clr;
            dataGridView1.BackgroundColor = Color.Black;
            dataGridView1.Columns[1].HeaderText = "Value";
            foreach (DataGridViewRow dgvr in dataGridView1.Rows)
            {
                HC = Convert.ToInt32(dgvr.Cells["DecValue"].Value).ToString("X");
                color = HexStringToColor(HC);
                dgvr.DefaultCellStyle.ForeColor = color;
                dgvr.DefaultCellStyle.BackColor = HexStringToColor("202020");
            }

        }

        public static Color HexStringToColor(string hexColor)
        {
            string hc = ExtractHexDigits(hexColor);
            if (hc.Length != 6)
            {
                // you can choose whether to throw an exception
                //throw new ArgumentException("hexColor is not exactly 6 digits.");
                return Color.Empty;
            }
            string r = hc.Substring(0, 2);
            string g = hc.Substring(2, 2);
            string b = hc.Substring(4, 2);
            Color color;
            try
            {
                int ri = Int32.Parse(r, NumberStyles.HexNumber);
                int gi = Int32.Parse(g, NumberStyles.HexNumber);
                int bi = Int32.Parse(b, NumberStyles.HexNumber);
                color = Color.FromArgb(ri, gi, bi);
            }
            catch
            {
                // you can choose whether to throw an exception
                //throw new ArgumentException("Conversion failed.");
                return Color.Empty;
            }
            return color;
        }

        public static string ExtractHexDigits(string input)
        {
            // remove any characters that are not digits (like #)
            var isHexDigit
                = new Regex("[abcdefABCDEF\\d]+", RegexOptions.Compiled);
            string newnum = "";
            foreach (char c in input)
            {
                if (isHexDigit.IsMatch(c.ToString()))
                {
                    newnum += c.ToString();
                }
            }
            return newnum;
        }

        private void WriteFileButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog
            {
                Title = "Save text file of #define lines",
                InitialDirectory = "D:\\OneDrive\\Documents\\vFE_Files\\Resources\\",
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
                RestoreDirectory = true,
            };
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFile.FileName))
                {
                    foreach(DataRow dr in Clr.Rows)
                    {
                        sw.WriteLine("#define " + dr["Name"].ToString() + " " + dr["DecValue"].ToString());
                    }
                }
            }
        }

        private void ReadDefineText()
        {
            string path; string define; string Name; int ClrValue;
            string ToParse;
            ;
            OpenFileDialog openFile = new OpenFileDialog
            {
                Title = "Open text file of #define lines",
                InitialDirectory = "D:\\OneDrive\\Documents\\vFE_Files\\Resources\\",
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
                RestoreDirectory = true,
            };

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                path = openFile.FileName;
                string[] Lines = File.ReadAllLines(path);

                foreach (string Line in Lines)
                {
                    ToParse = Line;
                    define = ToParse.Substring(0, ToParse.IndexOf(" ")).Trim();
                    if (define.IndexOf("#define") != -1)
                    {
                        ToParse = ToParse.Substring(ToParse.IndexOf(" ") + 1);
                        Name = ToParse.Substring(0, ToParse.IndexOf(" ")).Trim();
                        ToParse = ToParse.Substring(ToParse.IndexOf(" ") + 1);
                        ClrValue = Convert.ToInt32(ToParse);

                        Clr.Rows.Add(Name, ClrValue);
                    }
                }
                Debug.WriteLine("Table has " + Clr.Rows.Count);
            }
        }

        private void ReadSCTButton_Click(object sender, EventArgs e)
        {
            ReadDefineText();
            LoadGridView();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ColorDialog cd = colorDialog1;
            if (cd.ShowDialog() == DialogResult.OK)
            {
                DataGridViewRow dgr = dataGridView1.CurrentRow;
                dgr.DefaultCellStyle.ForeColor = cd.Color;
                Debug.WriteLine(RGB2Decimal(cd.Color.R, cd.Color.G, cd.Color.B));
                dgr.Cells[1].Value = RGB2Decimal(cd.Color.R, cd.Color.G, cd.Color.B);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ColorDialog cd = colorDialog1;
            if (cd.ShowDialog() == DialogResult.OK)
            {
                DataGridViewRow dgr = dataGridView1.CurrentRow;
                dgr.DefaultCellStyle.ForeColor = cd.Color;
                Debug.WriteLine(RGB2Decimal(cd.Color.R, cd.Color.G, cd.Color.B));
                dgr.Cells[1].Value = RGB2Decimal(cd.Color.R, cd.Color.G, cd.Color.B);
            }
        }
    }
}
