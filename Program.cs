﻿using System;

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
        private int Password { get; set; }

        public void SetLoginNPassword(string login, int password)
        {
            Login = login;
            Password = password;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
