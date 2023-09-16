namespace Phd_Port.Model
{
    using Data;
    using MySql.Data.MySqlClient;
    using System.Security.Cryptography;
    using System.Text;
    using System.Web;

    public static class Datastore
    {

        public static bool isLoginMessageShowing = false;
        public static string loginMessage = "";

        public static string userName = "";
        public static int userId = 0;
        public static bool isLoggedin = false;
        public static List<User> staticusers = null;
        public static string SortByColumn = "data_source";
        public static string SortOrder = "DESC";

        public static List<User> users
        {
            get
            {
                if (staticusers != null)
                {
                    return staticusers;
                }

                string connectionString = "server=127.0.0.1;port=8889;database=bookmarkhub;user=root;password=root;";
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

                string querycompanies = "SELECT * FROM accounts";

                // Create the command and execute the query
                using (MySqlCommand command = new MySqlCommand(querycompanies, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        // Create the list to store the data
                        staticusers = new List<User>();

                        // Read the data and add it to the list
                        while (reader.Read())
                        {
                        }
                    }

                    return staticusers;
                }
            }
        }

        public static bool ContainsIgnoreCase(this List<string> inputList, string check)
        {
            foreach (string item in inputList)
            {
                if (item.ToLower().Contains(check.ToLower()))
                    return true;
            }

            return false;
        }

        public static string SHA1(string input)
        {
            using SHA1Managed sHA1Managed = new SHA1Managed();
            byte[] array = sHA1Managed.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder stringBuilder = new StringBuilder(array.Length * 2);
            byte[] array2 = array;
            foreach (byte b in array2)
            {
                stringBuilder.Append(b.ToString("x2"));
            }

            return stringBuilder.ToString();
        }

        public static bool ContainsIgnoreCase(this string input, string check)
        {
            return (input.ToLower().Contains(check.ToLower()));
        }

        public static string EncodeURL(this string input)
        {
            return HttpUtility.UrlEncode(input);
        }

    }
}
