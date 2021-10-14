using ConsoleApp2.Classes;
using ConsoleApp2.Ingredients.Classes;
using ConsoleApp2.Новая_папка;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Builders.Classes
{
    public class ItallianBuilder : IBuilder
    {
     //   public Pizza pizza { get; set; }//реализация свойства из интерфейса IBuilder

        public ItallianBuilder()
        {
           // this.Reset();
        }

        public override void AddCheese()
        {
            pizza.Add(new Cheese());
        }

        public override void AddMeat()
        {
            pizza.Add(new Meat());
        }

        public override void AddOlives()
        {
            pizza.Add(new Olives());
        }

        public override void AddTomatoes()
        {
            pizza.Add(new Tomatoes());
        }

        

        public override void Reset()
        {
            pizza = new Pizza();
        }
    }
}
