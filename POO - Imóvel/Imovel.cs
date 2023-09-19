
    abstract class Imovel
    {
        private string endereco {get; set;}
        protected double valor;

    public Imovel(string endereco, double valor)
    {
        this.endereco = endereco;
        this.valor = valor;
    }
        
    }