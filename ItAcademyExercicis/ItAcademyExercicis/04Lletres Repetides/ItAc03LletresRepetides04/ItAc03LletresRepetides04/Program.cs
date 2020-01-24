using System;
using System.Collections.Generic;
namespace ItAc03LletresRepetides04
{
    class Program
    {
        static void Main(string[] args)
        {
            //FASE4
            Console.WriteLine("Bienvenido al programa Lletres Repetides");

            int cantidadN = 0;
            var flagN = false;
            while (flagN == false)
            {
                Console.WriteLine("Cuantas letras tiene tu Nombre?  ");
                try
                {
                    cantidadN = int.Parse(Console.ReadLine());
                    flagN = true;
                }
                catch (FormatException ex)
                {

                    Console.WriteLine("No has introducido un numero");
                    flagN = false;
                }

            }

            char[] ArrayName = new char[cantidadN];


            Console.WriteLine("Entra las letras de tu Nombre");

            for (int i = 0; i < ArrayName.Length; i++)
            {
                Console.WriteLine("Entra la letra número :  " + i);

                try
                {
                    ArrayName[i] = char.Parse(Console.ReadKey().Key.ToString());
                    Console.WriteLine();
                }
                catch (FormatException ex)
                {
                    Console.WriteLine();
                    Console.WriteLine("Els noms de persones no contenen números!");
                    i--;
                }

            }

            //Console.WriteLine();

            /*   es bueno
            Console.WriteLine("Tu Nombre es : ");

            for (int i = 0; i < ArrayName.Length; i++)

            {

                Console.Write(ArrayName[i]);

            }

            Console.WriteLine();

            */
            List<char> Name = new List<char>();  //Definimos Lista, se llama Name
            //   ---  es bona   Console.WriteLine("Cambiamos Array a Lista");
            for (int i = 0; i < ArrayName.Length; i++)
            {
                Name.Add(ArrayName[i]);

            }

            /*   es bueno

            Console.WriteLine("Los datos de la Lista Name son");
            Console.Write("Lista Name [");
            for (int i = 0; i < cantidadN-1; i++)

            {
                Console.Write("'" + Name[i] + "'" + "," );

            }
            Console.Write("'" + Name[cantidadN-1]+ "'" + "]");

            */

           // Console.WriteLine();
            // Ahora vamos con el apellido
            int cantidadS = 0;
            var flagS = false;
            while (flagS == false)
            {
                Console.WriteLine("Cuantas letras tiene tu Apellido?  ");
                try
                {
                    cantidadS = int.Parse(Console.ReadLine());
                    flagS = true;
                }
                catch (FormatException ex)
                {

                    Console.WriteLine("No has introducido un numero");
                    flagS = false;
                }

            }

            char[] ArraySurname = new char[cantidadS];


            Console.WriteLine("Entra las letras de tu Apellido");

            for (int i = 0; i < ArraySurname.Length; i++)
            {
                Console.WriteLine("Entra la letra número :  " + i);

                try
                {
                    ArraySurname[i] = char.Parse(Console.ReadKey().Key.ToString());
                    Console.WriteLine();
                }
                catch (FormatException ex)
                {
                    Console.WriteLine();
                    Console.WriteLine("Els cognoms de persones no contenen números!");
                    i--;
                }

            }

            
            /*   Es bueno
            Console.WriteLine();
            Console.WriteLine("Tu Apellido es : ");

            for (int i = 0; i < ArraySurname.Length; i++)

            {

                Console.Write(ArraySurname[i]);

            }

            */

            Console.WriteLine();
            List<char> Surname = new List<char>();  //Definimos Lista, se llama Surname
            //-- es bueno  Console.WriteLine("Cambiamos Array a Lista");
            for (int i = 0; i < cantidadS; i++)
            {
                Surname.Add(ArraySurname[i]);
                

            }

            /*  Es bueno 
            Console.WriteLine("Los datos de la Lista Surname son");
            Console.Write("Lista Surname [");
            for (int i = 0; i < cantidadS-1; i++)

            {
                Console.Write("'" + Surname[i] + "'" + ",");

            }
            Console.Write("'" + Surname[cantidadS - 1] + "'" + "]");
            */
            // Console.WriteLine();

            //Nueva Lista FullName

            List<char> FullName = new List<char>();
            for (int i = 0; i < cantidadN; i++)
            {
                FullName.Add(Name[i]);

            }
            for (int i = 0; i < cantidadS; i++) 
            {
                FullName.Add(Surname[i]);
            }

            Console.Write("FullName [");
            for (int i = 0; i < cantidadN-1; i++)

            {
                Console.Write("'" + FullName[i] + "'" + ",");

            }
            Console.Write("'" + FullName[cantidadN-1] + "'" + "," + "' '" + ",");
            for (int i = cantidadN; i < (cantidadN+cantidadS) - 1; i++)

            {
                Console.Write("'" + FullName[i] + "'" + ",");

            }
            Console.Write("'" + FullName[(cantidadN + cantidadS) - 1] + "'" + "]");

            Console.WriteLine();

        }
    }
}
    
