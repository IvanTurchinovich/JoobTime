using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace JoobTime
{
    class Class_sql
    {
        public string con_string =
            string.Format(@"Data Source=tcp:{0}\sqlexpress;Initial Catalog='DB1';User ID={1};Password={2}",
                xlsx_.read_xlsx("conection_ip"), xlsx_.read_xlsx("conecction_id"), xlsx_.read_xlsx("conection_pas"));
        /// <summary>
        /// возвращает DataSet
        /// </summary>
        /// <param name="query"></param>
        /// <param name="name_table"></param>
        /// <returns></returns>
        public DataSet ds_query( string query, string name_table)
        {
            SqlConnection connect1 = new SqlConnection(con_string);
            DataSet ds = new DataSet();
            try
            {
                connect1.Open();
                using (SqlDataAdapter dt1 = new SqlDataAdapter(query, connect1))
                {
                    dt1.Fill(ds, name_table);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка Class_sql.ds_query! Проблемы с подключением.");
                return null;
            }
            finally
            {
                connect1.Close();
            }
            return ds;
        }

        public SqlDataAdapter sql_da(string query,string name_table)
        {
            SqlConnection connect1 = new SqlConnection(con_string);
            DataSet ds = new DataSet();
            SqlDataAdapter w;
            connect1.Open();
            try
            {
                using (w = new SqlDataAdapter(query, connect1))
                {
                    w.Fill(ds, name_table);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка Class_sql.da! Проблемы с подключением.");
                return null;
            }
            finally
            {
                connect1.Close();
            }
            
            return w;
        }
        
        /// <summary>
        /// возвращает BindingSource
        /// </summary>
        /// <param name="query"></param>
        /// <param name="name_table"></param>
        /// <returns></returns>
        public BindingSource bs_query(string query, string name_table)
        {
            DataSet ds = new DataSet();
            ds = ds_query(query, name_table);
            BindingSource bs = new BindingSource(ds, name_table);
            return bs;
        }

        /// <summary>
        /// Отправляет запрос на сервер
        /// </summary>
        /// <param name="query"></param>
        public void update_comand (string query)
        {
            SqlConnection connect1 = new SqlConnection(con_string);
            connect1.Open();
            try
            {
                using (SqlCommand com1 = connect1.CreateCommand())
                {
                    com1.Connection = connect1;
                    com1.CommandText = query;
                    com1.ExecuteNonQuery();
                }

            }
            catch
            {
                MessageBox.Show("Ошибка Class_sql.update_comand! Проблемы с подключением или запросом.");
            }
            finally
            {
                connect1.Close();
            }
        }

        /// <summary>
        /// отправляет запрос на сервер и возвращает true если нет ошибки, false если докумещна ошибка
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public bool UpdateComand(string query)
        {
            SqlConnection connect1 = new SqlConnection(con_string);
            connect1.Open();
            try
            {
                using (SqlCommand com1 = connect1.CreateCommand())
                {
                    com1.Connection = connect1;
                    com1.CommandText = query;
                    com1.ExecuteNonQuery();
                }
                return true;
            }
            catch
            {
                MessageBox.Show("Ошибка Class_sql.update_comand! Проблемы с подключением или запросом.");
                return false;
            }
            finally
            {
                connect1.Close();
            }
        }

        public void baskUp_DB()
        {
            SqlConnection connect1 = new SqlConnection(con_string);
            connect1.Open();
            try
            {
                using (SqlCommand com1 = new SqlCommand())
                {
                    com1.Connection = connect1;
                    com1.CommandText = @"BACKUP DATABASE [DB1] TO  DISK = N'D:\backup_DB1_joob_time' WITH NOFORMAT, NOINIT,  NAME = N'DB1-Полная База данных Резервное копирование', SKIP, NOREWIND, NOUNLOAD,  STATS = 10";
                    com1.ExecuteNonQuery();
                }
            }
            catch
            {
                MessageBox.Show("Ошибка резервного копирования базы данных. Обратитесь к администратору.");
            }
            finally 
            {
                connect1.Close();
            }
        }

        /// <summary>
        /// возвращает DataTable
        /// </summary>
        /// <param name="query"></param>
        /// <param name="name_t"></param>
        /// <returns></returns>
        public DataTable sql_dt(string query, string name_t)
        {
            Class_sql w = new Class_sql();
                DataTable dt = w.ds_query(query, name_t).Tables[name_t];
            return dt;
        }
    }
}
