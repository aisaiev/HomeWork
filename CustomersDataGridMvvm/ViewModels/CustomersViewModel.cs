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
    public class CustomersViewModel
    {
        public ObservableCollection<Customer> Customers { get; set; }

        private ICustomersRepository Repository { get; set; }

        public ICommand GetCustomersCommand { get; set; }

        public CustomersViewModel()
        {
            if (DesignerProperties.GetIsInDesignMode(new System.Windows.DependencyObject()))
            {
                return;
            }
            this.Customers = new ObservableCollection<Customer>();
            this.Repository = new CustomersRepository();
            this.GetCustomersCommand = new RelayCommand(GetCustomersCommandExecute, GetCustomersCommandCanExecute);
        }

        public bool GetCustomersCommandCanExecute(object obj)
        {
            return true;
        }

        public async void GetCustomersCommandExecute(object obj)
        {
            List<Customer> customers = await this.Repository.GetCustomersAsync();
            foreach (var customer in customers)
            {
                this.Customers.Add(customer);
            }
        }
    }
}
