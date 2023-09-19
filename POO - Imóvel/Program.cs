// Exercício 4: Crie a classe Imovel, que possui um endereço e um preço. 
// a. crie uma classe Novo, que herda Imovel e possui um adicional no preço. Crie métodos de 
// acesso e impressão deste valor adicional. 
// b. crie uma classe Velho, que herda Imovel e possui um desconto no preço. Crie métodos de 
// acesso e impressão para este desconto

internal class Program
{
    private static void Main(string[] args)
    {
        Novo ImovelNovo = new Novo("Endereço X", 500.000, 25.000);
        Console.WriteLine($"O valor final do imóvel novo é: {ImovelNovo.ImprimeVLAdicional()} mil");

        Velho ImovelVelho = new Velho("Endereço Z", 300.000, 50.000);
        Console.WriteLine($"O valor final do imóvel velho é: {ImovelVelho.ImprimeVLDesconto()} mil");
    }
}