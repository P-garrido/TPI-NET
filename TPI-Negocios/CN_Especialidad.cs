using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI_Datos;
using TPI_Entidades;
using TPI_Datos;

namespace TPI_Negocios
{
    public class CN_Especialidad
    {

        CD_Especialidad CDEspecialidad = new CD_Especialidad();

        public DataTable mostrarEspecialidades()
        {
            return CDEspecialidad.mostrarEspecialidades();
        }

        public DataTable mostrarEspecialidad(string descEsp)
        {
            return CDEspecialidad.mostrarEspecialidad(descEsp);
        }

        public void agregarEspecialidad(string descEsp)
        {
            Especialidad esp = new Especialidad(descEsp);
            CDEspecialidad.agregarEspecialidad(esp);
        }

        public void eliminarEspecialidad(string descEsp)
        {
            CDEspecialidad.eliminarEspecialidad(descEsp);
        }

        public void actualizarEspecialidad(string nomEspViejo, string descEsp)
        {
            Especialidad esp = new Especialidad(descEsp);
            CDEspecialidad.actualizarEspecialidad(esp, nomEspViejo);
        }
    }
}
