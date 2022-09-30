using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
namespace DataAccessLayer
{
    public  class DataAccess
    {
        protected MySqlConnection con;
        protected DataAccess()
        {
            string database = ("Server=studmysql01.fhict.local;Uid=dbi476548;Database=dbi476548;Pwd=123;");
            this.con = new MySqlConnection(database);
           
        }
    }
}
