namespace Coursework
{
    partial class CouriersTable
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
            this.CourierPhoneBox = new System.Windows.Forms.TextBox();
            this.CourierSurnameBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Success = new System.Windows.Forms.Label();
            this.RefreshData = new System.Windows.Forms.Button();
            this.ChangeValue = new System.Windows.Forms.Button();
            this.DeleteValue = new System.Windows.Forms.Button();
            this.InsertValue = new System.Windows.Forms.Button();
            this.CourierIdBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.couriers = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.CourierNameBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.couriers)).BeginInit();
            this.SuspendLayout();
            // 
            // CourierPhoneBox
            // 
            this.CourierPhoneBox.Location = new System.Drawing.Point(440, 347);
            this.CourierPhoneBox.Name = "CourierPhoneBox";
            this.CourierPhoneBox.Size = new System.Drawing.Size(100, 20);
            this.CourierPhoneBox.TabIndex = 56;
            // 
            // CourierSurnameBox
            // 
            this.CourierSurnameBox.Location = new System.Drawing.Point(440, 312);
            this.CourierSurnameBox.Name = "CourierSurnameBox";
            this.CourierSurnameBox.Size = new System.Drawing.Size(100, 20);
            this.CourierSurnameBox.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(388, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 54;
            this.label4.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(373, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 53;
            this.label3.Text = "Surname";
            // 
            // Success
            // 
            this.Success.AutoSize = true;
            this.Success.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Success.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Success.Location = new System.Drawing.Point(227, 384);
            this.Success.Name = "Success";
            this.Success.Size = new System.Drawing.Size(0, 16);
            this.Success.TabIndex = 52;
            // 
            // RefreshData
            // 
            this.RefreshData.Location = new System.Drawing.Point(12, 432);
            this.RefreshData.Name = "RefreshData";
            this.RefreshData.Size = new System.Drawing.Size(166, 23);
            this.RefreshData.TabIndex = 51;
            this.RefreshData.Text = "Оновити";
            this.RefreshData.UseVisualStyleBackColor = true;
            this.RefreshData.Click += new System.EventHandler(this.RefreshData_Click);
            // 
            // ChangeValue
            // 
            this.ChangeValue.Location = new System.Drawing.Point(12, 403);
            this.ChangeValue.Name = "ChangeValue";
            this.ChangeValue.Size = new System.Drawing.Size(166, 23);
            this.ChangeValue.TabIndex = 50;
            this.ChangeValue.Text = "Змінити запис";
            this.ChangeValue.UseVisualStyleBackColor = true;
            this.ChangeValue.Click += new System.EventHandler(this.ChangeValue_Click);
            // 
            // DeleteValue
            // 
            this.DeleteValue.Location = new System.Drawing.Point(12, 374);
            this.DeleteValue.Name = "DeleteValue";
            this.DeleteValue.Size = new System.Drawing.Size(166, 23);
            this.DeleteValue.TabIndex = 49;
            this.DeleteValue.Text = "Видалити запис";
            this.DeleteValue.UseVisualStyleBackColor = true;
            this.DeleteValue.Click += new System.EventHandler(this.DeleteValue_Click);
            // 
            // InsertValue
            // 
            this.InsertValue.Location = new System.Drawing.Point(12, 345);
            this.InsertValue.Name = "InsertValue";
            this.InsertValue.Size = new System.Drawing.Size(166, 23);
            this.InsertValue.TabIndex = 48;
            this.InsertValue.Text = "Додати запис";
            this.InsertValue.UseVisualStyleBackColor = true;
            this.InsertValue.Click += new System.EventHandler(this.InsertValue_Click);
            // 
            // CourierIdBox
            // 
            this.CourierIdBox.Location = new System.Drawing.Point(83, 312);
            this.CourierIdBox.Name = "CourierIdBox";
            this.CourierIdBox.Size = new System.Drawing.Size(100, 20);
            this.CourierIdBox.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(204, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 46;
            this.label1.Text = "Name";
            // 
            // couriers
            // 
            this.couriers.AllowUserToAddRows = false;
            this.couriers.AllowUserToDeleteRows = false;
            this.couriers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(26)))), ((int)(((byte)(107)))));
            this.couriers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.couriers.Dock = System.Windows.Forms.DockStyle.Top;
            this.couriers.Location = new System.Drawing.Point(0, 0);
            this.couriers.Name = "couriers";
            this.couriers.ReadOnly = true;
            this.couriers.Size = new System.Drawing.Size(581, 309);
            this.couriers.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(9, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 58;
            this.label2.Text = "Courier_id";
            // 
            // CourierNameBox
            // 
            this.CourierNameBox.Location = new System.Drawing.Point(254, 312);
            this.CourierNameBox.Name = "CourierNameBox";
            this.CourierNameBox.Size = new System.Drawing.Size(100, 20);
            this.CourierNameBox.TabIndex = 59;
            // 
            // CouriersTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(102)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(581, 481);
            this.Controls.Add(this.CourierNameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CourierPhoneBox);
            this.Controls.Add(this.CourierSurnameBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Success);
            this.Controls.Add(this.RefreshData);
            this.Controls.Add(this.ChangeValue);
            this.Controls.Add(this.DeleteValue);
            this.Controls.Add(this.InsertValue);
            this.Controls.Add(this.CourierIdBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.couriers);
            this.Name = "CouriersTable";
            this.Text = "CouriersTable";
            ((System.ComponentModel.ISupportInitialize)(this.couriers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox CourierPhoneBox;
        private System.Windows.Forms.TextBox CourierSurnameBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Success;
        private System.Windows.Forms.Button RefreshData;
        private System.Windows.Forms.Button ChangeValue;
        private System.Windows.Forms.Button DeleteValue;
        private System.Windows.Forms.Button InsertValue;
        private System.Windows.Forms.TextBox CourierIdBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView couriers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CourierNameBox;
    }
}