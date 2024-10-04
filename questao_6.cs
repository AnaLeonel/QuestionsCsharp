using System;

class Funcionario
{
    public string Nome { get; set; } //atributo nome
    public int Codigo { get; set; } //atributo codigo de identificaçao
    public decimal TotalVendas { get; private set; } //atributo pro total de vendas
    public decimal Comissao { get; private set; } // atributo pra comissao

    public decimal GetTotalVendas()
    {
        return TotalVendas;
    }

    public void AdicionaVenda(decimal valorVenda)
    {
        TotalVendas += valorVenda;
    }

    public decimal GetComissao()
    {
        return Comissao;
    }

    public void AdicionaComissao(decimal valorComissao)
    {
        Comissao += valorComissao;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Funcionario[] funcionarios = new Funcionario[3]; // inicia vetor pra funcionarios de tamanho 3

        for (int i = 0; i < funcionarios.Length; i++) // le os atributos dos funcionarios
        {
            Console.WriteLine($"Funcionário {i + 1}:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Código: ");
            int codigo = int.Parse(Console.ReadLine());

            Funcionario funcionario = new Funcionario(); // cria instancia e atribui valores lidos
            funcionario.Nome = nome;
            funcionario.Codigo = codigo;

            funcionarios[i] = funcionario; // adiciona funcionario ao vetor

            Console.WriteLine();
        }

        foreach (Funcionario funcionario in funcionarios)
        {
            // simula vendas ficticias pra funcionarios
            funcionario.AdicionaVenda(1000); //valor da venda
            funcionario.AdicionaComissao(100); //valor comissao

            //imprime as informaçoes dos funcionarios
            Console.WriteLine($"Nome: {funcionario.Nome}");
            Console.WriteLine($"Código: {funcionario.Codigo}");
            Console.WriteLine($"Total de Vendas: R${funcionario.GetTotalVendas()}");
            Console.WriteLine($"Comissão: R${funcionario.GetComissao()}");

            Console.WriteLine();
        }
    }
}
