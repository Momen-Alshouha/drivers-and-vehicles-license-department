using DVLD.Presentation.People;
using DVLD.Presentation.People.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Presentation
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            //InitializeComponent();
            LoadCtrlUserDetailsWithFilter();
        }

        private void LoadCtrlUserDetailsWithFilter()
        {
            // Instantiate the user control
            CtrlUserDetailsWithFilter myUserControl = new CtrlUserDetailsWithFilter();

            // Optionally, set properties or handle events here
            // myUserControl.SomeProperty = someValue;
            // myUserControl.SomeEvent += SomeEventHandler;

            // Set the size and location of the user control
            myUserControl.Dock = DockStyle.Fill;

            // Add the user control to the form
            this.Controls.Add(myUserControl);

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManagePeople frmManagePeople = new FrmManagePeople();
            frmManagePeople.ShowDialog();
            
        }

        private void drivingLiscenseServicesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manageApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
