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

            player.ShowStats();
        }
    }

    class Player
    {
        private string _name;
        private  int _level;

        public Player(string name, int level) 
        { 
            _name = name;
            _level = level;
        }

        public void ShowStats() 
        {
            Console.WriteLine($"Имя Игрока {_name}, Уровень Игрока - {_level}");
            Console.ReadKey();
        }
    }
}