using System.Diagnostics;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace Sanduiche.Test;

public class ProgramTest
{
    [Fact]
    public void MainTest()
    {
        /// expected é o valor esperado ao executar o programa
        var expected = "Sanduíche de Mortadela com Queijo está pronto!\n";

        /// A função Main do nosso programa recebe um parâmetro chamado args
        /// Aqui criamos um variável para simular o valor desse parâmetro
        string[] args = { };

        /// StringWriter tem a função de armazenar a saída do nosso programa
        using (var saida = new StringWriter())
        {
            /// Aqui definimos que a saída do console será nosso StringWriter
            Console.SetOut(saida);

            /// Simulamos a chamada do nosso programa
            Sanduiche.Program.Main(args);

            /// Testamos se a saída do programa é a que esperamos
            Assert.EndsWith(expected, saida.ToString());
        }
    }

    [Fact]
    public void PegarFatiaTest()
    {
        var expected = "Peguei uma fatia de mortadela.\n";
        var expected2 = "Peguei uma fatia de queijo.\nPeguei uma fatia de queijo.\n";

        Robo roboMortadelaComQueijo = new Robo();

        using (var saida = new StringWriter())
        {
            Console.SetOut(saida);

            roboMortadelaComQueijo.PegarFatia("mortadela", 1);

            Assert.EndsWith(expected, saida.ToString());

            roboMortadelaComQueijo.PegarFatia("queijo", 2);

            Assert.EndsWith(expected2, saida.ToString());
        }
    }

    [Fact]
    public void PegarFatiaNegativaTest()
    {
        Robo roboMortadelaComQueijo = new Robo();

        using (var saida = new StringWriter())
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => roboMortadelaComQueijo.PegarFatia("presunto", -5));
        }
    }
}