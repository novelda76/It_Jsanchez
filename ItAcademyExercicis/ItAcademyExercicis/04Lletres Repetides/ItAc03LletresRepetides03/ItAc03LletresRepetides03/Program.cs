using System;

using System.Collections.Generic;

namespace ItAc03LletresRepetides03
{
    class Program
    {
        static void Main(string[] args)
        {
            //FASE3
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
            List<char> Name = new List<char>();  //Definimos Lista, se llama Name
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
                    
                    default:
                        Console.WriteLine(Name[i] + " CONSONANTE");
                        break;

                }

            }
                    
            // Defino diccionario
            Dictionary<string, int> letrasDiccio = new Dictionary<string, int>();
            int contador = 1;
            for (int i = 0; i < cantidad; i++)
            {
                contador = 0;
                for (int j = 0; j < cantidad; j++)
                {
                    
                    if (Name[i] == Name[j])
                    {

                        contador++;
                    }
                    
                }
                
                 var valor = Name[i].ToString();
                 
                 letrasDiccio[valor] = contador;
                 Console.WriteLine("Entran al diccionario : ");
                 Console.WriteLine(valor + "," + contador);

             }
             foreach (KeyValuePair<string, int> contenido in letrasDiccio)
             {
                 Console.WriteLine("La letra es : " + contenido.Key + " y aparece "+ contenido.Value + " veces " );

             }   
        }
    }
}
