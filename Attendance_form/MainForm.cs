using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_form
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSignInEmployee_Click(object sender, EventArgs e)
        {
            employeeForm employee_form = new employeeForm();
            employee_form.ShowDialog();
        }
    }
}
