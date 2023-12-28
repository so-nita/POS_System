using POS_UI.Constant;
using POS_UI.Controllers;
using POS_UI.Models.User;

namespace POS_UI;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        ApplicationConfiguration.Initialize();

        //Application.Run(new View_Resturant());
        //Application.Run(new View_MainContainer());

        /*ExcelPackage.LicenseContext = LicenseContext.NonCommercial;  
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);*/

        /*  var viewControll = new ViewController(new View_MainContainer(),new ResturantController(),new MartController);
          //Application.Run(new Test());
          var mainContainer = new View_MainContainer();*/

        //Application.Run(new View_Main());


        var user = new User
        {
            Role = RoleType.SuperAdmin.ToString(),
            //Role = RoleType.Admin.ToString(),
            //Company = CompanyType.Resturant.ToString(),
        };

        var controller = new UserController(user);
        var mainView = controller.CreateMainView();
        Application.Run(mainView);
    }
    
}