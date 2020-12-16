using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject
{
    /* Presentation layer is only resonsilbe with the user communication. Therefore, there should be
        * no access to the database and also no access to the data layer.
        * In this class we should find all the input and output (writelines & readlines) which are found
        * in the project.
        * The presentation layer shouldn't have any data validations the only accepted chekcs are checks related to methods
        * returns e.g. to check if there was an error so that the approriate error handling technique can be
        * executed.
        * The Presentation layer should access the business layer to pass and retrieve necessary data in the 
        * most secure way
     */
    class PL
    {
        static BL bl = new BL();
        static void Main(string[] args)
        {
          //  bl.AddInitialData();
        }
    }
}
