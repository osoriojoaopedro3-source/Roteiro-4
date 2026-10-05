using System;

// Classe base
public class Veiculo
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int NumeroDeRodas { get; set; }

    public void ExibirDados()
    {
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Número de rodas: {NumeroDeRodas}");
    }
}

// Carro herda de Veiculo
public class Carro : Veiculo
{
    public int NumeroDePortas { get; set; }
}

// Moto herda de Veiculo
public class Moto : Veiculo
{
    public bool PossuiBagageiro { get; set; }
}

class Program
{
    static void Main()
    {
        // 1. Criando um objeto Carro e informando seus dados
        Carro carro = new Carro();
        carro.Marca = "Toyota";        // atributo herdado de Veiculo
        carro.Modelo = "Corolla";      // atributo herdado de Veiculo
        carro.NumeroDeRodas = 4;       // atributo herdado de Veiculo
        carro.NumeroDePortas = 4;      // atributo específico de Carro

        // 2. Criando um objeto Moto e informando seus dados
        Moto moto = new Moto();
        moto.Marca = "Honda";          // atributo herdado de Veiculo
        moto.Modelo = "CG 160";        // atributo herdado de Veiculo
        moto.NumeroDeRodas = 2;        // atributo herdado de Veiculo
        moto.PossuiBagageiro = true;   // atributo específico de Moto

        // 3 e 4. Exibindo dados herdados e características específicas
        Console.WriteLine("=== Carro ===");
        carro.ExibirDados();
        Console.WriteLine($"Número de portas: {carro.NumeroDePortas}");

        Console.WriteLine();

        Console.WriteLine("=== Moto ===");
        moto.ExibirDados();
        Console.WriteLine($"Possui bagageiro: {(moto.PossuiBagageiro ? "Sim" : "Não")}");
    }
}
