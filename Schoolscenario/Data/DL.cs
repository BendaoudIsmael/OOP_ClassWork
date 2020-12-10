using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DL
    {
        SchoolDatabaseEntities1 db = new SchoolDatabaseEntities1(); // connection to the database

        public void AddInitialData() //to be called once
        {
            Teacher teach1 = new Teacher(233999, "Andy Piscopo");
            Teacher teach2 = new Teacher(43389, "Kelly Zarb");
        }
    }
}
