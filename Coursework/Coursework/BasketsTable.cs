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
    public partial class BasketsTable : Form
    {
        DataTable dataTable;
        Database database;
        NpgsqlCommand command;
        NpgsqlDataAdapter adapter;
        public BasketsTable()
        {
            InitializeComponent();
            dataTable = new DataTable();
            database = new Database();
            command = new NpgsqlCommand("SELECT * FROM baskets ORDER BY id", database.getConnection());
            adapter = new NpgsqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(dataTable);
            baskets.DataSource = dataTable;
        }

        private void InsertValue_Click(object sender, EventArgs e)
        {
            int userIdValue = Convert.ToInt32(UserIdBox.Text.Trim());
            command = new NpgsqlCommand(@"
INSERT INTO baskets(user_id)
VALUES (@UserId)",
database.getConnection());
            command.Parameters.Add("@UserId",NpgsqlDbType.Integer).Value=userIdValue;
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

        private void RefreshData_Click(object sender, EventArgs e)
        {
            command = new NpgsqlCommand("SELECT * FROM baskets ORDER BY id", database.getConnection());
            adapter = new NpgsqlDataAdapter();
            dataTable = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(dataTable);
            baskets.DataSource = dataTable;
        }

        private void DeleteValue_Click(object sender, EventArgs e)
        {
            if (BasketIdBox.Text != String.Empty)
            {
                int basketId = Convert.ToInt32(BasketIdBox.Text.Trim());

                command = new NpgsqlCommand(@"
DELETE FROM baskets
WHERE id = @BasketId",
database.getConnection());
                command.Parameters.Add("@BasketId", NpgsqlDbType.Integer).Value = basketId;

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
            if (BasketIdBox.Text != String.Empty)
            {
                int basketId = Convert.ToInt32(BasketIdBox.Text.Trim());
                int userId = Convert.ToInt32(UserIdBox.Text.Trim());
                command = new NpgsqlCommand(@"
UPDATE baskets
SET user_id = @UserId
WHERE id = @BasketId",
database.getConnection());
                command.Parameters.Add("@UserId", NpgsqlDbType.Integer).Value = userId;
                command.Parameters.Add("@BasketId", NpgsqlDbType.Integer).Value = basketId;
                

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
    }
}
