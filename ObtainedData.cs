using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_F._Costos_Empresariales
{
    public class ObtainedData
    {
        public static double MateriaPrima {  get; set; }
        public static double ManoDeObra { get; set; }
        public static double CostosIndirectos { get; set; }
        public static double GradoDeAvanceMP { get; set; }
        public static double GradoDeAvanceMO { get; set; }
        public static double GradoDeAvanceCI { get; set; }
        public static double VolumenProducido { get; set; }
        public static double VolumenTerminado { get; set; }

        public static double TotalInvFinal { get; set; }
        public static double TotalProduccionTerminada { get; set; }

    }
}
