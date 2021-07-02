namespace MVVM_Reg
{
    using System.ComponentModel;
    using Autofac;
    using MVVM_Reg.ViewModel;
    public class Bootstrapper
    {
        public Autofac.IContainer Bootstra()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<MainWindow>().AsSelf();
            builder.RegisterType<MainWindowViewModel>().AsSelf();
            return builder.Build();
        }
    }
}
