using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player("Player", 1);

            player.ShowStatsPlayer();
        }
    }

    class Player
    {
        public string Name;
        public int Level;

        public Player(string name, int level) 
        { 
            Name = name;
            Level = level;
        }

        public void ShowStatsPlayer() 
        {
            Console.WriteLine($"Имя Игрока {Name}, Уровень Игрока - {Level}");
            Console.ReadKey();
        }
    }
}