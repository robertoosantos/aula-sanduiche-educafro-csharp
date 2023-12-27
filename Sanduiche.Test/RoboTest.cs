using System.Diagnostics;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace Sanduiche.Test;

public class RoboTest
{
    [Fact]
    public void PegarFatiaTest()
    {
        string expectedMortadela = "Peguei uma fatia de mortadela.\n";
        string expectedQueijo = "Peguei uma fatia de queijo.\nPeguei uma fatia de queijo.\n";

        Robo roboMortadelaComQueijo = new Robo();
        Ingredente mortadela = new Ingredente();
        mortadela.Nome = "mortadela";

        Ingredente queijo = new Ingredente();
        queijo.Nome = "queijo";

        string actualMortadela = roboMortadelaComQueijo.PegarFatia(mortadela, 1);

        Assert.Equal(expectedMortadela, actualMortadela);

        string atualQueijo = roboMortadelaComQueijo.PegarFatia(queijo, 2);

        Assert.Equal(expectedQueijo, atualQueijo);
    }

    [Fact]
    public void PegarFatiaNegativaTest()
    {
        Robo roboMortadelaComQueijo = new Robo();
        Ingredente presunto = new Ingredente();

        using (StringWriter saida = new StringWriter())
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => roboMortadelaComQueijo.PegarFatia(presunto, -5));
        }
    }
}