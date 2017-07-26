using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
//using System.Data.Entity;

namespace Lab_20.Models
{
    public class Registration
    {
        [Required]
        [Key]
        public string name { get; set; }

        [Required]
        public string email { get; set; }
    }

    //public class DBRegisterContext : DbContext
    //{
    //    public DbSet<Register> Entries { get; set; }

    //    public System.Data.Entity.DbSet<Lab20.Models.Item> Items { get; set; }
    //}
}

