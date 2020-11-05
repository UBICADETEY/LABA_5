using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Dynamic;

namespace Laba_5
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter(@"output.txt");
            var new_in = new StreamReader(@"input1.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in);

            int N = Convert.ToInt32(Console.ReadLine());
            int M = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("*** Input matrix ***");

            int[,] mas = new int[N, M];
            for (int i=0;i<N;i++)
            {
                String str_all = Console.ReadLine();
                string[] str_elem = str_all.Split(' ');
                for (int j = 0; j < M; j++)
                {
                    mas[i, j] = Convert.ToInt32(str_elem[j]);
                    Console.Write(mas[i, j] + " ");
                }
                Console.WriteLine();
            }
            int sa = 0;
            double[] samas  = new double[N];
            for(int i=0 ; i < N; i++)
            {
                sa = 0;
                for(int j=0; j< M; j++)
                {
                    sa += mas[i, j];
                }
                samas[i] = sa / M;
                
                Console.WriteLine(samas[i]);

            }
            for( int i=0; i < N; i++)
            {
                for( int j=0; j<M; j++)
                {
                    if (mas[i, j] < samas[i])
                        Console.Write("q ");
                    else
                        Console.Write("z ");

                }
                Console.WriteLine();

            }

        }
    }
}
