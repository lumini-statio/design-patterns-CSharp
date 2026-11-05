using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COR
{
    public class JefeDeArea : PersonalEmpresa
    {
        public override void ProcesarGasto(int gasto)
        {
            if (gasto >= 150000 && gasto < 200000)
            {
                System.Console.WriteLine("aprobado por el jefe de area");
            }
            else
            {
                this.DerivarASuperior(gasto);
            }
        }
    }
}