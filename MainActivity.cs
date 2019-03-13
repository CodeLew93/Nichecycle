using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;
using System;
using System.Collections.Generic;
using App1.Classes;
using Firebase;
using Firebase.Auth;
using Firebase.Database.Query;

namespace App1
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        Button loginButton;
        Button cabutton;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.landing);
            InterfaceBuilder();
            AppData.GetInstance(this);
            
        }

        /*void TestingFirebase()
        {
            AppData.auth.CreateUserWithEmailAndPassword("test@test.com",
                                                        "password123");
            var myDict = new Dictionary<string, object>
            {
                {"key_1", "val_1"},
                {"key_2", "val_2"}
            };

            AppData.dataNode
                .Child("SampleNode")
                .PutAsync(myDict);
        }
*/


        void InterfaceBuilder ()
        {
            loginButton = FindViewById<Button>(Resource.Id.LoginButton);
            loginButton.Click += LoginButton_Click;

            cabutton = FindViewById<Button>(Resource.Id.CAButton);
            cabutton.Click += CreateAccount_Click;
        }



        void CreateAccount_Click(object sender, System.EventArgs e)
        {
            Android.App.AlertDialog.Builder CAAlert = new Android.App.AlertDialog.Builder(this);
            CAAlert.SetTitle("Register");
            CAAlert.SetMessage("Are sure you want to register");

            CAAlert.SetPositiveButton("Register", (senderAlert, arg) => RegisterClass.Alert(this));
            CAAlert.SetNegativeButton("Cancel", (senderAlert, args) => { });

            Dialog dialog = CAAlert.Create();
            dialog.Window.SetGravity(Android.Views.GravityFlags.Bottom);
            dialog.Show();
        }



        void LoginButton_Click(object sender, System.EventArgs e)
        {
            Intent nextactivity = new Intent(this, typeof(LandingActivity));
            StartActivity(nextactivity);
            
        }
    }
}