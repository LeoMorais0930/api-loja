using Oracle.ManagedDataAccess.Client;
using System.Data;

public class OracleRepository
{
    private readonly OracleConnection _connection;

    public OracleRepository(OracleConnection connection)
    {
        _connection = connection;
    }

    public DataTable ExecuteQuery(string sql)
    {
        var dataTable = new DataTable();

        try
        {
            _connection.Open();
            using (var command = new OracleCommand(sql, _connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    dataTable.Load(reader);
                }
            }
        }
        finally
        {
            _connection.Close();
        }

        return dataTable;
    }

    // Método para INSERT/UPDATE/DELETE
    public int ExecuteNonQuery(string sql, OracleParameter[] parameters = null)
    {
        try
        {
            _connection.Open();
            using (var command = new OracleCommand(sql, _connection))
            {
                if (parameters != null)
                    command.Parameters.AddRange(parameters);

                return command.ExecuteNonQuery();
            }
        }
        finally
        {
            _connection.Close();
        }
    }
}
