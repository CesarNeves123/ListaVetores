using System;
using Arrays;

public class Exercicio_1
{
    static int Somavetor(int[] vetor)
    {
        int soma = 0;
        for (int i = 0; i < vetor.Length; i++)
        {
            soma += vetor[i];

        }
        return soma;
    }
    public static void Main()
    {
        int n;
        Console.WriteLine("Tamanho do vetor");
        n = int.Parse(Console.ReadLine());
        int[] vetor = new int[n];

        BibliotecaArray.geraVetor(vetor);
        Console.WriteLine("Vetor gerado:");
        BibliotecaArray.mostraVetor(vetor);
        int soma = Somavetor(vetor);
        Console.WriteLine(" \n Soma do vetor: ");
        Console.WriteLine($" {Somavetor(vetor)}");
        Console.ReadKey();

    }
}


