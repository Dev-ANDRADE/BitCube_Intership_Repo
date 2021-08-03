using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BitCude_Kyle_Andrade.Classes;

namespace BitCude_Kyle_Andrade.Interface
{
    public interface IOnlineStore
    {

        //NOTE: the specification oof the interface was too vague for me to build it exaclty as desired so
        //i modified the interface the way i saw fit, i trust that it will work exaclty like the desired interface 
        void AddProductsToInventory(ProductPurchaseOrder purchaseOrder);

       

        void SellProductsFromInventory(ProductsSellOrder itemSoldOrder);

        void GetInventoryItemSummary(InventoryItemSummary itemsSummary);

        int getInventorySummary(InventorySummary inventorySummary);

        
    }
}
