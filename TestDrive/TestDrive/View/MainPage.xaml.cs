using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDrive.IocManager;
using TestDrive.ViewModel.Interfaces;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestDrive.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : ContentPage
	{
		public MainPage ()
		{
			InitializeComponent ();
            BindingContext = IoCApp.Container.GetInstance<IMainViewModel>();
		}
	}
}