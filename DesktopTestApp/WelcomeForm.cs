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
using DesktopTestApp.Student_Components;

namespace DesktopTestApp
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();

            DataBaseConn TFC = new DataBaseConn();
            lecturerPortalMenu.picBxLecPort.MouseClick += PicBxLecPort_MouseClick;
            studentPortalMenu.picBxStudPort.MouseClick += PicBxStudPort_MouseClick;
        }

        private void PicBxStudPort_MouseClick(object sender, MouseEventArgs e)
        {
            this.Visible = false;
            Form StuLogin = new StudentLogin();
            StuLogin.Show();
        }

        private void PicBxLecPort_MouseClick(object sender, MouseEventArgs e)
        {
            this.Visible = false;
            Form LectLogin = new LecturerLogin();
            LectLogin.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult getChoice = MessageBox.Show("Are You Sure You Want To Exit Application?", "Warning Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (getChoice == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
