using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopTestApp.Lecturer_Components.Test_Viewer_Components
{
    public partial class QuestionPanel : UserControl
    {
        public QuestionPanel(String Question, String Ans1, String Ans2, String Ans3, String Ans4, char CorrAns, String Marks, bool Visibility)
        {
            InitializeComponent();

            txtQuestion.Text = Question;

            txtAns1.Text = Ans1;
            txtAns2.Text = Ans2;
            txtAns3.Text = Ans3;
            txtAns4.Text = Ans4;

            txtMarks.Text = Marks;

            CheckBoxSelection(); // Set Checkboxes To Default

            switch (CorrAns)
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

            BtnCancel.Visible = Visibility;
        }

        public void CheckBoxSelection()
        {
            chBxA.Checked = false;
            chBxB.Checked = false;
            chBxC.Checked = false;
            chBxD.Checked = false;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            ViewTestTab.VwTstTbObj.sendBack();
        }
    }
}
