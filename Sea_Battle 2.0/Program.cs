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
            string[,] field = new string[10, 10];



            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(0); j++)
                    field[i, j] = ".";
            }
            Player player = new Player();
            player.GetField(field);

            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(0); j++)
                    Console.Write(field[i, j]);
                Console.WriteLine("");
            }
            

        }
    }
}
