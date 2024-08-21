namespace Economize.Modelos
{
    public class ContasAPagar : Registro
    {

        public int id { get; set; }
        public string Compra { get; set; }
        public string ValorDeCompra { get; set; }
        public string Divida { get; set; }
        public string Fornecedor { get; set; }
        
    }

}