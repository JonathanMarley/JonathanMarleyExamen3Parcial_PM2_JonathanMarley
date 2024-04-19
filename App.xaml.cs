using Plugin.Maui.Audio;
using ExamenFinal_JonathanMarley.Views;
using ExamenFinal_JonathanMarley.Controllers;
using ExamenFinal_JonathanMarley.Models;

namespace ExamenFinal_JonathanMarley
{
    public partial class App : Application
    {
        public static FirebaseController db = new FirebaseController();
        public static Notas nota;

        public App()
        {
            InitializeComponent();

            //MainPage = new AppShell();
            MainPage = new NavigationPage(new PaginaPrincipal(AudioManager.Current));

        }
    }
}
