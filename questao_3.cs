using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite uma frase: ");
        string frase = Console.ReadLine(); // guarda frase na string

        string[] palavras = frase.Split(' '); // o .Split quebra a frase em palavras toda vez que aparece um espaço em branco

        for (int i = 0; i < palavras.Length; i++) // loop pra procurar vogais
        {
            int contVogais = ContaVogais(palavras[i]); // chama função que conta vogais em cada palavra percorrendo cada posição da string pra fazer a comparação
            Console.WriteLine($"Palavra: {palavras[i]} - Número de vogais: {contVogais}"); //imprime quantas vogais tem na palavra
        }
    }

    static int ContaVogais(string palavra) // função pra contar vogais que recebe como parâmetro a string palavra
    {
        int cont = 0; // inicia contador

        palavra = palavra.ToLower(); // esse comando faz as letras serem sempre minúsculas, assim torna a comparação mais fácil

        // Iterar sobre cada caractere da palavra
        for (int i = 0; i < palavra.Length; i++)
        {
            if (EhVogal(palavra[i])) // conta se o caractere for uma vogal
            {
                cont++;
            }
        }

        return cont;
    }

    static bool EhVogal(char caractere) //funçao booleana pra identificar caracteres que sao vogais
    {
        // Definir as vogais válidas
        char[] vogais = { 'a', 'e', 'i', 'o', 'u' }; //define quais caracteres sao as vogais

        for (int i = 0; i < vogais.Length; i++) // loop pra percorrer a string
        {
            if (caractere == vogais[i]) // if pra fazer a comparação dos caracteres declarados acima e verificar se eh uma vogal
            {
                return true;
            }
        }

        return false;
    }
}
