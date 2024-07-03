namespace Projeto_Agropuro
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new PaginaLogin());
        }
    }
}