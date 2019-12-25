using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinema_hall_management_system.BL
{
    class Tickets
    {

        DAL.DatabaseConnector dbc = new DAL.DatabaseConnector();

        public List<Model.HelperModelForTicket> showTicEverything(String search)
        {
            try
            {
                return dbc.showTicEverything(search);
            }catch (Exception err)
            {
                throw err;
            }

        }
    }
}
