﻿using System;
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

        public DataTable mostrarCursosConCupos(int idMat, int idAlu)
        {
            DataTable cursos = CDCursos.mostrarCursosCompletoPorMateria(idMat, idAlu);
            return cursos;
        }

        public List<TPI_Entidades.Curso> buscarCurso(int idMat, int idCom)
        {
            return CDCursos.buscarCurso(idMat, idCom);
        }

        public DataTable mostrarCursosSinDocentes(int idMat)
        {
            return CDCursos.mostrarCursosSinDocente(idMat);
        }

        public AlumnoInscripcion buscarInscripcion(Persona alumno, int idCom, int idMat)
        {
            int idAlu = alumno.idPersona;
            return CDCursos.buscarInscripcion(idAlu, idCom, idMat);
        }

        public DataTable cargarReporteCursos()
        {
            return CDCursos.cargarReporteCursos();
        }
    }
}
