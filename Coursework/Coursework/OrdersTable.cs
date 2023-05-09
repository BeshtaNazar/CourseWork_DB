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
    public partial class OrdersTable : Form
    {
        DataTable dataTable;
        Database database;
        NpgsqlCommand command;
        NpgsqlDataAdapter adapter;
        public OrdersTable()
        {
            InitializeComponent();
            dataTable = new DataTable();
            database = new Database();
            command = new NpgsqlCommand("SELECT * FROM orders ORDER BY id", database.getConnection());
            adapter = new NpgsqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(dataTable);
            orders.DataSource = dataTable;
        }

        private void InsertValue_Click(object sender, EventArgs e)
        {
            string orderStatus = OrderStatusBox.Text.Trim();
            int userId = Convert.ToInt32(UserIdBox.Text.Trim());
            int basketId = Convert.ToInt32(BasketIdBox.Text.Trim());
            int courierId = Convert.ToInt32(CourierIdBox.Text.Trim());
            command = new NpgsqlCommand(@"
INSERT INTO orders(status, user_id, basket_id, courier_id)
VALUES (@OrderStatus, @UserId, @BasketId, @CourierId)",
database.getConnection());
            command.Parameters.Add("@OrderStatus", NpgsqlDbType.Varchar).Value = orderStatus;
            command.Parameters.Add("@UserId", NpgsqlDbType.Integer).Value = userId;
            command.Parameters.Add("@BasketId", NpgsqlDbType.Integer).Value = basketId;
            command.Parameters.Add("@CourierId", NpgsqlDbType.Integer).Value = courierId;

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
            if (OrderIdBox.Text != String.Empty)
            {
                int orderId = Convert.ToInt32(OrderIdBox.Text.Trim());

                command = new NpgsqlCommand(@"
DELETE FROM orders
WHERE id = @OrderId",
database.getConnection());
                command.Parameters.Add("@OrderId", NpgsqlDbType.Integer).Value = orderId;

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
            if (OrderIdBox.Text != String.Empty)
            {
                int orderId = Convert.ToInt32(OrderIdBox.Text.Trim());
                string orderStatus = OrderStatusBox.Text.Trim();
                int userId = Convert.ToInt32(UserIdBox.Text.Trim());
                int basketId = Convert.ToInt32(BasketIdBox.Text.Trim());
                int courierId = Convert.ToInt32(CourierIdBox.Text.Trim());
                command = new NpgsqlCommand(@"
UPDATE orders
SET status = @OrderStatus, user_id = @UserId, basket_id = @BasketId, courier_id = @CourierId
WHERE id = @OrderId",
database.getConnection());
                command.Parameters.Add("@OrderId", NpgsqlDbType.Integer).Value = orderId;
                command.Parameters.Add("@OrderStatus", NpgsqlDbType.Varchar).Value = orderStatus;
                command.Parameters.Add("@UserId", NpgsqlDbType.Integer).Value = userId;
                command.Parameters.Add("@BasketId", NpgsqlDbType.Integer).Value = basketId;
                command.Parameters.Add("@CourierId", NpgsqlDbType.Integer).Value = courierId;

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
            command = new NpgsqlCommand("SELECT * FROM orders ORDER BY id", database.getConnection());
            adapter = new NpgsqlDataAdapter();
            dataTable = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(dataTable);
            orders.DataSource = dataTable;
        }
    }
}
