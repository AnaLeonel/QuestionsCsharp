using System;

class Funcionario
{
    public string Nome { get; set; } // atributo nome
    public int Codigo { get; set; } // atributo pra codigo de identificaçao
    public decimal TotalVendas { get; set; } //atributo pro total de vendas 
    public decimal Comissao { get; set; } //atributo pra comissao
}

class Program
{
    static void Main(string[] args)
    {
        Funcionario[] funcionarios = new Funcionario[3] //vetor com dados dos funcionários
        {
            // os nomes sao dos meus gatos hehe
            new Funcionario { Nome = "Lisa", Codigo = 1 },
            new Funcionario { Nome = "Elso", Codigo = 2 },
            new Funcionario { Nome = "Ozzy", Codigo = 3 }
        };

        PagaComissao(1, 50.0m, 5, funcionarios); //chama funçao de pagamento da comissao

        foreach (Funcionario funcionario in funcionarios) //imprime informaçoes atualizadas dos funcionarios
        {
            Console.WriteLine($"Nome: {funcionario.Nome}");
            Console.WriteLine($"Código: {funcionario.Codigo}");
            Console.WriteLine($"Total de Vendas: R${funcionario.TotalVendas}");
            Console.WriteLine($"Comissão: R${funcionario.Comissao}");
            Console.WriteLine();
        }
    }

    static void PagaComissao(int codigoVendedor, decimal precoUnitario, int qtde, Funcionario[] funcionarios)
    {
        Funcionario funcionario = Array.Find(funcionarios, f => f.Codigo == codigoVendedor); //procura o funcionario com o codigo digitado dentro do vetor

        if (funcionario != null)
        {
            decimal totalVenda = precoUnitario * qtde; //calcula valor total da venda

            decimal comissao = totalVenda * 0.05m; //comissao (5% do valor total)

            funcionario.TotalVendas += totalVenda; //atribui valores ao funcionario
            funcionario.Comissao += comissao;
        }
        else
        {
            Console.WriteLine("Funcionário não encontrado.");
        }
    }
}
