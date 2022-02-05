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
        public void GetField(string [,] field)
        {
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
        }
        public virtual void Attack(string [,] attakingfield)
        {

        }

    }
}
