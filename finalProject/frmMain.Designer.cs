namespace finalProject
{
    partial class frmRestaurant
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.מערכתToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DishDataMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.הזמנותToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WaiterMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KitchenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.מערכתToolStripMenuItem,
            this.הזמנותToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // מערכתToolStripMenuItem
            // 
            this.מערכתToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DishDataMenuItem,
            this.AboutMenuItem,
            this.ExitMenuItem});
            this.מערכתToolStripMenuItem.Name = "מערכתToolStripMenuItem";
            this.מערכתToolStripMenuItem.Size = new System.Drawing.Size(80, 29);
            this.מערכתToolStripMenuItem.Text = "מערכת";
            // 
            // DishDataMenuItem
            // 
            this.DishDataMenuItem.Name = "DishDataMenuItem";
            this.DishDataMenuItem.Size = new System.Drawing.Size(191, 30);
            this.DishDataMenuItem.Text = "ניהול תפריט";
            this.DishDataMenuItem.Click += new System.EventHandler(this.DishDataMenuItem_Click);
            // 
            // AboutMenuItem
            // 
            this.AboutMenuItem.Name = "AboutMenuItem";
            this.AboutMenuItem.Size = new System.Drawing.Size(191, 30);
            this.AboutMenuItem.Text = "אודות";
            this.AboutMenuItem.Click += new System.EventHandler(this.AboutMenuItem_Click);
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(191, 30);
            this.ExitMenuItem.Text = "יציאה";
            this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // הזמנותToolStripMenuItem
            // 
            this.הזמנותToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WaiterMenuItem,
            this.KitchenMenuItem});
            this.הזמנותToolStripMenuItem.Name = "הזמנותToolStripMenuItem";
            this.הזמנותToolStripMenuItem.Size = new System.Drawing.Size(79, 29);
            this.הזמנותToolStripMenuItem.Text = "הזמנות";
            // 
            // WaiterMenuItem
            // 
            this.WaiterMenuItem.Name = "WaiterMenuItem";
            this.WaiterMenuItem.Size = new System.Drawing.Size(142, 30);
            this.WaiterMenuItem.Text = "מלצר";
            this.WaiterMenuItem.Click += new System.EventHandler(this.WaiterMenuItem_Click);
            // 
            // KitchenMenuItem
            // 
            this.KitchenMenuItem.Name = "KitchenMenuItem";
            this.KitchenMenuItem.Size = new System.Drawing.Size(142, 30);
            this.KitchenMenuItem.Text = "מטבח";
            this.KitchenMenuItem.Click += new System.EventHandler(this.KitchenMenuItem_Click);
            // 
            // frmRestaurant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmRestaurant";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "בוב המזמין";
            this.Load += new System.EventHandler(this.frmRestaurant_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem מערכתToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem הזמנותToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WaiterMenuItem;
        private System.Windows.Forms.ToolStripMenuItem KitchenMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DishDataMenuItem;
    }
}

