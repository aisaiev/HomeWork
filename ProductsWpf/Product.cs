using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsWpf
{
    public class Product : IDataErrorInfo
    {
        private ProductType type;

        private string model;

        private double speed;

        private double ram;

        private double hd;

        private double screen;

        private decimal price;

        public ProductType Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }

        public double Speed
        {
            get
            {
                return this.speed;
            }
            set
            {
                this.speed = value;
            }
        }

        public double Ram
        {
            get
            {
                return this.ram;
            }
            set
            {
                this.ram = value;
            }
        }

        public double Hd
        {
            get
            {
                return this.hd;
            }
            set
            {
                this.hd = value;
            }
        }

        public double Screen
        {
            get
            {
                return this.screen;
            }
            set
            {
                this.screen = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                this.price = value;
            }
        }

        public string this[string columnName]
        {
            get
            {
                string error = string.Empty;
                switch (columnName)
                {
                    case "Model":
                        if (string.IsNullOrWhiteSpace(this.Model))
                        {
                            error = "Invalid model name";
                        }
                        break;
                    case "Speed":
                        if (this.Speed <= 0)
                        {
                            error = "Speed <= 0";
                        }
                        break;
                    case "Ram":
                        if (this.Ram <= 0)
                        {
                            error = "Ram <= 0";
                        }
                        break;
                    case "Hd":
                        if (this.Hd <= 0)
                        {
                            error = "Hd <= 0";
                        }
                        break;
                    case "Screen":
                        if (this.Screen <= 0)
                        {
                            error = "Screen <= 0";
                        }
                        break;
                    case "Price":
                        if (this.Price <= 0)
                        {
                            error = "Price <= 0";
                        }
                        break;
                }
                return error;
            }
        }

        public string Error
        {
            get
            {
                return null;
            }
        }

        public Product()
        {

        }

        public Product(ProductType type, string model, double speed, double ram, double hd, double screen, decimal price)
        {
            this.Type = type;
            this.Model = model;
            this.Speed = speed;
            this.Ram = ram;
            this.Hd = hd;
            this.Screen = screen;
            this.Price = price;
        }
    }
}
