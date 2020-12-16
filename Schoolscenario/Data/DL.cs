using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    //the data layer is responsilbe to access the database and to query the database and manipluataing
    // data by adding, editing and deleting records. --> LINQ will be used for these tasks.
    public class DL
    {
        SchoolDatabaseEntities1 db = new SchoolDatabaseEntities1(); // connection to the database

        public void AddInitialData() //to be called once
        {
            /*
            Teacher teach1 = new Teacher(233999, "Andy Piscopo");
            Teacher teach2 = new Teacher(43389, "Kelly Zarb");
            

            //adding new objects / records to the teachers DBSet which will then be mapped to the
            // teahcer table in our database
            db.Teachers.Add(teach1); db.Teachers.Add(teach2);
            //after adding, editing and deleting records the db always always needs to be saved.
            db.SaveChanges();
            */

            Course c1 = new Course(1, "BSc in Software Development", 233999);
            Course c2 = new Course(2, "BSc in Networking", 34489);
            Student s1 = new Student(7888, "Tim", "Cauchi", 1);
            Student s2 = new Student(4221, "Michela", "Borg", 1);
            Student s3 = new Student(38899, "Luke", "Bezzina", 2);
            Student s4 = new Student(2118, "Elena", "Desira", 2);

            db.Courses.Add(c1); db.Courses.Add(c2);
            db.Students.Add(s1); db.Students.Add(s2); db.Students.Add(s3); db.Students(s4);
            db.SaveChanges();
        }
    }
}
