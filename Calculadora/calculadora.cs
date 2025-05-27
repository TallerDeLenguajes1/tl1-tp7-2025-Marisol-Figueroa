namespace EspacioCalculadora;

public class Calculadora
{
    double resultado;

    public double Resultado { get => resultado ; }
    public void Sumar(double termino)
    {
        resultado += termino;
    }
    public void Restar(double termino)
    {
        resultado -= termino;
    }
    public void Multiplicar(double termino)
    {
        resultado = resultado * termino;
    }
    public void Dividir(double termino)
    {
        if(termino != 0)
        resultado = resultado / termino;
    }
}