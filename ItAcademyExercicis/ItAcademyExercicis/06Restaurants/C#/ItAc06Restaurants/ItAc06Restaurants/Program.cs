using System;

namespace ItAc06Restaurants
{
    class Program
    {
        static void Main(string[] args)
        {
            // FASE 1
            Console.WriteLine("Bienvenidos al Ejercicio de Restaurants");
            int billFive = 5;
            int billTen = 10;
            int billTwen = 20;
            int billFift = 50;
            int billOneH = 100;
            int billTwoH = 200;
            int billFiveH = 500;
            int totalPrice = 0;
            string[] Dishes = new string[5] {"Fideua", "Pulpo Gallego", "Risotto Ceps" , "Entrecot Brasa" , "Canelones" };
            int[] Prices = new int[5] {15, 25, 20, 25, 10 };
            
            Console.WriteLine();
            Console.WriteLine("               Nuestra carta                                ");
            int origRow = 4;
            int origCol = 3;


            for (int i=0; i<Dishes.Length; i++)
            {
                Console.SetCursorPosition(origCol, origRow+i);

                Console.Write($"Plato Nº:{i+1}     {Dishes[i]}  " );

                Console.SetCursorPosition(origCol + 30, origRow+i);

                Console.Write($"     {Prices[i]} Eur.");
            }
            Console.WriteLine();
        }
    }
}
