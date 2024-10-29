using System;

namespace Arrays
{
    public class BibliotecaArray
    {
        public static void leiaVetor(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"[{i}]:");
                vetor[i] = int.Parse(Console.ReadLine());

            }
        } // fim leia vetor
        public static void leiaVetor(double[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"[{i}]:");
                vetor[i] = double.Parse(Console.ReadLine());

            }
        } // fim leia vetor

        public static void geraVetor(double[] vetor)
        {
            Random random = new Random(); // gerador de aleatorios
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = random.Next(1, 100) + random.NextDouble();
            }
        } // fim gera vetor
        public static void geraVetor(int[] vetor)
        {
            Random random = new Random(); // gerador de aleatorios
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = random.Next(1, 100);
            }
        } // fim gera vetor

        public static void mostraVetor(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
                Console.Write($" | {vetor[i]}");

        }//  fim mostra vetor
        public static void mostraVetor(double[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
                Console.Write($" | {vetor[i]:F2}");

        }//  fim mostra vetor
        static int Somavetor(int[] vetor)
        {
            int soma = 0;
            for (int i = 0; i < vetor.Length; i++)
            {
                soma += vetor[i];

            }
            return soma;
        }// fim soma vetor
        static int maiorVetor(int[] vetor)
        {
            int maior = 0;
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] > maior)
                {
                    maior += vetor[i];
                }

            }
            return maior;
        }// fim maior vetor
        static int menorVetor(int[] vetor)
        {
            int menor = vetor[0];
            for (int i = 1; i < vetor.Length; i++)
            {
                if (vetor[i] < menor)
                {
                    menor = vetor[i];
                }
            }
            return menor;
        }// fim menor vetor
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
        // fim qtd de impar

    }

}


