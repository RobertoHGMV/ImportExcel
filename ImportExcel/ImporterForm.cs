using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImportExcel
{
    public partial class ImporterForm : Form
    {
        private DataSet output;

        public ImporterForm()
        {
            InitializeComponent();
            lbQtdLines.Text = string.Empty;
            cbSheet.SelectedIndexChanged += CbSheet_SelectedIndexChanged;
        }

        private void cmdOk_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnImporter_Click(object sender, EventArgs e)
        {
            try
            {
                var fileDialog = new OpenFileDialog();
                fileDialog.Filter = "Excel Worksheets | *.xlsx;*.xls";
                fileDialog.Title = "Selecione o arquivo";

                if (fileDialog.ShowDialog() != DialogResult.OK) return;
                txtFileName.Text = fileDialog.FileName;

                this.Cursor = Cursors.WaitCursor;

                if (!File.Exists(fileDialog.FileName))
                    throw new Exception("Arquivo não encontrado");

                var spreadsheets = GetSpreadsheets(fileDialog.FileName);
                FillComboSheet(spreadsheets);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private DataSet GetSpreadsheets(string fileName)
        {
            var strConnection64 = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={fileName};Extended Properties=\"Excel 12.0;HDR=Yes;IMEX=0\"";
            var strConnection32 = $"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={fileName};Extended Properties=\"Excel 8.0;HDR=Yes;IMEX=0\"";
            var strConnection = Path.GetExtension(fileName) == ".xlsx" ? strConnection64 : strConnection32;

            var conn = new OleDbConnection(strConnection);
            conn.Open();

            var dt = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });

            output = new DataSet();
            foreach (DataRow row in dt.Rows)
            {
                var sheet = row["TABLE_NAME"].ToString();
                var cmd = new OleDbCommand("SELECT * FROM [" + sheet + "]", conn);
                cmd.CommandType = CommandType.Text;
                var outputTable = new DataTable(sheet);
                output.Tables.Add(outputTable);
                new OleDbDataAdapter(cmd).Fill(outputTable);
            }

            return output;
        }

        private void CbSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var table = output.Tables[cbSheet.SelectedValue.ToString()];
                FillGrid(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FillComboSheet(DataSet spreadsheets)
        {
            var listTable = new List<string>();
            foreach (DataTable sheet in spreadsheets.Tables)
                listTable.Add(sheet.TableName);

            cbSheet.DataSource = listTable;
        }

        private void FillGrid(DataTable table)
        {
            gridImporter.DataSource = table;
            gridImporter.AutoGenerateColumns = true;
            lbQtdLines.Text = table.Rows.Count.ToString();
        }
    }
}
