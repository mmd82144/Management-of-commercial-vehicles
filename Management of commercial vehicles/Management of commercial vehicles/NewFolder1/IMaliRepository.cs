using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Management_of_commercial_vehicles
{
    interface IMaliRepository
    {
        DataTable selectAll();
        DataTable selectRow(int ID);


        bool insert(string by, string car, int fore, string value, string date);
        bool update(int ID, string by, string car, int fore, string value, string date);
        bool delete(int ID);
    }
}
