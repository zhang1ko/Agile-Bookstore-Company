using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections.ObjectModel;


namespace BookStoreLIB
{
    public class ViewHistory
    {
        DALViewHistory dvh = new DALViewHistory();

        public DataSet getOrders(int uid)
        {
            return dvh.getOrders(uid);
        }

        public DataSet getDetails(int oid)
        {
            return dvh.getDetails(oid);
        }
    }

}
