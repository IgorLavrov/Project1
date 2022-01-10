using System;

namespace Project1
{


    class Program
    {
        static int[] arv = new int[5];
        static int summa;
        static int mutp;
        static int[] Arv()
        {
            for (int i = 0; i < arv.Length; i++)
            {
                Console.WriteLine(" Enter  your number for massive", i);
                arv[i] = int.Parse(Console.ReadLine());
            }
            return arv;
        }

        static int Keskimine(int keskimine, int[] arv)
        {

            for (int i = 0; i < arv.Length; i++)
            {
                keskimine = keskimine + arv[i];
            }

            keskimine = keskimine / arv.Length;


            return keskimine;
        }

        static int multiple(int multiple, int[] arv)
        {
            foreach (var item in arv)
            {
                multiple *= item;

            }

            return multiple;

        }

        static int Summa(int summa, int[] arv) {

            foreach (var item in arv)
            {
                summa += item;
                mutp *= item;
            }
            return summa;
        }
         static void Word()
        {
            string Name1;
            do
            {
                Console.WriteLine(" Buy an elephant");
                Name1= Console.ReadLine();


            } while (Name1!= "elephant");

            Console.WriteLine("won!");

        }

        static int generatenumber(int min, int max)
        {
            Random rnd = new Random();
            int A = rnd.Next(min, max);
            return A;

        }

        static void Numbergame(int gamenumber)
        { int attempt = 0;  int number;

            do {
                if (attempt < 5)

                {
                    Console.WriteLine(" Try you number");
                    number = int.Parse(Console.ReadLine());
                    attempt++;
                   
                }
                else
                {
                    Console.WriteLine("Lost");
                    break;
                }

                } while (gamenumber != number);
                
                

        }
        static int[,] korr = new int[10, 10];

        static  void  Korrutustabel()
        { 
            for (int i = 0; i < 10; i++)
            {
                for (int j=0; j < 10; j++)
                { 
                    // Console.Write("{0,4}", i * j);
                    korr[i, j] = (i+1) * (j+1);
                    Console.Write("{0,4}",korr[i, j]);       
                }

              
               Console.WriteLine();
            }
        }



        static char[] tehed = new char[4] { '+', '-', '/', '*' };

        public static void Main(string[] args)
        {/*
            Console.WriteLine(" Enter first number");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(" Enter second number");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine(" Enter symbol");
            char a = char.Parse(Console.ReadLine());

           Alaprogramm.Nur(number, number2, a);*/


            Random rnd = new Random();
            float x = 10;
            float y = 3;
            char tehe = tehed[rnd.Next(0, 3)];
            int otvet = Alaprogramm.calculator(x, y, tehe);
            Console.WriteLine(otvet);


            /*
             int[] array = Arv();
             int keskimine = Keskimine(0, array);
             int multipls = multiple(1, array);
             summa = Summa(0, array);

             Console.WriteLine("keskimine "+keskimine);

             Console.WriteLine("Multiple "+multipls);

             Console.WriteLine("Summa "+summa);
             Word();
            
             Numbergame(generatenumber(0, 20));
            */

            // Korrutustabel();

            /*
            Console.WriteLine(Alaprogramm.Korruta(1, 3));
             double a=Alaprogramm.Keskmine(1 ,2);
            Console.WriteLine(a);
            */

            //     foreach (var item in array)
            //     {
            //        summa += item;
            //  }
            //  Console.WriteLine("Summa ",summa);



        }
        /*  {
              Console.WriteLine("Hello World!");
              string eesnimi = Console.ReadLine();
              Console.WriteLine("Tere," + eesnimi.ToUpper());
              if (eesnimi.ToLower() == "juku") {
                  Console.WriteLine("LAHME KINNO {0}", eesnimi, "Kui vana sa oled?");
                  int vanus = int.Parse(Console.ReadLine());
                  double hind = 6.50;
                  string pilet;
                  if (vanus < 0 || vanus > 120)
                  {
                      Console.WriteLine("Viga!");
                  }
                  else
                  {
                      if (vanus < 6)
                      {
                          pilet = "Suur soodustus!";
                          hind *= 0.5;
                      }
                      else
                      {
                          pilet = "Taispilet!";
                      }

                      Console.WriteLine("Sul in {0} pileti hind on {1}", pilet, hind);
                  }
              }
              else
              {
                  Console.WriteLine("Mina olen hõivatud");
              }


               Console.ReadLine();
               int arv1= int.Parse(Console.ReadLine());
               int arv2 = int.Parse(Console.ReadLine());
               Console.WriteLine("Arvude {1}ja {0}korrutis võrdub{2}", arv1, arv2, arv1 * arv2);
               */




    }
    }
     
     


    




