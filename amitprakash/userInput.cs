using System;
namespace amitprakash
{
    /// <summary>
    /// This gonna take user input
    /// </summary>
    public class userInput
    {
        public void orderDeatils()
        {
            priceCalculation _priceCalculation = new priceCalculation();
            int aSKU, bSKU, cSKU, dSKU;
            int[] orders = new int[4];
            Console.WriteLine("----------------Please proveide your order details for respetive SKU(s)---------------------");
            Console.WriteLine("Order count for SKU: A");
            aSKU = int.Parse(Console.ReadLine());

            Console.WriteLine("Order count for SKU: B");
            bSKU = int.Parse(Console.ReadLine());

            Console.WriteLine("Order count for SKU: C");
            cSKU = int.Parse(Console.ReadLine());

            Console.WriteLine("Order count for SKU: D");
            dSKU = int.Parse(Console.ReadLine());
            orders[0] = aSKU;
            orders[1] = bSKU;
            orders[2] = cSKU;
            orders[3] = dSKU;

            _priceCalculation.orderSummery(orders);
            _priceCalculation.finalPriceCalculation(orders);

        }

    }
}
