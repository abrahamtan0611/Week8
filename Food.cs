using System;

using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Food
    {
        public int x { get; set; }
        public int y { get; set; }
        public Food()
        {
            //randomize the food coordinates
            Random random = new Random();
            this.x = random.Next(11, Console.WindowWidth - 11);
            this.y = random.Next(Console.WindowHeight);
        }

        public void Generate_random_food()
        {
            //display the food
            Console.OutputEncoding = System.Text.Encoding.UTF8;     //change the encoding style to utf-8
            Console.SetCursorPosition(this.x, this.y);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("♥♥");
        }
    }
}
