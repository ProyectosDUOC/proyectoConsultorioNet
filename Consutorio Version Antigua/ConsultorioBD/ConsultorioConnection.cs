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

          public ConsultorioConnection()
          {
              _connection = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Consultorios;Integrated Security=true");
          }
         
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
