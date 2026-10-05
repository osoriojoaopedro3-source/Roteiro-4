using System;

public interface IVoar
{
    void Voar();
}

public interface INadar
{
    void Nadar();
}

// Pato pode voar e nadar: implementa as duas interfaces
public class Pato : IVoar, INadar
{
    public void Voar()
    {
        Console.WriteLine("O pato está voando");
    }

    public void Nadar()
    {
        Console.WriteLine("O pato está nadando");
    }
}

// Águia só pode voar
public class Aguia : IVoar
{
    public void Voar()
    {
        Console.WriteLine("A águia está voando");
    }
}

// Peixe só pode nadar
public class Peixe : INadar
{
    public void Nadar()
    {
        Console.WriteLine("O peixe está nadando");
    }
}

class Program
{
    static void Main()
    {
        // 1. Criando um Pato
        Pato pato = new Pato();

        // 2. Fazendo o pato voar e nadar
        pato.Voar();
        pato.Nadar();

        // 3. Criando uma Águia
        Aguia aguia = new Aguia();

        // 4. Fazendo a águia voar
        aguia.Voar();

        // 5. Criando um Peixe
        Peixe peixe = new Peixe();

        // 6. Fazendo o peixe nadar
        peixe.Nadar();
    }
}
