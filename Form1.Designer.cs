namespace SCTColorManager
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ReadSCTButton = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSet1 = new SCTColorManager.DataSet1();
            this.sCTdefineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.WriteFileButton = new System.Windows.Forms.Button();
            this.InstructionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCTdefineBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ReadSCTButton
            // 
            this.ReadSCTButton.Location = new System.Drawing.Point(27, 34);
            this.ReadSCTButton.Name = "ReadSCTButton";
            this.ReadSCTButton.Size = new System.Drawing.Size(116, 23);
            this.ReadSCTButton.TabIndex = 0;
            this.ReadSCTButton.Text = "Read SCT file";
            this.ReadSCTButton.UseVisualStyleBackColor = true;
            this.ReadSCTButton.Click += new System.EventHandler(this.ReadSCTButton_Click);
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            this.colorDialog1.FullOpen = true;
            this.colorDialog1.SolidColorOnly = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 315);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sCTdefineBindingSource
            // 
            this.sCTdefineBindingSource.DataMember = "SCTdefine";
            this.sCTdefineBindingSource.DataSource = this.dataSet1;
            // 
            // WriteFileButton
            // 
            this.WriteFileButton.Location = new System.Drawing.Point(150, 34);
            this.WriteFileButton.Name = "WriteFileButton";
            this.WriteFileButton.Size = new System.Drawing.Size(98, 23);
            this.WriteFileButton.TabIndex = 9;
            this.WriteFileButton.Text = "Write SCT file";
            this.WriteFileButton.UseVisualStyleBackColor = true;
            this.WriteFileButton.Click += new System.EventHandler(this.WriteFileButton_Click);
            // 
            // InstructionLabel
            // 
            this.InstructionLabel.AutoSize = true;
            this.InstructionLabel.Location = new System.Drawing.Point(95, 411);
            this.InstructionLabel.Name = "InstructionLabel";
            this.InstructionLabel.Size = new System.Drawing.Size(172, 13);
            this.InstructionLabel.TabIndex = 10;
            this.InstructionLabel.Text = "Double-click color value to change";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 450);
            this.Controls.Add(this.InstructionLabel);
            this.Controls.Add(this.WriteFileButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ReadSCTButton);
            this.Name = "Form1";
            this.Text = "SCT File Color Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCTdefineBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReadSCTButton;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource sCTdefineBindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.Button WriteFileButton;
        private System.Windows.Forms.Label InstructionLabel;
    }
}

