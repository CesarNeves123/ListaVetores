using System;

    public class exercicio11
    {   public static void Main()
    {
     Console.WriteLine("Digite a mensagem codificada:");
     string mensagemCod = Console.ReadLine();

     string mensagemDecod = DecodificaMensagem(mensagemCod);

     Console.WriteLine("Mensagem decodificada:");
     Console.WriteLine(mensagemDecod);
    }

    static string DecodificaMensagem(string mensagemCod)
    {
     string mensagemDecod = "";

        for (int i = 0; i < mensagemCod.Length; i++) { 
        
            if (mensagemCod[i] != 'p') { 
            mensagemDecod += mensagemCod[i];

            }
            else if (i + 1 < mensagemCod.Length) { 
            mensagemDecod += mensagemCod[i + 1];
                i++;
            }
        }

        return mensagemDecod;
    }
}

