
namespace Grifindo_toy
{
    partial class frm_settings
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
            this.dtp_startD = new System.Windows.Forms.DateTimePicker();
            this.dtp_endD = new System.Windows.Forms.DateTimePicker();
            this.dtp_month = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.txt_stID = new System.Windows.Forms.TextBox();
            this.txt_cyDays = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_anLeav = new System.Windows.Forms.TextBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.dgv_settings = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_settings)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_startD
            // 
            this.dtp_startD.CustomFormat = "dd-MMM-yyyy";
            this.dtp_startD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_startD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_startD.Location = new System.Drawing.Point(427, 292);
            this.dtp_startD.Name = "dtp_startD";
            this.dtp_startD.Size = new System.Drawing.Size(225, 26);
            this.dtp_startD.TabIndex = 28;
            this.dtp_startD.Value = new System.DateTime(2024, 2, 2, 0, 0, 0, 0);
            // 
            // dtp_endD
            // 
            this.dtp_endD.CustomFormat = "dd-MMM-yyyy";
            this.dtp_endD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_endD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_endD.Location = new System.Drawing.Point(427, 368);
            this.dtp_endD.Name = "dtp_endD";
            this.dtp_endD.Size = new System.Drawing.Size(225, 26);
            this.dtp_endD.TabIndex = 28;
            this.dtp_endD.Value = new System.DateTime(2024, 2, 2, 0, 0, 0, 0);
            // 
            // dtp_month
            // 
            this.dtp_month.CustomFormat = "MMMM";
            this.dtp_month.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_month.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_month.Location = new System.Drawing.Point(427, 160);
            this.dtp_month.Name = "dtp_month";
            this.dtp_month.Size = new System.Drawing.Size(225, 26);
            this.dtp_month.TabIndex = 29;
            this.dtp_month.Value = new System.DateTime(2024, 2, 2, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(74, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "Setting ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(74, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Salary Month";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(74, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Salary Cycle Start Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Salary Cycle Days";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Salary Cycle End Date";
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(292, 528);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(184, 50);
            this.btn_update.TabIndex = 35;
            this.btn_update.Text = "Update Settings";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // txt_stID
            // 
            this.txt_stID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_stID.Location = new System.Drawing.Point(427, 76);
            this.txt_stID.Name = "txt_stID";
            this.txt_stID.ReadOnly = true;
            this.txt_stID.Size = new System.Drawing.Size(225, 29);
            this.txt_stID.TabIndex = 40;
            this.txt_stID.Text = "1";
            // 
            // txt_cyDays
            // 
            this.txt_cyDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cyDays.Location = new System.Drawing.Point(427, 219);
            this.txt_cyDays.Name = "txt_cyDays";
            this.txt_cyDays.Size = new System.Drawing.Size(225, 29);
            this.txt_cyDays.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(74, 454);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Annual Leave Days";
            // 
            // txt_anLeav
            // 
            this.txt_anLeav.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_anLeav.Location = new System.Drawing.Point(427, 445);
            this.txt_anLeav.Name = "txt_anLeav";
            this.txt_anLeav.Size = new System.Drawing.Size(225, 29);
            this.txt_anLeav.TabIndex = 41;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(1046, 587);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(79, 28);
            this.btn_back.TabIndex = 43;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // dgv_settings
            // 
            this.dgv_settings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_settings.Location = new System.Drawing.Point(718, 113);
            this.dgv_settings.Name = "dgv_settings";
            this.dgv_settings.Size = new System.Drawing.Size(436, 310);
            this.dgv_settings.TabIndex = 44;
            // 
            // frm_settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(1208, 655);
            this.Controls.Add(this.dgv_settings);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.txt_stID);
            this.Controls.Add(this.txt_anLeav);
            this.Controls.Add(this.txt_cyDays);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_month);
            this.Controls.Add(this.dtp_endD);
            this.Controls.Add(this.dtp_startD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.frm_settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_settings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_startD;
        private System.Windows.Forms.DateTimePicker dtp_endD;
        private System.Windows.Forms.DateTimePicker dtp_month;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.TextBox txt_stID;
        private System.Windows.Forms.TextBox txt_cyDays;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_anLeav;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.DataGridView dgv_settings;
    }
}