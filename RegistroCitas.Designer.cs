namespace SACM_2
{
    partial class RegistroCitas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_departamento = new System.Windows.Forms.ComboBox();
            this.dtp_fechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.dtg_registroCitas = new System.Windows.Forms.DataGridView();
            this.tipoDeCitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroTelefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.confirmacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spMostrarRegistrosDeparBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_imDepar = new SACM_2.DataSet_imDepar();
            this.btn_volver = new System.Windows.Forms.Button();
            this.btn_buscarRegistro = new System.Windows.Forms.Button();
            this.btnImprimirRegistro = new System.Windows.Forms.Button();
            this.spMostrarRegistrosDeparBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_MostrarRegistrosDeparTableAdapter = new SACM_2.DataSet_imDeparTableAdapters.sp_MostrarRegistrosDeparTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_registroCitas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spMostrarRegistrosDeparBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_imDepar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spMostrarRegistrosDeparBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Departamento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(369, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha";
            // 
            // cb_departamento
            // 
            this.cb_departamento.FormattingEnabled = true;
            this.cb_departamento.Items.AddRange(new object[] {
            "Medicina General",
            "Pediatria",
            "Dental",
            "Nutricion",
            "Psicologo",
            "Laboratorio",
            "Traumatologia"});
            this.cb_departamento.Location = new System.Drawing.Point(129, 30);
            this.cb_departamento.Margin = new System.Windows.Forms.Padding(5);
            this.cb_departamento.Name = "cb_departamento";
            this.cb_departamento.Size = new System.Drawing.Size(198, 27);
            this.cb_departamento.TabIndex = 19;
            // 
            // dtp_fechaRegistro
            // 
            this.dtp_fechaRegistro.Location = new System.Drawing.Point(433, 29);
            this.dtp_fechaRegistro.Margin = new System.Windows.Forms.Padding(5);
            this.dtp_fechaRegistro.Name = "dtp_fechaRegistro";
            this.dtp_fechaRegistro.Size = new System.Drawing.Size(262, 27);
            this.dtp_fechaRegistro.TabIndex = 20;
            // 
            // dtg_registroCitas
            // 
            this.dtg_registroCitas.AutoGenerateColumns = false;
            this.dtg_registroCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_registroCitas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tipoDeCitaDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.numeroTelefonoDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.confirmacionDataGridViewTextBoxColumn});
            this.dtg_registroCitas.DataSource = this.spMostrarRegistrosDeparBindingSource1;
            this.dtg_registroCitas.Location = new System.Drawing.Point(14, 91);
            this.dtg_registroCitas.Margin = new System.Windows.Forms.Padding(5);
            this.dtg_registroCitas.Name = "dtg_registroCitas";
            this.dtg_registroCitas.RowHeadersWidth = 51;
            this.dtg_registroCitas.Size = new System.Drawing.Size(679, 179);
            this.dtg_registroCitas.TabIndex = 21;
            // 
            // tipoDeCitaDataGridViewTextBoxColumn
            // 
            this.tipoDeCitaDataGridViewTextBoxColumn.DataPropertyName = "TipoDeCita";
            this.tipoDeCitaDataGridViewTextBoxColumn.HeaderText = "TipoDeCita";
            this.tipoDeCitaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tipoDeCitaDataGridViewTextBoxColumn.Name = "tipoDeCitaDataGridViewTextBoxColumn";
            this.tipoDeCitaDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.Width = 125;
            // 
            // numeroTelefonoDataGridViewTextBoxColumn
            // 
            this.numeroTelefonoDataGridViewTextBoxColumn.DataPropertyName = "NumeroTelefono";
            this.numeroTelefonoDataGridViewTextBoxColumn.HeaderText = "NumeroTelefono";
            this.numeroTelefonoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numeroTelefonoDataGridViewTextBoxColumn.Name = "numeroTelefonoDataGridViewTextBoxColumn";
            this.numeroTelefonoDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.Width = 125;
            // 
            // confirmacionDataGridViewTextBoxColumn
            // 
            this.confirmacionDataGridViewTextBoxColumn.DataPropertyName = "Confirmacion";
            this.confirmacionDataGridViewTextBoxColumn.HeaderText = "Confirmacion";
            this.confirmacionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.confirmacionDataGridViewTextBoxColumn.Name = "confirmacionDataGridViewTextBoxColumn";
            this.confirmacionDataGridViewTextBoxColumn.Width = 125;
            // 
            // spMostrarRegistrosDeparBindingSource1
            // 
            this.spMostrarRegistrosDeparBindingSource1.DataMember = "sp_MostrarRegistrosDepar";
            this.spMostrarRegistrosDeparBindingSource1.DataSource = this.dataSet_imDepar;
            // 
            // dataSet_imDepar
            // 
            this.dataSet_imDepar.DataSetName = "DataSet_imDepar";
            this.dataSet_imDepar.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_volver
            // 
            this.btn_volver.Location = new System.Drawing.Point(575, 301);
            this.btn_volver.Margin = new System.Windows.Forms.Padding(5);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(120, 40);
            this.btn_volver.TabIndex = 22;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // btn_buscarRegistro
            // 
            this.btn_buscarRegistro.Location = new System.Drawing.Point(14, 301);
            this.btn_buscarRegistro.Margin = new System.Windows.Forms.Padding(5);
            this.btn_buscarRegistro.Name = "btn_buscarRegistro";
            this.btn_buscarRegistro.Size = new System.Drawing.Size(120, 40);
            this.btn_buscarRegistro.TabIndex = 23;
            this.btn_buscarRegistro.Text = "Buscar";
            this.btn_buscarRegistro.UseVisualStyleBackColor = true;
            this.btn_buscarRegistro.Click += new System.EventHandler(this.btn_buscarRegistro_Click);
            // 
            // btnImprimirRegistro
            // 
            this.btnImprimirRegistro.Location = new System.Drawing.Point(275, 301);
            this.btnImprimirRegistro.Margin = new System.Windows.Forms.Padding(2);
            this.btnImprimirRegistro.Name = "btnImprimirRegistro";
            this.btnImprimirRegistro.Size = new System.Drawing.Size(154, 40);
            this.btnImprimirRegistro.TabIndex = 24;
            this.btnImprimirRegistro.Text = "Imprimir Registro";
            this.btnImprimirRegistro.UseVisualStyleBackColor = true;
            this.btnImprimirRegistro.Click += new System.EventHandler(this.btnImprimirRegistro_Click);
            // 
            // spMostrarRegistrosDeparBindingSource
            // 
            this.spMostrarRegistrosDeparBindingSource.DataMember = "sp_MostrarRegistrosDepar";
            // 
            // sp_MostrarRegistrosDeparTableAdapter
            // 
            this.sp_MostrarRegistrosDeparTableAdapter.ClearBeforeFill = true;
            // 
            // RegistroCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(707, 380);
            this.ControlBox = false;
            this.Controls.Add(this.btnImprimirRegistro);
            this.Controls.Add(this.btn_buscarRegistro);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.dtg_registroCitas);
            this.Controls.Add(this.dtp_fechaRegistro);
            this.Controls.Add(this.cb_departamento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "RegistroCitas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistroCitas";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_registroCitas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spMostrarRegistrosDeparBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_imDepar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spMostrarRegistrosDeparBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_departamento;
        private System.Windows.Forms.DateTimePicker dtp_fechaRegistro;
        private System.Windows.Forms.DataGridView dtg_registroCitas;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Button btn_buscarRegistro;
        private System.Windows.Forms.Button btnImprimirRegistro;
        private System.Windows.Forms.BindingSource spMostrarRegistrosDeparBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDeCitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroTelefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn confirmacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource spMostrarRegistrosDeparBindingSource1;
        private DataSet_imDepar dataSet_imDepar;
        private DataSet_imDeparTableAdapters.sp_MostrarRegistrosDeparTableAdapter sp_MostrarRegistrosDeparTableAdapter;
    }
}