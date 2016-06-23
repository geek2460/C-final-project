using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalProject_best
{
    public partial class Form5 : Form
    {
        public string s;
        public string t;
        public Form5(string 課程碼,string 帳號,string 課名)
        {
            InitializeComponent();
            s = 課程碼;
            t = 帳號;
            課名label.Text = 課名;
        }

        private void 留下心得button_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(留下心得richTextBox.Text))
            {
                DialogResult dr = MessageBox.Show("確定送出心得嗎", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    using (var fileStream = File.Open(@"課程心得\" + s + ".txt", FileMode.OpenOrCreate, FileAccess.ReadWrite))
                    {
                        fileStream.Close();
                    }
                    File.AppendAllText(@"課程心得\" + s + ".txt", "@" + t + ": " + 留下心得richTextBox.Text+ Environment.NewLine, System.Text.Encoding.Default);
                    this.Close();
                }

            }
            
        }

        private void 留下心得richTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
