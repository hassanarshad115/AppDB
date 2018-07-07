using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using AppDB.ORM;

namespace AppDB
{
    [Activity(Label = "@string/app_name", MainLauncher = true, LaunchMode = Android.Content.PM.LaunchMode.SingleTop, Icon = "@drawable/hsn",
        Theme ="@android:style/Theme.Material.Light.NoActionBar")]
    public class MainActivity : Activity
    {

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            //Set your main view here
            SetContentView(Resource.Layout.main);

            //create Database
            var dbBtn = FindViewById<Button>(Resource.Id.dbbutton1);
            dbBtn.Click += delegate
            {
                DBRepository obj = new DBRepository();
                var result = obj.connectionDbMethod();

                Toast.MakeText(this, result, ToastLength.Long).Show();
            };

            //create Table
            var tblBtn = FindViewById<Button>(Resource.Id.tablebutton1);
            tblBtn.Click += delegate
            {
                DBRepository obj = new DBRepository();
                string result = obj.CreateTable();

                Toast.MakeText(this, result, ToastLength.Long).Show();
            };

            //insert Record

            var insertBtn = FindViewById<Button>(Resource.Id.insertbutton2);
            insertBtn.Click += delegate
            {
                StartActivity(typeof(TaskActivity1));
            };

            //update k lye
            var updateBtn = FindViewById<Button>(Resource.Id.updatebutton3);
            updateBtn.Click += delegate
            {
                StartActivity(typeof(updateActivity1));
            };

            //delete k lye
            var delBtn = FindViewById<Button>(Resource.Id.deletebutton4);
            delBtn.Click += delegate
            {
                StartActivity(typeof(deleteActivity1));
            };
            //shwo Records
            var showBtn = FindViewById<Button>(Resource.Id.showbutton5);
            showBtn.Click += delegate
            {
                DBRepository obj = new DBRepository();
                var veriable = obj.getAllRecords();
                Toast.MakeText(this, veriable, ToastLength.Long).Show();
            };

            //get by id
            var idBtn = FindViewById<Button>(Resource.Id.idbutton1);
            idBtn.Click += delegate
            {
                StartActivity(typeof(searchByIdActivity1));
            };

            //mywork k lye
            var mywork = FindViewById<Switch>(Resource.Id.switch1);
            mywork.CheckedChange += delegate
            {
                StartActivity(typeof(myActivity1));
            };
        }
    }
}

