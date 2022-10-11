using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_7.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            font = txt_text.Font;
        }

        Font font = null;
        bool isBold = false;
        bool isUnderlined = false;
        bool isItalic = false;

        private void btn_selectFont_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_text.Font = fontDialog1.Font;
                font = fontDialog1.Font;
            }
        }

        private void cBox_size_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = cBox_size.Text;
            font = new(font.Name, Convert.ToSingle(str));
            txt_text.Font = font;
        }

        private void btn_Font_Click(object sender, EventArgs e)
        {
            FontStyle fStyle = FontStyle.Regular;
            string str = (sender as Button).Text;

            if (str.Equals("B"))
                isBold = !isBold;
            if (str.Equals("U"))
                isUnderlined = !isUnderlined;
            if (str.Equals("I"))
                isItalic = !isItalic;

            if (isBold)
                fStyle = fStyle.AddFontStyle(FontStyle.Bold);
            if (isUnderlined)
                fStyle = fStyle.AddFontStyle(FontStyle.Underline);
            if (isItalic)
                fStyle = fStyle.AddFontStyle(FontStyle.Italic);

            font = new(font, fStyle);
            txt_text.Font = font;
        }

        private void btn_align_Click(object sender, EventArgs e)
        {
            switch ((sender as Button).Text)
            {
                case "L":
                    txt_text.TextAlign = HorizontalAlignment.Left;
                    break;
                case "C":
                    txt_text.TextAlign = HorizontalAlignment.Center;
                    break;
                case "R":
                    txt_text.TextAlign = HorizontalAlignment.Right;
                    break;
            }
        }

        private void btn_selectColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                txt_text.ForeColor = colorDialog1.Color;
        }

        private void btn_loadFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All files|*.*|Text Files|*.txt";
            openFileDialog1.FilterIndex = 2;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new(openFileDialog1.FileName);
                txt_text.Text = sr.ReadToEnd();
            }
        }

        private void btn_saveFile_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files|*.txt";
            saveFileDialog1.FilterIndex = 1;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using StreamWriter sw = new(saveFileDialog1.FileName);
                sw.Write(txt_text.Text);
            }
        }
    }
}
