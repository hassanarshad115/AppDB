using System;

using System.Data;
using System.IO;
using SQLite;
namespace AppDB.ORM
{
    public class DBRepository
    {
        public static string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "myDb.db");
        SQLiteConnection db = new SQLiteConnection(dbPath);

        //create database ki h r uska path dia h ismy
        public string connectionDbMethod()
        {
            string content = "";
            content += "Create Database if it is not Exists";


            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "myDb.db");
            SQLiteConnection db = new SQLiteConnection(dbPath);
           
            return "\nDatabase Created..";
        }

        //create table kia h

        public string CreateTable()
        {


            db.CreateTable<ToDoTaskTable>();

            return "Create Table Successfully..";


        }

        //insert Record
        public string InsertRecord(string task)
        {


            ToDoTaskTable insert = new ToDoTaskTable();
            insert.Task = task;
            db.Insert(insert);


            return "Insert Record Successfully..";

        }

        //update Records

        public string updateRecordMethod(int idV, string taskV)
        {

            var item = db.Get<ToDoTaskTable>(idV);
            item.Task = taskV;
            db.Update(item);

            return "Update Record Successfully..";
        }

        //for delete

        public string deleteMethod(int idv)
        {

            var item = db.Get<ToDoTaskTable>(idv);
            db.Delete(item);

            return "Delete Record Successfully";
        }
        //show Records

        public string getAllRecords()
        {




            string output = "";
            output += "Show Records using ORM";

            var table = db.Table<ToDoTaskTable>();
            foreach (var item in table)
            {
                output += "\n" + item.ID + "----" + item.Task;
            }
            return output;



        }


        //get by id
        public string getById(int idV)
        {

            var item = db.Get<ToDoTaskTable>(idV);
            return item.Task; // id k zrye hmny task ko return krna h

        }

    }
}