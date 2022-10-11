namespace WinForms_7.Forms
{
    partial class MainForm
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
            this.btn_selectFont = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cBox_size = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_boldFont = new System.Windows.Forms.Button();
            this.btn_underlineFont = new System.Windows.Forms.Button();
            this.btn_italicFont = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_leftAlign = new System.Windows.Forms.Button();
            this.btn_centerAlign = new System.Windows.Forms.Button();
            this.btn_rightAlign = new System.Windows.Forms.Button();
            this.btn_selectColor = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_saveFile = new System.Windows.Forms.Button();
            this.btn_loadFile = new System.Windows.Forms.Button();
            this.txt_text = new System.Windows.Forms.TextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btn_selectFont
            // 
            this.btn_selectFont.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_selectFont.Location = new System.Drawing.Point(12, 12);
            this.btn_selectFont.Name = "btn_selectFont";
            this.btn_selectFont.Size = new System.Drawing.Size(95, 33);
            this.btn_selectFont.TabIndex = 1;
            this.btn_selectFont.Text = "Select Font";
            this.btn_selectFont.UseVisualStyleBackColor = true;
            this.btn_selectFont.Click += new System.EventHandler(this.btn_selectFont_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(142, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Size";
            // 
            // cBox_size
            // 
            this.cBox_size.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_size.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cBox_size.FormattingEnabled = true;
            this.cBox_size.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "30",
            "48",
            "56",
            "60",
            "72"});
            this.cBox_size.Location = new System.Drawing.Point(130, 24);
            this.cBox_size.Name = "cBox_size";
            this.cBox_size.Size = new System.Drawing.Size(62, 21);
            this.cBox_size.TabIndex = 3;
            this.cBox_size.SelectedIndexChanged += new System.EventHandler(this.cBox_size_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(247, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Font Style";
            // 
            // btn_boldFont
            // 
            this.btn_boldFont.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_boldFont.Location = new System.Drawing.Point(241, 24);
            this.btn_boldFont.Name = "btn_boldFont";
            this.btn_boldFont.Size = new System.Drawing.Size(23, 23);
            this.btn_boldFont.TabIndex = 5;
            this.btn_boldFont.Text = "B";
            this.btn_boldFont.UseVisualStyleBackColor = true;
            this.btn_boldFont.Click += new System.EventHandler(this.btn_Font_Click);
            // 
            // btn_underlineFont
            // 
            this.btn_underlineFont.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.btn_underlineFont.Location = new System.Drawing.Point(270, 24);
            this.btn_underlineFont.Name = "btn_underlineFont";
            this.btn_underlineFont.Size = new System.Drawing.Size(23, 23);
            this.btn_underlineFont.TabIndex = 6;
            this.btn_underlineFont.Text = "U";
            this.btn_underlineFont.UseVisualStyleBackColor = true;
            this.btn_underlineFont.Click += new System.EventHandler(this.btn_Font_Click);
            // 
            // btn_italicFont
            // 
            this.btn_italicFont.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btn_italicFont.Location = new System.Drawing.Point(299, 24);
            this.btn_italicFont.Name = "btn_italicFont";
            this.btn_italicFont.Size = new System.Drawing.Size(23, 23);
            this.btn_italicFont.TabIndex = 7;
            this.btn_italicFont.Text = "I";
            this.btn_italicFont.UseVisualStyleBackColor = true;
            this.btn_italicFont.Click += new System.EventHandler(this.btn_Font_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(385, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Alignment";
            // 
            // btn_leftAlign
            // 
            this.btn_leftAlign.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_leftAlign.Location = new System.Drawing.Point(380, 24);
            this.btn_leftAlign.Name = "btn_leftAlign";
            this.btn_leftAlign.Size = new System.Drawing.Size(23, 23);
            this.btn_leftAlign.TabIndex = 9;
            this.btn_leftAlign.Text = "L";
            this.btn_leftAlign.UseVisualStyleBackColor = true;
            this.btn_leftAlign.Click += new System.EventHandler(this.btn_align_Click);
            // 
            // btn_centerAlign
            // 
            this.btn_centerAlign.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_centerAlign.Location = new System.Drawing.Point(409, 24);
            this.btn_centerAlign.Name = "btn_centerAlign";
            this.btn_centerAlign.Size = new System.Drawing.Size(23, 23);
            this.btn_centerAlign.TabIndex = 10;
            this.btn_centerAlign.Text = "C";
            this.btn_centerAlign.UseVisualStyleBackColor = true;
            this.btn_centerAlign.Click += new System.EventHandler(this.btn_align_Click);
            // 
            // btn_rightAlign
            // 
            this.btn_rightAlign.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_rightAlign.Location = new System.Drawing.Point(438, 24);
            this.btn_rightAlign.Name = "btn_rightAlign";
            this.btn_rightAlign.Size = new System.Drawing.Size(23, 23);
            this.btn_rightAlign.TabIndex = 11;
            this.btn_rightAlign.Text = "R";
            this.btn_rightAlign.UseVisualStyleBackColor = true;
            this.btn_rightAlign.Click += new System.EventHandler(this.btn_align_Click);
            // 
            // btn_selectColor
            // 
            this.btn_selectColor.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_selectColor.Location = new System.Drawing.Point(479, 12);
            this.btn_selectColor.Name = "btn_selectColor";
            this.btn_selectColor.Size = new System.Drawing.Size(105, 33);
            this.btn_selectColor.TabIndex = 12;
            this.btn_selectColor.Text = "Select Color";
            this.btn_selectColor.UseVisualStyleBackColor = true;
            this.btn_selectColor.Click += new System.EventHandler(this.btn_selectColor_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(602, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 43);
            this.panel1.TabIndex = 13;
            // 
            // btn_saveFile
            // 
            this.btn_saveFile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_saveFile.Location = new System.Drawing.Point(611, 25);
            this.btn_saveFile.Name = "btn_saveFile";
            this.btn_saveFile.Size = new System.Drawing.Size(177, 23);
            this.btn_saveFile.TabIndex = 14;
            this.btn_saveFile.Text = "Save File";
            this.btn_saveFile.UseVisualStyleBackColor = true;
            this.btn_saveFile.Click += new System.EventHandler(this.btn_saveFile_Click);
            // 
            // btn_loadFile
            // 
            this.btn_loadFile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_loadFile.Location = new System.Drawing.Point(611, 3);
            this.btn_loadFile.Name = "btn_loadFile";
            this.btn_loadFile.Size = new System.Drawing.Size(177, 23);
            this.btn_loadFile.TabIndex = 15;
            this.btn_loadFile.Text = "Load File";
            this.btn_loadFile.UseVisualStyleBackColor = true;
            this.btn_loadFile.Click += new System.EventHandler(this.btn_loadFile_Click);
            // 
            // txt_text
            // 
            this.txt_text.Location = new System.Drawing.Point(12, 51);
            this.txt_text.Multiline = true;
            this.txt_text.Name = "txt_text";
            this.txt_text.Size = new System.Drawing.Size(776, 387);
            this.txt_text.TabIndex = 16;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_text);
            this.Controls.Add(this.btn_loadFile);
            this.Controls.Add(this.btn_saveFile);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_selectColor);
            this.Controls.Add(this.btn_rightAlign);
            this.Controls.Add(this.btn_centerAlign);
            this.Controls.Add(this.btn_leftAlign);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_italicFont);
            this.Controls.Add(this.btn_underlineFont);
            this.Controls.Add(this.btn_boldFont);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cBox_size);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_selectFont);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "MainForm";
            this.Text = "WordPad Killer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btn_selectFont;
        private Label label1;
        private ComboBox cBox_size;
        private Label label2;
        private Button btn_boldFont;
        private Button btn_underlineFont;
        private Button btn_italicFont;
        private Label label3;
        private Button btn_leftAlign;
        private Button btn_centerAlign;
        private Button btn_rightAlign;
        private Button btn_selectColor;
        private Panel panel1;
        private Button btn_saveFile;
        private Button btn_loadFile;
        private TextBox txt_text;
        private FontDialog fontDialog1;
        private ColorDialog colorDialog1;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
    }
}