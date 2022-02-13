
namespace Attendance_form
{
    partial class MainForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.loginAsEmployee = new System.Windows.Forms.Label();
            this.btnSignInManager = new Attendance_form.controls._roundedButton();
            this._loginTextBox2 = new Attendance_form.controls._loginTextBox();
            this._loginTextBox1 = new Attendance_form.controls._loginTextBox();
            this.btnSignInEmployee = new Attendance_form.controls._roundedButton();
            this._loginTextBox4 = new Attendance_form.controls._loginTextBox();
            this._loginTextBox3 = new Attendance_form.controls._loginTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(965, 634);
            this.splitContainer1.SplitterDistance = 483;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.btnSignInManager);
            this.panel2.Controls.Add(this._loginTextBox2);
            this.panel2.Controls.Add(this._loginTextBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(483, 634);
            this.panel2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(20, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(20, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "User ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(66, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "Login As Manager";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.btnSignInEmployee);
            this.panel1.Controls.Add(this._loginTextBox4);
            this.panel1.Controls.Add(this._loginTextBox3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.loginAsEmployee);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(478, 634);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(20, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(20, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "User ID";
            // 
            // loginAsEmployee
            // 
            this.loginAsEmployee.AutoSize = true;
            this.loginAsEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.loginAsEmployee.Location = new System.Drawing.Point(66, 26);
            this.loginAsEmployee.Name = "loginAsEmployee";
            this.loginAsEmployee.Size = new System.Drawing.Size(221, 29);
            this.loginAsEmployee.TabIndex = 0;
            this.loginAsEmployee.Text = "Login As Employee";
            // 
            // btnSignInManager
            // 
            this.btnSignInManager.BackColor = System.Drawing.Color.Tomato;
            this.btnSignInManager.BackgroundColor = System.Drawing.Color.Tomato;
            this.btnSignInManager.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSignInManager.BorderRadius = 33;
            this.btnSignInManager.BorderSize = 0;
            this.btnSignInManager.FlatAppearance.BorderSize = 0;
            this.btnSignInManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignInManager.ForeColor = System.Drawing.Color.White;
            this.btnSignInManager.Location = new System.Drawing.Point(106, 332);
            this.btnSignInManager.Name = "btnSignInManager";
            this.btnSignInManager.Size = new System.Drawing.Size(162, 46);
            this.btnSignInManager.TabIndex = 5;
            this.btnSignInManager.Text = "Sign In";
            this.btnSignInManager.TextColor = System.Drawing.Color.White;
            this.btnSignInManager.UseVisualStyleBackColor = false;
            // 
            // _loginTextBox2
            // 
            this._loginTextBox2.BackColor = System.Drawing.SystemColors.HotTrack;
            this._loginTextBox2.BorderColor = System.Drawing.Color.Tomato;
            this._loginTextBox2.BorderSize = 2;
            this._loginTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this._loginTextBox2.Location = new System.Drawing.Point(129, 189);
            this._loginTextBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._loginTextBox2.Multiline = false;
            this._loginTextBox2.Name = "_loginTextBox2";
            this._loginTextBox2.Padding = new System.Windows.Forms.Padding(7);
            this._loginTextBox2.PasswordChar = true;
            this._loginTextBox2.Size = new System.Drawing.Size(216, 35);
            this._loginTextBox2.TabIndex = 4;
            this._loginTextBox2.UnderLinedStyle = true;
            // 
            // _loginTextBox1
            // 
            this._loginTextBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this._loginTextBox1.BorderColor = System.Drawing.Color.Tomato;
            this._loginTextBox1.BorderSize = 2;
            this._loginTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this._loginTextBox1.Location = new System.Drawing.Point(129, 130);
            this._loginTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._loginTextBox1.Multiline = false;
            this._loginTextBox1.Name = "_loginTextBox1";
            this._loginTextBox1.Padding = new System.Windows.Forms.Padding(7);
            this._loginTextBox1.PasswordChar = true;
            this._loginTextBox1.Size = new System.Drawing.Size(216, 35);
            this._loginTextBox1.TabIndex = 4;
            this._loginTextBox1.UnderLinedStyle = true;
            // 
            // btnSignInEmployee
            // 
            this.btnSignInEmployee.BackColor = System.Drawing.Color.Tomato;
            this.btnSignInEmployee.BackgroundColor = System.Drawing.Color.Tomato;
            this.btnSignInEmployee.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSignInEmployee.BorderRadius = 33;
            this.btnSignInEmployee.BorderSize = 0;
            this.btnSignInEmployee.FlatAppearance.BorderSize = 0;
            this.btnSignInEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignInEmployee.ForeColor = System.Drawing.Color.White;
            this.btnSignInEmployee.Location = new System.Drawing.Point(110, 332);
            this.btnSignInEmployee.Name = "btnSignInEmployee";
            this.btnSignInEmployee.Size = new System.Drawing.Size(162, 46);
            this.btnSignInEmployee.TabIndex = 5;
            this.btnSignInEmployee.Text = "Sign In";
            this.btnSignInEmployee.TextColor = System.Drawing.Color.White;
            this.btnSignInEmployee.UseVisualStyleBackColor = false;
            this.btnSignInEmployee.Click += new System.EventHandler(this.btnSignInEmployee_Click);
            // 
            // _loginTextBox4
            // 
            this._loginTextBox4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this._loginTextBox4.BorderColor = System.Drawing.Color.Tomato;
            this._loginTextBox4.BorderSize = 2;
            this._loginTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this._loginTextBox4.Location = new System.Drawing.Point(126, 192);
            this._loginTextBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._loginTextBox4.Multiline = false;
            this._loginTextBox4.Name = "_loginTextBox4";
            this._loginTextBox4.Padding = new System.Windows.Forms.Padding(7);
            this._loginTextBox4.PasswordChar = true;
            this._loginTextBox4.Size = new System.Drawing.Size(216, 35);
            this._loginTextBox4.TabIndex = 4;
            this._loginTextBox4.UnderLinedStyle = true;
            // 
            // _loginTextBox3
            // 
            this._loginTextBox3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this._loginTextBox3.BorderColor = System.Drawing.Color.Tomato;
            this._loginTextBox3.BorderSize = 2;
            this._loginTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this._loginTextBox3.Location = new System.Drawing.Point(126, 133);
            this._loginTextBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._loginTextBox3.Multiline = false;
            this._loginTextBox3.Name = "_loginTextBox3";
            this._loginTextBox3.Padding = new System.Windows.Forms.Padding(7);
            this._loginTextBox3.PasswordChar = true;
            this._loginTextBox3.Size = new System.Drawing.Size(216, 35);
            this._loginTextBox3.TabIndex = 4;
            this._loginTextBox3.UnderLinedStyle = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 634);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label loginAsEmployee;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private controls._loginTextBox _loginTextBox1;
        private controls._loginTextBox _loginTextBox2;
        private controls._loginTextBox _loginTextBox4;
        private controls._loginTextBox _loginTextBox3;
        private controls._roundedButton btnSignInManager;
        private controls._roundedButton btnSignInEmployee;
    }
}

