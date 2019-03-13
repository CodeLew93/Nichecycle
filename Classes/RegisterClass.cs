using Android.App;
using Android.Views;
using Android.Widget;
using System.Threading.Tasks;

namespace App1
{
    public static class RegisterClass
    {
        public static void Alert(MainActivity thisActivity)
        {
            AlertDialog.Builder registerAlert = new AlertDialog.Builder(thisActivity);
            registerAlert.SetTitle("Register Online");
            registerAlert.SetMessage("Please enter your name, email and password.");

            LinearLayout textEditsLayout = new LinearLayout(thisActivity);
            textEditsLayout.Orientation = Orientation.Vertical;

            EditText nameInput = new EditText(thisActivity);
            nameInput.TextSize = 22;
            nameInput.Gravity = GravityFlags.Center;
            nameInput.Hint = "name";
            nameInput.SetSingleLine(true);
            textEditsLayout.AddView(nameInput);

            EditText emailInput = new EditText(thisActivity);
            emailInput.TextSize = 22;
            emailInput.Gravity = GravityFlags.Center;
            emailInput.Hint = "email";
            emailInput.InputType = Android.Text.InputTypes.TextVariationEmailAddress;
            emailInput.SetSingleLine(true);
            textEditsLayout.AddView(emailInput);

            EditText passwordInput = new EditText(thisActivity);
            passwordInput.TextSize = 22;
            passwordInput.Gravity = GravityFlags.Center;
            passwordInput.InputType = Android.Text.InputTypes.TextVariationPassword;
            passwordInput.Hint = "password";
            passwordInput.SetSingleLine(true);
            textEditsLayout.AddView(passwordInput);

            registerAlert.SetView(textEditsLayout);
            registerAlert.SetPositiveButton("Register",
                                            async (senderAlert, 
                                             args) => await Register(thisActivity,
                                                                     nameInput.Text,
                                                                     emailInput.Text,
                                                                     passwordInput.Text));
            registerAlert.SetNegativeButton("Cancel",
                                            (senderAlert, args) => { });

            Dialog dialog = registerAlert.Create();
            dialog.Show();
        }

        public static async Task Register (MainActivity thisActivity,
                                            string name,
                                            string email,
                                            string password)
        {
            
        }
    }
}
