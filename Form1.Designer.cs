namespace Notebook
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ToolStripMenuItem EditSelectAll;
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.FileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.FileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.FileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.FileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.FileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.EditUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.EditCut = new System.Windows.Forms.ToolStripMenuItem();
            this.EditCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.EditPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.EditTimeDate = new System.Windows.Forms.ToolStripMenuItem();
            this.Choice = new System.Windows.Forms.ToolStripMenuItem();
            this.ChoiceFont = new System.Windows.Forms.ToolStripMenuItem();
            this.ChoiceBackClor = new System.Windows.Forms.ToolStripMenuItem();
            this.ChoiceForeColor = new System.Windows.Forms.ToolStripMenuItem();
            this.Help = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tbTextArea = new System.Windows.Forms.TextBox();
            EditSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // EditSelectAll
            // 
            EditSelectAll.Name = "EditSelectAll";
            EditSelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            EditSelectAll.Size = new System.Drawing.Size(192, 22);
            EditSelectAll.Text = "全选(&A)";
            EditSelectAll.Click += new System.EventHandler(this.EditSelectAll_Click);
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.Edit,
            this.Choice,
            this.Help});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(543, 25);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // File
            // 
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileNew,
            this.FileOpen,
            this.FileSave,
            this.FileSaveAs,
            this.FileExit});
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(58, 21);
            this.File.Text = "文件(&F)";
            // 
            // FileNew
            // 
            this.FileNew.Name = "FileNew";
            this.FileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.FileNew.Size = new System.Drawing.Size(165, 22);
            this.FileNew.Text = "新建(&N)";
            this.FileNew.Click += new System.EventHandler(this.FileNew_Click);
            // 
            // FileOpen
            // 
            this.FileOpen.Name = "FileOpen";
            this.FileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.FileOpen.Size = new System.Drawing.Size(165, 22);
            this.FileOpen.Text = "打开(&O)";
            this.FileOpen.Click += new System.EventHandler(this.FileOpen_Click);
            // 
            // FileSave
            // 
            this.FileSave.Name = "FileSave";
            this.FileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.FileSave.Size = new System.Drawing.Size(165, 22);
            this.FileSave.Text = "保存(&S)";
            this.FileSave.Click += new System.EventHandler(this.FileSave_Click);
            // 
            // FileSaveAs
            // 
            this.FileSaveAs.Name = "FileSaveAs";
            this.FileSaveAs.Size = new System.Drawing.Size(165, 22);
            this.FileSaveAs.Text = "另存为(&A)";
            this.FileSaveAs.Click += new System.EventHandler(this.FileSaveAs_Click);
            // 
            // FileExit
            // 
            this.FileExit.Name = "FileExit";
            this.FileExit.Size = new System.Drawing.Size(165, 22);
            this.FileExit.Text = "退出(&X)";
            this.FileExit.Click += new System.EventHandler(this.FileQuit_Click);
            // 
            // Edit
            // 
            this.Edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditUndo,
            this.EditCut,
            this.EditCopy,
            this.EditPaste,
            this.EditTimeDate,
            EditSelectAll});
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(59, 21);
            this.Edit.Text = "编辑(&E)";
            // 
            // EditUndo
            // 
            this.EditUndo.Name = "EditUndo";
            this.EditUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.EditUndo.Size = new System.Drawing.Size(192, 22);
            this.EditUndo.Text = "撤销(&U)";
            this.EditUndo.Click += new System.EventHandler(this.EditUndo_Click);
            // 
            // EditCut
            // 
            this.EditCut.Name = "EditCut";
            this.EditCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.EditCut.Size = new System.Drawing.Size(192, 22);
            this.EditCut.Text = "剪切(&T)";
            this.EditCut.Click += new System.EventHandler(this.EditCut_Click);
            // 
            // EditCopy
            // 
            this.EditCopy.Name = "EditCopy";
            this.EditCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.EditCopy.Size = new System.Drawing.Size(192, 22);
            this.EditCopy.Text = "复制(&C)";
            this.EditCopy.Click += new System.EventHandler(this.EditCopy_Click);
            // 
            // EditPaste
            // 
            this.EditPaste.Name = "EditPaste";
            this.EditPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.EditPaste.Size = new System.Drawing.Size(192, 22);
            this.EditPaste.Text = "粘贴(&V)";
            this.EditPaste.Click += new System.EventHandler(this.EditPaste_Click);
            // 
            // EditTimeDate
            // 
            this.EditTimeDate.Name = "EditTimeDate";
            this.EditTimeDate.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.EditTimeDate.Size = new System.Drawing.Size(192, 22);
            this.EditTimeDate.Text = "时间/日期(&D)";
            this.EditTimeDate.Click += new System.EventHandler(this.EditTimeDate_Click);
            // 
            // Choice
            // 
            this.Choice.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChoiceFont,
            this.ChoiceBackClor,
            this.ChoiceForeColor});
            this.Choice.Name = "Choice";
            this.Choice.Size = new System.Drawing.Size(60, 21);
            this.Choice.Text = "选项(&C)";
            // 
            // ChoiceFont
            // 
            this.ChoiceFont.Name = "ChoiceFont";
            this.ChoiceFont.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.ChoiceFont.Size = new System.Drawing.Size(157, 22);
            this.ChoiceFont.Text = "字体(&F)";
            this.ChoiceFont.Click += new System.EventHandler(this.ChoiceFont_Click);
            // 
            // ChoiceBackClor
            // 
            this.ChoiceBackClor.Name = "ChoiceBackClor";
            this.ChoiceBackClor.Size = new System.Drawing.Size(157, 22);
            this.ChoiceBackClor.Text = "背景色(&B)";
            this.ChoiceBackClor.Click += new System.EventHandler(this.ChoiceBack_Click);
            // 
            // ChoiceForeColor
            // 
            this.ChoiceForeColor.Name = "ChoiceForeColor";
            this.ChoiceForeColor.Size = new System.Drawing.Size(157, 22);
            this.ChoiceForeColor.Text = "字体颜色(&Z)";
            this.ChoiceForeColor.Click += new System.EventHandler(this.ChoiceForeColor_Click);
            // 
            // Help
            // 
            this.Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HelpAbout});
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(61, 21);
            this.Help.Text = "帮助(&H)";
            this.Help.Click += new System.EventHandler(this.Help_Click);
            // 
            // HelpAbout
            // 
            this.HelpAbout.Name = "HelpAbout";
            this.HelpAbout.Size = new System.Drawing.Size(152, 22);
            this.HelpAbout.Text = "关于记事本(&A)";
            this.HelpAbout.Click += new System.EventHandler(this.HelpAbout_Click);
            // 
            // tbTextArea
            // 
            this.tbTextArea.Location = new System.Drawing.Point(12, 40);
            this.tbTextArea.Multiline = true;
            this.tbTextArea.Name = "tbTextArea";
            this.tbTextArea.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbTextArea.Size = new System.Drawing.Size(465, 299);
            this.tbTextArea.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(543, 361);
            this.Controls.Add(this.tbTextArea);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.ToolStripMenuItem FileNew;
        private System.Windows.Forms.ToolStripMenuItem FileOpen;
        private System.Windows.Forms.ToolStripMenuItem FileSave;
        private System.Windows.Forms.ToolStripMenuItem FileSaveAs;
        private System.Windows.Forms.ToolStripMenuItem FileExit;
        private System.Windows.Forms.ToolStripMenuItem Edit;
        private System.Windows.Forms.ToolStripMenuItem EditUndo;
        private System.Windows.Forms.ToolStripMenuItem EditCut;
        private System.Windows.Forms.ToolStripMenuItem EditCopy;
        private System.Windows.Forms.ToolStripMenuItem EditPaste;
        private System.Windows.Forms.ToolStripMenuItem Choice;
        private System.Windows.Forms.ToolStripMenuItem ChoiceFont;
        private System.Windows.Forms.ToolStripMenuItem ChoiceBackClor;
        private System.Windows.Forms.ToolStripMenuItem ChoiceForeColor;
        private System.Windows.Forms.ToolStripMenuItem Help;
        private System.Windows.Forms.ToolStripMenuItem HelpAbout;
        private System.Windows.Forms.TextBox tbTextArea;
        private System.Windows.Forms.ToolStripMenuItem EditTimeDate;
    }
}

