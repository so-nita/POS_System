using POS_UI.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_UI.UserControls.UC_Mart
{
    public partial class UC_ViewCard_SubTotal : UserControl
    {
        private Order _subTotals;
        public UC_ViewCard_SubTotal(Order subTotals = null!)
        {
            InitializeComponent();
        }
    }
}
