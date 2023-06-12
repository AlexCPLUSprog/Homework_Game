using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Game
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List<Gamers> comand1 = new List<Gamers>();
            List<Gamers> comand2 = new List<Gamers>();
            //создали экземпляры класса
            Gamers gamer01 = Gamers.inputInfoGamers();
            gamer01.PrintGamer(gamer01); //вывели на экран какие параметры у игрока
            Gamers gamer02 = Gamers.inputInfoGamers();
            gamer02.PrintGamer(gamer02);
            Gamers gamer03 = Gamers.inputInfoGamers();
            gamer03.PrintGamer(gamer03);
            Gamers gamer04 = Gamers.inputInfoGamers();
            gamer04.PrintGamer(gamer04);
            Gamers gamer05 = Gamers.inputInfoGamers();
            gamer05.PrintGamer(gamer05);
            Gamers gamer06 = Gamers.inputInfoGamers();
            gamer06.PrintGamer(gamer06);
            Gamers gamer07 = Gamers.inputInfoGamers();
            gamer07.PrintGamer(gamer07);
            Gamers gamer08 = Gamers.inputInfoGamers();
            gamer08.PrintGamer(gamer08);
            //распределили игроков на команды
            gamer01.AddGamersTeam1(gamer01, gamer02, gamer03, gamer04, comand1);
            gamer01.PrintTeam1(comand1); // состав 1 команды
            gamer05.AddGamersTeam2(gamer05, gamer06, gamer07, gamer08, comand2);
            gamer05.PrintTeam2(comand2); // состав 2 команды
            gamer01.Winner(gamer01, gamer02); // победитель из двух команд
            gamer01.TeamWinner(comand1, comand2);

        }
    }

}
