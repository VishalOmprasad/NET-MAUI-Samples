namespace ImageCrash;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
	}

    private async void CloseOnClicked(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }
}