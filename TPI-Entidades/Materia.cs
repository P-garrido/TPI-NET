using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI_Entidades
{
    internal class Materia
    {

        private string _descripcion;
        private int _horasSemanales;
        private int _horasTotales;
        private int _idPlan;

        public string Descripcion {
            get => _descripcion;
            set {
                _descripcion = value;
            }
        }

        public int HorasSemanales {
            get => _horasSemanales;
            set {
                _horasSemanales = value;
            }
        }

        public int HorasTotales {
            get => _horasTotales;
            set {
                _horasTotales = value;
            }
        }

        public int IdPlan {
            get => _idPlan;
            set {
                _idPlan = value;
            }
        }
    }
}
