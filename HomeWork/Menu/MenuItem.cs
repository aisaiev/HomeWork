using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Menu
{
    public class MenuItem
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public Action Action { get; set; }

        public MenuItem(int id, string text, Action action)
        {
            this.Id = id;
            this.Text = text;
            this.Action = action;
        }
    }
}
