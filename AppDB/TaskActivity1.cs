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
    [Activity(Label = "TaskActivity1")]
    public class TaskActivity1 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Tasklayout1);

            var btnAdd = FindViewById<Button>(Resource.Id.taskbutton1);
            btnAdd.Click += BtnAdd_Click;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            EditText txt = FindViewById<EditText>(Resource.Id.taskeditText1);
            DBRepository obj = new DBRepository();
            string veriable = obj.InsertRecord(txt.Text);

            Toast.MakeText(this, veriable, ToastLength.Long).Show();
        }
    }
}