using System;

namespace Product
{
    class Customer
    {
        public int CustomerId { get; set; } // поле id для покупателя
        public string CustomerFullName { get; set; } // поле ФИО покупателя
        public int CustomerPhoneNumber { get; set; } // поле номера телефона покупателя
        public string CustomerAdress { get; set; } // поле адреса доставки покупателя
        public int CardNum { get; set; } // поле номера карты покупателя
        private string Login { get; set; } // поле логина покупателя
        private string Password { get; set; } // поле пароля покупателя

        public void SetLoginNPassword(string login, string password)
        {
            const int minSizeOfPassword = 8;
            Login = login;
            if (password.Length > minSizeOfPassword)
            {
                Password = password;
            }
            else Console.WriteLine("Пароль должен состоять минимум из 8 цифр");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
