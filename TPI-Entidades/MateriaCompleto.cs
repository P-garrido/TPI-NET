using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI_Entidades
{
    public class MateriaCompleto
    {
        private string _descripcion;
        private int _horasSemanales;
        private int _horasTotales;
        private string _plan;
        private int _idMateria;

        public MateriaCompleto(string descMat, int hsSem, int hsTot, string plan)
        {
            _descripcion = descMat;
            _horasSemanales = hsSem;
            _horasTotales = hsTot;
            _plan = plan;
        }

        public MateriaCompleto()
        {

        }


        public int IdMateria
        {
            get => _idMateria;
            set
            {
                _idMateria = value;
            }
        }

        public string Descripcion
        {
            get => _descripcion;
            set
            {
                _descripcion = value;
            }
        }

        public int HorasSemanales
        {
            get => _horasSemanales;
            set
            {
                _horasSemanales = value;
            }
        }

        public int HorasTotales
        {
            get => _horasTotales;
            set
            {
                _horasTotales = value;
            }
        }

        public string Plan
        {
            get => _plan;
            set
            {
                _plan = value;
            }
        }



    }
}
