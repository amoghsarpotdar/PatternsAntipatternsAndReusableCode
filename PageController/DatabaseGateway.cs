using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace PageController
{
    public class DatabaseGateway
    {
        public static string RetrieveAddress(string name)
        {
            String address = null;
            String selectCmd = String.Format("Select * from webuser where (id = '{0}')", name);

            //Establish connection and retrieve data here.
            DataSet ds = new DataSet();
            //.
            //.
            //.

            return address;
        }
    }
}