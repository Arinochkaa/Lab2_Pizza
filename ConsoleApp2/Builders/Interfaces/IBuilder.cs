using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using System.Threading;

namespace ConsoleApp2.Classes
{
   public abstract class IBuilder
    {
        public Pizza pizza { get; set; } = new Pizza();//объявили свойства для всех наследников

        abstract public void AddCheese();
        abstract public void AddTomatoes();
        abstract public void AddOlives();
        abstract public void AddMeat();
        abstract public void Reset();

        
    }
    
}
