using System;
public class exercicio12
{
    static void Main()
    {
        double[] notas = new double[5];
        for (int i = 0; i < 5; i++) { 
        
         Console.Write($"Digite a nota {i + 1}: ");
         notas[i] = double.Parse(Console.ReadLine());
        }
        Array.Sort(notas);
        double notaFinal = notas[1] + notas[2] + notas[3];
        Console.WriteLine("Nota final: " + notaFinal.ToString("F1"));
    }
}
