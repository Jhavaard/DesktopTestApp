using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopTestApp.Student_Components.Student_Test_Components;

namespace DesktopTestApp.Student_Components
{
    public partial class StudentTestTab : UserControl
    {
        public static StudentTestTab StdTstTb;
        private int StartPtHeight = 0; 
        private String NumQuestions, TestName;
        private Label lblAnswered;
        private int numAnswered = 0;
        private int TestTotal;
        private String[][] questionsArr;

        public StudentTestTab(String TestName, String NumQuestions, String TotalMarks)
        {
            InitializeComponent();
            lblTstNamMrk.Text = "est Selected: " + TestName + "(" + TotalMarks + " Marks)";
            lblNumAns.Text = "Answered(none)";
            this.NumQuestions = NumQuestions;
            TestTotal = int.Parse(TotalMarks);
            this.TestName = TestName;

            StdTstTb = this;
        }

        public void addQuestionsToForm()
        {
            try
            {
                int counter = 0;
                questionsArr = DataBaseConn.TstFilObj.readStudTest();

                for (int i = 0; i < questionsArr.Length; i++)
                {
                    QuestionPanel QuesPnObj = new QuestionPanel(counter + 1, questionsArr[counter][0], questionsArr[counter][1], questionsArr[counter][2],
                                                               questionsArr[counter][3], questionsArr[counter][4], questionsArr[counter][5],
                                                               questionsArr[counter][6]);
                    if (i == (questionsArr.Length - 1))
                    {
                        QuesPnObj.Size = new Size(665, 443);
                    }

                    QuesPnObj.Name = "Question" + (i + 1);
                    pnQestions.AutoScroll = true;
                    pnQestions.AutoScrollPosition = new Point(0, 0);
                    pnQestions.Controls.Add(QuesPnObj);
                    QuesPnObj.Top = StartPtHeight;
                    StartPtHeight += QuesPnObj.Height;

                    counter++;
                }

                addAnsweredLabelsToForm();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            this.BringToFront();
        }

        public void addAnsweredLabelsToForm()
        {
            int[] arrTestMarks = DataBaseConn.TstFilObj.getTestMarks();
            int incrementer = 49;

            for (int i = 1; i <= int.Parse(NumQuestions); i++)
            {
                lblAnswered = new Label();
                lblAnswered.Name = "Question"+i;
                lblAnswered.AutoSize = true;
                lblAnswered.Text = "Question " + i + " -  " + arrTestMarks[i-1] + " Marks";
                lblAnswered.Font = new Font("Century", 12f);
                lblAnswered.ForeColor = Color.DarkGray;
                lblAnswered.Location = new Point(13, incrementer);
                pnAnswered.Controls.Add(lblAnswered);
                lblAnswered.Visible = true;

                incrementer += 28;
            }
        }

        public void setAnsdQues(String QuesNum, Boolean isAnswered)
        {
            if (isAnswered == true) { return; }
            
            foreach (Control ctrl in pnAnswered.Controls)
            {
                if (QuesNum == ctrl.Name)
                {
                    Label lblAns = ctrl as Label;
                    lblAns.Font  = new Font("Century", 12f, FontStyle.Strikeout);
                    lblNumAns.Text = "Answered: " + (++numAnswered) + "/" + NumQuestions;
                    return;
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (numAnswered != int.Parse(NumQuestions))
            {
                DialogResult result = MessageBox.Show("You Have Not Answered All Questions In Your Test!.\nAre You Sure You Want To Submit This Incomplete Test?", "Test Incompleted", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    callStdFeedBck();
                }
            }
            else
            {
                callStdFeedBck();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure You Want To Cancel This Test?", "Abort Test", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                this.Visible = false;
                SelectTestTab.SelTstTabObj.Visible = false;
            }
        }

        public void callStdFeedBck()
        {
            StudentFeedbackTab StdFdBckTbObj = new StudentFeedbackTab();
            this.Controls.Add(StdFdBckTbObj);
            StdFdBckTbObj.setStudResults(TestName, QuestionPanel.countMarks, TestTotal);
            QuestionPanel.countMarks = 0; // Set Test Total To Default

            for (int i = 0; i < int.Parse(NumQuestions); i++)
            {
                StdFdBckTbObj.setStudMemo
                (
                   i + 1, questionsArr[i][0], questionsArr[i][1], questionsArr[i][2],
                   questionsArr[i][3], questionsArr[i][4], questionsArr[i][6], NumQuestions,
                   QuestionPanel.arrMemo[i,0], QuestionPanel.arrMemo[i,1]
                );
            }
        }
    }
}
