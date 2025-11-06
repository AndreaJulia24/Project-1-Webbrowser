using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Diagnostics;

namespace Project_1_Webbrowser
{
    internal class DatabaseManager
    {
        private const string DbFileName = "blockedWords.db";
        // A Data Source elérési útját az alkalmazás futási mappájához igazítjuk
        private readonly string _connectionString = $"Data Source={DbFileName};Version=3;";
       

        public DatabaseManager()
        {
            initializeDatabase();
        }
        private void initializeDatabase()
        {
            if (!System.IO.File.Exists(DbFileName))
            {
                SQLiteConnection.CreateFile(DbFileName);
                using (var connection = new SQLiteConnection(_connectionString))
                {
                    connection.Open();
                    string sql = @"
                    CREATE TABLE IF NOT EXISTS Keywords (
                        ID INTEGER PRIMARY KEY AUTOINCREMENT,
                        Word TEXT UNIQUE NOT NULL
                    );";
                    using (var command = new SQLiteCommand(sql, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        public List<string> LoadKeywords()
        {
            var keywords = new List<string>();
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string sql = "SELECT Word FROM Keywords ORDER BY Word;";
                using (var command = new SQLiteCommand(sql, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        keywords.Add(reader["Word"].ToString());
                    }
                }
            }
            return keywords;
        }

        public bool AddKeyword(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword)) return false;

            try
            {
                using (var connection = new SQLiteConnection(_connectionString))
                {
                    connection.Open();
                    string sql = "INSERT INTO Keywords (Word) VALUES (@Word)";

                    using (var command = new SQLiteCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Word", keyword.Trim().ToLower());
                        return command.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (SQLiteException ex) when (ex.Message.Contains("UNIQUE constraint failed"))
            {
                return false; // Duplikátum hiba
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"DB Hiba: {ex.Message}");
                return false;
            }
        }

        public bool DeleteKeyword(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword)) return false;

            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string sql = "DELETE FROM Keywords WHERE Word = @Word";
                using (var command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Word", keyword.Trim());
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }
    }

}
