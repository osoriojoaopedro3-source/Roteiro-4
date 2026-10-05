using System;

public interface IVeiculo
{
    void Mover(); // Método sem implementação
}

public class Carro : IVeiculo
{
    public void Mover()
    {
        Console.WriteLine("O carro está se movendo");
    }
}

public class Bicicleta : IVeiculo
{
    public void Mover()
    {
        Console.WriteLine("A bicicleta está se movendo");
    }
}

class Program
{
    static void Main()
    {
        // 1. Criando um objeto Carro
        IVeiculo carro = new Carro();

        // 2. Criando um objeto Bicicleta
        IVeiculo bicicleta = new Bicicleta();

        // 3. Chamando o método Mover() de cada objeto
        carro.Mover();      // Saída: O carro está se movendo
        bicicleta.Mover();  // Saída: A bicicleta está se movendo
    }
}
