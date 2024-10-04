using System;

abstract class Funcionario //classe abstrata Funcionario
{
    //atributos comuns aos funcionários
    public string Nome { get; set; }
    public int NumeroIdentificacao { get; set; }
    public string Cargo { get; set; }

    //metodo abstrato para calcular o salario
    public abstract double CalculaSalario();
}

class FuncionarioAssalariado : Funcionario //classe FuncionarioAssalariado
{
    public double SalarioFixo { get; set; } //atributo especifico dos assalariados

    public override double CalculaSalario() //implementa metodo abstrato
    {
        return SalarioFixo; //calcula salario dos assalariados
    }
}

class FuncionarioPorHora : Funcionario //classe FuncionarioPorHora
{
    public double ValorHora { get; set; } //atributo especifico dos que trabalham por hora
    public int HorasTrabalhadas { get; set; }

    public FuncionarioPorHora(double valorHora, int horasTrabalhadas) //construtor
    {
        ValorHora = valorHora; //armazena o valor por hora
        HorasTrabalhadas = horasTrabalhadas; //armazena o número de horas trabalhadas
    }

    public override double CalculaSalario() //implementa metodo abstrato
    {
        return ValorHora * HorasTrabalhadas; //calcula salario por hora
    }
}

class FuncionarioComissionado : Funcionario //classe FuncionarioComissionado
{
    public double SalarioBase { get; set; }
    public double ComissaoVendas { get; set; } //atributo especifico dos comissionados

    public override double CalculaSalario() //implementa metodo abstrato
    {
        return SalarioBase + ComissaoVendas; //calcula salario dos comissionados
    }
}

class Program
{
    static void Main()
    {
        //usando as classes
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

        var funcionario3 = new FuncionarioComissionado()
        {
            Nome = "Ozzy",
            NumeroIdentificacao = 3,
            Cargo = "Vendedor",
            SalarioBase = 2000,
            ComissaoVendas = 1000
        };

        //impressao dos salarios
        Console.WriteLine($"Salário do {funcionario1.Cargo} {funcionario1.Nome}: {funcionario1.CalculaSalario()}");
        Console.WriteLine($"Salário do {funcionario2.Cargo} {funcionario2.Nome}: {funcionario2.CalculaSalario()}");
        Console.WriteLine($"Salário do {funcionario3.Cargo} {funcionario3.Nome}: {funcionario3.CalculaSalario()}");
    }
}
