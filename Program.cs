using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///
            /// Установить название окна консоли
            ///
            Console.Title = "Тема №5 Компьютерный практикум №1 Щуровская Александра";
            ///
            /// Установить размер окна консоли 60 х 25.
            ///
            Console.WindowWidth = 60;
            Console.WindowHeight = 25;
            ///
            /// инициализация для невидимого курсора
            ///
            Console.CursorVisible = false;
            bool saveCursorVisibile = Console.CursorVisible;
            ///
            /// Изменить цвет фона и символов.
            ///
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            ///
            /// Запросить через консоль имя человека, а затем поздороваться с этим человеком.
            ///
            Console.Write("Введите Имя:\t");
            string x = Console.ReadLine();
            Console.WriteLine("Привет "+x);
            

            Console.ReadKey();
        }
    }
}
