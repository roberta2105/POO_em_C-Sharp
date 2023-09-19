
    class Velho : Imovel 
    {
        private double desconto {get; set;}

        public Velho(string endereco, double valor, double desconto): base(endereco, valor)
        {
            this.desconto = desconto;
        }

        public double ImprimeVLDesconto()
        {
            return valor -= desconto;
        }
    }