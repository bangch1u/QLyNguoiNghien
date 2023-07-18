using QLyNguoiNghien.View;
namespace QLyNguoiNghien
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new fDataNguoiCaiNghien());
            //Scaffold-DbContext 'Data Source=BANGCHIU105\SQLEXPRESS01;Initial Catalog=QLNCN;Integrated Security=True ;TrustServerCertificate=true' Microsoft.EntityFrameworkCore.SqlServer -OutputDir DomainClass -context DBContext -Contextdir Context -DataAnnotations -Force

        }
    }
}