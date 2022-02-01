using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopTestApp.Lecturer_Components.Test_Viewer_Components
{
    public partial class TestName : UserControl
    {
        //Global Variable
        public static string getTestName;// Gets the name of the selected test

        public TestName(String Testname, int NumQues, String testCreated)
        {
            InitializeComponent();
            lblTstName.Text = Testname;// sets the name of the test
            chkBxTestSel.Text = Testname;// used as an ID to identify the selected checkBox

            lblQues.Text = NumQues+" Question(s)";
            lblDate.Text = testCreated;
        }

        private void chkBxTestSel_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBxTestSel.Checked == true)
            {
                this.BackColor = Color.FromArgb(215, 228, 242);
                ListTestTab.LTstobj.checkSelection(lblTstName.Text);
                // calls the method to disable all other checkBoxes
                getTestName = chkBxTestSel.Text;
                ListTestTab.LTstobj.setSelectedTest(getTestName);
            }
            else
            {
                this.BackColor = Color.FromArgb(240,240,240);
                getTestName = "";
            }
        }

        private void TestName_MouseEnter(object sender, EventArgs e)
        {
            changeColorEnter();
        }

        private void TestName_MouseLeave(object sender, EventArgs e)
        {
            changeColorLeave();
        }

        private void lblTstName_MouseEnter(object sender, EventArgs e)
        {
            changeColorEnter();
        }

        private void lblTstName_MouseLeave(object sender, EventArgs e)
        {
            changeColorLeave();
        }

        private void lblQues_MouseEnter(object sender, EventArgs e)
        {
            changeColorEnter();
        }

        private void lblQues_MouseLeave(object sender, EventArgs e)
        {
            changeColorLeave();
        }

        private void lblDate_MouseEnter(object sender, EventArgs e)
        {
            changeColorEnter();
        }

        private void lblDate_MouseLeave(object sender, EventArgs e)
        {
            changeColorLeave();
        }

        public void changeColorEnter()
        {
            
            if (this.BackColor != Color.FromArgb(215, 228, 242))
            {
                this.BackColor = Color.FromArgb(227, 227, 227);
            }
            else
            {
                this.BackColor = Color.FromArgb(215, 228, 242);
            }
        }

        public void changeColorLeave()
        {
            if (this.BackColor != Color.FromArgb(215, 228, 242))
            {
                this.BackColor = Color.FromArgb(240, 240, 240);
            }
            else
            {
                this.BackColor = Color.FromArgb(215, 228, 242);
            }
        }
    }
}
