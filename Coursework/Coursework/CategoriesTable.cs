using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    public partial class CategoriesTable : Form
    {
        DataTable dataTable;
        Database database;
        NpgsqlCommand command;
        NpgsqlDataAdapter adapter;
        public CategoriesTable()
        {
            InitializeComponent();
            dataTable = new DataTable();
            database = new Database();
            command = new NpgsqlCommand("SELECT * FROM categories ORDER BY id", database.getConnection());
            adapter = new NpgsqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(dataTable);
            categories.DataSource = dataTable;
        }

        private void InsertValue_Click(object sender, EventArgs e)
        {
            string categoryName = CategoryNameBox.Text.Trim();
            command = new NpgsqlCommand(@"
INSERT INTO categories(name)
VALUES (@CategoryName)",
database.getConnection());
            command.Parameters.Add("@CategoryName", NpgsqlDbType.Varchar).Value = categoryName;
            database.OpenConnection();

            try
            {
                command.ExecuteNonQuery();
                Success.Text = "Запис успішно\n додано";
            }
            catch (Exception)
            {
                Success.Text = "Не вдалося\n додати запис";
            }

            database.CloseConnection();
        }

        private void DeleteValue_Click(object sender, EventArgs e)
        {
            if (CategoryIdBox.Text != String.Empty)
            {
                int categoryId = Convert.ToInt32(CategoryIdBox.Text.Trim());

                command = new NpgsqlCommand(@"
DELETE FROM categories
WHERE id = @CategoryId",
database.getConnection());
                command.Parameters.Add("@CategoryId", NpgsqlDbType.Integer).Value = categoryId;

                database.OpenConnection();

                try
                {
                    command.ExecuteNonQuery();
                    Success.Text = "Запис успішно\n видалено";
                }
                catch (Exception)
                {
                    Success.Text = "Не вдалося\n видалити запис";
                }

                database.CloseConnection();
            }
            else
            {
                Success.Text = "Не вдалося\n видалити запис";
            }
        }

        private void ChangeValue_Click(object sender, EventArgs e)
        {
            if (CategoryIdBox.Text != String.Empty)
            {
                int categoryId = Convert.ToInt32(CategoryIdBox.Text.Trim());
                string categoryName = CategoryNameBox.Text.Trim();
                command = new NpgsqlCommand(@"
UPDATE categories
SET name = @CategoryName
WHERE id = @CategoryId",
database.getConnection());
                command.Parameters.Add("@CategoryId", NpgsqlDbType.Integer).Value = categoryId;
                command.Parameters.Add("@CategoryName", NpgsqlDbType.Varchar).Value = categoryName;

                database.OpenConnection();

                try
                {
                    command.ExecuteNonQuery();
                    Success.Text = "Запис успішно\n змінено";
                }
                catch (Exception)
                {
                    Success.Text = "Не вдалося\n змінити запис";
                }

                database.CloseConnection();
            }
            else
            {
                Success.Text = "Не вдалося\n змінити запис";
            }
        }

        private void RefreshData_Click(object sender, EventArgs e)
        {
            command = new NpgsqlCommand("SELECT * FROM categories ORDER BY id", database.getConnection());
            adapter = new NpgsqlDataAdapter();
            dataTable = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(dataTable);
            categories.DataSource = dataTable;
        }
    }
}
