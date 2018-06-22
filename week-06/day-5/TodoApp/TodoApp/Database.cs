using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using System.IO;

namespace TodoApp
{
    class Database
    {
        public Database()
        {
            string createTableQuery = @"CREATE TABLE IF NOT EXISTS [todos] (
                          [id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                          [text] NVARCHAR(2048)  NULL,
                          [created] DATETIME AUTOCOMPLETE NOT NULL,
                          [completed] DATETIME NOT NULL
                          )";

            if (!File.Exists("./database.sqlite3"))
            {
                SQLiteConnection.CreateFile("database.sqlite3");
                Console.WriteLine("Database file created.");
            }

            using (SQLiteConnection connection = new SQLiteConnection("Data Source=database.sqlite3"))
            {
                using (SQLiteCommand communication = new SQLiteCommand(connection))
                {
                    connection.Open();                             // Open the connection to the database

                    communication.CommandText = createTableQuery;     // Set CommandText to our query that will create the table
                    communication.ExecuteNonQuery();                  // Execute the query

                    GetInfo();
                    communication.ExecuteNonQuery();
                    //communication.CommandText = "INSERT INTO todos (text, created, completed) Values ('buy bread',date('now'),'2018-06-23')";   // Add another entry into our database 
                    //communication.ExecuteNonQuery();      // Execute the query

                    communication.CommandText = "Select * FROM todos";      // Select all rows from our database table

                    using (System.Data.SQLite.SQLiteDataReader reader = communication.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine(reader["text"] + " : " + reader["created"] + " : " + reader["completed"]);     // Display the value of the key and value column for every row
                        }
                    }
                    connection.Close();        // Close the connection to the database
                }
            }
            Console.ReadLine();
        }

        public void GetInfo()
        {
            Console.WriteLine("Give me a todo");
            string todo = Console.ReadLine();
            Console.WriteLine("When do you want it to be completed?");
            string completeDate = Console.ReadLine();
            AddInfos(todo, completeDate);
        }
        public void AddInfos(string the_todo, string the_completeDate)
        {
            var connection = new SQLiteConnection("Data Source=database.sqlite3");
            SQLiteCommand cmd;
            connection.Open();

            try
            {
                cmd = connection.CreateCommand();
                cmd.CommandText = @"INSERT INTO todos (text, created, completed) VALUES ('" + the_todo + "', date('now'), '" + the_completeDate + "');";
                cmd.ExecuteNonQuery();
                Console.WriteLine("Added: " + the_todo + DateTime.Now + the_completeDate + "to the database.");
            }
            catch (Exception e)
            {
                Console.WriteLine("not working "+ e.Data);
                
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
        /*public void AddData(SQLiteCommand saveData)
        {

            saveData.CommandText = "INSERT INTO todos (text, created, completed) Values ('" + the_todo + "', date('now'),'2018-07-24')";     // Add the first entry into our database 
            saveData.ExecuteNonQuery();
        }*/

        public void LoadAll(SQLiteCommand getAll)
        {
            getAll.CommandText = "Select * FROM todos";
        }

        public DateTime createdAtTodo { get; set; }
    }
}
