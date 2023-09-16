using Phd_Port.Data;
using Phd_Port.Model;

namespace Phd_Port.Pages
{
    public partial class Index
    {
        bool showLoginmessage = false;
        string username;
        string password;
        int userid;
        BookmarkhubContext context1;
        protected override async Task OnInitializedAsync()
        {
            context1 = DbFactory.CreateDbContext();
            var All_accounts = context1.Accounts.ToList();

            if (Datastore.isLoginMessageShowing)
            {
                showLoginmessage = true;
                Datastore.isLoginMessageShowing = false;
            }
            if (Datastore.isLoggedin == true)
            {
                NavigationManager.NavigateTo("/Events");
            }
        }

        async Task Login()
        {
            // Check if the data from the login form was submitted
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                Console.WriteLine("Please fill both the username and password fields!");
                return;
            }

            var Acnt = context1.Accounts.First(o => o.Username == username);


            int rowCount = 0;

            int id = Acnt.Id;
            string hashedPassword = Acnt.Password;
            // Verify the password
            if (true/*Datastore.SHA1(password) == hashedPassword*/)
            {
                // Verification success! User has logged in!
                // Create sessions to track user login status

                Datastore.userName = username;
                Datastore.userId = id;
                Datastore.isLoggedin = true;

                NavigationManager.NavigateTo("/Events");
            }
            else
            {
                // Incorrect password
                Console.WriteLine("Incorrect username and/or password!");
            }
            //}

            if (rowCount == 0)
            {
                showLoginmessage = true;
                Datastore.loginMessage = "Incorrect username and/or password!";
                // Incorrect username
                Console.WriteLine("Incorrect username and/or password!");
            }



        }

    }
}

