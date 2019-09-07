using System;
using System.Collections.Generic;
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

            var veiculos = new List<IVeiculo>();
            veiculos.Add(fiesta);
            veiculos.Add(logan);
            veiculos.Add(superBarco);

        }

        public void CulculaDisponibilidade(List<IVeiculo> veiculos)
        {
            foreach (var veiculo in veiculos)
            {
                if (veiculo is Carro carro)
                    CalculaDisponibilidade(carro);

                if (veiculo is IBarcoMotor superBarco)
                    CalculaDisponibilidade(superBarco);
            }
        }

        private void CalculaDisponibilidade(Carro carro)
        {
            throw new NotImplementedException();
        }

        private void CalculaDisponibilidade(IBarcoMotor superBarco)
        {
            throw new NotImplementedException();
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
