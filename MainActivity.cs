using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;

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
        }
        

        void InterfaceBuilder ()
        {
            loginButton = FindViewById<Button>(Resource.Id.LoginButton);
            loginButton.Click += LoginButton_Click;

            cabutton = FindViewById<Button>(Resource.Id.CAButton);
            cabutton.Click += CreateAccount_Click;
        }

        void CreateAccount_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        void LoginButton_Click(object sender, System.EventArgs e)
        {
             var nextactivity = new Intent(this, typeof(LandingActivity));
            StartActivity(nextactivity);
            
        }
    }
}