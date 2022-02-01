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
    public partial class LecturerPortal : UserControl
    {
        public LecturerPortal()
        {
            InitializeComponent();
        }

        private void picBxLecPort_MouseEnter(object sender, EventArgs e)
        {
            picBxLecPort.Image = DesktopTestApp.Properties.Resources.LecturerPtlChange;
            picBxLecPort.Cursor = Cursors.Hand;
        }

        private void picBxLecPort_MouseLeave(object sender, EventArgs e)
        {
            picBxLecPort.Image = DesktopTestApp.Properties.Resources.LecturerPtlDefault;
            picBxLecPort.Cursor = Cursors.Default;
        }

        private void picBxLecPort_MouseDown(object sender, MouseEventArgs e)
        {
            picBxLecPort.Cursor = Cursors.Default;
        }
    }
}
