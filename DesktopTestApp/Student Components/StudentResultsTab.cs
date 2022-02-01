using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;

namespace DesktopTestApp.Student_Components
{
    public partial class StudentResultsTab : UserControl
    {
        MaterialSkinManager skinManager;

        public StudentResultsTab()
        {
            InitializeComponent();

            skinManager = MaterialSkinManager.Instance;
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
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

        public void populateListView()
        {
            try
            {
                String[][] arrStudRes = DataBaseConn.TstFilObj.readStdRes();
                ListViewItem listStudRes;

                foreach (String[] lines in arrStudRes)
                {
                    listStudRes = new ListViewItem(lines);
                    lvStdRes.Items.Add(listStudRes);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void picExitApp_Click(object sender, EventArgs e)
        {
            DialogResult getChoice = MessageBox.Show("Are You Sure You Want To Exit Application?", "Warning Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (getChoice == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
