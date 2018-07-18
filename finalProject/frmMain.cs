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
    public partial class frmRestaurant : Form
    {
        public frmRestaurant()
        {
            InitializeComponent();

        }

        private void frmRestaurant_Load(object sender, EventArgs e)
        {

        }

        private void WaiterMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FrmWaiterOrder frmWaiterOrder = new FrmWaiterOrder();
            frmWaiterOrder.ShowDialog();
            Show();
        }

        private void KitchenMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FrmKitchen frmKitchen = new FrmKitchen();
            frmKitchen.ShowDialog();
            Show();
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FrmAbout frmAbout = new FrmAbout();
            frmAbout.ShowDialog();
            Show();
        }

        private void DishDataMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FrmDishMenu frmDishMenu = new FrmDishMenu();
            frmDishMenu.ShowDialog();
            Show();
        }
    }
}
