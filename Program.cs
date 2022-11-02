using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_11_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // zad 1 napisz program ktory obliczy sume n pierwszych liczb fibonacciego (na 3)
            // 1 + 2+ 3+5+8+13+21+34...
            /*int n = int.Parse(Console.ReadLine());
            int a = 0;
            int b = 1;
            int temp;
            int suma = 0;
            for (int i = 0; i < n; i++)
            {
                temp = a;
                a = b;
                b += temp;
                suma = suma + b;
            }
            Console.WriteLine(suma);*/

            //zad2 napisz program sumujący "w" pierwszych liczb trzycyfrowych (na 2)
            /*int suma = 0;
            int w = int.Parse(Console.ReadLine());
            for (int i = 100; i < w + 100; i++)
            {
                suma += i;
            }
            Console.WriteLine(suma);
*/
            //zad3 sprawdź czy liczba wpisana przez usera jest  doskonała
            // 6 = 1 + 2 + 3
            //28 = 1+2+4+7+14
            int suma = 0;
            int a = int.Parse(Console.ReadLine());
            for (int i = 1; i < a; i++)
                if (a % i == 0)
                { 
                    suma += i; 
                }
            if (suma == a)
            {
                Console.WriteLine("TAK"); 
            }
            else
            {
                Console.WriteLine("NIE");
            }
               
            Console.ReadKey();
        }
    }
}
