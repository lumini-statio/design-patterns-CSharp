using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COR
{
    public interface IProcesadorGasto
    {
        void AsignarSuperior(IProcesadorGasto personal);
        void ProcesarGasto(int gasto);
    }
}