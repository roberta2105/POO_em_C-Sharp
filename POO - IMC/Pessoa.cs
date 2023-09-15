
public class Pessoa
{
    
    private double peso;
    private double altura;

    public double Peso{
        get{return peso;}
        set{peso=value;}
    }
        public double Altura{
        get{return altura;}
        set{altura=value;}
    }

    public Pessoa(string nome)
    {
        Console.WriteLine($"Olá {nome} vamos calcular o seu IMC!");
    }

    public double Calculo()
    {
        return peso / (altura * altura);
    }

    public string Situacao(double imc)
    {
        string retorno;

        if (imc < 18)
        {
            retorno = "abaixo do peso";
        }
        else if (imc < 25)
        {
            retorno = "peso ideal";
        }
        else if (imc < 30)
        {
            retorno = "acima do peso";
        }
        else if (imc < 35)
        {
            retorno = "obesidade I";
        }
        else if (imc < 40)
        {
            retorno = "obesidade II";
        }
        else
        {
            retorno = "obesidade III";
        }
        return retorno;

    }
    public void Mensagem()
    {
        double obterCalculo = Calculo();
        string obterSituacao = Situacao(obterCalculo);

        Console.WriteLine($"A situação é: {obterSituacao} com {obterCalculo}");
    }
}