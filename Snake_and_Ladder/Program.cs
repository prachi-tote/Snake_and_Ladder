﻿// See https://aka.ms/new-console-template for more information
using System;


namespace Snake_And_Ladder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Snake and Ladder game played with single player at start position 0");
            int Player_position = 0;
            Console.WriteLine(" Position = " + Player_position);
            Console.WriteLine(" The Player rolls the die to get a number between 1 to 6");
            Random random = new Random();
            int Die_num = random.Next(1, 7);
            Console.WriteLine(" Number after rolling a die:");
            Console.WriteLine($" {Die_num}");


        }
    }
}