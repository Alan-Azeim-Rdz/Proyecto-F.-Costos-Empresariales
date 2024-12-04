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
    public partial class Cedula1 : Form
    {
        public Cedula1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Cedula2_Load);
        }
        private void Calculate()
        {
            try
            {
                // Datos ingresados
                double volumenProducido = ObtainedData.VolumenProducido;
                double materiaPrima = ObtainedData.MateriaPrima;
                double manoObra = ObtainedData.ManoDeObra;
                double costosIndirectos = ObtainedData.CostosIndirectos;

                // Cálculos de costos unitarios
                double costoUnitarioMP = materiaPrima / volumenProducido;
                double costoUnitarioMO = manoObra / volumenProducido;
                double costoUnitarioCI = costosIndirectos / volumenProducido;

                // Cálculos de costos totales
                double costoTotalMP = costoUnitarioMP * volumenProducido;
                double costoTotalMO = costoUnitarioMO * volumenProducido;
                double costoTotalCI = costoUnitarioCI * volumenProducido;

                // Mostrar resultados
                txtCostoMP.Text = costoUnitarioMP.ToString("N2");
                txtCostoMO.Text = costoUnitarioMO.ToString("N2");
                txtCostoCI.Text = costoUnitarioCI.ToString("N2");
                txtTotalMP.Text = costoTotalMP.ToString("N2");
                txtTotalMO.Text = costoTotalMO.ToString("N2");
                txtTotalCI.Text = costoTotalCI.ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular la Cédula 1: " + ex.Message);
            }

        }
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            // Mostrar el Form1 existente
            Form1 formPrincipal = (Form1)Application.OpenForms["Form1"];
            formPrincipal.Show();

            // Cerrar el formulario actual
            this.Close();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            // Crear una instancia del FormCedula2
            Cedula2 formCedula2 = new Cedula2();

            // Mostrar el siguiente formulario
            formCedula2.Show();

            // Cerrar el formulario actual
            this.Close();
        }
        private void Cedula2_Load(object sender, EventArgs e)
        {
            Calculate();
        }


    }
}
