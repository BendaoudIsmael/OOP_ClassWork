using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet3
{
    class Publication
    {
        string title;
        string price;
        protected int copies; //Not asked in worksheet an example to access an inherited
        //field only from the derived classes (Book and Magazine))

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Pirce
        {
            get { return price; }
            set { price = value; }
        }

        public int Copies
        {
            get { return copies; }
            set { copies = value; }
        }

        public string SellCopy()
        {
            copies--; //copies = copies -1;

            return "There are " + copies + " amount of copies left";
        }
    }
}
