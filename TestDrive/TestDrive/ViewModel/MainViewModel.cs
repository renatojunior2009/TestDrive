using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using TestDrive.Model;
using TestDrive.ViewModel.Base;
using TestDrive.ViewModel.Interfaces;

namespace TestDrive.ViewModel
{
    public class MainViewModel : ViewModelBase, IMainViewModel
    {
        #region Fields
        private ObservableCollection<Veiculo> _lista;
        #endregion

        #region Properties 
        public ObservableCollection<Veiculo> Lista
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

            Lista = new ObservableCollection<Veiculo>();

            Lista.Add(new Veiculo() { Modelo = "HB 20" });
            Lista.Add(new Veiculo() { Modelo = "Palio" });
            Lista.Add(new Veiculo() { Modelo = "Punto" });
            Lista.Add(new Veiculo() { Modelo = "Kombi" });
            
        } 
        #endregion
    }
}
