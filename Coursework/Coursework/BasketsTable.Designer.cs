namespace Coursework
{
    partial class BasketsTable
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
            this.baskets = new System.Windows.Forms.DataGridView();
            this.UserIdBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BasketIdBox = new System.Windows.Forms.TextBox();
            this.InsertValue = new System.Windows.Forms.Button();
            this.DeleteValue = new System.Windows.Forms.Button();
            this.ChangeValue = new System.Windows.Forms.Button();
            this.RefreshData = new System.Windows.Forms.Button();
            this.Success = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.baskets)).BeginInit();
            this.SuspendLayout();
            // 
            // baskets
            // 
            this.baskets.AllowUserToAddRows = false;
            this.baskets.AllowUserToDeleteRows = false;
            this.baskets.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(26)))), ((int)(((byte)(107)))));
            this.baskets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.baskets.Dock = System.Windows.Forms.DockStyle.Top;
            this.baskets.Location = new System.Drawing.Point(0, 0);
            this.baskets.Name = "baskets";
            this.baskets.ReadOnly = true;
            this.baskets.Size = new System.Drawing.Size(357, 309);
            this.baskets.TabIndex = 0;
            // 
            // UserIdBox
            // 
            this.UserIdBox.Location = new System.Drawing.Point(252, 325);
            this.UserIdBox.Name = "UserIdBox";
            this.UserIdBox.Size = new System.Drawing.Size(100, 20);
            this.UserIdBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(192, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "User_id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(5, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Basket_id";
            // 
            // BasketIdBox
            // 
            this.BasketIdBox.Location = new System.Drawing.Point(78, 324);
            this.BasketIdBox.Name = "BasketIdBox";
            this.BasketIdBox.Size = new System.Drawing.Size(100, 20);
            this.BasketIdBox.TabIndex = 4;
            // 
            // InsertValue
            // 
            this.InsertValue.Location = new System.Drawing.Point(12, 361);
            this.InsertValue.Name = "InsertValue";
            this.InsertValue.Size = new System.Drawing.Size(166, 23);
            this.InsertValue.TabIndex = 5;
            this.InsertValue.Text = "Додати запис";
            this.InsertValue.UseVisualStyleBackColor = true;
            this.InsertValue.Click += new System.EventHandler(this.InsertValue_Click);
            // 
            // DeleteValue
            // 
            this.DeleteValue.Location = new System.Drawing.Point(12, 390);
            this.DeleteValue.Name = "DeleteValue";
            this.DeleteValue.Size = new System.Drawing.Size(166, 23);
            this.DeleteValue.TabIndex = 6;
            this.DeleteValue.Text = "Видалити запис";
            this.DeleteValue.UseVisualStyleBackColor = true;
            this.DeleteValue.Click += new System.EventHandler(this.DeleteValue_Click);
            // 
            // ChangeValue
            // 
            this.ChangeValue.Location = new System.Drawing.Point(12, 419);
            this.ChangeValue.Name = "ChangeValue";
            this.ChangeValue.Size = new System.Drawing.Size(166, 23);
            this.ChangeValue.TabIndex = 7;
            this.ChangeValue.Text = "Змінити запис";
            this.ChangeValue.UseVisualStyleBackColor = true;
            this.ChangeValue.Click += new System.EventHandler(this.ChangeValue_Click);
            // 
            // RefreshData
            // 
            this.RefreshData.Location = new System.Drawing.Point(12, 448);
            this.RefreshData.Name = "RefreshData";
            this.RefreshData.Size = new System.Drawing.Size(166, 23);
            this.RefreshData.TabIndex = 8;
            this.RefreshData.Text = "Оновити";
            this.RefreshData.UseVisualStyleBackColor = true;
            this.RefreshData.Click += new System.EventHandler(this.RefreshData_Click);
            // 
            // Success
            // 
            this.Success.AutoSize = true;
            this.Success.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Success.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Success.Location = new System.Drawing.Point(227, 400);
            this.Success.Name = "Success";
            this.Success.Size = new System.Drawing.Size(0, 16);
            this.Success.TabIndex = 9;
            // 
            // BasketsTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(102)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(357, 494);
            this.Controls.Add(this.Success);
            this.Controls.Add(this.RefreshData);
            this.Controls.Add(this.ChangeValue);
            this.Controls.Add(this.DeleteValue);
            this.Controls.Add(this.InsertValue);
            this.Controls.Add(this.BasketIdBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserIdBox);
            this.Controls.Add(this.baskets);
            this.Name = "BasketsTable";
            this.Text = "BasketsTable";
            ((System.ComponentModel.ISupportInitialize)(this.baskets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView baskets;
        private System.Windows.Forms.TextBox UserIdBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BasketIdBox;
        private System.Windows.Forms.Button InsertValue;
        private System.Windows.Forms.Button DeleteValue;
        private System.Windows.Forms.Button ChangeValue;
        private System.Windows.Forms.Button RefreshData;
        private System.Windows.Forms.Label Success;
    }
}