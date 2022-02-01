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

namespace DesktopTestApp.Lecturer_Components
{
    public partial class TestDatabaseTab : UserControl
    {
        MaterialSkinManager skinManager;

        public TestDatabaseTab()
        {
            InitializeComponent();
            ///ListView k = new ListView(this);
            //gv k = new gv(this);
            skinManager = MaterialSkinManager.Instance;
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;


            ////skinManager.ColorScheme = new ColorScheme(Primary.DeepOrange600, Primary.Cyan400, Primary.Green900, Accent.Blue700, TextShade.BLACK);

            //how o = new how(materialListView1);
        }

        public void how(MaterialSkin.Controls.MaterialListView tasb)
        {
            skinManager = MaterialSkinManager.Instance;
            //skinManager.lis
            ///skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            //skinManager.ColorScheme = new ColorScheme(Primary.Pink300, Primary.Cyan400, Primary.Green900, Accent.Blue700, TextShade.BLACK);
            ///skinManager.GetSecondaryTextBrush = Brushes.Cyan;
        }
    }
}
