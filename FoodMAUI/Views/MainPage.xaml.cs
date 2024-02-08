namespace FoodMAUI.Views;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    async void Button_Pressed(System.Object sender, System.EventArgs e)
    {
		await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
    }
}


