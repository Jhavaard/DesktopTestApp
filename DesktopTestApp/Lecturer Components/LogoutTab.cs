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
    public partial class LogoutTab : UserControl
    {

        public LogoutTab()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LecturerMain.LecMainObj.Visible = false;
            WelcomeForm WelObj = new WelcomeForm();
            WelObj.Show();
        }
    }
}
