   using System;

namespace ConsoleApp1
{
    class Program
    {

        static char EscapeCharacter = 'R';
        static string EscapeWord = "RUNYOUFOOLS";


        static void Main(string[] args)
        {


            Console.WriteLine("Bienvenidos al programa para gestión de alumnos");
            Console.WriteLine("Introduzca las notas de los alumnos");

            var notaDeAlumnos = new list<double>();
            var keepDoing = true;

            while (keepDoing)
            {
                Console.WriteLine($"Nota del alumnos {notasDeAlumnnos.Count + 1}:");
                var notaText = Console.ReadLine();
                if (notaText == EscapeWord)
                {
                    keepDoing = false;
                }
                else
                {
                    var nota = 0.0;
                    if (double.TryParse(notaText.Replace(".", ","), out nota))
                    {
                        notaDeAlumnos.Add(nota);
                    }
                    else
                    {
                        Console.WriteLine("La nota introducida es incorrecta melón!");
                    }
                }
            }

            var suma = 0.0;

            for (var i = 0; i < notaDeAlumnos.Count; i++)
            {
                suma += notaDeAlumnos[i];
                var average = suma / notasDeAlumnos.Count;
                Console.WriteLine("la media de los examenes es:{0}", average);
            }

        }
    }
}
 