using System;

namespace Lista_Estudiantes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crea en C# un programa que capture una lista de estudiantes, cada estudiante debe poseer los siguientes atributos:

            // Nombre,  == String 
            // edad,  == Int 
            // carnet,  == String 
            // solvente,  == Bool

            // Curso(cada curso debe contener un nombre, nota parcial1, nota parcial2, nota final)

            // *Adjuntar un documento con SCREENSHOTS de la ejecución del programa, como también link de GitHub del programa Realizado

            // Fecha de entrega: miércoles 7 de abril del 2021
            // Puntos posibles: 2

            Estudent[] listadoEstudiantes = new Estudent [7];

            int contador = 0;
            while (contador <2)
            {
                // Ingreso del nombre del estudiante 
                Console.WriteLine("Ingrese su Nombre: ");
                string nombre = Console.ReadLine();
                Console.WriteLine("");

                // Ingreso de la edad del estudiante
                Console.WriteLine("Ingrese su Edad: ");
                int edad = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                // Ingreso del carnet del estudiante 
                Console.WriteLine("Ingrese su Carnet: ");
                string carnet = Console.ReadLine();
                Console.WriteLine("");

                // Ingreso si esta solvente el estudiante 
                Console.WriteLine("Indique si esta solvente: ");
                bool solvente = Boolean.Parse(Console.ReadLine());
                Console.WriteLine("");

                // Mensaje de bienvenida al curos 
                Console.WriteLine("Bienvenido al curso de Programación instruido por el dios Charli");

                // Ingreso de la nota del primer parcial 
                Console.WriteLine("Ingrese nota del primer parcial: ");
                int nota1 = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                // Ingreso de la nota del segundo parcial 
                Console.WriteLine("Ingrese nota del segundo parcial: ");
                int nota2 = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                // Ingreso de la nota del examen final 
                Console.WriteLine("Ingrese nota del parcial final : ");
                int nota3 = int.Parse(Console.ReadLine());
                Console.WriteLine("");


                Estudent estudiantes = new  Estudent(nombre, edad, carnet, solvente, nota1, nota2, nota3);
                listadoEstudiantes[contador] = estudiantes;
                contador ++;
            }


            Console.WriteLine("");
            Console.WriteLine("────── LISTADO ESTUDIANTES ─────");
            Console.WriteLine("");
            for(int est = 0; est < 5; est ++)
            {
                //resultados impresos en una lista 
                Estudent estudiantes = listadoEstudiantes[est];
                Console.WriteLine("Nombre del Estudiante: " + estudiantes.nombre);
                Console.WriteLine("Carnet del Estudiante: " + estudiantes.carnet);
                Console.WriteLine("El estudiante esta solvente: " + estudiantes.solvente);
                Console.WriteLine("su nota del primer parcial es: " + estudiantes.nota1);
                Console.WriteLine("su nota del segundo parcial es: " + estudiantes.nota2);
                Console.WriteLine("su nota del parcial final es: " + estudiantes.nota3);
                Console.WriteLine("su nota del final es de: " + (estudiantes.nota1 + estudiantes.nota2 + estudiantes.nota3));
                Console.WriteLine("");
            }
        }
    }
}