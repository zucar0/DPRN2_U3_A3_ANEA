abstract class Foto{
    //Datos miembro.
    protected int fila;
    protected int columna;
    //Método Pais con parámetros
    public Foto(int filas, int columnas){
        fila=filas;
        columna=columnas;
    }
    //Método para mostrar país elegido
    public void mostrarFilasYColumnas(){
        if(fila>0 && columna >0){
            System.Console.WriteLine("Has ingresado "+ fila + " fotos.");
            System.Console.WriteLine("Has ingresado los "+ columna + " pixeles necesarios.");
        }else{
            System.Console.WriteLine("Se ingrsaron datos inválidos.");
        }
    }
    public abstract int almacenarFotos();
    public abstract int revisarFila();
    //Interfaz para el pais
    public int DatoFila{
        get{
            return fila;
        }set{
            fila = value;
        }
    }
    public int DatoColumna{
        get
        {
            return columna;
        }
        set
        {
            columna = value;
        }
    }
    //Destructor
    ~Foto() {
        fila=0; 
        columna=0;
        // Console.Write("Este es el destructor ejecutándose para destruir el objeto de la clase Factura");
    } 
}