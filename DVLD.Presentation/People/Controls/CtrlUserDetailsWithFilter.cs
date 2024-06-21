using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Presentation.People.Controls
{
    public partial class CtrlUserDetailsWithFilter : UserControl
    {
        public CtrlUserDetailsWithFilter()
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
        }

        private void CtrlUserDetailsWithFilter_Load(object sender, EventArgs e)
        {
            ComboBoxFilterBy.SelectedIndex = 0;
            TextBoxFilterValue.Focus();
        }
    }
}
