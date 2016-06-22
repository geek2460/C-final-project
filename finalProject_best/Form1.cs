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
    public partial class Form1 : Form
    {
        public class Members
        {
            public string 帳號 { get; set; }
            public string 密碼 { get; set; }
            public string 系所 { get; set; }
            public string 年級 { get; set; }
            public bool 課表 { get; set; }
        }
        private Form2 form2;
        private Form3 form3;
        private List<Members> 帳戶資料;
        private Members result = new Members()
        {
            帳號 ="00000",
            密碼 = "00000",
            系所 = "資訊系",
            年級 = "1",
            課表 = false
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void 下一步button_Click(object sender, EventArgs e)
        {
            form2 = new Form2(this,result.帳號,result.系所,result.年級,result.課表.ToString());
            form2.Show();
            this.Visible = false;
        }

        public void form1_load(object sender, EventArgs e)
        {
            帳戶資料 = new List<Members>();
            char[] delimiterChars = { ' ' };
            string[] lines = File.ReadAllLines(@"帳戶資料.txt", System.Text.Encoding.Default);
            foreach (string line in lines)
            {
                string[] words = line.Split(delimiterChars);
                if (words.Length > 2)
                {
                    帳戶資料.Add(new Members() {
                        帳號 = words[0], 密碼 = words[1],
                        系所 = words[2],年級 = words[3],
                        課表 = Convert.ToBoolean(words[4])
                    });
                }
            }
            foreach(Members m in 帳戶資料)
            {
                Console.WriteLine("帳號:"+m.帳號+", 密碼:"+m.密碼+ ", 系所:"+m.系所 + ", 年級:"+m.年級
                );
            }
            
        }

        private void 登入button_Click(object sender, EventArgs e)
        {
            if (帳號textBox != null && 密碼textBox != null)
            {
                if (!string.IsNullOrWhiteSpace(帳號textBox.Text) && !string.IsNullOrWhiteSpace(密碼textBox.Text))
                {
                    result = 帳戶資料.Find(x => x.帳號 == 帳號textBox.Text);

                    if (result != null)
                    {
                        if (result.密碼 == 密碼textBox.Text)
                        {
                            MessageBox.Show("登入成功");
                            下一步button_Click(sender,e);
                        }
                        else
                        {
                            MessageBox.Show("密碼錯誤");
                        }
                       // MessageBox.Show("找到的密碼: "+result.密碼);
                    }
                    else
                    {
                        MessageBox.Show("帳號錯誤");
                    }


                }
                else
                {
                    MessageBox.Show("請輸入完整的帳號密碼");
                }
            }
        }

        private void 註冊button_Click(object sender, EventArgs e)
        {
            if (form3 == null)
            {
                form3 = new Form3(this);
                form3.Show();
                form3 = null;
                this.Visible = false;
            }
        }
    }
}
