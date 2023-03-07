using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoExepciones.Dominio
{
    public static class ExtensionMethods
    {
        //Estoy forzando esto solo para aplicar Extension Methods
        public static int DividirPorCero(this int value)
        {
            return value / 0;
        }

    }
}
