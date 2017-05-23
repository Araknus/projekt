using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Npgsql;

namespace ProjektZPO
{
    public class UserPersistance
    {
        public string test;

        public UserPersistance()
        {
            try
            {
                string connString = "Server=127.0.0.1; Port=5432; User Id=postgres; Password=qwerty; Database=ProjectZPO";
                NpgsqlConnection connection = new NpgsqlConnection(connString);

                connection.Open();

                NpgsqlCommand command = new NpgsqlCommand("INSERT INTO public.\"UserTable\" (id_number, first_name, surname, email, state, type) VALUES (12345678, Daniel, Baniel, qwe@qwe.com, 1, 1)", connection);
                command.ExecuteNonQuery();
                

                command = new NpgsqlCommand("SELECT * FROM public.\"UserTable\"", connection);
                NpgsqlDataReader reader = command.ExecuteReader();

                this.test = reader[0].ToString();

                connection.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}