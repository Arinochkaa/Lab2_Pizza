using ConsoleApp2.Новая_папка;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Pizza
    {
        private List<IIngredients> ingredients = new List<IIngredients>();
        //  public StringBuilder sb = new StringBuilder();
        /// <summary>
        /// добавление значения в лист(ингредиенты)
        /// </summary>
        public void Add(IIngredients ingredient) 
        {
            ingredients.Add(ingredient);
        }

        public string GetString() 
        {
            string str= "";
            for (int i = 0; i < ingredients.Count; i++) 
            {
                str = str + ingredients[i].Name + " ";
              
            }

            return str;
        }
    }
}
