using appProvaA1Caneta.Model;

namespace appProvaA1Caneta.Views;

public partial class TelaIncluirCaneta : ContentPage
{
    public TelaIncluirCaneta()
    {
        InitializeComponent();
    }

    private async void btnSalvar_Clicked(object sender, EventArgs e)
    {
        Caneta novaCaneta = new Caneta
        {
            canFabricante = txtFabricante.Text,
            canCor = txtCor.Text
        };

        await App.Database.InsertCaneta(novaCaneta);
        await DisplayAlert("Sucesso", "Caneta salva!", "OK");
        await Navigation.PopAsync();
    }
}