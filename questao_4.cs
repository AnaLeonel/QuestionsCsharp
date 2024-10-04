using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o tamanho do vetor: ");
        int N = int.Parse(Console.ReadLine()); // armazena o numero que o usuario digitou

        float[] vet = new float[N]; // o vetor float fica do tamanho que o usuário escolheu

        for (int i = 0; i < N; i++)
        {
            Console.Write($"Digite o valor #{i + 1}: ");
            vet[i] = float.Parse(Console.ReadLine()); //armazena os valores do usuário nas respectivas posições do vetor
        }

        float[] vetInvertido = InverteVetor(vet); //aqui a funçao que inverte o vetor eh chamada
        Console.WriteLine("Vetor invertido:");
        ImprimeVetor(vetInvertido); // o vetor invertido eh impresso aqui

        SomaValores(vet); // chama a funçao que soma os valores do vetor

        bool ehCrescente = Crescente(vet); // chama a funçao pra checar se o vetor ta em ordem crescente
        Console.WriteLine($"O vetor está em ordem crescente: {ehCrescente}");
    }

    static float[] InverteVetor(float[] vet) //função pra inverter o vetor
    {
        float[] vetInvertido = new float[vet.Length]; //um vetor com o mesmo tamanho é criado pra receber a versão invertida
        int j = 0; // novo contador

        for (int i = vet.Length - 1; i >= 0; i--) // looping pra percorrer o vetor de trás pra frente
        {
            vetInvertido[j] = vet[i]; //coloca os valores do vetor original no vetor invertidfo
            j++;
        }

        return vetInvertido; //retorna o vetor invertido
    }

    static void SomaValores(float[] vet) //função que calcula a soma dos valores do vetor e checa se essa soma eh divisivel por 3
    {
        float soma = 0;

        for (int i = 0; i < vet.Length; i++)
        {
            soma += vet[i]; // aqui cada valor é somado
        }

        Console.WriteLine($"A soma dos valores é: {soma}");

        if (soma % 3 == 0) // se o resto da divisão por 3 for igual a zero, então a soma é divisivel por 3
        {
            Console.WriteLine("A soma é divisível por 3.");
        }
        else
        {
            Console.WriteLine("A soma não é divisível por 3.");
        }
    }

    static bool Crescente(float[] vet) //funçao pra verificar se os elementos dentro do vetor estao na ordem crescente
    {
        for (int i = 1; i < vet.Length; i++)
        {
            if (vet[i] < vet[i - 1]) // checa se a posiçao atual é menor que a posiçao anterior
            {
                return false; //se nao tiver em ordem crescente, retorna false
            }
        }

        return true; //sai do loop e retorna true caso o vetor esteja em ordem crescente
    }

    static void ImprimeVetor(float[] vet) // funçao sem retorno pra imprimir os valores do vetor
    {
        for (int i = 0; i < vet.Length; i++)
        {
            Console.WriteLine(vet[i]); //imprime cada valor
        }
    }
}
