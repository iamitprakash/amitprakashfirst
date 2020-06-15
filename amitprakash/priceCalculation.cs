using System;
namespace amitprakash
{
    /// <summary>
    /// Send order count for Promo Application and Final cost calculation
    /// </summary>
    public class priceCalculation
    {
        public void orderSummery(int[] ordersummery)
        {
            Console.WriteLine("===================Order Details=======================");
            Console.WriteLine(" SKU(s)\tquantity\tActualPrice/Unit");
            Console.Write("A");
            Console.Write("\t" + ordersummery[0]);
            Console.Write("\t\t50");
            Console.Write("\nB");
            Console.Write("\t" + ordersummery[1]);
            Console.Write("\t\t30");
            Console.Write("\nC");
            Console.Write("\t" + ordersummery[2]);
            Console.Write("\t\t20");
            Console.Write("\nD");
            Console.Write("\t" + ordersummery[3]);
            Console.Write("\t\t15");


        }
        public void finalPriceCalculation(int[] orderCount)
        {
            promotionDetails _promotionDetails = new promotionDetails();
            int actualCost = orderCount[0] * 50 + orderCount[1] * 30 + orderCount[2] * 20 + orderCount[3] * 15;
            int finalPrice = _promotionDetails.promoType1(orderCount[0]) +
             _promotionDetails.promoType2(orderCount[1]) +
             _promotionDetails.promoType3(orderCount[2], orderCount[3]);
           
            Console.WriteLine("\n-------------------------------Actual Cost=" + actualCost.ToString());
            Console.WriteLine("-------------------------------Promotional Discunt" + (actualCost - finalPrice).ToString());
            Console.WriteLine("-------------------------------Total" + finalPrice.ToString());
            Console.WriteLine("================================================");
            Console.WriteLine(finalPrice.ToString());
        }
    }
}
