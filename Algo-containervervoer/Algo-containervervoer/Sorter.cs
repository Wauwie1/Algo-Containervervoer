using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_containervervoer
{
    public class Sorter
    {
        public List<Container> unplacedContainers { get; private set; }

        public Sorter(List<Container> containersToBePlaced)
        {
            unplacedContainers = containersToBePlaced;
            SortByWeight();
        }

        private void SortByWeight()
        {

              unplacedContainers = unplacedContainers.OrderBy(c => c.weight).ToList();
            
        }

    }
}
