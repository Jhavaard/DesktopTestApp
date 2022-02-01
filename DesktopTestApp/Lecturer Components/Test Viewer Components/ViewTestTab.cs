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
    public partial class ViewTestTab : UserControl
    {
        String[,] TestArr;
        int StartPt;

        public static ViewTestTab VwTstTbObj;

        public ViewTestTab()
        {
            InitializeComponent();
            VwTstTbObj = this;
        }

        public void readTest()
        {
            TestArr = DataBaseConn.TstFilObj.readLectTest(TestName.getTestName);

            StartPt = 0;
            readQuestions();
        }

        public void readQuestions()
        {
            try
            {
                for (int r = 0; r < TestArr.GetLength(0); r++)
                {
                    bool isBtnCnlVisible = false;

                    if ((r + 1) == TestArr.GetLength(0))
                    {
                        isBtnCnlVisible = true;
                    }

                    QuestionPanel Question = new QuestionPanel((r + 1) + "). " + TestArr[r, 0],
                                                                                 TestArr[r, 1],
                                                                                 TestArr[r, 2],
                                                                                 TestArr[r, 3],
                                                                                 TestArr[r, 4],
                                                                                 TestArr[r, 5][0],
                                                                                 TestArr[r, 6],
                                                                                 isBtnCnlVisible);

                    pnTestQues.AutoScrollPosition = new Point(0, 0);
                    pnTestQues.Controls.Add(Question);

                    Question.Top = StartPt;
                    StartPt += (Question.Height - 25);

                    pnTestQues.Focus();
                }

                this.BringToFront();
            }
            catch (Exception)
            {
                MessageBox.Show("The Test Selected Is Not In The Correct Format, Please Select Another Test!");
                this.SendToBack();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            sendBack();
        }


        public void sendBack()
        {
            this.SendToBack();
            pnTestQues.Controls.Clear();

            LecturerMain.LecMainObj.setSelectedTest("Select A Test An View Its Content");
        }
    }
}
