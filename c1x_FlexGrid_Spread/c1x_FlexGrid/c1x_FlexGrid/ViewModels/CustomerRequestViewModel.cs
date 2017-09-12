using System;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace c1x_FlexGrid
{
    public class CustomerRequestViewModel : INotifyPropertyChanged
    {
        // 問合せのコレクション
        private ObservableCollection<CustomerRequest> _requests;
        public CustomerRequestViewModel()
        {
            _requests = (new CustomerRequestCollection()).GetCustomerRequests();
        }
        public ObservableCollection<CustomerRequest> CustomerRequests
        {
            get { return _requests; }
            set
            {
                if (_requests != value)
                {
                    _requests = value;
                    NotifyPropertyChanged("CustomerRequests");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
