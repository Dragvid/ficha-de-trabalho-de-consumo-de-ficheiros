using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4_anagrama
{
    class Program
    {
        static void Main(string[] args)
        {
            int c=0;
            string s1="vazio", s2="vazioo";
            while (s1.Length != s2.Length)
            {
                Console.WriteLine("insira string og: ");
                s1 = Console.ReadLine();
                Console.WriteLine("insira string possivel anagrama para verificaçao: ");
                s2 = Console.ReadLine();
            }
            
            Dictionary<char, int> contagems1 = new Dictionary<char, int>();
            Dictionary<char, int> contagems2 = new Dictionary<char, int>();
            for (int i = 0; i < s1.Length; i++)
            {
                if (contagems1.ContainsKey(s1[i]))
                {
                    int p = contagems1[s1[i]];
                    contagems1[s1[i]] = p + 1;
                }
                else
                {
                    contagems1.Add(s1[i], 1);
                }
                i++;
            }
            for (int i = 0; i < s2.Length; i++)
            {
                if (contagems2.ContainsKey(s2[i]))
                {
                    int p = contagems2[s2[i]];
                    contagems2[s2[i]] = p + 1;
                }
                else
                {
                    contagems2.Add(s2[i], 1);
                }
                i++;
            }
            Console.WriteLine("contagem:");
            for (int i = 0; i < contagems1.Count; i++)
            {
                if (contagems2.ContainsKey(s1[i]) && contagems1[s1[i]] == contagems1[s1[i]])
                {
                    c++;
                }
            }
            
            Console.WriteLine("c="+c);
            if (c == contagems1.Count)
            {
                Console.WriteLine("anagrama: confirmado");
            }
            else {
                Console.WriteLine("anagrama: falso");
            }
            Console.ReadLine();
        }
    }
}
