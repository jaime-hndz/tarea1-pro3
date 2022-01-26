using System;

namespace tarea1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;
            while (!salir)
            {

                System.Console.Clear();
                System.Console.Write(@"
                Tarea 1 - Jaime Hernández, 2020-10613
                
                    Programas: 

                        1. Contador de vocales, espacios y consonantes.
                        2. Datos de contacto. 
                        3. Ver si un numero de teléfono, contiene tu matricula.
                        4. Determinador del tipo de triangulo según sus lados. 
                        5. Generador un archivo HTML.
                        6. Contador de parrafos e imagenes.
                        7. Calcule de equivalente literal de una calificacion y posible distribución.
                        9. Acerca de.

                        00. salir

                    Digite la opcion de que desea elegir =>");

                var entrada = System.Console.ReadLine();

                switch (entrada)
                {
                    case "1":
                        Ejercicios.ContadorFrase();
                        break;
                    case "2":
                        Ejercicios.DatosPersonales();
                        break;
                    case "3":
                        Ejercicios.TelefonoMatricula();
                        break;
                    case "4":
                        Ejercicios.Triangulos();
                        break;
                    case "5":
                        Ejercicios.GenerarHtml();
                        break;
                    case "00":
                        salir = true;
                        break;
/*                    default:
                        System.Console.Write(@"
                        Digite una de las opciones, nmms!");
                        System.Console.ReadLine();
                        break;*/
                }
            }

        }
    }
}
