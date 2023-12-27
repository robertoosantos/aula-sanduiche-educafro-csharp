public class Ingredente
{
    private string _nome;
    public string Nome
    {
        get { return _nome; }
        set { _nome = value; }
    }

    private string _marca;
    public string Marca
    {
        get { return _marca; }
        set { _marca = value; }
    }

    public virtual string Preparar() {
        string preparo = string.Format("Ingrediente {0} preparado!", _nome);
        return preparo;
    }
}