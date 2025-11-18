using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7112025
{
    internal class Program
    {
        static string Player1()
        {
            Console.WriteLine("Игра камень - ножницы - бумага. \n" +
                "Первый игрок введите выбор: камень, ножницы, бумага.");
            string choise = Console.ReadLine().Trim().ToLower();
            Console.Clear();
            return choise;
        }
        static string Player2()
        {
            Console.WriteLine("Игра камень - ножницы - бумага. \n" +
                "Второй игрок введите выбор: камень, ножницы, бумага.");
            string choise = Console.ReadLine().Trim().ToLower();
            Console.Clear();
            return choise;
        }
        static void Game()
        {
            while (true)
            {
                string player1Choise = Player1();
                string player2Choise = Player2();
                Console.WriteLine($"Игрок1 = {player1Choise}, Игрок2 = {player2Choise}");
                if (player1Choise == "ножницы" && player2Choise == "бумага")
                {
                    Console.WriteLine("Первый выиграл второго");
                }
                else if (player1Choise == "бумага" && player2Choise == "камень")
                {
                    Console.WriteLine("Первый выиграл второго");
                }
                else if (player1Choise == "камень" && player2Choise == "ножницы")
                {
                    Console.WriteLine("Первый выиграл второго");
                }
                else if (player1Choise == "ножницы" && player2Choise == "камень")
                {
                    Console.WriteLine("Второй выиграл первого");
                }
                else if (player1Choise == "бумага" && player2Choise == "ножницы")
                {
                    Console.WriteLine("Второй выиграл первого");
                }
                else if (player1Choise == "камень" && player2Choise == "бумага")
                {
                    Console.WriteLine("Второй выиграл первого");
                }
                else
                {
                    Console.WriteLine("Ничья!");
                }
                Console.WriteLine(" ");
            }
        }
        static void Main(string[] args)
        {
            Game();
        } 
    }
}
