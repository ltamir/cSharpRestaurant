namespace finalProject
{
    partial class FrmDishMenu
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
            this.lstAppetizer = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMainCourse = new System.Windows.Forms.Label();
            this.lstMainCourse = new System.Windows.Forms.ListBox();
            this.lblSideDish = new System.Windows.Forms.Label();
            this.lstSideDish = new System.Windows.Forms.ListBox();
            this.lblDessert = new System.Windows.Forms.Label();
            this.lstDessert = new System.Windows.Forms.ListBox();
            this.cmdAddDish = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDishName = new System.Windows.Forms.TextBox();
            this.txtDishPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDishType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdClose = new System.Windows.Forms.Button();
            this.cmdUpdateDish = new System.Windows.Forms.Button();
            this.cmdNewDish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstAppetizer
            // 
            this.lstAppetizer.FormattingEnabled = true;
            this.lstAppetizer.ItemHeight = 22;
            this.lstAppetizer.Items.AddRange(new object[] {
            "aaa",
            "bbb",
            "ccc",
            "ddd"});
            this.lstAppetizer.Location = new System.Drawing.Point(513, 64);
            this.lstAppetizer.Name = "lstAppetizer";
            this.lstAppetizer.Size = new System.Drawing.Size(150, 92);
            this.lstAppetizer.TabIndex = 0;
            this.lstAppetizer.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstAppetizer_MouseDoubleClick);
            this.lstAppetizer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lstAppetizer_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(562, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "מנות ראשונות";
            // 
            // lblMainCourse
            // 
            this.lblMainCourse.AutoSize = true;
            this.lblMainCourse.Location = new System.Drawing.Point(384, 30);
            this.lblMainCourse.Name = "lblMainCourse";
            this.lblMainCourse.Size = new System.Drawing.Size(101, 22);
            this.lblMainCourse.TabIndex = 3;
            this.lblMainCourse.Text = "מנות עיקריות";
            // 
            // lstMainCourse
            // 
            this.lstMainCourse.FormattingEnabled = true;
            this.lstMainCourse.ItemHeight = 22;
            this.lstMainCourse.Items.AddRange(new object[] {
            "aaa",
            "bbb",
            "ccc",
            "ddd"});
            this.lstMainCourse.Location = new System.Drawing.Point(346, 64);
            this.lstMainCourse.Name = "lstMainCourse";
            this.lstMainCourse.Size = new System.Drawing.Size(150, 92);
            this.lstMainCourse.TabIndex = 2;
            this.lstMainCourse.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstMainCourse_MouseDoubleClick);
            this.lstMainCourse.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lstMainCourse_MouseMove);
            // 
            // lblSideDish
            // 
            this.lblSideDish.AutoSize = true;
            this.lblSideDish.Location = new System.Drawing.Point(264, 30);
            this.lblSideDish.Name = "lblSideDish";
            this.lblSideDish.Size = new System.Drawing.Size(69, 22);
            this.lblSideDish.TabIndex = 5;
            this.lblSideDish.Text = "פחממות";
            // 
            // lstSideDish
            // 
            this.lstSideDish.FormattingEnabled = true;
            this.lstSideDish.ItemHeight = 22;
            this.lstSideDish.Items.AddRange(new object[] {
            "aaa",
            "bbb",
            "ccc",
            "ddd"});
            this.lstSideDish.Location = new System.Drawing.Point(179, 64);
            this.lstSideDish.Name = "lstSideDish";
            this.lstSideDish.Size = new System.Drawing.Size(150, 92);
            this.lstSideDish.TabIndex = 4;
            this.lstSideDish.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstSideDish_MouseDoubleClick);
            this.lstSideDish.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lstSideDish_MouseMove);
            // 
            // lblDessert
            // 
            this.lblDessert.AutoSize = true;
            this.lblDessert.Location = new System.Drawing.Point(120, 30);
            this.lblDessert.Name = "lblDessert";
            this.lblDessert.Size = new System.Drawing.Size(46, 22);
            this.lblDessert.TabIndex = 7;
            this.lblDessert.Text = "קינוח";
            // 
            // lstDessert
            // 
            this.lstDessert.FormattingEnabled = true;
            this.lstDessert.ItemHeight = 22;
            this.lstDessert.Items.AddRange(new object[] {
            "aaa",
            "bbb",
            "ccc",
            "ddd"});
            this.lstDessert.Location = new System.Drawing.Point(12, 64);
            this.lstDessert.Name = "lstDessert";
            this.lstDessert.Size = new System.Drawing.Size(150, 92);
            this.lstDessert.TabIndex = 6;
            this.lstDessert.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstDessert_MouseDoubleClick);
            this.lstDessert.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lstDessert_MouseMove);
            // 
            // cmdAddDish
            // 
            this.cmdAddDish.Location = new System.Drawing.Point(385, 273);
            this.cmdAddDish.Margin = new System.Windows.Forms.Padding(2);
            this.cmdAddDish.Name = "cmdAddDish";
            this.cmdAddDish.Size = new System.Drawing.Size(114, 31);
            this.cmdAddDish.TabIndex = 8;
            this.cmdAddDish.Text = "הוסף מנה";
            this.cmdAddDish.UseVisualStyleBackColor = true;
            this.cmdAddDish.Click += new System.EventHandler(this.cmdAddDish_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(596, 184);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "שם מנה";
            // 
            // txtDishName
            // 
            this.txtDishName.Location = new System.Drawing.Point(549, 208);
            this.txtDishName.Margin = new System.Windows.Forms.Padding(2);
            this.txtDishName.Name = "txtDishName";
            this.txtDishName.Size = new System.Drawing.Size(114, 26);
            this.txtDishName.TabIndex = 10;
            // 
            // txtDishPrice
            // 
            this.txtDishPrice.Location = new System.Drawing.Point(440, 208);
            this.txtDishPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtDishPrice.Name = "txtDishPrice";
            this.txtDishPrice.Size = new System.Drawing.Size(71, 26);
            this.txtDishPrice.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(440, 184);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "מחיר מנה";
            // 
            // cmbDishType
            // 
            this.cmbDishType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDishType.FormattingEnabled = true;
            this.cmbDishType.Items.AddRange(new object[] {
            "בחר סוג מנה",
            "מנה ראשונה",
            "מנה עיקרית",
            "פחממות",
            "קינוח"});
            this.cmbDishType.Location = new System.Drawing.Point(264, 208);
            this.cmbDishType.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDishType.Name = "cmbDishType";
            this.cmbDishType.Size = new System.Drawing.Size(126, 30);
            this.cmbDishType.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(330, 184);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 22);
            this.label4.TabIndex = 14;
            this.label4.Text = "סוג מנה";
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(11, 273);
            this.cmdClose.Margin = new System.Windows.Forms.Padding(2);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(74, 31);
            this.cmdClose.TabIndex = 15;
            this.cmdClose.Text = "סגור";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // cmdUpdateDish
            // 
            this.cmdUpdateDish.Enabled = false;
            this.cmdUpdateDish.Location = new System.Drawing.Point(263, 273);
            this.cmdUpdateDish.Margin = new System.Windows.Forms.Padding(2);
            this.cmdUpdateDish.Name = "cmdUpdateDish";
            this.cmdUpdateDish.Size = new System.Drawing.Size(114, 31);
            this.cmdUpdateDish.TabIndex = 17;
            this.cmdUpdateDish.Text = "עדכן מנה";
            this.cmdUpdateDish.UseVisualStyleBackColor = true;
            this.cmdUpdateDish.Click += new System.EventHandler(this.cmdUpdateDish_Click);
            // 
            // cmdNewDish
            // 
            this.cmdNewDish.Location = new System.Drawing.Point(549, 273);
            this.cmdNewDish.Margin = new System.Windows.Forms.Padding(2);
            this.cmdNewDish.Name = "cmdNewDish";
            this.cmdNewDish.Size = new System.Drawing.Size(114, 31);
            this.cmdNewDish.TabIndex = 18;
            this.cmdNewDish.Text = "מנה חדשה";
            this.cmdNewDish.UseVisualStyleBackColor = true;
            this.cmdNewDish.Click += new System.EventHandler(this.cmdNewDish_Click);
            // 
            // FrmDishMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(697, 315);
            this.Controls.Add(this.cmdNewDish);
            this.Controls.Add(this.cmdUpdateDish);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbDishType);
            this.Controls.Add(this.txtDishPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDishName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmdAddDish);
            this.Controls.Add(this.lblDessert);
            this.Controls.Add(this.lstDessert);
            this.Controls.Add(this.lblSideDish);
            this.Controls.Add(this.lstSideDish);
            this.Controls.Add(this.lblMainCourse);
            this.Controls.Add(this.lstMainCourse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstAppetizer);
            this.Font = new System.Drawing.Font("Trebuchet MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmDishMenu";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "ניהול מנות";
            this.Load += new System.EventHandler(this.FrmDishMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstAppetizer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMainCourse;
        private System.Windows.Forms.ListBox lstMainCourse;
        private System.Windows.Forms.Label lblSideDish;
        private System.Windows.Forms.ListBox lstSideDish;
        private System.Windows.Forms.Label lblDessert;
        private System.Windows.Forms.ListBox lstDessert;
        private System.Windows.Forms.Button cmdAddDish;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDishName;
        private System.Windows.Forms.TextBox txtDishPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDishType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.Button cmdUpdateDish;
        private System.Windows.Forms.Button cmdNewDish;
    }
}