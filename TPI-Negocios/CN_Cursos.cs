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
    public class CN_Cursos
    {
        public CN_Cursos() { }
        CD_Cursos CDCursos = new CD_Cursos();


        public void agregarCurso(int idMat, int idCom, int anioCal, int cup)
        {
            Curso cur = new Curso(idMat, idCom, anioCal, cup);
            this.CDCursos.agregarCurso(cur);
        }

        public DataTable mostrarCursos()
        {
            return this.CDCursos.mostrarCursos();
        }

        public DataTable mostrarCursosCompleto()
        {
            return this.CDCursos.mostrarCursosCompleto();
        }

        public DataTable mostrarCurso(int idCurso)
        {
            return this.CDCursos.mostrarCurso(idCurso);
        }

        public void eliminarCurso(int idCurso)
        {
            this.CDCursos.eliminarCurso(idCurso);
        }

        public void actualizarCurso(Curso cur, int idCur)
        {
            this.CDCursos.actualizarCurso(cur, idCur);
        }

        public DataTable mostrarCursosConCupos(int idMat)
        {
            //Verificar que los cupos no sean nulos
            DataTable cursos = CDCursos.mostrarCursosCompletoPorMateria(idMat);
            return cursos;
        }

        public DataTable buscarCurso(int idMat, int idCom)
        {
            return CDCursos.buscarCurso(idMat, idCom);
        }
    }
}
