using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Game
{
    internal class Gamers
    {
        static int count = 1;
        static private int myRandom()
        {
            Random random = new Random();
            var currentTime = DateTime.Now.Millisecond;
            int Number = currentTime;
            Number *= Number;
            int _myRandom = 1 + random.Next(Number) % 100;
            return _myRandom;
        }
        static private int myRandom2()
        {
            Random random = new Random();
            var currentTime = DateTime.Now.Second;
            int Number = currentTime;
            Number *= Number;
            int _myRandom = 1 + random.Next(Number) % 100;
            return _myRandom;
        }
        public Gamers(string _name, int _honor)
        {
            name = _name;
            coin = myRandom();
            honor = _honor;
            luck = myRandom2();

        }
        private string name { get; set; }
        private int coin { get; set; }
        private int honor { get; set; }
        private int luck { get; set; }
        private int sum_coin { get; set; }
        private int sum_honor { get; set; }
        private int multiply_luck { get; set; }

        public List<Gamers> team1 = new List<Gamers>();
        public List<Gamers> team2 = new List<Gamers>();
        public override bool Equals(object obj)// сравнение списков с элементами классами
        {
            var objDB = obj as Gamers;
            if (objDB == null) return false;

            return sum_coin > objDB.sum_coin && multiply_luck > objDB.multiply_luck && sum_honor == objDB.sum_honor;
        }
        public override int GetHashCode() { return 0; }

        public static Gamers inputInfoGamers() // объекты класса путем ввода пользователя
        {

            Console.WriteLine($"Введите имя игрока {count}");
            string _name = Console.ReadLine();
            Console.WriteLine($"Введите доблесть игрока {count}");
            count++;
            int _honor = int.Parse(Console.ReadLine());
            return new Gamers(_name, _honor);
        }
        public void PrintGamer(Gamers player) // вывести на экран игрока и ее детали
        {
            Console.WriteLine($"Имя игрока: {player.name}, монеты: {player.coin}, доблесть: {player.honor}, везение: {player.luck}");
        }
        public void AddGamersTeam1(Gamers player1, Gamers player2, Gamers player3, Gamers player4, List<Gamers> team1) // добавить игрока в команду 1
        {
            team1.Add(player1);
            team1.Add(player2);
            team1.Add(player3);
            team1.Add(player4);
            Console.WriteLine($"=================\nИгроки добавлены в команду 1\n");
            sum_coin = player1.coin + player2.coin + player3.coin + player4.coin;
            Console.WriteLine($"Сумма монет в команде 1 составила: {sum_coin}\n");
            sum_honor = player1.honor + player2.honor + player3.honor + player4.honor;
            Console.WriteLine($"Сумма доблести в команде 1 составила: {sum_honor}\n");
            multiply_luck = player1.luck * player2.luck * player3.luck * player4.luck;
            Console.WriteLine($"Произведение везения в команде 1 составило: {multiply_luck}\n");
        }
        public void AddGamersTeam2(Gamers player1, Gamers player2, Gamers player3, Gamers player4, List<Gamers> team2) // добавить игрока в команду 2
        {
            team2.Add(player1);
            team2.Add(player2);
            team2.Add(player3);
            team2.Add(player4);
            Console.WriteLine($"=================\nИгроки добавлены в команду 2\n");
            sum_coin = player1.coin + player2.coin + player3.coin + player4.coin;
            Console.WriteLine($"Сумма монет в команде 2 составила : {sum_coin}\n");
            sum_honor = player1.honor + player2.honor + player3.honor + player4.honor;
            Console.WriteLine($"Сумма доблести в команде 2 составила : {sum_honor}\n");
            multiply_luck = player1.luck * player2.luck * player3.luck * player4.luck;
            Console.WriteLine($"Произведение везения в команде 2 составила : {multiply_luck}\n");
        }

        public void PrintTeam1(List<Gamers> team1) //выводит список игроков в команде 1
        {

            Console.WriteLine($"Список команды 1: ");
            foreach (Gamers element in team1)
            {
                Console.WriteLine(element.name);
            }
        }
        public void PrintTeam2(List<Gamers> team2) // выводит список игроков в команде 2
        {
            Console.WriteLine($"Список команды 2: ");
            foreach (Gamers element in team2)
            {
                Console.WriteLine(element.name);
            }
        }
        public static bool operator <(Gamers player1, Gamers player2)
        {
            return player1.coin * player1.honor < player2.coin * player2.honor;
        }
        public static bool operator >(Gamers player1, Gamers player2)
        {
            return player1.coin * player1.honor > player2.coin * player2.honor;
        }

        public void Winner(Gamers player1, Gamers player2) // определение победителя
        {
            if (player1.coin == player2.coin && player1.honor < player2.honor)
            {
                Console.WriteLine("Игрок {1} успешней игрока {0}", player1.name, player2.name);
            }
            else
            {
                if (player1.honor == player2.honor && player1.coin < player2.coin)
                {
                    Console.WriteLine("Игрок {1} успешней игрока {0}", player1.name, player2.name);
                }
                else
                {
                    if (player1.honor > player2.honor && player1.coin < player2.coin)
                    {
                        Console.WriteLine("Игрок {0} успешней игрока {1}", player1.name, player2.name);
                    }
                }
            }
        }
        public void TeamWinner(List<Gamers> team1, List<Gamers> team2) // определение победителя среди команд
        {
            var isNoEquals = team1.Any(x => !team2.Contains(x));

            if (!isNoEquals) Console.WriteLine("\n-----Команда 1 победила-----");
            else Console.WriteLine("\n-----Команда 2 победила-----");

        }
    }
}
