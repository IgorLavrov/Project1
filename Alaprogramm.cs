using System;
using System.Collections.Generic;
using System.Text;

namespace Project1
{
    class Alaprogramm
    {
        public static int korruta (int a,int b)
        {
            return a * b;
        }
        public static float Keskmine(float a, float b)
        {
            float Kesk = (a + b) / 2;
            return Kesk;

        }

        public static int Nur ( int a, int b , char c)
        {
            float vastus = 0;

            if (c=='+')
            {
                vastus = a + b;
                if (vastus == 5)
                {
                    Console.WriteLine("nurr nurr nurr nurr nurr");
                }
                else
                {
                    Console.WriteLine(" Sum equals");
                }

            }
            else if (c=='/' && b != 0)
            {
                vastus = a / b;

                Console.WriteLine("Divide equals");
            }

            else if (c =='*')
            {
                vastus = a * b;

                Console.WriteLine("Multiple equals");
            }
            else if (c =='-')
            {
                vastus = a - b;

                Console.WriteLine("Minus equals");
            }
            else
            {
                Console.WriteLine(" Wrong operartions or number");
            }

            return (int)vastus;
        }

        public static int calculator(float a,float b, char operation)
        {
            float vas=0;
            int vastus=0;


            if (operation == '/' && b != 0)
            {
                vas = a / b;
            }
            else if (operation == '+')
            {
                vas = a + b;
            }
            else if (operation == '-')
            {
                vas = a - b;

            }
            else if (operation == '*')
            {
                vas = a * b;
            }
            else { Console.WriteLine("Mistake")                    }

            vastus = (int)vas;

            for (int i=0;i< vastus; i++)
            {
                Console.WriteLine("Nurr");

            }
            return vastus;


        }


    }




        public static void Main(string[] args)
        {
            int x = 5;
            Console.WriteLine("Sissesta arv y:");
            int y = int.Parse(Console.ReadLine());
            int z = korruta(x, y);
            Console.WriteLine("{0}*{1}={2}", x, y, z);
            Console.WriteLine(Korruta(4, 6));
            Console.ReadLine();
        }

    }

