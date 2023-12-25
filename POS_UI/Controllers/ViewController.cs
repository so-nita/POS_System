using POS_UI.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_UI.Controllers
{
    public class ViewController : IViewController
    {
        private readonly View_MainContainer _mainContainer;
        private readonly ResturantController _resturantController;
        private readonly MartController _martController;
        private readonly StoreController _storeController;

        public ViewController(View_MainContainer mainContainer, ResturantController resturantController, MartController martController, StoreController storeController)
        {
            _mainContainer = mainContainer;
            _resturantController = resturantController;
            _martController = martController;
            _storeController = storeController;
        }

        public void LoadInitialView(string userRole, string userCompany)
        {
            Form initialView = CreateInitialView(userRole, userCompany);
            AddController(initialView);
        }

        public void SwitchToResturantView()
        {
            Form resturantView = _resturantController.GetView();
            AddController(resturantView);
        }

        public void SwitchToMartView()
        {
            Form martView = _martController.GetView();
            AddController(martView);
        }

        public void SwitchToStoreView()
        {
            Form storeView = _storeController.GetView();
            AddController(storeView);
        }

        private void AddController(Form form)
        {
            _mainContainer.centerPanel.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            _mainContainer.centerPanel.Controls.Add(form);
            form.Show();
        }

        private Form CreateInitialView(string userRole, string userCompany)
        {
            // Logic to determine the initial view based on user role and company
        }
    }
}
