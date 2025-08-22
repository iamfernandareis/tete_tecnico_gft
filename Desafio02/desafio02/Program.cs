using System;
using desafio02;

class Program
{
    static void Main()
    {
        Console.WriteLine("Escolha o primeiro veículo (Carro, Moto ou Bicicleta):");
        string escolha1 = Console.ReadLine().ToLower();

        Console.WriteLine("Escolha o segundo veículo (Carro, Moto ou Bicicleta):");
        string escolha2 = Console.ReadLine().ToLower();

        Veiculo veiculo1;
        Veiculo veiculo2;

        if (escolha1 == "carro")
            veiculo1 = new Carro();
        else if (escolha1 == "moto")
            veiculo1 = new Moto();
        else if (escolha1 == "bicicleta") 
            veiculo1 = new Bicicleta();
        else
            veiculo1 = null;

        if (escolha2 == "carro")
            veiculo2 = new Carro();
        else if (escolha2 == "moto")
            veiculo2 = new Moto();
        else if (escolha2 == "bicicleta")
            veiculo2 = new Bicicleta();
        else veiculo2 = null;

        if (veiculo1 == null || veiculo2 == null)
        {
            Console.WriteLine("Uma das escolhas é inválida.");
            return;
        }

        Console.WriteLine($"\nVeículos escolhidos: {escolha1} vs {escolha2}");
        veiculo1.Mover();
        veiculo2.Mover();
    }
}
