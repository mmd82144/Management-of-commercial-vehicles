using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_of_commercial_vehicles
{
    class Lavazem : ILavazem
    {
        private string Iconnection = "Data Source =.;Initial Catalog=bar;Integrated Security=true";
        public bool delete(int ID)
        {
            throw new NotImplementedException();
        }

        public bool insert(string name, int amountofwork)
        {
            throw new NotImplementedException();
        }

        public DataTable selectAll()
        {
            string query = "Select * from lavazem";
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

        public bool update(int ID, string name, int amountofwork)
        {
            throw new NotImplementedException();
        }
    }
}
