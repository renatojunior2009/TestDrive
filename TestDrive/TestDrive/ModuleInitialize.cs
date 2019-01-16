using SimpleInjector;
using TestDrive.IocManager;
using TestDrive.ViewModel;
using TestDrive.ViewModel.Interfaces;

namespace TestDrive
{
    public static class ModuleInitialize
    {
        public static void Inicialize()
        {

            #region Register View Models 
            IoCApp.Container.Register<IMainViewModel, MainViewModel>(Lifestyle.Transient); 
            #endregion

        }
    }
}
