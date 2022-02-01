using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopTestApp.Lecturer_Components.Test_Editor_Components
{
    public partial class TestMenu : UserControl
    {
        public static TestMenu tstMnObj;
        public static String[,] arrTest;
        public static List<string> selectedTests = new List<string>();
        public static bool addTst2Pnl = true;
        public static int counter = 0;

        public TestMenu()
        {
            InitializeComponent();
        }

        public TestMenu(String  Text, Boolean Checked)
        {
            InitializeComponent();
            tstMnObj = this;

            lblName.Text = Text;
            chkBxDel.Checked = Checked;

            if (Checked)
            {
                lblName.Font = new Font(lblName.Name, lblName.Font.SizeInPoints, FontStyle.Strikeout);
            }
        }

        public string getTestName()
        {
            return lblName.Text;
        }

        public  void readTest()
        {
            if (!DataBaseConn.TstFilObj.isLectTestNull())
            {
                arrTest = DataBaseConn.TstFilObj.readLectTest(lblName.Text);

                if (addTst2Pnl)
                {
                    for (int r = 0; r < arrTest.GetLength(0); r++)
                    {
                        AddQuestionTab.AddTstObj.AddQuestToPnl(arrTest[r, 0]);
                    }
                }
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            btnCreate.Cursor = Cursors.AppStarting;

            CreateTestTab crtTabObj = new CreateTestTab();
            AddTestTab.pnEnclose.Controls.Add(crtTabObj);

            addTst2Pnl = true;
            DataBaseConn.TstFilObj.setLecTstPth(lblName.Text);
            readTest();

            crtTabObj.BringToFront();
            LecturerMain.LecMainObj.setSelectedTest("Creating Test: " + lblName.Text);

            btnCreate.Cursor = Cursors.Default;
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            selectedTests.Remove(lblName.Text);
            AddTestTab.AddTstObj.deleteTest(lblName.Text.Split('!'));

            MessageBox.Show("Test '"+lblName.Text+"' Has Been Sucessfully Deleted!");
        }

        public void setSelection(bool isChecked)
        {
            --AddTestTab.TotTest;

            if (isChecked == false)
            {
                --AddTestTab.UnselTest;
            }
            else
            {
                --AddTestTab.SelTest;
            }

            AddTestTab.DisplaySelection();
        }

        private void chkBx_OnChange(object sender, EventArgs e)
        {
            int index = AddTestTab.TestList.IndexOf(lblName.Text);

            if (chkBxDel.Checked == false)
            {
                ++AddTestTab.UnselTest;
                --AddTestTab.SelTest;

                lblName.Font = new Font("Segoe UI", 14.25f, FontStyle.Regular);

                selectedTests.Remove(lblName.Text);
                AddTestTab.CheckList[index] = false;
            }
            else
            {
                --AddTestTab.UnselTest;
                ++AddTestTab.SelTest;

                lblName.Font = new Font(lblName.Name, lblName.Font.SizeInPoints, FontStyle.Strikeout);

                selectedTests.Add(lblName.Text);
                AddTestTab.CheckList[index] = true;
            }

            AddTestTab.DisplaySelection();
        }
    }
}
