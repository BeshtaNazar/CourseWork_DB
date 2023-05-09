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
    public partial class CompaniesTable : Form
    {
        DataTable dataTable;
        Database database;
        NpgsqlCommand command;
        NpgsqlDataAdapter adapter;
        public CompaniesTable()
        {
            InitializeComponent();
            dataTable = new DataTable();
            database = new Database();
            command = new NpgsqlCommand("SELECT * FROM companies ORDER BY id", database.getConnection());
            adapter = new NpgsqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(dataTable);
            companies.DataSource = dataTable;
        }

        private void InsertValue_Click(object sender, EventArgs e)
        {
            string companyName= CompanyNameBox.Text.Trim();
            command = new NpgsqlCommand(@"
INSERT INTO companies(name)
VALUES (@CompanyName)",
database.getConnection());
            command.Parameters.Add("@CompanyName", NpgsqlDbType.Varchar).Value = companyName;
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
            if (CompanyIdBox.Text != String.Empty)
            {
                int companyId = Convert.ToInt32(CompanyIdBox.Text.Trim());

                command = new NpgsqlCommand(@"
DELETE FROM companies
WHERE id = @CompanyId",
database.getConnection());
                command.Parameters.Add("@CompanyId", NpgsqlDbType.Integer).Value = companyId;

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
            if (CompanyIdBox.Text != String.Empty)
            {
                int companyId = Convert.ToInt32(CompanyIdBox.Text.Trim());
                string companyName = CompanyNameBox.Text.Trim();
                command = new NpgsqlCommand(@"
UPDATE companies
SET name = @CompanyName
WHERE id = @CompanyId",
database.getConnection());
                command.Parameters.Add("@CompanyId", NpgsqlDbType.Integer).Value = companyId;
                command.Parameters.Add("@CompanyName", NpgsqlDbType.Varchar).Value = companyName;

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
            command = new NpgsqlCommand("SELECT * FROM companies ORDER BY id", database.getConnection());
            adapter = new NpgsqlDataAdapter();
            dataTable = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(dataTable);
            companies.DataSource = dataTable;
        }
    }
}
