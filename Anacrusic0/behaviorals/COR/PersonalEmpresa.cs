using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COR
{
    public abstract class PersonalEmpresa : IProcesadorGasto
    {
        protected IProcesadorGasto? superior;

        public void AsignarSuperior(IProcesadorGasto personal)
        {
            this.superior = personal;
        }

        protected void DerivarASuperior(int gasto)
        {
            superior.ProcesarGasto(gasto);
        }

        public abstract void ProcesarGasto(int gasto);
    }
}