using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace experience4
{
    public partial class Form1 : Form
    {
        
        int digitCount = 0;//数字个数
        int letterCount = 0;//字母个数
        int chineseCount = 0;//中文个数
        int otherCount = 0;//其他个数

        public Form1()
        {
            InitializeComponent();
            

        }



        private void Count(string s)//统计字数
        {
            digitCount = letterCount = chineseCount = otherCount =0;//置0            
            char[] ch = s.ToCharArray();
            for (int i = 0; i < ch.Length; i++)
            {
                if (char.IsDigit(ch[i]))//判断数字
                {
                    digitCount++;
                }
                else if ((ch[i] >= 65 && ch[i] <= 90) || (ch[i] >= 97 && ch[i] <= 122))//判断字母
                {
                    letterCount++;
                }
                else if (ch[i] >= 0x4E00 && ch[i] <= 0x9FA5)//判断汉字
                {
                    chineseCount++;
                }
                else //判断标点符号
                {
                    if ((ch[i] == 13) || (ch[i] == 10) || (ch[i] == 32)) {}
                    else
                        otherCount++;

                }
            }
        }

        private void bold_Click(object sender, EventArgs e)
        {
            //oldFont赋值为SelectionFont属性，若为null则赋值为Font属性
            Font oldFont = this.TextBox.SelectionFont == null ? TextBox.Font : TextBox.SelectionFont;
            //根据加粗不加粗时文本的不同下划线斜体状态做不同响应    
            if (!(oldFont.Bold)&!(oldFont.Underline)&!(oldFont.Italic))
            {
                TextBox.SelectionFont = new Font(this.Font, FontStyle.Bold);
            }
            if (!(oldFont.Bold) & !(oldFont.Underline)& oldFont.Italic)
            {
                TextBox.SelectionFont = new Font(this.Font, FontStyle.Bold|FontStyle.Italic);
            }
            if (!(oldFont.Bold) & oldFont.Underline & !(oldFont.Italic))
            {
                TextBox.SelectionFont = new Font(this.Font, FontStyle.Bold | FontStyle.Underline);
            }
            if (!(oldFont.Bold) & oldFont.Underline & oldFont.Italic)
            {
                TextBox.SelectionFont = new Font(this.Font, FontStyle.Bold | FontStyle.Italic|FontStyle.Underline);
            }
            if (oldFont.Bold & !(oldFont.Underline) & !(oldFont.Italic))
            {
                TextBox.SelectionFont = new Font(this.Font, FontStyle.Regular);
            }
            if (oldFont.Bold & oldFont.Underline & !(oldFont.Italic))
            {
                TextBox.SelectionFont = new Font(this.Font, FontStyle.Regular|FontStyle.Underline);
            }
            if (oldFont.Bold & !(oldFont.Underline) & oldFont.Italic)
            {
                TextBox.SelectionFont = new Font(this.Font, FontStyle.Regular | FontStyle.Italic);
            }
            if (oldFont.Bold & oldFont.Underline & oldFont.Italic)
            {
                TextBox.SelectionFont = new Font(this.Font, FontStyle.Regular | FontStyle.Underline|FontStyle.Italic);
            }
        }

        private void underline_Click(object sender, EventArgs e)
        {
            //oldFont赋值为SelectionFont属性，若为null则赋值为Font属性
            Font oldFont = this.TextBox.SelectionFont == null ? TextBox.Font : TextBox.SelectionFont;
            //根据加减下划线时文本的不同粗体斜体状态做不同响应    
            if (!(oldFont.Underline)&!(oldFont.Bold)&!(oldFont.Italic))
            {
                TextBox.SelectionFont = new Font(this.Font, FontStyle.Underline);
            }
            if (!(oldFont.Underline) & oldFont.Bold & !(oldFont.Italic))
            {
                TextBox.SelectionFont = new Font(this.Font, FontStyle.Underline|FontStyle.Bold);
            }
            if (!(oldFont.Underline) & !(oldFont.Bold) & oldFont.Italic)
            {
                TextBox.SelectionFont = new Font(this.Font, FontStyle.Underline|FontStyle.Italic);
            }
            if (!(oldFont.Underline) & oldFont.Bold& oldFont.Italic)
            {
                TextBox.SelectionFont = new Font(this.Font, FontStyle.Underline |FontStyle.Bold|FontStyle.Italic);
            }
            if (oldFont.Underline & oldFont.Bold & oldFont.Italic)
            {
                TextBox.SelectionFont = new Font(this.Font, FontStyle.Regular|FontStyle.Bold|FontStyle.Italic);
            }
            if (oldFont.Underline & !(oldFont.Bold) & oldFont.Italic)
            {
                TextBox.SelectionFont = new Font(this.Font, FontStyle.Regular  | FontStyle.Italic);
            }
            if (oldFont.Underline & oldFont.Bold & !(oldFont.Italic))
            {
                TextBox.SelectionFont = new Font(this.Font, FontStyle.Regular | FontStyle.Bold);
            }
            if (oldFont.Underline & !(oldFont.Bold) & !(oldFont.Italic))
            {
                TextBox.SelectionFont = new Font(this.Font, FontStyle.Regular);
            }
        }

        private void italic_Click(object sender, EventArgs e)
        {
            //oldFont赋值为SelectionFont属性，若为null则赋值为Font属性
            Font oldFont = this.TextBox.SelectionFont == null ? TextBox.Font : TextBox.SelectionFont;
            //根据斜体不斜体时文本的不同粗体下划线状态做不同响应    
            if (!(oldFont.Italic)&!(oldFont.Underline) & !(oldFont.Bold))
            {
                TextBox.SelectionFont = new Font(this.Font, FontStyle.Italic);
            }
            if (!(oldFont.Italic) & oldFont.Underline & !(oldFont.Bold))
            {
                TextBox.SelectionFont = new Font(this.Font, FontStyle.Italic|FontStyle.Underline);
            }
            if (!(oldFont.Italic) & !(oldFont.Underline) & oldFont.Bold)
            {
                TextBox.SelectionFont = new Font(this.Font, FontStyle.Italic|FontStyle.Bold);
            }
            if (!(oldFont.Italic) & oldFont.Underline & oldFont.Bold)
            {
                TextBox.SelectionFont = new Font(this.Font, FontStyle.Italic|FontStyle.Underline|FontStyle.Bold);
            }
            if (oldFont.Italic & !(oldFont.Underline) & !(oldFont.Bold))
            {
                TextBox.SelectionFont = new Font(this.Font, FontStyle.Regular);
            }
            if (oldFont.Italic & oldFont.Underline & !(oldFont.Bold))
            {
                TextBox.SelectionFont = new Font(this.Font, FontStyle.Regular|FontStyle.Underline);
            }
            if (oldFont.Italic & !(oldFont.Underline) & oldFont.Bold)
            {
                TextBox.SelectionFont = new Font(this.Font, FontStyle.Regular|FontStyle.Bold);
            }
            if (oldFont.Italic & oldFont.Underline & oldFont.Bold)
            {
                TextBox.SelectionFont = new Font(this.Font, FontStyle.Regular|FontStyle.Bold|FontStyle.Underline);
            }
        }

        private void newfile_Click(object sender, EventArgs e)//新建文本编辑器窗口
        {
            Form1 newForm1 = new Form1();
            newForm1.ShowDialog();
        }

        private void openfile_Click(object sender, EventArgs e)//打开文件窗口
        {
            //微软官方文档

            OpenFileDialog openFile1 = new OpenFileDialog();
            // Initialize the OpenFileDialog to specify the RTF extention for the file.
            openFile1.DefaultExt = "*.rtf";
            openFile1.Filter = "RTF Files|*.rtf";

            // Determine whether the user selected a file from the OpenFileDialog.
            if (openFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               openFile1.FileName.Length > 0)
            {
                // Load the contents of the file into the RichTextBox.
                TextBox.LoadFile(openFile1.FileName);
            }
        }

        private void savefile_Click(object sender, EventArgs e)//保存文件窗口
        {
            //微软官方文档

            SaveFileDialog saveFile1 = new SaveFileDialog();
            // Initialize the SaveFileDialog to specify the RTF extention for the file.
            saveFile1.DefaultExt = "*.rtf";
            saveFile1.Filter = "RTF Files|*.rtf";

            // Determine whether the user selected a file name from the saveFileDialog.
            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                           saveFile1.FileName.Length > 0)
            {
                // Save the contents of the RichTextBox into the file.
                TextBox.SaveFile(saveFile1.FileName);
            }
        }

        private void copytext_Click(object sender, EventArgs e)//复制
        {
            TextBox.Copy();
        }

        private void cuttext_Click(object sender, EventArgs e)//剪切
        {
            TextBox.Cut();
        }

        private void pastetext_Click(object sender, EventArgs e)//粘贴
        {
            TextBox.Paste();
        }

        private void findtext_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.change2 += new EventHandler(change1);

            form2.Show();
        }

        private void change1(object sender, EventArgs e)
        {
            
        }

        private void fontred_Click(object sender, EventArgs e)//字体红色
        {
            TextBox.SelectionColor = System.Drawing.Color.Red;
        }

        private void fontgreen_Click(object sender, EventArgs e)//字体绿色
        {
            TextBox.SelectionColor = System.Drawing.Color.Green;
        }

        private void fontyellow_Click(object sender, EventArgs e)//字体黄色
        {
            TextBox.SelectionColor = System.Drawing.Color.Yellow;
        }

        private void fontblue_Click(object sender, EventArgs e)//字体蓝色
        {
            TextBox.SelectionColor = System.Drawing.Color.Blue;
        }

        private void fontblack_Click(object sender, EventArgs e)//字体黑色
        {
            TextBox.SelectionColor = System.Drawing.Color.Black;
        }

        private void fontsong_Click(object sender, EventArgs e)//宋体
        {
            TextBox.SelectionFont = new Font("宋体",9);
        }

        private void fontkai_Click(object sender, EventArgs e)//楷体
        {
            TextBox.SelectionFont = new Font("楷体", 9);
        }

        private void fontli_Click(object sender, EventArgs e)//隶书
        {
            TextBox.SelectionFont = new Font("隶书",9);
        }

        private void fonthei_Click(object sender, EventArgs e)//黑体
        {
            TextBox.SelectionFont = new Font("黑体", 9);
        }

        private void fontya_Click(object sender, EventArgs e)//微软雅黑
        {
            TextBox.SelectionFont = new Font("微软雅黑", 9);
        }

        private void bigger_Click(object sender, EventArgs e)//字体增大
        {
            TextBox.SelectionFont = new Font(TextBox.SelectionFont.FontFamily, TextBox.SelectionFont.Size + 1, TextBox.SelectionFont.Style);
        }

        private void smaller_Click(object sender, EventArgs e)//字体减小
        {
            TextBox.SelectionFont = new Font(TextBox.SelectionFont.FontFamily, TextBox.SelectionFont.Size - 1, TextBox.SelectionFont.Style);
        }

        private void left_Click(object sender, EventArgs e)//左对齐
        {
            TextBox.SelectionAlignment = HorizontalAlignment.Left; 
        }

        private void middle_Click(object sender, EventArgs e)//居中对齐
        {
            TextBox.SelectionAlignment = HorizontalAlignment.Center;   
        }

        private void right_Click(object sender, EventArgs e)//右对齐
        {
            TextBox.SelectionAlignment = HorizontalAlignment.Right; 
        }

        private void undo_Click(object sender, EventArgs e)//撤销
        {
            TextBox.Undo();
        }

        private void redo_Click(object sender, EventArgs e)//恢复
        {
            TextBox.Redo();
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            Count(TextBox.Text); //统计字数
            //将行数和统计好的各种字数显示出来
            linenum.Text = TextBox.Lines.Length.ToString();
            chnum.Text = chineseCount.ToString();
            ennum.Text = letterCount.ToString();
            signnum.Text = otherCount.ToString();
        }

        private void newfiletool_Click(object sender, EventArgs e)
        {
            Form1 newForm1 = new Form1();
            newForm1.ShowDialog();
        }

        private void openfiletool_Click(object sender, EventArgs e)
        {
            //微软官方文档

            OpenFileDialog openFile1 = new OpenFileDialog();
            // Initialize the OpenFileDialog to specify the RTF extention for the file.
            openFile1.DefaultExt = "*.rtf";
            openFile1.Filter = "RTF Files|*.rtf";

            // Determine whether the user selected a file from the OpenFileDialog.
            if (openFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               openFile1.FileName.Length > 0)
            {
                // Load the contents of the file into the RichTextBox.
                TextBox.LoadFile(openFile1.FileName);
            }
        }

        private void savefiletool_Click(object sender, EventArgs e)
        {
            //微软官方文档

            SaveFileDialog saveFile1 = new SaveFileDialog();
            // Initialize the SaveFileDialog to specify the RTF extention for the file.
            saveFile1.DefaultExt = "*.rtf";
            saveFile1.Filter = "RTF Files|*.rtf";

            // Determine whether the user selected a file name from the saveFileDialog.
            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                           saveFile1.FileName.Length > 0)
            {
                // Save the contents of the RichTextBox into the file.
                TextBox.SaveFile(saveFile1.FileName);
            }
        }

        private void quittool_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void alltool_Click(object sender, EventArgs e)
        {
            TextBox.SelectAll();
        }
    }
}
