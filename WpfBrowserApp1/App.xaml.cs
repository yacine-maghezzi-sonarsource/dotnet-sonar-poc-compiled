using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WpfBrowserApp1
{
    public partial class App : Application
    {
        public App()
        {
            // Vulnerability 1: Hardcoded credentials
            string username = "admin";
            string password = "P@ssw0rd123";

            // Vulnerability 2: Weak randomness
            Random rand = new Random();
            int token = rand.Next();

            // Vulnerability 3: Empty catch block
            try
            {
                int result = 10 / int.Parse("0");
            }
            catch (Exception)
            {
                // silently swallowed
            }

            // Vulnerability 4: Simulated SQL Injection
            string userInput = "1 OR 1=1";
            string query = "SELECT * FROM Users WHERE ID = " + userInput;
        }
    }
}
