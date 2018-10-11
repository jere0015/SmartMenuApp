using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartMenuLibrary;
using SmartMenuApp;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Run();
        }

        private void Run()
        {
            SmartMenu menu = new SmartMenu();
            menu.LoadMenu("MenuSpec.txt");            
            Binding test = new Binding();
            test.BindingTest();
            menu.Activate();
        }
    }
}
