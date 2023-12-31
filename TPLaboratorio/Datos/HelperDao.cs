﻿using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace TPLaboratorio.Datos
{
    public class HelperDao
    {
        private SqlConnection conexion;
        private static HelperDao instance;

        public HelperDao()
        {
            conexion = new SqlConnection(Properties.Resources.CadenaConexion);
        }

        public static HelperDao ObtenerInstancia()
        {
            if (instance == null)
            {
                instance = new HelperDao();
            }
            return instance;
        }

        public SqlConnection ObtenerConexion()
        {
            return this.conexion;
        }

        public int ProximaOrden(string sentencia, string nombParam)
        {
            int aux = 0;
            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = sentencia;
            SqlParameter sqlParameter = new SqlParameter(nombParam, SqlDbType.Int);
            sqlParameter.Direction = ParameterDirection.Output;
            comando.Parameters.Add(sqlParameter);
            comando.ExecuteNonQuery();
            conexion.Close();
            aux = (int)sqlParameter.Value;
            return aux;
        }


        public DataTable Consultar(string nombreSP)
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombreSP;
            DataTable dt = new DataTable();
            dt.Load(comando.ExecuteReader());
            conexion.Close();
            return dt;
        }


        internal DataTable Consultar(string nombreSP, List<Parametro> lParam)
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombreSP;

            foreach (Parametro param in lParam)
            {
                comando.Parameters.AddWithValue(param.Nombre, param.Valor);
            }

            DataTable dt = new DataTable();
            dt.Load(comando.ExecuteReader());
            conexion.Close();
            return dt;
        }
        public DataTable ConsultaSql(string consulta)
        {
            conexion.Open();
            DataTable tabla = new DataTable();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = consulta;
            tabla.Load(comando.ExecuteReader());
            conexion.Close();
            return tabla;
        }

        public int EjecutarSQL(string strSql, List<Parametro> values)
        {
            int afectadas = 0;
            SqlTransaction t = null;

            try
            {
                SqlCommand cmd = new SqlCommand();
                conexion.Open();
                t = conexion.BeginTransaction();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = strSql;
                cmd.Transaction = t;

                if (values != null)
                {
                    foreach (Parametro param in values)
                    {
                        cmd.Parameters.AddWithValue(param.Nombre, param.Valor);
                    }
                }

                afectadas = cmd.ExecuteNonQuery();
                t.Commit();
            }
            catch (SqlException)
            {
                if (t != null) { t.Rollback(); }
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                    conexion.Close();

            }

            return afectadas;
        }
    }
}
