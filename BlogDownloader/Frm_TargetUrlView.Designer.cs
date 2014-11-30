
namespace BlogDownloader
{
    partial class Frm_TargetUrlView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewUrlList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUrlList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUrlList
            // 
            this.dataGridViewUrlList.AllowUserToAddRows = false;
            this.dataGridViewUrlList.AllowUserToDeleteRows = false;
            this.dataGridViewUrlList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUrlList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUrlList.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewUrlList.Name = "dataGridViewUrlList";
            this.dataGridViewUrlList.ReadOnly = true;
            this.dataGridViewUrlList.RowTemplate.Height = 23;
            this.dataGridViewUrlList.Size = new System.Drawing.Size(663, 311);
            this.dataGridViewUrlList.TabIndex = 0;
            // 
            // Frm_TargetUrlView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 311);
            this.Controls.Add(this.dataGridViewUrlList);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "Frm_TargetUrlView";
            this.Text = "开始下载";
            this.Load += new System.EventHandler(this.Frm_TargetUrlView_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_TargetUrlView_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUrlList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUrlList;

    }
}