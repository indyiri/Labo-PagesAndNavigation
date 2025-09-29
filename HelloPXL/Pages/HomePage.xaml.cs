using System.Threading.Tasks;

namespace HelloPXL.Pages;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}

    private async void GoToAboutClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(AboutPage));
    }

    private async void GoToMenuClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(MenuPage));
    }
}