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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Coursework
{
    public partial class UsersTable : Form
    {
        DataTable dataTable;
        Database database;
        NpgsqlCommand command;
        NpgsqlDataAdapter adapter;
        public UsersTable()
        {
            InitializeComponent();
            dataTable = new DataTable();
            database = new Database();
            command = new NpgsqlCommand("SELECT * FROM users ORDER BY id", database.getConnection());
            adapter = new NpgsqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(dataTable);
            users.DataSource = dataTable;
        }

        private void InsertValue_Click(object sender, EventArgs e)
        {
            string userName = UserNameBox.Text.Trim();
            string userSurname = SurnameBox.Text.Trim();
            string userPhone = PhoneBox.Text.Trim();
            string userAddress = UserAddressBox.Text.Trim();
            command = new NpgsqlCommand(@"
INSERT INTO users(name, surname, phone, address)
VALUES (@UserName, @UserSurname, @UserPhone, @UserAddress)",
database.getConnection());
            command.Parameters.Add("@UserName", NpgsqlDbType.Varchar).Value = userName;
            command.Parameters.Add("@UserSurname", NpgsqlDbType.Varchar).Value = userSurname;
            command.Parameters.Add("@UserPhone", NpgsqlDbType.Varchar).Value = userPhone;
            command.Parameters.Add("@UserAddress", NpgsqlDbType.Varchar).Value = userAddress;
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
            command = new NpgsqlCommand("SELECT * FROM users ORDER BY id", database.getConnection());
            adapter = new NpgsqlDataAdapter();
            dataTable = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(dataTable);
            users.DataSource = dataTable;
        }

        private void DeleteValue_Click(object sender, EventArgs e)
        {
            if (UserIdBox.Text != String.Empty)
            {
                int userId = Convert.ToInt32(UserIdBox.Text.Trim());

                command = new NpgsqlCommand(@"
DELETE FROM users
WHERE id = @UserId",
database.getConnection());
                command.Parameters.Add("@UserId", NpgsqlDbType.Integer).Value = userId;

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
            if (UserIdBox.Text != String.Empty)
            {
                int userId = Convert.ToInt32(UserIdBox.Text.Trim());
                string userName = UserNameBox.Text.Trim();
                string userSurname = SurnameBox.Text.Trim();
                string userPhone = PhoneBox.Text.Trim();
                string userAddress = UserAddressBox.Text.Trim();
                command = new NpgsqlCommand(@"
UPDATE users
SET name = @UserName, surname = @UserSurname, phone = @UserPhone, address = @UserAddress
WHERE id = @UserId",
database.getConnection());
                command.Parameters.Add("@UserId", NpgsqlDbType.Integer).Value = userId;
                command.Parameters.Add("@UserName", NpgsqlDbType.Varchar).Value = userName;
                command.Parameters.Add("@UserSurname", NpgsqlDbType.Varchar).Value = userSurname;
                command.Parameters.Add("@UserPhone", NpgsqlDbType.Varchar).Value = userPhone;
                command.Parameters.Add("@UserAddress", NpgsqlDbType.Varchar).Value = userAddress;

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


