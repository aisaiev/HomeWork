using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Zza.Data;
using ZzaDashboard.Commands;
using ZzaDashboard.Services;

namespace ZzaDashboard.ViewModels
{
    public class CustomersViewModel
    {
        public ObservableCollection<Customer> Customers { get; set; }

        public Customer SelectedCustomer { get; set; }

        private ICustomersRepository Repository { get; set; }

        public CustomersViewModel()
        {
            if (DesignerProperties.GetIsInDesignMode(new System.Windows.DependencyObject()))
            {
                return;
            }
            this.Customers = new ObservableCollection<Customer>();
            this.Repository = new CustomersRepository();
            List<Customer> customers = this.Repository.GetCustomersAsync().Result;
            foreach (var customer in customers)
            {
                this.Customers.Add(customer);
            }
        }
    }
}
