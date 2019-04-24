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
    public class StockOutRepository
    {
        SqlFactory _sqlFactory = new SqlFactory();
        private DataTable _dataTable;
        public bool SaveStockOut(List<StockOut> stockOuts, List<Item> items)
        {
            bool isSave = false;
            foreach (var list in stockOuts)
            {
                string query =
                        @"INSERT INTO StockOut (CompanyID, ItemID, StockOutQuantity, StockOutDate, Status )VALUES('" +
                        list.CompanyID + "', '" + list.ItemID + "', '" + list.StockOutQuantity + "', '" +
                        list.StockOutDate + "', '" + list.Status + "')";
                isSave = _sqlFactory.Add(query);

            }
            foreach (var item in items)
            {
                string query = @"UPDATE Item Set AvailableQuantity = '" + item.AvailableQuantity + "' WHERE ID = '" +
                           item.ID + "'";
                if (isSave)
                {
                    isSave = _sqlFactory.Update(query);
                }
            }
            return isSave;
        }

        public Item GetFieldData(StockOut stockOut)
        {
            Item item = new Item();
            _dataTable = new DataTable();
            string query = @"SELECT ReorderLevel, AvailableQuantity FROM Item WHERE  ID = '" + stockOut.ItemID + "'";
            _dataTable = _sqlFactory.GetFieldData(query);
            foreach (DataRow list in _dataTable.Rows)
            {
                item.ReorderLevel += Convert.ToDecimal(list["ReorderLevel"]);
                item.AvailableQuantity += Convert.ToDecimal(list["AvailableQuantity"]);
            }
            return item;
        }

        public DataTable GetItemComboData(Item item)
        {
            _dataTable = new DataTable();
            string query = @"SELECT ID, ItemName FROM Item WHERE  CompanyID = '" + item.CompanyID + "'";
            _dataTable = _sqlFactory.GetAll(query);
            return _dataTable;
        }
        public DataTable GetCompanyComboData()
        {
            _dataTable = new DataTable();
            string query = @"SELECT ID, Name FROM Company";
            _dataTable = _sqlFactory.GetAll(query);
            return _dataTable;
        }
        public DataTable DateWiseSearch(StockOut stockOut)
        {
            DataTable dataTable = new DataTable();

            try
            {

                string query = @"SELECT * FROM V_SearchSales where StockOutDate BETWEEN '" + stockOut.StockOutDate + "' AND '" + stockOut.StockToDate + "' AND Status= '" + "S" + "'";
                dataTable = _sqlFactory.GetAll(query);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            return dataTable;
        }
    }
}
