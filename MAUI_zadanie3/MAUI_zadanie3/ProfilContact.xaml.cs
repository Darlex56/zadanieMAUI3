using Microsoft.Maui.Platform;
using System.Xml;

namespace MAUI_zadanie3;

public partial class ProfilContact : ContentPage
{
    Contact contact;
	public ProfilContact(Contact contact)
	{
		InitializeComponent();
        this.contact = contact;
        BindingContext = contact;
	}

    protected  override void OnAppearing()
    {
        base.OnAppearing();
        nameProfil.Text =  contact.Name;
        nameContact.Text = contact.Name;
        imageContact.Source = contact.Image;
        descriptionContact.Text = "My name is " + contact.Name;
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }

}