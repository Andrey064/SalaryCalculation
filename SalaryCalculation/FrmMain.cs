using Salary.Model;
using Salary.Model.BusinessService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;


namespace SalaryCalculation
{
    public partial class FrmMain : Form
    {

        private IPersonService personService;
        private IDepartmentService departmentService;

        private string salaryBaseTotal;
        private string salaryDopTotal;
        private string salaryFullTotal;

        TextBox txtBox;
        Label lbl;
        Label lblSalaryBaseTotal;
        Label lblSalaryDopTotal;
        Label lblSalaryFullTotal;
        Label lblSalaryBonusTotal;



        //бонус в рублевом выражении
        private string bonusRub;

        /// <summary>
        /// Member id
        /// </summary>
        private int memberId;

        /// <summary>
        /// Variable to store error message
        /// </summary>
        private string errorMessage;

        public FrmMain()
        {
            InitializeComponent();
            personService = new PersonService();
            departmentService = new DepartmentService();
            InitilizeDataGridViewStyle();
            InitializeDropDownList();
            ResetRegistration();
            txtBox = new TextBox();
            lbl = new Label();
            lblSalaryBaseTotal = new Label();
            lblSalaryDopTotal = new Label();
            lblSalaryFullTotal = new Label();
            lblSalaryBonusTotal = new Label();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateRegistration())
                {
                    // Assign the values to the model
                    Person person = new Person()
                    {
                        Name = txtName.Text.Trim(),
                        Surname = txtSurName.Text.Trim(),
                        Patronymic = txtPatronymic.Text.Trim(),

                        SalaryBase = txtSalaryBase.Text.Trim() == string.Empty ? 0 : Convert.ToDecimal(txtSalaryBase.Text),
                        SalaryDop = txtSalaryDop.Text.Trim() == string.Empty ? 0 : Convert.ToDecimal(txtSalaryDop.Text),
                        Bonus = txtBonus.Text.Trim() == string.Empty ? 0 : Convert.ToDecimal(txtBonus.Text),

                        DepartmentID = (Department)cmbDepartment.SelectedValue,
                    };

                    var success = personService.RegisterPerson(person);

                    if (success)
                    {
                        MessageBox.Show(
                            "Добавлен сотрудник в базу",
                            "Сообщение",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        // Reset the screen
                        this.ResetRegistration();
                    }
                    else
                    {
                        MessageBox.Show(
                           "Запись не добавлена",
                           "Сообщение",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error);

                    }
                }
                else
                {

                    // Display the validation failed message
                    MessageBox.Show(
                        this.errorMessage,
                        "Сообщение",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex);
            }

        }

        /// <summary>
        /// Method to show general error message on any system level exception
        /// </summary>
        private void ShowErrorMessage(Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                //Resources.System_Error_Message, 
                "Ошибка - Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        /// <summary>
        /// Resets the registration screen
        /// </summary>
        private void ResetRegistration()
        {
            txtName.Text = string.Empty;
            txtSurName.Text = string.Empty;
            txtPatronymic.Text = string.Empty;
            txtSalaryBase.Text = string.Empty;
            txtSalaryDop.Text = string.Empty;
            txtBonus.Text = string.Empty;
            cmbDepartment.SelectedIndex = -1;
        }

        /// <summary>
        /// To generate the error message
        /// </summary>
        /// <param name="error">error message</param>
        private void AddErrorMessage(string error)
        {
            if (this.errorMessage == string.Empty)
            {
                this.errorMessage = "Сообщение " + "\n\n";
            }

            this.errorMessage += error + "\n";
        }

        /// <summary>
        /// Validates registration input
        /// </summary>
        /// <returns>true or false</returns>
        private bool ValidateRegistration()
        {
            errorMessage = string.Empty;

            if (txtName.Text.Trim() == string.Empty)
            {
                this.AddErrorMessage("Поле имя сотрудника обязательно для заполнения");
            }

            if (txtSurName.Text.Trim() == string.Empty)
            {
                this.AddErrorMessage("Поле фамилия сотрудника обязательно для заполнения");
            }

            if (cmbDepartment.SelectedIndex == -1)
            {
                this.AddErrorMessage("Укажите в каком отделе работает сотрудник");
            }

            return this.errorMessage != string.Empty ? false : true;
        }

        private void tabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (tabMain.SelectedIndex == 1)
                {
                    DataTable data = personService.GetAllPersons();
                    InitializeUpdate();
                    LoadDataGridView(data);
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex);
            }
        }

        private void LoadDataGridView(DataTable data)
        {
            dgvPersons.DataSource = data;
            dgvPersons.DataMember = data.TableName;
            //dgvPersons.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            ResizeColumns();
            RenameColumns();

            object sum = data.Compute("Sum(SalaryBase)", "");
            object sum1 = data.Compute("Sum(SalaryDop)", "");
            object sum2 = data.Compute("Sum(SalaryFull)", "");
            try
            {
                salaryBaseTotal = Convert.ToString(sum);
                salaryDopTotal = Convert.ToString(sum1);
                salaryFullTotal = Convert.ToString(sum2);
            }
            catch { }

            TotalFields();
        }

        private void ResizeColumns()
        {
            dgvPersons.Columns["PersonID"].Width = 30;
            dgvPersons.Columns["Surname"].Width = 110;
            dgvPersons.Columns["Name"].Width = 90;
            dgvPersons.Columns["Patronymic"].Width = 100;
            dgvPersons.Columns["SalaryBase"].Width = 70;
            dgvPersons.Columns["SalaryDop"].Width = 70;
            dgvPersons.Columns["SalaryFull"].Width = 70;
            dgvPersons.Columns["DepartmentID"].Width = 70;
            dgvPersons.Columns["Bonus"].Width = 70;
        }

        private void RenameColumns()
        {
            dgvPersons.Columns["PersonID"].HeaderText = "№";
            dgvPersons.Columns["PersonID"].Visible = false;
            dgvPersons.Columns["Surname"].HeaderText = "Фамилия";
            dgvPersons.Columns["Name"].HeaderText = "Имя";
            dgvPersons.Columns["Patronymic"].HeaderText = "Отчество";
            dgvPersons.Columns["SalaryBase"].HeaderText = "Сумма руб.";
            dgvPersons.Columns["SalaryDop"].HeaderText = "Доплата руб.";
            dgvPersons.Columns["Bonus"].HeaderText = "Бонус %";
            dgvPersons.Columns["SalaryFull"].HeaderText = "Итого руб.";
            dgvPersons.Columns["DepartmentID"].HeaderText = "Отдел";


        }

        private void TotalFields()
        {

            lbl.Text = "Итого";
            lbl.Height = 21;
            lbl.AutoSize = false;
            lbl.BorderStyle = BorderStyle.FixedSingle;
            lbl.BackColor = Color.White;
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            int Xdgv1 = this.dgvPersons.GetCellDisplayRectangle(5, -1, true).Location.X;
            lbl.Width = Xdgv1;
            lbl.Location = new Point(1, this.dgvPersons.Height - txtBox.Height - 2);
            this.dgvPersons.Controls.Add(lbl);

            lblSalaryBaseTotal.Text = salaryBaseTotal;
            lblSalaryBaseTotal.Height = 21;
            lblSalaryBaseTotal.AutoSize = false;
            lblSalaryBaseTotal.BorderStyle = BorderStyle.FixedSingle;
            lblSalaryBaseTotal.BackColor = Color.White;
            lblSalaryBaseTotal.ForeColor = Color.Black;
            lblSalaryBaseTotal.TextAlign = ContentAlignment.MiddleCenter;
            int salaryBaseWidth = this.dgvPersons.Columns["SalaryBase"].Width;
            lblSalaryBaseTotal.Width = salaryBaseWidth;
            lblSalaryBaseTotal.Location = new Point(Xdgv1, this.dgvPersons.Height - txtBox.Height - 2);
            this.dgvPersons.Controls.Add(lblSalaryBaseTotal);

            lblSalaryDopTotal.Text = salaryDopTotal;
            lblSalaryDopTotal.Height = 21;
            lblSalaryDopTotal.AutoSize = false;
            lblSalaryDopTotal.BorderStyle = BorderStyle.FixedSingle;
            lblSalaryDopTotal.BackColor = Color.White;
            lblSalaryDopTotal.ForeColor = Color.Black;
            lblSalaryDopTotal.TextAlign = ContentAlignment.MiddleCenter;
            int salaryDopWidth = this.dgvPersons.Columns["SalaryDop"].Width;
            lblSalaryDopTotal.Width = salaryDopWidth;
            lblSalaryDopTotal.Location = new Point(Xdgv1 + salaryBaseWidth - 1, this.dgvPersons.Height - txtBox.Height - 2);
            this.dgvPersons.Controls.Add(lblSalaryDopTotal);

            lblSalaryBonusTotal.Text = "";
            lblSalaryBonusTotal.Height = 21;
            lblSalaryBonusTotal.AutoSize = false;
            lblSalaryBonusTotal.BorderStyle = BorderStyle.FixedSingle;
            lblSalaryBonusTotal.BackColor = Color.White;
            lblSalaryBonusTotal.ForeColor = Color.Black;
            lblSalaryBonusTotal.TextAlign = ContentAlignment.MiddleCenter;
            int salaryBonus = this.dgvPersons.Columns["Bonus"].Width;
            lblSalaryBonusTotal.Width = salaryBonus;
            lblSalaryBonusTotal.Location = new Point(Xdgv1 + salaryBaseWidth + salaryDopWidth - 2, this.dgvPersons.Height - txtBox.Height - 2);
            this.dgvPersons.Controls.Add(lblSalaryBonusTotal);

            lblSalaryFullTotal.Text = salaryFullTotal;
            lblSalaryFullTotal.Height = 21;
            lblSalaryFullTotal.AutoSize = false;
            lblSalaryFullTotal.BorderStyle = BorderStyle.FixedSingle;
            lblSalaryFullTotal.BackColor = Color.White;
            lblSalaryFullTotal.ForeColor = Color.Black;
            lblSalaryFullTotal.TextAlign = ContentAlignment.MiddleCenter;
            lblSalaryFullTotal.Width = this.dgvPersons.Columns["SalaryFull"].Width; ;
            lblSalaryFullTotal.Location = new Point(Xdgv1 + salaryBaseWidth + salaryDopWidth + salaryBonus - 3, this.dgvPersons.Height - txtBox.Height - 2);
            this.dgvPersons.Controls.Add(lblSalaryFullTotal);
        }

        private void dgvPersons_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            try
            {
                if (dgv.SelectedRows.Count > 0)
                {
                    string personID = dgv.SelectedRows[0].Cells[0].Value.ToString();
                    memberId = int.Parse(personID);

                    DataRow dataRow = this.personService.GetPersonById(memberId);

                    Person person = new Person()
                    {
                        Name = dataRow["Name"].ToString(),
                        Surname = dataRow["Surname"].ToString(),
                        Patronymic = dataRow["Patronymic"].ToString(),
                        SalaryBase = Convert.ToDecimal(dataRow["SalaryBase"].ToString()),
                        SalaryDop = Convert.ToDecimal(dataRow["SalaryDop"].ToString()),
                        Bonus = Convert.ToDecimal(dataRow["Bonus"].ToString()),
                    };


                    txt2Name.Text = dataRow["Name"].ToString();
                    txt2Surname.Text = dataRow["Surname"].ToString();
                    txt2Patronymic.Text = dataRow["Patronymic"].ToString();
                    txt2SalaryBase.Text = dataRow["SalaryBase"].ToString() == "0.00" ? string.Empty : dataRow["SalaryBase"].ToString();
                    txt2SalaryDop.Text = dataRow["SalaryDop"].ToString() == "0.00" ? string.Empty : dataRow["SalaryDop"].ToString();
                    txt2Bonus.Text = dataRow["Bonus"].ToString() == "0.00" ? string.Empty : dataRow["Bonus"].ToString();

                    int depId = (int)(dataRow["DepartmentID"]);
                    cmb2Department.ValueMember = "DepartmentID";
                    cmb2Department.DisplayMember = "DepName";
                    cmb2Department.SelectedValue = depId;

                    //txtSalaryFull.Text = person.SalaryFull.ToString();
                }
            }
            catch (Exception ex)
            {
                this.ShowErrorMessage(ex);
            }

        }

        private void InitilizeDataGridViewStyle()
        {
            // Setting the style of the DataGridView control
            //dgvPersons.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9, FontStyle.Bold, GraphicsUnit.Point);
            dgvPersons.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.ControlDark;
            dgvPersons.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvPersons.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPersons.DefaultCellStyle.Font = new Font("Tahoma", 8, FontStyle.Regular, GraphicsUnit.Point);
            dgvPersons.DefaultCellStyle.BackColor = Color.Empty;
            dgvPersons.AlternatingRowsDefaultCellStyle.BackColor = SystemColors.Info;
            dgvPersons.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvPersons.GridColor = SystemColors.ControlDarkDark;
        }


        private void sdf(Microsoft.Office.Interop.Excel.Application excel) { }



        private void btnExportToXls_Click(object sender, EventArgs e)
        {
            try
            {
                List<Department> departments = departmentService.GetAllDepartment();
                DataTable allPersons = personService.GetAllPersons();

                Excel.Application xlApp = new Excel.Application();

                if (xlApp == null)
                {
                    MessageBox.Show("Excel не установлен!");
                    return;
                }

                Excel.Workbook xlWorkBook = xlApp.Workbooks.Add();
                Excel.Worksheet xlWorkSheet = xlWorkBook.Worksheets.get_Item(1);

                xlApp.Visible = true;

                XlsHead(xlWorkSheet);
                SetColumnWidth(xlWorkSheet);

                int rowIndex = 4;
                foreach (Department department in departments)
                {
                    if (department.DepartmentID > 0)
                    {
                        xlWorkSheet.Cells[rowIndex, 1] = department.DepName;

                        DataTable data = personService.GetPersonsByDepartmentId(department.DepartmentID);
                        if (data.Rows.Count==0)
                        {
                            return;
                        }
                        List<Person> persons = data.DataTableToList<Person>();
                        int rowCount = rowIndex + persons.Count;
                        BorderAround(xlWorkSheet, rowIndex+1, rowCount+1);

                        HeadRow(xlWorkSheet, rowIndex+1);
                        foreach (Person person in persons)
                        {
                            FillRows(xlWorkSheet, ++rowIndex+1, person);
                        }

                        object salaryBase = data.Compute("Sum(SalaryBase)", "");
                        object salaryDop = data.Compute("Sum(SalaryDop)", "");
                        object salaryFull = data.Compute("Sum(SalaryFull)", "");

                        TotalRow(xlWorkSheet, rowIndex+2, salaryBase, salaryDop, salaryFull);

                        rowIndex = rowCount + 3;
                    }
                }

                object sum = allPersons.Compute("Sum(SalaryBase)", "");
                object sum1 = allPersons.Compute("Sum(SalaryDop)", "");
                object sum2 = allPersons.Compute("Sum(SalaryFull)", "");

                TotalRow(xlWorkSheet, rowIndex+2, sum, sum1, sum2);

            }
            catch (Exception ex)
            {
                this.ShowErrorMessage(ex);
            }

        }

        private static void TotalRow(Excel.Worksheet xlWorkSheet, int rowIndex, object sum, object sum1, object sum2)
        {
            Excel.Range chartRange;
            xlWorkSheet.get_Range("a" + rowIndex, "c" + rowIndex).Merge(false);
            chartRange = xlWorkSheet.get_Range("a" + rowIndex, "c" + rowIndex);
            chartRange.Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;

            chartRange.FormulaR1C1 = "Итого";

            xlWorkSheet.Cells[rowIndex, 4] = sum == null ? 0 : Convert.ToDecimal(sum);
            xlWorkSheet.Cells[rowIndex, 5] = sum1 == null ? 0 : Convert.ToDecimal(sum1);
            xlWorkSheet.Cells[rowIndex, 7] = sum2 == null ? 0 : Convert.ToDecimal(sum2);
        }

        private static void FillRows(Excel.Worksheet xlWorkSheet, int rowIndex, Person person)
        {
            xlWorkSheet.Cells[rowIndex, 1] = person.Surname;
            xlWorkSheet.Cells[rowIndex, 2] = person.Name;
            xlWorkSheet.Cells[rowIndex, 3] = person.Patronymic;
            xlWorkSheet.Cells[rowIndex, 4] = person.SalaryBase;
            xlWorkSheet.Cells[rowIndex, 5] = person.SalaryDop;
            xlWorkSheet.Cells[rowIndex, 6] = person.Bonus;
            xlWorkSheet.Cells[rowIndex, 7] = person.SalaryFull;
        }

        private static void BorderAround(Excel.Worksheet xlWorkSheet, int row, int rowCount)
        {
            Excel.Range formatRange = xlWorkSheet.get_Range("a" + row, "g" + rowCount);
            formatRange.BorderAround(Excel.XlLineStyle.xlContinuous,
            Excel.XlBorderWeight.xlMedium, Excel.XlColorIndex.xlColorIndexAutomatic,
            Excel.XlColorIndex.xlColorIndexAutomatic);
        }

        private static void SetColumnWidth(Excel.Worksheet xlWorkSheet)
        {
            Excel.Range a = xlWorkSheet.get_Range("a:a");
            a.ColumnWidth = 12;
            Excel.Range c = xlWorkSheet.get_Range("c:c");
            c.ColumnWidth = 12;
            Excel.Range d = xlWorkSheet.get_Range("d:d");
            d.ColumnWidth = 12;
            Excel.Range e = xlWorkSheet.get_Range("e:e");
            e.ColumnWidth = 12;
            Excel.Range g = xlWorkSheet.get_Range("g:g");
            g.ColumnWidth = 12;
        }

        private static void HeadRow(Excel.Worksheet xlWorkSheet, int rowIndex)
        {
            Excel.Range formatRange = xlWorkSheet.get_Range("a" + rowIndex, "g" + rowIndex);
            formatRange.Interior.Color = ColorTranslator.ToOle(Color.LightGray);
            formatRange.Font.Color = Color.Black;
            xlWorkSheet.Cells[rowIndex, 1] = "Фамилия";
            xlWorkSheet.Cells[rowIndex, 2] = "Имя";
            xlWorkSheet.Cells[rowIndex, 3] = "Отчество";
            xlWorkSheet.Cells[rowIndex, 4] = "Зарплата руб.";
            xlWorkSheet.Cells[rowIndex, 5] = "Надбавка руб.";
            xlWorkSheet.Cells[rowIndex, 6] = "Премия %";
            xlWorkSheet.Cells[rowIndex, 7] = "Всего руб.";
        }

        //Заголовок отчета
        private static Excel.Range XlsHead(Excel.Worksheet xlWorkSheet)
        {
            Excel.Range chartRange;
            xlWorkSheet.get_Range("b1", "e2").Merge(false);
            chartRange = xlWorkSheet.get_Range("b1", "e2");
            chartRange.FormulaR1C1 = "Отчет по зарплате";
            chartRange.HorizontalAlignment = 3;
            chartRange.VerticalAlignment = 3;
            //chartRange.Interior.Color = ColorTranslator.ToOle(Color.LightGray);
            chartRange.Font.Color = ColorTranslator.ToOle(Color.Black);
            chartRange.Font.Size = 18;

            return chartRange;
        }

        /// <summary>
        /// Click event to update the data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Person person = new Person()
                {
                    Name = txt2Name.Text.Trim(),
                    Surname = txt2Surname.Text.Trim(),
                    Patronymic = txt2Patronymic.Text.Trim(),
                    SalaryBase = txt2SalaryBase.Text.Trim() == string.Empty ? 0 : Convert.ToDecimal(txt2SalaryBase.Text),
                    SalaryDop = txt2SalaryDop.Text.Trim() == string.Empty ? 0 : Convert.ToDecimal(txt2SalaryDop.Text),
                    Bonus = txt2Bonus.Text.Trim() == string.Empty ? 0 : Convert.ToDecimal(txt2Bonus.Text),
                    DepartmentID = (Department)cmb2Department.SelectedItem,
                    PersonID = memberId
                };

                var flag = personService.UpdatePerson(person);

                if (flag)
                {
                    DataTable data = this.personService.GetAllPersons();
                    this.LoadDataGridView(data);

                    MessageBox.Show(
                        "Данные обновлены",
                        "Сообщение",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                       "Ошибка обновления записи",
                       "Сообщение",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Удалить запись",
                "Сообщение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            try
            {
                var flag = personService.DeletePerson(memberId);

                if (flag)
                {
                    DataTable data = this.personService.GetAllPersons();
                    this.LoadDataGridView(data);

                    MessageBox.Show(
                        "Запись удалена",
                        "Сообщение",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                this.ShowErrorMessage(ex);
            }

        }

        /// <summary>
        /// Initializes all dropdown controls in update section
        /// </summary>
        private void InitializeUpdate()
        {
            cmb2Department.DataSource = departmentService.GetAllDepartment();
            cmb3Department.DataSource = departmentService.GetAllDepartment();
        }

        private void InitializeDropDownList()
        {
            cmbDepartment.DataSource = departmentService.GetAllDepartment();
            cmbDepartment.SelectedIndex = 0;
        }

        private void departmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDepartment frmDepartment = new FrmDepartment();
            frmDepartment.ShowDialog();
        }

        private void dgvPersons_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 4)
                {
                    e.Value = departmentService.GetDapartmentById((int)e.Value);
                }

            }
            catch (Exception ex)
            {
                this.ShowErrorMessage(ex);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Department department = (Department)cmb3Department.SelectedValue;

                DataTable data = this.personService.SearchPersons(department == null ? 0 : department.DepartmentID, txt3Surname.Text);
                this.LoadDataGridView(data);
            }
            catch (Exception ex)
            {
                this.ShowErrorMessage(ex);
            }
        }

        /// <summary>
        /// Resets search criteria
        /// </summary>
        private void ResetSearch()
        {
            cmb3Department.SelectedIndex = -1;
            txt3Surname.Text = "";
            DataTable data = personService.GetAllPersons();
            LoadDataGridView(data);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ResetSearch();
        }

        private void txt2Bonus_TextChanged(object sender, EventArgs e)
        {
            txtSalaryFull.Text = CalcSalary(txt2SalaryBase.Text, txt2SalaryDop.Text, txt2Bonus.Text);
            txtBonusRub.Text = bonusRub;
        }

        private string CalcSalary(string baseSalary, string dopSalary, string bonus)
        {
            decimal a = baseSalary == "" ? 0 : Convert.ToDecimal(baseSalary);
            decimal b = dopSalary == "" ? 0 : Convert.ToDecimal(dopSalary);
            decimal c = bonus == "" ? 0 : Convert.ToDecimal(bonus);

            decimal d = decimal.Round((a + b) * c / 100, 2);
            decimal e = decimal.Round((a + b) + d, 2);
            bonusRub = Convert.ToString(d);

            return Convert.ToString(e);
        }

        private void txt2SalaryDop_TextChanged(object sender, EventArgs e)
        {
            txtSalaryFull.Text = CalcSalary(txt2SalaryBase.Text, txt2SalaryDop.Text, txt2Bonus.Text);
            txtBonusRub.Text = bonusRub;
        }

        private void txt2SalaryBase_TextChanged(object sender, EventArgs e)
        {
            txtSalaryFull.Text = CalcSalary(txt2SalaryBase.Text, txt2SalaryDop.Text, txt2Bonus.Text);
            txtBonusRub.Text = bonusRub;
        }

        //начисление премии
        private void btnAddBonus_Click(object sender, EventArgs e)
        {
            FrmAddBonus frmAddBonus = new FrmAddBonus();
            frmAddBonus.ShowDialog();

            DataTable data = personService.GetAllPersons();
            LoadDataGridView(data);
        }

        private void txt2SalaryBase_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != ',');
        }

        private void txt2SalaryDop_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != ',');
        }

        private void txt2Bonus_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != ',');
        }

        private void txtSalaryBase_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != ',');
        }

        private void txtSalaryDop_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != ',');
        }

        private void txtBonus_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != ',');
        }
    }
}
