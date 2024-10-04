using System;

class Veiculo
{
    // propriedades protegidas
    public string Marca { get; set; } // marca do veículo
    public string Modelo { get; set; } //modelo do veículo
    public int AnoFabricacao { get; set; } // ano de fabricação do veículo
    public decimal Preco { get; set; } // preço do veículo
}

class Carro : Veiculo
{
    // propriedade específica dos carros
    public int NumeroPortas { get; set; } // número de portas do carro
}

class Moto : Veiculo
{
    // propriedade específica das motos
    public int Cilindradas { get; set; } //cilindradas da moto
}

class Caminhao : Veiculo
{
    //propriedade específica dos caminhões
    public int CapacidadeCarga { get; set; } // capacidade de carga do caminhão (em kg)
}

class Program
{
    static void Main()
    {
        // exemplo de uso do sistema de cadastro de veículos

        //criando objetos para representar alguns veículos
        Carro carro1 = new Carro
        {
            Marca = "Volkswagen",
            Modelo = "Gol",
            AnoFabricacao = 2020,
            Preco = 45000,
            NumeroPortas = 4
        };

        Moto moto1 = new Moto
        {
            Marca = "Honda",
            Modelo = "CB 500",
            AnoFabricacao = 2021,
            Preco = 28000,
            Cilindradas = 500
        };

        Caminhao caminhao1 = new Caminhao
        {
            Marca = "Volvo",
            Modelo = "FH 460",
            AnoFabricacao = 2019,
            Preco = 280000,
            CapacidadeCarga = 20000
        };

        // imprimindo as informações dos veículos
        Console.WriteLine("Carro:");
        Console.WriteLine($"Marca: {carro1.Marca}"); // imprime a marca do carro
        Console.WriteLine($"Modelo: {carro1.Modelo}"); // imprime o modelo do carro
        Console.WriteLine($"Ano de Fabricacao: {carro1.AnoFabricacao}"); // imprime o ano de fabricação do carro
        Console.WriteLine($"Preco: R${carro1.Preco}"); //imprime o preço do carro
        Console.WriteLine($"Numero de Portas: {carro1.NumeroPortas}"); // imprime o númerp de portas do carro
        Console.WriteLine();

        Console.WriteLine("Moto:");
        Console.WriteLine($"Marca: {moto1.Marca}"); // imprime a marca da moto
        Console.WriteLine($"Modelo: {moto1.Modelo}"); //imprime o modelo da moto
        Console.WriteLine($"Ano de Fabricacao: {moto1.AnoFabricacao}"); // imprime o ano de fabricação da moto
        Console.WriteLine($"Preco: R${moto1.Preco}"); // imprime o preço da moto
        Console.WriteLine($"Cilindradas: {moto1.Cilindradas}"); // imprime as cilindradas da moto
        Console.WriteLine();

        Console.WriteLine("Caminhao:");
        Console.WriteLine($"Marca: {caminhao1.Marca}"); // imprime a marca do caminhão
        Console.WriteLine($"Modelo: {caminhao1.Modelo}"); // imprime o modelo do caminhão
        Console.WriteLine($"Ano de Fabricacao: {caminhao1.AnoFabricacao}"); // imprime o ano de fabricação do caminhão
        Console.WriteLine($"Preco: R${caminhao1.Preco}"); //imprime o preço do caminhão
        Console.WriteLine($"Capacidade de Carga: {caminhao1.CapacidadeCarga} kg"); // imprime a capacidade de carga do caminhão
    }
}
