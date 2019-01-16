using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestDrive.IocManager
{
    public class IoCApp
    {

        #region Fields
        private static Container _container;
        #endregion

        #region Properties
        public static Container Container
        {
            get { return _container; }
        } 
        #endregion

        static IoCApp()
        {
            _container = new Container();
        }

    }
}
