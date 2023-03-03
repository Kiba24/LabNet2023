using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportePublico.Dominio
{
    internal class Omnibus : Transporte
    {
        public Omnibus(int pasajeros) : base(pasajeros)
        {
        }

        public override string Avanzar()
        {
            return "El omnibus avanza a 50 Km/h";
        }

        public override string Detenerse()
        {
            return "El omnibus tarda 4 segundos en detenerse completamente";
        }
    }
}
