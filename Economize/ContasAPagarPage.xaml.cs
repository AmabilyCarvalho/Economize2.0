using Controles;
using Economize.Modelos;
using Microsoft.Maui.Controls;

namespace Economize
{
    public partial class ContasAPagarPage : ContentPage
    {
        ContasAPagarControle contasAPagarControle = new ContasAPagarControle();

        public ContasAPagar contasAPagar { get; set; }
        public ContasAPagarPage()
        {
            InitializeComponent();
        }

         private void OnBackButtonClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new TelaEscolhas();
            Navigation.PopAsync();
        }

         private void BotaoLista(object sender, EventArgs e)
        {
            Application.Current.MainPage = new ListaContasAPagar();
        }


        private void OnAddClicked(object sender, EventArgs e)
        {
            // Lógica para o botão de adicionar
            // Por exemplo, você pode adicionar o conteúdo do Field5Entry a uma lista
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (contasAPagar != null)
            {
               CompraEntry.Text = contasAPagar.Compra;
               ValorDeCompraEntry.Text = contasAPagar.ValorDeCompra;
               FornecedorEntry.Text = contasAPagar.Fornecedor;
            }
        }

         private void BotaoSalvar(object sender, EventArgs e)
        {
                        if (string.IsNullOrWhiteSpace(CompraEntry.Text) ||
                 string.IsNullOrWhiteSpace(ValorDeCompraEntry.Text) ||
                 string.IsNullOrWhiteSpace(FornecedorEntry.Text)) ;

            else
            {
                var c = new ContasAPagar();
                c.Compra = CompraEntry.Text;
                c.ValorDeCompra = ValorDeCompraEntry.Text;
                c.Fornecedor = FornecedorEntry.Text;
                contasAPagarControle.CriarOuAtualizar(c);

                Application.Current.MainPage = new TelaEscolhas();
            }
        }
    }
}