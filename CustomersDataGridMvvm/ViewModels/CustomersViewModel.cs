using CustomersDataGridMvvm.Commands;
using CustomersDataGridMvvm.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Zza.Data;

namespace CustomersDataGridMvvm.ViewModels
{
    public class CustomersViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Customer> customers;

        public ObservableCollection<Customer> Customers
        {
            get
            {
                return this.customers;
            }
            set
            {
                if (this.customers == value)
                {
                    return;
                }
                this.customers = value;
                this.OnPropertyChanged(nameof(this.Customers));
            }
        }

        private ICustomersRepository Repository { get; set; }

        public ICommand GetCustomersCommand { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public CustomersViewModel()
        {
            if (DesignerProperties.GetIsInDesignMode(new System.Windows.DependencyObject()))
            {
                return;
            }
            this.Repository = new CustomersRepository();
            this.GetCustomersCommand = new RelayCommand(GetCustomersCommandExecute, GetCustomersCommandCanExecute);
        }

        public bool GetCustomersCommandCanExecute(object obj)
        {
            return true;
        }

        public async void GetCustomersCommandExecute(object obj)
        {
            this.Customers = new ObservableCollection<Customer>(await this.Repository.GetCustomersAsync());
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged is null)
            {
                return;
            }
            this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
