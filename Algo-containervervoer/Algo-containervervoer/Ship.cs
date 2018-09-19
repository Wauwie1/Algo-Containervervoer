using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_containervervoer
{
    public class Ship
    {
        private int maxWeight { get; set; }
        private int leftWeight { get; set; }
        private int rightWeight { get; set; }

        private List<Container> NotPlacedContainers;
        private Container[,,] PlacedContainers;

        //Constructor ship
        public Ship(double shipWidth, double shipLength, double containerWidth, double containerLength)
        {
            SetShipSize(shipWidth, shipLength, containerWidth, containerLength);

        }

        private void SetShipSize(double shipWidth, double shipLength, double containerWidth, double containerLength)
        {
            // Check wether the ship is bigger than the containers
            try
            {
                if (shipWidth < containerWidth || shipLength < containerLength)
                {
                    throw new SystemException("Ship can't be smaller than a container.");

                }

                //Calculate how many rows and columns the ship will have
                int columns = Convert.ToInt32(Math.Ceiling(shipLength / containerLength));
                int rows = Convert.ToInt32(Math.Ceiling(shipWidth / containerWidth));
                const int height = 30; // 120 / 4: Maxweight ontop of a container = 120. Min weight container = 4.

                PlacedContainers = new Container[columns, rows, height];
            }
            catch (Exception)
            {
                Console.WriteLine("Error, ship cant be smaller than the containers. ");
            }
        }
    }
}
