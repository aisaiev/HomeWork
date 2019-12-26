using System;
using System.Collections.Generic;
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

namespace Calculator_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Grid_Click(object sender, RoutedEventArgs e)
        {
            FrameworkElement feSource = e.Source as FrameworkElement;
            switch (feSource.Name)
            {
                case "ButtonOne":
                    IsInputTextBlockShouldBeCleared();
                    this.InputTextBlock.Text += "1";
                    break;
                case "ButtonTwo":
                    IsInputTextBlockShouldBeCleared();
                    this.InputTextBlock.Text += "2";
                    break;
                case "ButtonThree":
                    IsInputTextBlockShouldBeCleared();
                    this.InputTextBlock.Text += "3";
                    break;
                case "ButtonFour":
                    IsInputTextBlockShouldBeCleared();
                    this.InputTextBlock.Text += "4";
                    break;
                case "ButtonFive":
                    IsInputTextBlockShouldBeCleared();
                    this.InputTextBlock.Text += "5";
                    break;
                case "ButtonSix":
                    IsInputTextBlockShouldBeCleared();
                    this.InputTextBlock.Text += "6";
                    break;
                case "ButtonSeven":
                    IsInputTextBlockShouldBeCleared();
                    this.InputTextBlock.Text += "7";
                    break;
                case "ButtonEight":
                    IsInputTextBlockShouldBeCleared();
                    this.InputTextBlock.Text += "8";
                    break;
                case "ButtonNine":
                    IsInputTextBlockShouldBeCleared();
                    this.InputTextBlock.Text += "9";
                    break;
                case "ButtonZero":
                    IsInputTextBlockShouldBeCleared();
                    this.InputTextBlock.Text += "0";
                    break;
            }
        }

        private void IsInputTextBlockShouldBeCleared()
        {
            if(this.InputTextBlock.Text.Length == 1 && this.InputTextBlock.Text == "0")
            {
                this.InputTextBlock.Text = string.Empty;
            }
        }
    }
}
