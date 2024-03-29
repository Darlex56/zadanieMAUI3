using Microsoft.Maui.ApplicationModel.Communication;

namespace MAUI_zadanie3;

public partial class myProfil : ContentPage
{
	public myProfil()
	{
		InitializeComponent();
	}

    private void ImageButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        myContact.Text = "_almasus_";
        myLabelProfil.Text = "_almasus_";
        myImageContact.Source = "https://lh3.googleusercontent.com/kU1dgUjAYxn5vJB8mOGDD_ViOs4gFDKfG0-PvHMryf4AJ6i0q_0-vKF8apQp99p6eaXt5Sx577NXZ1kdvtsXViOZlA=w640-h400-e365-rj-sc0x00ffffff";
        descriptionContact.Text = "My name is _almasus_";
    }
}