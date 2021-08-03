using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitCude_Kyle_Andrade.Classes
{

  

    public class OnlineStore : Interface.IOnlineStore
    {
        // class properties
        public String sProductType { get; set; }

        public int iInventory { get; set; }

        public int iAvaibleLaptops { get; set; }

        public int iAvailablePhones { get; set; }

        public int iAvailableTablets { get; set; }

        

        //interface metohds 
        public void AddProductsToInventory(ProductPurchaseOrder purchaseOrder)
        {
            //adding the number of items being purchases to stock
            iInventory += purchaseOrder.nrOfItemsBeingPurchased;
        }

        public void GetInventoryItemSummary(InventoryItemSummary itemsSummary)
        {
            string pType = itemsSummary.productType;

            pType.ToLower();
            int inventory = itemsSummary.itemsHeldInInventory; 

            switch (pType)
            {
                case "laptops":

                    inventory = iAvaibleLaptops;

                    break;

                case "phones":

                    inventory = iAvailablePhones;

                    break;

                case "tablets":

                    inventory = iAvailableTablets;

                    break;
            }

            
        }

        public int getInventorySummary(InventorySummary inventorySummary)
        {
            int inventory = inventorySummary.allItemsInInventory;

            return inventory;
        }

        public void SellProductsFromInventory(ProductsSellOrder itemSoldOrder)
        {
            //this method will take the type of product being sold, and the amount of items sold
            //then it will subract from stock accordingly only if stock is sufficient

            string pType = itemSoldOrder.ProductType;
            int amountSold = itemSoldOrder.nrOfItemsSold;

            pType.ToLower();

            switch (pType)
            {
                case "laptops":

                    if (amountSold < iAvaibleLaptops)
                    {
                        iAvaibleLaptops -= amountSold;
                    }
                    else
                    {
                        //display insufficient stock alert
                    }


                    break;

                case "phones":

                    if (amountSold < iAvailablePhones)
                    {
                        iAvailablePhones -= amountSold;
                    }
                    else
                    {
                        //display insufficient stock alert
                    }


                    break;

                case "tablets":

                    if (amountSold < iAvailableTablets)
                    {
                        iAvailableTablets -= amountSold;
                    }
                    else
                    {
                        //display insufficient stock alert
                    }


                    break;
            }


        }

        
    }
}
