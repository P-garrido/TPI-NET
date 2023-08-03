using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI_Entidades
{
    public class Plan
    {
        private string _descripcion;
        private int _idEspecialidad;

        public string Descripcion {
            get => _descripcion;
            set {
                _descripcion = value;
            }
        }

        public int IdEspecialidad {
            get => _idEspecialidad;
            set {
                _idEspecialidad = value;
            }
        }
    }
}
