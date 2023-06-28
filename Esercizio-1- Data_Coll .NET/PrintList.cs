using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_1__Data_Coll_.NET
{
    public class PrintList
    {
       public List<string> Print(List<string>ls)
        {
            for (int i = 0; ls.Count <= 10; i++)
            {
                Console.WriteLine("Insert input");
                var inp = Console.ReadLine();
                ls.Add(inp);
                
            }

            ls.ForEach(Console.WriteLine);
            return ls;
        }

        public List<string> PrintReverse(List<string>ls)
        {
            ls.Reverse();
            string concat = string.Join(", ", ls);
            Console.WriteLine(concat);
            return ls;  
        }

       
    }
}
