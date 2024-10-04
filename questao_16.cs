using System;
using System.Collections.Generic;

class Veiculo
{
    public string Marca { get; set; } // marca do veículo
    public string Modelo { get; set; } // modelo do veículo
    public int AnoFabricacao { get; set; } // ano de fabricação do veículo
    public decimal Preco { get; set; } // preço do veículo
}

class Carro : Veiculo
{
    public int QuantidadePortas { get; set; } // quantidade de portas do carro
}

class Moto : Veiculo
{
    public int Cilindradas { get; set; } // cilindradas da moto
}

class Caminhao : Veiculo
{
    public decimal CapacidadeCarga { get; set; } // capacidade de carga do caminhão
}

class CadastroVeiculos
{
    private List<Veiculo> veiculos; // lista de veículos cadastrados

    public CadastroVeiculos()
    {
        veiculos = new List<Veiculo>(); // inicializa a lista de veículos
    }

    public void AdicionarVeiculo(Veiculo veiculo)
    {
        veiculos.Add(veiculo); // adiciona um veículo ao cadastro
    }

    public void ExibirVeiculosCadastrados()
    {
        foreach (Veiculo veiculo in veiculos) // itera sobre os veículos cadastrados
        {
            Console.WriteLine("Veiculo:");
            Console.WriteLine($"Marca: {veiculo.Marca}");
            Console.WriteLine($"Modelo: {veiculo.Modelo}");
            Console.WriteLine($"Ano de Fabricacao: {veiculo.AnoFabricacao}");
            Console.WriteLine($"Preco: R${veiculo.Preco}");

            if (veiculo is Carro)
            {
                Carro carro = (Carro)veiculo; // faz o cast para a classe Carro
                Console.WriteLine($"Quantidade de Portas: {carro.QuantidadePortas}");
            }
            else if (veiculo is Moto)
            {
                Moto moto = (Moto)veiculo; // faz o cast para a classe Moto
                Console.WriteLine($"Cilindradas: {moto.Cilindradas}");
            }
            else if (veiculo is Caminhao)
            {
                Caminhao caminhao = (Caminhao)veiculo; // faz o cast para a classe Caminhao
                Console.WriteLine($"Capacidade de Carga: {caminhao.CapacidadeCarga} kg");
            }

            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main()
    {
        CadastroVeiculos cadastro = new CadastroVeiculos(); // instancia o cadastro de veículos

        // adicionando veículos ao cadastro
        Carro carro1 = new Carro
        {
            Marca = "Volkswagen",
            Modelo = "Gol",
            AnoFabricacao = 2020,
            Preco = 45000,
            QuantidadePortas = 4
        };
        cadastro.AdicionarVeiculo(carro1);

        Moto moto1 = new Moto
        {
            Marca = "Honda",
            Modelo = "CB 500",
            AnoFabricacao = 2021,
            Preco = 28000,
            Cilindradas = 500
        };
        cadastro.AdicionarVeiculo(moto1);

        Caminhao caminhao1 = new Caminhao
        {
            Marca = "Volvo",
            Modelo = "FH 460",
            AnoFabricacao = 2019,
            Preco = 280000,
            CapacidadeCarga = 20000
        };
        cadastro.AdicionarVeiculo(caminhao1);

        // exibindo os veículos cadastrados
        cadastro.ExibirVeiculosCadastrados();
    }
}
