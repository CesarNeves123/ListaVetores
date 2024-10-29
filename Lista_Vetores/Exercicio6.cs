using System;
using Arrays;

class Exercicio6
{
    public static void Main()
    {
       Console.Write("Digite o tamanho do vetor: ");
       int n = int.Parse(Console.ReadLine());

       int[] vetor = new int[n];
       BibliotecaArray.geraVetor(vetor);

       Console.WriteLine("O vetor gerado é: ");
       for (int i = 0; i < vetor.Length; i++) { 
        
          Console.Write(vetor[i] + " ");
        }
        Console.WriteLine();

        Console.Write("Digite um número para procurar no vetor: ");
        int numero = int.Parse(Console.ReadLine());

        bool encontrado = false;
        for (int I = 0; I < n; I++)
        {
            if (vetor[I] == numero)
            {
                Console.WriteLine($"Número encontrado na posição {I}");
                encontrado = true;

            }
        }

        if (!encontrado)
        {
            Console.WriteLine("Número não encontrado no vetor.");
        }
    }
}
