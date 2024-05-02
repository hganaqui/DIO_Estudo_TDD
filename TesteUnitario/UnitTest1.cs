using Calc;
using System;
using Xunit;

namespace TesteUnitario
{
    public class CalculadoraTests
    {
        private  Calculadora _calc = new Calculadora();

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]
        public void TesteSomar(int val1, int val2, int resultado)
        {

            int resultadoCalculadora = _calc.somar(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(5, 4, 1)]
        public void TesteSubtrair(int val1, int val2, int resultado)
        {
            int resultadoCalculadora = _calc.subtrair(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void TesteMultiplicar(int val1, int val2, int resultado)
        {
            int resultadoCalculadora = _calc.multiplicar(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(2, 2, 1)]
        [InlineData(20, 5, 4)]
        public void TesteDividir(int val1, int val2, int resultado)
        {
            int resultadoCalculadora = _calc.dividir(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Fact]
        public void TesteDividirporzero()
        {
            Assert.Throws<DivideByZeroException>(() => _calc.dividir(2, 0));
        }

        [Fact]
        public void TesteHistorico()
        {
            _calc.somar(1, 2);
            _calc.somar(3, 2);
            _calc.somar(4, 2);
            var lista = _calc.historico();
            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }
    }
}
