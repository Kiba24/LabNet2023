using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportePublico.Dominio
{
    internal abstract class Transporte 
    {
        private int pasajeros { get; set; }

        public Transporte(int pasajeros)
        {
            this.pasajeros = pasajeros;
        }

        //Metodos generados por Interfaz
        public abstract string Avanzar();

        public abstract string Detenerse();
    }
}
