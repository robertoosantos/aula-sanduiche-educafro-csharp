using System.Diagnostics;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace Sanduiche.Test;

public class RoboTest
{
    [Fact]
    public void PegarFatiaTest()
    {
        var expected = "Peguei uma fatia de mortadela.\n";
        var expected2 = "Peguei uma fatia de queijo.\nPeguei uma fatia de queijo.\n";

        Robo roboMortadelaComQueijo = new Robo();
        Ingredente mortadela = new Ingredente();
        mortadela.Nome = "mortadela";
        
        Ingredente queijo = new Ingredente();
        queijo.Nome = "queijo";

        using (var saida = new StringWriter())
        {
            Console.SetOut(saida);

            roboMortadelaComQueijo.PegarFatia(mortadela, 1);

            Assert.EndsWith(expected, saida.ToString());

            roboMortadelaComQueijo.PegarFatia(queijo, 2);

            Assert.EndsWith(expected2, saida.ToString());
        }
    }

    [Fact]
    public void PegarFatiaNegativaTest()
    {
        Robo roboMortadelaComQueijo = new Robo();
        Ingredente presunto = new Ingredente();

        using (var saida = new StringWriter())
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => roboMortadelaComQueijo.PegarFatia(presunto, -5));
        }
    }
}