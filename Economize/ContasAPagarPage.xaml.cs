using Controles;
using Economize.Modelos;
using Microsoft.Maui.Controls;

namespace Economize
{
    public partial class ContaPage : ContentPage
    {
        ContasAPagarControle contasAPagarControle = new ContasAPagarControle();
        public ContaPage()
        {
            InitializeComponent();
        }

         private void OnBackButtonClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new TelaEscolhas();
            Navigation.PopAsync();
        }

        private void OnAddClicked(object sender, EventArgs e)
        {
            // Lógica para o botão de adicionar
            // Por exemplo, você pode adicionar o conteúdo do Field5Entry a uma lista
        }

         private void BotaoSalvar(object sender, EventArgs e)
        {
                        if (string.IsNullOrWhiteSpace(CompraEntry.Text) ||
                 string.IsNullOrWhiteSpace(ValorDeCompraEntry.Text) ||
                 string.IsNullOrWhiteSpace(DividaEntry.Text) ||
                 string.IsNullOrWhiteSpace(FornecedorEntry.Text)) ;

            else
            {
                var c = new ContasAPagar();
                c.Compra = CompraEntry.Text;
                c.ValorDeCompra = ValorDeCompraEntry.Text;
                c.Divida = DividaEntry.Text;
                c.Fornecedor = FornecedorEntry.Text;
                contasAPagarControle.CriarOuAtualizar(c);

                Application.Current.MainPage = new TelaEscolhas();
            }
        }
    }
}