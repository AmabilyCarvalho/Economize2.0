namespace Modelos;
public class Vendas
{
     string DataPedido;
     string Preço;
     string Desconto;


    public void SetDataPedido (string DataPedido)
    {
        this.DataPedido=DataPedido;
    }
    public string GetDataPedido ()
    {
        return DataPedido;
    }

    public void SetPreço (string Preço)
    {
        this.Preço=Preço;
    }
    public string GetPreço ()
    {
        return Preço;
    }

    public void SetDesconto (string Desconto)
    {
        this.Desconto=Desconto;
    }
    public string GetDesconto ()
    {
        return Desconto;
    } 
}