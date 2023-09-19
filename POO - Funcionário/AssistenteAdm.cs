
    class AssistenteAdm : Assistente
    {
        private string turno {get; set;}
        private double adicionalNoturno {get; set;}

        public AssistenteAdm(string Nome, double Salario, int Matricula, string Turno, double AdicionalNoturno): base(Nome, Salario, Matricula)
        {
            turno = Turno;
            adicionalNoturno = AdicionalNoturno;
        }
        public AssistenteAdm(string Nome, double Salario, int Matricula, string Turno): base(Nome, Salario, Matricula)
        {
            turno = Turno;
        }

        public override double GanhoAnual()
        {
            double salarioAnual = base.GanhoAnual();

                if(turno == "noite")
                {
                    salarioAnual += adicionalNoturno * 12;
                }
                    return salarioAnual;
                
        }
        public override void ExibeDados()
        {
            base.ExibeDados();
            Console.WriteLine($"O seu adicional noturno anual é de: {adicionalNoturno}");
        }
    }