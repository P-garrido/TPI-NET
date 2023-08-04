using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI_Entidades
{
    public class Comision
    {

        private int _anioEspecialidad;
        private string _descripcion;
        private int _idPlan;
        public Comision(string desc, int anioEsp, int idPlan)
        {
            _descripcion = desc;
            _idPlan = idPlan;
            _anioEspecialidad = anioEsp;
        }

        public int AnioEspecialidad {
            get => _anioEspecialidad;
            set {
                _anioEspecialidad = value;
            }
        }

        public string Descripcion {
            get => _descripcion;
            set {
                _descripcion = value;
            }
        }

        public int IdPlan {
            get => _idPlan;
            set {
                _idPlan = value;
            }
        }
    }
}
