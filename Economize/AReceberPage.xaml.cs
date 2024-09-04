using Controles;
using Microsoft.Maui.Controls;
using Economize.Modelos;

namespace Economize
{
    public partial class AReceberPage : ContentPage
    {
        Controles.AReceberControle aReceberControle = new Controles.AReceberControle();
        public AReceber aReceber { get; set; }

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

        private void BotaoLista(object sender, EventArgs e)
        {
            Application.Current.MainPage = new ListaAReceber();
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

         protected override void OnAppearing()
        {
            base.OnAppearing();

            if (aReceber != null)
            {
               NomeEntry.Text = aReceber.Nome;
               ValorDeCompraEntry.Text = aReceber.ValorDeCompra;
               DataDeEntregaEntry.Text = aReceber.DataDeEntrega;
               FornecedorEntry.Text = aReceber.Fornecedor;
            }
        }
        private void BotaoSalvar(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NomeEntry.Text) ||
                 string.IsNullOrWhiteSpace(ValorDeCompraEntry.Text) ||
                 string.IsNullOrWhiteSpace(DataDeEntregaEntry.Text) ||
                 string.IsNullOrWhiteSpace(FornecedorEntry.Text)) ;

            else
            {
                var a = new AReceber();
                a.Nome = NomeEntry.Text;
                a.ValorDeCompra = ValorDeCompraEntry.Text;
                a.DataDeEntrega = DataDeEntregaEntry.Text;
                a.Fornecedor = FornecedorEntry.Text;
                aReceberControle.CriarOuAtualizar(a);

                

            }
        }
    }
}