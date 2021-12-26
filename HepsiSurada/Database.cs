using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace HepsiSurada
{
    class Database
    {
        public SqlConnection conn;
        public SqlCommand cmd;

        public void Baglan()
        {
            conn = new SqlConnection("Data Source=DESKTOP-OOJJ30N\\SQLEXPRESS;Initial Catalog=HepsiSurada;Integrated Security=True");
            cmd = new SqlCommand();
            cmd.Connection = conn;
        }
    }
}
