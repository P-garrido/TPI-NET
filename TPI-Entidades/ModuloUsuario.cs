using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI_Entidades
{
    internal class ModuloUsuario
    {
        private int _idModulo;
        private int _idUsuario;
        private bool _permiteAlta;
        private bool _permiteBaja;
        private bool _permiteConsulta;
        private bool _permiteModificacion;

        public int IdModulo {
            get => _idModulo;
            set {
                _idModulo = value;
            }
        }

        public int IdUsuario {
            get => _idUsuario;
            set {
                _idUsuario = value;
            }
        }

        public bool PermiteAlta {
            get => _permiteAlta;
            set {
                _permiteAlta = value;
            }
        }

        public bool PermiteBaja {
            get => _permiteBaja;
            set {
                _permiteBaja = value;
            }
        }

        public bool PermiteConsulta {
            get => _permiteConsulta;
            set {
                _permiteConsulta = value;
            }
        }

        public bool PermiteModificacion {
            get => _permiteModificacion;
            set {
                _permiteModificacion = value;
            }
        }
    }
}
