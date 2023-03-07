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
    public class ExtensionMethodsTests
    {
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DividirPorCeroTest()
        {
            //Arrange
            int a = 3; 

            //act
            a.DividirPorCero();
        }
    }
}