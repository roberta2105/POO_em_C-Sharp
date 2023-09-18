// Exercício 3 (SLIDE): Crie uma classe chamada Ingresso que possui um valor em reais e um 
// método imprimeValor(). 
// a. crie uma classe VIP, que herda Ingresso e possui um valor adicional. Crie um método que 
// retorne o valor do ingresso VIP (com o adicional incluído). 
// b. crie uma classe Normal, que herda Ingresso e possui um método que imprime: "Ingresso 
// Normal". 
// c. crie uma classe CamaroteInferior (que possui a localização do ingresso e métodos para 
// acessar e imprimir esta localização) e uma classe CamaroteSuperior, que é mais cara (possui 
// valor adicional). Esta última possui um método para retornar o valor do ingresso. Ambas as 
// classes herdam a classe VIP


internal class Program
{
    private static void Main(string[] args)
    {
        ValorPadrao ingressoNormal = new ValorPadrao(20);
        ingressoNormal.imprimePadrao();
        Console.WriteLine("");

        ClasseVIP ingressoVIP = new ClasseVIP(20, 15);
        Console.WriteLine($"O valor do ingresso VIP é: {ingressoVIP.ValorVIP()}");
        Console.WriteLine("");

        CamaroteInferior ingressoCI = new CamaroteInferior(20,15,"localA");
        ingressoCI.Localizacao();
        Console.WriteLine($"O valor do ingresso é: {ingressoCI.ValorVIP()}");
        Console.WriteLine("");

        CamaroteSuperior ingressoCS = new CamaroteSuperior(20,30);
        Console.WriteLine($"O valor do ingresso é: {ingressoCS.ValorVIP()}");
        Console.WriteLine("");


    }
}