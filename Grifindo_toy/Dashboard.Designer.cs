
namespace Grifindo_toy
{
    partial class frm_dashboard
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
            this.btn_emoloyee = new System.Windows.Forms.Button();
            this.btn_salary = new System.Windows.Forms.Button();
            this.btn_settings = new System.Windows.Forms.Button();
            this.btn_showSal = new System.Windows.Forms.Button();
            this.btn_signout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_emoloyee
            // 
            this.btn_emoloyee.Location = new System.Drawing.Point(173, 84);
            this.btn_emoloyee.Name = "btn_emoloyee";
            this.btn_emoloyee.Size = new System.Drawing.Size(128, 53);
            this.btn_emoloyee.TabIndex = 0;
            this.btn_emoloyee.Text = "Employee Details";
            this.btn_emoloyee.UseVisualStyleBackColor = true;
            this.btn_emoloyee.Click += new System.EventHandler(this.btn_emoloyee_Click);
            // 
            // btn_salary
            // 
            this.btn_salary.Location = new System.Drawing.Point(401, 83);
            this.btn_salary.Name = "btn_salary";
            this.btn_salary.Size = new System.Drawing.Size(128, 53);
            this.btn_salary.TabIndex = 1;
            this.btn_salary.Text = "Salary Calculate";
            this.btn_salary.UseVisualStyleBackColor = true;
            this.btn_salary.Click += new System.EventHandler(this.btn_salary_Click);
            // 
            // btn_settings
            // 
            this.btn_settings.Location = new System.Drawing.Point(401, 233);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(128, 53);
            this.btn_settings.TabIndex = 2;
            this.btn_settings.Text = "Settings";
            this.btn_settings.UseVisualStyleBackColor = true;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // btn_showSal
            // 
            this.btn_showSal.Location = new System.Drawing.Point(182, 234);
            this.btn_showSal.Name = "btn_showSal";
            this.btn_showSal.Size = new System.Drawing.Size(119, 52);
            this.btn_showSal.TabIndex = 4;
            this.btn_showSal.Text = "Show Salary";
            this.btn_showSal.UseVisualStyleBackColor = true;
            this.btn_showSal.Click += new System.EventHandler(this.btn_showSal_Click);
            // 
            // btn_signout
            // 
            this.btn_signout.ForeColor = System.Drawing.Color.Red;
            this.btn_signout.Location = new System.Drawing.Point(690, 365);
            this.btn_signout.Name = "btn_signout";
            this.btn_signout.Size = new System.Drawing.Size(75, 23);
            this.btn_signout.TabIndex = 5;
            this.btn_signout.Text = "Sign Out";
            this.btn_signout.UseVisualStyleBackColor = true;
            this.btn_signout.Click += new System.EventHandler(this.btn_signout_Click);
            // 
            // frm_dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_signout);
            this.Controls.Add(this.btn_showSal);
            this.Controls.Add(this.btn_settings);
            this.Controls.Add(this.btn_salary);
            this.Controls.Add(this.btn_emoloyee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_dashboard";
            this.Text = "Dashboard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_emoloyee;
        private System.Windows.Forms.Button btn_salary;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.Button btn_showSal;
        private System.Windows.Forms.Button btn_signout;
    }
}