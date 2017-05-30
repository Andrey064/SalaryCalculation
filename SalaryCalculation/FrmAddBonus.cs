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
    public partial class FrmAddBonus : Form
    {
        private IDepartmentService departmentService;
        private IPersonService personService;

        public FrmAddBonus()
        {
            InitializeComponent();
            departmentService = new DepartmentService();
            personService = new PersonService();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cmb3Department_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Initialize()
        {
            cmb3Department.DataSource = departmentService.GetAllDepartment();
        }

        private void FrmAddBonus_Load(object sender, EventArgs e)
        {
            Initialize();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txt3Bonus.Text == "") || (cmb3Department.SelectedIndex==0))
                {
                    return;
                }

                decimal bonus = Convert.ToDecimal(txt3Bonus.Text);
                Department department = (Department)cmb3Department.SelectedValue;

                personService.UpdateBonusByDepartmentId(bonus, department.DepartmentID);
                Close();
            }
            catch
            { }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt3Bonus_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != ',');
        }
    }
}
