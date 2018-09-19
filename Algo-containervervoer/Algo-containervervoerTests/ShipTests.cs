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
    public class ShipTests
    {
        
        [TestMethod()]
        public void SetShipTest()
        {
            int shipWidth = 700;
            int shipLength = 900;
            int containerWidth = 70;
            int containerLength = 90;


            int columns = shipLength / containerLength;
            int rows = shipWidth / containerWidth;
            const int height = 30; // 120 / 4: Maxweight ontop of a container = 120. Min weight container = 4.

            Container[,,]PlacedContainers = new Container[columns, rows, height];

            Assert.AreEqual(10, PlacedContainers.GetLength(0));
            Assert.AreEqual(10, PlacedContainers.GetLength(1));
            Assert.AreEqual(30, PlacedContainers.GetLength(2));
        }

        [TestMethod()]
        public void SetShipTestIrr1()
        {
            double shipWidth = 700;
            int shipLength = 900;
            double containerWidth = 56;
            int containerLength = 90;


            int columns = shipLength / containerLength;
            int rows = Convert.ToInt32(Math.Ceiling(shipWidth / containerWidth));
            const int height = 30; // 120 / 4: Maxweight ontop of a container = 120. Min weight container = 4.

            Container[,,] PlacedContainers = new Container[columns, rows, height];

            Assert.AreEqual(13, PlacedContainers.GetLength(1));
        }

        [TestMethod()]
        public void SetShipTestIrr2()
        {
            double shipWidth = 872;
            double containerWidth = 56;

            double shipLength = 350;
            double containerLength = 90;


            int columns = Convert.ToInt32(Math.Ceiling(shipLength / containerLength));
            int rows = Convert.ToInt32(Math.Ceiling(shipWidth / containerWidth));
            const int height = 30; // 120 / 4: Maxweight ontop of a container = 120. Min weight container = 4.

            Container[,,] PlacedContainers = new Container[columns, rows, height];

            Assert.AreEqual(4, PlacedContainers.GetLength(0));
        }

        [TestMethod()]
        public void SetShipTestIrr3()
        {
            double shipWidth = 20;
            double containerWidth = 56;

            double shipLength = 30;
            double containerLength = 90;

            if (shipWidth < containerWidth || shipLength < containerLength)
            {
                Console.WriteLine("Error, ship cant be smaller than the containers. ");
                Assert.Inconclusive();
            }
            else
            {
                int columns = Convert.ToInt32(Math.Ceiling(shipLength / containerLength));
                int rows = Convert.ToInt32(Math.Ceiling(shipWidth / containerWidth));
                const int height = 30; // 120 / 4: Maxweight ontop of a container = 120. Min weight container = 4.

                Container[,,] PlacedContainers = new Container[columns, rows, height];

            }
        }
    }
}