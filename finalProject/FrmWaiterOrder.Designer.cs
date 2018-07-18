namespace finalProject
{
    partial class FrmWaiterOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTable = new System.Windows.Forms.Label();
            this.cmbTable = new System.Windows.Forms.ComboBox();
            this.cmdClose = new System.Windows.Forms.Button();
            this.cmdAddOrder = new System.Windows.Forms.Button();
            this.lblSum = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lstAppetizer = new System.Windows.Forms.ListBox();
            this.lstMainCourse = new System.Windows.Forms.ListBox();
            this.lstSideDish = new System.Windows.Forms.ListBox();
            this.lstDessert = new System.Windows.Forms.ListBox();
            this.lblAppetizerPrice = new System.Windows.Forms.Label();
            this.lblMainCoursePrice = new System.Windows.Forms.Label();
            this.lblSideDishPrice = new System.Windows.Forms.Label();
            this.lblDessertPrice = new System.Windows.Forms.Label();
            this.lblActionTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Location = new System.Drawing.Point(662, 29);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(54, 22);
            this.lblTable.TabIndex = 6;
            this.lblTable.Text = "שולחן:";
            // 
            // cmbTable
            // 
            this.cmbTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTable.FormattingEnabled = true;
            this.cmbTable.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbTable.Location = new System.Drawing.Point(562, 26);
            this.cmbTable.Name = "cmbTable";
            this.cmbTable.Size = new System.Drawing.Size(94, 30);
            this.cmbTable.TabIndex = 5;
            this.cmbTable.SelectedIndexChanged += new System.EventHandler(this.cmbTable_SelectedIndexChanged);
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(22, 245);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(107, 30);
            this.cmdClose.TabIndex = 7;
            this.cmdClose.Text = "סגור";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // cmdAddOrder
            // 
            this.cmdAddOrder.Location = new System.Drawing.Point(202, 245);
            this.cmdAddOrder.Name = "cmdAddOrder";
            this.cmdAddOrder.Size = new System.Drawing.Size(107, 30);
            this.cmdAddOrder.TabIndex = 8;
            this.cmdAddOrder.Text = "בצע הזמנה";
            this.cmdAddOrder.UseVisualStyleBackColor = true;
            this.cmdAddOrder.Click += new System.EventHandler(this.cmdAddOrder_Click);
            // 
            // lblSum
            // 
            this.lblSum.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblSum.Location = new System.Drawing.Point(569, 248);
            this.lblSum.Name = "lblSum";
            this.lblSum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSum.Size = new System.Drawing.Size(66, 25);
            this.lblSum.TabIndex = 9;
            this.lblSum.Text = "000.00";
            this.lblSum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(640, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "לתשלום:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(616, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "מנה ראשונה";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(442, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 22);
            this.label3.TabIndex = 16;
            this.label3.Text = "מנה עיקרית";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(287, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 22);
            this.label4.TabIndex = 17;
            this.label4.Text = "פחממות";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 22);
            this.label5.TabIndex = 18;
            this.label5.Text = "קינוח";
            // 
            // lstAppetizer
            // 
            this.lstAppetizer.FormattingEnabled = true;
            this.lstAppetizer.ItemHeight = 22;
            this.lstAppetizer.Location = new System.Drawing.Point(562, 95);
            this.lstAppetizer.Name = "lstAppetizer";
            this.lstAppetizer.Size = new System.Drawing.Size(154, 92);
            this.lstAppetizer.TabIndex = 19;
            this.lstAppetizer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstAppetizer_MouseClick);
            this.lstAppetizer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lstAppetizer_MouseMove);
            // 
            // lstMainCourse
            // 
            this.lstMainCourse.FormattingEnabled = true;
            this.lstMainCourse.ItemHeight = 22;
            this.lstMainCourse.Location = new System.Drawing.Point(382, 95);
            this.lstMainCourse.Name = "lstMainCourse";
            this.lstMainCourse.Size = new System.Drawing.Size(154, 92);
            this.lstMainCourse.TabIndex = 20;
            this.lstMainCourse.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstMainCourse_MouseClick);
            this.lstMainCourse.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lstMainCourse_MouseMove);
            // 
            // lstSideDish
            // 
            this.lstSideDish.FormattingEnabled = true;
            this.lstSideDish.ItemHeight = 22;
            this.lstSideDish.Location = new System.Drawing.Point(202, 95);
            this.lstSideDish.Name = "lstSideDish";
            this.lstSideDish.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstSideDish.Size = new System.Drawing.Size(154, 92);
            this.lstSideDish.TabIndex = 21;
            this.lstSideDish.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstSideDish_MouseClick);
            this.lstSideDish.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lstSideDish_MouseMove);
            // 
            // lstDessert
            // 
            this.lstDessert.FormattingEnabled = true;
            this.lstDessert.ItemHeight = 22;
            this.lstDessert.Location = new System.Drawing.Point(22, 95);
            this.lstDessert.Name = "lstDessert";
            this.lstDessert.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstDessert.Size = new System.Drawing.Size(154, 92);
            this.lstDessert.TabIndex = 22;
            this.lstDessert.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstDessert_MouseClick);
            this.lstDessert.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lstDessert_MouseMove);
            // 
            // lblAppetizerPrice
            // 
            this.lblAppetizerPrice.Location = new System.Drawing.Point(562, 190);
            this.lblAppetizerPrice.Name = "lblAppetizerPrice";
            this.lblAppetizerPrice.Size = new System.Drawing.Size(154, 23);
            this.lblAppetizerPrice.TabIndex = 23;
            this.lblAppetizerPrice.Text = "00.00";
            // 
            // lblMainCoursePrice
            // 
            this.lblMainCoursePrice.Location = new System.Drawing.Point(380, 190);
            this.lblMainCoursePrice.Name = "lblMainCoursePrice";
            this.lblMainCoursePrice.Size = new System.Drawing.Size(154, 23);
            this.lblMainCoursePrice.TabIndex = 24;
            this.lblMainCoursePrice.Text = "00.00";
            // 
            // lblSideDishPrice
            // 
            this.lblSideDishPrice.Location = new System.Drawing.Point(202, 190);
            this.lblSideDishPrice.Name = "lblSideDishPrice";
            this.lblSideDishPrice.Size = new System.Drawing.Size(154, 23);
            this.lblSideDishPrice.TabIndex = 25;
            this.lblSideDishPrice.Text = "00.00";
            // 
            // lblDessertPrice
            // 
            this.lblDessertPrice.Location = new System.Drawing.Point(22, 190);
            this.lblDessertPrice.Name = "lblDessertPrice";
            this.lblDessertPrice.Size = new System.Drawing.Size(154, 23);
            this.lblDessertPrice.TabIndex = 26;
            this.lblDessertPrice.Text = "00.00";
            // 
            // lblActionTitle
            // 
            this.lblActionTitle.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActionTitle.Location = new System.Drawing.Point(22, 23);
            this.lblActionTitle.Name = "lblActionTitle";
            this.lblActionTitle.Size = new System.Drawing.Size(534, 28);
            this.lblActionTitle.TabIndex = 29;
            this.lblActionTitle.Text = "הזמנה חדשה";
            this.lblActionTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmWaiterOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(729, 284);
            this.Controls.Add(this.lblActionTitle);
            this.Controls.Add(this.lblDessertPrice);
            this.Controls.Add(this.lblSideDishPrice);
            this.Controls.Add(this.lblMainCoursePrice);
            this.Controls.Add(this.lblAppetizerPrice);
            this.Controls.Add(this.lstDessert);
            this.Controls.Add(this.lstSideDish);
            this.Controls.Add(this.lstMainCourse);
            this.Controls.Add(this.lstAppetizer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.cmdAddOrder);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.lblTable);
            this.Controls.Add(this.cmbTable);
            this.Font = new System.Drawing.Font("Trebuchet MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmWaiterOrder";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "ניהול הזמנות";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.ComboBox cmbTable;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.Button cmdAddOrder;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstAppetizer;
        private System.Windows.Forms.ListBox lstMainCourse;
        private System.Windows.Forms.ListBox lstSideDish;
        private System.Windows.Forms.ListBox lstDessert;
        private System.Windows.Forms.Label lblAppetizerPrice;
        private System.Windows.Forms.Label lblMainCoursePrice;
        private System.Windows.Forms.Label lblSideDishPrice;
        private System.Windows.Forms.Label lblDessertPrice;
        private System.Windows.Forms.Label lblActionTitle;
    }
}