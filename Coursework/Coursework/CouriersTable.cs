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
    public partial class CouriersTable : Form
    {
        DataTable dataTable;
        Database database;
        NpgsqlCommand command;
        NpgsqlDataAdapter adapter;
        public CouriersTable()
        {            
            InitializeComponent();
            dataTable = new DataTable();
            database = new Database();
            command = new NpgsqlCommand("SELECT * FROM couriers ORDER BY id", database.getConnection());
            adapter = new NpgsqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(dataTable);
            couriers.DataSource = dataTable;
        }

        private void InsertValue_Click(object sender, EventArgs e)
        {
            string courierName = CourierNameBox.Text.Trim();
            string courierSurname = CourierSurnameBox.Text.Trim();
            string courierPhone = CourierPhoneBox.Text.Trim();
            command = new NpgsqlCommand(@"
INSERT INTO couriers(name, surname, phone)
VALUES (@CourierName, @CourierSurname, @CourierPhone)",
database.getConnection());
            command.Parameters.Add("@CourierName", NpgsqlDbType.Varchar).Value = courierName;
            command.Parameters.Add("@CourierSurname", NpgsqlDbType.Varchar).Value = courierSurname;
            command.Parameters.Add("@CourierPhone", NpgsqlDbType.Varchar).Value = courierPhone;
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
            if (CourierIdBox.Text != String.Empty)
            {
                int courierId = Convert.ToInt32(CourierIdBox.Text.Trim());

                command = new NpgsqlCommand(@"
DELETE FROM couriers
WHERE id = @CourierId",
database.getConnection());
                command.Parameters.Add("@CourierId", NpgsqlDbType.Integer).Value = courierId;

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
            if (CourierIdBox.Text != String.Empty)
            {
                int courierId = Convert.ToInt32(CourierIdBox.Text.Trim());
                string courierName = CourierNameBox.Text.Trim();
                string courierSurname = CourierSurnameBox.Text.Trim();
                string courierPhone = CourierPhoneBox.Text.Trim();
                command = new NpgsqlCommand(@"
UPDATE couriers
SET name = @CourierName, surname = @CourierSurname, phone = @CourierPhone
WHERE id = @CourierId",
database.getConnection());
                command.Parameters.Add("@CourierId", NpgsqlDbType.Integer).Value = courierId;
                command.Parameters.Add("@CourierName", NpgsqlDbType.Varchar).Value = courierName;
                command.Parameters.Add("@CourierSurname", NpgsqlDbType.Varchar).Value = courierSurname;
                command.Parameters.Add("@CourierPhone", NpgsqlDbType.Varchar).Value = courierPhone;

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
            command = new NpgsqlCommand("SELECT * FROM couriers ORDER BY id", database.getConnection());
            adapter = new NpgsqlDataAdapter();
            dataTable = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(dataTable);
            couriers.DataSource = dataTable;
        }
    }
}
