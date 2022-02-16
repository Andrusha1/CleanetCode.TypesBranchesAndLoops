using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random(); //объявляем рандомную переменную
            int userNumber; //число пользователя
            int neededNum = rnd.Next(1, 100); //присваиваем рандомное число загадонному
            string userName; //имя пользователя
            bool isWin = false; //победил ли пользователь
            bool isIntNumber = false; //число ли ввел пользователь
            int countTry = 0; //счетчик попыток
            
            Console.WriteLine("Здравствуйте, как вас зовут?");
            userName = Console.ReadLine();
            Console.WriteLine($"{userName}, я загадал для вас число от 1 до 100, попробуйте угадать.");
            Console.WriteLine("Введите ваше число: ");

            while (isWin == false) //запуск цикла пока пользователь не угадает число
            {
                string userInput = Console.ReadLine();
                isIntNumber = int.TryParse(userInput, out userNumber); //Попытка перевести ввод пользователя в число
                if (isIntNumber == false) //проверка на ввод числа
                    Console.WriteLine("Вы ввели не число.");
                else if (userNumber < 1 || userNumber > 100) //проверка на выход за пределы
                    Console.WriteLine("Число не может быть меньше 1 и больше 100.");
                else if (userNumber == neededNum) //проверяем равно ли число пользователя загаданному
                {
                    Console.WriteLine($"Поздравляем, вы угадали нужное число с {countTry} попыток!");
                }
                else if (userNumber < neededNum) //число пользователя меньше
                {
                    Console.WriteLine($"Число {userNumber} меньше загаданного.");
                    countTry++;
                }
                else if (userNumber > neededNum) //число пользователя больше
                {
                    Console.WriteLine($"Число {userNumber} больше загаданного.");
                    countTry++;
                }
                else if (Console.ReadKey().Key == ConsoleKey.Escape) //выход из программы в момент угадывания числа
                {
                    Environment.Exit(0);
                }
                    
            }
        }
    }
}