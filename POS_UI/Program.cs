using OfficeOpenXml;
using POS_UI.Components;
using POS_UI.View;
using POS_UI.View.Receipt;

namespace POS_UI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            //Application.Run(new View_Mart());
             Application.Run(new View_MainContainer());

            /*ExcelPackage.LicenseContext = LicenseContext.NonCommercial;  
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);*/

            //Application.Run(new Test());
             
        }
    }
}