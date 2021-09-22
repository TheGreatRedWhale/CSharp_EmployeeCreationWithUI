using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductionWorkerManager.Data;

namespace ProductionWorkerManager.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // CUSTOM METHODS

        public ProductionWorker CreateProductionWorker()
        {
            ProductionWorker employee = new ProductionWorker();

            // Get the employee's name
            employee.Name = inputEmployeeNameLabel.Text;

            // Get the employee's shift number
            try
            {
                if (int.TryParse(inputEmployeeShiftTextBox.Text, out int shiftNumber))
                {
                    employee.ShiftNumber = (ProductionWorker.Shift)int.Parse(inputEmployeeShiftTextBox.Text);
                }
                else if (inputEmployeeShiftTextBox.Text.ToUpper().Equals("DAY") ||
                    inputEmployeeShiftTextBox.Text.ToUpper().Equals("D") ||
                    inputEmployeeShiftTextBox.Text.ToUpper().Equals("MORNING") ||
                    inputEmployeeShiftTextBox.Text.ToUpper().Equals("M"))
                {
                    employee.ShiftNumber = ProductionWorker.Shift.Day;
                }
                else if (inputEmployeeShiftTextBox.Text.ToUpper().Equals("NIGHT") ||
                    inputEmployeeShiftTextBox.Text.ToUpper().Equals("N") ||
                    inputEmployeeShiftTextBox.Text.ToUpper().Equals("EVENING") ||
                    inputEmployeeShiftTextBox.Text.ToUpper().Equals("E"))
                {
                    employee.ShiftNumber = ProductionWorker.Shift.Night;
                }
                else
                {
                    employee.ShiftNumber = ProductionWorker.Shift.Unassigned;
                }
            }
            catch (Exception)
            {
                employee.ShiftNumber = ProductionWorker.Shift.Unassigned;
            }

            // Get the employee's unique number
            if (int.TryParse(inputEmployeeNumberTextBox.Text, out int employeeNumber))
            {
                employee.Number = employeeNumber;
            }
            else
            {
                employee.Number = -1;
            }

            // Get the employee's hourly rate
            if (double.TryParse(inputEmployeeHourlyRateTextBox.Text, out double hourlyRate))
            {
                employee.HourlyRate = hourlyRate;
            }
            else
            {
                employee.HourlyRate = -1.0;
            }

            ClearInput();
            return employee;
        }

        public void DisplayProductionWorker(ProductionWorker productionWorker)
        {
            outputEmployeeNameTextBox.Text = productionWorker.Name;
            outputEmployeeNumberTextBox.Text = productionWorker.Number.ToString();
            outputEmployeeShiftTextBox.Text = productionWorker.ShiftNumber.ToString();
            outputEmployeeHourlyRateTextBox.Text = productionWorker.HourlyRate.ToString();
        }

        public void ClearInput()
        {
            inputEmployeeNameTextBox.Text = "";
            inputEmployeeNumberTextBox.Text = "";
            inputEmployeeShiftTextBox.Text = "";
            inputEmployeeHourlyRateTextBox.Text = "";
        }

        // GENERATED METHODS

        private void createObjectButton_Click(object sender, EventArgs e)
        {
            ProductionWorker employee = CreateProductionWorker();

        }
    }
}
