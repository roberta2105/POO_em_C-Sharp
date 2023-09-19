

abstract class Ingresso
{
    protected double valorReais {get; set;}

    public Ingresso(double valorReais)
    {
        this.valorReais = valorReais;
    }

    public virtual void imprimeValor()
    {
        Console.WriteLine($"O valor do ingresso é: {valorReais}");
    }
}