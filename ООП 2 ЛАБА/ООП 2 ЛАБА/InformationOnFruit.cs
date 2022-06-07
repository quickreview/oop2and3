using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП_2_ЛАБА
{
    class InformationOnFruit
    {
        string cost_per_kilogram;
        string name_fruit;
        DateTime dateTime = new DateTime() ; 
    
        




        public string InformationOnFruitOut (string name_fruit, DateTime dateTimeint, string cost_per_kilogram)
        {
            
            string information;
            information = "\n Название фрукта : " + name_fruit + " Дата завоза : " + dateTimeint.ToString() + " Цена за 1кг : " + cost_per_kilogram;
            
            return information;

        }
    }
}
