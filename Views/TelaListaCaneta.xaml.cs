using appProvaA1Caneta.Model;

namespace appProvaA1Caneta.Views;

public partial class TelaListaCaneta : ContentPage
{
    public TelaListaCaneta()
    {
        InitializeComponent();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        lstCanetas.ItemsSource = await App.Database.GetCanetas();
    }

    private async void btnNovo_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new TelaIncluirCaneta());
    }

    private async void lstCanetas_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem != null)
        {
            Caneta canetaSelecionada = e.SelectedItem as Caneta;
            await Navigation.PushAsync(new TelaAlterarCaneta { BindingContext = canetaSelecionada });
            lstCanetas.SelectedItem = null;
        }
    }
}