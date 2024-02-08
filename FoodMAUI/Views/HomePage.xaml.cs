namespace FoodMAUI.Views;

public partial class HomePage : ContentPage
{
	private readonly HomeViewModel _homeViewModel;
	public HomePage(HomeViewModel homeViewModel)
	{
		InitializeComponent();
		BindingContext = _homeViewModel = homeViewModel;
	}
}
