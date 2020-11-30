using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Que1
{
    class ZooKeeper
    {
        int id;
        string name;
        string surname;
        string anmialSpecialty;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string AnmialSpecialty { get => anmialSpecialty; set => anmialSpecialty = value; }

        public ZooKeeper(int id, string name, string surname)
        {
            this.Id = id;
            this.Name = name;
            this.Surname = surname;
        }

        public void AddAnimal(Animal animal)
        {
            Animal.Add(animal);
        }
    }
}
