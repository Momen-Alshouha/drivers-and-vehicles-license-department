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
namespace DVLD.Presentation.Tests.Test_Types
{
    public partial class FrmEditTestType : Form
    {
        StTestType TestType;
        public FrmEditTestType(int TestTypeID)
        {
            TestType = BusinessLogic.ClsTestType.GetTestType(TestTypeID);
            InitializeComponent();
            _SetFormValues();
        }

        void _SetFormValues()
        {
            TextBoxTestTypeIDValue.Text = TestType.id.ToString();
            TextBoxTestTypeDescriptionValue.Text = TestType.description.ToString();
            TextBoxTestTypeNameValue.Text = TestType.title.ToString();
            LblTestTypeNameTitle.Text = TestType.title.ToString();
        }

        void _SetNewTestTypeValues()
        {
            TestType.title = TextBoxTestTypeNameValue.Text;
            TestType.description = TextBoxTestTypeDescriptionValue.Text;
        }

        private void BtnEditTestTypeFormSave_Click(object sender, EventArgs e)
        {
            _SetNewTestTypeValues();
            if (BusinessLogic.ClsTestType.Update(TestType))
            {
                MessageBox.Show("Test Type Updated Successfully!", "Update Test Type", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else {

                MessageBox.Show("Somthing Wrong Happened!", "Update Test Type", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            };
            this.Close();
        }
    }
}
