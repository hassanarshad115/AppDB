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
    [Activity(Label = "searchByIdActivity1")]
    public class searchByIdActivity1 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            SetContentView(Resource.Layout.searchByIdlayout1);

            var srchBtn = FindViewById<Button>(Resource.Id.searchbutton1);
            var srchTxt = FindViewById<EditText>(Resource.Id.searcheditText1);

            srchBtn.Click += delegate
            {
                DBRepository db = new DBRepository();
                string task = db.getById(int.Parse( srchTxt.Text));
                Toast.MakeText(this, task, ToastLength.Short).Show();
            };
        }
    }
}