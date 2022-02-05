using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sea_Battle_2._0
{
    class One : Ships
    {
        Random rnd = new Random();
        public List<string> one = new List<string>();
        public override string[,] GetShip(string[,] field)
        {
        Metka4: int x = rnd.Next(0, 10);
            int y = rnd.Next(0, 10);
            if (field[x, y] == "1" || Neighbor(x, y, field) != 0)
            {
                goto Metka4;
            }
            field[x, y] = "1";
            one.Add(field[x, y]);
            return field;
        }
    }
}
