namespace Economize.Modelos
{
    public class AReceber : Registro
    {

        public int id { get; set; }
        public string Nome { get; set; }
        public string ValorDeCompra { get; set; }
        public string DataDeEntrega { get; set; }
        public string Fornecedor { get; set; }
    }

}