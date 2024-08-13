using Economize.Modelos;

namespace Modelos;
public class ContasAPagar
 {
     string Compra;
     string Divida;
     string Fornecedor;

    public void SetCompra (string Compra)
    {
        this.Compra=Compra;
    }
    public string GetCompra ()
    {
        return Compra;
    }


    public void SetDivida (string Divida)
    {
        this.Divida=Divida;
    }
    public string GetDivida ()
    {
        return Divida;
    }


     public void SetFornecedor (string Fornecedor)
    {
        this.Fornecedor=Fornecedor;
    }
    public string GetFornecedor ()
    {
        return Fornecedor;
    }

 }   