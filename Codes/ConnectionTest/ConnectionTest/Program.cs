using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectionTest
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            string server = "localhost";
            string database = "bookingsystem";
            string username = "root";
            string password = "Ionlylovemyself123!";
            string constring = "Server = " + server + ";" + "DataBase" + database + ";" + "UID = " + username + ";" + "Password = " + password + ";";

            MySqlConnection connection = new MySqlConnection(constring);
            conn.Open();
            string query = "select * from users";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.Writeline(reader{ "UserID"});
                Console.Writeline(reader{ "Grade"});
                Console.Writeline(reader{ "Section"});
            }
        }
    }
}
