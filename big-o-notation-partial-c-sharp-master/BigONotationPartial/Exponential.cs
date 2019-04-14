using System;
using System.Diagnostics;

namespace BigONotationPartial
{
    class Exponential
    {
        //tarea
        static void Main(string[] args)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            Exponential exponential = new Exponential();
            ExponentialExampleType exponentialExampleType = ExponentialExampleType.Fibonacci;

            //Declaramos las variables
            int ant = 1, aux = 1;
            int fibonacci = 1;
    



            switch (exponentialExampleType)
            {
                case ExponentialExampleType.Fibonacci:
                    int n = 44; //8 40 80
                    for (int i = 1; i <= n; i++)
                    {
                        //imprime el primer valor
                        if (i == 1)
                        { Console.WriteLine("fibonacci {0} = {1}", i, fibonacci); }
                        else{ 
                        //Modificamos la logica en vez e llevar al exponencial
                        
                        fibonacci = ant + aux;
                        ant = aux;
                        aux = fibonacci;

                        Console.WriteLine("fibonacci {0} = {1}", i, fibonacci);
                        }
                    }
                    break;
            }
            Console.WriteLine("Time elapsed: {0:0.00} seconds", Math.Round(stopWatch.ElapsedMilliseconds / 1000.0, 2));
            Console.ReadLine();
        }

        /// Complexity: O(2^N)
        //internal int Fibonacci(long n)
        //{
        //    if (n < 0)
        //    {
        //        throw new Exception("n can not be less than zero");
        //    }
        //    if (n <= 2)
        //    {
        //        return 1;
        //    }
        //    return Fibonacci(n - 1) + Fibonacci(n - 2);
        //}
    }
}
