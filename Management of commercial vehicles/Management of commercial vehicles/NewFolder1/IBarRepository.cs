using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Management_of_commercial_vehicles
{
    interface IBarRepository
    {
        DataTable selectAll();
        DataTable selectRow(int ID);


        bool insert(string origin , string destination , int Amount , string bar_owner , string Driver ,string Date);
        bool update(int ID, string origin, string destination, int Amount, string bar_owner, string Driver, string Date);
        bool delete(int ID);
        void insert(string v1, object origin, string v2);
    }
}

