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
    public partial class Cedula3 : Form
    {
        public Cedula3()
        {
            InitializeComponent();
            this.Load += new EventHandler(Cedula3_Load);
        }


        private void Cedula3_Load(object sender, EventArgs e)
        {
            CalcularCostos();
        }

        private void CalcularCostos()
        {

            

            // Datos ingresados
            double volumenInventarioFinal = ObtainedData.VolumenProducido - ObtainedData.VolumenTerminado;
            double gradoAvanceMP = ObtainedData.GradoDeAvanceMP;
            double gradoAvanceMO = ObtainedData.GradoDeAvanceMO;
            double gradoAvanceCI = ObtainedData.GradoDeAvanceCI;

            double costoUnitarioMP = ObtainedData.MateriaPrima / ObtainedData.VolumenProducido;
            double costoUnitarioMO = ObtainedData.ManoDeObra / ObtainedData.VolumenProducido;
            double costoUnitarioCI = ObtainedData.CostosIndirectos / ObtainedData.VolumenProducido;

            // Cálculos de costos totales
            double costoTotalMP = volumenInventarioFinal * costoUnitarioMP * gradoAvanceMP;
            double costoTotalMO = volumenInventarioFinal * costoUnitarioMO * gradoAvanceMO;
            double costoTotalCI = volumenInventarioFinal * costoUnitarioCI * gradoAvanceCI;

            double costoF = costoTotalMP + costoTotalMO + costoTotalCI;


            txtCostoTMP.Text = costoTotalMP.ToString("N2");
            txtCostoTMO.Text = costoTotalMO.ToString("N2");
            txtCostoTCI.Text = costoTotalCI.ToString("N2");
            txtCostoTIF.Text = costoF.ToString("N2");

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                double invFinal = Convert.ToDouble(txtCostoTIF.Text);
                ObtainedData.TotalInvFinal = invFinal;
                frmCedula4 frmCedula4 = new frmCedula4();
                frmCedula4.Show();
                this.Close();

            }



            catch
            {
                MessageBox.Show("Error Con el Inventario Final.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 formP = (Form1)Application.OpenForms["Form1"];
            formP.Show();
            this.Close();
        }
    }
}


