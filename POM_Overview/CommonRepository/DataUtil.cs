using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkaNewMedia.CommonRepository
{
    public class DataUtil
    {
        public static object[] getData(ExcelReaderUsingNPOI xls, string sheetName)
        {
            try
            {
                int rows = xls.getRowCount(sheetName);
                Console.WriteLine("Total rows :" + rows);
                int cols = xls.getColumnCount(sheetName);
                Console.WriteLine("Total cols :" + cols);
                object[][] data = new object[rows - 1][];
                int dataRow = 0;
                Dictionary<string, string> table = null;
                for (int rNum = 2; rNum <= rows; rNum++)
                {
                    data[rNum - 2] = new object[1];
                    table = new Dictionary<string, string>();
                    for (int cNum = 0; cNum < cols; cNum++)
                    {
                        string key = xls.getCellData(sheetName, cNum, 1);
                        string value = xls.getCellData(sheetName, cNum, rNum);
                        table.Add(key, value);
                    }
                    data[dataRow][0] = table;
                    dataRow++;
                }
                return data;
            }
            catch (Exception)
            {
                throw;
            }          
        }
    }
}
