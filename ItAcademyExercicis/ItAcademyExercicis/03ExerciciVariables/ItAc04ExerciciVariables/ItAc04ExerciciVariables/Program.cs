using System;
using System.Collections.Generic;

namespace ItAc04ExerciciVariables
{
    class Program
    {   //It Academy : Exercici Variables, Constants i bucle For
        static void Main(string[] args)
        {
            //FASE 1
            var surname1 = "March ";
            var surname2 = "Vera";
            var name = "Jordi ";
            var day = 18;
            var month = 01;
            var year = 1966;
            Console.WriteLine("Salida por pantalla de las variables string concatenadas : ");
            Console.WriteLine($"{surname1 } + {surname2}, + {name}" );
            Console.WriteLine("Salida por pantalla de las variables int concatenadas : ");
            Console.WriteLine($"{day} / {month} / {year}");

            //FASE2
            const int YEARTRASPAS= 1948;
            const int CADENCIATRASPAS = 4;
            var anys = ((year - YEARTRASPAS) / CADENCIATRASPAS);
            Console.WriteLine($"Els anys de traspàs desde el {YEARTRASPAS} y el {year} són : {anys}");


            //FASE3
            var yearAux = YEARTRASPAS;  
            var contador = 0;
            bool yearTraspas;
            var traspas = "El meu any de naixement, " + year + ", és de traspàs";
            var noTraspas = "El meu any de naixement, " + year + ", no és de traspàs";
            while (yearAux <= year)
            {
                yearAux = yearAux + CADENCIATRASPAS;
                contador++;
                if (yearAux>year)
                {
                    contador--;
                }
                else 
                {
                    Console.WriteLine($"L'any {yearAux} és any de traspàs " );
                }
            }

            
            if (year%CADENCIATRASPAS==0)
            {
                yearTraspas = true;
                Console.WriteLine(traspas);
            }
            else 
            {
                yearTraspas = false;
                Console.WriteLine(noTraspas);
            }
                                    
            // FASE 4
            var fullName = name + surname1 + surname2;
            var birthYear = day.ToString() + "/" + month.ToString() + "/" + year.ToString();
            Console.WriteLine($"El meu nom és {fullName}");
            Console.WriteLine($"Vaig néixer el {birthYear}");
            Console.WriteLine(noTraspas);


        }
    }
}
