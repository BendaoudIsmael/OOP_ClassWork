using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelidaePeoject
{
    abstract class Felidae
    {
        bool male;

        public bool Male
        {
            get { return male; }
            set { male = value; }
        }

        public Felidae() : this(true)
        {
        }

        public Felidae(bool male)
        {
            this.male = male;
        }

        protected string Hide()
        {
            return "find a big bush and hide";
        }

        protected string Run()
        {
            return "Run as fast as you can";
        }

        public abstract string CatchPrey();
    }
}
