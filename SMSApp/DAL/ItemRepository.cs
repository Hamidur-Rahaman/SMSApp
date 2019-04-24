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
    public class ItemRepository
    {
        SqlFactory _sqlFactory = new SqlFactory();

        public bool SaveItem(Item item)
        {
            bool isSave = false;
            try
            {

                string query = @"insert into Item (CategoryID,CompanyID,ItemName,ReorderLevel,AvailableQuantity) values (" + item.CategoryID + "," + item.CompanyID + ",'" + item.ItemName + "'," + item.ReorderLevel + "," + item.AvailableQuantity + ")";
                isSave = _sqlFactory.Add(query);
            }
            catch (Exception ex)
            {
                isSave = false;
                MessageBox.Show(ex.Message);
                throw;
            }

            return isSave;
        }

        public DataTable SearchItem(int Company, int Category)
        {
            DataTable dataTable = new DataTable();
            try
            {
                string query = @"SELECT * FROM V_SearchItem WHERE CompanyID = '" + Company + "' AND CategoryID = '" + Category + "'";
                dataTable = _sqlFactory.GetAll(query);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            return dataTable;
        }

        public DataTable GetLoadCategoryCombo()
        {
            DataTable dataTable = new DataTable();
            try
            {
                string query = @"select ID,Name from Category";
                dataTable = _sqlFactory.GetAll(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            return dataTable;
        }
        public DataTable GetLoadCompanyCombo()
        {
            DataTable dataTable = new DataTable();
            try
            {
                string query = @"select ID,Name from Company";
                dataTable = _sqlFactory.GetAll(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dataTable;
        }
        public bool Exists(string item)
        {
            bool isExist = false;
            try
            {
                string query = @"select * from Item where ItemName='" + item + "'";
                isExist = _sqlFactory.Exsits(query);
            }
            catch (Exception ex)
            {
                isExist = false;
                MessageBox.Show(ex.Message);
            }
            return isExist;
        }
    }
}
