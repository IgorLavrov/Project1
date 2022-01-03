using System;

namespace Project1
{


    class Program
    {
        static void Main(string[] args)
        {
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

            /*
             Console.ReadLine();
             int arv1= int.Parse(Console.ReadLine());
             int arv2 = int.Parse(Console.ReadLine());
             Console.WriteLine("Arvude {1}ja {0}korrutis võrdub{2}", arv1, arv2, arv1 * arv2);
             */

        }
    }





    class lesson {


    static void Red(int arv, string tried)
    {



    }


    }



}
