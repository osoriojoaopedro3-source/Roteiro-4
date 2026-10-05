using System;

public class Pessoa
{
    public string Nome { get; set; }
}

public class Casa
{
    // Composição: uma Casa "tem uma" Pessoa
    private Pessoa morador;

    // Construtor: recebe a pessoa que vai morar na casa
    public Casa(Pessoa pessoa)
    {
        morador = pessoa;
    }

    public void ExibirMorador()
    {
        Console.WriteLine($"Morador da casa: {morador.Nome}");
    }
}

class Program
{
    static void Main()
    {
        // 1. Criando um objeto Pessoa
        Pessoa pessoa = new Pessoa();

        // 2. Informando o nome da pessoa
        pessoa.Nome = "João";

        // 3 e 4. Criando um objeto Casa e colocando a Pessoa dentro dela
        Casa casa = new Casa(pessoa);

        // 5. Chamando o método ExibirMorador()
        casa.ExibirMorador();
    }
}
