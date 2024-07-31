using Microsoft.Maui.Controls;

namespace Economize
{
    public partial class AReceber : ContentPage
    {
        public AReceber()
        {
            InitializeComponent();
        }

        private async void OnBackClicked(object sender, EventArgs e)
        {
            // Lógica para o botão de voltar
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
    }
}