using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI_Entidades
{
    public class Comision
    {

        private DateOnly _anioEspecialidad;
        private string _descripcion;
        private int _idPlan;
        public Comision(string desc, DateOnly anioEsp, int idPlan)
        {
            _descripcion = desc;
            _idPlan = idPlan;
            _anioEspecialidad = anioEsp;
        }

        public int AnioEspecialidad {
            get => default;
            set {
            }
        }

        public string Descripcion {
            get => default;
            set {
            }
        }

        public int IdPlan {
            get => default;
            set {
            }
        }
    }
}
