using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI_Entidades
{
    public class Especialidad
    {
        private string _descripcion;

        public Especialidad(string descEsp) {
            _descripcion = descEsp;
        }


        public string Descripcion {
            get => _descripcion;
            set {
                _descripcion = value;
            }
        }
    }
}
