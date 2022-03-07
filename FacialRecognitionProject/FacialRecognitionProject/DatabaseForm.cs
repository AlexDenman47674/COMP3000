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
            //OleDbConnection ExcelConnection = null;
            System.Data.OleDb.OleDbConnection ExcelConnection;
            ExcelConnection = null;
            string filePath = "C:/Users/Alex/Desktop/COMP3000/";
            DataTable dtNew = new DataTable();
            ExcelConnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + "'" + filePath + FileName + "'" + ";Extended Properties=Excel 8.0;");
            try
            {
                ExcelConnection.Open();
                DataTable dt = ExcelConnection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                System.Data.OleDb.OleDbCommand ExcelCommand = new OleDbCommand(@"SELECT * FROM [" + "Sheet1" + @"]", ExcelConnection);
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
