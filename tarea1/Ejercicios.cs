using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea1
{
    class Ejercicios
    {
        public static void ContadorFrase()
        {

            int vocales = 0;
            int consonantes = 0;
            int espacios = 0;

            System.Console.Clear();
            System.Console.Write(@"
                CONTADOR DE VOCALES, CONSONANTES Y ESPACIOS
                
                Digite una frase =>");
            string frase = System.Console.ReadLine();

            foreach (var item in frase)
            {
                int letra = char.ToLower(item);
                if (letra == 'a' | letra == 'e' | letra == 'i' | letra == 'o' | letra == 'u')
                {
                    vocales++;
                }
                else if (letra == ' ')
                {
                    espacios++;
                }
                else
                {
                    consonantes++;
                }
            }

            System.Console.WriteLine(@"

            En la frase escrita...

            El numero de vocales es: "+vocales+ @"
            El numero de consonantes es: " + consonantes + @"
            El numero de espacios es: " + espacios + @"
        
            Presiona enter para continuar...
            ");
            System.Console.Read();
        }
        public static void DatosPersonales()
        {
            System.Console.Clear();
            System.Console.Write(@"              
                              __.....__
                          .-' 202010613 '-.
                        .' +1 829-284-7781 '.
                       /jaime251102@gmail.com\
                      /        |\      _-_,,  \
                     ;        |V \_   (  //    ;
                     | Jaime  |  ' \    _||    ;
                     ; Hndz.  )   ,_\   _||    |
                     ;       /     |     ||    ;
                      \     /       \  -__-,  /
                       \    |        \       /
                        '.   \        \    .'
                          '-._|        \.-'
                              | |\       |
                    __________/ |_'.    /_________
            
             Presione cualquier letra para continuar...
            ");
            System.Console.Read();
        }
        public static void TelefonoMatricula()
        {
            System.Console.Clear();
            System.Console.Write(@"
                VER SI UN NUMERO DE TELEFONO CONTIENE MI MATRICULA
                
            Digite un numero de telefono=>");
            
            string numero_tel = System.Console.ReadLine();
            string matricula = "202010613";
            List<char> coincidencias = new List<char>();

            foreach (var letra in numero_tel)
            {

                if (matricula.Contains(letra))
                {
                    matricula = matricula.Replace(letra.ToString(), string.Empty);
                    coincidencias.Add(letra);
                }
            }

            if (matricula == "")
            {
                System.Console.WriteLine(@"
                    Contiene todas los numeros de mi matricula
                ");
            }
            else
            {
                System.Console.Write(@"
                    Solo contiene: ");
                coincidencias.ForEach(Console.Write);
            }
            System.Console.Write(@"
            
             Presione cualquier letra para continuar...
            ");
            System.Console.Read();
        }
        public static void Triangulos()
        {
            System.Console.Clear();
            System.Console.WriteLine(@"
                DETERMINAR TIPO DE TRIANGULO POR SUS LADOS
                
            ");
            System.Console.Write("Ingrese la medida del lado 1: ");
            var val1 = System.Console.ReadLine();

            System.Console.Write("Ingrese la medida del lado 2: ");
            var val2 = System.Console.ReadLine();

            System.Console.Write("Ingrese la medida del lado 3: ");
            var val3 = System.Console.ReadLine();

            string tipo;
            if (val1 == val2 && val2 == val3)
            {
                tipo = "Equilatero";
            }
            else if ((val1 == val2 && val2 != val3) || (val1 == val3 && val1 != val2) || (val2 == val3 && val2 != val1))
            {
                tipo = "Isosceles";
            }
            else
            {
                tipo = "Escaleno";
            }

            System.Console.Write(@"
              
             Su triangulo es: "+tipo+@"
            
             Presione cualquier letra para continuar...
            ");
            System.Console.Read();
        }
        public static void GenerarHtml()
        {
            System.Console.Clear();
            System.Console.Write(@"
                VER SI UN NUMERO DE TELEFONO CONTIENE MI MATRICULA
                
            Digite un numero de telefono=>");

            System.Console.Write(@"
            
             Presione cualquier letra para continuar...
            ");
            System.Console.Read();
        }
    }

}
