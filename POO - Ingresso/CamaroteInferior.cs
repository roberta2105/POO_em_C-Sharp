
    class CamaroteInferior : ClasseVIP
    {
        private string local {get; set;}

        public CamaroteInferior(double valorReais, double valorAdicional, string local): base(valorReais, valorAdicional)
        {
            this.local = local;
        }

        public void Localizacao()
        {
            Console.WriteLine($"Localização do ingresso: {local}");
        
        }
    }