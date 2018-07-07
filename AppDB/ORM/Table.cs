using System;


//ye 3 namespace add krni h
using System.Data;
using System.IO;
using SQLite;

namespace AppDB.ORM
{
    [Table("table")]
   public class Table
    {
        [PrimaryKey,AutoIncrement,Column("id")]
        public int id { get; set; }

        [MaxLength(55)]
        public string task { get; set; }
    }
}