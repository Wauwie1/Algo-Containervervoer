using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_containervervoer
{
    class Ship
    {
        private int maxWeight { get; set; }
        private int leftWeight { get; set; }
        private int rightWeight { get; set; }

        private List<Container> NotPlacedContainers;
    }
}
