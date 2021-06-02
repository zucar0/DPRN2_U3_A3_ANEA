
using System;
using System.IO; 
class Color:Foto{

    public Color(int fila, int columna):base(fila, columna){}

    public override int almacenarFotos()
    {
        try{

        }catch(IOException ioe){
            throw new NotImplementedException();
            System.Console.WriteLine(ioe);
        }
        return base.columna;
        
    }
    public override int revisarFila()
    {
        try
        {

        }
        catch(IOException ioe){
            throw new NotImplementedException();
            System.Console.WriteLine(ioe);
        }
        return base.fila;
    }

}