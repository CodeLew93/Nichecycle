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
using Firebase;
using Firebase.Auth;
using Firebase.Database;
using Firebase.Database.Query;

namespace App1.Classes
{

    public class AppData
    {
        private static AppData instance;
        public static ChildQuery dataNode;
        public static ChildQuery usersNode;
        static FirebaseApp fireApp;
        public static FirebaseAuth auth;

        public static AppData GetInstance (Context withContext)
        {
            if (instance == null)
                instance = new AppData(withContext);
            return instance;
        }

        private AppData (Context thiscontext)
        {
            var options = new Firebase.FirebaseOptions.Builder()
                                                      .SetApplicationId("1:191973491619:android:fc64e3b99f2fa22e")
                                                      .SetApiKey("AIzaSyCcKCt2E0MAPWc7uKbs7EFDf86Tw84drYU")
                                                      .Build();

            if (fireApp == null)
                fireApp = FirebaseApp.InitializeApp(thiscontext, options);

            auth = FirebaseAuth.GetInstance(fireApp);

            string FirebaseURL = "https://nichecycle-33d25.firebaseio.com";
            FirebaseClient rootNode = new FirebaseClient(FirebaseURL);
            dataNode = rootNode.Child("data");
            usersNode = rootNode.Child("users");
        }
    }
    
}