using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StatePattern.States;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Enemy enemy = new Enemy();

            string command = Console.ReadLine();
            switch (command)
            {
                case "a":
                    {
                        player.Attack(enemy);
                    } break;
                case "w":
                    {
                        player.Walk();
                    } break;
                case "t":
                    {
                        player.TakeDamage(5);
                    } break;
                case "1":
                    {
                        NormalState state = new NormalState(player);
                        player.ChangeState(state);
                    } break;
                case "2":
                    {
                        BerserkState state = new BerserkState(player);
                        player.ChangeState(state);
                    } break;
                case "3":
                    {
                        CursedState state = new CursedState(player);
                        player.ChangeState(state);
                    } break;
                default:
                    break;
            }
        }
    }
}
