using Controles;
using Microsoft.Maui.Controls;

namespace Economize
{
    public partial class AReceber : ContentPage
    {
        Controles.ClienteControle clienteControle = new Controles.ClienteControle();

        public AReceber()
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
        void Valor(object sender, SelectedItemChangedEventArgs e)
        {
            var page = new AReceber();
            Application.Current.MainPage = page;
        }
        private void BotaoSalvar(object sender, EventArgs e)
        {
           var cp = new ClienteControle();
           cp.Compra = CompraEntry.Text;
           cp.Divida = DividaEntry.Text;
           cp.Fornecedor = FornecedorEntry.Text;
           ClienteControle.CriarOuAtualizar(cp);
           
            await DisplayAlert("Salvar", "Dados salvos com sucesso!", "OK");
        }
    }
}