using System;
namespace DPRN2_U3_A3_ANEA
{
    class Program
    {
        static void Main(string[] args)
        {
            string separacion="******************************";
            //Este programa debe de pedir el número de filas y columnas 
            System.Console.WriteLine("Ingresar el número de filas: ");  
            var numeroDeFilas = System.Console.ReadLine();
            int numFilas = int.Parse(numeroDeFilas);
            System.Console.WriteLine("Ingresar el número de columnas: ");
            var numeroDeColumnas = System.Console.ReadLine();
            int numColumnas = int.Parse(numeroDeColumnas);
            try
            {
                //Definir un arreglo bidimensional
                string[,] bidimensional;
                bidimensional=new string[numFilas,numColumnas];
                Color almacenado = new Color(numFilas, numColumnas);
                almacenado.almacenarFotos();
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
                        // System.Console.WriteLine(finalString);
                        bidimensional[filas,columnas] = finalString;
                        // System.Console.Write(finalString);
                    }
                    // System.Console.WriteLine(separacion);
                }
                //Solicitar cual fila de la matriz se requiere revisar
                System.Console.WriteLine("Indicar el número de la foto que requieres revisar: ");
                var numeroDeFoto = System.Console.ReadLine();
                int fotoARevisar = int.Parse(numeroDeFoto);
                // implementar los algoritmos necesarios para  analizar que colores tienen las fotografías de esa fila, para finalmente, indicar si es a color o en b/n.
                System.Console.WriteLine(separacion);
                var valoresDeColores = "";
                for(int col=0;col<bidimensional.GetLength(0);col++)
                {
                    System.Console.Write(bidimensional[fotoARevisar,col]);
                    valoresDeColores = valoresDeColores + bidimensional[fotoARevisar,col];
                }
                System.Console.WriteLine("Impresión de valores de la foto: " + valoresDeColores);
                //Recomendación, aunque se indica que el arreglo bidimensional o matriz  puede tener un índice entre 1 y 100, sólo es para condicionar ese tamaño, para las pruebas, con que se cree una matriz que no se mayor a 5 x 5 es suficiente.    
                System.Console.WriteLine(separacion);
                if(!valoresDeColores.Contains("C")&&!valoresDeColores.Contains("M")&&!valoresDeColores.Contains("Y"))
                {
                    System.Console.WriteLine("# Blanco y Negro");
                }else if(valoresDeColores.Contains("C") || !valoresDeColores.Contains("M") || !valoresDeColores.Contains("Y")){
                    System.Console.WriteLine("# Color");
                }
            }catch(IndexOutOfRangeException aex)
            {
                System.Console.WriteLine(aex);
            }       
        }
    }
}