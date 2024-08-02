using Microsoft.Maui.Controls;

namespace Economize
{
    public partial class EditarAReceber : ContentPage
    {
        public EditarAReceber()
        {
            InitializeComponent();
        }

        private async void OnSalvarClicked(object sender, EventArgs e)
        {
            // Lógica para salvar as informações
            string nome = NomeEntry.Text;
            string dataEntrega = DataEntregaEntry.Text;
            string valorCompra = ValorCompraEntry.Text;

            // Exemplo de ação: exibir um alerta
            await DisplayAlert("Salvar", $"Nome: {nome}\nData de Entrega: {dataEntrega}\nValor da Compra: {valorCompra}", "OK");
        }

        private void OnCancelarClicked(object sender, EventArgs e)
        {
            // Lógica para cancelar a operação
            NomeEntry.Text = string.Empty;
            DataEntregaEntry.Text = string.Empty;
            ValorCompraEntry.Text = string.Empty;
        }
    }
}