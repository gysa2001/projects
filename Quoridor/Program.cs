using quoridor_v2.GameAI;

namespace quoridor_v2
{
    internal static class Program
    {
        public static Main main = new Main();
        public static Heuristic heuristic = new Heuristic();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(main);

            /*AI ai1 = new AI();
            AI ai2 = new AI();

            ai1.MAX_DEPTH = 2;
            ai2.MAX_DEPTH = 2;

            //Testing.SimulateGame(ai1 , ai2);
            Testing.Ramdomize(ai1);*/
        }
    }
}