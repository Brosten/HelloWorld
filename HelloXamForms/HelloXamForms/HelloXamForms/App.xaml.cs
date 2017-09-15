
using Xamarin.Forms;

namespace HelloXamForms
{
   public partial class App : Application
   {
      public App()
      {
         InitializeComponent();

         MainPage = new HelloXamForms.MainPage();
      }

      protected override void OnStart()
      {
         // Handle when your app starts
         // Ny rad
      }

      protected override void OnSleep()
      {
         // Handle when your app sleeps
      }

      protected override void OnResume()
      {
         // Handle when your app resumes
      }
   }
}
