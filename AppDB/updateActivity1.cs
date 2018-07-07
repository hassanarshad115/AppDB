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
    [Activity(Label = "updateActivity1")]
    public class updateActivity1 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.lupdateayout1);

            //search k lye
            EditText idTxt = FindViewById<EditText>(Resource.Id.idUeditText1);
            Button idBtn = FindViewById<Button>(Resource.Id.idUbutton1);

            //update k lye
            EditText upTxt = FindViewById<EditText>(Resource.Id.UeditText2);
            Button upBtn = FindViewById<Button>(Resource.Id.Ubutton2);

            //search k lye phly
            idBtn.Click += delegate
            {
                DBRepository obj = new DBRepository();
                upTxt.Text = obj.getById(int.Parse(idTxt.Text));
            };


            //for update
            upBtn.Click += delegate
            {
                DBRepository obj = new DBRepository();
                string result = obj.updateRecordMethod(int.Parse( idTxt.Text), upTxt.Text);
                Toast.MakeText(this, result, ToastLength.Short).Show();
            };

        }
    }
}