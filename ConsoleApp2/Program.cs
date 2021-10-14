using ConsoleApp2.Builders.Classes;
using ConsoleApp2.Classes;
using System;

namespace ConsoleApp2
{
     class Program
    {
        static void Main(string[] args)
        {
            IBuilder builder = PizzasInfo();
            Pizza pizza = SelectIngredients(builder);
            GetResult(pizza);
        }

        //выбор основы пиццы
        static IBuilder PizzasInfo()
        { 
           Console.WriteLine("Выберите пиццу: \n 1.Маргарита \n 2.Карбонара \n 3.Итальянская \n 4.Пепперони");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1: return new MargaritaBuilder();
                case 2: return new CarbonaraBuilder();
                case 3: return new ItallianBuilder();
                case 4: return new PepperoniBuilder();

            }
            return null;
        }
        //предоставление ингредиентов по выбранной основе 
        static Pizza SelectIngredients(IBuilder builder)
        {
            while (true)
            {
                Console.WriteLine("Выберите ингредиенты: \n 1.Сыр \n 2.Томаты \n 3.Оливки \n 4.Мясо \n 5.Результат");
                int addj = Convert.ToInt32(Console.ReadLine());
                switch (addj)
                {
                    case 1: builder.AddCheese(); break;
                    case 2: builder.AddTomatoes(); break;
                    case 3: builder.AddOlives(); break;
                    case 4: builder.AddMeat(); break;
                    case 5: return builder.pizza;
                }
            }
        }

        static void GetResult(Pizza pizza)
        {
            Console.WriteLine(pizza.GetString());
        }
    }
}
