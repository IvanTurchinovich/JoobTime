using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace JoobTime
{
    class sql
    {
        private DataSet dataset = new DataSet();
        private SqlDataAdapter dataadapter;
        private SqlConnection conn;

        public sql()
        {
            var domain = System.Net.NetworkInformation.IPGlobalProperties.GetIPGlobalProperties().DomainName;
            connection = domain.Equals("kb.polesie")
                ? @"Data Source=tcp:192.168.5.14,1433\sqlexpress;Initial Catalog=DB1;User ID=sa;Password=9293709b13"
                : @"Data Source=tcp:192.168.76.22,1433\sqlexpress;Initial Catalog=DB1;User ID=sa;Password=9293709b13";
        }

        private string connection;
        private string error_foruser;

        public string getError()
        {
            return error_foruser;
        }
        public DataSet GetSQLTable(string command)
        {
            if (dataset.Tables.Count > 0)
                dataset.Tables.Remove("table");
            try
            {
                if (!createconnection())
                {
                    error_foruser = "Ошибка подключения к базе данных. Повторите позже";
                    return dataset;
                }
                dataadapter = new SqlDataAdapter(command, conn);
                dataadapter.Fill(dataset, "table");
                if (dataset.Tables["table"].Rows.Count == 0)
                {
                    error_foruser = "Введены неверные данные, повторите запрос";
                    return dataset;
                }
                error_foruser = null;
                return dataset.Copy();
            }
            catch
            {
                error_foruser = "Ошибка чтения базы данных. Повторите позже";
                return dataset;
            }
            finally
            {
                closeconnection();
            }
        }
        public Boolean SetSQLTable(string command)
        {
            try
            {
                if (!createconnection())
                {
                    error_foruser = "Ошибка подключения к базе данных. Повторите позже";
                    return false;
                }
                new SqlCommand(command, conn).ExecuteNonQuery();
                error_foruser = null;
                return true;
            }
            catch 
            {
                error_foruser = "Ошибка записи базы данных. Повторите позже";
                return false;
            }
            finally
            {
                closeconnection();
            }
        }
        private Boolean createconnection()
        {
            try
            {
                conn = new SqlConnection(connection);
                conn.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }
        private void closeconnection()
        {
            conn.Close();
        }
    }
}
