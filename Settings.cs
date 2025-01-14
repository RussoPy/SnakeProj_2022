namespace Snake
{
    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    };

    public class Settings
    {
        public static int Width { get; set; }
        public static int Height { get; set; }
        public static int Speed { get; set; }
        public static int Score { get; set; }
        public static int R_Points { get; set; }
        public static int M_Points { get; set; }
        public static bool GameOver { get; set; }
        public static bool Puase { get; set; }
        public static Direction direction { get; set; }

        public Settings()
        {
            Speed = 20;
            Score = 0;
            R_Points = 100;
            M_Points = 200;
            GameOver = false;
            Puase = false;
            direction = Direction.Down;
        }

        public static void R_Reward()
        {
            Score +=R_Points;
        }

        public static void M_Reward()
        {
            Score += M_Points;
        }
    }


}
