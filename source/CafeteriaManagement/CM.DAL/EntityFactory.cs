using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.DAL
{
    public static class EntityFactory
    {
        public static ITable GetTableFrom(CMDataContext database, string tableName)
        {
            if (tableName == "PRODUCT")
            {
                return database.PRODUCTs;
            }
            if (tableName == "PRODUCTTYPE")
            {
                return database.PRODUCTTYPEs;
            }
            if (tableName == "BILL")
            {
                return database.BILLs;
            }
            if (tableName == "EMPLOYEE")
            {
                return database.EMPLOYEEs;
            }
            if (tableName == "CUSTOMER")
            {
                return database.CUSTOMERs;
            }
            if (tableName == "PRODUCT_BILL")
            {
                return database.PRODUCT_BILLs;
            }
            return null;
        }
    }
}
