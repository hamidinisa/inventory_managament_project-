using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace inventory_managament_project
{
    public partial class addusersForm : Form
    {
        SqlConnection baglan = new SqlConnection("Data Source=NISA\\SQLEXPRESS01;Initial Catalog=inventory;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;");

        public addusersForm()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            if (usernametextBox.Text == "" || passwordtextBox.Text == "" || rolecomboBox.SelectedIndex == -1 || statuscomboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Empty fields", "Error Message");
            }
            else
            {
                try
                {
                    if (baglan.State == ConnectionState.Closed)
                    {
                        baglan.Open();
                    }

                    string insertData = "INSERT INTO users1(username, id, role, status) VALUES (@username, @password, @role, @status)";

                    using (SqlCommand cmd = new SqlCommand(insertData, baglan))
                    {
                        cmd.Parameters.AddWithValue("@username", usernametextBox.Text.Trim());
                        cmd.Parameters.AddWithValue("@password", passwordtextBox.Text.Trim());
                        cmd.Parameters.AddWithValue("@role", rolecomboBox.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@status", statuscomboBox.SelectedItem.ToString());

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("User successfully added!", "Message");

                    // Verileri yeniden yükle
                    LoadDataGridView();
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

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (usernametextBox.Text == "" || rolecomboBox.SelectedIndex == -1 || statuscomboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in the fields to update", "Error Message");
            }
            else
            {
                try
                {
                    if (baglan.State == ConnectionState.Closed)
                    {
                        baglan.Open();
                    }

                    string updateData = "UPDATE users1 SET id = @password, role = @role, status = @status WHERE username = @username";

                    using (SqlCommand cmd = new SqlCommand(updateData, baglan))
                    {
                        cmd.Parameters.AddWithValue("@username", usernametextBox.Text.Trim());
                        cmd.Parameters.AddWithValue("@password", passwordtextBox.Text.Trim());
                        cmd.Parameters.AddWithValue("@role", rolecomboBox.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@status", statuscomboBox.SelectedItem.ToString());

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("User successfully updated!", "Message");

                    // Verileri yeniden yükle
                    LoadDataGridView();
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

        private void removebutton_Click(object sender, EventArgs e)
        {
            if (usernametextBox.Text == "")
            {
                MessageBox.Show("Please enter a username to remove", "Error Message");
            }
            else
            {
                try
                {
                    if (baglan.State == ConnectionState.Closed)
                    {
                        baglan.Open();
                    }

                    string deleteData = "DELETE FROM users1 WHERE username = @username";

                    using (SqlCommand cmd = new SqlCommand(deleteData, baglan))
                    {
                        cmd.Parameters.AddWithValue("@username", usernametextBox.Text.Trim());

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("User successfully removed!", "Message");

                    // Verileri yeniden yükle
                    LoadDataGridView();
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

        private void clearbutton_Click(object sender, EventArgs e)
        {
            usernametextBox.Clear();
            passwordtextBox.Clear();
            rolecomboBox.SelectedIndex = -1;
            statuscomboBox.SelectedIndex = -1;
            MessageBox.Show("Form cleared!", "Message");
        }

        // DataGridView'e verileri yükleyen metot
        private void LoadDataGridView()
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                }

                string selectData = "SELECT * FROM users1";
                SqlDataAdapter da = new SqlDataAdapter(selectData, baglan);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
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

        // Form yüklendiğinde verileri DataGridView'e yükle
        private void addusersForm_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }
    }
}
