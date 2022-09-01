using System;

namespace Task_04
{
    internal class User
    {
        string name, surname, login;
        int age;
        readonly DateTime dateCreat;

        public User(string name, string surname, string login, int age)
        {
            this.name = name;
            this.surname = surname;
            this.login = login;
            this.age = age;
            dateCreat = DateTime.Now;
        }

        public DateTime DateCreate { get { return dateCreat; } }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value == null)
                    name = "имя не указано";
            }
        }
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                if (value == null)
                    surname = "фамилия не указано";
            }
        }
        public string Login
        {
            get
            {
                return login;
            }
            set
            {
                if (value == null)
                    login = "логин не указано";
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value == 0)
                    age = 20;
            }
        }
    }
}
