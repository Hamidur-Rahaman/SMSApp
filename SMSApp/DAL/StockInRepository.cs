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
    public class StockInRepository
    {
        SqlFactory _sqlFactory = new SqlFactory();
        public bool SaveStockIN(StockIN stockIN, Item item)
        {
            bool isSave = false;
            try
            {
                string stockInQuery = @"insert into StockIN (CompanyID,ItemID,StockInQuantity,StockINDate) values (" + stockIN.CompanyID + "," + stockIN.ItemID + "," + stockIN.StockInQuantity + ",'" + stockIN.StockINDate + "')";
                isSave = _sqlFactory.Add(stockInQuery);
                if (isSave)
                {
                    string itemQuery = @"update Item SET AvailableQuantity=" + item.AvailableQuantity + " where ID=" + item.ID + "";
                    isSave = _sqlFactory.Add(itemQuery);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return isSave;
        }
    }
}
