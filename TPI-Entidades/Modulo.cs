using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI_Entidades
{
    internal class Modulo
    {
        private string _descripcion;

        public string Descripcion {
            get => _descripcion;
            set {
                _descripcion = value;
            }
        }
    }
}
