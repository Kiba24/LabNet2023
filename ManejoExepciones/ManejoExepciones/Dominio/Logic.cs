using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManejoExepciones.Dominio;

namespace ManejoExepciones.Dominio
{
    internal class Logic 
    {

        public void DisparadorExepcion()
        {
            throw new NotImplementedException();
        }

        public string DisparadorExepcionCustom()
        {
            throw new LogicExeption();  
        }
    }
}
