using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopTestApp
{

    public partial class StudentLogin : Form
    {
        public StudentLogin()
        {
            InitializeComponent();
            menuOptions.Renderer = new ToolStripProfessionalRenderer(new TestColorTable());
        }

        public class TestColorTable : ProfessionalColorTable
        {
            public override Color MenuBorder
            {
                get { return Color.FromArgb(33, 39, 50); }
            }

            public override Color MenuItemSelected
            {
                get { return Color.FromArgb(27, 32, 41); }
            }

            public override Color MenuItemSelectedGradientBegin
            {
                get { return Color.FromArgb(33, 39, 50); }
            }

            public override Color MenuItemSelectedGradientEnd
            {
                get { return Color.FromArgb(33, 39, 50); }
            }

            public override Color MenuItemPressedGradientBegin
            {
                get { return Color.FromArgb(33, 39, 50); }
            }

            public override Color MenuItemPressedGradientEnd
            {
                get { return Color.FromArgb(33, 39, 50); }
            }
        }

        private void txtStudPass_OnValueChanged(object sender, EventArgs e)
        {
            if (!cbxShowLogPass.Checked)
            {
                txtStudLogPass.isPassword = true;
            }
        }

        private void cbxShowLogPass_OnChange(object sender, EventArgs e)
        {
            if (cbxShowLogPass.Checked)
            {
                txtStudLogPass.isPassword = false;
            }
            else
            {
                if (!string.IsNullOrEmpty(txtStudLogPass.Text))
                {
                    txtStudLogPass.isPassword = true;
                }
            }
        }

        private void lblStudRegister_MouseEnter(object sender, EventArgs e)
        {
            lblStudRegister.ForeColor = Color.FromArgb(0, 190, 0);
            lblStudRegister.Cursor = Cursors.Hand;
        }

        private void lblStudRegister_MouseLeave(object sender, EventArgs e)
        {
            lblStudRegister.ForeColor = Color.Lime;
            lblStudRegister.Cursor = Cursors.Default;
        }

        private void lblStudRegister_Click(object sender, EventArgs e)
        {
            pnRegistration.Visible = true;
        }

        private void lblCancel_MouseEnter(object sender, EventArgs e)
        {
            lblCancel.ForeColor = Color.FromArgb(0, 190, 0);
            lblCancel.Cursor = Cursors.Hand;
        }

        private void lblCancel_MouseLeave(object sender, EventArgs e)
        {
            lblCancel.ForeColor = Color.Lime;
            lblCancel.Cursor = Cursors.Default;
        }

        private void lblCancel_Click(object sender, EventArgs e)
        {
            pnRegistration.Visible = false;
        }

        private void txtStudRegPass_OnValueChanged(object sender, EventArgs e)
        {
            if (!cbxShowRegPass.Checked)
            {
                txtStudRegPass.isPassword = true;
            }
        }

        private void txtStudRegRePass_OnValueChanged(object sender, EventArgs e)
        {
            if (!cbxShowRegPass.Checked)
            {
                txtStudRegRePass.isPassword = true;
            }
        }

        private void cbxShowRegPass_OnChange(object sender, EventArgs e)
        {
            if (cbxShowRegPass.Checked)
            {
                txtStudRegPass.isPassword = false;
                txtStudRegRePass.isPassword = false;
            }
            else
            {
                if (!(string.IsNullOrEmpty(txtStudRegPass.Text) || (string.IsNullOrEmpty(txtStudRegPass.Text))))
                {
                    txtStudRegPass.isPassword = true;
                    txtStudRegRePass.isPassword = true;
                }
            }
        }

        private void picExitApp_Click(object sender, EventArgs e)
        {
            DialogResult getChoice =  MessageBox.Show("Are You Sure You Want To Exit Application?", "Warning Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (getChoice == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnStudLogin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtStudLogNumber.Text) || String.IsNullOrEmpty(txtStudLogPass.Text))
            {
                MessageBox.Show("Fields Can't Be Empty!", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (DataBaseConn.TstFilObj.isStudentExist(txtStudLogNumber.Text))
                {
                    if (DataBaseConn.TstFilObj.isStudentPassCorrect(txtStudLogPass.Text))
                    {
                        this.Visible = false;
                        StudentMain StudMnObj = new StudentMain(DataBaseConn.TstFilObj.getStudFName() + " " + DataBaseConn.TstFilObj.getStudSName());
                        StudMnObj.Show();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Password Entered. Try Again!", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("The Student Account '" + txtStudLogNumber.Text + "' Does Not Exist. Try Registering For An Account Instead!", "Invalid Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnStudRegister_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtStudRegNumber.Text) || String.IsNullOrEmpty(txtStudRegFName.Text) || String.IsNullOrEmpty(txtStudRegSName.Text) || String.IsNullOrEmpty(txtStudRegPass.Text) || String.IsNullOrEmpty(txtStudRegRePass.Text))
            {
                MessageBox.Show("Fields Can't Be Empty!", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (txtStudRegPass.Text == txtStudRegRePass.Text)
                {
                    String dateNow = DateTime.Now.ToString("dddd, dd MMMM yyyy hh:mm:ss tt");
                    DataBaseConn.TstFilObj.RegisterStudent(txtStudRegNumber.Text, txtStudRegFName.Text, txtStudRegSName.Text,
                                                           txtStudRegPass.Text, dateNow);

                    pnRegistration.Visible = false;
                }
                else
                {
                    MessageBox.Show("Passwords Entered Don't Match!", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void MnItemExitApp_Click(object sender, EventArgs e)
        {
            DialogResult getChoice = MessageBox.Show("Are You Sure You Want To Exit Application?", "Warning Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (getChoice == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void MnItemGoBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            WelcomeForm WelFrmObj = new WelcomeForm();
            WelFrmObj.Show();
        }

        private void MnItemLectLogin_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            LecturerLogin LectLogObj = new LecturerLogin();
            LectLogObj.Show();
        }
    }
}
