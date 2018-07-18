using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalProject
{
    public partial class FrmKitchen : Form
    {
        private RestaurantBL bl = new RestaurantBL();

        public FrmKitchen()
        {
            InitializeComponent();

            grdOrder.DataSource = bl.GetOrderList();
            grdOrder.Columns[0].HeaderText = bl.GetCaption(1);
            grdOrder.Columns[1].HeaderText = bl.GetCaption(2);
            grdOrder.Columns[2].HeaderText = bl.GetCaption(3);
            grdOrder.Columns[3].HeaderText = bl.GetCaption(4);
            grdOrder.Columns[4].HeaderText = bl.GetCaption(5);
            grdOrder.Columns[5].HeaderText = bl.GetCaption(6);
            grdOrder.Columns[6].HeaderText = bl.GetCaption(7);
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
