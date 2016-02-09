using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandersCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Message:");
            string secretMessage = Console.ReadLine();

            secretMessage.ToLower();

            if ((secretMessage.Length % 2) == 1)
            {
                secretMessage = secretMessage + " ";
            }

            char[] unCoded = secretMessage.ToArray();
            char[] Coded = new char[unCoded.Length];

            for (int i = 0; i < Coded.Length; i=i+2)
            {
                Coded[i] = unCoded[i + 1];
                Coded[i + 1] = unCoded[i];
            }

            string rebuilt = new string(Coded);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("{0}", secretMessage);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("{0}", rebuilt);

            Console.ReadLine();
        }
    }
}
