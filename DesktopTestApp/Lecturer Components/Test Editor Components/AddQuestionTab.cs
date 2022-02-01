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
    public partial class AddQuestionTab : UserControl
    {
        public static AddQuestionTab AddTstObj;
        public static string sendQues;
        public static int questionNum = 0;

        public static int StartPt = 0;

        public AddQuestionTab()
        {
            InitializeComponent();
            AddTstObj = this;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            String CorrAnsSel;

            if (chBxA.Checked)
            {
                CorrAnsSel = "A";
            }
            else if (chBxB.Checked)
            {
                CorrAnsSel = "B";
            }
            else if (chBxC.Checked)
            {
                CorrAnsSel = "C";
            }
            else if (chBxD.Checked)
            {
                CorrAnsSel = "D";
            }
            else
            {
                CorrAnsSel = "None";
            }

            DataBaseConn.TstFilObj.setLecturerTest(txtQuestion.Text, txtAns1.Text, txtAns2.Text, 
                                                   txtAns3.Text, txtAns4.Text, CorrAnsSel, int.Parse(txtMarks.Text));

            AddQuestToPnl(txtQuestion.Text);
            this.Visible = false;
        }

        public void AddQuestToPnl(String Question)
        {
            QuestionMenu quesMenuObj = new QuestionMenu();
            quesMenuObj.lbQues.Text = ++questionNum + "). " + Question;

            CreateTestTab.pnQuestions.AutoScroll = true;
            CreateTestTab.pnQuestions.AutoScrollPosition = new Point(0, 0);
            CreateTestTab.pnQuestions.Controls.Add(quesMenuObj);

            quesMenuObj.Top = StartPt;
            StartPt += (quesMenuObj.Height + 10);
            CreateTestTab.pnQuestions.ScrollControlIntoView(quesMenuObj);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        public void setFields(String Question, String Ans1, String Ans2, String Ans3, String Ans4, char CorrectAns, int Marks, Boolean BtnVisibility)
        {
            txtQuestion.Text = Question;

            txtAns1.Text = Ans1;
            txtAns2.Text = Ans2;
            txtAns3.Text = Ans3;
            txtAns4.Text = Ans4;

            CheckBoxSelection(); // Set Checkboxes To Default

            switch (CorrectAns)
            {
                case 'A':
                    chBxA.Checked = true;
                    break;
                case 'B':
                    chBxB.Checked = true;
                    break;
                case 'C':
                    chBxC.Checked = true;
                    break;
                case 'D':
                    chBxD.Checked = true;
                    break;
                default:
                    {
                        CheckBoxSelection();
                        break;
                    }
            }

            txtMarks.Text = Marks+"";
            BtnSave.Visible = BtnVisibility;
        }

        public void CheckBoxSelection()
        {
            chBxA.Checked = false;
            chBxB.Checked = false;
            chBxC.Checked = false;
            chBxD.Checked = false;
        }

        private void chBxA_OnChange(object sender, EventArgs e)
        {
            CheckBoxSelection();
            chBxA.Checked = true;
        }

        private void chBxB_OnChange(object sender, EventArgs e)
        {
            CheckBoxSelection();
            chBxB.Checked = true;
        }

        private void chBxC_OnChange(object sender, EventArgs e)
        {
            CheckBoxSelection();
            chBxC.Checked = true;
        }

        private void chBxD_OnChange(object sender, EventArgs e)
        {
            CheckBoxSelection();
            chBxD.Checked = true;
        }
    }
}
