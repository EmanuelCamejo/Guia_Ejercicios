using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace TestProject1
{
    [TestClass]
    public class TestStringExtendido
    {
        [TestMethod]
        public void Fizz_CuandoEsDivisiblePor3_DeberiaRetornarFizz()
        {
            //Arrange
            int numero = 6;
            string exp = "Fizz";

            //act
            string actual = numero.FizzBuzz();

            //Assert
            Assert.AreEqual(exp, actual);

        }

        [TestMethod]
        public void Fizz_CuandoEsDivisiblePor5_DeberiaRetornarBuzz()
        {
            //Arrange
            int numero = 5;
            string exp = "Buzz";

            //act
            string actual = numero.FizzBuzz();

            //Assert
            Assert.AreEqual(exp, actual);

        }

        [TestMethod]
        public void Fizz_CuandoEsDivisiblePor3y5_DeberiaRetornarFizzBuzz()
        {
            //Arrange
            int numero = 15;
            string exp = "FizzBuzz";

            //act
            string actual = numero.FizzBuzz();

            //Assert
            Assert.AreEqual(exp, actual);

        }

        [TestMethod]
        public void Fizz_CuandoNoEsDivisiblePor3y5_DeberiaRetornarNoFizzBuzz()
        {
            //Arrange
            int numero = 2;
            string exp = "NoFizzBuzz";

            //act
            string actual = numero.FizzBuzz();

            //Assert
            Assert.AreEqual(exp, actual);

        }
    }
}
