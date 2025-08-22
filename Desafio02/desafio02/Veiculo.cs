using System;

namespace desafio02;

class Veiculo
{
    public string Nome { get; set; }
    public int Velocidade { get; set; }

    public virtual void Mover()
    {
        Console.WriteLine("O veículo está se movendo...");
    }
}