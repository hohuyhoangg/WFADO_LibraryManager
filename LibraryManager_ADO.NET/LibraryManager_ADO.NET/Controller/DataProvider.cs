﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager_ADO.NET.Controller
{
    public class DataProvider
    {
        private static DataProvider instance;
        private string connectionString = @"Data Source=(local);Initial Catalog=LibraryManager;Integrated Security=True";

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set => instance = value;
        }
        private DataProvider() { }
        public DataTable ExcuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] ListPara = query.Split(' ');// cắt chuỗi theo khoảng trắng
                    int i = 0;
                    foreach (string item in ListPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);

                connection.Close();
            }
            return data;
        }
        public int ExcuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] ListPara = query.Split(' ');// cắt chuỗi theo khoảng trắng
                    int i = 0;
                    foreach (string item in ListPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteNonQuery();

                connection.Close();
            }
            return data;
        }
        public object ExcuteScalar(string query, object[] parameter = null)
        {
            object data = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] ListPara = query.Split(' ');// cắt chuỗi theo khoảng trắng
                    int i = 0;
                    foreach (string item in ListPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteScalar();

                connection.Close();
            }
            return data;
        }
    }

}
