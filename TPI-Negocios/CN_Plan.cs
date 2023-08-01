using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI_Datos;

namespace TPI_Negocios
{
    public class CN_Plan
    {

        CD_Plan CDPlan = new CD_Plan();

        public DataTable mostrarPlanes()
        {
            return this.CDPlan.mostrarPlanes();
        }

        public DataTable mostrarPlan(string descPlan)
        {
            return this.CDPlan.mostrarPlan(descPlan);
        }
    }
}
