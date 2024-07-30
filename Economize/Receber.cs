namespace Economize;
public class Receber
{
    string nome;

    public void SetNome (string nome)
    {
        this.nome=nome;
    }
    public string GetNome ()
    {
        return nome;
    }


    string ValorDeCompra;
    public void SetValorDeCompra (string ValorDeCompra)
    {
        this.ValorDeCompra=ValorDeCompra;
    }
    public string GetValorDeCompra ()
    {
        return ValorDeCompra;
    }

    
    string DataDeEntrega;
    public void SetDataDeEntrega (string DataDeEntrega)
    {
        this.DataDeEntrega=DataDeEntrega;
    }
    public string GetDataDeEntrega ()
    {
        return DataDeEntrega;
    }
   

   string Fornecedor;
    public void SetFornecedor (string Fornecedor)
    {
        this.Fornecedor=Fornecedor;
    }
    public string GetFornecedor ()
    {
        return Fornecedor;
    }
}