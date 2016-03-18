namespace Tennis
{
    using System;

    public class Logic
    {
        private Points points;
        private int server;
        private int receiver;

        public Logic(Points points)
        {
            this.points = points;
            this.server = 0;
            this.receiver = 0;
        }

        public bool CheckStatus(int player)
        {
            this.UpdateScores(player);

            if (this.server == 5 || this.receiver == 5)
            {
                return true;
            }

            if (Math.Abs(this.server - this.receiver) >= 2 && (this.server == 4 || this.receiver == 4))
            {
                return true;
            }

            return false;
        }

        public string GetWinner()
        {
            string winner = this.server > this.receiver ? "Server" : "Receiver";

            return "The winner is: " + winner;
        }

        public string GetScore()
        {
            return this.points.GetScore(this.server, this.receiver);
        }

        private void UpdateScores(int player)
        {
            switch (player)
            {
                case 1:
                    this.server++;
                    break;

                case 2:
                    this.receiver++;
                    break;
            }

            if (this.server == 4 && this.receiver == 4)
            {
                this.server--;
                this.receiver--;
            }
        }
    }
}