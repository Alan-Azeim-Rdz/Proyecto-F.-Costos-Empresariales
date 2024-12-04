using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_F._Costos_Empresariales
{
    public partial class frmCedula4 : Form
    {
        public frmCedula4()
        {
            InitializeComponent();
            this.Load += new EventHandler(Cedula4_Load);
        }

        private void Cedula4_Load(object sender, EventArgs e)
        {
            CalcularCostos();
        }

        private void CalcularCostos()
        {
            try
            {
                double CostoProduccionTerminada;
                double CostoInventarioFinal;
                double GranTotal;

                CostoProduccionTerminada = ObtainedData.TotalProduccionTerminada;
                CostoInventarioFinal = ObtainedData.TotalInvFinal;

                txtProduccionTerminada.Text = CostoProduccionTerminada.ToString("N2");
                txtCostoInvertarioFinal.Text = CostoInventarioFinal.ToString("N2");

                GranTotal = CostoProduccionTerminada + CostoInventarioFinal;

                txtGranTotal.Text = GranTotal.ToString("N2");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Form1 formP = (Form1)Application.OpenForms["Form1"];
            formP.Show();
            this.Close();


        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            frmCedula4 frmCedula = new frmCedula4();
            this.Close();
        }

        private void btnGranTotal_Click(object sender, EventArgs e)
        {

        }
    }
}
