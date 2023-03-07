using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoExepciones.Dominio
{
    internal class LogicExeption : Exception
    {
        public LogicExeption() : base("Este es un mensaje personalizado de exepcion!") { }
    }
}
