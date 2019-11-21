namespace experience4
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openfiletool = new System.Windows.Forms.ToolStripMenuItem();
            this.savefiletool = new System.Windows.Forms.ToolStripMenuItem();
            this.quittool = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.格式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newfile = new System.Windows.Forms.ToolStripButton();
            this.openfile = new System.Windows.Forms.ToolStripButton();
            this.savefile = new System.Windows.Forms.ToolStripButton();
            this.copytext = new System.Windows.Forms.ToolStripButton();
            this.cuttext = new System.Windows.Forms.ToolStripButton();
            this.pastetext = new System.Windows.Forms.ToolStripButton();
            this.findtext = new System.Windows.Forms.ToolStripButton();
            this.undo = new System.Windows.Forms.ToolStripButton();
            this.redo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bold = new System.Windows.Forms.ToolStripButton();
            this.underline = new System.Windows.Forms.ToolStripButton();
            this.italic = new System.Windows.Forms.ToolStripButton();
            this.bigger = new System.Windows.Forms.ToolStripButton();
            this.smaller = new System.Windows.Forms.ToolStripButton();
            this.left = new System.Windows.Forms.ToolStripButton();
            this.middle = new System.Windows.Forms.ToolStripButton();
            this.right = new System.Windows.Forms.ToolStripButton();
            this.fontcolor = new System.Windows.Forms.ToolStripSplitButton();
            this.fontred = new System.Windows.Forms.ToolStripMenuItem();
            this.fontgreen = new System.Windows.Forms.ToolStripMenuItem();
            this.fontyellow = new System.Windows.Forms.ToolStripMenuItem();
            this.fontblue = new System.Windows.Forms.ToolStripMenuItem();
            this.fontblack = new System.Windows.Forms.ToolStripMenuItem();
            this.fonttype = new System.Windows.Forms.ToolStripSplitButton();
            this.fontsong = new System.Windows.Forms.ToolStripMenuItem();
            this.fontkai = new System.Windows.Forms.ToolStripMenuItem();
            this.fontli = new System.Windows.Forms.ToolStripMenuItem();
            this.fonthei = new System.Windows.Forms.ToolStripMenuItem();
            this.fontya = new System.Windows.Forms.ToolStripMenuItem();
            this.TextBox = new System.Windows.Forms.RichTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.chnum = new System.Windows.Forms.TextBox();
            this.linenum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.signnum = new System.Windows.Forms.TextBox();
            this.ennum = new System.Windows.Forms.TextBox();
            this.newfiletool = new System.Windows.Forms.ToolStripMenuItem();
            this.alltool = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.编辑ToolStripMenuItem,
            this.格式ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(140, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newfiletool,
            this.openfiletool,
            this.savefiletool,
            this.quittool});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // openfiletool
            // 
            this.openfiletool.Name = "openfiletool";
            this.openfiletool.Size = new System.Drawing.Size(180, 22);
            this.openfiletool.Text = "打开";
            this.openfiletool.Click += new System.EventHandler(this.openfiletool_Click);
            // 
            // savefiletool
            // 
            this.savefiletool.Name = "savefiletool";
            this.savefiletool.Size = new System.Drawing.Size(180, 22);
            this.savefiletool.Text = "保存";
            this.savefiletool.Click += new System.EventHandler(this.savefiletool_Click);
            // 
            // quittool
            // 
            this.quittool.Name = "quittool";
            this.quittool.Size = new System.Drawing.Size(180, 22);
            this.quittool.Text = "退出";
            this.quittool.Click += new System.EventHandler(this.quittool_Click);
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alltool});
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.编辑ToolStripMenuItem.Text = "编辑";
            // 
            // 格式ToolStripMenuItem
            // 
            this.格式ToolStripMenuItem.Name = "格式ToolStripMenuItem";
            this.格式ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.格式ToolStripMenuItem.Text = "格式";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newfile,
            this.openfile,
            this.savefile,
            this.copytext,
            this.cuttext,
            this.pastetext,
            this.findtext,
            this.undo,
            this.redo,
            this.toolStripSeparator1,
            this.bold,
            this.underline,
            this.italic,
            this.bigger,
            this.smaller,
            this.left,
            this.middle,
            this.right,
            this.fontcolor,
            this.fonttype});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(473, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newfile
            // 
            this.newfile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newfile.Image = ((System.Drawing.Image)(resources.GetObject("newfile.Image")));
            this.newfile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newfile.Name = "newfile";
            this.newfile.Size = new System.Drawing.Size(23, 22);
            this.newfile.Text = "toolStripButton1";
            this.newfile.ToolTipText = "新建";
            this.newfile.Click += new System.EventHandler(this.newfile_Click);
            // 
            // openfile
            // 
            this.openfile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openfile.Image = ((System.Drawing.Image)(resources.GetObject("openfile.Image")));
            this.openfile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openfile.Name = "openfile";
            this.openfile.Size = new System.Drawing.Size(23, 22);
            this.openfile.Text = "toolStripButton2";
            this.openfile.ToolTipText = "打开";
            this.openfile.Click += new System.EventHandler(this.openfile_Click);
            // 
            // savefile
            // 
            this.savefile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.savefile.Image = ((System.Drawing.Image)(resources.GetObject("savefile.Image")));
            this.savefile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.savefile.Name = "savefile";
            this.savefile.Size = new System.Drawing.Size(23, 22);
            this.savefile.Text = "toolStripButton3";
            this.savefile.ToolTipText = "保存";
            this.savefile.Click += new System.EventHandler(this.savefile_Click);
            // 
            // copytext
            // 
            this.copytext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copytext.Image = ((System.Drawing.Image)(resources.GetObject("copytext.Image")));
            this.copytext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copytext.Name = "copytext";
            this.copytext.Size = new System.Drawing.Size(23, 22);
            this.copytext.Text = "toolStripButton1";
            this.copytext.ToolTipText = "复制";
            this.copytext.Click += new System.EventHandler(this.copytext_Click);
            // 
            // cuttext
            // 
            this.cuttext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cuttext.Image = ((System.Drawing.Image)(resources.GetObject("cuttext.Image")));
            this.cuttext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cuttext.Name = "cuttext";
            this.cuttext.Size = new System.Drawing.Size(23, 22);
            this.cuttext.Text = "toolStripButton4";
            this.cuttext.ToolTipText = "剪切";
            this.cuttext.Click += new System.EventHandler(this.cuttext_Click);
            // 
            // pastetext
            // 
            this.pastetext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pastetext.Image = ((System.Drawing.Image)(resources.GetObject("pastetext.Image")));
            this.pastetext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pastetext.Name = "pastetext";
            this.pastetext.Size = new System.Drawing.Size(23, 22);
            this.pastetext.Text = "toolStripButton2";
            this.pastetext.ToolTipText = "粘贴";
            this.pastetext.Click += new System.EventHandler(this.pastetext_Click);
            // 
            // findtext
            // 
            this.findtext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.findtext.Image = ((System.Drawing.Image)(resources.GetObject("findtext.Image")));
            this.findtext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.findtext.Name = "findtext";
            this.findtext.Size = new System.Drawing.Size(23, 22);
            this.findtext.Text = "toolStripButton1";
            this.findtext.ToolTipText = "查找";
            this.findtext.Click += new System.EventHandler(this.findtext_Click);
            // 
            // undo
            // 
            this.undo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.undo.Image = ((System.Drawing.Image)(resources.GetObject("undo.Image")));
            this.undo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.undo.Name = "undo";
            this.undo.Size = new System.Drawing.Size(23, 22);
            this.undo.Text = "toolStripButton3";
            this.undo.ToolTipText = "撤销";
            this.undo.Click += new System.EventHandler(this.undo_Click);
            // 
            // redo
            // 
            this.redo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.redo.Image = ((System.Drawing.Image)(resources.GetObject("redo.Image")));
            this.redo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.redo.Name = "redo";
            this.redo.Size = new System.Drawing.Size(23, 22);
            this.redo.Text = "toolStripButton4";
            this.redo.ToolTipText = "恢复";
            this.redo.Click += new System.EventHandler(this.redo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bold
            // 
            this.bold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bold.Image = ((System.Drawing.Image)(resources.GetObject("bold.Image")));
            this.bold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bold.Name = "bold";
            this.bold.Size = new System.Drawing.Size(23, 22);
            this.bold.Text = "toolStripButton1";
            this.bold.ToolTipText = "加粗";
            this.bold.Click += new System.EventHandler(this.bold_Click);
            // 
            // underline
            // 
            this.underline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.underline.Image = ((System.Drawing.Image)(resources.GetObject("underline.Image")));
            this.underline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.underline.Name = "underline";
            this.underline.Size = new System.Drawing.Size(23, 22);
            this.underline.Text = "toolStripButton2";
            this.underline.ToolTipText = "下划线";
            this.underline.Click += new System.EventHandler(this.underline_Click);
            // 
            // italic
            // 
            this.italic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.italic.Image = ((System.Drawing.Image)(resources.GetObject("italic.Image")));
            this.italic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.italic.Name = "italic";
            this.italic.Size = new System.Drawing.Size(23, 22);
            this.italic.Text = "toolStripButton3";
            this.italic.ToolTipText = "斜体";
            this.italic.Click += new System.EventHandler(this.italic_Click);
            // 
            // bigger
            // 
            this.bigger.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bigger.Image = ((System.Drawing.Image)(resources.GetObject("bigger.Image")));
            this.bigger.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bigger.Name = "bigger";
            this.bigger.Size = new System.Drawing.Size(23, 22);
            this.bigger.Text = "toolStripButton1";
            this.bigger.ToolTipText = "字体变大";
            this.bigger.Click += new System.EventHandler(this.bigger_Click);
            // 
            // smaller
            // 
            this.smaller.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.smaller.Image = ((System.Drawing.Image)(resources.GetObject("smaller.Image")));
            this.smaller.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.smaller.Name = "smaller";
            this.smaller.Size = new System.Drawing.Size(23, 22);
            this.smaller.Text = "toolStripButton2";
            this.smaller.ToolTipText = "字体变小";
            this.smaller.Click += new System.EventHandler(this.smaller_Click);
            // 
            // left
            // 
            this.left.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.left.Image = ((System.Drawing.Image)(resources.GetObject("left.Image")));
            this.left.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(23, 22);
            this.left.Text = "toolStripButton1";
            this.left.ToolTipText = "左对齐";
            this.left.Click += new System.EventHandler(this.left_Click);
            // 
            // middle
            // 
            this.middle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.middle.Image = ((System.Drawing.Image)(resources.GetObject("middle.Image")));
            this.middle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.middle.Name = "middle";
            this.middle.Size = new System.Drawing.Size(23, 22);
            this.middle.Text = "toolStripButton2";
            this.middle.ToolTipText = "居中对齐";
            this.middle.Click += new System.EventHandler(this.middle_Click);
            // 
            // right
            // 
            this.right.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.right.Image = ((System.Drawing.Image)(resources.GetObject("right.Image")));
            this.right.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(23, 22);
            this.right.Text = "toolStripButton3";
            this.right.ToolTipText = "右对齐";
            this.right.Click += new System.EventHandler(this.right_Click);
            // 
            // fontcolor
            // 
            this.fontcolor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fontcolor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontred,
            this.fontgreen,
            this.fontyellow,
            this.fontblue,
            this.fontblack});
            this.fontcolor.Image = ((System.Drawing.Image)(resources.GetObject("fontcolor.Image")));
            this.fontcolor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fontcolor.Name = "fontcolor";
            this.fontcolor.Size = new System.Drawing.Size(32, 22);
            this.fontcolor.Text = "toolStripSplitButton1";
            this.fontcolor.ToolTipText = "颜色";
            // 
            // fontred
            // 
            this.fontred.Name = "fontred";
            this.fontred.Size = new System.Drawing.Size(100, 22);
            this.fontred.Text = "红色";
            this.fontred.Click += new System.EventHandler(this.fontred_Click);
            // 
            // fontgreen
            // 
            this.fontgreen.Name = "fontgreen";
            this.fontgreen.Size = new System.Drawing.Size(100, 22);
            this.fontgreen.Text = "绿色";
            this.fontgreen.Click += new System.EventHandler(this.fontgreen_Click);
            // 
            // fontyellow
            // 
            this.fontyellow.Name = "fontyellow";
            this.fontyellow.Size = new System.Drawing.Size(100, 22);
            this.fontyellow.Text = "黄色";
            this.fontyellow.Click += new System.EventHandler(this.fontyellow_Click);
            // 
            // fontblue
            // 
            this.fontblue.Name = "fontblue";
            this.fontblue.Size = new System.Drawing.Size(100, 22);
            this.fontblue.Text = "蓝色";
            this.fontblue.Click += new System.EventHandler(this.fontblue_Click);
            // 
            // fontblack
            // 
            this.fontblack.Name = "fontblack";
            this.fontblack.Size = new System.Drawing.Size(100, 22);
            this.fontblack.Text = "黑色";
            this.fontblack.Click += new System.EventHandler(this.fontblack_Click);
            // 
            // fonttype
            // 
            this.fonttype.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fonttype.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontsong,
            this.fontkai,
            this.fontli,
            this.fonthei,
            this.fontya});
            this.fonttype.Image = ((System.Drawing.Image)(resources.GetObject("fonttype.Image")));
            this.fonttype.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fonttype.Name = "fonttype";
            this.fonttype.Size = new System.Drawing.Size(32, 22);
            this.fonttype.Text = "toolStripSplitButton2";
            this.fonttype.ToolTipText = "字体";
            // 
            // fontsong
            // 
            this.fontsong.Name = "fontsong";
            this.fontsong.Size = new System.Drawing.Size(124, 22);
            this.fontsong.Text = "宋体";
            this.fontsong.Click += new System.EventHandler(this.fontsong_Click);
            // 
            // fontkai
            // 
            this.fontkai.Name = "fontkai";
            this.fontkai.Size = new System.Drawing.Size(124, 22);
            this.fontkai.Text = "楷体";
            this.fontkai.Click += new System.EventHandler(this.fontkai_Click);
            // 
            // fontli
            // 
            this.fontli.Name = "fontli";
            this.fontli.Size = new System.Drawing.Size(124, 22);
            this.fontli.Text = "隶书";
            this.fontli.Click += new System.EventHandler(this.fontli_Click);
            // 
            // fonthei
            // 
            this.fonthei.Name = "fonthei";
            this.fonthei.Size = new System.Drawing.Size(124, 22);
            this.fonthei.Text = "黑体";
            this.fonthei.Click += new System.EventHandler(this.fonthei_Click);
            // 
            // fontya
            // 
            this.fontya.Name = "fontya";
            this.fontya.Size = new System.Drawing.Size(124, 22);
            this.fontya.Text = "微软雅黑";
            this.fontya.Click += new System.EventHandler(this.fontya_Click);
            // 
            // TextBox
            // 
            this.TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox.Location = new System.Drawing.Point(0, 53);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(686, 350);
            this.TextBox.TabIndex = 2;
            this.TextBox.Text = "";
            this.TextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 402);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.chnum);
            this.splitContainer1.Panel1.Controls.Add(this.linenum);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.signnum);
            this.splitContainer1.Panel2.Controls.Add(this.ennum);
            this.splitContainer1.Size = new System.Drawing.Size(686, 26);
            this.splitContainer1.SplitterDistance = 326;
            this.splitContainer1.TabIndex = 3;
            // 
            // chnum
            // 
            this.chnum.Location = new System.Drawing.Point(231, 2);
            this.chnum.Name = "chnum";
            this.chnum.ReadOnly = true;
            this.chnum.Size = new System.Drawing.Size(65, 21);
            this.chnum.TabIndex = 1;
            // 
            // linenum
            // 
            this.linenum.Location = new System.Drawing.Point(86, 2);
            this.linenum.Name = "linenum";
            this.linenum.ReadOnly = true;
            this.linenum.Size = new System.Drawing.Size(65, 21);
            this.linenum.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "中文字数";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "行数";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "标点字数";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "英文字数";
            // 
            // signnum
            // 
            this.signnum.Location = new System.Drawing.Point(253, 2);
            this.signnum.Name = "signnum";
            this.signnum.ReadOnly = true;
            this.signnum.Size = new System.Drawing.Size(65, 21);
            this.signnum.TabIndex = 3;
            // 
            // ennum
            // 
            this.ennum.Location = new System.Drawing.Point(81, 2);
            this.ennum.Name = "ennum";
            this.ennum.ReadOnly = true;
            this.ennum.Size = new System.Drawing.Size(65, 21);
            this.ennum.TabIndex = 2;
            // 
            // newfiletool
            // 
            this.newfiletool.Name = "newfiletool";
            this.newfiletool.Size = new System.Drawing.Size(180, 22);
            this.newfiletool.Text = "新建";
            this.newfiletool.Click += new System.EventHandler(this.newfiletool_Click);
            // 
            // alltool
            // 
            this.alltool.Name = "alltool";
            this.alltool.Size = new System.Drawing.Size(180, 22);
            this.alltool.Text = "全选";
            this.alltool.Click += new System.EventHandler(this.alltool_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 427);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "文本编辑器";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openfiletool;
        private System.Windows.Forms.ToolStripMenuItem savefiletool;
        private System.Windows.Forms.ToolStripMenuItem quittool;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 格式ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newfile;
        private System.Windows.Forms.ToolStripButton openfile;
        private System.Windows.Forms.ToolStripButton savefile;
        private System.Windows.Forms.ToolStripButton copytext;
        private System.Windows.Forms.ToolStripButton cuttext;
        private System.Windows.Forms.ToolStripButton pastetext;
        private System.Windows.Forms.ToolStripButton findtext;
        private System.Windows.Forms.ToolStripButton undo;
        private System.Windows.Forms.ToolStripButton redo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton bold;
        private System.Windows.Forms.ToolStripButton underline;
        private System.Windows.Forms.ToolStripButton italic;
        private System.Windows.Forms.ToolStripButton bigger;
        private System.Windows.Forms.ToolStripButton smaller;
        private System.Windows.Forms.ToolStripSplitButton fontcolor;
        private System.Windows.Forms.ToolStripMenuItem fontred;
        private System.Windows.Forms.ToolStripMenuItem fontgreen;
        private System.Windows.Forms.ToolStripMenuItem fontyellow;
        private System.Windows.Forms.ToolStripMenuItem fontblack;
        private System.Windows.Forms.ToolStripSplitButton fonttype;
        private System.Windows.Forms.ToolStripMenuItem fontsong;
        private System.Windows.Forms.ToolStripMenuItem fontkai;
        private System.Windows.Forms.ToolStripMenuItem fontli;
        private System.Windows.Forms.ToolStripMenuItem fontya;
        private System.Windows.Forms.RichTextBox TextBox;
        private System.Windows.Forms.ToolStripMenuItem fontblue;
        private System.Windows.Forms.ToolStripMenuItem fonthei;
        private System.Windows.Forms.ToolStripButton left;
        private System.Windows.Forms.ToolStripButton middle;
        private System.Windows.Forms.ToolStripButton right;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox linenum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox chnum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox signnum;
        private System.Windows.Forms.TextBox ennum;
        private System.Windows.Forms.ToolStripMenuItem newfiletool;
        private System.Windows.Forms.ToolStripMenuItem alltool;
    }
}

