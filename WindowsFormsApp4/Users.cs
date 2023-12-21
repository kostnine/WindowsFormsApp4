using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{

    public class Users
    {
        private int idAccount; // Автоинкрементируемый идентификатор
        private string firstName;
        private string lastName;
        private string login;
        private string password;
        private int roleId = 2; // Роль пользователя

        public Users(string firstName, string lastName, string login, string password)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.login = login;
            this.password = password;
        }

        // Другие свойства и методы по необходимости

        // Метод для установки id_account
        public void SetIdAccount(int idAccount)
        {
            this.idAccount = idAccount;
        }

        // Свойство для доступа к id_account
        public int IdAccount
        {
            get { return idAccount; }
        }

        // Свойство для доступа к имени
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        // Свойство для доступа к фамилии
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        // Свойство для доступа к логину
        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        // Свойство для доступа к паролю
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        // Свойство для доступа к роли
        public int RoleId
        {
            get { return roleId; }
        }
    }



}

