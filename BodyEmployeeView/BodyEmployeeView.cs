using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseClass;
namespace BodyEmployeeView
{
    public partial class BodyEmployeeView: UserControl
    {
        public DatabaseAccess.Employee employee { get; set; } = new DatabaseAccess.Employee();
        public List<DatabaseAccess.Shift> employeeShifts { get; set; } = new List<DatabaseAccess.Shift>();
        DateTimePicker dtp = new DateTimePicker();
        readonly private List<string> roles = new List<string> { "Manager", "Employee" };
        public event EventHandler SaveBtnClick;
        public event EventHandler CancelBtnClick;
        public event EventHandler DelBtnClick;
        public BodyEmployeeView()
        {
            InitializeComponent();
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            foreach (var day in days)
            {
                ShiftDataGridView.Rows.Add(day, "", "");
            }

            // config DatetimePicker
            dtp.Format = DateTimePickerFormat.Time;
            dtp.ShowUpDown = true;
            dtp.Visible = false;
            dtp.CloseUp += Dtp_CloseUp;
            dtp.Leave += Dtp_CloseUp;
            dtp.PreviewKeyDown += Dtp_PreviewKeyDown;
            ShiftDataGridView.Controls.Add(dtp);
            ShiftDataGridView.CellDoubleClick += ShiftDataGridView_CellDoubleClick;
        }
        private class Schedule
        {
            Dictionary<int, string> dayNumToDayStr = new Dictionary<int, string>
            {
                {1, "Monday"},
                {2, "Tuesday" },
                {3, "Wednesday" },
                {4, "Thursday" },
                {5, "Friday" },
                {6, "Saturday" },
                {7, "Sunday" },
            };
            Dictionary<string, int> dayStrToDayNum = new Dictionary<string, int>
            {
                {"Monday",      1},
                {"Tuesday",     2},
                {"Wednesday",   3},
                {"Thursday",    4},
                {"Friday",      5},
                {"Saturday",    6},
                {"Sunday",      7},
            };
            Dictionary<int, string> start = new Dictionary<int, string>
            {
                {1, null },
                {2, null },
                {3, null },
                {4, null },
                {5, null },
                {6, null },
                {7, null },
            };
            Dictionary<int, string> finish = new Dictionary<int, string>
            {
                {1, null },
                {2, null },
                {3, null },
                {4, null },
                {5, null },
                {6, null },
                {7, null },
            };

            public void BuildSchedule(List<DatabaseAccess.Shift> shs)
            {
                foreach (var sh in shs)
                {
                    start[sh.Day_of_Week] = sh.Shift_Start.ToString();
                    finish[sh.Day_of_Week] = sh.Shift_Finish.ToString();
                }
            }
            public string GetDayStr(int i)
            {
                return dayNumToDayStr[i];
            }
            public int GetDayNum(string day)
            {
                return dayStrToDayNum[day];
            }
            public string GetStart(int dayNum)
            {
                return start[dayNum];
            }
            public string GetStart(string dayStr)
            {
                return start[GetDayNum(dayStr)];
            }
            public string GetFinish(int dayNum)
            {
                return finish[dayNum];
            }
            public string GetFinish(string dayStr)
            {
                return finish[GetDayNum(dayStr)];
            }
        }
        public BodyEmployeeView(string empID)
        {
            InitializeComponent();
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            foreach (var day in days)
            {
                ShiftDataGridView.Rows.Add(day, "", "");
            }

            // config DatetimePicker
            dtp.Format = DateTimePickerFormat.Time;
            dtp.ShowUpDown = true;
            dtp.Visible = false;
            dtp.CloseUp += Dtp_CloseUp;
            dtp.Leave += Dtp_CloseUp;
            dtp.PreviewKeyDown += Dtp_PreviewKeyDown;
            ShiftDataGridView.Controls.Add(dtp);
            ShiftDataGridView.CellDoubleClick += ShiftDataGridView_CellDoubleClick;

            // fetch employee information
            employee = DatabaseAccess.Employee.GetEmployeeByID(empID);
            employeeShifts = employee.GetShifts();

            // update data grid view with employee shifts
            UpdateShiftDataGridView();

            // update employee information 
            EmployeeSalaryTextBox.Text = employee.Employee_Salary.ToString();
            EmployeePhoneTextBox.Text = employee.Employee_PhoneNumber.ToString();
            EmployeeIDTextBox.Text = employee.Employee_ID.ToString();
            EmployeeStoreIDTextBox.Text = employee.Store_ID.ToString();
            EmployeeEmailTextBox.Text = employee.Employee_Email.ToString();
            EmployeeBirthTextBox.Text = employee.Employee_Birth.ToString();
        }
        private void UpdateShiftDataGridView()
        {
            ShiftDataGridView.Rows.Clear();
            Dictionary<int, string> dayNumToDayStr = new Dictionary<int, string>
            {
                { 1, "Monday" },
                { 2, "Tuesday" },
                { 3, "Wednesday" },
                { 4, "Thursday" },
                { 5, "Friday" },
                { 6, "Saturday" },
                { 7, "Sunday" }
            };
            Schedule sch = new Schedule();
            sch.BuildSchedule(employeeShifts);
            for (int i = 1;i <= 7; i++)
            {
                ShiftDataGridView.Rows.Add(sch.GetDayStr(i), sch.GetStart(i), sch.GetFinish(i));
            }
        }
        private void Dtp_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return || e.KeyCode == Keys.Escape)
            {
                dtp.Visible = false;
                dtp.Tag = null; // Reset the tag to avoid issues on next click  
            }
        }
        private void Dtp_CloseUp(object sender, EventArgs e)
        {
            dtp.Visible = false;
            if (dtp.Tag is DataGridViewCell cell)
            {
                string prevVal = cell.Value?.ToString() ?? "";
                if (cell.ColumnIndex == 2)
                {
                    // make sure the finish time is after the start time
                    string stTimeStr = ShiftDataGridView[cell.ColumnIndex - 1, cell.RowIndex].Value.ToString();
                    DateTime stTime = stTimeStr == "" ? DateTime.Parse("00:00:00") : DateTime.Parse(stTimeStr);
                    DateTime finTime = DateTime.Parse(dtp.Value.ToShortTimeString());
                    if (finTime < stTime)
                    {
                        MessageBox.Show("Finish time must be after start time.", "Invalid Time", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cell.Value = prevVal; // Reset the finish time
                        return;

                    }
                    else
                        cell.Value = dtp.Value.ToShortTimeString();
                }
                else if (cell.ColumnIndex == 1)
                {
                    // make sure the start time is before the finish time
                    string finTimeStr = ShiftDataGridView[cell.ColumnIndex + 1, cell.RowIndex].Value.ToString();
                    DateTime finTime = finTimeStr == "" ? DateTime.Parse("23:59:59") : DateTime.Parse(finTimeStr);
                    DateTime stTime = DateTime.Parse(dtp.Value.ToShortTimeString());
                    if (stTime > finTime)
                    {
                        MessageBox.Show("Start time must be before finish time.", "Invalid Time", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cell.Value = prevVal; // Reset the start time
                        return;
                    }
                    else
                        cell.Value = dtp.Value.ToShortTimeString();
                }
                else
                {
                    cell.Value = dtp.Value.ToShortTimeString();
                }

            }
            dtp.Tag = null; // Reset the tag to avoid issues on next click
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            CancelBtnClick?.Invoke(this, EventArgs.Empty);
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            SaveBtnClick?.Invoke(this, EventArgs.Empty);
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            DelBtnClick?.Invoke(this, EventArgs.Empty);
        }
        private void ShiftDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 || e.ColumnIndex == 2)
            {
                Rectangle rect = ShiftDataGridView.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                dtp.Size = rect.Size;
                dtp.Location = rect.Location;
                dtp.Visible = true;
                dtp.Focus();

                // Gán giá trị nếu có sẵn
                if (DateTime.TryParse(ShiftDataGridView.CurrentCell.Value?.ToString(), out DateTime val))
                {
                    dtp.Value = val;
                }
                else
                {
                    dtp.Value = DateTime.Now;
                }

                dtp.Tag = ShiftDataGridView.CurrentCell;
            }
            else
            {
                dtp.Visible = false;
            }
        }
    }
}
