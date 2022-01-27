using HtmlAgilityPack;
using ScrapySharp.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea1
{
    class Ejercicios
    {
        #region metodos

        public static void Write(string texto)
        {
            System.Console.Write(@$"
                {texto}");
        }
        public static void Writeline(string texto)
        {
            System.Console.WriteLine(@$"
                {texto}");
        }
        public static string Read(string texto)
        {
            Write(texto);
            return System.Console.ReadLine();
        }
        public static void Membrete(string titulo)
        {
            System.Console.Clear();
            Writeline(@$"
                {titulo.ToUpper()}

            ");
        }
        public static void Continuar()
        {
            Write(@"
            
             Presione cualquier letra para continuar...
            ");
            Read("");
        }

        #endregion

        #region ejercicios

        public static void ContadorFrase()
        {

            int vocales = 0;
            int consonantes = 0;
            int espacios = 0;

            Membrete(" CONTADOR DE VOCALES, CONSONANTES Y ESPACIOS ");
            string frase = Read("Digite una frase =>");

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

            Writeline(@"

            En la frase escrita...

            El numero de vocales es: "+vocales+ @"
            El numero de consonantes es: " + consonantes + @"
            El numero de espacios es: " + espacios + @"

            ");
            Continuar();
        }
        public static void DatosPersonales()
        {
            Membrete("");
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
            
            ");
            Continuar();
        }
        public static void TelefonoMatricula()
        {
            Membrete("VER SI UN NUMERO DE TELEFONO CONTIENE MI MATRICULA"); 
            
            string numero_tel = Read("Digite un numero de telefono=>");
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
                Writeline(@"
                    Contiene todas los numeros de mi matricula
                ");
            }
            else
            {
                Write(@"
                    Solo contiene: ");
                coincidencias.ForEach(Console.Write);
            }
            Continuar();
        }
        public static void Triangulos()
        {
            Membrete("DETERMINAR TIPO DE TRIANGULO POR SUS LADOS");
     
            var val1 = Read("Ingrese la medida del lado 1: ");
            var val2 = Read("Ingrese la medida del lado 2: ");
            var val3 = Read("Ingrese la medida del lado 3: ");

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

            Writeline(@"
              
            Su triangulo es: " + tipo + @"

            ");
            Continuar();
        }
        public static void GenerarHtml()
        {
            Membrete("GENERAR UN ARCHIVO HTML CON DATOS DE UNA PERSONA");

            var nombre = Read("Nombre: ");
            var apellido = Read("Apellido: ");
            var telefono = Read("Telefono: ");

            string ruta = "..\\..\\..\\html\\";

            if (!Directory.Exists(ruta))
            {
                Directory.CreateDirectory(ruta);
            }

            var random = new Random();
            var color = String.Format("#{0:X6}", random.Next(0x1000000));
            string html = "<!DOCTYPE html><html lang='en'><head> <meta charset='UTF-8'> <meta http-equiv='X-UA-Compatible' content='IE=edge'> <meta name='viewport' content='width=device-width, initial-scale=1.0'> <title>Persona</title></head><body style='background-color: "+color+"; '> <div style='justify-content: center;'> <div style='background-color: white; opacity: 0.9; font-size: 50px; width: 500px; margin-left: auto; margin-right: auto; padding: 30px;'> <center>Datos personales</center> <p>Nombre: "+nombre+" </p><p>Apellido: "+apellido+" </p><p>Telefono: "+telefono+" </p></div></div></body></html>";

            File.WriteAllText(ruta + nombre + ".html", html);

            System.Diagnostics.Process.Start(Environment.GetEnvironmentVariable("WINDIR") + @"\explorer.exe", ruta+nombre + ".html");
            Write(@"
             HTML GENERADO!
            ");
            Continuar();
        }
        public static void AnalizarURL()
        {
            Membrete("ANALIZAR UN URL");
                
            string URL = Read("Escriba la URL=>");

            HtmlWeb oWeb = new HtmlWeb();
            HtmlDocument doc = oWeb.Load(URL);
            List<string> imagenes = new List<string>();
            List<string> parrafos = new List<string>();

            foreach (var img in doc.DocumentNode.CssSelect("img"))
            {
                imagenes.Add(img.InnerHtml);
            }
            foreach (var p in doc.DocumentNode.CssSelect("p"))
            {
                parrafos.Add(p.InnerHtml);
            }

            Writeline($"La cantidad de imagenes es {imagenes.Count}");
            Writeline($"La cantidad de parrafos es {parrafos.Count}");

            Continuar();
        }
        public static void Calificacion()
        {
            Membrete("CALIFICACION");
            float calificacion = Int32.Parse(Read("Escriba la calificacion: "));
            string val_literal;

            if(calificacion >= 90)
            {
                val_literal = "A";
            }
            else if (calificacion < 90 && calificacion >= 80)
            {
                val_literal = "B";
            }
            else if (calificacion < 80 && calificacion >= 70)
            {
                val_literal = "C";
            }
            else
            {
                val_literal = "F";
            }

            float cua = (float)(calificacion * 0.4);
            float tre = (float)(calificacion * 0.3);

            Write($"El valor literal de su nota es: {val_literal}=>{cua},{tre},{tre}");
            Continuar();
        }
        public static void AcercaDe()
        {
            Membrete("ACERCA DE");

            string ruta = "..\\..\\..\\acerca\\index.html";

            System.Diagnostics.Process.Start(Environment.GetEnvironmentVariable("WINDIR") + @"\explorer.exe", ruta);


            Continuar();
        }
        
        #endregion
    }

}
