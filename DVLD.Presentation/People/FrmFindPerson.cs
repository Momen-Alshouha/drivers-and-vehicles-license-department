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

namespace DVLD.Presentation.People
{
    public partial class FrmFindPerson : Form
    {
        // Declare a delegate
        public delegate void DataBackEventHandler(object sender, int PersonID);

        // Declare an event using the delegate

        public event DataBackEventHandler DataBack;

        public FrmFindPerson()
        {
            InitializeComponent();
        }

        private void ButtonCloseFindPersonForm_Click(object sender, EventArgs e)
        {
            // Trigger the event to send data back to the caller form.
            DataBack?.Invoke(this, ctrlUserDetailsWithFilter1.PersonID);
        }
    }
}
