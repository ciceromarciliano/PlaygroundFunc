using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlaygroundFunc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PlaygroundFuncTestes
{
    [TestClass]
    public class CalculadoraTestes
    {
        [TestMethod]
        public void Somar_Dois_Numeros_RetornaTotal()
        {
            var total = new Calculadora().Calcular(20, 30, (a, b) => a + b);
            Assert.AreEqual(50,total);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException), "Tentativa de divisão por zero.")]
        public void Dividir_Dois_Numeros_Passar_E_Falhar_Divisao_Por_Zero()
        {
            var total = new Calculadora().Calcular(100, 0, (a, b) => a/b);
            Assert.AreEqual(10, total);
        }

        [TestMethod]
        public void Dividir_Dois_Numeros_Retornal_Total()
        {
            var total = new Calculadora().Calcular(400, 40, (a, b) => a/b, (x) => x > 0);
            Assert.AreEqual(10, total);
        }
    }
}
