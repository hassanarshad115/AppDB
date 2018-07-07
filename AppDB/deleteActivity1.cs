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
    [Activity(Label = "deleteActivity1")]
    public class deleteActivity1 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.deletelayout1);

            var delBtn = FindViewById<Button>(Resource.Id.deletebutton1);
            var delTxtID = FindViewById<EditText>(Resource.Id.deleteeditText1);

            delBtn.Click += delegate
            {
                DBRepository obj = new DBRepository();
                string result = obj.deleteMethod(int.Parse(delTxtID.Text));
                Toast.MakeText(this, result, ToastLength.Short).Show();
            };
        }
    }
}