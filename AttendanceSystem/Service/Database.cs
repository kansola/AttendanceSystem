using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace AttendanceSystem.Service
{
    public class Database
    {
        public string GetConnectionSetting()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["AttendanceConnString"].ConnectionString;
            return connectionString;
        }
    }
}