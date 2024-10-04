using System;

abstract class Funcionario //classe abstrata Funcionario
{
    //atributos comuns aos funcionários
    public string Nome { get; set; }
    public int NumeroIdentificacao { get; set; }
    public string Cargo { get; set; }

    //metodo abstrato pra calcular o salario
    public abstract double CalculaSalario();
}

class FuncionarioAssalariado : Funcionario //classe funcionario assalariado
{
    public double SalarioFixo { get; set; } //atributo especifico dos assalariados

    public override double CalculaSalario() //implementa metodo abstratp
    {
        return SalarioFixo; //calcula saiario dos assalariados
    }
}

class FuncionarioPorHora : Funcionario //classe funcionario por hora
{
    public double ValorHora { get; set; } //atributo especifico dos que trabalham por hora
    public int HorasTrabalhadas { get; set; }

    public override double CalculaSalario() //implementa metodo abstrato
    {
        return ValorHora * HorasTrabalhadas; //calcula salario por hora
    }
}

class FuncionarioComissionado : Funcionario //classe funcionario comissionado
{
    public double SalarioBase { get; set; } 
    public double ComissaoVendas { get; set; } //atributo especifico dos comissionados

    public override double CalculaSalario() //implementaçao do metodo abstrato
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

        //impressao dos salarios
        Console.WriteLine($"Salário do {funcionario1.Cargo} {funcionario1.Nome}: {funcionario1.CalculaSalario()}");
        Console.WriteLine($"Salário do {funcionario2.Cargo} {funcionario2.Nome}: {funcionario2.CalculaSalario()}");
        Console.WriteLine($"Salário do {funcionario3.Cargo} {funcionario3.Nome}: {funcionario3.CalculaSalario()}");
    }
}
