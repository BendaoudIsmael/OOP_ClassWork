using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Que1
{
    class Zone
    {
        int zoneID;
        double zoneArea;

        List<Animal> animals = new List<Animal>();

        public Zone(int zoneID, double zoneArea)
        {
            this.zoneID = zoneID;
            this.zoneArea = zoneArea;
        }
        public void addAnimal(Animal animal)
        {
            //Aggregation relationship since the instance lifetime for the animals
            // is not dependant on the Zone instance
            animals.Add(animal);
        }
    }
}
