using pcso_remar.ViewModel;
namespace pcso_remar.View;

public partial class ProfilePage : ContentPage
{
	public ProfilePage(ProfileViewModel profileViewModel)
	{
		InitializeComponent();
        BindingContext = profileViewModel;
    }
}