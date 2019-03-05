using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.Support.V7.App;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace App1
{
    [Activity(Label = "LandingActivity")]
    public class LandingActivity : Activity
    {
        Button DBButton;
        Button QRButton;
        Button MPButton;
      

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.login);
            InterfaceBuilder();
        }

        void InterfaceBuilder ()
        {
            DBButton = FindViewById<Button>(Resource.Id.landingDBButton);
            DBButton.Click += GoDB;
            QRButton = FindViewById<Button>(Resource.Id.LandingQRButton);

            MPButton = FindViewById<Button>(Resource.Id.LandingMPButton);

        }

        private void GoMP(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void GoQR(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void GoDB(object sender, EventArgs e)
        {
            var nextactivity = new Intent(this, typeof(Database));
            StartActivity(nextactivity);
        }
    }

  
}