using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace template
{
    public class PrepararCafe : PrepararBebida
    {
        public void Preparar()
        {
            HervirAgua();
            PrepararInfusion();
            Servir();
        }
        public void HervirAgua()
        {
            System.Console.WriteLine("hirviendo el agua...");
        }

        public void PrepararInfusion()
        {
            System.Console.WriteLine("Filtrando el café");
        }
        public void Servir()
        {
            System.Console.WriteLine("sirviendo en la taza");
        }

        public void AgregarExtras(String extra)
        {
            System.Console.WriteLine($"extra agregado: {extra} ");
        }

    }
}