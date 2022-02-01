using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopTestApp.Lecturer_Components;

namespace DesktopTestApp
{
    public partial class LecturerLogin : Form
    {
        public LecturerLogin()
        {
            InitializeComponent();
        }

        private void LinkNotMember_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LecturerRegister LecRegObj = new LecturerRegister();
            this.Controls.Add(LecRegObj);
            LecRegObj.BringToFront();

            txtNum.Text = "";
            txtPass.Text = "";
        }

        private void txtboxNum_OnValueChanged(object sender, EventArgs e)
        {
            txtNum.ForeColor = Color.LightBlue;
        }

        private void txtbxPass_OnValueChanged(object sender, EventArgs e)
        {
            if (chBxShowPass.Checked == false)
            {
                txtPass.isPassword = true;
            }
            txtPass.ForeColor = Color.LightBlue;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtNum.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("Please Input Fields!");
            }
            else
	        {
                if (DataBaseConn.TstFilObj.isLecturerExit(txtNum.Text))
                {
                    if (DataBaseConn.TstFilObj.isLecturerPassCorrect(txtPass.Text))
                    {
                        this.Visible = false;
                        Form LecMainObj = new LecturerMain();
                        LecMainObj.Show();
                    }
                    else
                    {
                        MessageBox.Show("Password Is Incorrect, Please Type Again!");
                    }
                }
                else
                {
                    MessageBox.Show("Lecturer Number '" + txtNum.Text + "' Doesn't Exist!, Try Creating An Account!");
                }
            }
        }

        private void chBxShowPass_OnChange(object sender, EventArgs e)
        {
            if (chBxShowPass.Checked == true)
            {
                txtPass.isPassword = false;
            }
            else
            {
                txtPass.isPassword = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
