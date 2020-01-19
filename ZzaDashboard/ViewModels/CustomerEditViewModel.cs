using System;
using System.Collections.Generic;
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
    public class CustomerEditViewModel
    {
        private readonly Guid customerId = new Guid("11DA4696-CEA3-4A6D-8E83-013F1C479618");

        public Customer Customer { get; set; }

        public ICommand SaveCommand { get; set; }

        private ICustomersRepository CustomersRepository { get; set; }

        public CustomerEditViewModel()
        {
            if (DesignerProperties.GetIsInDesignMode(new System.Windows.DependencyObject()))
            {
                return;
            }
            this.CustomersRepository = new CustomersRepository();
            this.Customer = this.CustomersRepository.GetCustomerAsync(this.customerId).Result;
            this.SaveCommand = new RelayCommand(this.SaveCommandExecute, this.SaveCommandCanExecute);
        }

        public bool SaveCommandCanExecute(object obj)
        {
            if (!string.IsNullOrWhiteSpace(this.Customer.FirstName)
                && !string.IsNullOrWhiteSpace(this.Customer.LastName)
                && !string.IsNullOrWhiteSpace(this.Customer.Phone))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public async void SaveCommandExecute(object obj)
        {
            await this.CustomersRepository.UpdateCustomerAsync(this.Customer);
        }
    }
}
