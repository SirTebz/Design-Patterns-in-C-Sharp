using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Creational.AbstractFactory.BadExample.Windows
{
    // /Windows/WindowsButton
    public class WindowsButton : IButton
    {
        public void Render()
        {
            System.Console.WriteLine("Windows: render button");
        }
    }
}