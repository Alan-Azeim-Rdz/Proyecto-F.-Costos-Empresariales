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
    public partial class Cedula2 : Form
    {
        public Cedula2()
        {
            InitializeComponent();

            this.Load += new EventHandler(Cedula2_Load);
        }



        private void CalcularCostos()
        {

            double volT = ObtainedData.VolumenTerminado;
            double volP = ObtainedData.VolumenProducido;


            double costoUMP = ObtainedData.MateriaPrima / volP;
            double costoUMO = ObtainedData.ManoDeObra / volP;
            double costoUCI = ObtainedData.CostosIndirectos /volP;

            double costoTMP = costoUMP * volT;
            double costoTMO = costoUMO * volT;
            double costoTCI = costoUCI * volT;
            double costoProduccionT = costoTMP + costoTMO + costoTCI;


            txtCostoTMP.Text = costoTMP.ToString("N2");
            txtCostoTMO.Text = costoTMO.ToString("N2");
            txtCostoTCI.Text = costoTCI.ToString("N2");
            txtCostoTPT.Text = costoProduccionT.ToString("N2");
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            Form1 formP = (Form1)Application.OpenForms["Form1"];
            formP.Show();
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                double prodFinal = Convert.ToDouble(txtCostoTPT.Text);
                ObtainedData.TotalProduccionTerminada = prodFinal;
                Cedula3 cedula3 = new Cedula3();
                cedula3.Show();
                this.Close();

            }



            catch
            {
                MessageBox.Show("Error Con el Inventario Final.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void Cedula2_Load(object sender, EventArgs e)
        {
            CalcularCostos();
        }
    }
}
