using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo_containervervoer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_containervervoer.Tests
{
    [TestClass()]
    public class SorterTests
    {
        [TestMethod()]
        public void SorteerTest()
        {
            List<Container> unplacedContainers = new List<Container>();
            
            Container container1 = new Container(99, Container.ContainerType.Regular);
            Container container2 = new Container(80, Container.ContainerType.Cooled);
            Container container3 = new Container(11, Container.ContainerType.Precious);
            Container container4 = new Container(54, Container.ContainerType.Regular);
            Container container5 = new Container(90, Container.ContainerType.Cooled);
            Container container6 = new Container(120, Container.ContainerType.Regular);

            unplacedContainers.Add(container1);
            unplacedContainers.Add(container2);
            unplacedContainers.Add(container3);
            unplacedContainers.Add(container4);
            unplacedContainers.Add(container5);
            unplacedContainers.Add(container6);

            unplacedContainers = unplacedContainers.OrderByDescending(c => c.weight).ToList();
            Console.WriteLine(unplacedContainers[0].weight);
            Assert.AreEqual(120, unplacedContainers[0].weight);

        }
    }
}