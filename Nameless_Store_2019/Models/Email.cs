using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcEmail.Models
{
    public class Email
    {
        public int ID { get; set; }
        public string email { get; set; }
    }
    public class EmailDBContext : DbContext
    {
        public DbSet<Email> Emails { get; set; }
    }
}