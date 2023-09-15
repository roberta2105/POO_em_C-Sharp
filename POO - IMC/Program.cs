internal class Program
{
    static void Main(string[] args)
    {
        Pessoa p = new Pessoa("Roberta");
        p.Peso = 50;
        p.Altura = 1.60;
        p.Mensagem();
    }
}