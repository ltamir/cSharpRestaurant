using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListBox;

namespace finalProject
{
    public partial class FrmWaiterOrder : Form
    {
        private RestaurantBL bl = new RestaurantBL();

        private int lastX;
        private int lastY;
        private ToolTip toolTip = new ToolTip();

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

        private void SetActionTitle()
        {
            if (cmbTable.SelectedIndex == 0)
            {
                lblActionTitle.Text = bl.GetCaption(8);
            }
            else
            {
                lblActionTitle.Text = bl.GetCaption(9);
            }
        }

        public FrmWaiterOrder()
        {
            InitializeComponent();

            cmbTable.DataSource = bl.GetDiningTable();

            lstAppetizer.DataSource = bl.GetAppetizer();
            lstMainCourse.DataSource = bl.GetMainCourse();
            lstSideDish.DataSource = bl.GetSideDish();            
            lstDessert.DataSource = bl.GetDessert();

            SetActionTitle();
        }


        // ***** Form events ***** //

        private void cmbTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cs_order order = null;
            SetActionTitle();

            if (lstAppetizer.Items.Count < 1)
                return;

            order = bl.GetOrder((Cs_diningTable)cmbTable.SelectedItem);
            if (order == null)
            {
                lblActionTitle.Text = bl.GetCaption(8);
                lstAppetizer.SetSelected(0, true);
                lstMainCourse.SetSelected(0, true);
                lstSideDish.ClearSelected();
                lstSideDish.SetSelected(0, true);
                lstDessert.ClearSelected();
                lstDessert.SetSelected(0, true);
            }
            else
            {
                lblActionTitle.Text = bl.GetCaption(9);

                lstAppetizer.SelectedIndex = lstAppetizer.Items.IndexOf(order.Cs_appetizer);
                lblAppetizerPrice.Text = order.Cs_appetizer.DishPrice.ToString();

                lstMainCourse.SelectedIndex = lstMainCourse.Items.IndexOf(order.Cs_mainCourse);
                lblMainCoursePrice.Text = order.Cs_mainCourse.DishPrice.ToString();

                lstSideDish.ClearSelected();
                lstSideDish.SetSelected(lstSideDish.Items.IndexOf(order.Cs_sideDish), true);
                lstSideDish.SetSelected(lstSideDish.Items.IndexOf(order.SideDishTwo), true);
                lblSideDishPrice.Text = (order.Cs_sideDish.DishPrice + order.SideDishTwo.DishPrice).ToString();

                lstDessert.ClearSelected();
                lstDessert.SetSelected(lstDessert.Items.IndexOf(order.Cs_dessert), true);
                lstDessert.SetSelected(lstDessert.Items.IndexOf(order.DessertTwo), true);
                lblDessertPrice.Text = (order.Cs_dessert.DishPrice + order.DessertTwo.DishPrice).ToString();
            }
            
            lblSum.Text = bl.OrderSum.ToString();
        }

        // ***** Form events for dish selection ***** //

        private void lstMainCourse_MouseClick(object sender, MouseEventArgs e)
        {
            if (lstMainCourse.IndexFromPoint(e.Location) < 0)
                return;

            bl.AddMainCourseOrder((Cs_mainCourse)lstMainCourse.SelectedItem);
            lblSum.Text = bl.OrderSum.ToString();
            lblMainCoursePrice.Text = ((Cs_mainCourse)lstMainCourse.SelectedItem).DishPrice.ToString();
        }

        private void lstSideDish_MouseClick(object sender, MouseEventArgs e)
        {
            Cs_sideDish sideDish1 = null;
            Cs_sideDish sideDish2 = null;

            if (lstSideDish.IndexFromPoint(e.Location) < 0)
                return;

            if (lstSideDish.SelectedItems.Count > 2)
            {
                if (((Cs_sideDish)lstSideDish.SelectedItems[0]).SideDishId == 1)
                { 
                    lstSideDish.SetSelected(0, false);
                }
                else if(((Cs_sideDish)lstSideDish.SelectedItems[1]).SideDishId == 1)
                {
                    lstSideDish.SetSelected(0, false);
                }
            }

            switch (lstSideDish.SelectedItems.Count)
            {
                case 0:
                    sideDish1 = (Cs_sideDish)lstSideDish.Items[0];
                    sideDish2 = (Cs_sideDish)lstSideDish.Items[0];
                    break;
                case 1:
                    sideDish1 = (Cs_sideDish)lstSideDish.SelectedItem;
                    sideDish2 = (Cs_sideDish)lstSideDish.Items[0];
                    break;
                case 2:
                    sideDish1 = (Cs_sideDish)lstSideDish.SelectedItems[0];
                    sideDish2 = (Cs_sideDish)lstSideDish.SelectedItems[1];
                    break;
                default:
                    ShowMessage(7);
                    lstSideDish.SetSelected(lstSideDish.IndexFromPoint(e.Location), false);
                    return;
            }

            bl.AddSideDishOrder(sideDish1, sideDish2);
            lblSum.Text = bl.OrderSum.ToString();
            lblSideDishPrice.Text = (sideDish1.DishPrice + sideDish2.DishPrice).ToString();
        }

        private void lstAppetizer_MouseClick(object sender, MouseEventArgs e)
        {
            if (lstAppetizer.IndexFromPoint(e.Location) < 0)
                return;

            bl.AddAppetizerOrder((Cs_appetizer)lstAppetizer.SelectedItem);
            lblSum.Text = bl.OrderSum.ToString();
            lblAppetizerPrice.Text = ((Cs_appetizer)lstAppetizer.SelectedItem).DishPrice.ToString();
        }

        private void lstDessert_MouseClick(object sender, MouseEventArgs e)
        {
            Cs_dessert dessert1 = null;
            Cs_dessert dessert2 = null;

            if (lstDessert.IndexFromPoint(e.Location) < 0)
            {
                if (lstDessert.SelectedItems.Count == 0)
                    lstDessert.ClearSelected();
                return;
            }
                

            if (lstDessert.SelectedItems.Count > 2)
            {
                if (((Cs_dessert)lstDessert.SelectedItems[0]).DesertId == 1)
                {
                    lstDessert.SetSelected(0, false);
                }
                else if (((Cs_dessert)lstDessert.SelectedItems[1]).DesertId == 1)
                {
                    lstDessert.SetSelected(0, false);
                }
            }

            switch (lstDessert.SelectedItems.Count)
            {
                case 0:
                    dessert1 = (Cs_dessert)lstDessert.Items[0];
                    dessert2 = (Cs_dessert)lstDessert.Items[0];
                    break;
                case 1:
                    dessert1 = (Cs_dessert)lstDessert.SelectedItem;
                    dessert2 = (Cs_dessert)lstDessert.Items[0];
                    break;
                case 2:
                    dessert1 = (Cs_dessert)lstDessert.SelectedItems[0];
                    dessert2 = (Cs_dessert)lstDessert.SelectedItems[1];
                    break;
                default:
                    ShowMessage(8);
                    lstDessert.SetSelected(lstDessert.IndexFromPoint(e.Location), false);
                    return;
            }
            bl.AddDessertOrder(dessert1, dessert2);
            lblSum.Text = bl.OrderSum.ToString();
            lblDessertPrice.Text = (dessert1.DishPrice + dessert2.DishPrice).ToString();
        }


        // ***** Form events for command buttons ***** //

        private void cmdAddOrder_Click(object sender, EventArgs e)
        {
            if (cmbTable.SelectedIndex == 0)
                ShowMessage(6);
            bl.AddOrder((Cs_diningTable)cmbTable.SelectedItem);
            lblActionTitle.Text = bl.GetCaption(10);
            
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            Close();
        }


        // ***** Form events for Dish tooltip ***** //

        private void lstAppetizer_MouseMove(object sender, MouseEventArgs e)
        {
            ShowDishToolTip(lstAppetizer, e);

        }


        private void lstMainCourse_MouseMove(object sender, MouseEventArgs e)
        {
            ShowDishToolTip(lstMainCourse, e);
        }


        private void lstSideDish_MouseMove(object sender, MouseEventArgs e)
        {
            ShowDishToolTip(lstSideDish, e);
        }

        private void lstDessert_MouseMove(object sender, MouseEventArgs e)
        {
            ShowDishToolTip(lstDessert, e);

        }


    }
}
