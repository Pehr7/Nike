using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Menu_Modelo.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterPage : MasterDetailPage
    {
        public MasterPage()
        {
            InitializeComponent();
            Detail = new NavigationPage(new MainPage())
            { BarBackgroundColor = Color.Black };
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void ViewCell_Tapped(object sender, EventArgs e)
        {

        }

        private void GoPage1(object sender, EventArgs e)
        {
            Detail.Navigation.PushAsync(new Page1());
            IsPresented = false;
        }

        private void GoPage2(object sender, EventArgs e)
        {
            Detail.Navigation.PushAsync(new Page2());
            IsPresented = false;
        }

        private void GoPage3(object sender, EventArgs e)
        {
            Detail.Navigation.PushAsync(new Page3());
            IsPresented = false;
        }
    }
}