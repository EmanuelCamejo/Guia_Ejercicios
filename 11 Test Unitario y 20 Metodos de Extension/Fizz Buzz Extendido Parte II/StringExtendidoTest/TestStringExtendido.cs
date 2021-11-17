using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace StringExtendidoTest
{ 
    [TestClass]
    public class TestStringExtendido
    {
        public object Arrange { get; private set; }

        [TestMethod]
        public void DivisiblePor3yPor5()
        {
            //Arrange: Inicializo las variables 

            //Chequeo que sean divisibles por 3 
            Int32 num = 3;
            string expected = "Fizz";

            //Chequeo que no sean divisibles por 5 
            //Int32 num = 5;
            //string expected = "Buzz";

            //Chequeo que sean divisibles por 3 y por 5
            //Int32 num = 15;
            //string expected = "FizzBuzz";


            //Chequeo que no sean divisibles por 3 y por 5
            //Int32 num = 2;
            //string expected = "2";


            //Act: Llamar al metodo a testear
            string resultado = MiExtension.FizzBuss(num);

            //Assert: Comprobar el valor con el esperado.
            Assert.AreEqual(expected,resultado);

        }

    }
}
