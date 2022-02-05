using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sea_Battle_2._0
{
    abstract class Ships
    {
        public virtual String [,] GetShip(string [,] field)
        {
            return field;
        }
        public int Neighbor(int xCentral, int yCentral, string [,] field)
        {
            int neighbors = 0;
            for (int y = yCentral-1; y <= yCentral +1; y++)
                for (int x = xCentral-1; x <= xCentral+1; x++)
                {
                    if (x == xCentral && y == yCentral)
                    {
                        continue;
                    }
                    else if (x < 0 || y < 0 || x >= field.GetLength(0) || y >= field.GetLength(1))
                    {
                        continue;
                    }
                    else if (field[x,y] == "1")
                    {
                        neighbors += 1;
                    }
                }
            return neighbors;
        }

    }
}
