﻿using DBCrudApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBCrudApp.Repositories
{
    public static class PersonRepository
    {
        public static string _connectionString { get; set; } = @"Persist Security Info=False;User ID=sa;Password=nimda;Initial Catalog=TestDb;Data Source=.\SQLSERVER2K22";


        public static List<Person> GetData(string? commandString = "")
        {
            if (string.IsNullOrEmpty(commandString))
            {
                commandString = "Select * FROM TestDB.dbo.Person;";
            }

            var connection = new SqlConnection(_connectionString);
            var command = new SqlCommand(commandString, connection);

            var dataAdapter = new SqlDataAdapter(command);
            var dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            var persons = new List<Person>();

            foreach (DataRow row in dataTable.Rows)
            {
                var person = new Person()
                {
                    Id = (int)row["Id"],
                    FirstName = (string)row["FirstName"],
                    LastName = (string)row["LastName"],
                    Address = row["Address"].ToString()!,
                    Email = (string)row["Email"],
                    Phone = row["Phone"].ToString()!,
                    Designition = (string)row["Designition"],
                    CNIC = (string)row["CNIC"],
                    DOB = (DateTime)row["DOB"],
                    isActive = (bool)row["isActive"],
                };

                persons.Add(person);
            }

            return persons;
        }

    }
}
