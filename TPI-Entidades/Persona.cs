using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI_Entidades
{
    internal class Persona
    {

        private string _apellido;
        private string _direccion;
        private string _email;
        private System.DateTime _fechaNacimiento;
        private int _IdPlan;
        private int _legajo;
        private string _nombre;
        private string _telefono;
        private string _tipoPersona;

        public string Apellido {
            get => _apellido;
            set {
                _apellido = value;
            }
        }

        public string Direccion {
            get => _direccion;
            set {
                _direccion = value;
            }
        }

        public string Email {
            get => _email;
            set {
                _email = value;
            }
        }

        public System.DateTime FechaNacimiento {
            get => _fechaNacimiento;
            set {
                _fechaNacimiento = value;
            }
        }

        public int IdPlan {
            get => _IdPlan;
            set {
                _IdPlan = value;
            }
        }

        public int Legajo {
            get => _legajo;
            set {
                _legajo = value;
            }
        }

        public string Nombre {
            get => _nombre;
            set {
                _nombre = value;
            }
        }

        public string Telefono {
            get => _telefono;
            set {
                _telefono = value;
            }
        }

        public string TipoPersona {
            get => _tipoPersona;
            set {
                _tipoPersona = value;
            }
        }
    }
}
