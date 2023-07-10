using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI_Entidades
{
    internal class AlumnoInscripcion
    {
        private string _condicion;
        private int _idAlumno;
        private int _idCurso;
        private int _nota;

        public string Condicion {
            get => _condicion;
            set {
                _condicion = value;
            }
        }

        public int IdAlumno {
            get => _idAlumno;
            set {
                _idAlumno = value;
            }
        }

        public int IdCurso {
            get => _idCurso;
            set {
                _idCurso = value;
            }
        }

        public int Nota {
            get => _nota;
            set {
                _nota = value;
            }
        }
    }
}
