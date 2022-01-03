using System;
using System.Collections.Generic;
using System.Text;

namespace Project1
{
    class Kordused
    {
        static int Massivisuurus(int min,int max)
        {
            Random rnd = new Random();
            int A = rnd.Next(min, max);
            return A;

        }


        static void Main(string[] args)
        {



            int A = Massivisuurus(1, 20);
            int[] massiv = new int[A];
            int E;
            for (int i = 0; i < A; i++){
                E = Massivisuurus(1,10);
                massiv[i] = E;
            }

            foreach (var item in massiv)
            {
                Console.Write("{0,3}",item);
            }
            Console.WriteLine();
            string[] abc = new string[5] { "A", "B", "C", "D", "E" };

            int ind = Massivisuurus(0,4);
            Console.WriteLine("Element indeksiga {0} on {1}",ind,abc[ind]);

            int n = abc.Length;
            int j=0;

            while (n > 0)
            {
                Console.WriteLine(abc[n-1]);
                n--;
            }

            while (j > abc.Length)
            {
                Console.WriteLine(abc[j]);
                j++;
            }

            A = Massivisuurus(3, 12);
            E = Massivisuurus(3, 12);
            int [,]tabel=new int[A,E];
            //int[,] tabel2 = new int[,] { };

            for (int i = 0; i < A; i++)
            {
                for (j= 0; j < E; j++)
                {
                    tabel[i, j] = Massivisuurus(-10, 10);
                }

            }


            for (int i = 0; i < A; i++)
            {
                for (j = 0; j < E; j++)
                {
                    Console.Write("{0,4}",tabel[i, j]);
                }
                Console.WriteLine();
            }




            Console.ReadLine();
        }



    }

}
