using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite a quantidade de valores: ");
        int n = int.Parse(Console.ReadLine()); //lê quantidade de valores

        int inIntervalo = 0; //inicia variável pra valores dentro do intervalo
        int outIntervalo = 0; //inicia variável pra valores fora do intervalo

        for (int i = 0; i < n; i++) //looping pra contar quais estão dentro e quais estão fora
        {
            Console.Write($"Digite o valor #{i + 1}: ");
            float x = float.Parse(Console.ReadLine()); //guarda os números digitados

            if (x >= 10 && x <= 20) //define intervalo
            {
                inIntervalo++; //conta os que tão dentro
            }
            else
            {
                outIntervalo++; //conta os que tão fora
            }
        }

        Console.WriteLine($"Valores IN: {inIntervalo}"); // imprime os que tão dentro
        Console.WriteLine($"Valores OUT: {outIntervalo}"); //imprime os que tão fora
    }
}
