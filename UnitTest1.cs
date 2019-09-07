using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var fiesta = new CarroDeIgnicaoViaBotao
            {
                Cor = "preto"
            };

            var logan = new CarroDeIgnicaoViaChave()
            {
                Cor = "branco"
            };

            var superBarco = new SuperBarco()
            {
                Cor = "azul",
                EspessuraDoCasco = 2
            };


            Desmontar(fiesta);
            Desmontar(logan);

            Desmontar(superBarco);
        }

        public void Desmontar(Carro carro)
        {
        }

        public void Desmontar(IBarcoMotor barcoMotor)
        {
        }

        public void Desmontar(IVeiculo veiculo)
        {
        }


        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(1, 1, 2)]
        [InlineData(0, 0, 0)]
        public void Soma_deve__somar_corretamentes(int num1, int num2, int expected)
        {
            var actual = new Matematica().Soma(num1, num2);
            Assert.Equal(expected, actual);
        }
    }

    public class Matematica
    {
        public int Soma(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
