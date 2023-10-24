using Xunit;
using System;
using NewTalents;

namespace TestNewTalent
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1,2,3)]
        [InlineData(2,3,5)]
        public void TestSomar(int val1,int val2, int resultado)
        {
            Calculadora calc = new Calculadora();


            int resultadoCalc = calc.Somar(val1, val2);


            Assert.Equal(resultado, resultadoCalc);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(2, 3, 6)]
        public void TestMultiplicar(int val1, int val2, int resultado)
        {
            Calculadora calc = new Calculadora();


            int resultadoCalc = calc.Multplicar(val1, val2);


            Assert.Equal(resultado, resultadoCalc);
        }

        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(10, 2, 5)]
        public void TestDividir(int val1, int val2, int resultado)
        {
            Calculadora calc = new Calculadora();


            int resultadoCalc = calc.Dividir(val1, val2);


            Assert.Equal(resultado, resultadoCalc);
        }

        [Theory]
        [InlineData(5, 2, 3)]
        [InlineData(40, 2 , 38)]
        public void TestSubtrair(int val1, int val2, int resultado)
        {
            Calculadora calc = new Calculadora();


            int resultadoCalc = calc.Diminuir(val1, val2);


            Assert.Equal(resultado, resultadoCalc);
        }

        [Fact]
        public void TestarDivisaoPorZero()
        {
            Calculadora calc = new Calculadora();

            Assert.Throws<DivideByZeroException>(() => calc.Dividir(3, 0));
        }

        [Fact]
        public void TestarHistorico()
        {
            Calculadora calc = new Calculadora();

            calc.Somar(1, 2);
            calc.Somar(2, 8);
            calc.Somar(3, 7);

            var lista = calc.Historico();


            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count());

        }
    }
}