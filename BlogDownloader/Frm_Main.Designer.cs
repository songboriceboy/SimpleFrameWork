namespace BlogDownloader
{
    partial class Frm_Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Main));
            WeifenLuo.WinFormsUI.Docking.DockPanelSkin dockPanelSkin1 = new WeifenLuo.WinFormsUI.Docking.DockPanelSkin();
            WeifenLuo.WinFormsUI.Docking.AutoHideStripSkin autoHideStripSkin1 = new WeifenLuo.WinFormsUI.Docking.AutoHideStripSkin();
            WeifenLuo.WinFormsUI.Docking.DockPanelGradient dockPanelGradient1 = new WeifenLuo.WinFormsUI.Docking.DockPanelGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient1 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.DockPaneStripSkin dockPaneStripSkin1 = new WeifenLuo.WinFormsUI.Docking.DockPaneStripSkin();
            WeifenLuo.WinFormsUI.Docking.DockPaneStripGradient dockPaneStripGradient1 = new WeifenLuo.WinFormsUI.Docking.DockPaneStripGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient2 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.DockPanelGradient dockPanelGradient2 = new WeifenLuo.WinFormsUI.Docking.DockPanelGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient3 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.DockPaneStripToolWindowGradient dockPaneStripToolWindowGradient1 = new WeifenLuo.WinFormsUI.Docking.DockPaneStripToolWindowGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient4 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient5 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.DockPanelGradient dockPanelGradient3 = new WeifenLuo.WinFormsUI.Docking.DockPanelGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient6 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient7 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            this.panelTreeViewContainer = new System.Windows.Forms.Panel();
            this.treeViewTask = new System.Windows.Forms.TreeView();
            this.contextMenuStripBlogChild = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除任务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.dockPanel1 = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripExit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.退出程序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripBlog = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timerCheckAccess = new System.Windows.Forms.Timer(this.components);
            this.toolStripButtonShowAllTask = new System.Windows.Forms.ToolStripButton();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.toolStripDropDownButtonHelp = new System.Windows.Forms.ToolStripDropDownButton();
            this.帮助手册ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButtonTip = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonTuiGuang = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.panelTreeViewContainer.SuspendLayout();
            this.contextMenuStripBlogChild.SuspendLayout();
            this.contextMenuStripExit.SuspendLayout();
            this.contextMenuStripBlog.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTreeViewContainer
            // 
            this.panelTreeViewContainer.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelTreeViewContainer.Controls.Add(this.treeViewTask);
            this.panelTreeViewContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTreeViewContainer.Location = new System.Drawing.Point(0, 39);
            this.panelTreeViewContainer.Name = "panelTreeViewContainer";
            this.panelTreeViewContainer.Size = new System.Drawing.Size(223, 620);
            this.panelTreeViewContainer.TabIndex = 1;
            // 
            // treeViewTask
            // 
            this.treeViewTask.ContextMenuStrip = this.contextMenuStripBlogChild;
            this.treeViewTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewTask.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeViewTask.ImageIndex = 0;
            this.treeViewTask.ImageList = this.imageList1;
            this.treeViewTask.ItemHeight = 20;
            this.treeViewTask.Location = new System.Drawing.Point(0, 0);
            this.treeViewTask.Name = "treeViewTask";
            this.treeViewTask.SelectedImageIndex = 0;
            this.treeViewTask.Size = new System.Drawing.Size(223, 620);
            this.treeViewTask.TabIndex = 0;
            this.treeViewTask.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.treeViewTask_MouseDoubleClick);
            this.treeViewTask.MouseClick += new System.Windows.Forms.MouseEventHandler(this.treeViewTask_MouseClick);
            // 
            // contextMenuStripBlogChild
            // 
            this.contextMenuStripBlogChild.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除任务ToolStripMenuItem});
            this.contextMenuStripBlogChild.Name = "contextMenuStrip1";
            this.contextMenuStripBlogChild.Size = new System.Drawing.Size(125, 26);
            // 
            // 删除任务ToolStripMenuItem
            // 
            this.删除任务ToolStripMenuItem.Name = "删除任务ToolStripMenuItem";
            this.删除任务ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.删除任务ToolStripMenuItem.Text = "删除博客";
            this.删除任务ToolStripMenuItem.Click += new System.EventHandler(this.删除任务ToolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "generic_folder.png");
            this.imageList1.Images.SetKeyName(1, "id.png");
            this.imageList1.Images.SetKeyName(2, "iso.gif");
            this.imageList1.Images.SetKeyName(3, "category.png");
            this.imageList1.Images.SetKeyName(4, "folder_smart.png");
            this.imageList1.Images.SetKeyName(5, "universal.png");
            this.imageList1.Images.SetKeyName(6, "new_doc.png");
            this.imageList1.Images.SetKeyName(7, "document_library.png");
            this.imageList1.Images.SetKeyName(8, "new_archive.png");
            this.imageList1.Images.SetKeyName(9, "address.png");
            this.imageList1.Images.SetKeyName(10, "txt.gif");
            this.imageList1.Images.SetKeyName(11, "wenjianjia.gif");
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(223, 39);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 620);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // dockPanel1
            // 
            this.dockPanel1.ActiveAutoHideContent = null;
            this.dockPanel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dockPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockPanel1.DockBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dockPanel1.Location = new System.Drawing.Point(226, 39);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.Size = new System.Drawing.Size(972, 620);
            dockPanelGradient1.EndColor = System.Drawing.SystemColors.ControlLight;
            dockPanelGradient1.StartColor = System.Drawing.SystemColors.ControlLight;
            autoHideStripSkin1.DockStripGradient = dockPanelGradient1;
            tabGradient1.EndColor = System.Drawing.SystemColors.Control;
            tabGradient1.StartColor = System.Drawing.SystemColors.Control;
            tabGradient1.TextColor = System.Drawing.SystemColors.ControlDarkDark;
            autoHideStripSkin1.TabGradient = tabGradient1;
            dockPanelSkin1.AutoHideStripSkin = autoHideStripSkin1;
            tabGradient2.EndColor = System.Drawing.SystemColors.ControlLightLight;
            tabGradient2.StartColor = System.Drawing.SystemColors.ControlLightLight;
            tabGradient2.TextColor = System.Drawing.SystemColors.ControlText;
            dockPaneStripGradient1.ActiveTabGradient = tabGradient2;
            dockPanelGradient2.EndColor = System.Drawing.SystemColors.Control;
            dockPanelGradient2.StartColor = System.Drawing.SystemColors.Control;
            dockPaneStripGradient1.DockStripGradient = dockPanelGradient2;
            tabGradient3.EndColor = System.Drawing.SystemColors.ControlLight;
            tabGradient3.StartColor = System.Drawing.SystemColors.ControlLight;
            tabGradient3.TextColor = System.Drawing.SystemColors.ControlText;
            dockPaneStripGradient1.InactiveTabGradient = tabGradient3;
            dockPaneStripSkin1.DocumentGradient = dockPaneStripGradient1;
            tabGradient4.EndColor = System.Drawing.SystemColors.ActiveCaption;
            tabGradient4.LinearGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            tabGradient4.StartColor = System.Drawing.SystemColors.GradientActiveCaption;
            tabGradient4.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            dockPaneStripToolWindowGradient1.ActiveCaptionGradient = tabGradient4;
            tabGradient5.EndColor = System.Drawing.SystemColors.Control;
            tabGradient5.StartColor = System.Drawing.SystemColors.Control;
            tabGradient5.TextColor = System.Drawing.SystemColors.ControlText;
            dockPaneStripToolWindowGradient1.ActiveTabGradient = tabGradient5;
            dockPanelGradient3.EndColor = System.Drawing.SystemColors.ControlLight;
            dockPanelGradient3.StartColor = System.Drawing.SystemColors.ControlLight;
            dockPaneStripToolWindowGradient1.DockStripGradient = dockPanelGradient3;
            tabGradient6.EndColor = System.Drawing.SystemColors.GradientInactiveCaption;
            tabGradient6.LinearGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            tabGradient6.StartColor = System.Drawing.SystemColors.GradientInactiveCaption;
            tabGradient6.TextColor = System.Drawing.SystemColors.ControlText;
            dockPaneStripToolWindowGradient1.InactiveCaptionGradient = tabGradient6;
            tabGradient7.EndColor = System.Drawing.Color.Transparent;
            tabGradient7.StartColor = System.Drawing.Color.Transparent;
            tabGradient7.TextColor = System.Drawing.SystemColors.ControlDarkDark;
            dockPaneStripToolWindowGradient1.InactiveTabGradient = tabGradient7;
            dockPaneStripSkin1.ToolWindowGradient = dockPaneStripToolWindowGradient1;
            dockPanelSkin1.DockPaneStripSkin = dockPaneStripSkin1;
            this.dockPanel1.Skin = dockPanelSkin1;
            this.dockPanel1.TabIndex = 3;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStripExit;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStripExit
            // 
            this.contextMenuStripExit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.退出程序ToolStripMenuItem});
            this.contextMenuStripExit.Name = "contextMenuStripExit";
            this.contextMenuStripExit.Size = new System.Drawing.Size(125, 26);
            // 
            // 退出程序ToolStripMenuItem
            // 
            this.退出程序ToolStripMenuItem.Name = "退出程序ToolStripMenuItem";
            this.退出程序ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.退出程序ToolStripMenuItem.Text = "退出程序";
            this.退出程序ToolStripMenuItem.Click += new System.EventHandler(this.退出程序ToolStripMenuItem_Click);
            // 
            // contextMenuStripBlog
            // 
            this.contextMenuStripBlog.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStripBlog.Name = "contextMenuStripSite";
            this.contextMenuStripBlog.Size = new System.Drawing.Size(153, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem1.Text = "新增博客";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timerCheckAccess
            // 
            this.timerCheckAccess.Interval = 60000;
            // 
            // toolStripButtonShowAllTask
            // 
            this.toolStripButtonShowAllTask.Image = global::BlogDownloader.Properties.Resources.ToolStripControl;
            this.toolStripButtonShowAllTask.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonShowAllTask.Name = "toolStripButtonShowAllTask";
            this.toolStripButtonShowAllTask.Size = new System.Drawing.Size(105, 28);
            this.toolStripButtonShowAllTask.Text = "显示任务配置";
            // 
            // toolStripDropDownButtonHelp
            // 
            this.toolStripDropDownButtonHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.帮助手册ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.toolStripDropDownButtonHelp.Image = global::BlogDownloader.Properties.Resources.help_browser;
            this.toolStripDropDownButtonHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonHelp.Name = "toolStripDropDownButtonHelp";
            this.toolStripDropDownButtonHelp.Size = new System.Drawing.Size(77, 36);
            this.toolStripDropDownButtonHelp.Text = "帮助";
            // 
            // 帮助手册ToolStripMenuItem
            // 
            this.帮助手册ToolStripMenuItem.Name = "帮助手册ToolStripMenuItem";
            this.帮助手册ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.帮助手册ToolStripMenuItem.Text = "帮助手册";
            this.帮助手册ToolStripMenuItem.Click += new System.EventHandler(this.帮助手册ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.关于ToolStripMenuItem.Text = "关于...";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // toolStripButtonTip
            // 
            this.toolStripButtonTip.Image = global::BlogDownloader.Properties.Resources.home;
            this.toolStripButtonTip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonTip.Name = "toolStripButtonTip";
            this.toolStripButtonTip.Size = new System.Drawing.Size(92, 36);
            this.toolStripButtonTip.Text = "温馨提示";
            this.toolStripButtonTip.Click += new System.EventHandler(this.toolStripButtonTip_Click);
            // 
            // toolStripButtonTuiGuang
            // 
            this.toolStripButtonTuiGuang.Image = global::BlogDownloader.Properties.Resources.flag;
            this.toolStripButtonTuiGuang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonTuiGuang.Name = "toolStripButtonTuiGuang";
            this.toolStripButtonTuiGuang.Size = new System.Drawing.Size(92, 36);
            this.toolStripButtonTuiGuang.Text = "退出系统";
            this.toolStripButtonTuiGuang.Click += new System.EventHandler(this.toolStripButtonTuiGuang_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButtonHelp,
            this.toolStripButtonTip,
            this.toolStripButtonTuiGuang});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1198, 39);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 659);
            this.Controls.Add(this.dockPanel1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panelTreeViewContainer);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Frm_Main";
            this.Text = "豆约翰博客备份专家";
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            this.panelTreeViewContainer.ResumeLayout(false);
            this.contextMenuStripBlogChild.ResumeLayout(false);
            this.contextMenuStripExit.ResumeLayout(false);
            this.contextMenuStripBlog.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTreeViewContainer;
        private System.Windows.Forms.TreeView treeViewTask;
        private System.Windows.Forms.Splitter splitter1;
        private WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel1;
        private System.Windows.Forms.ToolStripButton toolStripButtonShowAllTask;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripBlogChild;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem 删除任务ToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripExit;
        private System.Windows.Forms.ToolStripMenuItem 退出程序ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripBlog;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timerCheckAccess;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonHelp;
        private System.Windows.Forms.ToolStripMenuItem 帮助手册ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonTip;
        private System.Windows.Forms.ToolStripButton toolStripButtonTuiGuang;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}

