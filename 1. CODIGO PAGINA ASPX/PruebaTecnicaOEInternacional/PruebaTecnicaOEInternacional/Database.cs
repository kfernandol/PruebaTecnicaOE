using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PruebaTecnicaOEInternacional
{
    public class Database
    {
        private readonly string _connectionString;
        public Database(string connectionString)
        {
            _connectionString = connectionString;
        }

        /// <summary>
        /// Metodo que devuelve los datoss de un select
        /// </summary>
        /// <param name="querySQL">Query SQL que permite obtener los datos usando un select</param>
        /// <returns></returns>
        public DataSet ExecuteQuery(string querySQL)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(querySQL, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);
                    return dataSet;
                }
            }
        }

        /// <summary>
        /// Metodo que permite ejecutar INSERT, UPDATE o DELETE
        /// </summary>
        /// <param name="querySQL">Query SQL para ejecutar el INSERT, UPDATE o DELETE</param>
        /// <returns></returns>
        public int ExecuteNonQuery(string querySQL)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(querySQL, connection))
                {
                    return command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Metodo que devuelve el numero de filas al ejecutar un select
        /// </summary>
        /// <param name="querySQL">Query SQL para buscar datos y devolver el numero de filas encontradas</param>
        /// <returns></returns>
        public int GetRowCount(string querySQL)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(querySQL, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataSet dataSet = new DataSet();
                    int rows = adapter.Fill(dataSet);
                    return rows;
                }
            }
        }
    }

}