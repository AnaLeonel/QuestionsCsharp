using System;

abstract class Funcionario // classe abstrata Funcionario
{
    // atributos comuns aos funcionários
    public string Nome { get; set; }
    public int NumeroIdentificacao { get; set; }
    public string Cargo { get; set; }

    // método abstrato para calcular o salário
    public abstract double CalculaSalario();
}

class FuncionarioAssalariado : Funcionario // classe FuncionarioAssalariado
{
    public double SalarioFixo { get; set; } // atributo específico dos assalariados

    public override double CalculaSalario() // implementa método abstrato
    {
        return SalarioFixo; // calcula salário dos assalariados
    }
}

class FuncionarioPorHora : Funcionario // classe FuncionarioPorHora
{
    public double ValorHora { get; set; } // atributo específico dos que trabalham por hora
    public int HorasTrabalhadas { get; set; }

    public FuncionarioPorHora(double valorHora, int horasTrabalhadas) // construtor
    {
        ValorHora = valorHora; // armazena o valor por hora
        HorasTrabalhadas = horasTrabalhadas; // armazena o número de horas trabalhadas
    }

    public override double CalculaSalario() // implementa método abstrato
    {
        return ValorHora * HorasTrabalhadas; // calcula salário por hora
    }
}

class FuncionarioComissionado : FuncionarioAssalariado // classe FuncionarioComissionado herda de FuncionarioAssalariado
{
    public double PorcentagemComissao { get; set; } // atributo específico dos comissionados
    public double ValorVendas { get; set; }

    public FuncionarioComissionado(double porcentagemComissao, double valorVendas, double salarioFixo)
    {
        PorcentagemComissao = porcentagemComissao; // armazena a porcentagem da comissão
        ValorVendas = valorVendas; // armazena o valor total das vendas
        SalarioFixo = salarioFixo; // armazena o salário fixo
    }

    public override double CalculaSalario() // sobrescreve o método abstrato
    {
        double comissao = ValorVendas * (PorcentagemComissao / 100); // calcula o valor da comissão
        return SalarioFixo + comissao; // calcula o salário do funcionário comissionado
    }
}

class Program
{
    static void Main()
    {
        // usando as classes
        var funcionario1 = new FuncionarioAssalariado()
        {
            Nome = "Lisa",
            NumeroIdentificacao = 1,
            Cargo = "Gerente",
            SalarioFixo = 50000
        };

        var funcionario2 = new FuncionarioPorHora(valorHora: 30, horasTrabalhadas: 160)
        {
            Nome = "Elso",
            NumeroIdentificacao = 2,
            Cargo = "Atendente"
        };

        var funcionario3 = new FuncionarioComissionado(porcentagemComissao: 10, valorVendas: 5000, salarioFixo: 2000)
        {
            Nome = "Ozzy",
            NumeroIdentificacao = 3,
            Cargo = "Vendedor"
        };

        // impressão dos salários
        Console.WriteLine($"Salário do {funcionario1.Cargo} {funcionario1.Nome}: {funcionario1.CalculaSalario()}");
        Console.WriteLine($"Salário do {funcionario2.Cargo} {funcionario2.Nome}: {funcionario2.CalculaSalario()}");
        Console.WriteLine($"Salário do {funcionario3.Cargo} {funcionario3.Nome}: {funcionario3.CalculaSalario()}");
    }
}
