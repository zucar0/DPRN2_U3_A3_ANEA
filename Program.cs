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


            //Este programa debe de pedir el número de filas y columnas para poder definir un arreglo bidimensional

            //Almacenar en cada posición (i,j)

            //Solicitar cual fila de la matriz se requiere revisar

            // implementar los algoritmos necesarios para  analizar que colores tienen las fotografías de esa fila, para finalmente, indicar si es a color o en b/n.
            
            //Recomendación, aunque se indica que el arreglo bidimensional o matriz  puede tener un índice entre 1 y 100, sólo es para condicionar ese tamaño, para las pruebas, con que se cree una matriz que no se mayor a 5 x 5 es suficiente.    
            var chars = "CMYWGB";
            var stringChars = new char[8];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);
            System.Console.WriteLine(finalString);
        }
    }
}
