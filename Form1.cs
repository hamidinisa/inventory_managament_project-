using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace inventory_managament_project
{
    public partial class loginPage : Form
    {
        SqlConnection baglan = new SqlConnection("Data Source=NISA\\SQLEXPRESS01;Initial Catalog=inventory;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;");

        public loginPage()
        {
            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(loginText.Text) || string.IsNullOrWhiteSpace(passwordText.Text))
            {
                MessageBox.Show("Please enter a username and password", "Message");
                return;
            }

            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                }

                // Tablonuzun doğru adını kullandığınızdan emin olun
                string insertData = "INSERT INTO users1(username,id) VALUES (@username, @password)";

                using (SqlCommand cmd = new SqlCommand(insertData, baglan))
                {
                    cmd.Parameters.AddWithValue("@username", loginText.Text.Trim());
                    cmd.Parameters.AddWithValue("@password", passwordText.Text.Trim());

                    // Sorguyu çalıştırıyoruz
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("User successfully added!", "Message");
                
                Form2 loginForm = new Form2();
                loginForm.Show();
                this.Hide();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Error: " + ex.Message, "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
            finally
            {
                if (baglan.State == ConnectionState.Open)
                {
                    baglan.Close();
                }
            }
        }

    }
}