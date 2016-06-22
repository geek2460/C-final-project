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
    public partial class Form3 : Form
    {
        public class Members
        {
            public string 帳號 { get; set; }
            public string 密碼 { get; set; }
            public string 系所 { get; set; }
            public string 年級 { get; set; }
            public bool 課表 { get; set; }
        }
        private Form1 form1;
        private bool close_by_button = false;
        private List<Members> 帳戶資料;
        public Form3(Form1 form)
        {
            InitializeComponent();
            form1 = form;
            this.FormClosing += Form3_FormClosing;

            帳戶資料 = new List<Members>();
            char[] delimiterChars = { ' ' };
            string[] lines = File.ReadAllLines(@"帳戶資料.txt", System.Text.Encoding.Default);
            foreach (string line in lines)
            {
                string[] words = line.Split(delimiterChars);
                if (words.Length > 2)
                {
                    帳戶資料.Add(new Members()
                    {
                        帳號 = words[0],
                        密碼 = words[1],
                        系所 = words[2],
                        年級 = words[3],
                        課表 = Convert.ToBoolean(words[4])
                    });
                }
            }
            foreach (Members m in 帳戶資料)
            {
                Console.WriteLine("帳號:" + m.帳號 + ", 密碼:" + m.密碼 + ", 系所:" + m.系所);
            }

        }

        private void 註冊成功button_Click(object sender, EventArgs e)
        {
            form1.帳號textBox.Text = "";
            form1.密碼textBox.Text = "";
            form1.Show();
            close_by_button = true;
            this.Close();
        }
        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!close_by_button)
            {
                form1.Close();
            }
           // Then assume that X has been clicked and act accordingly.
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void 註冊button_Click(object sender, EventArgs e)
        {
            if (帳號textBox != null && 密碼textBox != null)
            {
                if (!string.IsNullOrWhiteSpace(帳號textBox.Text) && !string.IsNullOrWhiteSpace(密碼textBox.Text))
                {
                    Members result = 帳戶資料.Find(x => x.帳號 == 帳號textBox.Text);

                    if (result != null)
                    {
                        MessageBox.Show("帳號已被申請");
                    }
                    else
                    {//帳號沒有重複 先確認帳號密碼沒有空白 再開始確認listbox的資料
                        
                        
                        if (帳號textBox.Text.Contains(" ") ==true || 密碼textBox.Text.Contains(" ") == true
                            || 密碼textBox.Text.Contains("\t") || 帳號textBox.Text.Contains("\t"))
                        {
                            MessageBox.Show("帳號密碼皆不能有空白字元");
                        }
                        else {
                            if (系所listBox.SelectedItem != null && 年級listBox.SelectedItem != null)
                            {
                                DialogResult dr = MessageBox.Show("確定註冊資料 帳號:"+ 帳號textBox.Text
                                    + ", 系所:" + 系所listBox.SelectedItem.ToString() + ", 年級:" + 年級listBox.SelectedItem.ToString()
                                    , "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                                if (dr == DialogResult.Yes)
                                {


                                    string 系所string = 系所listBox.SelectedItem.ToString();
                                    string 年級string = 年級listBox.SelectedItem.ToString();
                                    //寫入資料 並且離開
                                    using (var tw = new StreamWriter(@"帳戶資料.txt", false, System.Text.Encoding.Default))
                                    {
                                        foreach (Members m in 帳戶資料)
                                        {
                                            tw.WriteLine(m.帳號 + " " +
                                                m.密碼 + " " + m.系所 + " " + m.年級 + " " + m.課表);
                                        }
                                        tw.WriteLine(帳號textBox.Text + " " +
                                                密碼textBox.Text + " " + 系所string + " " + 年級string + " " + "false");
                                    }
                                    form1.form1_load(sender, e);
                                    Console.WriteLine("--------");
                                    註冊成功button_Click(sender, e);
                                    MessageBox.Show("註冊完畢");
                                }
                            }
                            else {
                                MessageBox.Show("請記得要點選系所及年級清單");
                            }
                        }
                    }


                }
                else
                {
                    MessageBox.Show("請輸入完整的帳號密碼");
                }
            }
        }
    }
}
