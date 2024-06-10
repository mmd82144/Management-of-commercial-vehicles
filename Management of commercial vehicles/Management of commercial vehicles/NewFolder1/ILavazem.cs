using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_of_commercial_vehicles
{
    interface ILavazem
    {
        DataTable selectAll();
        DataTable selectRow(int ID);
        bool insert(String name, int amountofwork);
        bool update(int ID, String name, int amountofwork);
        bool delete(int ID);
    }
}
