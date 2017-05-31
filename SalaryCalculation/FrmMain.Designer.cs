namespace SalaryCalculation
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPageNewPerson = new System.Windows.Forms.TabPage();
            this.tabControlPerson = new System.Windows.Forms.TabControl();
            this.tabPagePerson = new System.Windows.Forms.TabPage();
            this.lblDepartmentRequired = new System.Windows.Forms.Label();
            this.lblNameRequired = new System.Windows.Forms.Label();
            this.lblSurNameRequired = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.txtBonus = new System.Windows.Forms.TextBox();
            this.lblBonus = new System.Windows.Forms.Label();
            this.txtSalaryDop = new System.Windows.Forms.TextBox();
            this.lblSalaryDop = new System.Windows.Forms.Label();
            this.txtSalaryBase = new System.Windows.Forms.TextBox();
            this.lblBaseSalary = new System.Windows.Forms.Label();
            this.txtSurName = new System.Windows.Forms.TextBox();
            this.lblSurName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtPatronymic = new System.Windows.Forms.TextBox();
            this.lblPatronymic = new System.Windows.Forms.Label();
            this.tabPageManage = new System.Windows.Forms.TabPage();
            this.btnAddBonus = new System.Windows.Forms.Button();
            this.groupBoxPerson = new System.Windows.Forms.GroupBox();
            this.lblMoney = new System.Windows.Forms.Label();
            this.lblDash = new System.Windows.Forms.Label();
            this.txtBonusRub = new System.Windows.Forms.TextBox();
            this.lbl2Department = new System.Windows.Forms.Label();
            this.cmb2Department = new System.Windows.Forms.ComboBox();
            this.txtSalaryFull = new System.Windows.Forms.TextBox();
            this.lblSalaryFull = new System.Windows.Forms.Label();
            this.txt2Bonus = new System.Windows.Forms.TextBox();
            this.lbl2Bonus = new System.Windows.Forms.Label();
            this.txt2SalaryDop = new System.Windows.Forms.TextBox();
            this.lbl2SalaryDop = new System.Windows.Forms.Label();
            this.txt2SalaryBase = new System.Windows.Forms.TextBox();
            this.lbl2SalaryBase = new System.Windows.Forms.Label();
            this.txt2Patronymic = new System.Windows.Forms.TextBox();
            this.lbl2Patronymic = new System.Windows.Forms.Label();
            this.txt2Surname = new System.Windows.Forms.TextBox();
            this.lbl2Surname = new System.Windows.Forms.Label();
            this.txt2Name = new System.Windows.Forms.TextBox();
            this.lbl2Name = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tabControlSearch = new System.Windows.Forms.TabControl();
            this.tabPageSearch = new System.Windows.Forms.TabPage();
            this.txt3Surname = new System.Windows.Forms.TextBox();
            this.lbl3Name = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb3Department = new System.Windows.Forms.ComboBox();
            this.btnExportToXls = new System.Windows.Forms.Button();
            this.dgvPersons = new System.Windows.Forms.DataGridView();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabMain.SuspendLayout();
            this.tabPageNewPerson.SuspendLayout();
            this.tabControlPerson.SuspendLayout();
            this.tabPagePerson.SuspendLayout();
            this.tabPageManage.SuspendLayout();
            this.groupBoxPerson.SuspendLayout();
            this.tabControlSearch.SuspendLayout();
            this.tabPageSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersons)).BeginInit();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabPageNewPerson);
            this.tabMain.Controls.Add(this.tabPageManage);
            this.tabMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabMain.Location = new System.Drawing.Point(12, 45);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1141, 522);
            this.tabMain.TabIndex = 8;
            this.tabMain.SelectedIndexChanged += new System.EventHandler(this.tabMain_SelectedIndexChanged);
            // 
            // tabPageNewPerson
            // 
            this.tabPageNewPerson.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tabPageNewPerson.Controls.Add(this.tabControlPerson);
            this.tabPageNewPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPageNewPerson.Location = new System.Drawing.Point(4, 25);
            this.tabPageNewPerson.Name = "tabPageNewPerson";
            this.tabPageNewPerson.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNewPerson.Size = new System.Drawing.Size(1133, 493);
            this.tabPageNewPerson.TabIndex = 0;
            this.tabPageNewPerson.Text = "Новый сотрудник";
            // 
            // tabControlPerson
            // 
            this.tabControlPerson.Controls.Add(this.tabPagePerson);
            this.tabControlPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControlPerson.Location = new System.Drawing.Point(24, 21);
            this.tabControlPerson.Name = "tabControlPerson";
            this.tabControlPerson.SelectedIndex = 0;
            this.tabControlPerson.Size = new System.Drawing.Size(727, 244);
            this.tabControlPerson.TabIndex = 0;
            // 
            // tabPagePerson
            // 
            this.tabPagePerson.Controls.Add(this.lblDepartmentRequired);
            this.tabPagePerson.Controls.Add(this.lblNameRequired);
            this.tabPagePerson.Controls.Add(this.lblSurNameRequired);
            this.tabPagePerson.Controls.Add(this.lblDepartment);
            this.tabPagePerson.Controls.Add(this.cmbDepartment);
            this.tabPagePerson.Controls.Add(this.btnAddPerson);
            this.tabPagePerson.Controls.Add(this.txtBonus);
            this.tabPagePerson.Controls.Add(this.lblBonus);
            this.tabPagePerson.Controls.Add(this.txtSalaryDop);
            this.tabPagePerson.Controls.Add(this.lblSalaryDop);
            this.tabPagePerson.Controls.Add(this.txtSalaryBase);
            this.tabPagePerson.Controls.Add(this.lblBaseSalary);
            this.tabPagePerson.Controls.Add(this.txtSurName);
            this.tabPagePerson.Controls.Add(this.lblSurName);
            this.tabPagePerson.Controls.Add(this.txtName);
            this.tabPagePerson.Controls.Add(this.lblName);
            this.tabPagePerson.Controls.Add(this.txtPatronymic);
            this.tabPagePerson.Controls.Add(this.lblPatronymic);
            this.tabPagePerson.Location = new System.Drawing.Point(4, 25);
            this.tabPagePerson.Name = "tabPagePerson";
            this.tabPagePerson.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePerson.Size = new System.Drawing.Size(719, 215);
            this.tabPagePerson.TabIndex = 0;
            this.tabPagePerson.Text = "Сотрудник";
            this.tabPagePerson.UseVisualStyleBackColor = true;
            // 
            // lblDepartmentRequired
            // 
            this.lblDepartmentRequired.AutoSize = true;
            this.lblDepartmentRequired.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentRequired.ForeColor = System.Drawing.Color.Red;
            this.lblDepartmentRequired.Location = new System.Drawing.Point(93, 121);
            this.lblDepartmentRequired.Name = "lblDepartmentRequired";
            this.lblDepartmentRequired.Size = new System.Drawing.Size(21, 25);
            this.lblDepartmentRequired.TabIndex = 61;
            this.lblDepartmentRequired.Text = "*";
            // 
            // lblNameRequired
            // 
            this.lblNameRequired.AutoSize = true;
            this.lblNameRequired.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameRequired.ForeColor = System.Drawing.Color.Red;
            this.lblNameRequired.Location = new System.Drawing.Point(93, 62);
            this.lblNameRequired.Name = "lblNameRequired";
            this.lblNameRequired.Size = new System.Drawing.Size(21, 25);
            this.lblNameRequired.TabIndex = 60;
            this.lblNameRequired.Text = "*";
            // 
            // lblSurNameRequired
            // 
            this.lblSurNameRequired.AutoSize = true;
            this.lblSurNameRequired.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurNameRequired.ForeColor = System.Drawing.Color.Red;
            this.lblSurNameRequired.Location = new System.Drawing.Point(93, 37);
            this.lblSurNameRequired.Name = "lblSurNameRequired";
            this.lblSurNameRequired.Size = new System.Drawing.Size(21, 25);
            this.lblSurNameRequired.TabIndex = 59;
            this.lblSurNameRequired.Text = "*";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(20, 121);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(49, 16);
            this.lblDepartment.TabIndex = 58;
            this.lblDepartment.Text = "Отдел";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(138, 118);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(182, 24);
            this.cmbDepartment.TabIndex = 3;
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddPerson.Location = new System.Drawing.Point(583, 151);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(95, 37);
            this.btnAddPerson.TabIndex = 7;
            this.btnAddPerson.Text = "Добавить";
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // txtBonus
            // 
            this.txtBonus.Location = new System.Drawing.Point(481, 90);
            this.txtBonus.Name = "txtBonus";
            this.txtBonus.Size = new System.Drawing.Size(182, 22);
            this.txtBonus.TabIndex = 6;
            this.txtBonus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBonus_KeyPress);
            // 
            // lblBonus
            // 
            this.lblBonus.AutoSize = true;
            this.lblBonus.Location = new System.Drawing.Point(363, 93);
            this.lblBonus.Name = "lblBonus";
            this.lblBonus.Size = new System.Drawing.Size(76, 16);
            this.lblBonus.TabIndex = 10;
            this.lblBonus.Text = "Премия, %";
            // 
            // txtSalaryDop
            // 
            this.txtSalaryDop.Location = new System.Drawing.Point(481, 62);
            this.txtSalaryDop.Name = "txtSalaryDop";
            this.txtSalaryDop.Size = new System.Drawing.Size(182, 22);
            this.txtSalaryDop.TabIndex = 5;
            this.txtSalaryDop.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalaryDop_KeyPress);
            // 
            // lblSalaryDop
            // 
            this.lblSalaryDop.AutoSize = true;
            this.lblSalaryDop.Location = new System.Drawing.Point(363, 65);
            this.lblSalaryDop.Name = "lblSalaryDop";
            this.lblSalaryDop.Size = new System.Drawing.Size(106, 16);
            this.lblSalaryDop.TabIndex = 8;
            this.lblSalaryDop.Text = "Надбавка, руб.";
            // 
            // txtSalaryBase
            // 
            this.txtSalaryBase.Location = new System.Drawing.Point(481, 34);
            this.txtSalaryBase.Name = "txtSalaryBase";
            this.txtSalaryBase.Size = new System.Drawing.Size(182, 22);
            this.txtSalaryBase.TabIndex = 4;
            this.txtSalaryBase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalaryBase_KeyPress);
            // 
            // lblBaseSalary
            // 
            this.lblBaseSalary.AutoSize = true;
            this.lblBaseSalary.Location = new System.Drawing.Point(363, 37);
            this.lblBaseSalary.Name = "lblBaseSalary";
            this.lblBaseSalary.Size = new System.Drawing.Size(105, 16);
            this.lblBaseSalary.TabIndex = 6;
            this.lblBaseSalary.Text = "Зарплата, руб.";
            // 
            // txtSurName
            // 
            this.txtSurName.Location = new System.Drawing.Point(138, 34);
            this.txtSurName.Name = "txtSurName";
            this.txtSurName.Size = new System.Drawing.Size(182, 22);
            this.txtSurName.TabIndex = 0;
            // 
            // lblSurName
            // 
            this.lblSurName.AutoSize = true;
            this.lblSurName.Location = new System.Drawing.Point(20, 37);
            this.lblSurName.Name = "lblSurName";
            this.lblSurName.Size = new System.Drawing.Size(67, 16);
            this.lblSurName.TabIndex = 4;
            this.lblSurName.Text = "Фамилия";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(138, 62);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(182, 22);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(20, 65);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(34, 16);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Имя";
            // 
            // txtPatronymic
            // 
            this.txtPatronymic.Location = new System.Drawing.Point(138, 90);
            this.txtPatronymic.Name = "txtPatronymic";
            this.txtPatronymic.Size = new System.Drawing.Size(182, 22);
            this.txtPatronymic.TabIndex = 2;
            // 
            // lblPatronymic
            // 
            this.lblPatronymic.AutoSize = true;
            this.lblPatronymic.Location = new System.Drawing.Point(20, 93);
            this.lblPatronymic.Name = "lblPatronymic";
            this.lblPatronymic.Size = new System.Drawing.Size(71, 16);
            this.lblPatronymic.TabIndex = 0;
            this.lblPatronymic.Text = "Отчество";
            // 
            // tabPageManage
            // 
            this.tabPageManage.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tabPageManage.Controls.Add(this.btnAddBonus);
            this.tabPageManage.Controls.Add(this.groupBoxPerson);
            this.tabPageManage.Controls.Add(this.tabControlSearch);
            this.tabPageManage.Controls.Add(this.btnExportToXls);
            this.tabPageManage.Controls.Add(this.dgvPersons);
            this.tabPageManage.Location = new System.Drawing.Point(4, 25);
            this.tabPageManage.Name = "tabPageManage";
            this.tabPageManage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageManage.Size = new System.Drawing.Size(1133, 493);
            this.tabPageManage.TabIndex = 1;
            this.tabPageManage.Text = "Поиск/Управление";
            // 
            // btnAddBonus
            // 
            this.btnAddBonus.Location = new System.Drawing.Point(6, 117);
            this.btnAddBonus.Name = "btnAddBonus";
            this.btnAddBonus.Size = new System.Drawing.Size(195, 28);
            this.btnAddBonus.TabIndex = 11;
            this.btnAddBonus.Text = "Начислить премию отделу";
            this.btnAddBonus.UseVisualStyleBackColor = true;
            this.btnAddBonus.Click += new System.EventHandler(this.btnAddBonus_Click);
            // 
            // groupBoxPerson
            // 
            this.groupBoxPerson.Controls.Add(this.lblMoney);
            this.groupBoxPerson.Controls.Add(this.lblDash);
            this.groupBoxPerson.Controls.Add(this.txtBonusRub);
            this.groupBoxPerson.Controls.Add(this.lbl2Department);
            this.groupBoxPerson.Controls.Add(this.cmb2Department);
            this.groupBoxPerson.Controls.Add(this.txtSalaryFull);
            this.groupBoxPerson.Controls.Add(this.lblSalaryFull);
            this.groupBoxPerson.Controls.Add(this.txt2Bonus);
            this.groupBoxPerson.Controls.Add(this.lbl2Bonus);
            this.groupBoxPerson.Controls.Add(this.txt2SalaryDop);
            this.groupBoxPerson.Controls.Add(this.lbl2SalaryDop);
            this.groupBoxPerson.Controls.Add(this.txt2SalaryBase);
            this.groupBoxPerson.Controls.Add(this.lbl2SalaryBase);
            this.groupBoxPerson.Controls.Add(this.txt2Patronymic);
            this.groupBoxPerson.Controls.Add(this.lbl2Patronymic);
            this.groupBoxPerson.Controls.Add(this.txt2Surname);
            this.groupBoxPerson.Controls.Add(this.lbl2Surname);
            this.groupBoxPerson.Controls.Add(this.txt2Name);
            this.groupBoxPerson.Controls.Add(this.lbl2Name);
            this.groupBoxPerson.Controls.Add(this.btnUpdate);
            this.groupBoxPerson.Controls.Add(this.btnDelete);
            this.groupBoxPerson.Location = new System.Drawing.Point(803, 145);
            this.groupBoxPerson.Name = "groupBoxPerson";
            this.groupBoxPerson.Size = new System.Drawing.Size(324, 342);
            this.groupBoxPerson.TabIndex = 63;
            this.groupBoxPerson.TabStop = false;
            this.groupBoxPerson.Text = "Сотрудник";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Location = new System.Drawing.Point(262, 203);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(35, 16);
            this.lblMoney.TabIndex = 77;
            this.lblMoney.Text = ".руб";
            // 
            // lblDash
            // 
            this.lblDash.AutoSize = true;
            this.lblDash.Location = new System.Drawing.Point(188, 203);
            this.lblDash.Name = "lblDash";
            this.lblDash.Size = new System.Drawing.Size(12, 16);
            this.lblDash.TabIndex = 76;
            this.lblDash.Text = "-";
            // 
            // txtBonusRub
            // 
            this.txtBonusRub.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBonusRub.Location = new System.Drawing.Point(202, 201);
            this.txtBonusRub.Name = "txtBonusRub";
            this.txtBonusRub.ReadOnly = true;
            this.txtBonusRub.Size = new System.Drawing.Size(56, 22);
            this.txtBonusRub.TabIndex = 7;
            // 
            // lbl2Department
            // 
            this.lbl2Department.AutoSize = true;
            this.lbl2Department.Location = new System.Drawing.Point(24, 118);
            this.lbl2Department.Name = "lbl2Department";
            this.lbl2Department.Size = new System.Drawing.Size(49, 16);
            this.lbl2Department.TabIndex = 74;
            this.lbl2Department.Text = "Отдел";
            // 
            // cmb2Department
            // 
            this.cmb2Department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb2Department.FormattingEnabled = true;
            this.cmb2Department.Location = new System.Drawing.Point(129, 115);
            this.cmb2Department.Name = "cmb2Department";
            this.cmb2Department.Size = new System.Drawing.Size(167, 24);
            this.cmb2Department.TabIndex = 3;
            // 
            // txtSalaryFull
            // 
            this.txtSalaryFull.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSalaryFull.Enabled = false;
            this.txtSalaryFull.Location = new System.Drawing.Point(144, 256);
            this.txtSalaryFull.Name = "txtSalaryFull";
            this.txtSalaryFull.Size = new System.Drawing.Size(152, 22);
            this.txtSalaryFull.TabIndex = 8;
            // 
            // lblSalaryFull
            // 
            this.lblSalaryFull.AutoSize = true;
            this.lblSalaryFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSalaryFull.Location = new System.Drawing.Point(24, 258);
            this.lblSalaryFull.Name = "lblSalaryFull";
            this.lblSalaryFull.Size = new System.Drawing.Size(98, 16);
            this.lblSalaryFull.TabIndex = 71;
            this.lblSalaryFull.Text = "ИТОГО, руб.";
            // 
            // txt2Bonus
            // 
            this.txt2Bonus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt2Bonus.Location = new System.Drawing.Point(129, 201);
            this.txt2Bonus.Name = "txt2Bonus";
            this.txt2Bonus.Size = new System.Drawing.Size(55, 22);
            this.txt2Bonus.TabIndex = 6;
            this.txt2Bonus.TextChanged += new System.EventHandler(this.txt2Bonus_TextChanged);
            this.txt2Bonus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt2Bonus_KeyPress);
            // 
            // lbl2Bonus
            // 
            this.lbl2Bonus.AutoSize = true;
            this.lbl2Bonus.Location = new System.Drawing.Point(24, 203);
            this.lbl2Bonus.Name = "lbl2Bonus";
            this.lbl2Bonus.Size = new System.Drawing.Size(76, 16);
            this.lbl2Bonus.TabIndex = 69;
            this.lbl2Bonus.Text = "Премия, %";
            // 
            // txt2SalaryDop
            // 
            this.txt2SalaryDop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt2SalaryDop.Location = new System.Drawing.Point(129, 173);
            this.txt2SalaryDop.Name = "txt2SalaryDop";
            this.txt2SalaryDop.Size = new System.Drawing.Size(167, 22);
            this.txt2SalaryDop.TabIndex = 5;
            this.txt2SalaryDop.TextChanged += new System.EventHandler(this.txt2SalaryDop_TextChanged);
            this.txt2SalaryDop.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt2SalaryDop_KeyPress);
            // 
            // lbl2SalaryDop
            // 
            this.lbl2SalaryDop.AutoSize = true;
            this.lbl2SalaryDop.Location = new System.Drawing.Point(24, 175);
            this.lbl2SalaryDop.Name = "lbl2SalaryDop";
            this.lbl2SalaryDop.Size = new System.Drawing.Size(106, 16);
            this.lbl2SalaryDop.TabIndex = 67;
            this.lbl2SalaryDop.Text = "Надбавка, руб.";
            // 
            // txt2SalaryBase
            // 
            this.txt2SalaryBase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt2SalaryBase.Location = new System.Drawing.Point(129, 145);
            this.txt2SalaryBase.Name = "txt2SalaryBase";
            this.txt2SalaryBase.Size = new System.Drawing.Size(167, 22);
            this.txt2SalaryBase.TabIndex = 4;
            this.txt2SalaryBase.TextChanged += new System.EventHandler(this.txt2SalaryBase_TextChanged);
            this.txt2SalaryBase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt2SalaryBase_KeyPress);
            // 
            // lbl2SalaryBase
            // 
            this.lbl2SalaryBase.AutoSize = true;
            this.lbl2SalaryBase.Location = new System.Drawing.Point(24, 147);
            this.lbl2SalaryBase.Name = "lbl2SalaryBase";
            this.lbl2SalaryBase.Size = new System.Drawing.Size(105, 16);
            this.lbl2SalaryBase.TabIndex = 65;
            this.lbl2SalaryBase.Text = "Зарплата, руб.";
            // 
            // txt2Patronymic
            // 
            this.txt2Patronymic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt2Patronymic.Location = new System.Drawing.Point(129, 87);
            this.txt2Patronymic.Name = "txt2Patronymic";
            this.txt2Patronymic.Size = new System.Drawing.Size(167, 22);
            this.txt2Patronymic.TabIndex = 2;
            // 
            // lbl2Patronymic
            // 
            this.lbl2Patronymic.AutoSize = true;
            this.lbl2Patronymic.Location = new System.Drawing.Point(24, 89);
            this.lbl2Patronymic.Name = "lbl2Patronymic";
            this.lbl2Patronymic.Size = new System.Drawing.Size(71, 16);
            this.lbl2Patronymic.TabIndex = 63;
            this.lbl2Patronymic.Text = "Отчество";
            // 
            // txt2Surname
            // 
            this.txt2Surname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt2Surname.Location = new System.Drawing.Point(129, 31);
            this.txt2Surname.Name = "txt2Surname";
            this.txt2Surname.Size = new System.Drawing.Size(167, 22);
            this.txt2Surname.TabIndex = 0;
            // 
            // lbl2Surname
            // 
            this.lbl2Surname.AutoSize = true;
            this.lbl2Surname.Location = new System.Drawing.Point(24, 33);
            this.lbl2Surname.Name = "lbl2Surname";
            this.lbl2Surname.Size = new System.Drawing.Size(67, 16);
            this.lbl2Surname.TabIndex = 61;
            this.lbl2Surname.Text = "Фамилия";
            // 
            // txt2Name
            // 
            this.txt2Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt2Name.Location = new System.Drawing.Point(129, 59);
            this.txt2Name.Name = "txt2Name";
            this.txt2Name.Size = new System.Drawing.Size(167, 22);
            this.txt2Name.TabIndex = 1;
            // 
            // lbl2Name
            // 
            this.lbl2Name.AutoSize = true;
            this.lbl2Name.Location = new System.Drawing.Point(24, 61);
            this.lbl2Name.Name = "lbl2Name";
            this.lbl2Name.Size = new System.Drawing.Size(34, 16);
            this.lbl2Name.TabIndex = 59;
            this.lbl2Name.Text = "Имя";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(129, 301);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(84, 27);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Обновить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(219, 301);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(77, 27);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tabControlSearch
            // 
            this.tabControlSearch.Controls.Add(this.tabPageSearch);
            this.tabControlSearch.Location = new System.Drawing.Point(6, 6);
            this.tabControlSearch.Name = "tabControlSearch";
            this.tabControlSearch.SelectedIndex = 0;
            this.tabControlSearch.Size = new System.Drawing.Size(791, 103);
            this.tabControlSearch.TabIndex = 62;
            // 
            // tabPageSearch
            // 
            this.tabPageSearch.Controls.Add(this.txt3Surname);
            this.tabPageSearch.Controls.Add(this.lbl3Name);
            this.tabPageSearch.Controls.Add(this.btnRefresh);
            this.tabPageSearch.Controls.Add(this.btnSearch);
            this.tabPageSearch.Controls.Add(this.label3);
            this.tabPageSearch.Controls.Add(this.cmb3Department);
            this.tabPageSearch.Location = new System.Drawing.Point(4, 25);
            this.tabPageSearch.Name = "tabPageSearch";
            this.tabPageSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearch.Size = new System.Drawing.Size(783, 74);
            this.tabPageSearch.TabIndex = 0;
            this.tabPageSearch.Text = "Поиск";
            this.tabPageSearch.UseVisualStyleBackColor = true;
            // 
            // txt3Surname
            // 
            this.txt3Surname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt3Surname.Location = new System.Drawing.Point(204, 30);
            this.txt3Surname.Name = "txt3Surname";
            this.txt3Surname.Size = new System.Drawing.Size(152, 22);
            this.txt3Surname.TabIndex = 1;
            // 
            // lbl3Name
            // 
            this.lbl3Name.AutoSize = true;
            this.lbl3Name.Location = new System.Drawing.Point(201, 7);
            this.lbl3Name.Name = "lbl3Name";
            this.lbl3Name.Size = new System.Drawing.Size(67, 16);
            this.lbl3Name.TabIndex = 44;
            this.lbl3Name.Text = "Фамилия";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(482, 26);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 28);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Очистить";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(376, 26);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 28);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Найти";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(26, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Отдел";
            // 
            // cmb3Department
            // 
            this.cmb3Department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb3Department.FormattingEnabled = true;
            this.cmb3Department.Location = new System.Drawing.Point(29, 29);
            this.cmb3Department.Name = "cmb3Department";
            this.cmb3Department.Size = new System.Drawing.Size(162, 24);
            this.cmb3Department.TabIndex = 0;
            // 
            // btnExportToXls
            // 
            this.btnExportToXls.Location = new System.Drawing.Point(676, 117);
            this.btnExportToXls.Name = "btnExportToXls";
            this.btnExportToXls.Size = new System.Drawing.Size(117, 28);
            this.btnExportToXls.TabIndex = 12;
            this.btnExportToXls.Text = "Экспорт в XLS";
            this.btnExportToXls.UseVisualStyleBackColor = true;
            this.btnExportToXls.Click += new System.EventHandler(this.btnExportToXls_Click);
            // 
            // dgvPersons
            // 
            this.dgvPersons.AllowUserToAddRows = false;
            this.dgvPersons.AllowUserToOrderColumns = true;
            this.dgvPersons.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPersons.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPersons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersons.Location = new System.Drawing.Point(6, 151);
            this.dgvPersons.Name = "dgvPersons";
            this.dgvPersons.ReadOnly = true;
            this.dgvPersons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersons.Size = new System.Drawing.Size(791, 336);
            this.dgvPersons.TabIndex = 0;
            this.dgvPersons.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPersons_CellFormatting);
            this.dgvPersons.SelectionChanged += new System.EventHandler(this.dgvPersons_SelectionChanged);
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.dirToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(1165, 24);
            this.menuStripMain.TabIndex = 1;
            this.menuStripMain.Text = "menuStripMain";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            // 
            // dirToolStripMenuItem
            // 
            this.dirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.departmentsToolStripMenuItem});
            this.dirToolStripMenuItem.Name = "dirToolStripMenuItem";
            this.dirToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.dirToolStripMenuItem.Text = "Справочники";
            // 
            // departmentsToolStripMenuItem
            // 
            this.departmentsToolStripMenuItem.Name = "departmentsToolStripMenuItem";
            this.departmentsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.departmentsToolStripMenuItem.Text = "Отделы";
            this.departmentsToolStripMenuItem.Click += new System.EventHandler(this.departmentsToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 579);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.menuStripMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Зарплата";
            this.tabMain.ResumeLayout(false);
            this.tabPageNewPerson.ResumeLayout(false);
            this.tabControlPerson.ResumeLayout(false);
            this.tabPagePerson.ResumeLayout(false);
            this.tabPagePerson.PerformLayout();
            this.tabPageManage.ResumeLayout(false);
            this.groupBoxPerson.ResumeLayout(false);
            this.groupBoxPerson.PerformLayout();
            this.tabControlSearch.ResumeLayout(false);
            this.tabPageSearch.ResumeLayout(false);
            this.tabPageSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersons)).EndInit();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabPageNewPerson;
        private System.Windows.Forms.TabPage tabPageManage;
        private System.Windows.Forms.TabControl tabControlPerson;
        private System.Windows.Forms.TabPage tabPagePerson;
        private System.Windows.Forms.TextBox txtPatronymic;
        private System.Windows.Forms.Label lblPatronymic;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.TextBox txtBonus;
        private System.Windows.Forms.Label lblBonus;
        private System.Windows.Forms.TextBox txtSalaryDop;
        private System.Windows.Forms.Label lblSalaryDop;
        private System.Windows.Forms.TextBox txtSalaryBase;
        private System.Windows.Forms.Label lblBaseSalary;
        private System.Windows.Forms.TextBox txtSurName;
        private System.Windows.Forms.Label lblSurName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataGridView dgvPersons;
        private System.Windows.Forms.Button btnExportToXls;
        private System.Windows.Forms.ToolStripMenuItem dirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departmentsToolStripMenuItem;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label lblDepartmentRequired;
        private System.Windows.Forms.Label lblNameRequired;
        private System.Windows.Forms.Label lblSurNameRequired;
        private System.Windows.Forms.TabControl tabControlSearch;
        private System.Windows.Forms.TabPage tabPageSearch;
        private System.Windows.Forms.TextBox txt3Surname;
        private System.Windows.Forms.Label lbl3Name;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb3Department;
        private System.Windows.Forms.GroupBox groupBoxPerson;
        private System.Windows.Forms.Label lbl2Department;
        private System.Windows.Forms.ComboBox cmb2Department;
        private System.Windows.Forms.TextBox txtSalaryFull;
        private System.Windows.Forms.Label lblSalaryFull;
        private System.Windows.Forms.TextBox txt2Bonus;
        private System.Windows.Forms.Label lbl2Bonus;
        private System.Windows.Forms.TextBox txt2SalaryDop;
        private System.Windows.Forms.Label lbl2SalaryDop;
        private System.Windows.Forms.TextBox txt2SalaryBase;
        private System.Windows.Forms.Label lbl2SalaryBase;
        private System.Windows.Forms.TextBox txt2Patronymic;
        private System.Windows.Forms.Label lbl2Patronymic;
        private System.Windows.Forms.TextBox txt2Surname;
        private System.Windows.Forms.Label lbl2Surname;
        private System.Windows.Forms.TextBox txt2Name;
        private System.Windows.Forms.Label lbl2Name;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label lblDash;
        private System.Windows.Forms.TextBox txtBonusRub;
        private System.Windows.Forms.Button btnAddBonus;
    }
}

