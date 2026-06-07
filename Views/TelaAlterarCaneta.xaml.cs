using appProvaA1Caneta.Model;

namespace appProvaA1Caneta.Views;

public partial class TelaAlterarCaneta : ContentPage
{
    public TelaAlterarCaneta()
    {
        InitializeComponent();
    }

    private async void btnAtualizar_Clicked(object sender, EventArgs e)
    {
        Caneta canetaEditada = BindingContext as Caneta;
        canetaEditada.canFabricante = txtFabricante.Text;
        canetaEditada.canCor = txtCor.Text;

        await App.Database.UpdateCaneta(canetaEditada);
        await DisplayAlert("Sucesso", "Caneta atualizada!", "OK");
        await Navigation.PopAsync();
    }

    private async void btnExcluir_Clicked(object sender, EventArgs e)
    {
        Caneta canetaSelecionada = BindingContext as Caneta;
        await App.Database.DeleteCaneta(canetaSelecionada.canID);
        await DisplayAlert("Aviso", "Caneta excluída!", "OK");
        await Navigation.PopAsync();
    }
}