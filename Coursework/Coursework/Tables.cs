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
    public partial class Tables : Form
    {
        public Tables()
        {
            InitializeComponent();           
        }

        private void Baskets_Click(object sender, EventArgs e)
        {
            BasketsTable basketsTable = new BasketsTable();
            basketsTable.Show();
        }

        private void Users_Click(object sender, EventArgs e)
        {
            UsersTable usersTable = new UsersTable();
            usersTable.Show();
        }

        private void Companies_Click(object sender, EventArgs e)
        {
            CompaniesTable companiesTable = new CompaniesTable();
            companiesTable.Show();
        }

        private void Categories_Click(object sender, EventArgs e)
        {
            CategoriesTable categoriesTable = new CategoriesTable();
            categoriesTable.Show();
        }

        private void Food_Click(object sender, EventArgs e)
        {
            FoodTable foodTable = new FoodTable();
            foodTable.Show();
        }

        private void Baskets_food_Click(object sender, EventArgs e)
        {
            BasketsFoodTable basketsFood = new BasketsFoodTable();
            basketsFood.Show();
        }

        private void Orders_Click(object sender, EventArgs e)
        {
            OrdersTable ordersTable = new OrdersTable();
            ordersTable.Show();
        }

        private void Couriers_Click(object sender, EventArgs e)
        {
            CouriersTable couriersTable = new CouriersTable();
            couriersTable.Show();
        }
    }
}
