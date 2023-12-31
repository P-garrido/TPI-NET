﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI_Datos;
using TPI_Entidades;

namespace TPI_Negocios
{
    public class CN_Plan
    {

        CD_Plan CDPlan = new CD_Plan();

        public DataTable mostrarPlanes()
        {
            return this.CDPlan.mostrarPlanes();
        }

        public DataTable mostrarPlanesCompleto()
        {
            return this.CDPlan.mostrarPlanesCompleto();
        }

        public DataTable mostrarPlan(string descPlan)
        {
            return this.CDPlan.mostrarPlan(descPlan);
        }

        public void agregarPlan(string descPla, int idEsp)
        {
            Plan pla = new Plan(descPla, idEsp);
            this.CDPlan.agregarPlan(pla);
        }

        public void eliminarPlan(int idPlan)
        {
            this.CDPlan.eliminarPlan(idPlan);
        }

        public void actualizarPlan(int idPlaViejo, string descPla, int idEsp)
        {
            Plan pla = new Plan(descPla, idEsp);
            this.CDPlan.actualizarPlan(pla, idPlaViejo);
        }

        public DataTable cargarReportePlanes()
        {
            return CDPlan.cargarReportePlanes();
        }
    }
}
