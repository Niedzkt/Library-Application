namespace LibraryApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            string connectionString = "Server=localhost; Port=3306; Database=library; Uid=root; Pwd=;";
            DatabaseAccess dbAccess = new DatabaseAccess(connectionString);

            Application.Run(new Form1(dbAccess));
        }
    }
}