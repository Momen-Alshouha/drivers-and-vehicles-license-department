using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Presentation.Login
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            SetPlaceholder(TextBoxLoginFormUserName, "User Name ...");
            SetPlaceholder(TextBoxLoginFormPassword, "Password ...");
        }

        private void SetPlaceholder(TextBox textBox, string placeholder)
        {
            // Set the initial placeholder text
            textBox.Text = placeholder;
            textBox.ForeColor = Color.Gray;

            // event handlers
            textBox.GotFocus += (sender, e) => RemovePlaceholder(textBox, placeholder);
            textBox.LostFocus += (sender, e) => AddPlaceholder(textBox, placeholder);
        }

        private void RemovePlaceholder(TextBox textBox, string placeholder)
        {
            if (textBox.Text == placeholder)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
            }
        }

        private void AddPlaceholder(TextBox textBox, string placeholder)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = placeholder;
                textBox.ForeColor = Color.Gray;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
