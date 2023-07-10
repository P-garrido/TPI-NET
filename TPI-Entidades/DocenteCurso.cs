using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI_Entidades
{
    internal class DocenteCurso
    {

        private int _cargo;
        private int _idCurso;
        private int _idDocente;

        public int Cargo {
            get => _cargo;
            set {
                _cargo = value;
            }
        }

        public int IdCurso {
            get => _idCurso;
            set {
                _idCurso = value;
            }
        }

        public int IdDocente {
            get => _idDocente;
            set {
                _idDocente = value;
            }
        }
    }
}
