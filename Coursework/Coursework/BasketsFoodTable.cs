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
    public partial class BasketsFoodTable : Form
    {
        DataTable dataTable;
        Database database;
        NpgsqlCommand command;
        NpgsqlDataAdapter adapter;
        public BasketsFoodTable()
        {
            InitializeComponent();
            dataTable = new DataTable();
            database = new Database();
            command = new NpgsqlCommand("SELECT * FROM baskets_food ORDER BY basket_id", database.getConnection());
            adapter = new NpgsqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(dataTable);
            basketsFood.DataSource = dataTable;
        }

        private void InsertValue_Click(object sender, EventArgs e)
        {
            int basketId = Convert.ToInt32(BasketIdBox.Text.Trim());
            int foodId = Convert.ToInt32(FoodIdBox.Text.Trim());
            int foodAmount = Convert.ToInt32(FoodAmountBox.Text.Trim());
            command = new NpgsqlCommand(@"
INSERT INTO baskets_food(basket_id, food_id, food_amount)
VALUES (@BasketId, @FoodId, @FoodAmount)",
database.getConnection());
            command.Parameters.Add("@BasketId", NpgsqlDbType.Integer).Value = basketId;
            command.Parameters.Add("@FoodId", NpgsqlDbType.Integer).Value = foodId;
            command.Parameters.Add("@FoodAmount", NpgsqlDbType.Integer).Value = foodAmount;
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
            int basketId = Convert.ToInt32(BasketIdBox.Text.Trim());
            int foodId = Convert.ToInt32(FoodIdBox.Text.Trim());
            command = new NpgsqlCommand(@"
DELETE FROM baskets_food
WHERE basket_id = @BasketId AND food_id = @FoodId",
database.getConnection());
            command.Parameters.Add("@BasketId", NpgsqlDbType.Integer).Value = basketId;
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

        private void RefreshData_Click(object sender, EventArgs e)
        {
            command = new NpgsqlCommand("SELECT * FROM baskets_food ORDER BY basket_id", database.getConnection());
            adapter = new NpgsqlDataAdapter();
            dataTable = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(dataTable);
            basketsFood.DataSource = dataTable;
        }

        private void ChangeValue_Click(object sender, EventArgs e)
        {
            int foodId = Convert.ToInt32(FoodIdBox.Text.Trim());
            int basketId = Convert.ToInt32(BasketIdBox.Text.Trim());
            int foodAmount = Convert.ToInt32(FoodAmountBox.Text.Trim());
            command = new NpgsqlCommand(@"
UPDATE baskets_food
SET food_amount = @FoodAmount
WHERE basket_id = @BasketId AND food_id = @FoodId",
database.getConnection());
            command.Parameters.Add("@BasketId", NpgsqlDbType.Integer).Value = basketId;
            command.Parameters.Add("@FoodId", NpgsqlDbType.Integer).Value = foodId;
            command.Parameters.Add("@FoodAmount", NpgsqlDbType.Integer).Value = foodAmount;

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
    }
}

