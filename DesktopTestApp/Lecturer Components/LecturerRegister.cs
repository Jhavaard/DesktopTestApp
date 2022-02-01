using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopTestApp.Lecturer_Components
{
    public partial class LecturerRegister : UserControl
    {
        public LecturerRegister()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtPass_OnValueChanged(object sender, EventArgs e)
        {
            if (chBxShowPass.Checked == false)
            {
                txtPass.isPassword = true;
            }
        }

        private void txtRePass_OnValueChanged(object sender, EventArgs e)
        {
            if (chBxShowPass.Checked == false)
            {
                txtRePass.isPassword = true;
            }
        }

        private void chBxShowPass_OnChange(object sender, EventArgs e)
        {
            if (chBxShowPass.Checked == true)
            {
                txtPass.isPassword = false;
                txtRePass.isPassword = false;
            }
            else
            {
                txtPass.isPassword = true;
                txtRePass.isPassword = true;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!DataBaseConn.TstFilObj.isLecturerExit(txtNum.Text))
            {
                if (txtPass.Text == txtRePass.Text)
                {
                    String LoggedDate =  DateTime.Now.ToString("dddd, dd MMMM yyyy h:mm:ss tt");

                    DataBaseConn.TstFilObj.RegisterLecturer(txtNum.Text, txtName.Text, txtEmail.Text, txtPass.Text, LoggedDate);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Passwords Don't Match!");
                }
            }
            else
            {
                MessageBox.Show("Lecturer Number Already Exist! Try Logging In!");
            }
        }
    }
}
