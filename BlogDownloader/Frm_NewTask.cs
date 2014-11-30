using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;

using System.Web;

namespace BlogDownloader
{
    public partial class Frm_NewTask : Form
    {
        private string m_strSiteName = "";
        private string m_strTaskName = "";
        private string m_strBlogID = "";
        private string m_strDBFolder = Application.StartupPath + @"\WebSiteDB\";
        
 
        public Frm_NewTask()
        {
            InitializeComponent();
        }
        public Frm_NewTask(string strSiteName, string strBlogID)
        {
            m_strSiteName = strSiteName;
            InitializeComponent();
            m_strBlogID = strBlogID;

        }
        public string GetTaskName()
        {
            return m_strTaskName;
        }
        public string GetBlogID()
        {
            return m_strBlogID;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (m_strBlogID != "")
            {
                this.Close();
                this.DialogResult = DialogResult.Abort;
                return;
            }

            string strTitle = this.textBoxTaskName.Text;

            List<string> lstDBNames = new List<string>();
            DirectoryInfo TheFolder = new DirectoryInfo(m_strDBFolder);
            foreach (FileInfo NextFile in TheFolder.GetFiles())
            {

                string strConStringTemp = m_strDBFolder + NextFile.Name;
                lstDBNames.Add(strConStringTemp);
            }

            if (lstDBNames.Contains(this.textBoxTaskName.Text))
            {
                MessageBox.Show("同名任务已存在，请重命名任务!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            m_strBlogID = this.textBoxTaskName.Text;
            m_strTaskName = strTitle;
            this.Close();
            this.DialogResult = DialogResult.OK;
        }

        private void Frm_NewTask_Load(object sender, EventArgs e)
        {

            if (m_strBlogID != "")
            {
                this.textBoxTaskName.ReadOnly = true;
                this.textBoxTaskName.Text = m_strBlogID;
            }
            
            this.Text = m_strSiteName;

        }

        private void textBoxTaskName_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.Abort;
            return;
        }
    }
}
