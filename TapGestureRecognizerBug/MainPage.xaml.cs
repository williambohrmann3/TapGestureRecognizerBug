using CommunityToolkit.Maui.Views;
using System.Collections.ObjectModel;

namespace TapGestureRecognizerBug
{
    public partial class MainPage : ContentPage
    {
      
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var popup = new MyPopup();

            var result = await this.ShowPopupAsync(popup);
        }
    }
}
