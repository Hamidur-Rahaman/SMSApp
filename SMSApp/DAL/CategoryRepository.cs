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
    public class CategoryRepository
    {
        SqlFactory _sql = new SqlFactory();
        public bool SaveCategory(Category category)
        {
            string query = "";
            bool isSave = false;
            try
            {
                if (category.ID > 0)
                {
                    query = @"UPDATE Category SET Name= '" + category.Name + "' WHERE ID= " + category.ID + "";
                }
                else
                {
                    query = @"INSERT INTO Category(Name) VALUES ('" + category.Name + "')";
                }
                isSave = _sql.Add(query);

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            return isSave;
        }

        public bool UpdateCategory(Category category)
        {
            bool isUpdate = false;

            try
            {
                string query = @"UPDATE Category SET Name= '" + category.Name + "' WHERE ID= " + category.ID + "";
                isUpdate = _sql.Update(query);

            }
            catch (Exception exception)
            {
                isUpdate = false;
                MessageBox.Show(exception.Message);
            }
            return isUpdate;
        }

        public DataTable GetCategory()
        {
            DataTable dataTable = new DataTable();
            try
            {

                string query = @"SELECT * FROM Category";
                dataTable = _sql.GetAll(query);

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            return dataTable;
        }


        public bool Exists(Category category)
        {

            bool isExists = false;
            try
            {
                string query = @"SELECT * FROM Category WHERE Name = '" + category.Name + "'";
                isExists = _sql.Exsits(query);

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
