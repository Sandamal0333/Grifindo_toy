
namespace Grifindo_toy
{
    partial class frm_show_salary
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
            this.btn_back = new System.Windows.Forms.Button();
            this.txt_slID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_empID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_salIdSearch = new System.Windows.Forms.Button();
            this.dgv_salary = new System.Windows.Forms.DataGridView();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_empIdSarch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_salary)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(623, 428);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(94, 30);
            this.btn_back.TabIndex = 58;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // txt_slID
            // 
            this.txt_slID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_slID.Location = new System.Drawing.Point(287, 35);
            this.txt_slID.Name = "txt_slID";
            this.txt_slID.Size = new System.Drawing.Size(225, 22);
            this.txt_slID.TabIndex = 62;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(52, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 61;
            this.label7.Text = "Salary Id";
            // 
            // txt_empID
            // 
            this.txt_empID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_empID.Location = new System.Drawing.Point(287, 95);
            this.txt_empID.Name = "txt_empID";
            this.txt_empID.Size = new System.Drawing.Size(225, 22);
            this.txt_empID.TabIndex = 60;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(52, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 16);
            this.label6.TabIndex = 59;
            this.label6.Text = "Empolyee ID";
            // 
            // btn_salIdSearch
            // 
            this.btn_salIdSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salIdSearch.Location = new System.Drawing.Point(528, 33);
            this.btn_salIdSearch.Name = "btn_salIdSearch";
            this.btn_salIdSearch.Size = new System.Drawing.Size(189, 31);
            this.btn_salIdSearch.TabIndex = 58;
            this.btn_salIdSearch.Text = "Search With Salary Id";
            this.btn_salIdSearch.UseVisualStyleBackColor = true;
            this.btn_salIdSearch.Click += new System.EventHandler(this.btn_salIdSearch_Click);
            // 
            // dgv_salary
            // 
            this.dgv_salary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_salary.Location = new System.Drawing.Point(55, 143);
            this.dgv_salary.Name = "dgv_salary";
            this.dgv_salary.Size = new System.Drawing.Size(696, 235);
            this.dgv_salary.TabIndex = 63;
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(463, 428);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(94, 30);
            this.btn_clear.TabIndex = 58;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_empIdSarch
            // 
            this.btn_empIdSarch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_empIdSarch.Location = new System.Drawing.Point(528, 93);
            this.btn_empIdSarch.Name = "btn_empIdSarch";
            this.btn_empIdSarch.Size = new System.Drawing.Size(189, 31);
            this.btn_empIdSarch.TabIndex = 58;
            this.btn_empIdSarch.Text = "Search With Employee Id";
            this.btn_empIdSarch.UseVisualStyleBackColor = true;
            this.btn_empIdSarch.Click += new System.EventHandler(this.btn_empIdSarch_Click);
            // 
            // frm_show_salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(800, 498);
            this.Controls.Add(this.dgv_salary);
            this.Controls.Add(this.txt_slID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_empID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_empIdSarch);
            this.Controls.Add(this.btn_salIdSearch);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_show_salary";
            this.Text = "Show Salaries";
            this.Load += new System.EventHandler(this.frm_show_salary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_salary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.TextBox txt_slID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_empID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_salIdSearch;
        private System.Windows.Forms.DataGridView dgv_salary;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_empIdSarch;
    }
}