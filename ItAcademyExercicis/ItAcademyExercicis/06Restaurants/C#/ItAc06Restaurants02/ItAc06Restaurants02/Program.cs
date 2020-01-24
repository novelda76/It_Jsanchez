using System;
using System.Collections.Generic;


namespace ItAc06Restaurants02
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

            string[] Dishes = new string[5];
            int[] Prices = new int[5];
            Console.WriteLine("Confección de la carta");
            for (int i=0; i<5;i++)
            {
                Console.WriteLine("Entra el nombre plato");
                Dishes[i] = Console.ReadLine().ToUpper();
                Console.WriteLine("Entra el precio del plato");
                Prices[i] = int.Parse(Console.ReadLine());
            }

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("            Nuestra carta          ");
            int origRow = 3;
            int origCol = 3;
            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition(origCol, origRow + i);

                Console.Write($"Plato Nº:{i + 1}     {Dishes[i]}  ");

                Console.SetCursorPosition(origCol + 30, origRow + i);

                Console.Write($"     {Prices[i]} Eur.");
            }
            Console.WriteLine();
            
            List<string> Orders = new List<string>();
            int more = 1;
            var dishSelected="";
            while (more == 1)
            {
                Console.WriteLine("Qué desearán tomar ? ");
                if (more == 0)
                {
                    break;
                }
                else
                {
                    dishSelected = Console.ReadLine().ToUpper();

                    Orders.Add(dishSelected);
                }


                Console.WriteLine("Desean seguir pidiendo ? 1= Si, 0=No");
                try
                {
                    more = int.Parse(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("No has elegido correctamente.");
                    Console.WriteLine("Pulsa Intro para confirmar salida");
                }
            }


            Console.WriteLine("Han pedido lo siguiente : ");

            foreach (string ele in Orders)
            {
                Console.WriteLine( ele);
            }
        }    
    }
}


