using Controles;
using Economize.Modelos;
using Microsoft.Maui.Controls;

namespace Economize;
public partial class ListaAReceber : ContentPage
{
    Controles.AReceberControle aReceberControle = new Controles.AReceberControle();
 
    public ListaAReceber()
    {
        InitializeComponent();
        ListaClientes.ItemsSource = aReceberControle.LerTodos();
    }

    void QuandoSelecionarUmItemNaLista(object sender, SelectedItemChangedEventArgs e)
    {
        var page = new AReceberPage();
        page.aReceber = e.SelectedItem as AReceber;
        Application.Current.MainPage = page;
    }

    private void OnBackButtonClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new AReceberPage();
            Navigation.PopAsync();
        }

}