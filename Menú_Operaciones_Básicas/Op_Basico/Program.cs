using System;

namespace Op_Basico
{
    class Program
    {
        static void Main(string[] args)
        {
            String NombreUsuario; 
            byte Operacion; 
            double Numero1; 
            double Numero2; 

            


            // Solicitud a la peticion de nombre del Usuario
            Console.WriteLine("Favor escribe tu nombre completo: ");
            NombreUsuario = Console.ReadLine();

            // Solicitud de ingreso de los datos por el usuario
            Console.WriteLine("Escriba la primera cantidad: ");
            Numero1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Escriba la segunda cantidad: ");
            Numero2 = double.Parse(Console.ReadLine());

            // Operaciones 
            var Suma = Numero1 + Numero2;
            var Resta = Numero1 - Numero2; 
            var Multiplicacion = Numero1 * Numero2; 
            var Division = Numero1 / Numero2;


            // Listado de operaciones para el usuario
            Console.WriteLine("\n 1.- Suma \n 2.- Resta \n 3.- Multiplicación \n 4. División \n 5.- Todas las operaciones \n 6.- Salir");

            // Numero de la operacion que desea realizar el usuario 
            Console.WriteLine("\nDigita un número de la operación que deseas realizar: "); 

            // Conversion de Byte para que funcione en el Switch 
            Operacion = Convert.ToByte(Console.ReadLine());
            
            // Inicio de la Operación Switch
            switch(Operacion)
            {
                // Primer caso para validad la SUMA
                case 1: 
                    Console.WriteLine("\n ----- SUMA -----");

                    // Variable para aguardar la suma de las dos cantidades
                    Console.WriteLine("   Perfecto " + NombreUsuario + "\n La suma de las dos cantidades digitadas es: " + Suma);
                    break;


                // Segundo Caso para validar la RESTA
                case 2: 
                    Console.WriteLine("\n ----- RESTA -----"); 

                    // Variable para aguardar la resta de las dos cantidades
                    Console.WriteLine("   Perfecto " + NombreUsuario + "\n La resta de las dos cantidades digitadas es: " + Resta);
                    


                    break;


                // Tercer caso para validar la MULTIPLICACION 
                case 3: 
                    Console.WriteLine("\n ----- MULTIPLICACIÓN -----"); 

                    // Variable para aguardar la multiplicacion de las dos cantidades
                    Console.WriteLine("   Perfecto " + NombreUsuario + "\n La multiplicación de las dos cantidades digitadas es: " + Multiplicacion);
                    break;


                // Cuarto caso para validar la DIVISION     
                case 4: 
                    Console.WriteLine("\n ----- DIVISIÓN -----"); 
                    Console.WriteLine("   Perfecto " + NombreUsuario + "\n La división de las dos cantidades digitadas es: " + Division);

                    break;
                // Sexta opcion, la cual despliega todas las opciones
                case 5: 
                    Console.WriteLine("\n ----- TODAS LAS OPCIONES -----");
                    Console.WriteLine("   Perfecto " + NombreUsuario + "\n \n ----- SUSMA -----" + "\n La suma de las dos cantidades digitadas es: " + Suma);

                    Console.WriteLine("\n ----- RESTA ----- " + "\n La resta de las dos cantidades digitadas es: " + Resta);

                    Console.WriteLine("\n ----- MULTIPLICACIÓN -----  " + "\n La multiplicación de las dos cantidades digitadas es: " + Multiplicacion);

                    Console.WriteLine("\n ----- DIVISIÓN ----- " + "\n La División de las dos cantidades digitadas es: " + Division);
                    break;


                // Septima Opcion, la cual sale del programa
                case 6: 
                    Console.WriteLine("\n ----- SALIR -----");

                    Console.Write("\n Hasta luego " + NombreUsuario + " ");
                    break;


                // Error al ingresar un valor no existente dentro de nuestro programa
                default: 
                    Console.WriteLine("\n ----- ERROR DE OPERACIÓN -----"); 
                    // Mensaje de error personalisado con la variable de NombreUsuario, la cual fue solicitada al inicio de la ejecucion del programa
                    Console.WriteLine("     Estimado usiario: " + NombreUsuario + "\n La peticion solicitada no se encuentra dentro de nuestras operaciones. \n \n Le solicitamos volver a correr el software.");
                    break;
            }
        }
    }
}
