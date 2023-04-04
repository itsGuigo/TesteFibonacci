using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Testando
{
    public class fibonacci
    {
        static void Main()
        {
            int[] fibo = { 0, 1 };
            Console.WriteLine("Digite um número para saber se pertence a sequencia fibonacci: ");
            int numExists = int.Parse(Console.ReadLine());

            while (fibo[fibo.Length - 1] < numExists)
            {
                int proximoNum = fibo[fibo.Length - 1] + fibo[fibo.Length - 2];
                Array.Resize(ref fibo, fibo.Length + 1);
                fibo[fibo.Length - 1] = proximoNum;
            }

            var existe = false;
            foreach (int num in fibo)
            {
                if (num == numExists)
                {
                    existe = true;
                    break;
                }
            }

            if (existe)
            {
                Console.WriteLine($"O número {numExists} pertence a sequencia de fibonacci");
            }
            else
            {
                Console.WriteLine($"O número {numExists} não pertence a sequencia de fibonacci");
            }
        }
    }
}
