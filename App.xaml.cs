using Autofac;
using System.Windows;

namespace MVVM_Reg
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            var bootStrapper = new Bootstrapper();
            var container = bootStrapper.Bootstra();

            var mainWindow = container.Resolve<MainWindow>();
            mainWindow.Show();
        }
    }
}
