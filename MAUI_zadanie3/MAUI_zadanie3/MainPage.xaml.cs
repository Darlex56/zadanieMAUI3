using System.Diagnostics.Contracts;

namespace MAUI_zadanie3
{
    public partial class MainPage : ContentPage
    {
        static List<Contact> contacts = new List<Contact>();
        Name name = new Name();
        public MainPage()
        {
            InitializeComponent();

            generateInstagram();
            ContactList.ItemsSource = contacts;

            if (Application.Current.MainPage.IsFocused) {
                bottomActivities.TextColor = Color.FromRgb(38, 127, 0);
            }
        }

        private void generateInstagram() {
            if(contacts.Count == 0) 
                for (int i = 0; i < 10; i++) {
                    string[] array = name.chooseSentence();
                    contacts.Add( new Contact { Image = @"https://picsum.photos/id/" + i + 8 + "/100/100/", Sentence = array[0], Name = array[1] });
                }
        }
        private async void ContactList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            await Navigation.PushAsync(new ProfilContact((Contact)e.SelectedItem)); 

            ContactList.SelectedItem = null;
        }

        private void Profil_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new myProfil());
        }
    }

    public class Contact {
    public String Image { get; set; }
    public String Name { get; set; }
    public String Sentence { get; set; }
    }

}
