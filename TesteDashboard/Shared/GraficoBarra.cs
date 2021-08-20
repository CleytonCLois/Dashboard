using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace TesteDashboard.Shared
{
    public class GraficoBarra
    {
        public double valores { get; set; }
    }

    //public List<GraficoBarra> GetEmplyees()
    //{
    //    List<GraficoBarra> rowAffected;
    //    using (IDbConnection con = new MySqlConnection(_configuration.GetConnectionString("dbConnectionString")))
    //    {
    //        if (con.State == ConnectionState.Closed)
    //            con.Open();

    //        const string insertQuery = @"SELECT * FROM `Employee`";

    //        rowAffected = con.Query<GraficoBarra>(insertQuery).AsList<GraficoBarra>();
    //    }
    //    return rowAffected;
    //}
}
