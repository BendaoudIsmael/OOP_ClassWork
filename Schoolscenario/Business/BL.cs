using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    /* Business layer is responsible for the data validations and logical executions. There should be no input and output
        * and also no direct access to the database (and no queries).
        * The Business layer will be accessed by the presentation layer and the BL should be able to access the data layer.
        */
    public class BL
    {
        static DL dl = new DL();

        public void AddInitialData()
        {
            dl.AddInitialData();
        }
    }
}
