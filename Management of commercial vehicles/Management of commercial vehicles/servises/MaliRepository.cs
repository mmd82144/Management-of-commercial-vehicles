using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlClient;

namespace Management_of_commercial_vehicles
{
    class MaliRepository : IMaliRepository
    {
        private string Iconnection = "Data Source =.;Initial Catalog=bar;Integrated Security=true";
        public bool delete(int MyID)
        {
            throw new NotImplementedException();
        }

        public bool insert(string by, string car, int fore, string value, string date)
        {
            throw new NotImplementedException();
        }

        public DataTable selectAll()
        {
            string query = "Select * from mali";
            SqlConnection connection = new SqlConnection(Iconnection);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        public DataTable selectRow(int MyID)
        {
            throw new NotImplementedException();
        }

        public bool update(int MyID, string by, string car, int fore, string value, string date)
        {
            throw new NotImplementedException();
        }
    }
}
