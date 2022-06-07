using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП_2_ЛАБА
{
    abstract class InformationOnProduct
    {
        public string nameProduct;
        public string sizeProduct;
        public string costProduct;

        public string countryCreateProduct;

        public InformationOnProduct(string nameProduct, string sizeProduct, string costProduct, string countryCreateProduct)
        {

            this.nameProduct = nameProduct;
            this.sizeProduct = sizeProduct;
            this.costProduct = costProduct;
            this.countryCreateProduct = countryCreateProduct;

        }

        /*  public InformationOnProduct(string nameProduct , string costProduct )
           {

               this.nameProduct = nameProduct;

               this.costProduct = costProduct;


           }*/

        public abstract string InformationOnFruitOut();// комментарии для 4 лабы 
                                                       // {
        /*
             string information;
             information = "\n Название фрукта : " + nameProduct + "Размер продукта : " + sizeProduct + "Стоимость продукта : "
                 + costProduct + "Страна производства : " + countryCreateProduct ; 

             return information;
                                                     // без даты 
        */
        // } 



    }
}
