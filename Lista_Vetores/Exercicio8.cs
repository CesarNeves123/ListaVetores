using System;
using Arrays;


    public class Exercicio8
    {
        static void Main()
        {
            Console.Write("Digite uma sequência de caracteres: ");
            string input = Console.ReadLine();

            char[] vetor = input.ToCharArray();

            int length = vetor.Length;

            Console.WriteLine("Vetor em ordem inversa: ");
            for (int i = length - 1; i >= 0; i--) { 
            
                Console.Write(vetor[i]);
            }
            Console.WriteLine(); 
        }
    }

