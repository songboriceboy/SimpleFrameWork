using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Net;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Web;
using mshtml;
using WeifenLuo.WinFormsUI.Docking;

using System.Xml.Linq;
using System.Xml;

namespace BlogDownloader
{
    public partial class Frm_TargetUrlView : DockContent
    {

        private Frm_Main m_mainFrm = null;
        private int m_nLayerID = -1;
        private string m_strWholeDbName = "";
        private DYH_DB.BLL.AU_LayerNode m_bllAU_LayerNode = new DYH_DB.BLL.AU_LayerNode();

        private string m_strFormName = "";
        private string m_strSiteName = "";

        public Frm_TargetUrlView()
        {
            InitializeComponent();
        }

        public Frm_TargetUrlView(string strSiteName, string strWholeDbName, string strFormName, Frm_Main mainFrm)
        {
            InitializeComponent();
            m_strSiteName = strSiteName;
            m_strFormName = strFormName;
            m_strWholeDbName = strWholeDbName;
            m_mainFrm = mainFrm;
          
        }
        public Frm_TargetUrlView(string strWholeDbName)
        {
            InitializeComponent();
            m_strWholeDbName = strWholeDbName;
        }
     
        private void ShowAllRecordInDataGridView()
        {
            dataGridViewUrlList.DataSource = null;
            DataSet ds = m_bllAU_LayerNode.GetList(m_strWholeDbName, "");
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dataGridViewUrlList.DataSource = ds.Tables[0];
                dataGridViewUrlList.Columns[0].Visible = false;
                dataGridViewUrlList.Columns[1].Visible = false;
                dataGridViewUrlList.Columns[2].Visible = false;

             
                dataGridViewUrlList.Columns[6].Visible = false;
                dataGridViewUrlList.Columns[7].Visible = false;
                dataGridViewUrlList.Columns[8].Visible = false;
                dataGridViewUrlList.Columns[9].Visible = false;
                dataGridViewUrlList.Columns[10].Visible = false;
                dataGridViewUrlList.Columns[11].Visible = false;
                this.dataGridViewUrlList.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void Frm_TargetUrlView_Load(object sender, EventArgs e)
        {
            if (m_strWholeDbName != "")
            {
              
                ShowAllRecordInDataGridView();
                this.Text = m_strFormName;
            }

        }

        private void dataGridViewUrlList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            string strLayerID = this.dataGridViewUrlList.Rows[this.dataGridViewUrlList.CurrentCell.RowIndex].Cells["AU_LayerNodeID"].Value.ToString();

            m_nLayerID = Convert.ToInt32(strLayerID, 10);
        }

        private void dataGridViewUrlList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            {
                using (SolidBrush b = new SolidBrush(dataGridViewUrlList.RowHeadersDefaultCellStyle.ForeColor))
                {
                    e.Graphics.DrawString((e.RowIndex + 1).ToString(System.Globalization.CultureInfo.CurrentUICulture), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
                }
            }
        }


        private string GetFileSavedPath(string strFileType)
        {
            return m_strWholeDbName.Substring(12, m_strWholeDbName.Length - 15).Replace("WebSiteDB", strFileType);
        }


        private void Frm_TargetUrlView_FormClosed(object sender, FormClosedEventArgs e)
        {
           
            m_bllAU_LayerNode.ReleaseSQLiteConnection(m_strWholeDbName);
        }
 
    }
}
