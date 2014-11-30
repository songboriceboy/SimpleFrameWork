using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Collections;
using System.Web;
using System.Xml;
using System.Net;
using System.Configuration;
using WeifenLuo.WinFormsUI.Docking;
using System.Xml.Serialization;
using System.Threading;
using System.Net.Sockets;
using System.Diagnostics;

namespace BlogDownloader
{     
    public partial class Frm_Main : Form
    {

        private DYH_DB.BLL.AU_LayerNode m_bllAU_LayerNode = new DYH_DB.BLL.AU_LayerNode();
        private string m_strDBConStringPath = @"Data Source=" + Application.StartupPath + @"\WebSiteDB\";
        private string m_strDBFolder = Application.StartupPath + @"\WebSiteDB\";
        private Cls_SqliteMng m_sqliteMng = new Cls_SqliteMng();
        private string m_strTreeNodeName = "";
        string m_connStr1 = @"Data Source=" + Application.StartupPath + @"\WebSiteDB\";
        string m_connStr2 = @";Initial Catalog=sqlite;Integrated Security=True;Max Pool Size=10";
        string m_strCreatTable = @"--1-2 层节点表(AU_LayerNode)
drop table if exists [AU_LayerNode];
CREATE TABLE AU_LayerNode(
	AU_LayerNodeID         		INT NOT NULL PRIMARY KEY,
	AU_ParentLayerNodeID		INT NOT NULL DEFAULT 0,
	AU_UrlAddress		  	VARCHAR(1000) NOT NULL DEFAULT '',
	AU_UrlTitle	  		NVARCHAR(1000) NOT NULL DEFAULT '',
	AU_UrlContent			NTEXT NOT NULL DEFAULT '', 
	AU_UrlLayer	           	INT NOT NULL DEFAULT 0,	
	AU_IsVisit	           	INT NOT NULL DEFAULT 0,	
	AU_RemoveSameOffset1  		INT NOT NULL DEFAULT 0, 
	AU_RemoveSameOffset2  		INT NOT NULL DEFAULT 0, 
	AU_LastUpdateDate	   	DATETIME  NOT NULL DEFAULT '2012-01-01',


	AU_ReserveInt1			INT NOT NULL DEFAULT 0,
	AU_ReserveInt2			INT NOT NULL DEFAULT 0,
	AU_ReserveInt3			INT NOT NULL DEFAULT 0,
	AU_ReserveInt4			INT NOT NULL DEFAULT 0,
	AU_ReserveInt5			INT NOT NULL DEFAULT 0,
	AU_ReserveInt6			INT NOT NULL DEFAULT 0,
	AU_ReserveInt7			INT NOT NULL DEFAULT 0,
	AU_ReserveInt8			INT NOT NULL DEFAULT 0,


	AU_ReserveStr1		  	VARCHAR(1000) NOT NULL DEFAULT '',
	AU_ReserveStr2		  	VARCHAR(1000) NOT NULL DEFAULT '',
	AU_ReserveNStr1		  	NVARCHAR(1000) NOT NULL DEFAULT '',
	AU_ReserveNStr2		  	NVARCHAR(1000) NOT NULL DEFAULT '',

	AU_ReserveTEXT1		  	TEXT NOT NULL DEFAULT '',
	AU_ReserveTEXT2		  	TEXT NOT NULL DEFAULT '',
	AU_ReserveTEXT3		  	TEXT NOT NULL DEFAULT '',
	AU_ReserveNTEXT1		NTEXT NOT NULL DEFAULT '',
	AU_ReserveNTEXT2		NTEXT NOT NULL DEFAULT '',
	AU_ReserveNTEXT3		NTEXT NOT NULL DEFAULT '',

	AU_ReserveDateTime1	   	DATETIME  NOT NULL DEFAULT '2012-01-01',
	AU_ReserveDateTime2	   	DATETIME  NOT NULL DEFAULT '2012-01-01',
	AU_ReserveDateTime3	   	DATETIME  NOT NULL DEFAULT '2012-01-01',
	AU_ReserveDateTime4	   	DATETIME  NOT NULL DEFAULT '2012-01-01',

	AU_ReserveDecmial1		DECIMAL NOT NULL DEFAULT 0,
	AU_ReserveDecmial2		DECIMAL NOT NULL DEFAULT 0
);

";
        private string m_strInsertTaskInitData = @"insert into [AU_LayerNode] values(0, 0, '#^$BlogID$^#','a test string', '', 0, 0, 0, 0
         , '2012-01-01', 0, 0, 0, 0, 0, 1, 1, 0,'', '','测试分类', '','', '','', '','', '', '2012-01-01', '2012-01-01', '2012-01-01', '2012-01-01', 1, 0)";
   
        public Frm_Main()
        {
            InitializeComponent();
        }

        private DockContent FindDocument(string text)
        {
            if (dockPanel1.DocumentStyle == DocumentStyle.DockingMdi)
            {
                foreach (Form form in MdiChildren)
                {
                    if (form.Text == text)
                    {
                        return form as DockContent;
                    }
                }

                return null;
            }
            else
            {
                foreach (DockContent content in dockPanel1.Documents)
                {
                    if (content.DockHandler.TabText == text)
                    {
                        return content;
                    }
                }

                return null;
            }
        }

        public bool IsWindowOpen(string caption)
        {

            DockContent frm = FindDocument(caption);

            if (frm == null)
            {
                

                return false;
            }
            else
            {
                if (frm.IsHidden == true)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        private void ShowHomePage(string strCaption)
        {
            DockContent frm = FindDocument(strCaption);
            if (frm == null)
            {
                Frm_TargetUrlView frm_TargetUrlView = new Frm_TargetUrlView("", m_strDBConStringPath + "home.db", strCaption, this);
                frm_TargetUrlView.MdiParent = this;
                frm_TargetUrlView.WindowState = FormWindowState.Maximized;
                frm_TargetUrlView.Show(this.dockPanel1);
                frm_TargetUrlView.Focus();
                frm_TargetUrlView.BringToFront();
                return;
            }
            frm.Show(this.dockPanel1);
            frm.Focus();
            frm.BringToFront();
            return;
        }


        public DockContent ShowContent(string caption/*, Type formType*/)
        {

            DockContent frm = FindDocument(caption);

            if (frm == null)
            {
                Frm_TargetUrlView frm_TargetUrlView = new Frm_TargetUrlView((string)this.treeViewTask.SelectedNode.Parent.Text
                    , m_strDBConStringPath + m_strTreeNodeName
               ,  (string)this.treeViewTask.SelectedNode.Text, this);
                frm_TargetUrlView.MdiParent = this;
                frm_TargetUrlView.WindowState = FormWindowState.Maximized;
                frm_TargetUrlView.Show(this.dockPanel1);
                frm_TargetUrlView.Focus();
                frm_TargetUrlView.BringToFront();
                return frm_TargetUrlView;
            }

            frm.Show(this.dockPanel1);
            frm.Focus();
            frm.BringToFront();
            return frm;
        }

        private void GetSubDirectoryNodes(TreeNode parentNode, string fullName, bool getFileNames)
        {
            if (!Directory.Exists(fullName))
            {
                Directory.CreateDirectory(fullName);
            }
            DirectoryInfo dir = new DirectoryInfo(fullName);
            DirectoryInfo[] dirSubs = dir.GetDirectories();

            // 为每个子目录添加一个子节点
            foreach (DirectoryInfo dirSub in dirSubs)
            {
                // 不显示隐藏文件夹
                if ((dirSub.Attributes & FileAttributes.Hidden) != 0)
                {
                    continue;
                }

               
                TreeNode node = new TreeNode();
                node.Text = dirSub.Name;

                node.Tag = 0;
                node.ImageIndex = 0;
                parentNode.Nodes.Add(node);

                // 递归调用
                GetSubDirectoryNodes(node, dirSub.FullName, getFileNames);
             

            }
            // 为每个子目录添加一个子节点
            foreach (DirectoryInfo dirSub in dirSubs)
            {
                // 不显示隐藏文件夹
                if ((dirSub.Attributes & FileAttributes.Hidden) != 0)
                {
                    continue;
                }

            }
            if (getFileNames) // 书中源码中，这部分在foreach内部，不正确
            {
                // 获取此节点的所有文件
                FileInfo[] files = dir.GetFiles();

                // 放置节点后。放置子目录中的文件。
                foreach (FileInfo file in files)
                {
                    if (file.Extension.ToString() != ".db")
                        continue;
                    string strNodeName = file.Name.Remove(file.Name.Length - 3, 3);
                    if (strNodeName == "home")
                        continue;
                    
                    TreeNode node = new TreeNode();
                    node.Text = strNodeName;

                    node.Tag = 1;
                    node.ImageIndex = 1;
                    parentNode.Nodes.Add(node);
                }
            }
        }  

        private void LoadWebSiteTree()
        {

            this.treeViewTask.Nodes.Clear();

            TreeNode nodeRoot = new TreeNode();
            nodeRoot.Text = "站点列表";
            nodeRoot.Tag = -1;
            this.treeViewTask.Nodes.Add(nodeRoot);


            GetSubDirectoryNodes(nodeRoot, m_strDBFolder,true);

            this.treeViewTask.SelectedNode = this.treeViewTask.TopNode;
           
        }
 
        private void Frm_Main_Load(object sender, EventArgs e)
        {
              
                LoadWebSiteTree();
                this.treeViewTask.ExpandAll();
                ShowHomePage("温馨提示");
     
        }

        private void LoadInfoByNode()
        {
            if (this.treeViewTask.TopNode == this.treeViewTask.SelectedNode)
                return;
            m_strTreeNodeName = (string)this.treeViewTask.SelectedNode.Parent.Text + "\\" + (string)this.treeViewTask.SelectedNode.Text + ".db";
        }

         private void treeViewTask_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Point pos = new Point(e.X, e.Y);
            TreeNode nodeClick = this.treeViewTask.GetNodeAt(pos);
            if (nodeClick.Text == "站点列表")
            {

                this.treeViewTask.ContextMenuStrip = null;
                return;
            }
            if (nodeClick != null && e.Button == MouseButtons.Left)
            {
                int nTag = (int)nodeClick.Tag;
                if (nTag == 0)
                    return;
                this.treeViewTask.SelectedNode = nodeClick;

                LoadInfoByNode();

            }

            ShowContent(this.treeViewTask.SelectedNode.Text);
        }

         private void 删除任务ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((int)this.treeViewTask.SelectedNode.Tag != 1)
            {
                MessageBox.Show("不是博客用户节点，不能删除!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (IsWindowOpen(this.treeViewTask.SelectedNode.Text))
            {
                MessageBox.Show("请先关闭窗口!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (MessageBox.Show("确实要删除该节点!", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                string strPath = m_strDBFolder + this.treeViewTask.SelectedNode.Parent.Text + "\\" + this.treeViewTask.SelectedNode.Text + ".db";
                if (System.IO.File.Exists(strPath))
                    System.IO.File.Delete(strPath);
                this.treeViewTask.Nodes.Remove(this.treeViewTask.SelectedNode);
            }
        }

   
        private void 退出程序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.notifyIcon1.Visible = false;

            this.Close();
            Environment.Exit(1);//退出程序
        }

        private void notifyMenu_Show_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
                this.Show();
                this.BringToFront();
                this.Activate();
                this.Focus();
            }
            else
            {
                this.WindowState = FormWindowState.Minimized;
                this.Hide();
            }
        }
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            notifyMenu_Show_Click(sender, e);
        }

        private void toolStripButtonTip_Click(object sender, EventArgs e)
        {
            ShowHomePage("温馨提示");
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout f = new frmAbout();
            f.ShowDialog();
            f.Dispose();
        }

        private void 帮助手册ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.douyuehan.com/Common/Page/7.aspx"); 
        }

        private void treeViewTask_MouseClick(object sender, MouseEventArgs e)
        {
            Point pos = new Point(e.X, e.Y);
            TreeNode nodeClick = this.treeViewTask.GetNodeAt(pos);
            if (nodeClick.Text == "站点列表")
            {
                
                this.treeViewTask.ContextMenuStrip = null;
                return;
            }
            
            if (nodeClick != null && e.Button == MouseButtons.Right && (int)nodeClick.Tag == 0)
            {
                int nTag = (int)nodeClick.Tag;
                //if (nTag == 0)
                //    return;
                if (nTag != 0)
                    nodeClick.SelectedImageIndex = 2;
                this.treeViewTask.SelectedNode = nodeClick;

                LoadInfoByNode();
                this.treeViewTask.ContextMenuStrip = this.contextMenuStripBlog;
            }
            else if (nodeClick != null && e.Button == MouseButtons.Right)
            {
                int nTag = (int)nodeClick.Tag;

                if (nTag != 0)
                    nodeClick.SelectedImageIndex = 2;
                this.treeViewTask.SelectedNode = nodeClick;

                LoadInfoByNode();
                this.treeViewTask.ContextMenuStrip = this.contextMenuStripBlogChild;
            }
            else 
            {
                int nTag = (int)nodeClick.Tag;

                if (nTag != 0)
                    nodeClick.SelectedImageIndex = 2;
                this.treeViewTask.SelectedNode = nodeClick;

                LoadInfoByNode();
             
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if ((int)this.treeViewTask.SelectedNode.Tag != 0)
            {
                MessageBox.Show("不是根节点，不能增加博客!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Frm_NewTask frm_NewTask = new Frm_NewTask(this.treeViewTask.SelectedNode.Text, "");
            frm_NewTask.StartPosition = FormStartPosition.CenterScreen;
            DialogResult dr = frm_NewTask.ShowDialog();
            if (dr != DialogResult.OK)
                return;
            string strTemp = frm_NewTask.GetTaskName();
            string strBlogID = frm_NewTask.GetBlogID();
            TreeNode node = new TreeNode();
            node.Text = strTemp;
            node.Tag = 1;
            node.ImageIndex = 1;
            this.treeViewTask.SelectedNode.Nodes.Add(node);

            m_sqliteMng.CreateDB(m_strDBFolder + this.treeViewTask.SelectedNode.Text + "\\" + strTemp + ".db");
            m_sqliteMng.ExecuteSql(m_strCreatTable
                , m_connStr1 + this.treeViewTask.SelectedNode.Text + "\\" + strTemp + ".db" + m_connStr2);

            string strInsertTaskInitData = m_strInsertTaskInitData.Replace("#^$BlogID$^#", strBlogID);

            m_sqliteMng.ExecuteSql(strInsertTaskInitData
                , m_connStr1 + this.treeViewTask.SelectedNode.Text + "\\" + strTemp + ".db" + m_connStr2);
        }

   

        private void toolStripButtonTuiGuang_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(1);//退出程序
        }
    }
}
