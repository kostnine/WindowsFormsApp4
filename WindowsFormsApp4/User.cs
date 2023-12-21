using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void User_Load(object sender, EventArgs e)
        {
            label3.Visible = false;
            dataGridView1.Visible = false;
            button5.Visible = false;
            Auto.GetAuto();
            dataGridView1.DataSource = Auto.dbAuto;
            Mods.GetDegalai();
            Mods.GetKebulas ();
            comboBox1.DataSource = Mods.dbMods;
            comboBox1.DisplayMember = "Kebulai";
            comboBox2.DataSource = Mods.dbMod;
            comboBox2.DisplayMember = "Degalas";
            DbConnect.ConnectionDB();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            dataGridView1.Visible = true;
            button5.Visible = true;
            string selectedKebulas = comboBox1.Text;
            string selectedDegalai = comboBox2.Text;

            // Apply the filter to the DataTable (assuming dbAuto is a DataTable)
            DataView dv = new DataView(Auto.dbAuto);
            dv.RowFilter = $"Kebulas = '{selectedKebulas}' AND Degalai = '{selectedDegalai}'";

            // Display the filtered results in dataGridView1
            dataGridView1.DataSource = dv.ToTable();

        }



private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Getting data from the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string marke = selectedRow.Cells["Marke"].Value.ToString();
                string kebulas = selectedRow.Cells["Kebulas"].Value.ToString();
                string degalu = selectedRow.Cells["Degalai"].Value.ToString();
                string variklis = selectedRow.Cells["Variklio_Galia"].Value.ToString();
                string modelis = selectedRow.Cells["Modelis"].Value.ToString(); // Added line for Modelis

                // Generating a VIN automatically (example)
                string vin = GenerateVin();

                // Connection string for MySQL
                string connectionString = "server=127.0.0.1;user=root;password=root;database=auto;";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Inserting data into the acc table
                    string insertQuery = "INSERT INTO acc (Login, Password, id_role, Marke, Kebulas, Degalu, Variklis, Modelis, VIN) " +
                                         "VALUES (@login, @password, @id_role, @marke, @kebulas, @degalu, @variklis, @modelis, @vin)"; // Modified query

                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, connection))
                    {
                        // Use values from the Authorization class
                        cmd.Parameters.AddWithValue("@login", Authorization.User ?? "default_login");
                        cmd.Parameters.AddWithValue("@password", Authorization.Password ?? "default_password");
                        cmd.Parameters.AddWithValue("@id_role", 2); // Assuming 2 is the role for cars
                        cmd.Parameters.AddWithValue("@marke", marke);
                        cmd.Parameters.AddWithValue("@kebulas", kebulas);
                        cmd.Parameters.AddWithValue("@degalu", degalu);
                        cmd.Parameters.AddWithValue("@variklis", variklis);
                        cmd.Parameters.AddWithValue("@modelis", modelis); // Added parameter for Modelis
                        cmd.Parameters.AddWithValue("@vin", vin);

                        // Executing the query
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Автомобиль добавлен в ваш аккаунт.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите автомобиль для добавления.");
            }
        }



        private string GenerateVin()
        {
            // Example of generating a random VIN (replace with your logic)
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, 17)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MyCars form = new MyCars();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }
    }
}

