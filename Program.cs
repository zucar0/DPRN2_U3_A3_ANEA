using System;

namespace DPRN2_U3_A3_ANEA
{
    class Program
    {
        static void Main(string[] args)
        {
            // char[,] arreglo = new char[8, 10];
            // Random r = new Random();
            // for (int i = 0; i < arreglo.GetLength(0); ++i)
            // {
            //     for (int j = 0; j < arreglo.GetLength(1); ++j)
            //     {
            //         arreglo[i, j] = (char)r.Next(32, 255);
            //     }
            // }
            // foreach (char c in arreglo)
            // {
            //     Console.Write(c+"\n");
            // }
            // private static Random random = new Random();
            // public static string RandomString(int length)
            // {
            //     const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            //     return new string(Enumerable.Repeat(chars, length)
            //     .Select(s => s[random.Next(s.Length)]).ToArray());
            // }


            //Este programa debe de pedir el número de filas y columnas 
            System.Console.WriteLine("Ingresar el número de filas: ");  
            var numeroDeFilas = System.Console.ReadLine();
            int numFilas = int.Parse(numeroDeFilas);
            System.Console.WriteLine("Ingresar el número de columnas: ");
            var numeroDeColumnas = System.Console.ReadLine();
            int numColumnas = int.Parse(numeroDeColumnas);
            //Definir un arreglo bidimensional
            string[,] bidimensional;
            bidimensional=new string[numFilas,numColumnas];
            //(Rellenar matriz) Almacenar en cada posición (i,j)
            //El primer for entra a la fila
            for(int filas=0; filas<bidimensional.GetLength(0);filas++)
            {
                //El segundo for va a leer cada una de las columnas
                for( int columnas = 0; columnas<bidimensional.GetLength(1); columnas++)
                {
                    var chars = "CMYWGB";
                    var stringChars = new char[1];
                    var random = new Random();
                    for (int i = 0; i < stringChars.Length; i++)
                    {
                        stringChars[i] = chars[random.Next(chars.Length)];
                    }
                    var finalString = new String(stringChars);
                    System.Console.WriteLine(finalString);
                    bidimensional[filas,columnas] = finalString;
                }
            }
            //Solicitar cual fila de la matriz se requiere revisar
            System.Console.WriteLine("Indicar el número de la foto que requieres revisar: ");
            var numeroDeFoto = System.Console.ReadLine();

            // implementar los algoritmos necesarios para  analizar que colores tienen las fotografías de esa fila, para finalmente, indicar si es a color o en b/n.
            
            //Recomendación, aunque se indica que el arreglo bidimensional o matriz  puede tener un índice entre 1 y 100, sólo es para condicionar ese tamaño, para las pruebas, con que se cree una matriz que no se mayor a 5 x 5 es suficiente.    
            
        }
    }
}
