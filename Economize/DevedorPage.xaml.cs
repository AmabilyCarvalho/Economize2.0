using System;
using Controles;
using Economize.Modelos;
using Microsoft.Maui.Controls;

namespace Economize
{

    public partial class DevedorPage : ContentPage
    {
        Controles.DevedorControle devedorControle = new Controles.DevedorControle();
        public Devedor devedor { get; set; }
        
        public DevedorPage()
        {
            InitializeComponent();
        }

        private void OnAddDebtorButtonClicked(object sender, EventArgs e)
        {
            // Adicionar novo campo de devedor
            Entry newDebtorEntry = new Entry
            {
                Placeholder = "Novo devedor",
                BackgroundColor = Colors.White,
                TextColor = Colors.Black
            };
            // Adiciona o novo campo ao StackLayout
            //(Content as Grid).Children[1].Add(newDebtorEntry);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (devedor != null)
            {
               NomeEntry.Text = devedor.Nome;
               ValorDividaEntry.Text = devedor.ValorDivida;
            }
        }

        private void OnBackButtonClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new TelaEscolhas();
            Navigation.PopAsync();
        }

         private void BotaoLista(object sender, EventArgs e)
        {
            Application.Current.MainPage = new ListaDevedor();
        }

        private void OnSettingsButtonClicked(object sender, EventArgs e)
        {

        }

        private void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            // Implementar funcionalidade de deletar (devedores, etc.)
        }

        private void BotaoSalvar(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NomeEntry.Text) ||
                 string.IsNullOrWhiteSpace(ValorDividaEntry.Text)) ;

            else
            {
                var d = new Devedor();
                d.Nome = NomeEntry.Text;
                d.ValorDivida = ValorDividaEntry.Text;
                devedorControle.CriarOuAtualizar(d);

                Application.Current.MainPage = new TelaEscolhas();

            }
        }

    }
    
}