internal class Program
{
    private static void Main(string[] args)
    {

          Funcionario Fun = new Funcionario("Mariana", 200);
          Fun.ExibeDados();
          Console.WriteLine($"O ganho anual é: {Fun.GanhoAnual()}");
          Console.WriteLine("");

          Assistente Ass = new Assistente("Guilherme", 2000, 01);
          Ass.ExibeDados();
          Console.WriteLine($"O ganho anual é: {Ass.GanhoAnual()}");
          Console.WriteLine("");


          AssistenteTec Tec = new AssistenteTec("Roberta", 941, 02, 100);
          Tec.ExibeDados();
          Console.WriteLine($"O ganho anual é: {Tec.GanhoAnual()}");
          Console.WriteLine("");

          AssistenteAdm Admin = new AssistenteAdm("Felipe", 600, 03, "noite", 200);
          Admin.ExibeDados();
          Console.WriteLine($"O ganho anual é: {Admin.GanhoAnual()}");
          Console.WriteLine("");

    }
}