using POS_UI.Service;
using POS_UI.View.View_PosSubMenu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_UI.Controllers;

public class ResturantController
{
    private readonly View_Resturant _view;
    private readonly ProductService _productService;

    public ResturantController(View_Resturant viewModel, ProductService productService)
    {
        _view = viewModel;
        _productService = productService;
    }

    
}
