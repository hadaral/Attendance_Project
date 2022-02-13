
namespace Attendance_form
{
    partial class employeeForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnWatch = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageProfile = new System.Windows.Forms.TabPage();
            this.tabPageReport = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageProfile.SuspendLayout();
            this.tabPageReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 634);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAbout);
            this.panel2.Controls.Add(this.btnWatch);
            this.panel2.Controls.Add(this.btnReport);
            this.panel2.Controls.Add(this.btnProfile);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(244, 634);
            this.panel2.TabIndex = 4;
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAbout.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnAbout.Location = new System.Drawing.Point(0, 341);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(244, 60);
            this.btnAbout.TabIndex = 7;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = false;
            // 
            // btnWatch
            // 
            this.btnWatch.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnWatch.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnWatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWatch.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnWatch.Location = new System.Drawing.Point(0, 274);
            this.btnWatch.Name = "btnWatch";
            this.btnWatch.Size = new System.Drawing.Size(244, 60);
            this.btnWatch.TabIndex = 6;
            this.btnWatch.Text = "Watch hours";
            this.btnWatch.UseVisualStyleBackColor = false;
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnReport.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnReport.Location = new System.Drawing.Point(0, 207);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(244, 60);
            this.btnReport.TabIndex = 5;
            this.btnReport.Text = "Report Hours";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnProfile.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.Location = new System.Drawing.Point(0, 140);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(244, 60);
            this.btnProfile.TabIndex = 4;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tabPageProfile);
            this.tabControl1.Controls.Add(this.tabPageReport);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControl1.Location = new System.Drawing.Point(244, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(721, 634);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageProfile
            // 
            this.tabPageProfile.Controls.Add(this.label6);
            this.tabPageProfile.Controls.Add(this.label7);
            this.tabPageProfile.Controls.Add(this.label8);
            this.tabPageProfile.Controls.Add(this.label9);
            this.tabPageProfile.Controls.Add(this.label5);
            this.tabPageProfile.Controls.Add(this.label4);
            this.tabPageProfile.Controls.Add(this.label3);
            this.tabPageProfile.Controls.Add(this.label2);
            this.tabPageProfile.Controls.Add(this.label1);
            this.tabPageProfile.Location = new System.Drawing.Point(4, 5);
            this.tabPageProfile.Name = "tabPageProfile";
            this.tabPageProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProfile.Size = new System.Drawing.Size(713, 625);
            this.tabPageProfile.TabIndex = 0;
            this.tabPageProfile.Text = "tabPage1";
            this.tabPageProfile.UseVisualStyleBackColor = true;
            this.tabPageProfile.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPageReport
            // 
            this.tabPageReport.Controls.Add(this.monthCalendar1);
            this.tabPageReport.Location = new System.Drawing.Point(4, 5);
            this.tabPageReport.Name = "tabPageReport";
            this.tabPageReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReport.Size = new System.Drawing.Size(713, 625);
            this.tabPageReport.TabIndex = 1;
            this.tabPageReport.Text = "tabPage2";
            this.tabPageReport.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(25, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Profile";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ink Free", 13F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(163, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Full Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ink Free", 13F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(209, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ink Free", 13F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(150, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Birth Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ink Free", 13F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(74, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 27);
            this.label5.TabIndex = 3;
            this.label5.Text = "Seniority(Months):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Ink Free", 13F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(296, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 27);
            this.label6.TabIndex = 6;
            this.label6.Text = "seniority";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Ink Free", 13F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(294, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 27);
            this.label7.TabIndex = 7;
            this.label7.Text = "birth date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Ink Free", 13F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(294, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 27);
            this.label8.TabIndex = 5;
            this.label8.Text = "email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Ink Free", 13F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(294, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 27);
            this.label9.TabIndex = 4;
            this.label9.Text = "full name";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.AccessibleRole = System.Windows.Forms.AccessibleRole.List;
            this.monthCalendar1.Location = new System.Drawing.Point(213, 9);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // employeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 634);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "employeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "employeeForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageProfile.ResumeLayout(false);
            this.tabPageProfile.PerformLayout();
            this.tabPageReport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnWatch;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageProfile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageReport;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}