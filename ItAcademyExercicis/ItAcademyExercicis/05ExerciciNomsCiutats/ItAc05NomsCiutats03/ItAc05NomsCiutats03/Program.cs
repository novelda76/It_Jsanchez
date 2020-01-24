using System;

namespace ItAc05NomsCiutats03
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
        }
    }
}
