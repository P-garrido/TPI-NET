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

        public void agregarPersona(string ape, string dir, string email,DateTime  fechaNac,int idPlan, int leg, string nom, string tel,  int tipoPer)
        {
            Persona per = new Persona(ape, dir, email, fechaNac, idPlan, leg, nom, tel, tipoPer);
            this.CDPersona.agregarPersona(per);
        }

        public DataTable mostrarPersonas()
        {
            return this.CDPersona.mostrarPersonas();
        }

        public DataTable mostrarPersona(int legPer)
        {
            return this.CDPersona.mostrarPersona(legPer);
        }

        public void eliminarPersona(string nomPer)
        {
            this.CDPersona.eliminarPersona(nomPer);
        }

        public void actualizarPersona(string nomPer, Persona per)
        {

            this.CDPersona.actualizarPersona(per, nomPer);
        }
    }
}
