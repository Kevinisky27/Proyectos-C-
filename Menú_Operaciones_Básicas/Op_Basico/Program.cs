using System;

namespace Op_Basico
{
    class Program
    {
        static void Main(string[] args)
        {
            String NombreUsuario; 
            byte Operacion; 
            float Numero1; 
            float Numero2; 

            // Solicitud a la peticion de nombre del Usuario
            Console.WriteLine("Favor escribe tu nombre completo: ");
            NombreUsuario = Console.ReadLine();

            // Listado de operaciones para el usuario
            Console.WriteLine("\n 1.- Suma \n 2.- Resta \n 3.- Multiplicación \n 4. División \n 5.- Potenciación \n 6.- Salir");

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
                    break;


                // Segundo Caso para validar la RESTA
                case 2: 
                    Console.WriteLine("\n ----- RESTA -----"); 
                    break;


                // Tercer caso para validar la MULTIPLICACION 
                case 3: 
                    Console.WriteLine("\n ----- MULTIPLICACIÓN -----"); 
                    break;


                // Cuarto caso para validar la DIVISION     
                case 4: 
                    Console.WriteLine("\n ----- DIVISIÓN -----"); 
                    break;


                // Quinto caso para validar la POTENCIACION 
                case 5: 
                    Console.WriteLine("\n ----- POTENCIACIÓN -----"); 
                    break;


                // Sexta opcion, la cual despliega todas las opciones
                case 6: 
                    Console.WriteLine("\n ----- TODAS LAS OPCIONES -----");
                    break;


                // Septima Opcion, la cual sale del programa
                case 7: 
                    Console.WriteLine("\n ----- SALIR -----");
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
