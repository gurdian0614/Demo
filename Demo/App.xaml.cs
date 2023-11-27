using Demo.Pages.ContentPageDemo;
using Demo.Pages.FlyoutPageDemo;
using Demo.Pages.NewFolder;
using Demo.Pages.TabbedPageDemo;

namespace Demo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new NavigationPage(new Page1());
            /*var navigation = new NavigationPage(new Navigation1());
            navigation.BarBackgroundColor = Colors.Red;
            MainPage = navigation;*/
            //MainPage = new FlyoutPageDemo();
            MainPage = new TabDemo();
        }
    }
}
