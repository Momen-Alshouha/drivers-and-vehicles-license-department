using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClsDataType;

namespace DVLD.Presentation.People.Controls
{
    public partial class CtrlPersonDetailsWithFilter : UserControl
    {
        // property to control the visibility of GroupBoxUserDetailsFilter
        public bool GroupBoxUserDetailsFilterVisible
        {
            get
            {
                return GroupBoxUserDetailsFilter.Visible;
            }
            set
            {
                GroupBoxUserDetailsFilter.Enabled = value;
            }
        }
        public ClsDataType.ClsDataType.StPerson? SelectedPersonInfo
        {
            get { return ctrlUserDetails1.Person; }
        }

        public int PersonID
        {
            get
            {
                return ctrlUserDetails1.Person.Value.Id;
            }
        }

        public CtrlPersonDetailsWithFilter()
        {
            InitializeComponent();
        }

        // Define a custom event handler delegate with parameters
        public event Action<int> OnPersonSelected;
        // Create a protected method to raise the event with a parameter
        protected virtual void PersonSelected(int PersonID)
        {
            Action<int> handler = OnPersonSelected;
            if (handler != null)
            {
                handler(PersonID); // Raise the event with the parameter
            }
        }

        public void LoadPersonInfo(int PersonID)
        {

            ComboBoxFilterBy.SelectedIndex = 1;
            TextBoxFilterValue.Text = PersonID.ToString();
            FindNow();

        }

        private void FindNow()
        {
            switch (ComboBoxFilterBy.Text)
            {
                case "Person ID":
                    ctrlUserDetails1.LoadPersonInfo(int.Parse(TextBoxFilterValue.Text));

                    break;

                case "National No":
                    ctrlUserDetails1.LoadPersonInfo(TextBoxFilterValue.Text);
                    break;

                default:
                    break;
            }

            if (OnPersonSelected != null)
                // Raise the event with a parameter
                OnPersonSelected(ctrlUserDetails1.Person.Value.Id);
        }
        private void PictureBoxAddNewPerson_Click(object sender, EventArgs e)
        {
            FrmAddEditPerson frmAddEditPerson = new FrmAddEditPerson();
            frmAddEditPerson.ShowDialog();
        }

        private void DataBackEvent(object sender, int PersonID)
        {
            // Handle the data received

            ComboBoxFilterBy.SelectedIndex = 1;
            TextBoxFilterValue.Text = PersonID.ToString();
            ctrlUserDetails1.LoadPersonInfo(PersonID);
        }

        private void PictureBoxSearchPerson_Click(object sender, EventArgs e)
        {
            FindNow();

            if (!SelectedPersonInfo.HasValue)
            {
                MessageBox.Show("Person Not Found!","Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Information,MessageBoxDefaultButton.Button1);
            }
        }

        private void CtrlUserDetailsWithFilter_Load(object sender, EventArgs e)
        {
            ComboBoxFilterBy.SelectedIndex = 0;
            TextBoxFilterValue.Focus();
        }
    }
}
