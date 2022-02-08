using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sea_Battle_2._0
{
    class Computer : Player
    {
        int first_x;
        int first_y;
        int count = 0;
        int x;
        int y;
        int direction = -1;
        Random rnd = new Random();
        public override void Attack(string[,] attackingfield, out int counthits)
        {            
            counthits = 0;
            
            if (count == 0)
            {
            Metka6: x = rnd.Next(0, 10);
                y = rnd.Next(0, 10);
                if (attackingfield[x, y] == "o" || attackingfield[x, y] == "x")
                    goto Metka6;
                first_y = y;
                first_x = x;
            }
            else 
            {     
                    Second_Attack(out x, out y, x, y, first_x, first_y, attackingfield);       
            }



            if (attackingfield[x, y] == "1")
            {
                attackingfield[x, y] = "x";
                counthits += 1;
                count++;

                if (Neighbor(x, y, attackingfield) == 0 && Neighbor(first_x, first_y, attackingfield) == 0)
                {
                    Border_Of_Ship(x, y, attackingfield);
                    Border_Of_Ship(first_x, first_y, attackingfield);
                    count = 0;
                }

                if (counthits == 1 && Neighbor_x(x, y, attackingfield) == 0)
                {
                    first_x = x;
                    first_y = y;
                }
                if (Neighbor(x, y, attackingfield) == 0 && Neighbor(first_x, first_y, attackingfield) != 0)
                {
                    first_x = x;
                    first_y = y;
                }
            }
            else
            {
                attackingfield[x, y] = "o";
                counthits = 0;
            }

        }




        public void Second_Attack(out int x, out int y, int _x, int _y, int first_x, int first_y, string [,] attackingfield)
        {
            x = _x;
            y = _y;
        Metka7: if (direction == -1 || attackingfield[x,y] == "o")
            {
                x = first_x;
                y = first_y;
                direction = rnd.Next(0, 4);
            }
            switch(direction)
            {
                case 0:
                    {
                        x++;
                        if (x < 0 || y < 0 || x >= 10 || y >= 10 || attackingfield[x, y] == "o")                 
                        {
                            x--;
                            goto Metka7;
                            
                        }     
                        break;
                    }
                case 1:
                    {
                        x--;
                        if (x < 0 || y < 0 || x >= 10 || y >= 10 || attackingfield[x, y] == "o")
                        {
                            x++;
                            goto Metka7;
                        }
                        break;
                    }
                case 2:
                    {
                        y++;
                        if (x < 0 || y < 0 || x >= 10 || y >= 10 || attackingfield[x, y] == "o")
                        {
                            y--;
                            goto Metka7;
                        }
                        break;
                    }
                case 3:
                    {
                        y--;
                        if (x < 0 || y < 0 || x >= 10 || y >= 10 || attackingfield[x, y] == "o")
                        {
                            y++;
                            goto Metka7;
                        }
                        break;
                    }
            }
        }
    }
}
