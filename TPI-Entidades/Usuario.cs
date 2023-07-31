using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI_Entidades
{
    public class Usuario
    {
        private string _nombreUsuario;
        private string _clave;
        private bool _habilitado;
        private string _nombre;
        private string _apellido;
        private string _email;
        private int _idPersona;

        public Usuario(string nomUsu, string clave, string nombre, string apellido, string email, int idPersona)
        {
            this._nombreUsuario = nomUsu;
            this._clave = clave;
            this._habilitado = true;
            this._nombre = nombre;
            this._apellido = apellido;
            this._email = email;
            this._idPersona = idPersona;
        }

        public string Apellido
        {
            get => _apellido;
            set
            {
                _apellido = value;
            }
        }

        public string Clave
        {
            get => _clave;
            set
            {
                _clave = value;
            }
        }

        public string Email
        {
            get => _email;
            set
            {
                _email = value;
            }
        }

        public bool Habilitado
        {
            get => _habilitado;
            set
            {
                _habilitado = value;
            }
        }

        public string Nombre
        {
            get => _nombre;
            set
            {
                _nombre = value;
            }
        }

        public string NombreUsuario
        {
            get => _nombreUsuario;
            set
            {
                _nombreUsuario = value;
            }
        }

        public int IdPersona
        {
            get => _idPersona;
            set
            {
                _idPersona = value;
            }
        }
    }
}
