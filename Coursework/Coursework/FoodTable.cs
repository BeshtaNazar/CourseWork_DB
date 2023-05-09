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
    public partial class FoodTable : Form
    {
        DataTable dataTable;
        Database database;
        NpgsqlCommand command;
        NpgsqlDataAdapter adapter;
        public FoodTable()
        {
            InitializeComponent();
            dataTable = new DataTable();
            database = new Database();
            command = new NpgsqlCommand("SELECT * FROM food ORDER BY id", database.getConnection());
            adapter = new NpgsqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(dataTable);
            food.DataSource = dataTable;
        }

        private void InsertValue_Click(object sender, EventArgs e)
        {
            string foodName = FoodNameBox.Text.Trim();
            int foodCost = Convert.ToInt32(FoodCostBox.Text.Trim());
            int companyId = Convert.ToInt32(CompanyIdBox.Text.Trim());
            int categoryId = Convert.ToInt32(CategoryIdBox.Text.Trim());
            command = new NpgsqlCommand(@"
INSERT INTO food(name, cost, company_id, category_id)
VALUES (@FoodName, @FoodCost, @CompanyId, @CategoryId)",
database.getConnection());
            command.Parameters.Add("@FoodName", NpgsqlDbType.Varchar).Value = foodName;
            command.Parameters.Add("@FoodCost", NpgsqlDbType.Integer).Value = foodCost;
            command.Parameters.Add("@CompanyId", NpgsqlDbType.Integer).Value = companyId;
            command.Parameters.Add("@CategoryId", NpgsqlDbType.Integer).Value = categoryId;
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
            if (FoodIdBox.Text != String.Empty)
            {
                int foodId = Convert.ToInt32(FoodIdBox.Text.Trim());

                command = new NpgsqlCommand(@"
DELETE FROM food
WHERE id = @FoodId",
database.getConnection());
                command.Parameters.Add("@FoodId", NpgsqlDbType.Integer).Value = foodId;

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
            if (FoodIdBox.Text != String.Empty)
            {
                int foodId = Convert.ToInt32(FoodIdBox.Text.Trim());
                string foodName = FoodNameBox.Text.Trim();
                int foodCost = Convert.ToInt32(FoodCostBox.Text.Trim());
                int companyId = Convert.ToInt32(CompanyIdBox.Text.Trim());
                int categoryId = Convert.ToInt32(CategoryIdBox.Text.Trim());
                command = new NpgsqlCommand(@"
UPDATE food
SET name = @FoodName, cost = @FoodCost, company_id = @CompanyId, category_id = @CategoryId
WHERE id = @FoodId",
database.getConnection());
                command.Parameters.Add("@FoodId", NpgsqlDbType.Integer).Value = foodId;
                command.Parameters.Add("@FoodName", NpgsqlDbType.Varchar).Value = foodName;
                command.Parameters.Add("@FoodCost", NpgsqlDbType.Integer).Value = foodCost;
                command.Parameters.Add("@CompanyId", NpgsqlDbType.Integer).Value = companyId;
                command.Parameters.Add("@CategoryId", NpgsqlDbType.Integer).Value = categoryId;

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
            command = new NpgsqlCommand("SELECT * FROM food ORDER BY id", database.getConnection());
            adapter = new NpgsqlDataAdapter();
            dataTable = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(dataTable);
            food.DataSource = dataTable;
        }
    }
}
