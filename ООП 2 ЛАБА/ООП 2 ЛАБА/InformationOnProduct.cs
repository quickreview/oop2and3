using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП_2_ЛАБА
{

    class InformationOnProduct
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

        public InformationOnProduct(string nameProduct, string costProduct)
        {

            this.nameProduct = nameProduct;

            this.costProduct = costProduct;


        }

        public virtual string InformationOnFruitOut()
        {
            string information;
            information = Environment.NewLine + "Название фрукта : " + nameProduct +
                " Цена за 1кг : " + costProduct +
              " Размер партии : " + sizeProduct + " Страна производства : " + countryCreateProduct +
              Environment.NewLine;



            return information;
        }



    }
}
