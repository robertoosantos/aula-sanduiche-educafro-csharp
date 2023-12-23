public class Robo
{
    public void PegarFatia(string ingrediente, int quantidade)
    {
        if (quantidade < 0)
        {
            throw new ArgumentOutOfRangeException();
        }

        for (int i = 0; i < quantidade; i++)
        {
            Console.WriteLine("Peguei uma fatia de {0}.", ingrediente);
        }
    }
}