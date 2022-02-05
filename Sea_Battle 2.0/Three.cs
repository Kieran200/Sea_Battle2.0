using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sea_Battle_2._0
{
    class Three : Ships
    {
        Random rnd = new Random();
        public List<string> three = new List<string>();
        public override string[,] GetShip(string[,] field)
        {
        Metka2: int x = rnd.Next(0, 10);
            int y = rnd.Next(0, 10);
            if (field[x, y] == "1" || Neighbor(x, y, field) != 0)
            {
                goto Metka2;
            }
            field[x, y] = "1";
            three.Add(field[x, y]);
            int direction = rnd.Next(0, 4);


            switch (direction)
            {
                case 0:
                    {
                        if ((x + 2 >= 10) || Neighbor(x + 1, y, field) != 1 || Neighbor(x + 2, y, field) != 0)
                        {
                            field[x, y] = ".";
                            goto Metka2;
                        }
                        else
                        {
                            x++;
                            field[x, y] = "1";
                            three.Add(field[x, y]);
                            x++;
                            field[x, y] = "1";
                            three.Add(field[x, y]);
                        }
                        break;

                    }
                case 1:
                    {
                        if ((x - 2 < 0) || Neighbor(x - 1, y, field) != 1 || Neighbor(x - 2, y, field) != 0)
                        {
                            field[x, y] = ".";
                            goto Metka2;
                        }
                        else
                        {
                            x--;
                            field[x, y] = "1";
                            three.Add(field[x, y]);
                            x--;
                            field[x, y] = "1";
                            three.Add(field[x, y]);
                        }
                        break;
                    }
                case 2:
                    {

                        if ((y + 2 >= 10) || Neighbor(x, y + 1, field) != 1 || Neighbor(x, y + 2, field) != 0)
                        {
                            field[x, y] = ".";
                            goto Metka2;
                        }
                        else
                        {
                            y++;
                            field[x, y] = "1";
                            three.Add(field[x, y]);
                            y++;
                            field[x, y] = "1";
                            three.Add(field[x, y]);
                        }
                        break;
                    }
                case 3:
                    {

                        if ((y - 2 < 0) || Neighbor(x, y - 1, field) != 1 || Neighbor(x, y - 2, field) != 0)
                        {
                            field[x, y] = ".";
                            goto Metka2;
                        }
                        else
                        {
                            y--;
                            field[x, y] = "1";
                            three.Add(field[x, y]);
                            y--;
                            field[x, y] = "1";
                            three.Add(field[x, y]);
                        }
                        break;
                    }

            }


            return field;
        }
    }
}
