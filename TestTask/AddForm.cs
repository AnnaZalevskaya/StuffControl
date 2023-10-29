using System;
using System.Windows.Forms;

namespace TestTask
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "stuffDataSet.positions". При необходимости она может быть перемещена или удалена.
            this.positionsTableAdapter.Fill(this.stuffDataSet.positions);

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxFirstName.Text != string.Empty && textBoxLastName.Text != string.Empty
                && textBoxYearOfBirth.Text != string.Empty && textBoxSalary.Text != string.Empty)
            {
                string firstName = textBoxFirstName.Text;
                string lastName = textBoxLastName.Text;
                int positionId = listBoxPositions.SelectedIndex + 1;
                if (int.TryParse(textBoxYearOfBirth.Text, out int year) && year > 1950 && year < 2006)
                {
                    year = int.Parse(textBoxYearOfBirth.Text);
                    if (decimal.TryParse(textBoxSalary.Text, out decimal salary))
                    {
                        salary = decimal.Parse(textBoxSalary.Text);
                        labelNotif.Text = DAL.DBHelper.AddEmployee(firstName, lastName, positionId, year, salary);
                        this.Close();
                    }
                    else
                    {
                        labelNotif.Text = "Incorrect amount. Try again.";
                    }
                }
                else
                {
                    labelNotif.Text = "Incorrect year format. Check the data.";
                }
                
            }
            else
            {
                labelNotif.Text = "Please fill in the input fields!";
            }    
        }
    }
}
