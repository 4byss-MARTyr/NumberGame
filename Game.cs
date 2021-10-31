using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Game
    {
        class Program
        {
            /*static void Main(string[] args)
            {
                Console.WriteLine("Ваша задача угадать число от 1 до 100.");
                Game();
            */
        }

            static void GameInit(int wins = 0)
            {
                Console.WriteLine("Начало игры.");
                int tries = 5;
                Random rndObject = new Random();
                int SoughteredNumber = rndObject.Next(1, 100);
                Console.WriteLine(SoughteredNumber);
                while (tries != 0)
                {
                    Console.WriteLine("Ваш вариант: ");
                    string input = Console.ReadLine();
                    //int variant = int.Parse(input);
                    int variant = 0;
                    var parseResult = int.TryParse(input, out variant);
                    if (!parseResult)
                    {
                        Console.WriteLine("Ваш ввод не является числом. Попробуйте ещё раз.");
                        continue;
                    }
                    if (SoughteredNumber > variant)
                    {
                        tries--;
                        Console.WriteLine($"Ваше число меньше заданного. У вас осталось {tries} попыток.");

                        continue;
                    }
                    if (SoughteredNumber < variant)
                    {
                        tries--;
                        Console.WriteLine($"Ваше число больше заданного. У вас осталось {tries} попыток.");

                        continue;
                    }

                    if (SoughteredNumber == variant)
                    {
                        tries = 5;
                        wins++;
                        Console.WriteLine($"Вы угадали.");

                        SoughteredNumber = rndObject.Next(1, 100);
                        Console.WriteLine(SoughteredNumber);
                    }

                    if (tries == 0)
                    {

                        Console.WriteLine("У вас кончились попытки. Попробуйте снова.");
                        continue;
                    }

                    if (wins == 3)
                    {
                        Console.WriteLine("Вы победили. Игра окончена.");
                        break;
                    }
                }
            }
    }
}