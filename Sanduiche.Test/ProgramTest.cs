using System.Diagnostics;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Xunit.Abstractions;

namespace Sanduiche.Test;

public class ProgramTest
{
    [Fact]
    public void MainTest()
    {
        /// expected é o valor esperado ao executar o programa
        string expected = "Sanduíche de Mortadela com Queijo está pronto!\n";

        /// StringWriter tem a função de armazenar a saída do nosso programa
        using (StringWriter saida = new StringWriter())
        {
            /// Aqui definimos que a saída do console será nosso StringWriter
            Console.SetOut(saida);

            /// Simulamos a chamada do nosso programa
            Sanduiche.Program.Main(null);

            /// Testamos se a saída do programa é a que esperamos
            Assert.EndsWith(expected, saida.ToString());
        }
    }
}