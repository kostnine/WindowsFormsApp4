using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Получение данных из текстовых полей
                string firstName = textBox1.Text.Trim();
                string lastName = textBox2.Text.Trim();
                string login = textBox3.Text.Trim();
                string password = textBox4.Text;

                // Создание объекта пользователя
                Users newUser = new Users(firstName, lastName, login, password);

                // Регистрация пользователя в базе данных
                bool registrationSuccess = DbConnect.RegisterUser(newUser);

                // Отображение сообщения о результате
                if (registrationSuccess)
                {
                    MessageBox.Show("Регистрация успешна. ID вашего аккаунта: " + newUser.IdAccount);
                    this.Hide();
                    Form1 form = new Form1();
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Ошибка регистрации. Пожалуйста, проверьте введенные данные.");
                }
            }
            catch (Exception ex)
            {
                // Display the exception message in case of an error
                MessageBox.Show($"Ошибка регистрации: {ex.Message}", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        

    }

        private void Registration_Load(object sender, EventArgs e)
        {

        }
    }
}
