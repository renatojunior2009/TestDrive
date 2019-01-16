using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using TestDrive.ViewModel.Base;
using TestDrive.ViewModel.Interfaces;

namespace TestDrive.ViewModel
{
    public class MainViewModel : ViewModelBase, IMainViewModel
    {
        #region Fields
        private ObservableCollection<string> _lista;
        #endregion

        #region Properties 
        public ObservableCollection<string> Lista
        {
            get
            {
                return _lista;
            }

            set
            {
                _lista = value;
                RaisedPropertyChanged(() => Lista);
            }
        }
        #endregion

        #region Constructor 
        public MainViewModel()
        {

        } 
        #endregion
    }
}
