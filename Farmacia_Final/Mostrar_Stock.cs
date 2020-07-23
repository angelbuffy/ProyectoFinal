﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Farmacia_Final
{
    public class Mostrar_Stock
    {
        public DataTable MostrarStock()
        {
            SqlConnection conexion = new SqlConnection("server=.;database = Farmacia; integrated security=true");
            SqlDataAdapter da = new SqlDataAdapter("MostrarStock", conexion);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            conexion.Open();
            conexion.Close();
            return dt;
        }
    }
}
