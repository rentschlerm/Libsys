﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libsys_Mercado.Connection
{
    internal class Connection
    {
        public static SqlConnection con;
        public static String dbconnect = "Data Source=(localDb)\\db;Initial Catalog=libsys;Integrated Security=True;Pooling=False "; //Connection String

        public static void DB()
        {
            try
            {
                con = new SqlConnection(dbconnect);
                con.Open();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }
    }
}