using Controles;
using Economize.Modelos;
using Microsoft.Maui.Controls;

namespace Economize;
public partial class ListaDevedor : ContentPage
{
    Controles.DevedorControle devedorControle = new Controles.DevedorControle();
 
    public ListaDevedor()
    {
        InitializeComponent();
        ListaClientes.ItemsSource = devedorControle.LerTodos();
    }

    void QuandoSelecionarUmItemNaLista(object sender, SelectedItemChangedEventArgs e)
    {
        var page = new DevedorPage();
        page.devedor = e.SelectedItem as Devedor;
        Application.Current.MainPage = page;
    }

    private void OnBackButtonClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new DevedorPage();
            Navigation.PopAsync();
        }

}