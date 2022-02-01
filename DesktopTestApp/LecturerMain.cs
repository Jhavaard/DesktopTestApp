using System;
using System.Drawing;
using System.Windows.Forms;
using DesktopTestApp.Lecturer_Components;

namespace DesktopTestApp
{
    public partial class LecturerMain : Form
    {
        public static LecturerMain LecMainObj;// Creates Another Instance Of Lecture Main

        public LecturerMain()
        {
            InitializeComponent();
            FirstTab();
            LecMainObj = this;/// Sets The Same Instance To LecMainObj

            lblLectName.Text = DataBaseConn.TstFilObj.getLectName();// Sets Lecturer Name
        }

        public void FirstTab()
        {
            pnUsing.Height = btnTestEditor.Height - 1;
            pnUsing.Top = btnTestEditor.Top;
            labTitle.Text = "Add A Test To The Database";
          
            setDefaults();

            labTitle.BackColor = Color.Gainsboro;
            labTitle.ForeColor = Color.Black;

            btnTestEditor.Normalcolor = Color.DodgerBlue;
            btnTestEditor.OnHovercolor = Color.DodgerBlue;
            btnTestEditor.Activecolor = Color.DodgerBlue;
            
            addTestTab1.addAllLectTests();/// Adds ALL Lecturer Tests To Form // Issue Obj Not Disposed
            addTestTab1.BringToFront();
        }

        public void setSelectedTest(String Display)
        {
            labTitle.Text = Display;
        }

        private void btnTestEditor_Click(object sender, EventArgs e)
        {
            FirstTab();
        }

        private void btnTstVwr_Click(object sender, EventArgs e)
        {
            pnUsing.Height = btnTstVwr.Height - 1;
            pnUsing.Top = btnTstVwr.Top;
            labTitle.Text = "Select A Test An View Its Content";
            setDefaults();

            labTitle.BackColor = Color.Gainsboro;
            labTitle.ForeColor = Color.Black;

            btnTstVwr.Normalcolor = Color.DodgerBlue;
            btnTstVwr.OnHovercolor = Color.DodgerBlue;
            btnTstVwr.Activecolor = Color.DodgerBlue;

            listTestTab1.addAllLectTests();/// Adds ALL Lecturer Tests To Form // Issue Obj Not Disposed
            listTestTab1.BringToFront();
        }

        private void btnTstDb_Click(object sender, EventArgs e)
        {
            pnUsing.Height = btnTstDb.Height - 1;
            pnUsing.Top = btnTstDb.Top;
            labTitle.Text = "View All Created Test";
            setDefaults();

            btnTstDb.Normalcolor = Color.DodgerBlue;
            btnTstDb.OnHovercolor = Color.DodgerBlue;
            btnTstDb.Activecolor = Color.DodgerBlue;

            labTitle.BackColor = Color.Crimson;
            labTitle.ForeColor = Color.White;
            testDatabaseTab1.BringToFront();
        }

        private void btnStuRs_Click(object sender, EventArgs e)
        {
            pnUsing.Height = btnStuRs.Height - 1;
            pnUsing.Top = btnStuRs.Top;
            labTitle.Text = "Select Test And View Student Results";
            setDefaults();

            btnStuRs.Normalcolor = Color.DodgerBlue;
            btnStuRs.OnHovercolor = Color.DodgerBlue;
            btnStuRs.Activecolor = Color.DodgerBlue;

            labTitle.BackColor = Color.Crimson;
            labTitle.ForeColor = Color.White;
            btnPrint.Visible = true;

            if (SelectTestTab.isTestSelected)
            {
                btnBack.Visible = true;
            }
           
            studentResultsTab1.callSelectTestTab();
            studentResultsTab1.BringToFront();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            pnUsing.Height = btnAccount.Height - 1;
            pnUsing.Top = btnAccount.Top;
            labTitle.Text = "Your Account Settings";
            setDefaults();

            labTitle.BackColor = Color.Crimson;
            labTitle.ForeColor = Color.White;

            btnAccount.Normalcolor = Color.DodgerBlue;
            btnAccount.OnHovercolor = Color.DodgerBlue;
            btnAccount.Activecolor = Color.DodgerBlue;

            myAccountTab1.setLectAccount();
            myAccountTab1.BringToFront();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            pnUsing.Height = btnLogout.Height - 1;
            pnUsing.Top = btnLogout.Top;
            labTitle.Text = "Logout of Your Lecturer Account";
            setDefaults();

            labTitle.BackColor = Color.Crimson;
            labTitle.ForeColor = Color.White;

            btnLogout.Normalcolor = Color.DodgerBlue;
            btnLogout.OnHovercolor = Color.DodgerBlue;
            btnLogout.Activecolor = Color.DodgerBlue;

            logoutTab1.BringToFront();
        }

        private void picBxExit_Click(object sender, EventArgs e)
        {
            DialogResult getChoice = MessageBox.Show("Are You Sure You Want To Exit Application?", "Warning Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (getChoice == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public void setDefaults()
        {
            btnPrint.Visible = false;
            btnBack.Visible = false;
            ///-------------------------------------------------------
            btnTestEditor.Normalcolor = Color.FromArgb(1, 179, 227);
            btnTestEditor.OnHovercolor = Color.FromArgb(0, 172, 209);
            //--------------------------------------------------------
            btnTstVwr.Normalcolor = Color.FromArgb(1, 179, 227);
            btnTstVwr.OnHovercolor = Color.FromArgb(0, 172, 209);
            //--------------------------------------------------------
            btnTstDb.Normalcolor = Color.FromArgb(1, 179, 227);
            btnTstDb.OnHovercolor = Color.FromArgb(0, 172, 209);
            //--------------------------------------------------------
            btnStuRs.Normalcolor = Color.FromArgb(1, 179, 227);
            btnStuRs.OnHovercolor = Color.FromArgb(0, 172, 209);
            //--------------------------------------------------------
            btnAccount.Normalcolor = Color.FromArgb(1, 179, 227);
            btnAccount.OnHovercolor = Color.FromArgb(0, 172, 209);
            //--------------------------------------------------------
            btnLogout.Normalcolor = Color.FromArgb(1, 179, 227);
            btnLogout.OnHovercolor = Color.FromArgb(0, 172, 209);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            studentResultsTab1.StartPrint();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SelectTestTab.SelTestTbObj.Dispose();
            studentResultsTab1.canCall = true;
            studentResultsTab1.callSelectTestTab();
            SelectTestTab.isTestSelected = false;
            btnBack.Visible = false;
        }

        public void makeBackBtnVisible()
        {
            btnBack.Visible = true;
        }
    }
}
