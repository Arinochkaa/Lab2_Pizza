using ConsoleApp2.Classes;
using ConsoleApp2.Ingredients.Classes;
using ConsoleApp2.Новая_папка;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Builders.Classes
{
   public class PepperoniBuilder : IBuilder
    {

       // public Pizza pizza { get; set; } //реализация свойства из интерфейса IBuilder
        public PepperoniBuilder()
        {
            //this.Reset();
        }


        public override void AddCheese()
        {
            pizza.Add(new Cheese());
        }

        public override void AddMeat()
        {
           
        }

        public override void AddOlives()
        {
            
        }

        public override void AddTomatoes()
        {
            pizza.Add(new Tomatoes());
        }

        //public Pizza GetResult()
        //{
        //    return pizza;
        //}

        public override void Reset()
        {
            pizza = new Pizza();
        }
    }
}
