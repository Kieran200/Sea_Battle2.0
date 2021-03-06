using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Sea_Battle_2._0
{
    class User : Player
    {
        int first_x;
        int first_y;

        public override string[,] GetField()
        {
            string[,] field = new string[10, 10];
            Console.WriteLine("Выберите способ установки поля: ");
            Console.WriteLine("Для установки рандомного поля нажмите \"р\"");
            Console.WriteLine("Для установки поля с файла нажмите \"ф\"");
            string input = Console.ReadLine();
            if (input == "р")
            {   
                for (int y = 0; y < 10; y++)
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
            }
            else if (input == "ф")
            {
                StreamReader sr = new StreamReader("Поле.txt");
                for (int y = 0; y < 10; y++)
                {
                    string stringsr = sr.ReadLine();
                    for (int x = 0; x < 10; x++)
                    {
                        field[y, x] = Convert.ToString(stringsr[x]);
                    }
                }
            }
            return field;
        }

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

                if (Neighbor(x, y, attackingfield) == 0 && Neighbor(first_x, first_y, attackingfield) == 0)      
                {
                    Border_Of_Ship(x, y, attackingfield);
                    Border_Of_Ship(first_x, first_y, attackingfield);
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
            if (input == "")
            {
                Console.WriteLine("Вы неправильно ввели поле, попробуйте заново");
                goto Metka5;
            }
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
            y = number - 1;
        }


    }    
}
