using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COR
{
    public class Director : PersonalEmpresa
    {
        public override void ProcesarGasto(int gasto)
        {
            System.Console.WriteLine("aprobado por el director god");
        }
    }
}