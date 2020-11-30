using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Que1
{
    class Zoo
    {
        string zooName;
        string location;
        bool zooAccredited;
        List<Zone> zones = new List<Zone>();
        List<ZooKeeper> zooKeepers = new List<ZooKeeper>();

        public string ZooName { get => zooName; set => zooName = value; }
        public string Location { get => location; set => location = value; }
        internal List<Zone> Zones { get => zones; set => zones = value; }
        internal List<ZooKeeper> ZooKeepers { get => zooKeepers; set => zooKeepers = value; }

        public void AddZone()
        {
            //compostition
            zones.Add(new Zone(zones, Count + 1, 80));
        }

        public void AddZookeeper(ZooKeeper zooKeeper)
        {
            //Aggregation
            zooKeepers.Add(zooKeeper);
        }

        // Associaition relationship since ZooInsepector is not part of the Zoo
        // Zoo is not made up of a ZooInspector but a Zoo uses the ZooInspector
        public void ZooInspection(ZooInspector zooInspector)
        {
            // zooAccredited is true if zooInsepector gives a good report
        }
    }
}
