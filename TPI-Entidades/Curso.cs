using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI_Entidades
{
    internal class Curso
    {

        private int _anioCalendario;
        private int _cupo;
        private string _descripcion;
        private int _idComision;
        private int _idMateria;

        public int AnioCalendario {
            get => _anioCalendario;
            set {
                _anioCalendario = value;
            }
        }

        public int Cupo {
            get => _cupo;
            set {
                _cupo = value;
            }
        }

        public string Descripcion {
            get => _descripcion;
            set {
                _descripcion = value;
            }
        }

        public int IdComision {
            get => _idComision;
            set {
                _idComision = value;
            }
        }

        public int IdMateria {
            get => _idMateria;
            set {
                _idMateria = value;
            }
        }
    }
}
