namespace Tennis
{
    public class Program
    {
        static void Main(string[] args)
        {
            Points points = new Points();
            Logic logic = new Logic(points);
            Controller controller = new Controller(logic);

            controller.StartGame();
        }
    }
}
