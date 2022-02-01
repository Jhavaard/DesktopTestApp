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
    public partial class TestContentMenu : UserControl
    {
        public static string LectNum;
        private string testName, selTestContent;
        public static Boolean isSelect = false;

        public TestContentMenu(String SetBy, String TestName, String NumQuestions, String TotalMarks, String DateCreated)
        {
            InitializeComponent();
            lblLectName.Text = "Set By: " + SetBy;
            lblTestName.Text = "Test Name: " + TestName;
            lblNumQues.Text = "No. Questions: " + NumQuestions;
            lblMarks.Text = "Total Marks: "+TotalMarks;
            lblDateCreated.Text = "Created: " + DateCreated;
        }

        private void pnMenu_MouseClick(object sender, MouseEventArgs e)
        {
            SelectTestTab.SelTstTabObj.setDefaultColor();
            pnMenu.BackColor = Color.DarkGreen;
            // Set Test Selected To True
            isSelect = true;
            /// Get Lecture Who Set The Test
            LectNum = this.Name.Split('#')[0];
            // Get The Test Name
            testName = this.Name.Split('#')[2];
            // Set Selected Test Content
            selTestContent = testName + "#" + this.Name.Split('#')[3] + "#" + this.Name.Split('#')[4];
            /// Set Student Test Path
            DataBaseConn.TstFilObj.setStudTestID(LectNum, testName, selTestContent);
        }

//------------------------- Mouse Click End -------------------------------------------------------

        private void pnMenu_MouseEnter(object sender, EventArgs e)
        {
            pnMenu.Cursor = Cursors.Hand;
        }

        private void pnMenu_MouseLeave(object sender, EventArgs e)
        {
            pnMenu.Cursor = Cursors.Default;
        }

//--------------------------------- Color Change End ----------------------------------------------
      
    }
}
