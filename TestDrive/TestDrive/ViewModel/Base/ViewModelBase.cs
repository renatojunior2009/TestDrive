using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;

namespace TestDrive.ViewModel.Base
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        #region INotifyProperty Members

        public event PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisedPropertyChanged<T>(Expression<Func<T>> expression)
        {
            var memberExpression = expression.Body as MemberExpression;

            if (memberExpression != null)
            {
                var pInfo = memberExpression.Member as PropertyInfo;

                if (pInfo != null)
                {
                    if (PropertyChanged != null)
                        PropertyChanged(this, new PropertyChangedEventArgs(pInfo.Name));
                }

            }
        }

        #endregion

        #region Methods Publics
        
        #endregion
    }
}
