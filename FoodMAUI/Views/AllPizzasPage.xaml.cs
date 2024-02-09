namespace FoodMAUI.Views;

public partial class AllPizzasPage : ContentPage
{
	private readonly AllPizzasViewModel _allPizzasViewModel;
    public AllPizzasPage(AllPizzasViewModel allPizzasViewModel)
	{
		InitializeComponent();
		BindingContext = _allPizzasViewModel = allPizzasViewModel;
	}

    void SearchBar_TextChanged(System.Object sender, Microsoft.Maui.Controls.TextChangedEventArgs e)
    {
		if(!string.IsNullOrEmpty(e.OldTextValue) && string.IsNullOrEmpty(e.NewTextValue))
		{
			_allPizzasViewModel.SearchPizzasCommand.Execute(null);
		}
    }
}
