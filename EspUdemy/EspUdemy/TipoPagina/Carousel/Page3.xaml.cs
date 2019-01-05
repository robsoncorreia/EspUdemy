using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EspUdemy.TipoPagina.Carousel
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page3 : ContentPage
    {
        public Page3()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, System.EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new Navigation.Page1());
        }
    }
}