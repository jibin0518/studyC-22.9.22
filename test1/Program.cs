using System;

namespace test1
{
    class Program
    {
        internal class program
        {

        }
        static void Main(string[] args)
        {
            Player player = new Player();
            Monster monster1 = new Monster();

            player.AddAt(10);
            player.Fight(monster1.at);
            Monster.Fight(player.at);

            Console.WriteLine(monster1.at);
            Console.WriteLine(player.at);
            Console.Read();
        }
    }
}
