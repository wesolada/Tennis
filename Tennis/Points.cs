namespace Tennis
{
    public class Points
    {
        public string GetScore(int server, int receiver)
        {
            return this.GetPoint(server) + ":" + this.GetPoint(receiver);
        }

        private string GetPoint(int point)
        {
            switch (point)
            {
                case 0:
                    return "0";

                case 1:
                    return "15";

                case 2:
                    return "30";

                case 3:
                    return "40";

                case 4:
                    return "A";
            }

            return "0";
        }
    }
}
