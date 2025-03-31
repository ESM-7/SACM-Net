namespace SACM_2
{
    partial class fImprimirRegistros
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fImprimirRegistros));
            this.spMostrarRegistrosDeparBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_imDepar = new SACM_2.DataSet_imDepar();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_MostrarRegistrosDeparTableAdapter = new SACM_2.DataSet_imDeparTableAdapters.sp_MostrarRegistrosDeparTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regresarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.spMostrarRegistrosDeparBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_imDepar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // spMostrarRegistrosDeparBindingSource
            // 
            this.spMostrarRegistrosDeparBindingSource.DataMember = "sp_MostrarRegistrosDepar";
            this.spMostrarRegistrosDeparBindingSource.DataSource = this.dataSet_imDepar;
            // 
            // dataSet_imDepar
            // 
            this.dataSet_imDepar.DataSetName = "DataSet_imDepar";
            this.dataSet_imDepar.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetRegistros";
            reportDataSource1.Value = this.spMostrarRegistrosDeparBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SACM_2.ReportRegistroCitas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 31);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.ShowPrintButton = false;
            this.reportViewer1.Size = new System.Drawing.Size(1027, 602);
            this.reportViewer1.TabIndex = 0;
            // 
            // sp_MostrarRegistrosDeparTableAdapter
            // 
            this.sp_MostrarRegistrosDeparTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1027, 30);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regresarToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 26);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // regresarToolStripMenuItem
            // 
            this.regresarToolStripMenuItem.Name = "regresarToolStripMenuItem";
            this.regresarToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.regresarToolStripMenuItem.Text = "Regresar ";
            this.regresarToolStripMenuItem.Click += new System.EventHandler(this.regresarToolStripMenuItem_Click_1);
            // 
            // fImprimirRegistros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1027, 634);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fImprimirRegistros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fImprimirRegistros";
            this.Load += new System.EventHandler(this.fImprimirRegistros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spMostrarRegistrosDeparBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_imDepar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spMostrarRegistrosDeparBindingSource;
        private DataSet_imDepar dataSet_imDepar;
        private DataSet_imDeparTableAdapters.sp_MostrarRegistrosDeparTableAdapter sp_MostrarRegistrosDeparTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regresarToolStripMenuItem;
    }
}