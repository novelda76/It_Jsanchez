using System;
using System.Collections.Generic;

namespace ItAc06Restaurants03
{
    class Program
    {
        static void Main(string[] args)
        {
            // FASE 3
            Console.WriteLine("Bienvenidos al Ejercicio de Restaurants");
            int billFive = 5;
            int billTen = 10;
            int billTwen = 20;
            int billFift = 50;
            int billOneH = 100;
            int billTwoH = 200;
            int billFiveH = 500;
            double totalPrice = 0.00;

            string[] Dishes = new string[5];
            double[] Prices = new double[5];
            Console.WriteLine("Confección de la carta");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Entra el nombre plato");
                Dishes[i] = Console.ReadLine().ToUpper();
                Console.WriteLine("Entra el precio del plato");
                try
                {
                    var preuplat = Console.ReadLine();
                    double preu = 0;
                    

                    if (double.TryParse(preuplat.Replace(".", ","), out preu))

                    {
                        Prices[i] = preu;
                    }
                    else
                    {
                        Console.WriteLine("El precio no tiene formato correcto");
                        i--;
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(" El precio no es correcto.");
                    i--;
                }
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
            var dishSelected = "";
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
                Console.WriteLine(ele);
            }
            Console.WriteLine();

            List<string> OutOfmenu = new List<string>();
            foreach (string ele in Orders)
            {
                int index = Array.IndexOf(Dishes, ele);   
                
                if (index == -1)
                {
                    OutOfmenu.Add(ele);
                }
                else
                {
                    Console.WriteLine($"El plato   {ele}   tiene un precio de {Prices[index]} Eur.");
                    totalPrice = totalPrice + Prices[index];
                }
            }

            totalPrice = Math.Truncate(totalPrice * 100) / 100;
            Console.WriteLine();
            Console.WriteLine($"El total de su pedido asciende a :  {totalPrice}  Eur.");

            Console.WriteLine();
            Console.WriteLine("Han pedido los siguientes productos que no existen en la Carta ");
            foreach (string ele in OutOfmenu)
            {
                Console.Write($"   {ele}    ");
            }
            Console.WriteLine();

            int [] Bills = new int[7] { billFive, billTen, billTwen, billFift, billOneH, billTwoH, billFiveH };
            List<int> BillsToPay = new List<int>();
            var auxPrice = 0;
            var bills =0;
            var dif = 0.0;
            
            var redondeo = (int) Math.Ceiling(totalPrice);
            dif = redondeo - totalPrice;
            dif = Math.Truncate(dif * 100) / 100;

            var cambio = 0.0;
            for (int i = 1; i<=5; i ++)
            {
                var resto = redondeo % 5;
                if (resto==0)
                {
                    cambio = i-1;
                    break;
                }

                else
                {
                   redondeo++;
                }
            }

            cambio = cambio + dif;
            auxPrice = redondeo;

            for (int i = 6; i>=0; i--)
            {
                bills = auxPrice / Bills[i];
                var rest = auxPrice % Bills[i]; 
                if (bills == 1 && rest == 0)
                {
                    BillsToPay.Add(Bills[i]);
                    auxPrice = rest;
                }

                else if (bills == 2)
                {
                    BillsToPay.Add(Bills[i]);
                    BillsToPay.Add(Bills[i]);
                    auxPrice = rest;
                }

                else if (bills == 1)
                {
                    BillsToPay.Add(Bills[i]);
                    auxPrice = rest;
                }
            }

            Console.WriteLine("Pueden pagar con los siguientes billetes : ");
            foreach (int ele in BillsToPay)
            {
                Console.WriteLine( ele + "  Euros");
            }
            Console.WriteLine($"El cambio será de {cambio} Euros");
        }
    }
}
    

