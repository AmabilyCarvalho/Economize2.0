using Controles;
using Microsoft.Maui.Controls;
using Economize.Modelos;

namespace Economize
{
    public partial class AReceberPage : ContentPage
    {
        AReceberControle aReceberControle = new AReceberControle();
        Controles.ClienteControle clienteControle = new Controles.ClienteControle();

        public AReceberPage()
        {
            InitializeComponent();

        }

        private async void OnBackClicked(object sender, EventArgs e)
        {

            Application.Current.MainPage = new TelaEscolhas();
            await Navigation.PopAsync();
        }

        private void OnAddClicked(object sender, EventArgs e)
        {
            // Lógica para o botão de adicionar
            // Por exemplo, você pode adicionar o conteúdo do Field5Entry a uma lista
        }

        private void OnSettingsClicked(object sender, EventArgs e)
        {
            // Lógica para o botão de configurações
        }

        private void OnDeleteClicked(object sender, EventArgs e)
        {
            // Lógica para o botão de exclusão
        }
        private void OnBackButtonClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new TelaEscolhas();
            Navigation.PopAsync();
        }
        private void BotaoSalvar(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NomeEntry.Text) ||
                 string.IsNullOrWhiteSpace(ValorDeCompraEntry.Text) ||
                 string.IsNullOrWhiteSpace(DataDeEntregaEntry.Text) ||
                 string.IsNullOrWhiteSpace(FornecedorEntry.Text)) ;

            else
            {
                var c = new AReceber();
                c.Nome = NomeEntry.Text;
                c.ValorDeCompra = ValorDeCompraEntry.Text;
                c.DataDeEntrega = DataDeEntregaEntry.Text;
                c.Fornecedor = FornecedorEntry.Text;
                aReceberControle.CriarOuAtualizar(c);

            }
        }
    }

   
}