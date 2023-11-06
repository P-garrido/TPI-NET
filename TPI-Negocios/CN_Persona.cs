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
    public class CN_Persona
    {

        CD_Persona CDPersona = new CD_Persona();
        Persona per = null;

        public void agregarPersona(string ape, string dir, string email,DateTime  fechaNac,int idPlan, int leg, string nom, string tel,  int tipoPer)
        {
            per = new Persona(ape, dir, email, fechaNac, idPlan, leg, nom, tel, tipoPer);
            this.CDPersona.agregarPersona(per);
        }

        public DataTable mostrarPersonas()
        {
            return this.CDPersona.mostrarPersonas();
        }

        public DataTable mostrarPersonasCompleto()
        {
            return this.CDPersona.mostrarPersonasCompleto();
        }

        public DataTable mostrarPersona(int legPer)
        {
            return this.CDPersona.mostrarPersona(legPer);
        }

        public void eliminarPersona(int idPer)
        {
            this.CDPersona.eliminarPersona(idPer);
        }

        public void actualizarPersona(int idPer, Persona per)
        {

            this.CDPersona.actualizarPersona(per, idPer);
        }

        public int buscarPersonaPorId(int idPer)
        {
            DataTable dt = CDPersona.buscarPersona(idPer);

            int tipoPer = (int)dt.Rows[0]["tipo_persona"];
            return tipoPer;

        }

        public DataTable buscarPerPorId(int idPer)
        {
            return CDPersona.buscarPersona(idPer);

        }


        public void inscribirACurso(int idAlumno, int idCurso)
        {
            CDPersona.inscribirACurso(idAlumno, idCurso);
        }

        public void inscribirDocenteACurso(int idDoc, int idCur, int cargo)
        {
            CDPersona.inscribirDocenteACurso(idDoc, idCur, cargo);
        }

        public List<Persona> buscarAlumnosCursando(int idCom, int idMat)
        {
            return CDPersona.buscarAlumnosCursando(idCom, idMat);
        }

        public Persona buscarAlumnoNombreApellido(string nomAp)
        {
            return CDPersona.buscarAlumnoNombreApellido(nomAp);
        }

        public void actualizarNota(AlumnoInscripcion inscripcion, int nota)
        {
            int idInsc = inscripcion.IdInscripcion;
            CDPersona.actualizarNota(idInsc, nota);
        }

        public void eliminarInscripcionesDePersona(int idPer, int tipoPer)
        {
            if (tipoPer == 0)
            {
                CDPersona.eliminarInscripcionesDeDocente(idPer);
            }
            else
            {
                CDPersona.eliminarInscripcionesDeAlumno(idPer);
            }
        }
    }
}
