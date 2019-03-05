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

namespace App1
{
    [Activity(Label = "Activity1")]
    public class Database : Activity
    {
        Button SearchButton;
        EditText SearchField;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.searchpage);
            InterfaceBuilder();
        }

        void InterfaceBuilder()
        {
            SearchButton = FindViewById<Button>(Resource.Id.findbuttonID);
            SearchButton.Click += SearchDB;

            SearchField = FindViewById<EditText>(Resource.Id.searchtextID);
        }

        private void SearchDB(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}