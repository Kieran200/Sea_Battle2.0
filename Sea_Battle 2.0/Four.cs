using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sea_Battle_2._0
{
    class Four: Ships
    {
        Random rnd = new Random();
        public List<string> four = new List<string>();
        public override string[,] GetShip (string [,] field)
        {
            int x = rnd.Next(0, 10);
            int y = rnd.Next(0, 10);
            field[x, y] = "1";
            four.Add(field[x, y]);
        Metka1: int direction = rnd.Next(0, 4);
      
                switch (direction)
                {
                    case 0:
                        if (x + 3 < 10)
                        {
                            for (int i = 0; i < 3; i++)
                            {
                                x++;
                                field[x, y] = "1";
                                four.Add(field[x, y]);
                            }
                        }
                        else goto Metka1;
                        break;
                    case 1:
                        if (x - 3 >= 0)
                        {
                             for (int i = 0; i < 3; i++)
                             {
                                 x--;
                                 field[x, y] = "1";
                                 four.Add(field[x, y]);
                             }
                        }
                        else goto Metka1;
                        break;
                    case 2:
                        if (y + 3 < 10)
                        {
                            for (int i = 0; i < 3; i++)
                            {
                                y++;
                                field[x, y] = "1";
                                four.Add(field[x, y]);
                            }
                        }
                        else goto Metka1;
                        break;
                    case 3:
                        if (y - 3 >= 0)
                        {
                            for (int i = 0; i < 3; i++)
                            {
                                y--;
                                field[x, y] = "1";
                                four.Add(field[x, y]);
                            }
                        }
                        else goto Metka1;
                        break;
                }
            
            return field;
        }
    }
}
