using System;

namespace ItAc05NomsCiutats04
{
    class Program
    {
        static void Main(string[] args)
        {
            //FASE 1
            string cityOne = "";
            string cityTwoo = "";
            string cityThree = "";
            string cityFour = "";
            string cityFive = "";
            string citySix = "";
            Console.WriteLine("Benvinguts al programa de les ciutats");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"Entra el nom de la ciutat número {i}");
                var cityAux = Console.ReadLine();
                if (i == 0)
                {
                    cityOne = cityAux;
                }
                else if (i == 1)
                {
                    cityTwoo = cityAux;
                }
                else if (i == 2)
                {
                    cityThree = cityAux;
                }
                else if (i == 3)
                {
                    cityFour = cityAux;
                }
                else if (i == 4)
                {
                    cityFive = cityAux;
                }
                else if (i == 5)
                {
                    citySix = cityAux;
                }
            }
            Console.WriteLine($"Les ciutats són : {cityOne}, {cityTwoo}, {cityThree}, {cityFour}, {cityFive}, {citySix}.");
            Console.WriteLine();

            //FASE2
            string[] arrayCiutats = new string[6];

            for (int i = 0; i < 6; i++)
            {

                if (i == 0)
                {
                    arrayCiutats[i] = cityOne;
                }
                else if (i == 1)
                {
                    arrayCiutats[i] = cityTwoo;
                }
                else if (i == 2)
                {
                    arrayCiutats[i] = cityThree;
                }
                else if (i == 3)
                {
                    arrayCiutats[i] = cityFour;
                }
                else if (i == 4)
                {
                    arrayCiutats[i] = cityFive;
                }
                else if (i == 5)
                {
                    arrayCiutats[i] = citySix;
                }
            }
            Console.WriteLine("Les ciutats ordenades alfabèticament són : ");
            Array.Sort(arrayCiutats);
            for (int i = 0; i < arrayCiutats.Length; i++)
            {
                Console.WriteLine(arrayCiutats[i]);
            }
            Console.WriteLine();

            //FASE 3
            string[] arrayCiutatsModificades = new string[6];
            for (int i = 0; i < arrayCiutats.Length; i++)
            {
                arrayCiutatsModificades[i] = (arrayCiutats[i]).Replace("a", "4");
            }
            Array.Sort(arrayCiutatsModificades);
            Console.WriteLine("Les ciutats modificades i ordenades alfabèticament són : ");
            for (int i = 0; i < arrayCiutatsModificades.Length; i++)
            {
                Console.WriteLine(arrayCiutatsModificades[i]);
            }
            Console.WriteLine();

            // FASE 4

            string[] arrayCityOne = new string[cityOne.Length];
            string[] arrayCityTwoo = new string[cityTwoo.Length];
            string[] arrayCityThree = new string[cityThree.Length];
            string[] arrayCityFour = new string[cityFour.Length];
            string[] arrayCityFive = new string[cityFive.Length];
            string[] arrayCitySix = new string[citySix.Length];
            Console.WriteLine("Entrarem les ciutats als Arrays.");
            for (int i = 0; i < arrayCityOne.Length; i++)
            {
                arrayCityOne[i] = cityOne[i].ToString();
            }
            for (int i = 0; i < arrayCityTwoo.Length; i++)
            {
                arrayCityTwoo[i] = cityTwoo[i].ToString();
            }
            for (int i = 0; i < arrayCityThree.Length; i++)
            {
                arrayCityThree[i] = cityThree[i].ToString();
            }
            for (int i = 0; i < arrayCityFour.Length; i++)
            {
                arrayCityFour[i] = cityFour[i].ToString();
            }
            for (int i = 0; i < arrayCityFive.Length; i++)
            {
                arrayCityFive[i] = cityFive[i].ToString();
            }
            for (int i = 0; i < arrayCitySix.Length; i++)
            {
                arrayCitySix[i] = citySix[i].ToString();
            }
            Console.WriteLine();
            Console.WriteLine("Les ciutats desde els Arrays amb les lletres invertides són : ");
            for (int i = arrayCityOne.Length - 1; i >= 0; i--)
            {
                Console.Write(arrayCityOne[i]);
            }
            Console.WriteLine();
            for (int i = arrayCityTwoo.Length - 1; i >= 0; i--)
            {
                Console.Write(arrayCityTwoo[i]);
            }
            Console.WriteLine();
            for (int i = arrayCityThree.Length - 1; i >= 0; i--)
            {
                Console.Write(arrayCityThree[i]);
            }
            Console.WriteLine();
            for (int i = arrayCityFour.Length - 1; i >= 0; i--)
            {
                Console.Write(arrayCityFour[i]);
            }
            Console.WriteLine();
            for (int i = arrayCityFive.Length - 1; i >= 0; i--)
            {
                Console.Write(arrayCityFive[i]);
            }
            Console.WriteLine();
            for (int i = arrayCitySix.Length - 1; i >= 0; i--)
            {
                Console.Write(arrayCitySix[i]);
            }
        }
    }
}
