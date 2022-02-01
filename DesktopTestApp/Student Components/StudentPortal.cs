using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopTestApp.Student_Components
{
    public partial class StudentPortal : UserControl
    {
        public StudentPortal()
        {
            InitializeComponent();
        }

        private void picBxStudPort_MouseEnter(object sender, EventArgs e)
        {
            picBxStudPort.Image = DesktopTestApp.Properties.Resources.StudentPtlChange;
            picBxStudPort.Cursor = Cursors.Hand;
        }

        private void picBxStudPort_MouseLeave(object sender, EventArgs e)
        {
            picBxStudPort.Image = DesktopTestApp.Properties.Resources.StudentPtlDefault;
            picBxStudPort.Cursor = Cursors.Default;
        }

        private void picBxStudPort_MouseDown(object sender, MouseEventArgs e)
        {
            picBxStudPort.Cursor = Cursors.Default;
        }
    }
}