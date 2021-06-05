using System;
using System.IO; 
class Color:Foto{
    public Color(int fila, int columna):base(fila, columna){}
    public override int almacenarFotos()
    {
        try{
            mostrarFilasYColumnas();
        }catch(IOException ioe){
            throw new NotImplementedException();
            System.Console.WriteLine(ioe);
        }
        return base.columna;
    }
}