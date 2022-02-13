using System;

namespace impares
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, intervalo;

            X = int.Parse(Console.ReadLine());

           for(int i = 1; i <= X; i = i + 2)
            {

                if(X % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    
                    Console.WriteLine(i);
                }  
            }
            
        }
    }
}
