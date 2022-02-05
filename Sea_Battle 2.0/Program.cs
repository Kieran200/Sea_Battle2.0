using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sea_Battle_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer comp = new Computer();
            User user = new User();
            string[,] compfield = comp.GetField();
            string[,] userfield = user.GetField();



            for (int i = 0; i < compfield.GetLength(0); i++)
            {
                for (int j = 0; j < compfield.GetLength(0); j++)
                    Console.Write(compfield[i, j]);
                Console.WriteLine("");
            }

            user.Attack(compfield);

            for (int i = 0; i < compfield.GetLength(0); i++)
            {
                for (int j = 0; j < compfield.GetLength(0); j++)
                    Console.Write(compfield[i, j]);
                Console.WriteLine("");
            }

        }
    }
}
