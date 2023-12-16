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
    public void PegarFatiaDeQueijoTest()
    {
        var expected = "Peguei uma fatia de queijo.\n";

        using (var saida = new StringWriter())
        {
            Console.SetOut(saida);

            Sanduiche.Program.PegarFatiaDeQueijo();

            Assert.EndsWith(expected, saida.ToString());
        }
    }

    [Fact]
    public void PegarFatiaTest()
    {
        var expected = "Peguei uma fatia de mortadela.\n";
        var expected2 = "Peguei uma fatia de queijo.\n";

        using (var saida = new StringWriter())
        {
            Console.SetOut(saida);

            Sanduiche.Program.PegarFatia("mortadela");

            Assert.EndsWith(expected, saida.ToString());

            Sanduiche.Program.PegarFatia("queijo");

            Assert.EndsWith(expected2, saida.ToString());
        }
    }
}