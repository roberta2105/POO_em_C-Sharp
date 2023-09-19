

    class AssistenteTec : Assistente
    {
        private double bonus {get; set;}

        public AssistenteTec(string Nome, double Salario, int Matricula, double Bonus): base(Nome, Salario, Matricula)
        {
            bonus = Bonus;
        }
        

        public override double GanhoAnual()
        {
            return base.GanhoAnual() + bonus;
        }

        public override void ExibeDados()
        {
            base.ExibeDados();
            Console.WriteLine($"O seu bônus é: {bonus}");
        }
    }