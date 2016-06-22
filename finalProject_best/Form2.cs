using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace finalProject_best
{
    public partial class Form2 : Form
    {
        public class myclass
        {
            public string 課名 { get; set; }
            public string 年級 { get; set; }
            public string 學分 { get; set; }
            public string 必選 { get; set; }
            public string 老師 { get; set; }
            public string 時間 { get; set; }
            public string 地點 { get; set; }

        }
        private List<myclass> 載入課程;
        private Form1 form1;
        private bool close_by_button = false;
        private string[,] 個人化課表 = new string[10, 5];
        private string my帳號;
        public Form2(Form1 form, string 帳號, string 系所, string 年級, string 課表)
        {
            InitializeComponent();
            form1 = form;
            this.FormClosing += Form2_FormClosing;
            帳號label.Text = "帳號：" + 帳號 + " 系所:" + 系所 + " 年級:" + 年級 + "年級";
            my帳號 = 帳號;
            //系所label.Text = 系所;
            //年級label.Text = 年級 + "年級";
            Console.WriteLine(帳號 + " " + 系所 + " " + 年級 + " " + 課表);
            課表listView.Items.Clear();
            if (!File.Exists(@"帳戶課表\" + my帳號 + ".txt"))
            {
                //第一次進入尚未更新課表
                載入課程 = new List<myclass>();
                char[] delimiterChars = { ' ' };
                string[] lines = File.ReadAllLines(@"系所課程\" + 系所 + ".txt", System.Text.Encoding.Default);
                foreach (string line in lines)
                {
                    string[] words = line.Split(delimiterChars);
                    if (words.Length > 2)
                    {
                        載入課程.Add(new myclass()
                        {
                            課名 = words[0],
                            年級 = words[1],
                            學分 = words[2],
                            必選 = words[3],
                            老師 = words[4],
                            時間 = words[5],
                            地點 = words[6]
                        });
                    }
                }
                foreach (myclass m in 載入課程)
                {
                    Console.WriteLine("課名:" + m.課名 + ", 年級:" + m.年級 +
                        ", 學分:" + m.學分 + ", 必選" + m.必選 + ", 老師" + m.老師 +
                        ", 時間:" + m.時間
                    );
                }
                //篩選出帳戶年級的課程
                List<myclass> result = 載入課程.FindAll(x => x.年級 == 年級);
                foreach (myclass m in result)
                {
                    Console.WriteLine("課名:" + m.課名 + ", 年級:" + m.年級 +
                        ", 學分:" + m.學分 + ", 必選:" + m.必選 + ", 老師" + m.老師 +
                        ", 時間:" + m.時間
                    );
                }
                //再用result篩選出帳戶的必修課
                List<myclass> final_result = result.FindAll(x => x.必選 == "必修");
                Console.WriteLine("------------------------");
                foreach (myclass m in final_result)
                {
                    Console.WriteLine("課名:" + m.課名 + ", 年級:" + m.年級 +
                        ", 學分:" + m.學分 + ", 必選:" + m.必選 + ", 老師" + m.老師 +
                        ", 時間:" + m.時間
                    );
                }
                //填入個人話課表array
                //時間如果有跨天的話用"-"分開
               
                char[] delimiterChars_day = { '-' };
                char[] delimiterChars_time = { ']', '[' };
                Regex Validator = new Regex(@"^((\[[12345]\])[123456789]+-?)+$");
                foreach (myclass m in final_result)
                {
                    

                    if (Validator.IsMatch( m.時間))
                    {
                        string[] words = m.時間.Split(delimiterChars_day);

                        //有"-"字元出現 表示有跨天
                        foreach (string w in words)
                        {
                            //w = [5]123.... ; m.課名

                            string[] letters = w.Split(delimiterChars_time);
                            int start = 1, day = 0;
                            foreach (string l in letters)
                            {
                                if (!string.IsNullOrWhiteSpace(l))
                                {
                                    // Console.WriteLine("-->" + l);
                                    //個人化課表
                                    if (start == 1)
                                    {
                                        day = Int32.Parse(l);
                                        start++;
                                    }
                                    else
                                    {
                                        Console.WriteLine("->" + day);
                                        foreach (char c in l)
                                        {

                                            if (Char.IsNumber(c) && day > 0 && day < 6)
                                            {
                                                if (Convert.ToInt32(c) - 49 > 0 && Convert.ToInt32(c) - 49 <= 10)
                                                {
                                                    個人化課表[Convert.ToInt32(c) - 49, day - 1] = m.課名;
                                                    Console.WriteLine("time:" + c + ", day:" + day);

                                                }
                                            }
                                        }
                                    }

                                }

                            }
                        }
                    }

                }
                課表listView.SmallImageList = imageList1;
                //個人化課表填寫完畢 可以丟到listview中了
                for (int i = 0; i < 10; i++)
                {

                    ListViewItem lvi = new ListViewItem((i + 1).ToString());
                    for (int j = 0; j < 5; j++)
                    {
                        lvi.SubItems.Add(個人化課表[i, j]);
                    }

                    課表listView.Items.Add(lvi);

                    if (i == 3)
                    {
                        //額外加入中午
                        ListViewItem Nlvi = new ListViewItem("N");
                        for (int j = 0; j < 5; j++)
                        {
                            Nlvi.SubItems.Add("");
                        }

                        課表listView.Items.Add(Nlvi);
                    }
                }
            }
            else
            {
                MessageBox.Show("讀取個人課表資料 -> " + 帳號);
                string[] lines = File.ReadAllLines(@"帳戶課表\" + 帳號 + ".txt", System.Text.Encoding.Default);
                //MessageBox.Show("開始存取上次存檔 -> " + lines.Length);
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        個人化課表[i, j] = lines[i * 5 + j];
                    }
                }
                課表listView.SmallImageList = imageList1;
                //個人化課表填寫完畢 可以丟到listview中了
                for (int i = 0; i < 10; i++)
                {

                    ListViewItem lvi = new ListViewItem((i + 1).ToString());
                    for (int j = 0; j < 5; j++)
                    {
                        lvi.SubItems.Add(個人化課表[i, j]);
                    }

                    課表listView.Items.Add(lvi);

                    if (i == 3)
                    {
                        //額外加入中午
                        ListViewItem Nlvi = new ListViewItem("N");
                        for (int j = 0; j < 5; j++)
                        {
                            Nlvi.SubItems.Add("");
                        }

                        課表listView.Items.Add(Nlvi);
                    }
                }

            }
        }

        private void 上一步button_Click(object sender, EventArgs e)
        {
            form1.帳號textBox.Text = "";
            form1.密碼textBox.Text = "";
            form1.Show();
            close_by_button = true;
            this.Close();
        }

        private void Form2_FormClosing(Object sender, FormClosingEventArgs e)
        {
            if (!close_by_button)
            {
                form1.Close();
            }
            //把課表存入data.txt
            using (var tw = new StreamWriter(@"帳戶課表\" + my帳號 + ".txt", false, System.Text.Encoding.Default))
            {
                foreach (string s in 個人化課表)
                {
                    tw.WriteLine(s);

                }
            }
            // Then assume that X has been clicked and act accordingly.
        }

        private void 選課ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripTextBox1.Text = "在這裡輸入課名";
            toolStripTextBox2.Text = "時間(ex:[3]56)";
        }

        private void 載入課程textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void 載入button_Click(object sender, EventArgs e)
        {
            if (載入系所listBox.SelectedItem != null)
            {
                string s = 載入系所listBox.SelectedItem.ToString();
                char[] delimiterChars = { ' ' };
                string[] lines = File.ReadAllLines(@"系所課程\" + s + ".txt", System.Text.Encoding.Default);
                選課listView.Items.Clear();
                選課listView.SmallImageList = imageList1;
                foreach (string line in lines)
                {
                    string[] words = line.Split(delimiterChars);
                    if (words.Length > 2)
                    {
                        ListViewItem lvi = new ListViewItem(words[0]);

                        lvi.SubItems.Add(words[1] + "年級");
                        lvi.SubItems.Add(words[2]);
                        lvi.SubItems.Add(words[3]);
                        lvi.SubItems.Add(words[4]);
                        lvi.SubItems.Add(words[5]);
                        lvi.SubItems.Add(words[6]);
                        lvi.SubItems.Add(words[7]);
                        選課listView.Items.Add(lvi);
                    }
                }
            }
        }

        private void 選課listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            toolStripTextBox1.Text = "";
            toolStripTextBox2.Text = "";
        }

        private void 加入button_Click(object sender, EventArgs e)
        {
            if (選課listView.SelectedItems.Count >= 1)
            {
                foreach (ListViewItem c in 選課listView.SelectedItems)
                {
                    MessageBox.Show("確定加入課程:" + c.SubItems[0].Text);
                    string classname = c.SubItems[0].Text;

                    char[] delimiterChars_day = { '-' };
                    char[] delimiterChars_time = { ']', '[' };
                    string[] words = c.SubItems[5].Text.Split(delimiterChars_day);
                    Regex Validator = new Regex(@"^((\[[12345]\])[123456789]+-?)+$");

                    if (Validator.IsMatch(c.SubItems[5].Text))
                    {
                        //有"-"字元出現 表示有跨天
                        foreach (string w in words)
                        {
                        //w = [5]123.... ; m.課名

                        string[] letters = w.Split(delimiterChars_time);
                        int start = 1, day = 0;
                            foreach (string l in letters)
                            {
                                if (!string.IsNullOrWhiteSpace(l))
                                {
                                    // Console.WriteLine("-->" + l);
                                    //個人化課表
                                    if (start == 1)
                                    {
                                        day = Int32.Parse(l);
                                        start++;
                                    }
                                    else
                                    {
                                        Console.WriteLine("->" + day);
                                        foreach (char s in l)
                                        {
                                            if (Char.IsNumber(s) && day > 0 && day < 6)
                                            {
                                                個人化課表[Convert.ToInt32(s) - 49, day - 1] = classname;
                                                Console.WriteLine("time:" + s + ", day:" + day);
                                            }
                                        }
                                    }

                                }
                            }
                        }
                    }
                    課表listView.Items.Clear();
                    //個人化課表填寫完畢 可以丟到listview中了
                    for (int i = 0; i < 10; i++)
                    {

                        ListViewItem lvi = new ListViewItem((i + 1).ToString());
                        for (int j = 0; j < 5; j++)
                        {
                            lvi.SubItems.Add(個人化課表[i, j]);
                        }

                        課表listView.Items.Add(lvi);

                        if (i == 3)
                        {
                            //額外加入中午
                            ListViewItem Nlvi = new ListViewItem("N");
                            for (int j = 0; j < 5; j++)
                            {
                                Nlvi.SubItems.Add("");
                            }

                            課表listView.Items.Add(Nlvi);
                        }
                    }
                }





            }
        }

        private void 登出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            上一步button_Click(sender, e);
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            toolStripTextBox1.Text = "";
        }

        private void toolStripComboBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void 確定加入ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(toolStripTextBox2.Text) && !string.IsNullOrWhiteSpace(toolStripTextBox1.Text))
            {
                DialogResult dr = MessageBox.Show("確定加入課程:" + toolStripTextBox1.Text
                               + ", 時間:" + toolStripTextBox2.Text
                               , "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    Regex Validator = new Regex(@"^((\[[12345]\])[123456789]+-?)+$");

                    if (Validator.IsMatch(toolStripTextBox2.Text))
                    {

                        //填入個人話課表array
                        //時間如果有跨天的話用"-"分開
                        char[] delimiterChars_day = { '-' };
                        char[] delimiterChars_time = { ']', '[' };

                        string[] words = toolStripTextBox2.Text.Split(delimiterChars_day);

                        //有"-"字元出現 表示有跨天
                        foreach (string w in words)
                        {
                            //w = [5]123.... ; m.課名

                            string[] letters = w.Split(delimiterChars_time);
                            int start = 1, day = 0;
                            foreach (string l in letters)
                            {
                                if (!string.IsNullOrWhiteSpace(l))
                                {
                                    // Console.WriteLine("-->" + l);
                                    //個人化課表
                                    if (start == 1)
                                    {
                                        day = Int32.Parse(l);
                                        start++;
                                    }
                                    else
                                    {
                                        Console.WriteLine("->" + day);
                                        foreach (char c in l)
                                        {
                                            if (Char.IsNumber(c) && day > 0 && day < 6)
                                            {
                                                個人化課表[Convert.ToInt32(c) - 49, day - 1] = toolStripTextBox1.Text;
                                                Console.WriteLine("time:" + c + ", day:" + day);
                                            }
                                        }
                                    }

                                }

                            }
                        }
                        課表listView.Items.Clear();
                        //個人化課表填寫完畢 可以丟到listview中了
                        for (int i = 0; i < 10; i++)
                        {

                            ListViewItem lvi = new ListViewItem((i + 1).ToString());
                            for (int j = 0; j < 5; j++)
                            {
                                lvi.SubItems.Add(個人化課表[i, j]);
                            }

                            課表listView.Items.Add(lvi);

                            if (i == 3)
                            {
                                //額外加入中午
                                ListViewItem Nlvi = new ListViewItem("N");
                                for (int j = 0; j < 5; j++)
                                {
                                    Nlvi.SubItems.Add("");
                                }

                                課表listView.Items.Add(Nlvi);
                            }
                        }


                    }
                    else
                    {
                        MessageBox.Show("時間輸入格式錯誤 請用下列類似方式表示[3]56");
                    }
                }
            }
        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {
            toolStripTextBox2.Text = "";

        }

        private void toolStripComboBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void 確定移除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(toolStripComboBox1.Text) && !string.IsNullOrWhiteSpace(toolStripComboBox2.Text))
            {
                int day = 0, time = 0;
                switch (toolStripComboBox1.Text)
                {
                    case "星期一":
                        day = 1;
                        break;
                    case "星期二":
                        day = 2;
                        break;
                    case "星期三":
                        day = 3;
                        break;
                    case "星期四":
                        day = 4;
                        break;
                    case "星期五":
                        day = 5;
                        break;
                    default:
                        break;
                }
                time = Int32.Parse(toolStripComboBox2.Text);
                個人化課表[time - 1, day - 1] = "";
                課表listView.Items.Clear();
                //個人化課表填寫完畢 可以丟到listview中了
                for (int i = 0; i < 10; i++)
                {

                    ListViewItem lvi = new ListViewItem((i + 1).ToString());
                    for (int j = 0; j < 5; j++)
                    {
                        lvi.SubItems.Add(個人化課表[i, j]);
                    }

                    課表listView.Items.Add(lvi);

                    if (i == 3)
                    {
                        //額外加入中午
                        ListViewItem Nlvi = new ListViewItem("N");
                        for (int j = 0; j < 5; j++)
                        {
                            Nlvi.SubItems.Add("");
                        }

                        課表listView.Items.Add(Nlvi);
                    }
                }


            }



        }

        private void 輸出課表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = "xls";
            sfd.Filter = "Excel文件(*.xls)|*.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("開始輸出課表:" + sfd.FileName);

                int rowNum = 課表listView.Items.Count;
                int columnNum = 課表listView.Items[0].SubItems.Count;
                int rowIndex = 1;
                int columnIndex = 0;
                if (rowNum == 0 || string.IsNullOrEmpty(sfd.FileName))
                {
                    return;
                }
                if (rowNum > 0)
                {

                    Excel.Application xlApp = new Excel.Application();
                    if (xlApp == null)
                    {
                        MessageBox.Show("無法建立excel檔案，可能尚未安裝excel");
                        return;
                    }
                    //var excelApp = new Excel.Application();

                    xlApp.DefaultFilePath = "";
                    xlApp.DisplayAlerts = true;
                    xlApp.SheetsInNewWorkbook = 1;
                    Microsoft.Office.Interop.Excel.Workbook xlBook = xlApp.Workbooks.Add(true);
                    //ListView行名導入Excel表第一行  
                    foreach (ColumnHeader dc in 課表listView.Columns)
                    {
                        columnIndex++;
                        xlApp.Cells[rowIndex, columnIndex] = dc.Text;
                    }
                    //ListView導入 Excel中  
                    for (int i = 0; i < rowNum; i++)
                    {
                        rowIndex++;
                        columnIndex = 0;
                        for (int j = 0; j < columnNum; j++)
                        {
                            columnIndex++;
                            //加了“\t”避免數據顯示科學記號。可以放在每行的首尾。  
                            xlApp.Cells[rowIndex, columnIndex] = Convert.ToString(課表listView.Items[i].SubItems[j].Text) + "\t";
                        }
                    }
                    //例外需要说明的是用strFileName,Excel.XlFileFormat.xlExcel9795保存方式时 当你的Excel版本不是95、97 而是2003、2007 时导出的时候会报一个错误：异常来自 HRESULT:0x800A03EC。 解决办法就是换成strFileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal。  
                    xlBook.SaveAs(sfd.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                    xlApp = null;
                    xlBook = null;
                    MessageBox.Show("輸出課表成功!");



                }

            }

        }

        private void 查看心得button_Click(object sender, EventArgs e)
        {
            if (選課listView.SelectedItems.Count >= 1)
            {
                string str = 選課listView.SelectedItems[0].SubItems[7].Text.ToString();
                
                using (var fileStream = File.Open(@"課程心得\" + str + ".txt", FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    fileStream.Close();
                }
                string[] lines = File.ReadAllLines(@"課程心得\" + str + ".txt", System.Text.Encoding.Default);
                
                Form4 form4 = new Form4(lines, 選課listView.SelectedItems[0].SubItems[0].Text.ToString());
                form4.Show();

            }
            else {
                MessageBox.Show("請選取載入後的要觀看心得的課程");
            }
        }

        private void 留下心得button_Click(object sender, EventArgs e)
        {
            if (選課listView.SelectedItems.Count >= 1)
            {
                string str = 選課listView.SelectedItems[0].SubItems[7].Text.ToString();
                
                Form5 form5 = new Form5(str, my帳號, 選課listView.SelectedItems[0].SubItems[0].Text.ToString());
                form5.Show();

            }
            else
            {
                MessageBox.Show("請選取載入後的要觀看心得的課程");
            }
        }

        private void 刪除課表課程ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
    

