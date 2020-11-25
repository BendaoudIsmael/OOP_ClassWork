using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalougeProject
{
        class Catalogue
        {
            List<ItemForSale> itemForSale = new List<ItemForSale>();
            List<Page> pages = new List<Page>();

            public List<ItemForSale> ItemForSale { get => itemForSale; set => itemForSale = value; }
            public List<Page> Pages { get => Pages; set => Pages = value; }

        public void AddItem(ItemForSale item)
        {
            ItemForSale.Add(item);
            if (ItemForSale.Count % 2 != 0)
            {
                AddPage();
            }
        }

        public void AddPage()
        {
            Page newPage = new Page(Pages.Count + 1);
            Pages.Add(newPage);
            //pages.Add(new Page(pages.Count + 1));
        }
    }
}
