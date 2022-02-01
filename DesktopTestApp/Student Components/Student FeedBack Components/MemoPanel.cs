using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopTestApp;
using System.IO;

namespace DesktopTestApp.Student_Components.Student_FeedBack_Components
{
    public partial class MemoPanel : UserControl
    {
        public MemoPanel(int QuesNum, String question, String AnsOne, String AnsTwo, String AnsThree, String AnsFour,
                         String Marks, String StudAns, String CorrAns)
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

            try
            {
                String getUsrDir = Directory.GetCurrentDirectory().Replace(@"bin\Debug", @"Resources\");

                if (StudAns == CorrAns && StudAns != null)
                {
                    ptbxTicCros.Image = Image.FromFile(getUsrDir + "Correct.png");
                }
                else
                {
                    ptbxTicCros.Image = Image.FromFile(getUsrDir + "Wrong.png");

                    // Wrong Anwser
                    if (StudAns == "A")
                    {
                        lblAns1.ForeColor = Color.IndianRed;
                    }
                    else if (StudAns == "B")
                    {
                        lblAns2.ForeColor = Color.IndianRed;
                    }
                    else if (StudAns == "C")
                    {
                        lblAns3.ForeColor = Color.IndianRed;
                    }
                    else if (StudAns == "D")
                    {
                        lblAns4.ForeColor = Color.IndianRed;
                    }
                }

                // Correct Answer
                if (CorrAns == "A")
                {
                    lblAns1.ForeColor = Color.SeaGreen;
                }
                else if (CorrAns == "B")
                {
                    lblAns2.ForeColor = Color.SeaGreen;
                }
                else if (CorrAns == "C")
                {
                    lblAns3.ForeColor = Color.SeaGreen;
                }
                else if (CorrAns == "D")
                {
                    lblAns4.ForeColor = Color.SeaGreen;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
