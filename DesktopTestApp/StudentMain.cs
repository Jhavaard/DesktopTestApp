using DesktopTestApp.Student_Components;
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
    public partial class StudentMain : Form
    {
        public static StudentMain StudMnObj;

        public StudentMain(String StudName)
        {
            InitializeComponent();
            StudMnObj = this;//Creating An Object Of This Class

            btnDispStudName.Text = " "+StudName;
        }

        public void disposeForm()
        {
            this.Dispose();
        }

        private void btnTakeTest_Click(object sender, EventArgs e)
        {
            SelectTestTab takeTstTbObj = new SelectTestTab();
            String[][] testContentArr = DataBaseConn.TstFilObj.getStudTestsContent();

            foreach (String[] content in testContentArr)
            {
                takeTstTbObj.AddTestContentMenu(content[0], content[1], content[2], content[3], content[4], content[5]);
            }

            this.Controls.Add(takeTstTbObj);
            takeTstTbObj.BringToFront();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            WelcomeForm WelFrmObj = new WelcomeForm();
            WelFrmObj.Show();
        }

        private void btnMyResults_Click(object sender, EventArgs e)
        {
            StudentResultsTab StudResTb = new StudentResultsTab();
            this.Controls.Add(StudResTb);
            StudResTb.populateListView();
            StudResTb.BringToFront();
        }

        private void btnMyAccount_Click(object sender, EventArgs e)
        {
            StudentAccountTab StudAccTb = new StudentAccountTab();
            this.Controls.Add(StudAccTb);
            StudAccTb.BringToFront();
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            DataBaseConn.TstFilObj.deleteStudAcc();
        }

        private void pbxClose_Click(object sender, EventArgs e)
        {
            DialogResult getChoice = MessageBox.Show("Are You Sure You Want To Exit Application?", "Warning Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (getChoice == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
