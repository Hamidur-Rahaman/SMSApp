using System;
using SMSApp.Models;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMSApp.DAL
{
    public class CompanyRepository
    {
        SqlFactory _sqlFactory = new SqlFactory();
        public bool SaveCompany(Company company)
        {

            bool isSave = false;
            string query = "";
            try
            {
                if (company.ID > 0)
                {
                    query = @"UPDATE Company SET Name= '" + company.Name + "' WHERE ID= " + company.ID + "";
                }
                else
                {
                    query = @"INSERT INTO Company(Name) VALUES ('" + company.Name + "')";
                }
                isSave = _sqlFactory.Add(query);

            }
            catch (Exception exception)
            {
                isSave = false;
                MessageBox.Show(exception.Message);
            }

            return isSave;
        }

        public DataTable LoadCompany()
        {
            DataTable _dt = new DataTable();
            try
            {
                string query = @"SELECT * FROM Company";
                _dt = _sqlFactory.GetAll(query);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            return _dt;
        }
        public bool NameExists(Company company)
        {

            bool isExists = false;

            try
            {
                string query = @"SELECT * FROM Company WHERE Name = '" + company.Name + "'";
                isExists = _sqlFactory.Exsits(query);

            }
            catch (Exception exception)
            {
                isExists = false;
                MessageBox.Show(exception.Message);
            }

            return isExists;
        }
    }
}
