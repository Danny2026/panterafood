<<<<<<< HEAD
<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Stock
    {
        public int StockId { get; set; } // Поле ID товара
        public string Adress { get; set; } // Поле адреса
        public int CountOfFull { get; set; } // Поле количества товара на складе
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
>>>>>>> 72b011842e44f9d76fc42b388140980d4cf5452c
=======
﻿using System;

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
>>>>>>> 44c0c958b910f2f730eadf403e6f98aa1d0a6b88
