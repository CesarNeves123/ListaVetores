using System;
using Arrays;



public class Exercicio_4
{
    static int qtdImpar(int[] vetor)
    {
        int impar = 0;
        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] % 2 == 1)
            {
                impar++;
            }
        }
        return impar;
    }
    static void Main()
    {
        int n;
        Console.WriteLine("Tamanho do vetor:");
        n = int.Parse(Console.ReadLine());
        int[] vetor = new int[n];

        BibliotecaArray.geraVetor(vetor);
        Console.WriteLine("Vetor gerado:");
        BibliotecaArray.mostraVetor(vetor);
        int impar = qtdImpar(vetor);
        Console.WriteLine("\na quantidade de vetores impares é:");
        Console.WriteLine(impar);
        Console.ReadKey();
    }
}




