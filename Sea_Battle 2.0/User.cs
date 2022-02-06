using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sea_Battle_2._0
{
    class User : Player
    {
        int first_x;
        int first_y;
        public override void Attack(string[,] attackingfield, out int counthits)
        {
            counthits = 0;
            int x;
            int y;

            Console.WriteLine("Введите поле, по которому хотите нанести удар: ");
            Translator(out x, out y);

            if (attackingfield[x, y] == "1")
            {   
                attackingfield[x, y] = "x";
                counthits += 1;
                

                if (Neighbor(x, y, attackingfield) == 0 && Neighbor(first_x, first_y, attackingfield) == 0)      // огорождает убитый корабль 
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
                    for (int j = first_y - 1; j <= first_y + 1; j++)
                        for (int i = first_x - 1; i <= first_x + 1; i++)
                        {
                            if (i == first_x && j == first_y)
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
            }
        }


            private void Translator(out int x, out int y)
        {
            x = -1;
            string input;
            char letter;
            int number;
        Metka5: 
            input = Console.ReadLine();
            input = input.Trim();
            input = input.ToLower();
            if ((input[0] == 'а' || input[0] == 'б' || input[0] == 'в' || input[0] == 'г' || input[0] == 'д' || input[0] == 'е' || input[0] == 'ж' || input[0] == 'з' || input[0] == 'и' || input[0] == 'к') && input.Count() <= 3
&& (input[1] == '1' || input[1] == '2' || input[1] == '3' || input[1] == '4' || input[1] == '5' || input[1] == '6' || input[1] == '7' || input[1] == '8' || input[1] == '9'))
            {

            }
            else
            {
                Console.WriteLine("Вы неправильно ввели поле, попробуйте заново");
                goto Metka5;
            }

            letter = input[0];
            number = int.Parse(Convert.ToString(input[1]));
            if (input.Count() == 3 && input[2] == '0' && input[1] == '1')
                number = 10;
            else if (input.Count() == 3)
            {
                Console.WriteLine("Вы неправильно ввели поле, попробуйте заново");
                goto Metka5;
            }

            switch (letter)
            {
                case 'а':
                    {
                        x = 0;
                        break;
                    }
                case 'б':
                    {
                        x = 1;
                        break;
                    }
                case 'в':
                    {
                        x = 2;
                        break;
                    }
                case 'г':
                    {
                        x = 3;
                        break;
                    }
                case 'д':
                    {
                        x = 4;
                        break;
                    }
                case 'е':
                    {
                        x = 5;
                        break;
                    }
                case 'ж':
                    {
                        x = 6;
                        break;
                    }
                case 'з':
                    {
                        x =7;
                        break;
                    }
                case 'и':
                    {
                        x = 8;
                        break;
                    }
                case 'к':
                    {
                        x = 9;
                        break;
                    }
            }
            y = number -1;
        }


    }    
}
