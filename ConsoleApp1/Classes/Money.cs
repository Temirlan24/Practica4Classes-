using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public partial class Money
    {
        //Поля
        private int valueMoney; // номинал купюры
        private int quantityMoney; //колличество купюр 
                                   // Конструктор 

        public Money(int banknotes, int number)
        {
            this.valueMoney = banknotes;
            this.quantityMoney = number;
        }
        //Методы
        public int getValueMoney()
        {
            return valueMoney;
        }
        public void setValueMoney(int valueMoney)
        {
            this.valueMoney = valueMoney;
        }

        public int getQuantityMoney()
        {
            return quantityMoney;
        }
        public void setQuantityMoney(int quantityMoney)
        {
            this.quantityMoney = quantityMoney;
        }

        public void checkMoney(int totalCost)
        {
            int totalValue;
            totalValue = valueMoney * quantityMoney;
            if (totalValue >= totalCost)
            {
                Console.WriteLine("Денежные средства хватают на покупку");
            }
            else
            {
                Console.WriteLine("Денежных средств не хватает на покупку");
            }
        }
        public void defeineQuantity(int productCost)
        {
            int totalValue;
            totalValue = valueMoney * quantityMoney;
            int quantityOfProduct = totalValue / productCost;
            Console.WriteLine("За {0}тг можно купить {1} товара", productCost, quantityOfProduct);

        }

        public int totalMoney()
        {
            return valueMoney * quantityMoney;
        }
    }
}
