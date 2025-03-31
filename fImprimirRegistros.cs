using System;
using System.Windows.Forms;

namespace SACM_2
{

    public partial class fImprimirRegistros : Form
    {

        RegistroCitas registro = new RegistroCitas();
        public string TipoDepartamento { get; set; }
        public DateTime FechaRegistro { get; set; }

        public fImprimirRegistros()
        {
            InitializeComponent();
        }

        private void fImprimirRegistros_Load(object sender, EventArgs e)
        {
            this.sp_MostrarRegistrosDeparTableAdapter.Fill(this.dataSet_imDepar.sp_MostrarRegistrosDepar, TipoDepartamento, FechaRegistro);
            this.reportViewer1.RefreshReport();
        }

        private void regresarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
            // registro.Show();
        }


    }

}

