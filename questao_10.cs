using System;

abstract class Funcionario //classe abstrata Funcionario
{
    //atributos comuns aos funcionários
    public string Nome { get; set; }
    public int NumeroIdentificacao { get; set; }
    public string Cargo { get; set; }

    //método abstrato para calcular o salário
    public abstract double CalculaSalario();
}

class FuncionarioAssalariado : Funcionario //classe FuncionarioAssalariado herda da classe Funcionario
{
    public double SalarioFixo { get; set; } //atributo específico dos assalariados

    public FuncionarioAssalariado(double salarioFixo) //construtor que recebe o salário fixo do funcionário
    {
        SalarioFixo = salarioFixo;
    }

    public override double CalculaSalario() //sobrescrita do método abstrato para calcular o salário
    {
        return SalarioFixo; //cálculo do salário dos assalariados
    }
}

class FuncionarioPorHora : Funcionario //classe FuncionarioPorHora
{
    //atributos específicos dos funcionários por hora
    public double ValorHora { get; set; }
    public int HorasTrabalhadas { get; set; }

    public override double CalculaSalario() //implementação do método abstrato
    {
        return ValorHora * HorasTrabalhadas; //cálculo do salário por hora
    }
}

class FuncionarioComissionado : Funcionario //classe FuncionarioComissionado
{
    //atributos específicos dos funcionários comissionados
    public double SalarioBase { get; set; }
    public double ComissaoVendas { get; set; }

    public override double CalculaSalario() //implementação do método abstrato
    {
        return SalarioBase + ComissaoVendas; //cálculo do salário dos comissionados
    }
}

class Program
{
    static void Main()
    {
        //usando as classes
        var funcionario1 = new FuncionarioAssalariado(50000) //criando um objeto FuncionarioAssalariado e passando o salário fixo como argumento
        {
            Nome = "Lisa",
            NumeroIdentificacao = 1,
            Cargo = "Gerente"
        };

        var funcionario2 = new FuncionarioPorHora()
        {
            Nome = "Elso",
            NumeroIdentificacao = 2,
            Cargo = "Atendente",
            ValorHora = 30,
            HorasTrabalhadas = 160
        };

        var funcionario3 = new FuncionarioComissionado()
        {
            Nome = "Ozzy",
            NumeroIdentificacao = 3,
            Cargo = "Vendedor",
            SalarioBase = 2000,
            ComissaoVendas = 1000
        };

        //impressão dos salários
        Console.WriteLine($"Salário do {funcionario1.Cargo} {funcionario1.Nome}: {funcionario1.CalculaSalario()}");
        Console.WriteLine($"Salário do {funcionario2.Cargo} {funcionario2.Nome}: {funcionario2.CalculaSalario()}");
        Console.WriteLine($"Salário do {funcionario3.Cargo} {funcionario3.Nome}: {funcionario3.CalculaSalario()}");
    }
}
