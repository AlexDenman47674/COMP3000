using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacialRecognitionProject
{
    public partial class DatabaseForm : Form
    {
        public DatabaseForm()
        {
            InitializeComponent();
        }

        private void DatabaseForm_Load(object sender, EventArgs e)
        {
            string FileName = "Database(People).xlsx";
            OleDbConnection ExcelConnection = null;
            string filePath = "C:/Users/Alex/Desktop/COMP3000/";
            DataTable dtNew = new DataTable();
            string strExt = "";
            strExt = FileName.Substring(FileName.LastIndexOf("."));
            if (strExt == ".xls")
            {
                ExcelConnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filePath + FileName + ";Extended Properties=Excel 8.0;");
            }
            else
            {
                if (strExt == ".xlsx")
                {
                    ExcelConnection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath + FileName + ";Extended Properties=Excel 12.0;");
                }
            }
            try
            {
                ExcelConnection.Open();
                DataTable dt = ExcelConnection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                OleDbCommand ExcelCommand = new OleDbCommand(@"SELECT * FROM [" + "Sheet1" + @"]", ExcelConnection);
                OleDbDataAdapter ExcelAdapter = new OleDbDataAdapter(ExcelCommand);
                DataSet ExcelDataSet = new DataSet();
                ExcelAdapter.Fill(dataSet1);
                ExcelConnection.Close();

            }
            catch (Exception ex)
            {

            }
            finally
            {
            }
        }

        private void databaseViewer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
