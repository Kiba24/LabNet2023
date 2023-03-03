using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportePublico.Dominio
{
    internal class Taxi : Transporte
    {
        public Taxi(int pasajeros) : base(pasajeros)
        {
           
        }

        public override string Avanzar()
        {
            return "El taxi avanza a 80 Km/h";
        }

        public override string Detenerse()
        {
            return "El taxi tarda 1.2 segundos en detenerse completamente";
        }
    }
}
