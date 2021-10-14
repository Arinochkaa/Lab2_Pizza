using ConsoleApp2.Classes;
using ConsoleApp2.Ingredients.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Builders.Classes
{
    public class MargaritaBuilder : IBuilder
    {
        //public Pizza pizza { get; set; }  //реализация свойства из интерфейса IBuilder

        public MargaritaBuilder()
        {
           // this.Reset();
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
            pizza.Add(new Olives());
        }

        public override void AddTomatoes()
        {
            pizza.Add(new Tomatoes());
        }

        //public Pizza GetResult()
        //{
        //    return pizza;
        //}
       
        public override void Reset(){
            pizza = new Pizza();
        }


}
}
