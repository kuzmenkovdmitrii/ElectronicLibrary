using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace ElLib.DAL.StoredProcedure
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
            using (SqlCommand cmd = new SqlCommand(storedProcedure, connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddRange(Parameters.ToArray());

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable Execute(string storedProcedure)
        {
            DataTable table;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            using (SqlCommand cmd = new SqlCommand(storedProcedure, connection))
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();

                connection.Open();

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(Parameters.ToArray());

                da.SelectCommand = cmd;

                cmd.ExecuteNonQuery();

                da.Fill(ds);

                table = ds.Tables[0];
            }

            return table;
        }
    }
}
