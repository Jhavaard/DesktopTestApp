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
    public partial class QuestionMenu : UserControl
    {
        String[,] getTest;

        public QuestionMenu()
        {
            InitializeComponent();
        }

        private void QuestionMenu_MouseEnter(object sender, EventArgs e)
        {
            //this.BackColor = Color.DodgerBlue;
        }

        private void QuestionMenu_MouseLeave(object sender, EventArgs e)
        {
            //this.BackColor = Color.DeepSkyBlue;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            TestMenu.addTst2Pnl = false;

            TestMenu.tstMnObj.readTest();
            getTest = TestMenu.arrTest;
            
            int QuesNum = int.Parse((lbQues.Text)[0]+"")-1;// Question Starts From 1

            CreateTestTab.AddQuesObj.setFields(getTest[QuesNum, 0],
                                               getTest[QuesNum, 1],
                                               getTest[QuesNum, 2],
                                               getTest[QuesNum, 3],
                                               getTest[QuesNum, 4],
                                               getTest[QuesNum, 5][0],
                                               int.Parse(getTest[QuesNum, 6]),
                                               false);

            CreateTestTab.AddQuesObj.Visible = true;
            CreateTestTab.AddQuesObj.BringToFront();
        }
    }
}
