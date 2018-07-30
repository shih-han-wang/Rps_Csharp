﻿using System;
namespace Rps
{
    public enum Moves { Rock = 1, Paper, Scissors };

    public class Game
    {
        private int totalTurn;
        public Player p1;
        public Player p2;

        public Game(Player player1, Player player2, int turn = 3)
        {
            totalTurn = turn;
            p1 = player1;
            p2 = player2;
        }

        public int TotalTurn
        {
            get { return totalTurn; }
        }

        public Moves GetUerInput()
        {
            string userInput;
            char inputChar;

            do
            {
                Console.WriteLine(Message.StartGame());
                userInput = Console.ReadLine();
                inputChar = Convert.ToChar(userInput);

            } while (!Helper.RpsValidation(inputChar));

            return Helper.ConvertInput(inputChar);

        }
    }
}
