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
    public partial class MyAccountTab : UserControl
    {
        public MyAccountTab()
        {
            InitializeComponent();
        }

        public void setLectAccount()
        {
            //Personal
            txtID.Text = DataBaseConn.TstFilObj.getLectNum();
            txtName.Text = DataBaseConn.TstFilObj.getLectName();
            txtEmail.Text = DataBaseConn.TstFilObj.getLectEmail();
            txtPass.Text = DataBaseConn.TstFilObj.getLectPass();

            //General
            String[] getLectTests = DataBaseConn.TstFilObj.getCreatedLectTests();

            txtLoginDate.Text = DataBaseConn.TstFilObj.getLectLstLogDate();
            txtNumTst.Text = getLectTests.Length + " Tests Created By You";
            CbBxTests.Items.AddRange(getLectTests);

            if (getLectTests.Length > 0)
            {
                CbBxTests.SelectedItem = getLectTests[0];
            }
        }

        private void btnEdSav_Click(object sender, EventArgs e)
        {
            if (btnEdSav.ButtonText == "Edit")
            {
                txtName.BorderColorIdle = Color.Red;
                txtEmail.BorderColorIdle = Color.Red;
                txtPass.BorderColorIdle = Color.Red;

                txtName.BorderColorMouseHover = Color.Red;
                txtEmail.BorderColorMouseHover = Color.Red;
                txtPass.BorderColorMouseHover = Color.Red;

                txtName.Enabled = true;
                txtEmail.Enabled = true;
                txtPass.Enabled = true;

                btnEdSav.ButtonText = "Save";
            }
            else
            {
                txtName.BorderColorIdle = Color.FromArgb(64, 64, 64);
                txtEmail.BorderColorIdle = Color.FromArgb(64, 64, 64);
                txtPass.BorderColorIdle = Color.FromArgb(64, 64, 64);

                txtName.BorderColorMouseHover = Color.Blue;
                txtEmail.BorderColorMouseHover = Color.Blue;
                txtPass.BorderColorMouseHover = Color.Blue;

                txtName.Enabled = false;
                txtEmail.Enabled = false;
                txtPass.Enabled = false;

                DataBaseConn.TstFilObj.AlterLectAccount(txtName.Text, txtEmail.Text, txtPass.Text);
                lbFocus.Focus();

                btnEdSav.ButtonText = "Edit";
            }
            
        }

        private void btnDelAcc_Click(object sender, EventArgs e)
        {
            DataBaseConn.TstFilObj.deleteLectAcc();
            MessageBox.Show("Successfully Deleted Lecturer Account '" + txtID.Text + "'");

            LecturerMain.LecMainObj.Visible = false;
            WelcomeForm WelObj = new WelcomeForm();
            WelObj.Show();
        }
    }
}
