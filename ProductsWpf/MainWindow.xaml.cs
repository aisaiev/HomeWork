using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProductsWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new Product();
        }

        private void OnAddButtonClick(object sender, RoutedEventArgs e)
        {
            this.ProductTable.Items.Add(this.CreateProductFromInput());
        }

        private void OnRemoveRowContextMenuClick(object sender, RoutedEventArgs e)
        {
            if (this.ProductTable.Items.Count > 0)
            {
                this.ProductTable.Items.RemoveAt(this.ProductTable.SelectedIndex);
            }
        }

        private Product CreateProductFromInput()
        {
            ProductType productType = (ProductType)Enum.Parse(typeof(ProductType), this.ProductTypeComboBox.SelectedItem.ToString());
            string model = this.ModelTextBox.Text;
            double speed = double.Parse(this.SpeedTextBox.Text);
            double ram = double.Parse(this.RamTextBox.Text);
            double hd = double.Parse(this.HdTextBox.Text);
            double screen = double.Parse(this.ScreenTextBox.Text);
            decimal price = decimal.Parse(this.ScreenTextBox.Text);
            return new Product(productType, model, speed, ram, hd, screen, price);
        }

        private void OnClearAllContextMenuClick(object sender, RoutedEventArgs e)
        {
            this.ProductTable.Items.Clear();
        }

        private void OnMainWindowClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure want to close this app?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result != MessageBoxResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void OnExitMenuClick(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure want to close this app?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                Environment.Exit(0);
            }
        }
    }
}
