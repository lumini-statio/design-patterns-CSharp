using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COR
{
    public class Supervisor : PersonalEmpresa, IProcesadorGasto
    {
        public override void ProcesarGasto(int gasto)
        {
            if(gasto <= 50000)
            {
                System.Console.WriteLine($"${gasto} aprobado por el supervisor");
            }
            else
            {
                this.DerivarASuperior(gasto);
            }
        }
    }
}