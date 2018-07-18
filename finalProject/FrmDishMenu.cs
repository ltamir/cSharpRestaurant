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
    public partial class FrmDishMenu : Form
    {
        private RestaurantBL bl = new RestaurantBL();

        private int lastX;
        private int lastY;
        private ToolTip toolTip = new ToolTip();

        IDishBean currentDish = null;


        public FrmDishMenu()
        {
            InitializeComponent();

            lstDessert.DataSource = bl.GetDessert().Where(e => e.DesertId > 1);
            lstAppetizer.DataSource = bl.GetAppetizer().Where(e => e.AppetizerId > 1);
            lstMainCourse.DataSource = bl.GetMainCourse().Where (e => e.MainCourseId > 1);
            lstSideDish.DataSource = bl.GetSideDish().Where(e => e.SideDishId > 1);
        }


        // ***** form logic ***** //


        private void ShowMessage(int msgId)
        {
            string caption = null;
            string prompt = null;

            bl.GetMessage(msgId, ref caption, ref prompt);
            MessageBox.Show(prompt, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void ShowDishToolTip(ListBox list, MouseEventArgs e)
        {
            int itemId = list.IndexFromPoint(e.Location);
            if (itemId < 0)
                return;

            if (e.X != this.lastX || e.Y != this.lastY)
            {
                toolTip.SetToolTip(list, list.Items[itemId].ToString());

                this.lastX = e.X;
                this.lastY = e.Y;
            }
        }

        private void EditDish(IDishBean dish, RestaurantBL.DishTypeEnum dishType)
        {
            currentDish = dish;
            txtDishName.Text = dish.GetDishName();
            txtDishPrice.Text = dish.GetDishPrice().ToString();
            cmbDishType.SelectedIndex = (int)dishType;
        }

        private bool ValidateDishName(ref string name)
        {
            if (txtDishName.Text == null || txtDishName.Text.Length == 0)
                return false;

            name = txtDishName.Text;
            return true;

        }
        private bool ValidateDishPrice(ref double dishPrice)
        {
            Double price = 0.00;
            try
            {
                price = Double.Parse(txtDishPrice.Text);
                dishPrice = price;
            }
            catch (Exception excep)
            {
                Console.WriteLine(excep.Data);

                return false;
            }

            return true;
        }

        // ***** form events ***** //

        private void FrmDishMenu_Load(object sender, EventArgs e)
        {
            cmbDishType.SelectedIndex = 0;
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            Close();
        }


        // **** form events for data handling ***** //

        private void cmdAddDish_Click(object sender, EventArgs e)
        {
            Double dishPrice = 0;
            string dishName = null;

            if (!ValidateDishName(ref dishName))
            {
                ShowMessage(5);
                return;
            }
                

            if (!ValidateDishPrice(ref dishPrice))
                return;
            
            if(cmbDishType.SelectedIndex == 0)
            {
                ShowMessage(3);
                return;
            }

            bl.AddDish((RestaurantBL.DishTypeEnum)cmbDishType.SelectedIndex, dishName, dishPrice);

            switch (cmbDishType.SelectedIndex)
            { 
                case 1:
                    lstAppetizer.Refresh();
                    break;
                case 2:
                    lstMainCourse.Refresh();
                    break;
                case 3:
                    lstSideDish.Refresh();
                    break;
                case 4:
                    lstDessert.Refresh();
                    break;
            }
        }


        private void cmdUpdateDish_Click(object sender, EventArgs e)
        {
            Double dishPrice = 0;
            string dishName = null;

            if (!ValidateDishName(ref dishName))
            {
                ShowMessage(5);
                return;
            }

                if (!ValidateDishPrice(ref dishPrice))
            {
                ShowMessage(4);
                return;
            }

            bl.updateDish((RestaurantBL.DishTypeEnum)cmbDishType.SelectedIndex, this.currentDish, dishName, dishPrice);
            cmbDishType.Enabled = true;
        }


        // ***** form events for tooltip handling ***** //

        private void lstDessert_MouseMove(object sender, MouseEventArgs e)
        {
            ShowDishToolTip((ListBox)sender, e);
        }

        private void lstSideDish_MouseMove(object sender, MouseEventArgs e)
        {
            ShowDishToolTip((ListBox)sender, e);
        }

        private void lstMainCourse_MouseMove(object sender, MouseEventArgs e)
        {
            ShowDishToolTip((ListBox)sender, e);
        }

        private void lstAppetizer_MouseMove(object sender, MouseEventArgs e)
        {
            ShowDishToolTip((ListBox)sender, e);
        }


        // ***** form events for edit Dish handling ***** //

        private void lstAppetizer_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Cs_appetizer appetizer = (Cs_appetizer)lstAppetizer.SelectedItem;
            EditDish((IDishBean)appetizer, RestaurantBL.DishTypeEnum.APPETIZER);
            cmbDishType.Enabled = false;
            cmdAddDish.Enabled = false;
            cmdUpdateDish.Enabled = true;
        }

        private void lstMainCourse_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Cs_mainCourse mainCourse = (Cs_mainCourse)lstMainCourse.SelectedItem;
            EditDish((IDishBean)mainCourse, RestaurantBL.DishTypeEnum.MAIN_COURSE);
            cmbDishType.Enabled = false;
            cmdAddDish.Enabled = false;
            cmdUpdateDish.Enabled = true;
        }

        private void lstSideDish_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Cs_sideDish sideDish = (Cs_sideDish)lstSideDish.SelectedItem;
            EditDish((IDishBean)sideDish, RestaurantBL.DishTypeEnum.SIDE_DISH);
            cmbDishType.Enabled = false;
            cmdAddDish.Enabled = false;
            cmdUpdateDish.Enabled = true;
        }

        private void lstDessert_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Cs_dessert dessert = (Cs_dessert)lstDessert.SelectedItem;
            EditDish((IDishBean)dessert, RestaurantBL.DishTypeEnum.DESSERT);
            cmbDishType.Enabled = false;
            cmdAddDish.Enabled = false;
            cmdUpdateDish.Enabled = true;
        }

        private void cmdNewDish_Click(object sender, EventArgs e)
        {
            txtDishName.Text = "";
            txtDishPrice.Text = "";
            cmbDishType.Enabled = true;
            cmdAddDish.Enabled = true;
            cmdUpdateDish.Enabled = false;
        }
    }
}
