namespace Tennis
{
    using System;

    public class Controller
    {
        private readonly Logic logic;

        public Controller(Logic logic)
        {
            this.logic = logic;
        }

        public void StartGame()
        {
            bool win;
            int player;

            Console.WriteLine("Server=1");
            Console.WriteLine("Receiver=2");

            while (true)
            {
                Console.Write("Please enter the player that wins the point:");
                string line = Console.ReadLine();


                if (int.TryParse(line, out player))
                {
                    win = this.logic.CheckStatus(player);
                    if (win)
                    {
                        break;
                    }

                    Console.WriteLine(this.logic.GetScore());
                }
            }

            Console.WriteLine(this.logic.GetWinner());
            Console.ReadLine();
        }
    }
}