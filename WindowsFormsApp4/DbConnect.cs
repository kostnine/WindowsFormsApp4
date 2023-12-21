using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp4
{
    internal class DbConnect
    {
        static public MySqlConnection myconnect;
        static public string DbConnection = "server=127.0.0.1;user=root;password=root;database=auto;";
        static public MySqlDataAdapter msDataAdapter;
        static public MySqlCommand msCommand;

        public static bool ConnectionDB()
        {
            try
            {
                myconnect = new MySqlConnection(DbConnection);
                myconnect.Open();
                msCommand = new MySqlCommand();
                msCommand.Connection = myconnect;
                msDataAdapter = new MySqlDataAdapter(msCommand);
                return true;
            }
            catch
            {
                MessageBox.Show("Nepavyko prisijungti prie duomenu bazes!", "Klaida!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static void CloseDB()
        {
            myconnect.Close();
        }

        public MySqlConnection GetConnection()
        {
            return myconnect;
        }

        public static bool RegisterUser(Users user)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(DbConnection))
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO acc (Vardas, Pavarde, Login, Password, id_role) " +
                                         "VALUES (@firstName, @lastName, @login, @password, @roleId); SELECT LAST_INSERT_ID()";

                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@firstName", user.FirstName);
                        cmd.Parameters.AddWithValue("@lastName", user.LastName);
                        cmd.Parameters.AddWithValue("@login", user.Login);
                        cmd.Parameters.AddWithValue("@password", user.Password);
                        cmd.Parameters.AddWithValue("@roleId", user.RoleId);

                        int idAccount = Convert.ToInt32(cmd.ExecuteScalar());

                        user.SetIdAccount(idAccount);

                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка во время регистрации: {ex.Message}");
                return false;
            }
        }
    }
}

