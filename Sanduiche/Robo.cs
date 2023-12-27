public class Robo
{
    public string PegarFatia(Ingredente ingrediente, int quantidade)
    {
        string fatias = "";

        if (quantidade < 0)
        {
            throw new ArgumentOutOfRangeException();
        }

        for (int i = 0; i < quantidade; i++)
        {
            fatias = fatias + string.Format("Peguei uma fatia de {0}.\n", ingrediente.Nome);
        }

        return fatias;
    }
}