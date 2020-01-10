using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;

namespace Nameless_Store_2019.Views.Email
{
    public class Email
    {
        public string email { get; set; }
        public string Address { get; set; }
        public int House_number { get; set; }
        public string Street { get; set; }
        public int Phone_number { get; set; }

        public Email(string email, string Address, int House_number, string Street, int Phone_number)
        {
            this.email = email;
            this.Address = Address;
            this.House_number = House_number;
            this.Street = Street;
            this.Phone_number = Phone_number;
        }


    }
}