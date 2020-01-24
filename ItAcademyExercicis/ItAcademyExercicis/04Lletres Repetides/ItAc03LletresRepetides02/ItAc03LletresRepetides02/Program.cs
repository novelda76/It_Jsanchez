using System;
using System.Collections.Generic;

namespace ItAc03LletresRepetides02
{
    class Program
    {
        static void Main(string[] args)
        {
            //FASE2
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
                    Console.WriteLine("Els noms de persones no contenen números!");
                    i--;
                } 

            }

            Console.WriteLine();
            Console.WriteLine("Tu nombre es : ");

            for (int i = 0; i < Array.Length; i++)
            
            {

                Console.Write(Array[i]);
                
            }

            Console.WriteLine();

            
            List<char> Name = new List<char>();   //Definimos la lista
            Console.WriteLine("Cambiamos Array a Lista");
            for (int i = 0; i < Array.Length; i++)
            {
                Name.Add(Array[i]);

            }
            Console.WriteLine("Los datos de la Lista Name son");
            for (int i = 0; i < cantidad; i++)
            
            {
                
                switch (Name[i])
                {
                    case 'A':
                        Console.WriteLine(Name[i] + " VOCAL");
                        break;
                    case 'E':
                        Console.WriteLine(Name[i] + " VOCAL");
                        break;
                    case 'I':
                        Console.WriteLine(Name[i] + " VOCAL");
                        break;
                    case 'O':
                        Console.WriteLine(Name[i] + " VOCAL");
                        break;

                    case 'U':
                        Console.WriteLine(Name[i] + " VOCAL");
                        break;
                    /*
                    case '1':
                        Console.WriteLine(Name[i] + " Els noms de persones no contenen números!");
                        break;
                    case '2':
                        Console.WriteLine(Name[i] + " Els noms de persones no contenen números!");
                        break;
                    case '3':
                        Console.WriteLine(Name[i] + " Els noms de persones no contenen números!");
                        break;
                    case '4':
                        Console.WriteLine(Name[i] + " Els noms de persones no contenen números!");
                        break;
                    case '5':
                        Console.WriteLine(Name[i] + " Els noms de persones no contenen números!");
                        break;
                    case '6':
                        Console.WriteLine(Name[i] + " Els noms de persones no contenen números!");
                        break;
                    case '7':
                        Console.WriteLine(Name[i] + " Els noms de persones no contenen números!");
                        break;
                    case '8':
                        Console.WriteLine(Name[i] + " Els noms de persones no contenen números!");
                        break;
                    case '9':
                        Console.WriteLine(Name[i] + " Els noms de persones no contenen números!");
                        break;
                    case '0':
                        Console.WriteLine(Name[i] + " Els noms de persones no contenen números!"");
                        break;
                        */
                    default:
                        Console.WriteLine(Name[i] + " CONSONANTE");
                        break;
                        
                }

            }

        }

    }
}

