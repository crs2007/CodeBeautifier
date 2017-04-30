/*
 * Thanks for taking the time to check out my meager app.
 * It's not rocket science. I wrote it for my specific use 
 * case, which is pretty simple. There is a short blog
 * article about it here:
 *      https://itsalljustelectrons.blogspot.com/2017/04/Code-Beautifier.html
 * And of course, the GitHub repo is here:
 *      https://github.com/BeginTry/CodeBeautifier
 *      
 * LICENSE
 * Um, I don't know. Legal stuff is a PITA. Just be considerate and
 * use common sense. I shared the code. If you can use it, great. 
 * If you want to add to the code, edit the code, or share it with 
 * others...please include one (or both) of the links above. 
 * A follow on Twitter would be nice, too: 
 *      https://twitter.com/BeginTry
*/

using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CodeBeautifier
{
    /// <summary>
    /// 
    /// </summary>
    internal struct SelectedRichText
    {
        internal SelectedRichText(Font font, Color foreColor, Color backColor)
        {
            ForeColor = foreColor;
            BackColor = backColor;
            Font = font;
        }

        internal Color ForeColor;
        internal Color BackColor;
        internal Font Font;
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBeautify_Click(object sender, EventArgs e)
        {
            try
            {
                if (!FormValidated())
                {
                    return;
                }

                StringBuilder sb = new StringBuilder();
                SelectedRichText lastSelection = new SelectedRichText(null, Color.Empty, Color.Empty);

                rtCode.Select(0, 1);
                AppendOpeningSpanTag(lastSelection, sb);

                lastSelection.Font = rtCode.SelectionFont;
                lastSelection.BackColor = rtCode.SelectionBackColor;
                lastSelection.ForeColor = rtCode.SelectionColor;

                //Iterate through characters.
                for (int i = 0; i < rtCode.Text.Length; i++)
                {
                    rtCode.Select(i, 1);
                    char c = rtCode.SelectedText[0];

                    if (
                        (rtCode.SelectionBackColor != lastSelection.BackColor) ||
                        (!char.IsWhiteSpace(c) && rtCode.SelectionFont.Name != lastSelection.Font.Name) ||
                        (!char.IsWhiteSpace(c) && rtCode.SelectionColor != lastSelection.ForeColor) ||
                        (!char.IsWhiteSpace(c) && (rtCode.SelectionFont.Bold != lastSelection.Font.Bold))
                        )
                    {
                        sb.Append("</span>");
                        AppendOpeningSpanTag(lastSelection, sb);
                        lastSelection.Font = rtCode.SelectionFont;
                        lastSelection.BackColor = rtCode.SelectionBackColor;
                        lastSelection.ForeColor = rtCode.SelectionColor;
                    }

                    sb.Append(rtCode.SelectedText);
                }

                sb.Append("</span>");

                txtCode.Text = sb.ToString();
                txtCode.SelectAll();
                Clipboard.SetText(txtCode.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Returns input Color as an html hex color string.
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        private String ColorToHex(System.Drawing.Color c)
        {
            return "#" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
        }

        /// <summary>
        /// Appends a styled <span> tag to the input StringBuilder.
        /// </summary>
        /// <param name="lastSelection"></param>
        /// <param name="sb">Contains html markup.</param>
        private void AppendOpeningSpanTag(SelectedRichText lastSelection, StringBuilder sb)
        {
            sb.Append("<span style=\"");

            if (ckFontName.Checked)
            {
                if (lastSelection.Font == null || lastSelection.Font.Name != rtCode.SelectionFont.Name)
                {
                    sb.Append("font-family: '" + rtCode.SelectionFont.Name + "';");
                }
            }

            if (ckColor.Checked && lastSelection.ForeColor != rtCode.SelectionColor)
            {
                sb.Append("color: " + ColorToHex(rtCode.SelectionColor) + ";");
            }

            if (ckBackColor.Checked && lastSelection.BackColor != rtCode.SelectionBackColor)
            {
                sb.Append("background-color: " + ColorToHex(rtCode.SelectionBackColor) + ";");
            }

            if (ckFontBold.Checked)

            {
                if (lastSelection.Font == null || lastSelection.Font.Bold != rtCode.SelectionFont.Bold)
                {
                    sb.Append("font-weight: " + (rtCode.SelectionFont.Bold ? "bold" : "normal") + ";");
                }
            }

            sb.Append("\">");
        }

        /// <summary>
        /// Returns a boolean that indicates whether or not code beautification can proceed.
        /// </summary>
        /// <returns></returns>
        private bool FormValidated()
        {
            bool retVal = true;
            
            if (!(ckBackColor.Checked | ckColor.Checked | ckFontBold.Checked | ckFontName.Checked))
            {
                retVal = false;
                tabControl1.SelectTab(2);   //options tab
                MessageBox.Show("At least one format option must be chosen.", 
                    "Format Options", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
            }
            else if (string.IsNullOrEmpty(rtCode.Text))
            {
                retVal = false;
                tabControl1.SelectTab(0);   //rich text tab
                MessageBox.Show("There is no rich text to be formatted.",
                    "Rich Text",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            
            return retVal;
        }
    }
}
