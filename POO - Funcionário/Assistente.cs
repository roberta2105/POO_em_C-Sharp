using System.Dynamic;

class Assistente : Funcionario
    {
        private int matricula {get; set;}


        public Assistente(string Nome, double Salario, int Matricula): base(Nome, Salario)
        {
            matricula = Matricula;
        }

        //Usa-se o "override" para subscrever um método "virtual"
        public override void ExibeDados()
        {
            base.ExibeDados();
            Console.WriteLine($"A matrícula é: {matricula}");
        }
    }