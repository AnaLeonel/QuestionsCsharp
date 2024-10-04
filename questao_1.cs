using System;

class Program
{
    static int[] vet; //declara vetor

    static void Main(string[] args)
    {
        int opcao;
        do
        {
            Console.WriteLine("Escolha uma opção:"); //mostra as opções pro usuário
            Console.WriteLine("1 - Ler valores do vetor");
            Console.WriteLine("2 - Listar Vetor (exibir os valores armazenados)");
            Console.WriteLine("3 - Exibir apenas os números pares do vetor");
            Console.WriteLine("4 - Exibir apenas os números ímpares do vetor");
            Console.WriteLine("5 - Exibir a quantidade de números pares nas posições ímpares do vetor");
            Console.WriteLine("6 - Exibir a quantidade de números ímpares nas posições pares do vetor");
            Console.WriteLine("7 - Sair");
            Console.Write("Opção: ");
            opcao = int.Parse(Console.ReadLine()); //guarda o número

            // switch como estrutura de controle ao invés de if-else já que temos muitas opções
            switch (opcao)
            {
                // cada caso selecionado vai chamar uma função
                case 1:
                    LeValores();
                    break;
                case 2:
                    ListaVetor();
                    break;
                case 3:
                    ExibePares();
                    break;
                case 4:
                    ExibeImpares();
                    break;
                case 5:
                    if (vet == null)
                    {
                        Console.WriteLine("Selecione primeiro a opção 1 para que o tamanho do vetor seja armazenado.");
                    }
                    else
                    {
                        ExibeQdeParesPosImpares();
                    }
                    break;
                case 6:
                    if (vet == null)
                    {
                        Console.WriteLine("Selecione primeiro a opção 1 para que o tamanho do vetor seja armazenado.");
                    }
                    else
                    {
                        ExibeQdeImparesPosPares();
                    }
                    break;
                case 7:
                    Console.WriteLine("Saindo.");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

            Console.WriteLine();
        } while (opcao != 7);
    }

    // as funções que foram chamadas ali em cima agora vão ser definidas

    static void LeValores()
    {
        Console.Write("Digite o tamanho do vetor: ");
        int tam = int.Parse(Console.ReadLine()); // armazena o valor digitado pelo usuário
        vet = new int[tam]; // o vetor recebe o tamanho que o usuário digitou

        for (int i = 0; i < tam; i++) // loop pra percorrer o vetor com os números digitados pelo usuário
        {
            Console.Write($"Digite o valor para a posição {i}: "); 
            vet[i] = int.Parse(Console.ReadLine()); //armazena cada valor em sua respectiva posição
        }

        Console.WriteLine("Os valores foram armazenados.");
    }

    static void ListaVetor()
    {
        if (vet == null) // esse if vai aparecer nas próximas funções pq não dá pra executar nenhuma delas sem saber o tamanho do vetor e os números digitados
        {
            Console.WriteLine("Os valores do vetor não foram lidos ainda. Por favor, selecione a opção 1 para ler os valores.");
        }
        else
        {
            Console.WriteLine("Valores do vetor:");
            for (int i = 0; i < vet.Length; i++) // loop pra percorrer o vetor e imprimir as posições que o usuário digitou
            {
                Console.WriteLine($"Posição {i}: {vet[i]}"); // imprime cada número em sua respectiva posição
            }
        }
    }

    static void ExibePares()
    {
        if (vet == null)
        {
            Console.WriteLine("Os valores do vetor não foram lidos ainda. Por favor, selecione a opção 1 para ler os valores.");
        }
        else
        {
            Console.WriteLine("Números pares do vetor:");
            for (int i = 0; i < vet.Length; i++)
            {
                if (vet[i] % 2 == 0) // procura números pares no vetor. quando o resto eh igual a zero, o número eh par.
                {
                    Console.WriteLine(vet[i]); // imprime os pares em suas posições caso existam
                }
            }
        }
    }

    static void ExibeImpares()
    {
        if (vet == null)
        {
            Console.WriteLine("Os valores do vetor não foram lidos ainda. Por favor, selecione a opção 1 para ler os valores.");
        }
        else
        {
            Console.WriteLine("Números ímpares do vetor:");
            for (int i = 0; i < vet.Length; i++)
            {
                if (vet[i] % 2 != 0) // mesmo esquema da função de cima, agora quando o resto da divisão do número por 2 for igual a 1.
                {
                    Console.WriteLine(vet[i]); //imprime os ímpares em suas posições caso existam
                }
            }
        }
    }

    static void ExibeQdeParesPosImpares() // quantidade de valores pares em posições ímpares
    {
        int count = 0; // inicia outro contador
        for (int i = 1; i < vet.Length; i += 2) // contador "i" inicia na posição 1 conta de 2 em 2, assim só vai contar posições ímpares
        {
            if (vet[i] % 2 == 0) // procura valores pares
            {
                count++; // conta quantos valores são pares
            }
        }
        Console.WriteLine($"Quantidade de números pares nas posições ímpares: {count}"); //imprime quantidade de pares em posições ímpares
    }

    static void ExibeQdeImparesPosPares() // quantidade de valores ímpares em posiões pares
    {
        int count = 0; //inicia outro contador
        for (int i = 0; i < vet.Length; i += 2) // aqui o contador "i" começa na posição 0, e o vetor vai ser percorrido de 2 em 2, assim só vai contar posições pares
        {
            if (vet[i] % 2 != 0) //procura ímpares
            {
                count++; // conta quantos valores são ímpares
            }
        }
        Console.WriteLine($"Quantidade de números ímpares nas posições pares: {count}"); //imprime a quantidade de números ímpares nas posições pares
    }
}
