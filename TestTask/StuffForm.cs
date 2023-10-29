using ClosedXML.Excel;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace TestTask
{
    public partial class StuffForm : Form
    {
        public StuffForm()
        {
            InitializeComponent();
        }

        private void StuffForm_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = DAL.DBHelper.GetEmployees();
            dataGridView1.DataSource = dt;
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            var path = Path.Combine(Environment.CurrentDirectory, "Export", "data.xlsx");
            DataTable dt = new DataTable();
            dt = DAL.DBHelper.GetPositions();
            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("AVGSalary");
            worksheet.Cell(2, 2).InsertTable(dt);
            workbook.SaveAs(path);

            System.Diagnostics.Process.Start(path);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddForm addform = new AddForm();
            addform.FormClosing += new FormClosingEventHandler(this.AddForm_FormClosing);
            addform.ShowDialog();
        }

        private void AddForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.StuffForm_Load(sender, e);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    string firstName = row.Cells[0].Value.ToString();
                    string lastName = row.Cells[1].Value.ToString();
                    string posName = row.Cells[2].Value.ToString();
                    string yearOfBirth = row.Cells[3].Value.ToString();
                    string salary = row.Cells[4].Value.ToString();
                    int id = DAL.DBHelper.GetEmpById(firstName, lastName, DAL.DBHelper.GetPosByName(posName), yearOfBirth, salary);
                    labelNotific.Text = DAL.DBHelper.DeleteEmployee(id);
                    this.StuffForm_Load(sender, e);     
                }
            }
            else
            {
                labelNotific.Text = "Mistake! The row is not selected. Select the row to delete.";
            }
        }

        private void buttonSortDesc_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DAL.DBHelper.GetEmployeesWithSortingDesc();
        }

        private void buttonSortAsc_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DAL.DBHelper.GetEmployeesWithSorting();
        }
    }
}
