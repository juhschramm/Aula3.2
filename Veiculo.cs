using System;

namespace XUnitTestProject1
{
    public interface IVeiculo
    {
        string Cor { get; set; }
        void Andar();
    }

    public interface IVeiculoTerrestre : IVeiculo
    {
        int NumeroDeRodas { get; }
    }

    public abstract class Carro : IVeiculoTerrestre
    {
        public int NumeroDeRodas => 4;
        public string Cor { get; set; }

        public void Andar()
        {
            Console.WriteLine("Ir para frente");
        }

        public virtual void Ligar()
        {
            Console.WriteLine("Virar a chave");
        }
    }

    public class CarroDeIgnicaoViaBotao : Carro
    {
        public override void Ligar()
        {
            Console.WriteLine("Apertar o botão");
        }
    }

    public class CarroDeIgnicaoViaChave : Carro
    {
    }

    public interface IVeiculoMarinho : IVeiculo
    {
        int EspessuraDoCasco { get; set; }
    }

    public interface IBarco : IVeiculoMarinho
    {
    }

    public interface IBarcoMotor : IBarco
    {
        void Ligar();
    }

    public class SuperBarco : IBarcoMotor
    {
        public int EspessuraDoCasco { get; set; }
        public string Cor { get; set; }

        public void Andar()
        {
        }

        public void Ligar()
        {
        }
    }
}
