using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ElLib.Common.Converter;

namespace ElLib.Common.ProcedureExecuter
{
    public class ProcedureExecuter : IProcedureExecuter
    {
        public string ConnectionString { get; set; }
        public ICollection<SqlParameter> Parameters { get; set; }

        public ProcedureExecuter()
        {
            Parameters = new List<SqlParameter>();
        }

        public void ExecuteVoid(string storedProcedure)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(storedProcedure, connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    foreach (var parameter in Parameters)
                    {
                        cmd.Parameters.AddWithValue(parameter.ParameterName, parameter.SqlValue);
                    }

                    connection.Open();

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }   
                    finally
                    {
                        cmd.Parameters.Clear();
                        Parameters.Clear();
                    }
                }
            }
        }

        public IEnumerable<T> Execute<T>(string storedProcedure, IConverter<T> converter)
            where T : class
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(storedProcedure, connection))
                {
                    connection.Open();

                    cmd.CommandType = CommandType.StoredProcedure;

                    foreach (var parameter in Parameters)
                    {
                        cmd.Parameters.AddWithValue(parameter.ParameterName, parameter.SqlValue);
                    }

                    try
                    {
                        cmd.ExecuteNonQuery();

                        ICollection<T> list = new List<T>();

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                list.Add(converter.FromReader(reader));
                            }
                        }

                        reader.Close();

                        return list;
                    }
                    finally
                    {
                        cmd.Parameters.Clear();
                        Parameters.Clear();
                    }
                }
            }
        }
    }
}
