using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI_Datos;
using TPI_Entidades;

namespace TPI_Negocios
{
    public class CN_Materia
    {
        CD_Materia CDMateria = new CD_Materia();

        public void agregarMateria(string descMat, int hsSem, int hsTot, int idPlan)
        {
            Materia mat = new Materia(descMat, hsSem, hsTot, idPlan);

            this.CDMateria.agregarMateria(mat);
        }

        public DataTable mostrarMaterias()
        {
            return this.CDMateria.mostrarMaterias();
        }

        public DataTable mostrarMateria(string descMat)
        {
            return this.CDMateria.mostrarMateria(descMat);
        }

        public DataTable mostrarMateriaPorId(int idMat)
        {
            return this.CDMateria.mostrarMateriaPorId(idMat);
        }

        public void eliminarMateria(int idMat)
        {
            this.CDMateria.eliminarMateria(idMat);
        }

        public void actualizarMateria(Materia mat, string descMat)
        {
            this.CDMateria.actualizarMateria(mat, descMat);
        }
    }
}
