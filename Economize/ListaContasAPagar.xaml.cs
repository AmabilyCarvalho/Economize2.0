using Controles;
using Economize.Modelos;
using Microsoft.Maui.Controls;

namespace Economize;
public partial class ListaContasAPagar : ContentPage
{
    Controles.ContasAPagarControle contasAPagarControle = new Controles.ContasAPagarControle();
 
    public ListaContasAPagar()
    {
        InitializeComponent();
        ListaClientes.ItemsSource = contasAPagarControle.LerTodos();
    }

    void QuandoSelecionarUmItemNaLista(object sender, SelectedItemChangedEventArgs e)
    {
        var page = new ContasAPagarPage();
        page.contasAPagar = e.SelectedItem as ContasAPagar;
        Application.Current.MainPage = page;
    }

    private void OnBackButtonClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new ContasAPagarPage();
            Navigation.PopAsync();
        }

}