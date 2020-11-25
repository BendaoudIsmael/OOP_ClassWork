using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalougeProject
{
    class Shop
    {
        List<ItemForSale> itemToSell = new List<ItemForSale>();

        public List<ItemForSale> ItemToSell { get => itemToSell; set => itemToSell = value; }

        public void AddItemToSell(ItemForSale item)
        {
            itemToSell.Add(item);
        }

        public string ListOfItemsToSell()
        {
            string returnText = "";

            foreach (ItemForSale item in itemToSell)
            {
                returnText += "\n" + item.Name;
            }

            return returnText;
        }
    }
}
