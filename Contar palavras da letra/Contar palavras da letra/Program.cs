using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contar_palavras_da_letra
{
    class Program
    {
        static void Main(string[] args)
        {
            string caminho, letra;
            caminho = Path.GetFullPath("lyrics.txt");
            Dictionary<string, int> contagem = new Dictionary<string, int>();
            letra = File.ReadAllText(caminho).ToUpper(); ;
            string[] palavras = letra.Split(' ',',');
            for (int i = 0; i < palavras.Length; i++) { 
                if (contagem.ContainsKey(palavras[i]))
                {
                    int p = contagem[palavras[i]];
                    contagem[palavras[i]] = p + 1;
                }
                else
                {
                    contagem.Add(palavras[i], 1); 
                }
                i++;
            }
            Console.WriteLine("contagem:");
            for (int i = 0; i < palavras.Length; i++)
            {
                if (contagem.ContainsKey(palavras[i]))
                    Console.WriteLine(palavras[i]+": "+contagem[palavras[i]]);
                
            }
            Console.ReadLine();
        }
    }
}
