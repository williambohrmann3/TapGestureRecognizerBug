using System.Collections.ObjectModel;
using CommunityToolkit.Maui.Views;

namespace TapGestureRecognizerBug
{
    public partial class MyPopup : Popup
    {
        ObservableCollection<MyItem> MyItems { get; set; } = 
            [ new MyItem { MyName = "Item 1" }, new MyItem { MyName = "Item 2" } ];
        
        public MyPopup()
        {
            InitializeComponent();
            Initialize();
        }

        void Initialize()
        {
            MyCollectionView.BindingContext = this;
            MyCollectionView.ItemsSource = MyItems;
        }

        private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
        {
            MyCollectionView.BackgroundColor = Colors.Red;
        }
    }

    public class MyItem
    {
        public string MyName { get; set; }

        public override string ToString()
        {
            return MyName;
        }
    }

}
