using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace DesktopTestApp.Lecturer_Components.Test_Editor_Components
{

    public partial class AddTestTab : UserControl
    {
        public static int StartPt, TotTest, SelTest, UnselTest;
        public static List<string> TestList = new List<string>();
        public static List<bool> CheckList = new List<bool>();

        public static Panel pnEnclose = new Panel();
        public static Panel pnTest = new Panel();
        public static Label lbTotal = new Label();
        public static Label lbSelected = new Label();
        public static Label lbUnselected = new Label();

        public static AddTestTab AddTstObj;

        public AddTestTab()
        {
            InitializeComponent();
            AddTstObj = this;

            pnEnclose_Properties();
            pnTest_Properties();

            lbTotal_Properties();
            lbSelected_Properties();
            lbUnSelected_Properties();
        }

        public void addAllLectTests()
        {
            /// Set Defaults
            StartPt = 0;
            TotTest = 0;
            UnselTest = 0;

            TestList.Clear();
            CheckList.Clear();

            pnTest.Controls.Clear();
            foreach (string testName in DataBaseConn.TstFilObj.getCreatedLectTests())
            {
                addTestMenuCtrl(testName, false, false);
            }
        }

        public void pnEnclose_Properties()
        {
            this.Controls.Add(pnEnclose);
            pnEnclose.Dock = DockStyle.Fill;
            pnEnclose.BackColor = Color.FromArgb(240, 240, 240);
            pnEnclose.Controls.Add(pnAddTest);
        }

        public void pnTest_Properties()
        {
            pnAddTest.Controls.Add(pnTest);
            pnTest.SetBounds(15, 58, 559, 310);
            pnTest.BackColor = Color.FromArgb(240, 240, 240);
            pnTest.AutoScroll = true;
        }

        public void lbTotal_Properties()
        {
            pnBottom.Controls.Add(lbTotal);
            lbTotal.SetBounds(5, 2, 41, 17);
            lbTotal.BackColor = Color.Crimson;
            lbTotal.ForeColor = Color.White; 
            lbTotal.AutoSize = true;
            lbTotal.Text = "Total: ";
            lbTotal.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Italic);
        }

        public void lbSelected_Properties()
        {
            pnBottom.Controls.Add(lbSelected);
            lbSelected.SetBounds(220, 2, 61, 17);
            lbSelected.BackColor = Color.Crimson;
            lbSelected.ForeColor = Color.White;
            lbSelected.AutoSize = true;
            lbSelected.Text = "Selected: ";
            lbSelected.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Italic);
        }

        public void lbUnSelected_Properties()
        {
            pnBottom.Controls.Add(lbUnselected);
            lbUnselected.SetBounds(449, 2, 76, 17);
            lbUnselected.BackColor = Color.Crimson;
            lbUnselected.ForeColor = Color.White;
            lbUnselected.AutoSize = true;
            lbUnselected.Text = "Unselected: ";
            lbUnselected.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Italic);
        }

        public void addTestMenuCtrl(String Text, bool Checked, bool isDelete)
        {
            TestMenu Test = new TestMenu(Text, Checked);
            Test.Name = Text;
            TestList.Add(Text);
            CheckList.Add(Checked);

            pnTest.AutoScrollPosition = new Point(0, 0);
            pnTest.Controls.Add(Test);

            Test.Top = StartPt;
            StartPt += (Test.Height + 10);

            if (!isDelete)
            {
                ++TotTest;
                ++UnselTest;
            }

            DisplaySelection();
            pnTest.Focus();
        }

        public void addTest(String Text, bool Checked)
        {
            if ((txtTestName.Text == "Enter Test Name" && txtTestName.ForeColor == Color.Gray) || txtTestName.Text.Trim() == "")
            {
                MessageBox.Show("Please Input Name For Test In The Textbox Provided!");
            }
            else
            {
                addTestMenuCtrl(Text, Checked, false);

                txtTestName.Text = "Enter Test Name"; txtTestName.ForeColor = Color.Gray;
                pnTest.AutoScrollPosition = new Point(
                Math.Abs(pnTest.AutoScrollPosition.X),
                pnTest.VerticalScroll.Maximum);

                DataBaseConn.TstFilObj.createLecturerTest(Text);
            }
        }

        public void deleteTest(String[] selTests)
        {
            StartPt = 0;

            String[] testArray = TestList.ToArray();
            bool[] checkArray = CheckList.ToArray();


            foreach (string Testname in selTests)
            {
                int index = TestList.IndexOf(Testname);

                DataBaseConn.TstFilObj.deleteLecturerTest(Testname);
                TestMenu.tstMnObj.setSelection(CheckList[index]);
            }

            TestList.Clear();
            CheckList.Clear();

            AddTestTab.pnTest.Controls.Clear();

            for (int i = 0; i < testArray.Length; i++)
            {
                bool Flag = true;

                for (int j = 0; j < selTests.Length; j++)
                {
                    if (testArray[i] == selTests[j])
                    {
                        Flag = false;
                    }
                }

                if (Flag)
                {
                    addTestMenuCtrl(testArray[i], checkArray[i], true);
                }
            }
        }

        private void btnAddTest_Click(object sender, EventArgs e)
        {
            addTest(txtTestName.Text, false);
        }

        private void txtTestName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                addTest(txtTestName.Text, false);
                e.Handled = true;
            }
        }

        private void btnDelSelected_Click(object sender, EventArgs e)
        {
            deleteTest(TestMenu.selectedTests.ToArray());
            TestMenu.selectedTests.Clear();

            MessageBox.Show("Successfully Deleted Selected Tests");
        }

        private void txtTestName_Enter(object sender, EventArgs e)
        {
            if (txtTestName.ForeColor != Color.Crimson)
            {
                txtTestName.Text = "";
            }

            txtTestName.ForeColor = Color.Crimson;
        }

        private void txtTestName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTestName.Text))
            {
                txtTestName.ForeColor = Color.Gray;
                txtTestName.Text = "Enter Test Name";
            }
        }

        public static void DisplaySelection()
        {
            lbTotal.Text = "Total: " + (TotTest);
            lbSelected.Text = "Selected: " + (SelTest);
            lbUnselected.Text = "Unselected: " + (UnselTest);
        }
    }
}
