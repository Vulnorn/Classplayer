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
        string _name;
        public int Level;

        public Player(string name, int level) 
        { 
            _name = name;
            Level = level;
        }

        public void ShowStats() 
        {
            Console.WriteLine($"Имя Игрока {_name}, Уровень Игрока - {Level}");
            Console.ReadKey();
        }
    }
}