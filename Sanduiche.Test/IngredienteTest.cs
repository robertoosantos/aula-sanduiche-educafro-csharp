namespace Sanduiche.Test;

public class IngredienteTest
{
    [Fact]
    public void PrepararQueijoTest()
    {
        string expected = "queijo derretido";

        Ingredente queijo = new Queijo();
        queijo.Nome = "queijo";

        string actual = queijo.Preparar();

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void PrepararMortadelaTest()
    {
        string expected = "mortadela quente";

        Ingredente mortadela = new Mortadela();
        mortadela.Nome = "mortadela";

        string actual = mortadela.Preparar();

        Assert.Equal(expected, actual);
    }
}