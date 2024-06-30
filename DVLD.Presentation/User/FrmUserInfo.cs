using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Presentation.User
{
    public partial class FrmUserInfo : Form
    {

        int _UserID;
        public FrmUserInfo(int UserID)
        {
            _UserID = UserID;
            InitializeComponent();
        }

        private void ButtonCloseUserInfoForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmUserInfo_Load(object sender, EventArgs e)
        {
            ctrlUserCard1.LoadUserInfo(_UserID);
        }
    }
}
