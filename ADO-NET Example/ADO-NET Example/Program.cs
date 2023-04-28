namespace ADO_NET_Example
{
   
    internal static class Program
    {
        static Program()
        {
            DatabasePath= "C:\\06_Official\\Trainings\\C-Training\\ADO-NET Example\\ADO-NET Example\\Library.db";
        }
        public static string DatabasePath { get; private set; }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new frmMain());
        }
    }
}