using System;
using Microsoft.Maui.Controls;

namespace Economize
{
    public partial class EditarDevedor : ContentPage
    {
        public EditarDevedor()
        {
            InitializeComponent();
        }

        private void OnSaveButtonClicked(object sender, EventArgs e)
        {
            string name = NameEntry.Text;
            string debt = DebtEntry.Text;

            // Lógica para salvar as informações do devedor
            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(debt))
            {
                // Supondo que o valor de dívida seja um número válido
                DisplayAlert("Sucesso", "Informações salvas com sucesso!", "OK");
                // Navegar de volta ou realizar outra ação após salvar
            }
            else
            {
                DisplayAlert("Erro", "Por favor, preencha todos os campos.", "OK");
            }
        }

        private void OnCancelButtonClicked(object sender, EventArgs e)
        {
            // Navegar de volta ou realizar outra ação de cancelamento
            Navigation.PopAsync();
        }
    }
}