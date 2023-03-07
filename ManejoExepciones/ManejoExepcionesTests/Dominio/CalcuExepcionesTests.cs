using Microsoft.VisualStudio.TestTools.UnitTesting;
using ManejoExepciones.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoExepciones.Dominio.Tests
{
    [TestClass()]
    public class CalcuExepcionesTests
    {
        [TestMethod()]
        public void DividirTest()
        {
            //ARRANGE
            int num1 = 10;
            int num2 = 2;
            int resultadoEsperado = 5;
            int resultadoObtenido;

            //ACT

            CalcuExepciones calcu = new CalcuExepciones();

            resultadoObtenido = calcu.Dividir(num1, num2);
            //ASSERT
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }
    }
}