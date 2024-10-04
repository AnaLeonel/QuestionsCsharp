using System;

abstract class Funcionario // classe abstrata Funcionario
{
    //atributos comuns aos funcionarios
    public string Nome { get; set; }
    public int NumeroIdentificacao { get; set; }
    public string Cargo { get; set; }

    // metodo abstrato para calcular o salario
    public abstract double CalculaSalario();
}

class FuncionarioAssalariado : Funcionario //classe FuncionarioAssalariado herda de Funcionario
{
    public double SalarioFixo { get; set; } // atributo especifico dos assalariados

    public override double CalculaSalario() //implementacao do metodo abstrato
    {
        return SalarioFixo; // calcula salario dos assalariados
    }
}

class FuncionarioPorHora : Funcionario // classe FuncionarioPorHora herda de Funcionario
{
    public double ValorHora { get; set; } // atributo especifico dos que trabalham por hora
    public int HorasTrabalhadas { get; set; }

    public override double CalculaSalario() //implementacao do metodo abstrato
    {
        return ValorHora * HorasTrabalhadas; // calcula salario por hora
    }
}

class FuncionarioComissionado : FuncionarioAssalariado //classe FuncionarioComissionado herda de FuncionarioAssalariado
{
    public double PorcentagemComissao { get; set; }
    public double ValorVendas { get; set; } // atributo especifico dos comissionados

    public override double CalculaSalario() // implementacao do metodo abstrato
    {
        return SalarioFixo + (ValorVendas * PorcentagemComissao / 100); // calcula salario dos comissionados
    }
}

class Program
{
    static void Main()
    {
        //criando vetor de funcionarios
        Funcionario[] funcionarios = new Funcionario[5];

        // fazendo a leitura das informacoes dos funcionarios
        for (int i = 0; i < funcionarios.Length; i++)
        {
            Console.WriteLine("Informe o tipo de funcionario (1-Assalariado, 2-Por Hora, 3-Comissionado):");
            int tipoFuncionario = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o nome do funcionario:");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe o numero de identificacao do funcionario:");
            int numeroIdentificacao = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o cargo do funcionario:");
            string cargo = Console.ReadLine();

            // condicional para instanciar o objeto da classe selecionada
            if (tipoFuncionario == 1)
            {
                Console.WriteLine("Informe o salario fixo do funcionario:");
                double salarioFixo = double.Parse(Console.ReadLine());

                funcionarios[i] = new FuncionarioAssalariado()
                {
                    Nome = nome,
                    NumeroIdentificacao = numeroIdentificacao,
                    Cargo = cargo,
                    SalarioFixo = salarioFixo
                };
            }
            else if (tipoFuncionario == 2)
            {
                Console.WriteLine("Informe o valor por hora do funcionario:");
                double valorHora = double.Parse(Console.ReadLine());

                Console.WriteLine("Informe o numero de horas trabalhadas do funcionario:");
                int horasTrabalhadas = int.Parse(Console.ReadLine());

                funcionarios[i] = new FuncionarioPorHora()
                {
                    Nome = nome,
                    NumeroIdentificacao = numeroIdentificacao,
                    Cargo = cargo,
                    ValorHora = valorHora,
                    HorasTrabalhadas = horasTrabalhadas
                };
            }
            else if (tipoFuncionario == 3)
            {
                Console.WriteLine("Informe a porcentagem de comissao do funcionario:");
                double porcentagemComissao = double.Parse(Console.ReadLine());

                Console.WriteLine("Informe o valor total das vendas do funcionario:");
                double valorVendas = double.Parse(Console.ReadLine());

                funcionarios[i] = new FuncionarioComissionado()
                {
                    Nome = nome,
                    NumeroIdentificacao = numeroIdentificacao,
                    Cargo = cargo,
                    SalarioFixo = 0, //valor inicial zerado pra ser preenchido no calculo do salario
                    PorcentagemComissao = porcentagemComissao,
                    ValorVendas = valorVendas
                };
            }
        }

        // chamando a funcao calcula salario pra cada funcionario e imprimindo as informacoes
        for (int i = 0; i < funcionarios.Length; i++)
        {
            double salario = funcionarios[i].CalculaSalario();
            Console.WriteLine($"Nome: {funcionarios[i].Nome}");
            Console.WriteLine($"Cargo: {funcionarios[i].Cargo}");
            Console.WriteLine($"Salario: {salario}");
        }
    }
}
