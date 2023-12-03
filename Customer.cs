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
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
