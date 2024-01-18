namespace QuanLyCuaHangBanBanh
{
    partial class frmInHoaDon
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
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.crpHoaDon = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // crpHoaDon
            // 
            this.crpHoaDon.ActiveViewIndex = -1;
            this.crpHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crpHoaDon.Cursor = System.Windows.Forms.Cursors.Default;
            this.crpHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crpHoaDon.Location = new System.Drawing.Point(0, 0);
            this.crpHoaDon.Name = "crpHoaDon";
            this.crpHoaDon.Size = new System.Drawing.Size(926, 546);
            this.crpHoaDon.TabIndex = 0;
            this.crpHoaDon.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // frmInHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 546);
            this.Controls.Add(this.crpHoaDon);
            this.Name = "frmInHoaDon";
            this.Text = "Hóa Đơn";
            this.Load += new System.EventHandler(this.frmInHoaDon_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer crpHoaDon;
    }
}