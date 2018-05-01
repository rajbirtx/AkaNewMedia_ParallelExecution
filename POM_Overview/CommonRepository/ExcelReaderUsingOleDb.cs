using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkaNewMedia.CommonRepository
{
    public class ExcelReaderUsingOleDb
    {
        /// <summary>
        /// CreatedDate:29-March-2018
        /// Desc:Method is used to read excel data using two private methods BindData & getSheetData
        /// </summary>
        /// <returns></returns>
        public DataTable ReadExcelData(string sheetName)
        {
            try
            {
                string excelPath = GetExcelPath();
                string strConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + excelPath + ";Extended Properties=\"Excel 12.0 xml;HDR=Yes;IMEX=1\"";
                DataTable dt = BindData(strConn, sheetName);
                return dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while reading data from excel");
                throw;
            }
        }
        /// <summary>
        /// Desc:Method is used to get excelsheet's path
        /// </summary>
        /// <returns></returns>
        public string GetExcelPath()
        {
            string path = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            string actualPath = path.Substring(0, path.LastIndexOf("bin"));
            string excelPath = new Uri(actualPath).LocalPath;
            excelPath = excelPath + "ExcelSheet\\Aka_Excel_Sheet.xlsx";
            return excelPath;
        }
        /// <summary>
        /// CreatedDate:29-March-2018
        /// Desc:Method is used to bind the data with datatable
        /// </summary>
        /// <param name="strConn"></param>
        /// <returns></returns>
        private DataTable BindData(string strConn, string sheetName)
        {
            try
            {
                OleDbConnection objConn = new OleDbConnection(strConn);
                objConn.Open();
                DataTable dt = null;
                dt = objConn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                objConn.Close();
                DataTable dt_sheet = null;
                dt_sheet = getSheetData(strConn, sheetName + "$");
                return dt_sheet;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        /// <summary>
        /// CreatedDate:29-March-2018
        /// Desc:Method is used to get sheet's data
        /// </summary>
        /// <param name="strConn"></param>
        /// <param name="sheet"></param>
        /// <returns></returns>
        private DataTable getSheetData(string strConn, string sheet)
        {
            try
            {
                string query = "select * from [" + sheet + "]";
                OleDbConnection objConn;
                OleDbDataAdapter oleDA;
                DataTable dt = new DataTable();
                objConn = new OleDbConnection(strConn);
                objConn.Open();
                oleDA = new OleDbDataAdapter(query, objConn);
                oleDA.Fill(dt);
                objConn.Close();
                oleDA.Dispose();
                objConn.Dispose();
                return dt;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
