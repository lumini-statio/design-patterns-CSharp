using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COR
{
    public class Gerente : PersonalEmpresa
    {

        public override void ProcesarGasto(int gasto)
        {
            if (gasto > 0 && gasto <= 200000)
            {
                System.Console.WriteLine("aprobado por el gerente");
            }
            else
            {
                this.DerivarASuperior(gasto);
            }
        }
    }
}