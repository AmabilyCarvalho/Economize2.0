using Microsoft.Maui.Controls;

namespace Economize
{
    public partial class EditarContas : ContentPage
    {
        public EditarContas()
        {
            InitializeComponent();
        }

        private async void OnSalvarClicked(object sender, EventArgs e)
        {
            // Lógica para salvar as informações
            string nome = NomeEntry.Text;
            string compra = CompraEntry.Text;
            string divida = DividaEntry.Text;

            // Exemplo de ação: exibir um alerta
            await DisplayAlert("Salvar", $"Nome: {nome}\nCompra: {compra}\nDívida: {divida}", "OK");
        }

        private void OnCancelarClicked(object sender, EventArgs e)
        {
            // Lógica para cancelar a operação
            NomeEntry.Text = string.Empty;
            CompraEntry.Text = string.Empty;
            DividaEntry.Text = string.Empty;
        }
    }
}