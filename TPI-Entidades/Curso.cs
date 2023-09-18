using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI_Entidades
{
    public class Curso
    {
        private int _idCurso;
        private int _anioCalendario;
        private int _cupo;
        private int _idComision;
        private int _idMateria;

        public Curso(int idMateria, int idComision, int anioCal, int cup)
        {
            _anioCalendario = anioCal;
            _idMateria = idMateria;
            _idComision = idComision;
            _cupo = cup;
        }

        public Curso() { }

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

        public int IdCurso {
            get => _idCurso;
            set {
                _idCurso = value;
            }
        }
    }
}
