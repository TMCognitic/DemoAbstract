using System.Configuration;
using System.Data;
using System.Runtime.CompilerServices;
using System.Windows;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public new static App Current
        {
            get { return (App)Application.Current; }
        }

        public Guid Uid
        {
            get { return Guid.NewGuid(); }
        }

        public App()
        {
            Console.WriteLine(App.Current.Uid);
        }
    }

}
