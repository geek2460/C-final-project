using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalProject_best
{
    public partial class Form4 : Form
    {
        private string[] lines;
        public Form4(string[] input_lines)
        {
            InitializeComponent();
            lines = input_lines;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            心得richTextBox.Text = "";
            foreach (string s in lines)
            {
                心得richTextBox.Text += s;
            }
            
           


        }

        private void 心得richTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
