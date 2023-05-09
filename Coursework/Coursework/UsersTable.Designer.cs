namespace Coursework
{
    partial class UsersTable
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
            this.UserIdBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UserNameBox = new System.Windows.Forms.TextBox();
            this.users = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.PhoneBox = new System.Windows.Forms.TextBox();
            this.SurnameBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.UserAddressBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.users)).BeginInit();
            this.SuspendLayout();
            // 
            // Success
            // 
            this.Success.AutoSize = true;
            this.Success.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Success.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Success.Location = new System.Drawing.Point(269, 383);
            this.Success.Name = "Success";
            this.Success.Size = new System.Drawing.Size(0, 16);
            this.Success.TabIndex = 19;
            // 
            // RefreshData
            // 
            this.RefreshData.Location = new System.Drawing.Point(12, 438);
            this.RefreshData.Name = "RefreshData";
            this.RefreshData.Size = new System.Drawing.Size(166, 23);
            this.RefreshData.TabIndex = 18;
            this.RefreshData.Text = "Оновити";
            this.RefreshData.UseVisualStyleBackColor = true;
            this.RefreshData.Click += new System.EventHandler(this.RefreshData_Click);
            // 
            // ChangeValue
            // 
            this.ChangeValue.Location = new System.Drawing.Point(12, 409);
            this.ChangeValue.Name = "ChangeValue";
            this.ChangeValue.Size = new System.Drawing.Size(166, 23);
            this.ChangeValue.TabIndex = 17;
            this.ChangeValue.Text = "Змінити запис";
            this.ChangeValue.UseVisualStyleBackColor = true;
            this.ChangeValue.Click += new System.EventHandler(this.ChangeValue_Click);
            // 
            // DeleteValue
            // 
            this.DeleteValue.Location = new System.Drawing.Point(12, 380);
            this.DeleteValue.Name = "DeleteValue";
            this.DeleteValue.Size = new System.Drawing.Size(166, 23);
            this.DeleteValue.TabIndex = 16;
            this.DeleteValue.Text = "Видалити запис";
            this.DeleteValue.UseVisualStyleBackColor = true;
            this.DeleteValue.Click += new System.EventHandler(this.DeleteValue_Click);
            // 
            // InsertValue
            // 
            this.InsertValue.Location = new System.Drawing.Point(12, 351);
            this.InsertValue.Name = "InsertValue";
            this.InsertValue.Size = new System.Drawing.Size(166, 23);
            this.InsertValue.TabIndex = 15;
            this.InsertValue.Text = "Додати запис";
            this.InsertValue.UseVisualStyleBackColor = true;
            this.InsertValue.Click += new System.EventHandler(this.InsertValue_Click);
            // 
            // UserIdBox
            // 
            this.UserIdBox.Location = new System.Drawing.Point(65, 314);
            this.UserIdBox.Name = "UserIdBox";
            this.UserIdBox.Size = new System.Drawing.Size(100, 20);
            this.UserIdBox.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(5, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "User_id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(183, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Name";
            // 
            // UserNameBox
            // 
            this.UserNameBox.Location = new System.Drawing.Point(230, 313);
            this.UserNameBox.Name = "UserNameBox";
            this.UserNameBox.Size = new System.Drawing.Size(100, 20);
            this.UserNameBox.TabIndex = 11;
            // 
            // users
            // 
            this.users.AllowUserToAddRows = false;
            this.users.AllowUserToDeleteRows = false;
            this.users.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(26)))), ((int)(((byte)(107)))));
            this.users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.users.Dock = System.Windows.Forms.DockStyle.Top;
            this.users.Location = new System.Drawing.Point(0, 0);
            this.users.Name = "users";
            this.users.ReadOnly = true;
            this.users.Size = new System.Drawing.Size(721, 309);
            this.users.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(539, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Phone";
            // 
            // PhoneBox
            // 
            this.PhoneBox.Location = new System.Drawing.Point(591, 315);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(100, 20);
            this.PhoneBox.TabIndex = 21;
            // 
            // SurnameBox
            // 
            this.SurnameBox.Location = new System.Drawing.Point(417, 314);
            this.SurnameBox.Name = "SurnameBox";
            this.SurnameBox.Size = new System.Drawing.Size(100, 20);
            this.SurnameBox.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(350, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Surname";
            // 
            // UserAddressBox
            // 
            this.UserAddressBox.Location = new System.Drawing.Point(417, 357);
            this.UserAddressBox.Name = "UserAddressBox";
            this.UserAddressBox.Size = new System.Drawing.Size(274, 20);
            this.UserAddressBox.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Location = new System.Drawing.Point(353, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Address";
            // 
            // UsersTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(102)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(721, 492);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UserAddressBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SurnameBox);
            this.Controls.Add(this.PhoneBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Success);
            this.Controls.Add(this.RefreshData);
            this.Controls.Add(this.ChangeValue);
            this.Controls.Add(this.DeleteValue);
            this.Controls.Add(this.InsertValue);
            this.Controls.Add(this.UserIdBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserNameBox);
            this.Controls.Add(this.users);
            this.Name = "UsersTable";
            this.Text = "UsersTable";
            ((System.ComponentModel.ISupportInitialize)(this.users)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Success;
        private System.Windows.Forms.Button RefreshData;
        private System.Windows.Forms.Button ChangeValue;
        private System.Windows.Forms.Button DeleteValue;
        private System.Windows.Forms.Button InsertValue;
        private System.Windows.Forms.TextBox UserIdBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UserNameBox;
        private System.Windows.Forms.DataGridView users;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PhoneBox;
        private System.Windows.Forms.TextBox SurnameBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox UserAddressBox;
        private System.Windows.Forms.Label label5;
    }
}