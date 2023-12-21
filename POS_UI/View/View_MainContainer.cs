using POS_UI.View.View_PosSubMenu;

namespace POS_UI.View;

public partial class View_MainContainer : Form
{
    public View_MainContainer()
    {
        InitializeComponent();
        CustomeDesign();
    }

    private void AddController(Form form)
    {
        /*if (this.centerPanel.Controls.Count > 1)
        {
            this.centerPanel.Controls.Clear();
        }*/
        this.centerPanel.Controls.Clear();
        form.TopLevel = false;
        form.Dock = DockStyle.Fill;
        this.centerPanel.Controls.Add(form);
        form.Show();
    }
    private void CustomeDesign()
    {
        panelSubMenuPOSView.Visible = false;
        CollapseMenu();
    }
    private void hideSubMenu()
    {
        panelSubMenuPOSView.Visible = (panelSubMenuPOSView.Visible == true) ? false : true;
    }
    private void ShowSubMenu(Panel subMenu)
    {
        if (subMenu.Visible == false)
        {
            hideSubMenu();
            subMenu.Visible = true;
        }
        else
        {
            subMenu.Visible = false;
        }
    }
    
    private void btnMenuPOSView_Click(object sender, EventArgs e)
    {
        ShowSubMenu(panelSubMenuPOSView);
    }


    #region Sub menu POS View
    private void btnSubMenuResturant_Click(object sender, EventArgs e)
    {
        hideSubMenu();
        AddController(new View_Resturant());
    }

    private void btnSubMenuMart_Click(object sender, EventArgs e)
    {
        hideSubMenu();
        AddController(new View_Mart());
    }
    private void btnSubMenuStore_Click(object sender, EventArgs e)
    {
        hideSubMenu();
        AddController(new View_Store());
    }
    #endregion

    private void btnMenuBar_Click(object sender, EventArgs e)
    {

    }
    // 
    private void CollapseMenu()
    {

    }
}
