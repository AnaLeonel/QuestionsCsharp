using System;

class Funcionario
{
    public string Nome { get; set; } // atributo nome
    public int Codigo { get; set; } // atributo pro código de identificação
    public decimal TotalVendas { get; set; } // atributo pro total de vendas
    public decimal Comissao { get; set; } // atributo pra comissão
}

class Program
{
    static void Main(string[] args)
    {
        Funcionario[] funcionarios = new Funcionario[3] // vetor com dados dos funcionários
        {
            new Funcionario { Nome = "Lisa", Codigo = 1 },
            new Funcionario { Nome = "Elso", Codigo = 2 },
            new Funcionario { Nome = "Ozzy", Codigo = 3 }
        };

        bool continuar = true; // variável pra controlar o loop

        while (continuar)
        {
            Console.WriteLine("Digite a ação desejada: 1 para contabilizar venda, 2 para sair");
            int acao = Convert.ToInt32(Console.ReadLine()); //converte pra numero inteiro

            switch (acao) //estrutura de controle pra muitas alternativas
            {
                case 1:
                    Console.WriteLine("Digite o código de identificação do funcionário:");
                    int codigoVendedor = Convert.ToInt32(Console.ReadLine()); //le codigo de identificaçao do funcionario

                    Console.WriteLine("Digite o preço da peça vendida:");
                    decimal precoUnitario = Convert.ToDecimal(Console.ReadLine()); //le o preço, converte pra decimal

                    Console.WriteLine("Digite a quantidade vendida:");
                    int qtde = Convert.ToInt32(Console.ReadLine()); //le a quantidade e converte pra inteiro

                    PagaComissao(codigoVendedor, precoUnitario, qtde, funcionarios); //chama a função pra adicionar as informaçoes ao funcionario
                    break;

                case 2:
                    continuar = false; //encerra o loop
                    break;

                default: //caso o usuario digite um numero diferente de 1 ou 2
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }

        foreach (Funcionario funcionario in funcionarios) //loop pra percorrer os elementos
        {
            //imprime os dados do funcionário
            Console.WriteLine($"Nome: {funcionario.Nome}");
            Console.WriteLine($"Código: {funcionario.Codigo}");
            Console.WriteLine($"Total de Vendas: R${funcionario.TotalVendas}");
            Console.WriteLine($"Comissão: R${funcionario.Comissao}");
            Console.WriteLine();
        }
    }

    static void PagaComissao(int codigoVendedor, decimal precoUnitario, int qtde, Funcionario[] funcionarios) //funçao recebe como parametro os dados dos funcionarios
    {
        Funcionario funcionario = Array.Find(funcionarios, f => f.Codigo == codigoVendedor);

        if (funcionario != null)
        {
            decimal totalVenda = precoUnitario * qtde; // calcula o valor total da venda
            decimal comissao = totalVenda * 0.05m; // calcula a comissão (5% do valor total)

            funcionario.TotalVendas += totalVenda; // atribui os valores ao funcionário
            funcionario.Comissao += comissao;
        }
        else
        {
            Console.WriteLine("Funcionário não encontrado.");
        }
    }
}



//os resultados sao impressos quando a opção 2 eh selecionada