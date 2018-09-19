using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_containervervoer
{
    class Container
    {
        public int weight { get; private set; }
        public ContainerType type { get; private set; }

        public Container(int weight, ContainerType type)
        {
            this.weight = weight;
            this.type = type;
        }
        public enum ContainerType
        {
            Regular,
            Cooled,
            Precious
        }
    }
}
