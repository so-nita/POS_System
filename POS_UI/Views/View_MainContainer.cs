using POS_UI.View.View_PosSubMenu;

namespace POS_UI.View;

public partial class View_MainContainer : Form
{
    private int minWidthSize = 1200;
    private int maxWidthSize = 1305;

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
        // CollapseMenu();
    }
    // 
    private void CollapseMenu()
    {
        if (this.panelMenuLeft.Width > 200) // Callapse the Panel
        {
            panelMenuLeft.Width = 70;
            foreach (Button menuButton in panelMenuLeft.Controls.OfType<Button>())
            {
                menuButton.Text = "";
                menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                panelMenuLeft.Padding = new Padding(0, 20, 0, 0);
            }
            this.Width = minWidthSize;
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        else // Expand the Panel
        {
            panelMenuLeft.Width = 203;
            panelMenuLeft.Visible = true;
            panelMenuLeft.Padding = new Padding(0, 10, 0, 0);
            foreach (Button menuButton in panelMenuLeft.Controls.OfType<Button>())
            {
                menuButton.Text = "   " + menuButton.Tag!.ToString();
                menuButton.ImageAlign = ContentAlignment.MiddleLeft;
            }
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Width = maxWidthSize;
        }
    }

    private void nightControlBox1_Click(object sender, EventArgs e)
    {
        if (centerPanel.Width < 1150)
        {
            centerPanel.Padding = new Padding(10, 10, 15, 10);
        }
        else
        {
            centerPanel.Padding = new Padding(0, 0, 0, 0);
        }
    }
}
