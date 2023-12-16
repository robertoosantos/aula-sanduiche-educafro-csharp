
namespace Sanduiche;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Sanduíche de Mortadela com Queijo está pronto!");
    }

    public static void PegarFatiaDeQueijo()
    {
        Console.WriteLine("Peguei uma fatia de queijo.");
    }

    public static void PegarFatia(string ingrediente)
    {
        Console.WriteLine("Peguei uma fatia de {0}.", ingrediente);
    }
}
