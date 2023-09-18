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
    public class CN_Comisiones
    {
        CD_Comisiones CDComisiones = new CD_Comisiones();


        public void agregarComision(string desc, int anioEsp, int idPlan)
        {
            Comision com = new Comision(desc, anioEsp, idPlan);
            this.CDComisiones.agregarComision(com);
        }

        public DataTable mostrarComisiones()
        {
            return this.CDComisiones.mostrarComisiones();
        }

        public DataTable mostrarComisionesCompleto()
        {
            return this.CDComisiones.mostrarComisionesCompleto();
        }

        public DataTable mostrarComision(int idCom)
        {
            return this.CDComisiones.mostrarComision(idCom);
        }

        public DataTable mostrarComisionPorDescripcion(string descCom)
        {
            return this.CDComisiones.mostrarComisionPorDescripcion(descCom);
        }

        public void eliminarComision(int idCom)
        {
            this.CDComisiones.eliminarComision(idCom);
        }

        public void actualizarComision(int idCom, Comision com)
        {
            this.CDComisiones.actualizarComision(com, idCom);
        }

        //public DataTable mostrarComisionesConCupos()
        //{
        //    //Verificar que los cupos no sean nulos
        //    DataTable comisiones = CDComisiones.mostrarComisionesConCurso();
            
        //    foreach (DataRow com in comisiones.Rows)
        //    {
        //        if ((int)com["cupo"] == 0)
        //        {
        //            com.Delete();
        //        }
        //    }
        //    comisiones.AcceptChanges();
        //    return comisiones;
        //}
    }
}
