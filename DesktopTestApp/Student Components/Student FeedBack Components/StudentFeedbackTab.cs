using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using DesktopTestApp.Student_Components.Student_FeedBack_Components;

namespace DesktopTestApp.Student_Components
{
    public partial class StudentFeedbackTab : UserControl
    {
        MaterialSkinManager skinManager;
        private int StartPtHeight = 0;
        private string saveStdRes;

        public StudentFeedbackTab()
        {
            InitializeComponent();

            skinManager = MaterialSkinManager.Instance;
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
        }

        public void setStudResults(String testName, int stdMark, int testTot)
        {
            //set Student Information
            lblStudName.Text = DataBaseConn.TstFilObj.getStudFName() + " " + DataBaseConn.TstFilObj.getStudSName();
            lblTestName.Text = "Test Name: " + testName;
            lblScore.Text = stdMark + "";
            lblTestTot.Text = testTot + "";
            int studMrkPerc = (int)(((double)stdMark / testTot) * 100);
            cpbMarkPerc.Value = studMrkPerc;

            if (cpbMarkPerc.Value > 49)
            {
                lblResult.Text = "Passed";
            }
            else
            {
                lblResult.Text = "Failed";
            }

            if (studMrkPerc >= 0 && studMrkPerc <= 19)
            {
                rtStudRating.Value = 1;
            }
            else if (studMrkPerc >= 20 && studMrkPerc <= 39)
            {
                rtStudRating.Value = 2;
            }
            else if (studMrkPerc >= 40 && studMrkPerc <= 59)
            {
                rtStudRating.Value = 3;
            }
            else if (studMrkPerc >= 60 && studMrkPerc <= 79)
            {
                rtStudRating.Value = 4;
            }
            else if (studMrkPerc >= 80 && studMrkPerc <= 100)
            {
                rtStudRating.Value = 5;
            }

            //Saves Results For Each Student
            saveStdRes = DataBaseConn.TstFilObj.getStudNum() + "#" + TestContentMenu.LectNum + "#" + testName + "#" + stdMark + "#" + studMrkPerc + "#" + lblResult.Text;
            DataBaseConn.TstFilObj.saveStdResults(saveStdRes);
        }

        public void setStudMemo(int QuesNum, String question, String AnsOne, String AnsTwo, String AnsThree,
                                String AnsFour, String Marks, String NumQues, String StudAns, String CorrAns)
        {
            MemoPanel MemoPnObj = new MemoPanel(QuesNum, question, AnsOne, AnsTwo, AnsThree,
                                                AnsFour, Marks, StudAns, CorrAns);
            pnMemo.AutoSize = true;
            pnMemo.AutoScrollPosition = new Point(0, 0);
            pnMemo.Controls.Add(MemoPnObj);
            MemoPnObj.Top = StartPtHeight;
            StartPtHeight += MemoPnObj.Height;

            if (QuesNum == int.Parse(NumQues))
            {
                MemoPnObj.Size = new Size(838, 476);
                this.BringToFront();
            }
        }

        private void pbxClose_Click(object sender, EventArgs e)
        {
            DialogResult getChoice = MessageBox.Show("Are You Sure You Want To Exit Application?", "Warning Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (getChoice == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            StudentTestTab.StdTstTb.Visible = false;
            SelectTestTab.SelTstTabObj.Visible = false;
        }
    }
}
