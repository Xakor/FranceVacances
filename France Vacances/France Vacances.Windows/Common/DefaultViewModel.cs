using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;
using Windows.UI.Xaml.Controls;

namespace France_Vacances.Common
{
    public class DefaultViewModel : INotifyPropertyChanged
    {

        // Pop up message
        public class MessageDialogHelper
        {
            public static async void Show(string content, string title)
            {
                MessageDialog messageDialog = new MessageDialog(content, title);
                await messageDialog.ShowAsync();
            }
        }

        public class NavigationService
        {
            readonly Frame frame;

            public NavigationService(Frame frame)
            {
                this.frame = frame;
            }

            public void GoBack()
            {
                frame.GoBack();
            }

            public void GoForward()
            {
                frame.GoForward();
            }

            public bool Navigate<T>(object parameter = null)
            {
                var type = typeof(T);

                return Navigate(type, parameter);
            }

            public bool Navigate(Type source, object parameter = null)
            {
                return frame.Navigate(source, parameter);
            }
        }

        // INotifyPropertyChanged Implementation
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private class NotifyPropertyChangedInvocatorAttribute : Attribute
        {
        }


    }
}
