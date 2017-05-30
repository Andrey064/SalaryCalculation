using Salary.Model;
using Salary.Model.BusinessService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculation
{
    public partial class FrmDepartment : Form
    {
        private IDepartmentService departmentService;
        private Department department;

        public FrmDepartment()
        {
            InitializeComponent();
            departmentService = new DepartmentService();
            LoadListBox(departmentService.GetAllDepartment());
        }

        public void LoadListBox(List<Department> departmentList)
        {
            listBoxDepartment.DataSource = departmentList;
        }

        /// <summary>
        /// Check if department exsists in database
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private string CheckDepartmentIdDB(int id)
        {
            return departmentService.GetDapartmentById(id);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Department department = new Department()
                {
                    DepartmentID = txtDepartmentID.Text.Trim() == string.Empty ? 0 : Convert.ToInt32(txtDepartmentID.Text),
                    DepName = txtDepName.Text.Trim(),
                };

                var success = departmentService.AddDepartment(department);

                if (success)
                {
                    MessageBox.Show(
                        "Отдел " + txtDepName.Text.Trim() + " добавлен в базу",
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
            catch (Exception ex)
            {
                ShowErrorMessage(ex);
            }
        }

        private void ResetRegistration()
        {
            txtDepName.Text = string.Empty;
            txtDepartmentID.Text = "";
        }

        private void ShowErrorMessage(Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                //Resources.System_Error_Message, 
                "Ошибка - Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private void tabControlDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetDepartment();
            ResetRegistration();
            try
            {
                if (tabControlDepartment.SelectedIndex == 1)
                {
                    List<Department> data = departmentService.GetAllDepartment();
                    LoadListBox(data);
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex);
            }
        }

        private void ResetDepartment()
        {
            statusStripDepartment.Items.Clear();
        }

        private void txtDepartmentID_TextChanged(object sender, EventArgs e)
        {
            if (txtDepartmentID.Text != "")
            {
                CheckDepartment(sender);
            }
        }

        private void CheckDepartment(object sender)
        {
            ResetDepartment();

            string str = (sender as TextBox).Text;
            int depId = Convert.ToInt32(str);
            string depStr = CheckDepartmentIdDB(depId);
            if (depStr != "")
            {
                statusStripDepartment.Items.Add("Отдел c номером " + str + " - " + depStr + " уже существует");
            }
        }


        private void listBoxDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            department = (Department)listBoxDepartment.SelectedValue;
            txt2DepartmentID.Text = department.DepartmentID.ToString();
            txt2DepName.Text = department.DepName;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            PersonService personService = new PersonService();

            int rows = personService.GetPersonsByDepartmentId(department.DepartmentID).Rows.Count;

            if (rows > 0)
            {
                MessageBox.Show(
                "В отделе " + department.DepName + " (количество сотрудников - " + rows + ") \n Удалить можно отдел в котором нет сотрудников!",
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Asterisk);

                return;
            }

            DialogResult result = MessageBox.Show(
                "Удалить отдел " + department.DepName + "?",
                "Сообщение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            try
            {
                departmentService.DeleteDepartment(department.DepartmentID);
                LoadListBox(departmentService.GetAllDepartment());
            }
            catch
            { }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            department.DepartmentID = Convert.ToInt32(txt2DepartmentID.Text);
            department.DepName = txt2DepName.Text;
            departmentService.UpdateDepartment(department);

            LoadListBox(departmentService.GetAllDepartment());
        }

    }
}
