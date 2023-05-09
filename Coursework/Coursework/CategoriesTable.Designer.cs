namespace Coursework
{
    partial class CategoriesTable
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
            this.CategoryIdBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CategoryNameBox = new System.Windows.Forms.TextBox();
            this.categories = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.categories)).BeginInit();
            this.SuspendLayout();
            // 
            // Success
            // 
            this.Success.AutoSize = true;
            this.Success.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Success.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Success.Location = new System.Drawing.Point(227, 399);
            this.Success.Name = "Success";
            this.Success.Size = new System.Drawing.Size(0, 16);
            this.Success.TabIndex = 29;
            // 
            // RefreshData
            // 
            this.RefreshData.Location = new System.Drawing.Point(12, 447);
            this.RefreshData.Name = "RefreshData";
            this.RefreshData.Size = new System.Drawing.Size(166, 23);
            this.RefreshData.TabIndex = 28;
            this.RefreshData.Text = "Оновити";
            this.RefreshData.UseVisualStyleBackColor = true;
            this.RefreshData.Click += new System.EventHandler(this.RefreshData_Click);
            // 
            // ChangeValue
            // 
            this.ChangeValue.Location = new System.Drawing.Point(12, 418);
            this.ChangeValue.Name = "ChangeValue";
            this.ChangeValue.Size = new System.Drawing.Size(166, 23);
            this.ChangeValue.TabIndex = 27;
            this.ChangeValue.Text = "Змінити запис";
            this.ChangeValue.UseVisualStyleBackColor = true;
            this.ChangeValue.Click += new System.EventHandler(this.ChangeValue_Click);
            // 
            // DeleteValue
            // 
            this.DeleteValue.Location = new System.Drawing.Point(12, 389);
            this.DeleteValue.Name = "DeleteValue";
            this.DeleteValue.Size = new System.Drawing.Size(166, 23);
            this.DeleteValue.TabIndex = 26;
            this.DeleteValue.Text = "Видалити запис";
            this.DeleteValue.UseVisualStyleBackColor = true;
            this.DeleteValue.Click += new System.EventHandler(this.DeleteValue_Click);
            // 
            // InsertValue
            // 
            this.InsertValue.Location = new System.Drawing.Point(12, 360);
            this.InsertValue.Name = "InsertValue";
            this.InsertValue.Size = new System.Drawing.Size(166, 23);
            this.InsertValue.TabIndex = 25;
            this.InsertValue.Text = "Додати запис";
            this.InsertValue.UseVisualStyleBackColor = true;
            this.InsertValue.Click += new System.EventHandler(this.InsertValue_Click);
            // 
            // CategoryIdBox
            // 
            this.CategoryIdBox.Location = new System.Drawing.Point(94, 323);
            this.CategoryIdBox.Name = "CategoryIdBox";
            this.CategoryIdBox.Size = new System.Drawing.Size(100, 20);
            this.CategoryIdBox.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(5, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Category_id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(212, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Name";
            // 
            // CategoryNameBox
            // 
            this.CategoryNameBox.Location = new System.Drawing.Point(262, 323);
            this.CategoryNameBox.Name = "CategoryNameBox";
            this.CategoryNameBox.Size = new System.Drawing.Size(100, 20);
            this.CategoryNameBox.TabIndex = 21;
            // 
            // categories
            // 
            this.categories.AllowUserToAddRows = false;
            this.categories.AllowUserToDeleteRows = false;
            this.categories.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(26)))), ((int)(((byte)(107)))));
            this.categories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categories.Dock = System.Windows.Forms.DockStyle.Top;
            this.categories.Location = new System.Drawing.Point(0, 0);
            this.categories.Name = "categories";
            this.categories.ReadOnly = true;
            this.categories.Size = new System.Drawing.Size(401, 309);
            this.categories.TabIndex = 20;
            // 
            // CategoriesTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(102)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(401, 495);
            this.Controls.Add(this.Success);
            this.Controls.Add(this.RefreshData);
            this.Controls.Add(this.ChangeValue);
            this.Controls.Add(this.DeleteValue);
            this.Controls.Add(this.InsertValue);
            this.Controls.Add(this.CategoryIdBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CategoryNameBox);
            this.Controls.Add(this.categories);
            this.Name = "CategoriesTable";
            this.Text = "CategoriesTable";
            ((System.ComponentModel.ISupportInitialize)(this.categories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Success;
        private System.Windows.Forms.Button RefreshData;
        private System.Windows.Forms.Button ChangeValue;
        private System.Windows.Forms.Button DeleteValue;
        private System.Windows.Forms.Button InsertValue;
        private System.Windows.Forms.TextBox CategoryIdBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CategoryNameBox;
        private System.Windows.Forms.DataGridView categories;
    }
}