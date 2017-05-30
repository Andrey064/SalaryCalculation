namespace SalaryCalculation
{
    partial class FrmAddBonus
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
            this.txt3Bonus = new System.Windows.Forms.TextBox();
            this.lbl3Bonus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb3Department = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt3Bonus
            // 
            this.txt3Bonus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt3Bonus.Location = new System.Drawing.Point(110, 96);
            this.txt3Bonus.Name = "txt3Bonus";
            this.txt3Bonus.Size = new System.Drawing.Size(79, 20);
            this.txt3Bonus.TabIndex = 68;
            this.txt3Bonus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt3Bonus_KeyPress);
            // 
            // lbl3Bonus
            // 
            this.lbl3Bonus.AutoSize = true;
            this.lbl3Bonus.Location = new System.Drawing.Point(28, 98);
            this.lbl3Bonus.Name = "lbl3Bonus";
            this.lbl3Bonus.Size = new System.Drawing.Size(61, 13);
            this.lbl3Bonus.TabIndex = 67;
            this.lbl3Bonus.Text = "Премия, %";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 70;
            this.label3.Text = "Отдел";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cmb3Department
            // 
            this.cmb3Department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb3Department.FormattingEnabled = true;
            this.cmb3Department.Location = new System.Drawing.Point(27, 43);
            this.cmb3Department.Name = "cmb3Department";
            this.cmb3Department.Size = new System.Drawing.Size(162, 21);
            this.cmb3Department.TabIndex = 69;
            this.cmb3Department.SelectedIndexChanged += new System.EventHandler(this.cmb3Department_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(27, 157);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 71;
            this.btnAdd.Text = "Начислить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(114, 157);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 72;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmAddBonus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 210);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb3Department);
            this.Controls.Add(this.txt3Bonus);
            this.Controls.Add(this.lbl3Bonus);
            this.Name = "FrmAddBonus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Премия";
            this.Load += new System.EventHandler(this.FrmAddBonus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt3Bonus;
        private System.Windows.Forms.Label lbl3Bonus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb3Department;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
    }
}