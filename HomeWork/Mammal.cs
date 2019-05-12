using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public class Mammal
    {
        private int age;

        private int weight;

        private int foodAmount;

        public int Age
        {
            get
            {
                return age;
            }
            private set
            {
                if (value > 0)
                {
                    age = value;
                }
                else
                {
                    age = 1;
                }
            }
        }

        public int Weight
        {
            get
            {
                return weight;
            }
            private set
            {
                if (value > 0)
                {
                    weight = value;
                }
                else
                {
                    weight = 1;
                }
            }
        }

        public Mammal(int age)
        {
            this.Age = age;
            this.Weight = 1;
        }

        public void Eat(int foodAmount)
        {
            if (age <= 1)
            {
                Console.WriteLine($"{this.GetType().Name} eat milk");
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} eat other food");
            }
            this.foodAmount += foodAmount;
            if (this.foodAmount % 5 == 0)
            {
                this.Weight++;
            }
        }
    }
}
