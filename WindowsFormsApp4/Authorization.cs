using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp4
{
    internal class Authorization
    {
        static public string role, surname, User;
 
        static public string Password { get; set; }

        static public void AuthorizationMethod(string login, string password)
    {
        try
        {
            DbConnect.msCommand.CommandText = @"SELECT name_role from sp_role, acc WHERE Login = '" + login + "' and Password ='" + password + "'and acc.id_role=sp_role.id_role";
            object result = DbConnect.msCommand.ExecuteScalar();
            if (result != null)
            {
                role = result.ToString();
                User = login;
                Password = password; // сохраняем пароль
            }
            else
            {
                role = User = Password = null;
                surname = null;
            }
        }
        catch
        {
            role = User = Password = null;
            MessageBox.Show("Klaida prisijungus");
        }
    }
        static public string AuthorizationName(string login)
        {
            try
            {
                DbConnect.msCommand.CommandText = @"SELECT Surname FROM acc WHERE Login = '" + login + "' ";
                object result = DbConnect.msCommand.ExecuteScalar();
                surname = result.ToString();
                return surname;
            }
            catch
            {
                return null;
            }
        }
    }
}
