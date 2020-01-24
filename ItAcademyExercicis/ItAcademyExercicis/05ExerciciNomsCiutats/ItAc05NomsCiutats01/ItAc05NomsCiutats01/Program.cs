using System;

namespace ItAc05NomsCiutats01
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
        }
    }
}
