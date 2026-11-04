using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace template
{
    public interface PrepararBebida
    {
        void HervirAgua();
        void PrepararInfusion();
        void Servir();
        void AgregarExtras(String extra);
        void Preparar();
    }
}