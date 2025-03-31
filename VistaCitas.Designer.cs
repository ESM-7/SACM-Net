namespace SACM_2
{
    partial class VistaCitas
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
            this.dgv_vistaCitas = new System.Windows.Forms.DataGridView();
            this.confirmacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDeCitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primerApellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.segundoApellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sintomasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enfermedadesPreviasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consumeMedicamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alergiasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDeCitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaDeCitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spMostrarInformacionCitaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cruzRojaPracticaDataSetImprimir = new SACM_2.cruzRojaPracticaDataSetImprimir();
            this.btn_eliminarCita = new System.Windows.Forms.Button();
            this.btn_cerrarRegresar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sp_MostrarInformacionCitaTableAdapter = new SACM_2.cruzRojaPracticaDataSetImprimirTableAdapters.sp_MostrarInformacionCitaTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vistaCitas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spMostrarInformacionCitaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cruzRojaPracticaDataSetImprimir)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_vistaCitas
            // 
            this.dgv_vistaCitas.AutoGenerateColumns = false;
            this.dgv_vistaCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vistaCitas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.confirmacionDataGridViewTextBoxColumn,
            this.iDDeCitaDataGridViewTextBoxColumn,
            this.departamentoDataGridViewTextBoxColumn,
            this.edadDataGridViewTextBoxColumn,
            this.nombresDataGridViewTextBoxColumn,
            this.primerApellidoDataGridViewTextBoxColumn,
            this.segundoApellidoDataGridViewTextBoxColumn,
            this.sintomasDataGridViewTextBoxColumn,
            this.enfermedadesPreviasDataGridViewTextBoxColumn,
            this.consumeMedicamentoDataGridViewTextBoxColumn,
            this.alergiasDataGridViewTextBoxColumn,
            this.fechaDeCitaDataGridViewTextBoxColumn,
            this.horaDeCitaDataGridViewTextBoxColumn});
            this.dgv_vistaCitas.DataSource = this.spMostrarInformacionCitaBindingSource;
            this.dgv_vistaCitas.Location = new System.Drawing.Point(7, 29);
            this.dgv_vistaCitas.Margin = new System.Windows.Forms.Padding(5);
            this.dgv_vistaCitas.Name = "dgv_vistaCitas";
            this.dgv_vistaCitas.ReadOnly = true;
            this.dgv_vistaCitas.RowHeadersWidth = 51;
            this.dgv_vistaCitas.Size = new System.Drawing.Size(1277, 378);
            this.dgv_vistaCitas.TabIndex = 0;
            this.dgv_vistaCitas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_vistaCitas_CellClick);
            // 
            // confirmacionDataGridViewTextBoxColumn
            // 
            this.confirmacionDataGridViewTextBoxColumn.DataPropertyName = "Confirmacion";
            this.confirmacionDataGridViewTextBoxColumn.HeaderText = "Confirmacion";
            this.confirmacionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.confirmacionDataGridViewTextBoxColumn.Name = "confirmacionDataGridViewTextBoxColumn";
            this.confirmacionDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDDeCitaDataGridViewTextBoxColumn
            // 
            this.iDDeCitaDataGridViewTextBoxColumn.DataPropertyName = "ID de Cita";
            this.iDDeCitaDataGridViewTextBoxColumn.HeaderText = "ID de Cita";
            this.iDDeCitaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDeCitaDataGridViewTextBoxColumn.Name = "iDDeCitaDataGridViewTextBoxColumn";
            this.iDDeCitaDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDeCitaDataGridViewTextBoxColumn.Width = 125;
            // 
            // departamentoDataGridViewTextBoxColumn
            // 
            this.departamentoDataGridViewTextBoxColumn.DataPropertyName = "Departamento";
            this.departamentoDataGridViewTextBoxColumn.HeaderText = "Departamento";
            this.departamentoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.departamentoDataGridViewTextBoxColumn.Name = "departamentoDataGridViewTextBoxColumn";
            this.departamentoDataGridViewTextBoxColumn.Width = 125;
            // 
            // edadDataGridViewTextBoxColumn
            // 
            this.edadDataGridViewTextBoxColumn.DataPropertyName = "Edad";
            this.edadDataGridViewTextBoxColumn.HeaderText = "Edad";
            this.edadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.edadDataGridViewTextBoxColumn.Name = "edadDataGridViewTextBoxColumn";
            this.edadDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombresDataGridViewTextBoxColumn
            // 
            this.nombresDataGridViewTextBoxColumn.DataPropertyName = "Nombre(s)";
            this.nombresDataGridViewTextBoxColumn.HeaderText = "Nombre(s)";
            this.nombresDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombresDataGridViewTextBoxColumn.Name = "nombresDataGridViewTextBoxColumn";
            this.nombresDataGridViewTextBoxColumn.Width = 125;
            // 
            // primerApellidoDataGridViewTextBoxColumn
            // 
            this.primerApellidoDataGridViewTextBoxColumn.DataPropertyName = "Primer Apellido";
            this.primerApellidoDataGridViewTextBoxColumn.HeaderText = "Primer Apellido";
            this.primerApellidoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.primerApellidoDataGridViewTextBoxColumn.Name = "primerApellidoDataGridViewTextBoxColumn";
            this.primerApellidoDataGridViewTextBoxColumn.Width = 125;
            // 
            // segundoApellidoDataGridViewTextBoxColumn
            // 
            this.segundoApellidoDataGridViewTextBoxColumn.DataPropertyName = "Segundo Apellido";
            this.segundoApellidoDataGridViewTextBoxColumn.HeaderText = "Segundo Apellido";
            this.segundoApellidoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.segundoApellidoDataGridViewTextBoxColumn.Name = "segundoApellidoDataGridViewTextBoxColumn";
            this.segundoApellidoDataGridViewTextBoxColumn.Width = 125;
            // 
            // sintomasDataGridViewTextBoxColumn
            // 
            this.sintomasDataGridViewTextBoxColumn.DataPropertyName = "Sintomas";
            this.sintomasDataGridViewTextBoxColumn.HeaderText = "Sintomas";
            this.sintomasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sintomasDataGridViewTextBoxColumn.Name = "sintomasDataGridViewTextBoxColumn";
            this.sintomasDataGridViewTextBoxColumn.Width = 125;
            // 
            // enfermedadesPreviasDataGridViewTextBoxColumn
            // 
            this.enfermedadesPreviasDataGridViewTextBoxColumn.DataPropertyName = "Enfermedades Previas";
            this.enfermedadesPreviasDataGridViewTextBoxColumn.HeaderText = "Enfermedades Previas";
            this.enfermedadesPreviasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.enfermedadesPreviasDataGridViewTextBoxColumn.Name = "enfermedadesPreviasDataGridViewTextBoxColumn";
            this.enfermedadesPreviasDataGridViewTextBoxColumn.Width = 125;
            // 
            // consumeMedicamentoDataGridViewTextBoxColumn
            // 
            this.consumeMedicamentoDataGridViewTextBoxColumn.DataPropertyName = "¿Consume Medicamento?";
            this.consumeMedicamentoDataGridViewTextBoxColumn.HeaderText = "¿Consume Medicamento?";
            this.consumeMedicamentoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.consumeMedicamentoDataGridViewTextBoxColumn.Name = "consumeMedicamentoDataGridViewTextBoxColumn";
            this.consumeMedicamentoDataGridViewTextBoxColumn.Width = 125;
            // 
            // alergiasDataGridViewTextBoxColumn
            // 
            this.alergiasDataGridViewTextBoxColumn.DataPropertyName = "Alergias";
            this.alergiasDataGridViewTextBoxColumn.HeaderText = "Alergias";
            this.alergiasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.alergiasDataGridViewTextBoxColumn.Name = "alergiasDataGridViewTextBoxColumn";
            this.alergiasDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechaDeCitaDataGridViewTextBoxColumn
            // 
            this.fechaDeCitaDataGridViewTextBoxColumn.DataPropertyName = "Fecha de Cita";
            this.fechaDeCitaDataGridViewTextBoxColumn.HeaderText = "Fecha de Cita";
            this.fechaDeCitaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaDeCitaDataGridViewTextBoxColumn.Name = "fechaDeCitaDataGridViewTextBoxColumn";
            this.fechaDeCitaDataGridViewTextBoxColumn.Width = 125;
            // 
            // horaDeCitaDataGridViewTextBoxColumn
            // 
            this.horaDeCitaDataGridViewTextBoxColumn.DataPropertyName = "Hora de Cita";
            this.horaDeCitaDataGridViewTextBoxColumn.HeaderText = "Hora de Cita";
            this.horaDeCitaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.horaDeCitaDataGridViewTextBoxColumn.Name = "horaDeCitaDataGridViewTextBoxColumn";
            this.horaDeCitaDataGridViewTextBoxColumn.Width = 125;
            // 
            // spMostrarInformacionCitaBindingSource
            // 
            this.spMostrarInformacionCitaBindingSource.DataMember = "sp_MostrarInformacionCita";
            this.spMostrarInformacionCitaBindingSource.DataSource = this.cruzRojaPracticaDataSetImprimir;
            // 
            // cruzRojaPracticaDataSetImprimir
            // 
            this.cruzRojaPracticaDataSetImprimir.DataSetName = "cruzRojaPracticaDataSetImprimir";
            this.cruzRojaPracticaDataSetImprimir.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_eliminarCita
            // 
            this.btn_eliminarCita.Location = new System.Drawing.Point(1159, 450);
            this.btn_eliminarCita.Margin = new System.Windows.Forms.Padding(5);
            this.btn_eliminarCita.Name = "btn_eliminarCita";
            this.btn_eliminarCita.Size = new System.Drawing.Size(135, 56);
            this.btn_eliminarCita.TabIndex = 1;
            this.btn_eliminarCita.Text = "Cancelar Cita";
            this.btn_eliminarCita.UseVisualStyleBackColor = true;
            this.btn_eliminarCita.Click += new System.EventHandler(this.btn_eliminarCita_Click);
            // 
            // btn_cerrarRegresar
            // 
            this.btn_cerrarRegresar.Location = new System.Drawing.Point(17, 456);
            this.btn_cerrarRegresar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_cerrarRegresar.Name = "btn_cerrarRegresar";
            this.btn_cerrarRegresar.Size = new System.Drawing.Size(135, 50);
            this.btn_cerrarRegresar.TabIndex = 2;
            this.btn_cerrarRegresar.Text = "Regresar";
            this.btn_cerrarRegresar.UseVisualStyleBackColor = true;
            this.btn_cerrarRegresar.Click += new System.EventHandler(this.btn_cerrarRegresar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_vistaCitas);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1303, 414);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Citas Registradas";
            // 
            // sp_MostrarInformacionCitaTableAdapter
            // 
            this.sp_MostrarInformacionCitaTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(840, 469);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nota: Seleccionar la cita para cancelar";
            // 
            // VistaCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 515);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_eliminarCita);
            this.Controls.Add(this.btn_cerrarRegresar);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "VistaCitas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vista de Citas";
            this.Load += new System.EventHandler(this.VistaCitas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vistaCitas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spMostrarInformacionCitaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cruzRojaPracticaDataSetImprimir)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_vistaCitas;
        private System.Windows.Forms.Button btn_eliminarCita;
        private System.Windows.Forms.Button btn_cerrarRegresar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn confirmacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDeCitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn primerApellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn segundoApellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sintomasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enfermedadesPreviasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn consumeMedicamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alergiasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDeCitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaDeCitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource spMostrarInformacionCitaBindingSource;
        private cruzRojaPracticaDataSetImprimir cruzRojaPracticaDataSetImprimir;
        private cruzRojaPracticaDataSetImprimirTableAdapters.sp_MostrarInformacionCitaTableAdapter sp_MostrarInformacionCitaTableAdapter;
        private System.Windows.Forms.Label label1;
    }
}