using System;

public class Exercicio_5
{
    public static void Main()
    {
        char[] dna = new char[50], complementar = new char[50];


        Console.WriteLine("Digite a fita de DNA com até 50 bases (A, T, C, G):");
        string input = Console.ReadLine().ToUpper();

        int length = Math.Min(input.Length, 50);

        for (int i = 0; i < length; i++)
        { 
           dna[i] = input[i];

           if (dna[i] == 'A')
            {
               complementar[i] = 'T';
            }
           else if (dna[i] == 'T')
            {
              complementar[i] = 'A';
            }
            else if (dna[i] == 'C')
            {
              complementar[i] = 'G';
            }
            else if (dna[i] == 'G')
            {
             complementar[i] = 'C';
            }
            else
            {
              Console.WriteLine($"Base inválida: {dna[i]}");
            }
        }//fim for

        Console.WriteLine("Fita de DNA:");
        for (int i = 0; i < length; i++)
        {
            Console.Write(dna[i]);
        }

        Console.WriteLine("\nFita complementar:");
        for (int i = 0; i < length; i++)
        {
            Console.Write(complementar[i]);
        }

        Console.ReadKey();
    }
}
