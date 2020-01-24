using System;

namespace ItAct03LletresRepetides01
{
    class Program
    {
        static void Main(string[] args)
        {   //FASE1


            Console.WriteLine("Bienvenido al programa Lletres Repetides");
            
            int cantidad = 0;
            var flag = false;
            while (flag == false)
            {
                Console.WriteLine("Cuantas letras tiene tu nombre?  ");
                try
                {
                    cantidad = int.Parse(Console.ReadLine());
                    flag = true;
                }
                catch (FormatException ex)
                {
                    
                    Console.WriteLine("No has introducido un numero");
                    flag = false;
                }
                
            }
                        
            char[] Array = new char[cantidad];
           
            
            Console.WriteLine("Entra las letras de tu nombre");
           
                for (int i = 0; i < Array.Length; i++)
                {
                    Console.WriteLine("Entra la letra número :  " + i);
                    
                    try
                    {
                        Array[i] = char.Parse(Console.ReadKey().Key.ToString());
                        Console.WriteLine();
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine();
                        Console.WriteLine("No has introducido una letra");
                        i--;
                    }

                }
                        
            Console.WriteLine();
            Console.WriteLine("Tu nombre es : ");

            for (int i = 0; i < Array.Length; i++)
            //foreach (int i in Array)
            {

                Console.Write(Array[i]);

            }
        }
    }
}

