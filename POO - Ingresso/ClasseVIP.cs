
    class ClasseVIP : Ingresso
    {
        private double valorAdicional {get; set;}

        public ClasseVIP(double valorReais, double valorAdicional): base(valorReais)
        {
            this.valorAdicional = valorAdicional;
        }

        public double ValorVIP()
        {
            return valorReais += valorAdicional ;
        }
    }