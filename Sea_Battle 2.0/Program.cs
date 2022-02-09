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
            int counthits = 1;
            Computer comp = new Computer();
            User user = new User();
            string[,] compfield = comp.GetField();
            string[,] userfield = user.GetField();
            string[,] invisiblefield = new string[10, 10];

            DrawField(userfield, invisiblefield);
            while (true)
            {
                int compcount_x = 0;
                int usercount_x = 0;
                counthits = 1;
                while (counthits != 0)
                {      
                    user.Attack(compfield, out counthits);
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (compfield[i, j] != "1")
                                invisiblefield[i, j] = compfield[i, j];
                            else invisiblefield[i, j] = ".";
                        }
                    }
                    DrawField(userfield, invisiblefield);
                }
                Count_X(compfield, out compcount_x);
                if (compcount_x == 20)
                {
                    Console.WriteLine("Вы победили!!!!!");
                    break;
                }
                Console.WriteLine("Нажмите Enter для атаки компьютера");
                Console.ReadKey();
                counthits = 1;
                while (counthits != 0)
                {
                    comp.Attack(userfield, out counthits);
                    DrawField(userfield, invisiblefield);
                    Console.ReadKey();
                    Count_X(userfield, out usercount_x);
                    if (usercount_x == 20)
                    {
                        Console.WriteLine("Увы, вы проиграли :(");
                        break;
                    }
                }
            }

            void Count_X(string[,] field, out int count_x)
            {
                count_x = 0;
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (field[i, j] == "x")
                            count_x++;
                    }                   
                }
            }

            void DrawField(string[,] field1, string[,] field2)        //метод вырисовки поля
            {
                Console.Clear();
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (field1[i, j] == "x")
                            Console.ForegroundColor = ConsoleColor.Red;
                        if (field1[i, j] == "o")
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.Write(field1[i, j]);
                        Console.ResetColor();
                    }
                    Console.WriteLine("");
                }
                Console.WriteLine("/");
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (field2[i, j] == "x")
                            Console.ForegroundColor = ConsoleColor.Red;
                        if (field2[i, j] == "o")
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.Write(field2[i, j]);
                        Console.ResetColor();
                    }
                    Console.WriteLine("");
                }               
            }

        }
    }
}
