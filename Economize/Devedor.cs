namespace Economize;
public class Devedores
{
    string nome;
     string Divida;

    Int64 id;
    public void SetNome (string nome)
    {
        this.nome=nome;
    }
    public string GetNome ()
    {
        return nome;
    }

    public void SetDivida (string Divida)
    {
        this.Divida=Divida;
    }
    public string GetDivida ()
    {
        return Divida;
    }
}