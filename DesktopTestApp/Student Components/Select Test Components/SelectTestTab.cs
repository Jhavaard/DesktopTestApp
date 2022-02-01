using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopTestApp.Student_Components;

namespace DesktopTestApp.Student_Components
{
    public partial class SelectTestTab : UserControl
    {
        public static SelectTestTab SelTstTabObj;
        private int StartPtHeight = 0, counter = 0;
        private TestContentMenu TstContMnObj;
        private Boolean hasTest = false;

        public SelectTestTab()
        {
            InitializeComponent();
            SelTstTabObj = this;
            menuOptions.Renderer = new ToolStripProfessionalRenderer(new TestColorTable());
        }

        public class TestColorTable : ProfessionalColorTable
        {
            public override Color MenuBorder
            {
                get { return Color.FromArgb(33, 39, 50); }
            }

            public override Color MenuItemSelected
            {
                get { return Color.FromArgb(27, 32, 41); }
            }

            public override Color MenuItemSelectedGradientBegin
            {
                get { return Color.FromArgb(33, 39, 50); }
            }

            public override Color MenuItemSelectedGradientEnd
            {
                get { return Color.FromArgb(33, 39, 50); }
            }

            public override Color MenuItemPressedGradientBegin
            {
                get { return Color.FromArgb(33, 39, 50); }
            }

            public override Color MenuItemPressedGradientEnd
            {
                get { return Color.FromArgb(33, 39, 50); }
            }
        }

        private void MnItemExitApp_Click(object sender, EventArgs e)
        {
            DialogResult getChoice = MessageBox.Show("Are You Sure You Want To Exit Application?", "Warning Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (getChoice == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void MnItemGoBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void MnItemLectLogin_Click(object sender, EventArgs e)
        {
            this.Dispose();
            StudentMain.StudMnObj.disposeForm();
            LecturerLogin LectLogObj = new LecturerLogin();
            LectLogObj.Show();
        }

        public void AddTestContentMenu(String LectNo, String SetBy, String TestName, String NumQuestions, String TotalMarks, String DateCreated)
        {
            TstContMnObj = new TestContentMenu(SetBy, TestName, NumQuestions, TotalMarks, DateCreated);
            TstContMnObj.Name = LectNo + "#" + SetBy + "#" + TestName + "#" + NumQuestions + "#" + TotalMarks;
            pnTestEnclose.AutoScroll = true;
            pnTestEnclose.AutoScrollPosition = new Point(0, 0);
            pnTestEnclose.Controls.Add(TstContMnObj);
            TstContMnObj.Top = StartPtHeight;

            if (++counter % 2 == 0)
            {
                TstContMnObj.Left = (TstContMnObj.Width + 57);
                StartPtHeight += (TstContMnObj.Height + 40);
            }
            else
            {
                TstContMnObj.Top = StartPtHeight;
                
            }

            hasTest = true;
        }

        private void btnSelTest_Click(object sender, EventArgs e)
        {
            if (hasTest)
            {
                if (TestContentMenu.isSelect == true)
                {
                    String[] SelContArr = DataBaseConn.TstFilObj.getSelTestCont().Split('#');
                    StudentTestTab StudTstTab = new StudentTestTab(SelContArr[0], SelContArr[1], SelContArr[2]);
                    this.Controls.Add(StudTstTab);
                    StudTstTab.addQuestionsToForm();
                }
                else
                {
                    MessageBox.Show("Please Select A Test To Continue");
                }
            }
            else
            {
                btnSelTest.Enabled = false;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void setDefaultColor()
        {
            foreach (Control ctrl in pnTestEnclose.Controls)
            {
                foreach (Control subCtrl in ctrl.Controls)
                {
                    if (subCtrl.Name == "pnMenu")
                    {
                        Panel pnl = subCtrl as Panel;
                        pnl.BackColor = Color.FromArgb(27, 32, 41);
                    }
                }
            }
        }
    }
}
