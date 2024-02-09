namespace FoodMAUI.ViewModels
{
	public partial class HomeViewModel : ObservableObject
	{
		private readonly PizzaService _pizzaService;
		public HomeViewModel(PizzaService pizzaService)
		{
			_pizzaService = pizzaService;
			Pizzas = new(_pizzaService.GetPopularPizzas());
		}

		public ObservableCollection<PizzaModel> Pizzas { get; set; }

		[RelayCommand]
		public async Task GoToAllPizzasPage(bool fromSearch = false)
		{
			var parameters = new Dictionary<string, object>
			{
				[nameof(AllPizzasViewModel.FromSearch)] = fromSearch

			};
			await Shell.Current.GoToAsync(nameof(AllPizzasPage), animate: true, parameters);
		}

	}
}

