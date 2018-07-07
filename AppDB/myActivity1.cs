using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AppDB.ORM;

namespace AppDB
{
    [Activity(Label = "myActivity1")]
    public class myActivity1 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.mylayout1);

            var createDbBtn = FindViewById<Button>(Resource.Id.mydbbutton1);
            var tblBtn = FindViewById<Button>(Resource.Id.mytablebutton2);

            var txt = FindViewById<EditText>(Resource.Id.myentertaskeditText1);

            var insertBtn = FindViewById<Button>(Resource.Id.myinsertbutton3);
            var updateBtn = FindViewById<Button>(Resource.Id.myupdatebutton4);
            var deleteBtn = FindViewById<Button>(Resource.Id.mydeletebutton5);
            var showAllDataBtn = FindViewById<Button>(Resource.Id.myshowalldatabutton6);
            var getById = FindViewById<Button>(Resource.Id.mygetbyidbutton7);

            //create database
            createDbBtn.Click += delegate
            {
                CodeClass obj = new CodeClass();
                var v=obj.createDatabaseMethod();
                Toast.MakeText(this, v, ToastLength.Short).Show();
            };
            //create table
            tblBtn.Click += delegate
            {
                CodeClass obj = new CodeClass();
               var v= obj.createTableMethod();
                Toast.MakeText(this, v, ToastLength.Short).Show();
            };
            //insert data into table
            insertBtn.Click += delegate
            {
                CodeClass obj = new CodeClass();
                string v =obj.insertMethod(txt.Text);
                Toast.MakeText(this, v, ToastLength.Short).Show();
            };

            //delete data krny k lye
            deleteBtn.Click += delegate
            {
                CodeClass obj = new CodeClass();
               string v= obj.deleteMethod(int.Parse(txt.Text));
                Toast.MakeText(this, v, ToastLength.Short).Show();
            };

            //show all records
            showAllDataBtn.Click += delegate
            {
                CodeClass obj = new CodeClass();
                var v=obj.showAllRecordMethod();
                Toast.MakeText(this, v, ToastLength.Short).Show();
            };

            //get by id
            getById.Click += delegate
            {
                CodeClass obj = new CodeClass();
                var v = obj.getByIdMethod(int.Parse(txt.Text));
            };

            //now show all record
            showAllDataBtn.Click += delegate
            {
                CodeClass obj = new CodeClass();
                string v= obj.showAllRecordMethod();
                Toast.MakeText(this, v, ToastLength.Short).Show();
            };
        }
    }
}