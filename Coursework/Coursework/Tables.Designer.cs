namespace Coursework
{
    partial class Tables
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
            this.Baskets = new System.Windows.Forms.Button();
            this.Baskets_food = new System.Windows.Forms.Button();
            this.Categories = new System.Windows.Forms.Button();
            this.Companies = new System.Windows.Forms.Button();
            this.Food = new System.Windows.Forms.Button();
            this.Orders = new System.Windows.Forms.Button();
            this.Users = new System.Windows.Forms.Button();
            this.Couriers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Baskets
            // 
            this.Baskets.Location = new System.Drawing.Point(72, 37);
            this.Baskets.Name = "Baskets";
            this.Baskets.Size = new System.Drawing.Size(82, 56);
            this.Baskets.TabIndex = 0;
            this.Baskets.Text = "Baskets";
            this.Baskets.UseVisualStyleBackColor = true;
            this.Baskets.Click += new System.EventHandler(this.Baskets_Click);
            // 
            // Baskets_food
            // 
            this.Baskets_food.Location = new System.Drawing.Point(184, 37);
            this.Baskets_food.Name = "Baskets_food";
            this.Baskets_food.Size = new System.Drawing.Size(82, 56);
            this.Baskets_food.TabIndex = 1;
            this.Baskets_food.Text = "Baskets_food";
            this.Baskets_food.UseVisualStyleBackColor = true;
            this.Baskets_food.Click += new System.EventHandler(this.Baskets_food_Click);
            // 
            // Categories
            // 
            this.Categories.Location = new System.Drawing.Point(285, 37);
            this.Categories.Name = "Categories";
            this.Categories.Size = new System.Drawing.Size(82, 56);
            this.Categories.TabIndex = 2;
            this.Categories.Text = "Categories";
            this.Categories.UseVisualStyleBackColor = true;
            this.Categories.Click += new System.EventHandler(this.Categories_Click);
            // 
            // Companies
            // 
            this.Companies.Location = new System.Drawing.Point(72, 117);
            this.Companies.Name = "Companies";
            this.Companies.Size = new System.Drawing.Size(82, 56);
            this.Companies.TabIndex = 3;
            this.Companies.Text = "Companies";
            this.Companies.UseVisualStyleBackColor = true;
            this.Companies.Click += new System.EventHandler(this.Companies_Click);
            // 
            // Food
            // 
            this.Food.Location = new System.Drawing.Point(184, 117);
            this.Food.Name = "Food";
            this.Food.Size = new System.Drawing.Size(82, 56);
            this.Food.TabIndex = 4;
            this.Food.Text = "Food";
            this.Food.UseVisualStyleBackColor = true;
            this.Food.Click += new System.EventHandler(this.Food_Click);
            // 
            // Orders
            // 
            this.Orders.Location = new System.Drawing.Point(285, 117);
            this.Orders.Name = "Orders";
            this.Orders.Size = new System.Drawing.Size(82, 56);
            this.Orders.TabIndex = 5;
            this.Orders.Text = "Orders";
            this.Orders.UseVisualStyleBackColor = true;
            this.Orders.Click += new System.EventHandler(this.Orders_Click);
            // 
            // Users
            // 
            this.Users.Location = new System.Drawing.Point(72, 188);
            this.Users.Name = "Users";
            this.Users.Size = new System.Drawing.Size(82, 56);
            this.Users.TabIndex = 6;
            this.Users.Text = "Users";
            this.Users.UseVisualStyleBackColor = true;
            this.Users.Click += new System.EventHandler(this.Users_Click);
            // 
            // Couriers
            // 
            this.Couriers.Location = new System.Drawing.Point(184, 188);
            this.Couriers.Name = "Couriers";
            this.Couriers.Size = new System.Drawing.Size(82, 56);
            this.Couriers.TabIndex = 7;
            this.Couriers.Text = "Couriers";
            this.Couriers.UseVisualStyleBackColor = true;
            this.Couriers.Click += new System.EventHandler(this.Couriers_Click);
            // 
            // Tables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(436, 306);
            this.Controls.Add(this.Couriers);
            this.Controls.Add(this.Users);
            this.Controls.Add(this.Orders);
            this.Controls.Add(this.Food);
            this.Controls.Add(this.Companies);
            this.Controls.Add(this.Categories);
            this.Controls.Add(this.Baskets_food);
            this.Controls.Add(this.Baskets);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Tables";
            this.Text = "Tables";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Baskets;
        private System.Windows.Forms.Button Baskets_food;
        private System.Windows.Forms.Button Categories;
        private System.Windows.Forms.Button Companies;
        private System.Windows.Forms.Button Food;
        private System.Windows.Forms.Button Orders;
        private System.Windows.Forms.Button Users;
        private System.Windows.Forms.Button Couriers;
    }
}

