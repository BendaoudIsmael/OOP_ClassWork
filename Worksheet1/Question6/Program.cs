using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question6
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Person p2 = new Person();

            p1.ID = 293600;
            p1.Age = 20;
            p1.FavColour = "Black";
            p1.Name = "Any";
            p1.Locality = "Zabbar";

            p2.ID = 293700;
            p2.Age = 26;
            p2.FavColour = "Red";
            p2.Name = "Deandra";
            p2.Locality = "Xghajra";

            Person[] persons = new Person[2];
            persons[0] = p1;
            persons[1] = p2;

            /* foreach (type) item in collection
             * do { statements }
             */

            int[] marks = { 55, 89, 90, 100, 67 };

            Console.WriteLine("List of all marks:\n");
            foreach (int mark in marks)
            {
                Console.WriteLine(mark);
            }

            Console.WriteLine("\nList and details of all person:\n");
            foreach (Person p in persons)
            {
                Console.WriteLine("ID: " + p.GetID());
                Console.WriteLine("Name: " + p.GetName());
                Console.WriteLine("Age: " + p.GetAge());
                Console.WriteLine("Locality: " + p.GetLocality());
                Console.WriteLine("Favourite Colour: " + p.GetFavColour());
            }

            Console.ReadKey();

        }
    }
}
