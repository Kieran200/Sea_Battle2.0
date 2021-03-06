using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Sea_Battle_2._0
{
    class Player
    {
        
        public virtual string [,] GetField()
        {
            string[,] field = new string [10,10];
            for (int y = 0; y<10; y++)
                for (int x = 0; x < 10; x++)
                {
                    field[x, y] = ".";
                }
            Four four = new Four();
            four.GetShip(field);
            Three three = new Three();
            three.GetShip(field);
            three.GetShip(field);
            Two two = new Two();
            two.GetShip(field);
            two.GetShip(field);
            two.GetShip(field);
            One one = new One();
            one.GetShip(field);
            one.GetShip(field);
            one.GetShip(field);
            one.GetShip(field);
            return field;
        }
        public virtual void Attack(string [,] attakingfield, out int counthits)
        {
            counthits = 0;
        }

        public int Neighbor(int xCentral, int yCentral, string[,] field)
        {
            int neighbors = 0;
            for (int x = xCentral - 1; x <= xCentral + 1; x++)
                for (int y = yCentral - 1; y <= yCentral + 1; y++)   
                {
                    if (x == xCentral && y == yCentral)
                    {
                        continue;
                    }
                    else if (x < 0 || y < 0 || x >= field.GetLength(0) || y >= field.GetLength(1))
                    {
                        continue;
                    }
                    else if (field[x, y] == "1")
                    {
                        neighbors += 1;
                    }
                }
            return neighbors;
        }
        public int Neighbor_x(int xCentral, int yCentral, string[,] field)
        {
            int neighbors = 0;
            for (int x = xCentral - 1; x <= xCentral + 1; x++)
                for (int y = yCentral - 1; y <= yCentral + 1; y++)
                {
                    if (x == xCentral && y == yCentral)
                    {
                        continue;
                    }
                    else if (x < 0 || y < 0 || x >= field.GetLength(0) || y >= field.GetLength(1))
                    {
                        continue;
                    }
                    else if (field[x, y] == "x")
                    {
                        neighbors += 1;
                    }
                }
            return neighbors;
        }
        public int Neighbor_o(int xCentral, int yCentral, string[,] field)
        {
            int neighbors = 0;
            for (int x = xCentral - 1; x <= xCentral + 1; x++)
                for (int y = yCentral - 1; y <= yCentral + 1; y++)
                {
                    if (x == xCentral && y == yCentral)
                    {
                        continue;
                    }
                    else if (x < 0 || y < 0 || x >= field.GetLength(0) || y >= field.GetLength(1))
                    {
                        continue;
                    }
                    else if (field[x, y] == "o")
                    {
                        neighbors += 1;
                    }
                }
            return neighbors;
        }

        public void Border_Of_Ship(int x, int y, string[,] attackingfield)     //огорождает убийтый корабль
        {
            
                for (int j = y - 1; j <= y + 1; j++)
                    for (int i = x - 1; i <= x + 1; i++)
                    {
                        if (i == x && j == y)
                        {
                            continue;
                        }
                        else if (i < 0 || j < 0 || i >= 10 || j >= 10 || attackingfield[i, j] == "x")
                        {
                            continue;
                        }
                        else
                        {
                            attackingfield[i, j] = "o";
                        }
                   }
            
        }
    }
}
