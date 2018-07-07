using System;

//ye 3 namespace add krni h 
using System.Data;
using System.IO;
using SQLite;

namespace AppDB.ORM
{
    public class CodeClass
    {

        public static string connection = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "mydb.db");
        SQLiteConnection db = new SQLiteConnection(connection);

        //first we create database 
        public string createDatabaseMethod()
        {
            string output = "create database if not exists";
            string connection = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "mydb.db");
            SQLiteConnection db = new SQLiteConnection(connection);


            output +="\nSuccessfully create Database";
            return output;
        }

        //now we create table 
        public string createTableMethod()
        {
            db.CreateTable<Table>();

            return "create table successfully";
        }

        //now insert data
        public string insertMethod(string taskV)
        {
            Table insert = new Table();
            insert.task = taskV;
            db.Insert(insert);

            return "insert data successfully";
        }

        //now update data
        public string updateMethod(int idV,string taskV)
        {
            var item = db.Get<Table>(idV);
            item.task = taskV;
            db.Update(item);

            return "update data successfully";
        }

        //now delete data
        public string deleteMethod(int idV)
        {
            var item = db.Get<Table>(idV);
            db.Delete(item);

            return "delete data successfully";
        }

        //get by id
        public string getByIdMethod(int idV)
        {
            var item = db.Get<Table>(idV);

            return item.task;
        }

        //show all records
        public string showAllRecordMethod()
        {
            string output = "";
            var table = db.Table<Table>();
            foreach (var item in table)
            {
                output = "\n" + item.id +"---" + item.task;
            }
            return output;
        }

        

    }
}