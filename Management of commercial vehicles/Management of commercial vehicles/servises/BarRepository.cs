using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Management_of_commercial_vehicles
{
    class BarRepository : IBarRepository
    {
        private string Iconnection = "Data Source =.;Initial Catalog=bar;Integrated Security=true";
        public bool delete(int ID)
        {
            throw new NotImplementedException();
        }

        public bool insert(string origin, string destination, int Amount, string bar_owner, string Driver, string Date)
        {
            throw new NotImplementedException();
        }

        public DataTable selectAll()
        {
            string query = "Select * from Bar";
            SqlConnection connection = new SqlConnection(Iconnection);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        public DataTable selectRow(int ID)
        {
            throw new NotImplementedException();
        }

        public bool update(int ID, string origin, string destination, int Amount, string bar_owner, string Driver, string Date)
        {
            throw new NotImplementedException();
        }
    }
}
