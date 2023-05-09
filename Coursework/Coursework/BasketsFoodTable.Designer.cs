namespace Coursework
{
    partial class BasketsFoodTable
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
            this.Success = new System.Windows.Forms.Label();
            this.RefreshData = new System.Windows.Forms.Button();
            this.ChangeValue = new System.Windows.Forms.Button();
            this.DeleteValue = new System.Windows.Forms.Button();
            this.InsertValue = new System.Windows.Forms.Button();
            this.BasketIdBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FoodIdBox = new System.Windows.Forms.TextBox();
            this.basketsFood = new System.Windows.Forms.DataGridView();
            this.FoodAmountBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.basketsFood)).BeginInit();
            this.SuspendLayout();
            // 
            // Success
            // 
            this.Success.AutoSize = true;
            this.Success.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Success.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Success.Location = new System.Drawing.Point(227, 389);
            this.Success.Name = "Success";
            this.Success.Size = new System.Drawing.Size(0, 16);
            this.Success.TabIndex = 39;
            // 
            // RefreshData
            // 
            this.RefreshData.Location = new System.Drawing.Point(12, 437);
            this.RefreshData.Name = "RefreshData";
            this.RefreshData.Size = new System.Drawing.Size(166, 23);
            this.RefreshData.TabIndex = 38;
            this.RefreshData.Text = "Оновити";
            this.RefreshData.UseVisualStyleBackColor = true;
            this.RefreshData.Click += new System.EventHandler(this.RefreshData_Click);
            // 
            // ChangeValue
            // 
            this.ChangeValue.Location = new System.Drawing.Point(12, 408);
            this.ChangeValue.Name = "ChangeValue";
            this.ChangeValue.Size = new System.Drawing.Size(166, 23);
            this.ChangeValue.TabIndex = 37;
            this.ChangeValue.Text = "Змінити запис";
            this.ChangeValue.UseVisualStyleBackColor = true;
            this.ChangeValue.Click += new System.EventHandler(this.ChangeValue_Click);
            // 
            // DeleteValue
            // 
            this.DeleteValue.Location = new System.Drawing.Point(12, 379);
            this.DeleteValue.Name = "DeleteValue";
            this.DeleteValue.Size = new System.Drawing.Size(166, 23);
            this.DeleteValue.TabIndex = 36;
            this.DeleteValue.Text = "Видалити запис";
            this.DeleteValue.UseVisualStyleBackColor = true;
            this.DeleteValue.Click += new System.EventHandler(this.DeleteValue_Click);
            // 
            // InsertValue
            // 
            this.InsertValue.Location = new System.Drawing.Point(12, 350);
            this.InsertValue.Name = "InsertValue";
            this.InsertValue.Size = new System.Drawing.Size(166, 23);
            this.InsertValue.TabIndex = 35;
            this.InsertValue.Text = "Додати запис";
            this.InsertValue.UseVisualStyleBackColor = true;
            this.InsertValue.Click += new System.EventHandler(this.InsertValue_Click);
            // 
            // BasketIdBox
            // 
            this.BasketIdBox.Location = new System.Drawing.Point(78, 313);
            this.BasketIdBox.Name = "BasketIdBox";
            this.BasketIdBox.Size = new System.Drawing.Size(100, 20);
            this.BasketIdBox.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(5, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "Basket_id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(202, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "Food_id";
            // 
            // FoodIdBox
            // 
            this.FoodIdBox.Location = new System.Drawing.Point(265, 313);
            this.FoodIdBox.Name = "FoodIdBox";
            this.FoodIdBox.Size = new System.Drawing.Size(100, 20);
            this.FoodIdBox.TabIndex = 31;
            // 
            // basketsFood
            // 
            this.basketsFood.AllowUserToAddRows = false;
            this.basketsFood.AllowUserToDeleteRows = false;
            this.basketsFood.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(26)))), ((int)(((byte)(107)))));
            this.basketsFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.basketsFood.Dock = System.Windows.Forms.DockStyle.Top;
            this.basketsFood.Location = new System.Drawing.Point(0, 0);
            this.basketsFood.Name = "basketsFood";
            this.basketsFood.ReadOnly = true;
            this.basketsFood.Size = new System.Drawing.Size(598, 309);
            this.basketsFood.TabIndex = 30;
            // 
            // FoodAmountBox
            // 
            this.FoodAmountBox.Location = new System.Drawing.Point(486, 313);
            this.FoodAmountBox.Name = "FoodAmountBox";
            this.FoodAmountBox.Size = new System.Drawing.Size(100, 20);
            this.FoodAmountBox.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(390, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 42;
            this.label3.Text = "Food_amount";
            // 
            // BasketsFoodTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(102)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(598, 479);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FoodAmountBox);
            this.Controls.Add(this.Success);
            this.Controls.Add(this.RefreshData);
            this.Controls.Add(this.ChangeValue);
            this.Controls.Add(this.DeleteValue);
            this.Controls.Add(this.InsertValue);
            this.Controls.Add(this.BasketIdBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FoodIdBox);
            this.Controls.Add(this.basketsFood);
            this.Name = "BasketsFoodTable";
            this.Text = "BasketsFoodTable";
            ((System.ComponentModel.ISupportInitialize)(this.basketsFood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Success;
        private System.Windows.Forms.Button RefreshData;
        private System.Windows.Forms.Button ChangeValue;
        private System.Windows.Forms.Button DeleteValue;
        private System.Windows.Forms.Button InsertValue;
        private System.Windows.Forms.TextBox BasketIdBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FoodIdBox;
        private System.Windows.Forms.DataGridView basketsFood;
        private System.Windows.Forms.TextBox FoodAmountBox;
        private System.Windows.Forms.Label label3;
    }
}