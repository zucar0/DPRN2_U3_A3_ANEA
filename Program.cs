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
