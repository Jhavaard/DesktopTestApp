using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopTestApp.Lecturer_Components.Test_Editor_Components;

namespace DesktopTestApp.Lecturer_Components.Test_Viewer_Components
{
    public partial class ListTestTab : UserControl
    {
        ViewTestTab VwTstObj = new ViewTestTab();
        public static ListTestTab LTstobj;
        String[] LectTestsArr;
        bool changeText = true, CanSearch = true;
        int StartPt, NumQues;
        String testCreated;

        public ListTestTab()
        {
            InitializeComponent();
            LTstobj = this;
            this.Controls.Add(VwTstObj);

            pnListTst.AutoScroll = true;
            pnListTst.AutoScrollPosition = new Point(0, 0);
        }

        public void addAllLectTests()
        {
            StartPt = 10;
            pnListTst.Controls.Clear();

            LectTestsArr = DataBaseConn.TstFilObj.getLectTests();

            for (int i = 0; i < LectTestsArr.Length; i++)
            {
                DataBaseConn.TstFilObj.setLecTstPth(LectTestsArr[i]);
                testCreated = DataBaseConn.TstFilObj.getDateCreated()[i];
                NumQues = int.Parse(DataBaseConn.TstFilObj.getTotQues()[i]);

                addCtrlToPnl(i);
            }
        }

        public void addCtrlToPnl(int i)
        {
            TestName TstNameObj = new TestName(LectTestsArr[i], NumQues, testCreated);
            TstNameObj.Name = LectTestsArr[i];

            pnListTst.Controls.Add(TstNameObj);
            TstNameObj.Top = StartPt;
            StartPt += (TstNameObj.Height + 10);
            pnListTst.ScrollControlIntoView(TstNameObj);
        }

        public void checkSelection(String testName)
        {
            foreach (Control c in pnListTst.Controls)
            {
                foreach (Control childc in c.Controls)
                {
                    CheckBox chkBox = childc as CheckBox;

                    if (childc.Name == "chkBxTestSel")
                    {
                        if (childc.Text != testName)
                        {
                            chkBox.Checked = false;
                        }
                    }
                }
            }
        }

        public void searchTest(string textName)
        {
            StartPt = 10;
            bool flag = false;

            if (!string.IsNullOrEmpty(textName))
            {
                for (int i = 0; i < LectTestsArr.Length; i++)
                {
                    if (LectTestsArr[i].ToLower().StartsWith(textName.ToLower()))
                    {
                        flag = true;

                        if (StartPt == 10)
                        {
                            pnListTst.Controls.Clear();
                        }

                        addCtrlToPnl(i);
                    }
                }

                if (!flag)
                {
                    pnListTst.Controls.Clear();
                }


                if (txtSearch.Text == "Search Test By Name")
                {
                    for (int i = 0; i < LectTestsArr.Length; i++)
                    {
                        addCtrlToPnl(i);
                    }
                }
            }
        }

 //----------------------------------------------------------------------------------------------

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "" && txtSearch.ForeColor == Color.White && changeText == true)
            {
                txtSearch.Text = "Search Test By Name";
                txtSearch.ForeColor = Color.LightGray;
            }

            if (CanSearch == true)
            {
                searchTest(txtSearch.Text.Trim());
            }
           
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.ForeColor == Color.LightGray)
            {
                CanSearch = true;
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.White;
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Back)
            {
                if (txtSearch.ForeColor == Color.LightGray)
                {
                    changeText = false;
                    txtSearch.ForeColor = Color.White;
                    txtSearch.Text = "";
                }

                if (txtSearch.Text == "")
                {
                    changeText = true;
                }
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                CanSearch = false;
                txtSearch.Text = "Search Test By Name";
                txtSearch.ForeColor = Color.LightGray;
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Text File|*.txt";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    DataBaseConn.TstFilObj.setOpenFilePath(ofd.FileName);

                    if (!DataBaseConn.TstFilObj.isLectTestNull())
                    {
                        this.Cursor = Cursors.AppStarting;

                        VwTstObj.readTest();
                        LecturerMain.LecMainObj.setSelectedTest("Viewing Test - " + ofd.SafeFileName.Replace(".txt",""));

                        this.Cursor = Cursors.Default;
                    }
                    else
                    {
                        MessageBox.Show("Error, The File Selected Seems To Be Empty!");
                    }
                }
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TestName.getTestName))
            {
                DataBaseConn.TstFilObj.setLecTstPth(TestName.getTestName);
                btnTest.Cursor = Cursors.AppStarting;

                VwTstObj.readTest();
                LecturerMain.LecMainObj.setSelectedTest("Viewing Test - " + TestName.getTestName);

                btnTest.Cursor = Cursors.Hand;
            }
            else
            {
                MessageBox.Show("Error, Please Select A Test To View It!");
            }
        }

        public void setSelectedTest(String testName)
        {
            lblTestSel.Text = "Test Selected: "+testName;
        }
    }
}
