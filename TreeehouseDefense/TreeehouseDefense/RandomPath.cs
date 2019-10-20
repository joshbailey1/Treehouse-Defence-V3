using System;
using System.Collections.Generic;
using System.Text;

namespace TreeehouseDefense
{
    class RandomPath : Path
    {


        public RandomPath(Map map) : base(GenerateRandomPath(map))
        {

        }
        public static MapLocation[] GenerateRandomPath(Map map)
            {
            int X = 0;
            int Y = 0;
            int Counter = 0;
            //the Locations array stores the map location values i will use when i return the map location array
            //I use a seperate array so that it can be of any length up to 15
            int[,] Locations = new int[15, 2];
            Locations[Counter, 0] = X;
            Locations[Counter, 1] = Y;
            while (X < (map.Width) && Y < (map.Height))
            {
                Counter++;
                if (Random.NextDouble() < 0.5)
                {
                    X++;
                    Locations[Counter, 0] = X;
                    Locations[Counter, 1] = Y;
                }
                else
                {
                    Y++;
                    Locations[Counter, 0] = X;
                    Locations[Counter, 1] = Y;
                }
            }
            MapLocation[] RandomPath = new MapLocation[Counter];
            //here we only put Counter amount of Locations into the array of map locations that we return
            //otherwise we would be putting Locations that haven't been set explicitly (i.e. lots of (0,0)s)
            for (int i = 0; i < Counter; i++)
            {
                RandomPath[i] = new MapLocation(Locations[i,0],Locations[i,1], map);
            }
            return RandomPath;
            }
    }
}
