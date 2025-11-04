using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PR2
{

    public static class UserSession
    {
        // Core user properties (only what you asked for)
        public static int UserID { get; private set; }
        public static string Email { get; private set; }
        public static DateTime LoginTime { get; private set; }
        public static DateTime LastActivity { get; private set; }

        // Derived properties
        public static bool IsLoggedIn => UserID > 0;
        public static TimeSpan SessionDuration => DateTime.Now - LoginTime;

        // Session management
        public static void Login(int userId, string email)
        {
            UserID = userId;
            Email = email;
            LoginTime = DateTime.Now;
            LastActivity = DateTime.Now;

            // Update database with login time
            UpdateDatabaseLoginTime();
        }

        public static void Logout()
        {
            // Clear all session data
            UserID = 0;
            Email = null;
            LoginTime = DateTime.MinValue;
            LastActivity = DateTime.MinValue;
        }

        public static void UpdateActivity()
        {
            if (IsLoggedIn)
            {
                LastActivity = DateTime.Now;
                UpdateDatabaseLastActivity();
            }
        }

        public static string GetSessionInfo()
        {
            if (!IsLoggedIn)
                return "No active session";

            return $"User: {Email} | Logged in: {LoginTime:HH:mm} | Active: {LastActivity:HH:mm}";
        }

        // Database update methods
        private static void UpdateDatabaseLoginTime()
        {
            try
            {
                using (var connection = new System.Data.SqlClient.SqlConnection("YourConnectionString"))
                {
                    connection.Open();
                    string sql = @"UPDATE Users 
                              SET LoginTime = @LoginTime, 
                                  LastActivity = @LastActivity 
                              WHERE UserID = @UserID";

                    using (var command = new System.Data.SqlClient.SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@LoginTime", LoginTime);
                        command.Parameters.AddWithValue("@LastActivity", LastActivity);
                        command.Parameters.AddWithValue("@UserID", UserID);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Log error but don't crash
                System.Diagnostics.Debug.WriteLine($"Error updating login time: {ex.Message}");
            }
        }

        private static void UpdateDatabaseLastActivity()
        {
            try
            {
                using (var connection = new System.Data.SqlClient.SqlConnection("YourConnectionString"))
                {
                    connection.Open();
                    string sql = "UPDATE Users SET LastActivity = @LastActivity WHERE UserID = @UserID";

                    using (var command = new System.Data.SqlClient.SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@LastActivity", LastActivity);
                        command.Parameters.AddWithValue("@UserID", UserID);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error updating last activity: {ex.Message}");
            }
        }
    }

}