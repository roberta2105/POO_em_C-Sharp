using System.Dynamic;

class Assistente : Funcionario
    {
        private int matricula {get; set;}


        public Assistente(string Nome, double Salario, int Matricula): base(Nome, Salario)
        {
            matricula = Matricula;
        }

        public override void ExibeDados()
        {
            base.ExibeDados();
            Console.WriteLine($"A matrícula é: {matricula}");
        }
    }