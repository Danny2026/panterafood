using System;

namespace Product
{
    class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerFullName { get; set; }
        public int CustomerPhoneNumber { get; set; }
        public string CustomerAdress { get; set; }
        public int CardNum { get; set; }
        private string Login { get; set; }
        private string Password { get; set; }

        public void SetLoginNPassword(string login, int password)
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
