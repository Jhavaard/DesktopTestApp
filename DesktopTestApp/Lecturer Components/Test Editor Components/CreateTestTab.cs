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
    public partial class CreateTestTab : UserControl
    {
        public static AddQuestionTab AddQuesObj = new AddQuestionTab();

        public static Panel pnQuestions = new Panel();

        public CreateTestTab()
        {
            InitializeComponent();
            this.Controls.Add(AddQuesObj);

            pnQuestions.SetBounds(8, 63, 566, 325);
            pnQuestions.BackColor = Color.LightGray;
            pnCrtTstTab.Controls.Add(pnQuestions);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.SendToBack();
            pnQuestions.Controls.Clear();
            AddQuestionTab.StartPt = 0;
            AddQuestionTab.questionNum = 0;

            LecturerMain.LecMainObj.setSelectedTest("Add A Test To The Database");
        }

        private void btnAddQues_Click(object sender, EventArgs e)
        {
            AddQuesObj.Visible = true;

            AddQuesObj.setFields("", 
                                 "Enter Answer One",
                                 "Enter Answer Two", 
                                 "Enter Answer Three", 
                                 "Enter Answer Four", 
                                 'K', 
                                  0, 
                                  true);

            AddQuesObj.BringToFront();
        }

        private void btnSaveTst_Click(object sender, EventArgs e)
        {
            TestMenu.addTst2Pnl = false;
            TestMenu.tstMnObj.readTest();

            if (TestMenu.arrTest != null)
            {
                DataBaseConn.TstFilObj.saveStudTest(TestMenu.arrTest);
                MessageBox.Show("Your Created Test '" + TestMenu.tstMnObj.getTestName() + "' Has Been Saved Successfully!", "Successfully Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("There Is Nothing To Save. Please Add Questions To Test!", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
