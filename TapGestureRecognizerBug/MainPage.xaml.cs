using System.Collections.ObjectModel;

namespace TapGestureRecognizerBug
{
    public partial class MainPage : ContentPage
    {
        ObservableCollection<MyItem> MyItems { get; set; } = 
            [ new MyItem { MyName = "Item 1" }, new MyItem { MyName = "Item 2" } ];
        
        public MainPage()
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
