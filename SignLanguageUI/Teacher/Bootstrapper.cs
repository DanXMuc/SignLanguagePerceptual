using System.Windows;
using Caliburn.Micro;

namespace Teacher
{
    class Bootstrapper : BootstrapperBase {
        public Bootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e) {
            DisplayRootViewFor<MainViewModel>();
        }
    }
}
