using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopTestApp.Student_Components.Student_Test_Components
{
    public partial class QuestionPanel : UserControl
    {
        private Boolean isAnswered = false, isMarked = false;
        private String AnsOne, AnsTwo, AnsThree, AnsFour, CorrAns;
        private int Marks, QuesNum;
        public static int countMarks;
        public static String[,] arrMemo;

        public QuestionPanel(int QuesNum, String question, String AnsOne, String AnsTwo, String AnsThree, String AnsFour, String CorrAns, String Marks)
        {
            InitializeComponent();
            //Set Text of Labels
            lblQuesNum.Text = "Question: " + QuesNum;
            lblQues.Text = question;
            lblAns1.Text = AnsOne;
            lblAns2.Text = AnsTwo;
            lblAns3.Text = AnsThree;
            lblAns4.Text = AnsFour;
            lblMark.Text = "Marks: " + Marks;

            //Set Names of Variables
            this.QuesNum = QuesNum;
            this.AnsOne = AnsOne;
            this.AnsTwo = AnsTwo;
            this.AnsThree = AnsThree;
            this.AnsFour = AnsFour;
            this.CorrAns = CorrAns;
            this.Marks = int.Parse(Marks);

            int numQues = DataBaseConn.TstFilObj.getNumQues();
            arrMemo = new string[numQues, 2];
        }

        public void CheckBoxSelection()
        {
            chBxA.Checked = false;
            chBxB.Checked = false;
            chBxC.Checked = false;
            chBxD.Checked = false;

            chBxA.BorderStyle = BorderStyle.Fixed3D;
            chBxB.BorderStyle = BorderStyle.Fixed3D;
            chBxC.BorderStyle = BorderStyle.Fixed3D;
            chBxD.BorderStyle = BorderStyle.Fixed3D;
        }

        private void chBxA_OnChange(object sender, EventArgs e)
        {
            CheckBoxSelection();
            chBxA.Checked = true;
            chBxA.BorderStyle = BorderStyle.None;
            StudentTestTab.StdTstTb.setAnsdQues(this.Name, isAnswered);
            isAnswered = true;
            createMemo("A");
        }

        private void chBxB_OnChange(object sender, EventArgs e)
        {
            CheckBoxSelection();
            chBxB.Checked = true;
            chBxB.BorderStyle = BorderStyle.None;
            StudentTestTab.StdTstTb.setAnsdQues(this.Name, isAnswered);
            isAnswered = true;
            createMemo("B");
        }

        private void chBxC_OnChange(object sender, EventArgs e)
        {
            CheckBoxSelection();
            chBxC.Checked = true;
            chBxC.BorderStyle = BorderStyle.None;
            StudentTestTab.StdTstTb.setAnsdQues(this.Name, isAnswered);
            isAnswered = true;
            createMemo("C");
        }

        private void chBxD_OnChange(object sender, EventArgs e)
        {
            CheckBoxSelection();
            chBxD.Checked = true;
            chBxD.BorderStyle = BorderStyle.None;
            StudentTestTab.StdTstTb.setAnsdQues(this.Name, isAnswered);
            isAnswered = true;
            createMemo("D");
        }

        public void createMemo(String StudAns)
        {
            arrMemo[QuesNum - 1, 0] = StudAns;
            arrMemo[QuesNum - 1, 1] = CorrAns;


            if (StudAns == CorrAns)
            {
                countMarks += Marks;
                isMarked = true;
            }
            else
            {
                if (isMarked)
                {
                    countMarks -= Marks;
                    isMarked = false;
                }
            }
        }
    }
}
