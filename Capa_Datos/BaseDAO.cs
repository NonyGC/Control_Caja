﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Capa_Datos
{
    public class BaseDAO
    {
        protected SqlConnection conexion()
        {
            SqlConnection conexionValue = new SqlConnection();
            try
            {
                if (conexionValue.State == ConnectionState.Open)
                {
                    conexionValue.Close();
                }
                conexionValue.ConnectionString = ConfigurationManager.ConnectionStrings["CapaPresentacion.Properties.Settings.Conn2"].ConnectionString;
                conexionValue.Open();
            }
            catch (Exception ex)
            {
                RadMessageBox.SetThemeName("VisualStudio2012Light");
                RadMessageBox.Show(ex.Message, "", MessageBoxButtons.OK, RadMessageIcon.Info);
            }
            return conexionValue;
        }


        protected SqlCommand Parameters(SqlCommand cmd, object[] env)
        {
            string procedure = cmd.CommandText;
            try
            {
                SqlCommandBuilder.DeriveParameters(cmd);
                int c = 0;

                foreach (SqlParameter prm in cmd.Parameters)
                {
                    if (prm.ParameterName != "@RETURN_VALUE")
                    {
                        prm.Value = env[c];
                        c += 1;
                        Debug.WriteLine(prm.Value);
                    }
                }
                return cmd;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(procedure + "- " + ex.Message);
                return null;
            }

        }

        protected SqlCommand CommandProcedure(string name)
        {
            SqlCommand cmd = new SqlCommand(name, conexion());
            cmd.CommandType = CommandType.StoredProcedure;
            return cmd;
        }

        protected SqlCommand CommandText(string text)
        {
            SqlCommand cmd = new SqlCommand(text, conexion());
            cmd.CommandType = CommandType.Text;
            return cmd;
        }

        protected DataTable GetDataTable(SqlCommand cmd)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            CloseDB();
            return dt;
        }
        //protected DataSet GetDataTable(SqlCommand cmd, string TableName)
        //{
        //    DataSet dt = new DataSet();
        //    SqlDataAdapter da = new SqlDataAdapter();
        //    da.SelectCommand = cmd;
        //    da.Fill(dt, TableName);
        //    CloseDB();
        //    return dt;
        //}

        protected void CloseDB()
        {
            if (conexion() == null)
                return;
            if (conexion().State == ConnectionState.Open)
            {
                conexion().Close();
            }
        }

    }
}
