using System;

namespace IFS
{
    class Program
    {

     
        static int sumOfPrimes(int n)
        {

            bool[] prime = new bool[n + 1];

            
            for (int i = 0; i < n + 1; i++)
                prime[i] = true;



            for (int p = 2; p * p <= n; p++)
            {

                
                if (prime[p] == true)
                {

                    
                    for (int i = p * 2; i <= n; i += p)
                        prime[i] = false;
                }
            }

            
            int sum = 0;
            for (int i = 2; i <= n; i++)
                if (prime[i])
                    sum += i;
            return sum;
        }

        // Driver code
        public static void Main()
        {
            Console.WriteLine("Enter x");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write(sumOfPrimes(n));
        }
    }

}
