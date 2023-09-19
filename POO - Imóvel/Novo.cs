
    class Novo : Imovel
    {
        private double valorAdicional {get; set;}

        public Novo(string endereco, double valor, double valorAdicional): base(endereco, valor)
        {
            this.valorAdicional = valorAdicional;
        }

        public double ImprimeVLAdicional()
        {
            return valor += valorAdicional;
        }


    }