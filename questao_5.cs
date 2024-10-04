using System;

abstract class Animal // cria classe abstrata animal
{
    public abstract void EmitirSom(); // aqui está o método abstrato EmitirSom()
}

class Cachorro : Animal // classe cachorro derivada da classe animal
{
    public override void EmitirSom() // método EmitirSom pro cachorro
    {
        Console.WriteLine("O cachorro late");
    }
}

class Gato : Animal // classe gato derivada da classe animal
{
    public override void EmitirSom() //método EmitirSom pro gato
    {
        Console.WriteLine("O gato mia");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal[] animais = new Animal[4]; // cria vetor com tamanho 4

        animais[0] = new Cachorro(); // cria instancia de um objeto cachorro e atribui ao vetor
        animais[1] = new Gato(); //cria instancia de um objeto gato e atribui ao vetor
        animais[2] = new Cachorro(); //cria instancia de mais um objeto cachorro e atribui ao vetor
        animais[3] = new Gato(); // cria instancia de mais um objeto gato e atribui ao vetor

        foreach (Animal animal in animais) //percorre o vetor animais
        {
            animal.EmitirSom(); //chama o método de cada objeto no vetor
        }
    }
}
