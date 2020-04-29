using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ex3_linhas_invertidas
{
    class Program
    {
        static void Main(string[] args)
        {
            string caminho, linhas;
            caminho = Path.GetFullPath("lines.txt");
            linhas = File.ReadAllText(caminho); ;
            string[] linha = linhas.Split('\n');        
            for (int i = 0; i < linha.Length; i++)
            {
                
                Console.WriteLine(linha[linha.Length-1-i]);

            }
            Console.ReadLine();
        }
    }
}
