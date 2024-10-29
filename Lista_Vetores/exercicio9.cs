using System;
using Arrays;



public class exercicio9
{
    static void Main()
    {
        Console.Write("Digite o tamanho do vetor: ");
        int n = int.Parse(Console.ReadLine());

        int[] vetor = new int[n];

        BibliotecaArray.geraVetor(vetor);

        Console.Write("Digite o valor a ser buscado no vetor: ");
        int valor = int.Parse(Console.ReadLine());

        int contador = 0;


        for (int i = 0; i < n; i++) { 
        
            if (vetor[i] == valor)
            {
                contador++;
            }
        }

        Console.WriteLine("Elementos do vetor:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(vetor[i] + " ");
        }

        Console.WriteLine();
        Console.WriteLine($"O valor {valor} aparece {contador} vezes no vetor.");
    }
}

