using System;
using SMSApp.Models;
using SMSApp.DAL;
using SMSApp.BLL;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSApp.BLL
{
    
    public class StockOutManager
    {
        StockOutRepository _stockOutRepository = new StockOutRepository();
        private DataTable _dataTable;
        public bool SaveStockOut(List<StockOut> stockOuts, List<Item> items)
        {
            bool isSave = false;
            isSave = _stockOutRepository.SaveStockOut(stockOuts, items);
            return isSave;
        }

        public Item GetFieldData(StockOut stockOut)
        {
            Item item = new Item();
            item = _stockOutRepository.GetFieldData(stockOut);
            return item;
        }
        public DataTable GetItem(Item item)
        {
            _dataTable = new DataTable();
            _dataTable = _stockOutRepository.GetItemComboData(item);
            return _dataTable;
        }
        public DataTable GetCompany()
        {
            _dataTable = new DataTable();
            _dataTable = _stockOutRepository.GetCompanyComboData();
            return _dataTable;
        }

        public DataTable DateWiseSearch(StockOut stockOut)
        {
            DataTable dt = new DataTable();
            dt = _stockOutRepository.DateWiseSearch(stockOut);
            return dt;
        }
    }
}
