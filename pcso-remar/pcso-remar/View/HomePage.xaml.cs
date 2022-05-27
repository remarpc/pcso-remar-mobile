using pcso_remar.ViewModel;

namespace pcso_remar.View;

public partial class HomePage : ContentPage
{
	public HomePage(HomeViewModel homeViewModel)
	{
		InitializeComponent();
        BindingContext = homeViewModel;
    }
}