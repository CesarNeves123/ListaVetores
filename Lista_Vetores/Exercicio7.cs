using System;
using Arrays;


    public class Exercicio7
    {
        static void Main()
        {
        Console.Write("Digite o tamanho dos vetores: ");
          int n = int.Parse(Console.ReadLine());

         int[] vetor1 = new int[n];
         int[] vetor2 = new int[n];
         int[] vetorRes = new int[n];

         BibliotecaArray.geraVetor(vetor1);
         BibliotecaArray.geraVetor(vetor2);

            for (int i = 0; i < n; i++) {             
                vetorRes[i] = vetor1[i] * vetor2[i];
            }

            Console.WriteLine("O resultado da multiplicação dos vetores é :");
            for (int i = 0; i < n; i++)
            {
                Console.Write(vetorRes[i] + " ");
            }
        }
    }

