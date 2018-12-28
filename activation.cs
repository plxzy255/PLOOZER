using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO.IsolatedStorage;

namespace Ploozer
{
    class activation
    {
        const string connectionString = "Server = ploozer.database.windows.net;  DATABASE = Ploozer; USER ID = Plozy; PASSWORD = Potato#257;";
        private static bool Activated { get; set; }

        public static bool isActivated(string key)
        {
            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {
                string checkForActivationQuery = "SELECT activated FROM activationTable WHERE serialKey =@key";
                SqlCommand cmd = new SqlCommand(checkForActivationQuery, sqlConn);
                cmd.Parameters.AddWithValue("@key", key);
                sqlConn.Open();
                int result = Convert.ToInt32(cmd.ExecuteScalar());
                if (result > 0)
                {
                    return true;
                }
                return false;
            }
        }
        public static void activateSoftware(string key)
        {
            if (!isActivated(key))
            {
                using(SqlConnection sqlConn = new SqlConnection(connectionString))
                {
                    string checkForKeyQuery = "SELECT COUNT (*) FROM activationTable WHERE serialKey =@key";
                    SqlCommand cmd = new SqlCommand(checkForKeyQuery, sqlConn);
                    cmd.Parameters.AddWithValue("@key", key);
                    sqlConn.Open();
                    int result = Convert.ToInt32(cmd.ExecuteScalar());
                    if (result > 0)
                    {
                        updateActivaton(key);
                        using (IsolatedStorageFile isolatedStorageFile = IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Assembly, null, null))
                        {
                            using (IsolatedStorageFileStream isolatedStorageFileStream = new IsolatedStorageFileStream("settings.txt",System.IO.FileMode.Create, isolatedStorageFile))
                            {
                                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(isolatedStorageFileStream))
                                {
                                    sw.WriteLine(key);
                                }
                            }
                        }
                            Activated = true;
                    }
                    else
                    {
                        MessageBox.Show("Your key was incorrect");
                    Activated = false;
                    }
                }
                }
                else
                {
                MessageBox.Show("Your Software is already activated");
                Activated = true;
                }
            }
            private static void updateActivaton(string key)
            {
            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {
                string updateQuery = "UPDATE activationTable SET activated = 1 WHERE serialkey =@key";
                SqlCommand cmd = new SqlCommand(updateQuery, sqlConn);
                cmd.Parameters.AddWithValue("@key", key);
                sqlConn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Your Software has been activated");
            }
        }
    }
}
