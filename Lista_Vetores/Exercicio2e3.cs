using System;
using Arrays;

public class Exercicio_2_3
{
    static double MaiorVetor(double[] vetor)
    {
        double maior = vetor[0];
        for (int i = 1; i < vetor.Length; i++)
        {
            if (vetor[i] > maior)
            {
                maior = vetor[i];
            }
        }
        return maior;
    }
    static double menorVetor(double[] vetor)
    {
        double menor = vetor[0];
        for (int i = 1; i < vetor.Length; i++)
        {
            if (vetor[i] < menor)
            {
                menor = vetor[i];
            }
        }
        return menor;
    }
    public static void Main()
    {
        int n;
        Console.WriteLine("Tamanho do vetor:");
        n = int.Parse(Console.ReadLine());
        double[] vetor = new double[n];

        BibliotecaArray.geraVetor(vetor);
        Console.WriteLine("Vetor gerado:");
        BibliotecaArray.mostraVetor(vetor);
        double maior = MaiorVetor(vetor);
        double menor = menorVetor(vetor);
        Console.WriteLine($"\nO maior vetor é {maior:F2}:");
        Console.WriteLine($"\n O menor vetor é: {menor:F2}");
        Console.ReadKey();

    }
}
