using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (Auto.AddAuto(comboBox1.Text, textBox1.Text, comboBox3.Text, comboBox2.Text, textBox2.Text, textBox3.Text))
                {
                    MessageBox.Show("Automoblius sekmingai pridetas", "Sekmingai!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Auto.GetAuto();
                    Mods.GetKebulas();
                    Mods.GetDegalai();
                    Mods.GetKompl();
                }
                else
                {
                    MessageBox.Show("Nepavyko prideti Automoblio!", "Klaida!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Uzpildikyte visus langus!");
            }
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            Auto.GetAuto();
            dataGridView1.DataSource = Auto.dbAuto;
            Mods.GetDegalai();
            Mods.GetKebulas();
            Mods.GetKompl();
            comboBox1.DataSource = Mods.dbMods;
            comboBox1.DisplayMember = "Kebulai";
            comboBox2.DataSource = Mods.dbMod;
            comboBox2.DisplayMember = "Degalas";
            comboBox3.DataSource = Mods.dbMod1;
            comboBox3.DisplayMember = "kompls";
            DbConnect.ConnectionDB();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Получение значения ключевого столбца (предположим, что у вас есть столбец "id_auto")
                int idToDelete = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id_auto"].Value);

                // Вызов метода удаления из базы данных
                bool success = DeleteAuto(idToDelete);

                // Удаление строки из DataGridView
                if (success)
                {
                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                    MessageBox.Show("Автомобиль удален успешно.");
                }
                else
                {
                    MessageBox.Show("Ошибка при удалении автомобиля.");
                }
            }
            else
            {
                MessageBox.Show("Выберите автомобиль для удаления.");
            }
        }

        // Метод удаления из базы данных
        private bool DeleteAuto(int id)
        {
            try
            {
                // Используйте ваш запрос SQL для удаления записи по id_auto
                string deleteQuery = $"DELETE FROM autumobiliai WHERE id_auto = {id}";

                DbConnect.msCommand.CommandText = deleteQuery;

                // Выполнение запроса
                if (DbConnect.msCommand.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении из базы данных: {ex.Message}");
                return false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }
    }
}

