using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartMenuLibrary;

namespace SmartMenuApp
{
    public class Binding
    {
        SmartMenu menu = new SmartMenu();
        public void BindingTest()
        {
            Console.WriteLine("Binding kørt");
            menu.MenuContinue = true;
        }
    }
}
