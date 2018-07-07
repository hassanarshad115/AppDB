using System;

using System.Data;
using System.IO;
using SQLite;
namespace AppDB.ORM
{
    [Table("ToDoTaskTable")]
   public  class ToDoTaskTable
    {
        [PrimaryKey,AutoIncrement,Column("ID")]
        public int ID { get; set; }

        [MaxLength(50)]
        public string Task { get; set; }

    }
}