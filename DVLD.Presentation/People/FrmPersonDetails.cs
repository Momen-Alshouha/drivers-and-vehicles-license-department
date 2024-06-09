using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ClsDataType.ClsDataType;
namespace DVLD.Presentation.People
{
    public partial class FrmPersonDetails : Form
    {
       
        private int _PersonID;
        public FrmPersonDetails()
        {
            InitializeComponent();
        }

        public FrmPersonDetails(int PersonID )
        {
            this._PersonID = PersonID;
           
            InitializeComponent();
        }

        private void FrmPersonDetails_Load(object sender, EventArgs e)
        {
          
            ctrlUserDetails1.LoadPersonInfo(_PersonID);
        }
    }
}
