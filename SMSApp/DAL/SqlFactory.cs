using System;
using SMSApp.Models;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMSApp.DAL
{
    public class SqlFactory
    {
        private static string _conStr = ConfigurationManager.ConnectionStrings["SMSDbContext"].ToString();
        private static SqlConnection _con = new SqlConnection(_conStr);
        private SqlCommand _cmd = new SqlCommand("", _con);
        private DataTable dataTable;
        private SqlDataAdapter dataAdapter;
        private SqlDataReader dataReader;
        public bool Add(string query)
        {
            bool isResult = false;
            int isExcuted = 0;
            try
            {
                _cmd.CommandText = query;
                _con.Open();
                isExcuted = _cmd.ExecuteNonQuery();
                if (isExcuted > 0)
                {
                    isResult = true;
                }

            }
            catch (Exception ex)
            {
                isResult = false;
                MessageBox.Show(ex.Message);
            }
            finally
            {
                _con.Close();
            }
            return isResult;
        }
        public bool Update(string query)
        {
            bool isResult = false;
            int isExcuted = 0;
            try
            {
                _cmd.CommandText = query;
                _con.Open();
                isExcuted = _cmd.ExecuteNonQuery();
                if (isExcuted > 0)
                {
                    isResult = true;
                }
            }
            catch (Exception ex)
            {
                isResult = false;
                MessageBox.Show(ex.Message);
            }
            finally
            {
                _con.Close();
            }
            return isResult;
        }
        public bool Delete(string query)
        {
            bool isResult = false;
            int isExcuted = 0;
            try
            {
                _cmd.CommandText = query;
                _con.Open();
                isExcuted = _cmd.ExecuteNonQuery();
                if (isExcuted > 0)
                {
                    isResult = true;
                }
            }
            catch (Exception ex)
            {
                isResult = false;
                MessageBox.Show(ex.Message);
            }
            finally
            {
                _con.Close();
            }
            return isResult;
        }
        public DataTable GetAll(string query)
        {
            dataTable = new DataTable();
            try
            {
                _cmd.CommandText = query;
                _con.Open();
                dataAdapter = new SqlDataAdapter(_cmd);
                dataAdapter.Fill(dataTable);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                _con.Close();
            }
            return dataTable;
        }

        public DataTable GetFieldData(string query)
        {
            dataTable = new DataTable();
            try
            {
                _cmd.CommandText = query;
                _con.Open();
                dataReader = _cmd.ExecuteReader();
                dataTable.Load(dataReader);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                _con.Close();
            }
            return dataTable;
        }
        public bool Exsits(string query)
        {
            bool isExsit = false;
            try
            {
                _cmd.CommandText = query;
                _con.Open();
                dataReader = _cmd.ExecuteReader();
                if (dataReader.Read())
                {
                    isExsit = true;
                }
            }
            catch (Exception ex)
            {
                isExsit = false;
                MessageBox.Show(ex.Message);
            }
            finally
            {
                _con.Close();
            }
            return isExsit;
        }
    }
}
