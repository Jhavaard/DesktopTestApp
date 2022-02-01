using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopTestApp.Lecturer_Components
{
    public partial class SelectTestTab : UserControl
    {
        public static SelectTestTab SelTestTbObj;
        public static String testName;
        public static Boolean isTestSelected = false;

        public SelectTestTab()
        {
            InitializeComponent();
            SelTestTbObj = this;
        }

        public void populateListBox()
        {
            lbSelTest.Items.AddRange(DataBaseConn.TstFilObj.getAllTests());
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            testName = lbSelTest.SelectedItem + "";

            if (testName != "")
            {
                StudentResultsTab.StudResTbObj.populateListView();
                StudentResultsTab.StudResTbObj.pnCalcVisibleTrue();
                LecturerMain.LecMainObj.makeBackBtnVisible();

                isTestSelected = true;
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Please Select A Test To Continue!", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
