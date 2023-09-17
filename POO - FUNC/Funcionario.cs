
// Exercício 1: Implemente a classe Funcionario com nome, salario e os métodos 
// addAumento(double valor), ganhoAnual() e exibeDados() - imprime os valores do funcionário.
// a. crie a classe Assistente, que também é um funcionário, e que possui um número de 
// matrícula (faça os métodos GET e SET). Sobrescreva o método exibeDados(). 
// b. sabendo que os Assistentes Técnicos possuem um bônus salarial e que os Assistentes 
// Administrativos possuem um turno (dia ou noite) e um adicional noturno, crie as classes 
// Tecnico e Administrativo e sobrescreva o método ganhoAnual() de ambas as classes 
// (Administrativo e Tecnico).


class Funcionario
{
    public string nome { get; set; }
    public double salario { get; set; }
    
    //Construtor para inicializar os atributos nome e salario.
    public Funcionario(string Nome, double Salario)
    {
        nome = Nome;
        salario = Salario;
    }

    //Usa-se a palavra-chave "virtual" para indicar que um método pode ser subscrito em classes derivadas.
    public virtual double GanhoAnual()
    {
        return salario * 12;
    }
    public double AddAumento(double valor)
    {
        return salario += valor;
    }

    public virtual void ExibeDados()
    {
        Console.WriteLine($"Funcionário: {nome}");
        Console.WriteLine($"Salário de : {salario}");
    }

}





