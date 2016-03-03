    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            int K;
            K = Convert.ToInt32(Console.ReadLine());
            string str = Console.ReadLine();
            var results = str.Split(' ').Select(item => Convert.ToInt32(item)).ToArray();
            int half = K / 2 + 1;
            int[] halfres = new int[half];
            for (int i = 0; i < half; i++)
            {
                halfres[i] = 10000;
            }
            for (int i = 0; i < K; i++)
            {
                for (int j = 0; j < half; j++)
                {
                    if (results[i]<halfres[j])
                    {
                        halfres[j] = results[i];
                        break;
                    }
                }
            }
            int count = 0;
            for (int i = 0; i < half; i++)
            {
                count += (halfres[i] / 2 + 1);
            }
            Console.WriteLine(count);
        }
    }
}
