using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace ConsultorioBD
{
    public class ConsultorioConnection
    {
          private SqlConnection _connection;

          private ConsultorioConnection() { }
         
          public ConsultorioConnection(String connectionString)
            {
                _connection = new SqlConnection(connectionString);
            }

            public SqlConnection getConnection()
            {
                return _connection;
            }
    }
}
