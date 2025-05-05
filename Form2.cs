using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory_managament_project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            loginPage login = new loginPage(); 
            login.Show();
            this.Hide();
        }

        private void button_dashboard_Click(object sender, EventArgs e)
        {
            dashboardForm dashboard= new dashboardForm();
            dashboard.Show();
            this.Hide();
        }

        private void button_addusers_Click(object sender, EventArgs e)
        {
            addusersForm addusersForm = new addusersForm();
            addusersForm.Show();
            this.Hide();    
        }
    }
}
