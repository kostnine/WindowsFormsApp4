using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        static public string LoginActive;
        static public string whois;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DbConnect.ConnectionDB();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                Authorization.AuthorizationMethod(textBox1.Text, textBox2.Text);
                switch (Authorization.role)
                {
                    case null:
                        {
                            MessageBox.Show("Toks naudotojas neegzistuoja", "Patikrinkit ivestus duomenius", MessageBoxButtons.OK, MessageBoxIcon.Warning); break;
                        }
                    case "Admin":
                        {
                            LoginActive = textBox1.Text;
                            whois = "Admin";
                            Authorization.User = textBox1.Text;
                            string surname = Authorization.AuthorizationName(textBox1.Text);
                            Authorization.surname = surname;
                            MessageBox.Show(surname + ", sveiki prisijungus i Administratoriaus menu", "Sekmingai!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            AdminForm admin = new AdminForm();
                            admin.Show();
                            break;
                        }
                    case "User":
                        {
                            LoginActive = textBox1.Text;
                            whois = "User";
                            Authorization.User = textBox1.Text;
                            string surname = Authorization.AuthorizationName(textBox1.Text);
                            string sur = textBox2.Text;
                            Authorization.surname = surname;
                            sur = textBox2.Text;

                            User destytojas = new User();

                            MessageBox.Show(surname + ", sveiki prisijungus i BMW Autosalono menu", "Sekmingai!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            destytojas.Show();
                            break;
                        }

                }

            }
            else
            {
                MessageBox.Show("Uzpildikyte visus ivedimo langus!", "Klaida!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration reg = new Registration();
            reg.Show();
        }
    }
}
