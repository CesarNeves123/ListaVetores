using System;

    public class exercicio10
    {
    public static void Main()
    {
        Console.Write("Digite o número de lançamentos: ");
        int n = int.Parse(Console.ReadLine());

        int[] resultados = new int[n];


        for (int i = 0; i < n; i++) { 
        
            Console.Write($"Resultado do lançamento {i + 1}: ");
            resultados[i] = int.Parse(Console.ReadLine());
        }

        int[] ocorrencias = new int[6];

        for (int i = 0; i < n; i++)
        {
          if (resultados[i] >= 1 && resultados[i] <= 6)
          {
                ocorrencias[resultados[i] - 1]++;
         }
          else
            
           Console.WriteLine("Resultado inválido, deve ser entre 1 e 6.");
            
            }
        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine($"Face {i + 1}: {ocorrencias[i]} ocorrência(s)");
        }
    }
}

