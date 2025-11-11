using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PR2
{
    internal class UserSession
    {
        public static int UserID { get; private set; }
        public static string Email { get; private set; }
        public static DateTime LoginTime { get; private set; }
        public static DateTime LastActivity { get; private set; }

        // Propriedades derivadas
        public static bool IsLoggedIn => UserID > 0;
        public static TimeSpan SessionDuration => DateTime.Now - LoginTime;

        // Gerenciamento de sessão
        public static void Login(int userId, string email)
        {
            UserID = userId;
            Email = email;
            LoginTime = DateTime.Now;
            LastActivity = DateTime.Now;

            UpdateDatabaseLoginTime();
        }

        public static void Logout()
        {
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
                return "Nenhuma sessão ativa";

            return $"Usuário: {Email} | Logado às: {LoginTime:HH:mm}";
        }

        // Métodos de atualização do banco de dados
        private static void UpdateDatabaseLoginTime()
        {
            try
            {
                string connectionString = "Data Source=sqlexpress;Initial Catalog=CJ3022d04PR2;User ID=aluno;Password=aluno;";

                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = @"UPDATE Users 
                              SET LoginTime = @LoginTime, 
                                  LastActivity = @LastActivity 
                              WHERE UserID = @UserID";

                    using (var command = new SqlCommand(sql, connection))
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
                System.Diagnostics.Debug.WriteLine($"Erro ao atualizar horário de login: {ex.Message}");
            }
        }

        private static void UpdateDatabaseLastActivity()
        {
            try
            {
                string connectionString = "Data Source=sqlexpress;Initial Catalog=CJ3022d04PR2;User ID=aluno;Password=aluno;";

                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "UPDATE Users SET LastActivity = @LastActivity WHERE UserID = @UserID";

                    using (var command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@LastActivity", LastActivity);
                        command.Parameters.AddWithValue("@UserID", UserID);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Erro ao atualizar última atividade: {ex.Message}");
            }
        }
    }
}

