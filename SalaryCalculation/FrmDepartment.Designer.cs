namespace SalaryCalculation
{
    partial class FrmDepartment
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
            this.listBoxDepartment = new System.Windows.Forms.ListBox();
            this.lbl2DepartmentID = new System.Windows.Forms.Label();
            this.txt2DepartmentID = new System.Windows.Forms.TextBox();
            this.txt2DepName = new System.Windows.Forms.TextBox();
            this.lbl2DepName = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tabControlDepartment = new System.Windows.Forms.TabControl();
            this.tabPageAddDepartment = new System.Windows.Forms.TabPage();
            this.txtDepName = new System.Windows.Forms.TextBox();
            this.lblDepName = new System.Windows.Forms.Label();
            this.txtDepartmentID = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblDepartmentID = new System.Windows.Forms.Label();
            this.tabPageManageDepartment = new System.Windows.Forms.TabPage();
            this.statusStripDepartment = new System.Windows.Forms.StatusStrip();
            this.tabControlDepartment.SuspendLayout();
            this.tabPageAddDepartment.SuspendLayout();
            this.tabPageManageDepartment.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxDepartment
            // 
            this.listBoxDepartment.FormattingEnabled = true;
            this.listBoxDepartment.Location = new System.Drawing.Point(6, 6);
            this.listBoxDepartment.Name = "listBoxDepartment";
            this.listBoxDepartment.Size = new System.Drawing.Size(212, 199);
            this.listBoxDepartment.TabIndex = 0;
            this.listBoxDepartment.SelectedIndexChanged += new System.EventHandler(this.listBoxDepartment_SelectedIndexChanged);
            // 
            // lbl2DepartmentID
            // 
            this.lbl2DepartmentID.AutoSize = true;
            this.lbl2DepartmentID.Location = new System.Drawing.Point(237, 36);
            this.lbl2DepartmentID.Name = "lbl2DepartmentID";
            this.lbl2DepartmentID.Size = new System.Drawing.Size(52, 13);
            this.lbl2DepartmentID.TabIndex = 1;
            this.lbl2DepartmentID.Text = "Отдел №";
            // 
            // txt2DepartmentID
            // 
            this.txt2DepartmentID.Location = new System.Drawing.Point(305, 33);
            this.txt2DepartmentID.Name = "txt2DepartmentID";
            this.txt2DepartmentID.ReadOnly = true;
            this.txt2DepartmentID.Size = new System.Drawing.Size(100, 20);
            this.txt2DepartmentID.TabIndex = 2;
            // 
            // txt2DepName
            // 
            this.txt2DepName.Location = new System.Drawing.Point(305, 73);
            this.txt2DepName.Name = "txt2DepName";
            this.txt2DepName.Size = new System.Drawing.Size(100, 20);
            this.txt2DepName.TabIndex = 4;
            // 
            // lbl2DepName
            // 
            this.lbl2DepName.AutoSize = true;
            this.lbl2DepName.Location = new System.Drawing.Point(237, 76);
            this.lbl2DepName.Name = "lbl2DepName";
            this.lbl2DepName.Size = new System.Drawing.Size(57, 13);
            this.lbl2DepName.TabIndex = 3;
            this.lbl2DepName.Text = "Название";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(305, 160);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Обновить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(386, 160);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tabControlDepartment
            // 
            this.tabControlDepartment.Controls.Add(this.tabPageAddDepartment);
            this.tabControlDepartment.Controls.Add(this.tabPageManageDepartment);
            this.tabControlDepartment.Location = new System.Drawing.Point(12, 12);
            this.tabControlDepartment.Name = "tabControlDepartment";
            this.tabControlDepartment.SelectedIndex = 0;
            this.tabControlDepartment.Size = new System.Drawing.Size(492, 239);
            this.tabControlDepartment.TabIndex = 8;
            this.tabControlDepartment.SelectedIndexChanged += new System.EventHandler(this.tabControlDepartment_SelectedIndexChanged);
            // 
            // tabPageAddDepartment
            // 
            this.tabPageAddDepartment.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPageAddDepartment.Controls.Add(this.txtDepName);
            this.tabPageAddDepartment.Controls.Add(this.lblDepName);
            this.tabPageAddDepartment.Controls.Add(this.txtDepartmentID);
            this.tabPageAddDepartment.Controls.Add(this.btnAdd);
            this.tabPageAddDepartment.Controls.Add(this.lblDepartmentID);
            this.tabPageAddDepartment.Location = new System.Drawing.Point(4, 22);
            this.tabPageAddDepartment.Name = "tabPageAddDepartment";
            this.tabPageAddDepartment.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddDepartment.Size = new System.Drawing.Size(484, 213);
            this.tabPageAddDepartment.TabIndex = 0;
            this.tabPageAddDepartment.Text = "Новый отдел";
            // 
            // txtDepName
            // 
            this.txtDepName.Location = new System.Drawing.Point(110, 74);
            this.txtDepName.Name = "txtDepName";
            this.txtDepName.Size = new System.Drawing.Size(224, 20);
            this.txtDepName.TabIndex = 13;
            // 
            // lblDepName
            // 
            this.lblDepName.AutoSize = true;
            this.lblDepName.Location = new System.Drawing.Point(42, 77);
            this.lblDepName.Name = "lblDepName";
            this.lblDepName.Size = new System.Drawing.Size(57, 13);
            this.lblDepName.TabIndex = 12;
            this.lblDepName.Text = "Название";
            // 
            // txtDepartmentID
            // 
            this.txtDepartmentID.Location = new System.Drawing.Point(110, 34);
            this.txtDepartmentID.Name = "txtDepartmentID";
            this.txtDepartmentID.Size = new System.Drawing.Size(224, 20);
            this.txtDepartmentID.TabIndex = 11;
            this.txtDepartmentID.TextChanged += new System.EventHandler(this.txtDepartmentID_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(367, 156);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblDepartmentID
            // 
            this.lblDepartmentID.AutoSize = true;
            this.lblDepartmentID.Location = new System.Drawing.Point(42, 37);
            this.lblDepartmentID.Name = "lblDepartmentID";
            this.lblDepartmentID.Size = new System.Drawing.Size(52, 13);
            this.lblDepartmentID.TabIndex = 10;
            this.lblDepartmentID.Text = "Отдел №";
            // 
            // tabPageManageDepartment
            // 
            this.tabPageManageDepartment.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPageManageDepartment.Controls.Add(this.listBoxDepartment);
            this.tabPageManageDepartment.Controls.Add(this.btnDelete);
            this.tabPageManageDepartment.Controls.Add(this.btnUpdate);
            this.tabPageManageDepartment.Controls.Add(this.lbl2DepartmentID);
            this.tabPageManageDepartment.Controls.Add(this.txt2DepName);
            this.tabPageManageDepartment.Controls.Add(this.txt2DepartmentID);
            this.tabPageManageDepartment.Controls.Add(this.lbl2DepName);
            this.tabPageManageDepartment.Location = new System.Drawing.Point(4, 22);
            this.tabPageManageDepartment.Name = "tabPageManageDepartment";
            this.tabPageManageDepartment.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageManageDepartment.Size = new System.Drawing.Size(484, 213);
            this.tabPageManageDepartment.TabIndex = 1;
            this.tabPageManageDepartment.Text = "Управление";
            // 
            // statusStripDepartment
            // 
            this.statusStripDepartment.Location = new System.Drawing.Point(0, 261);
            this.statusStripDepartment.Name = "statusStripDepartment";
            this.statusStripDepartment.Size = new System.Drawing.Size(513, 22);
            this.statusStripDepartment.TabIndex = 9;
            this.statusStripDepartment.Text = "statusStrip1";
            // 
            // FrmDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(513, 283);
            this.Controls.Add(this.statusStripDepartment);
            this.Controls.Add(this.tabControlDepartment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отделы";
            this.tabControlDepartment.ResumeLayout(false);
            this.tabPageAddDepartment.ResumeLayout(false);
            this.tabPageAddDepartment.PerformLayout();
            this.tabPageManageDepartment.ResumeLayout(false);
            this.tabPageManageDepartment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxDepartment;
        private System.Windows.Forms.Label lbl2DepartmentID;
        private System.Windows.Forms.TextBox txt2DepartmentID;
        private System.Windows.Forms.TextBox txt2DepName;
        private System.Windows.Forms.Label lbl2DepName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TabControl tabControlDepartment;
        private System.Windows.Forms.TabPage tabPageAddDepartment;
        private System.Windows.Forms.TextBox txtDepName;
        private System.Windows.Forms.Label lblDepName;
        private System.Windows.Forms.TextBox txtDepartmentID;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblDepartmentID;
        private System.Windows.Forms.TabPage tabPageManageDepartment;
        private System.Windows.Forms.StatusStrip statusStripDepartment;
    }
}