namespace DVLD.Presentation.People.Controls
{
    partial class CtrlUserDetailsWithFilter
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GroupBoxUserDetailsFilter = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboBoxFilterBy = new System.Windows.Forms.ComboBox();
            this.TextBoxFilterValue = new System.Windows.Forms.TextBox();
            this.PictureBoxAddNewPerson = new System.Windows.Forms.PictureBox();
            this.PictureBoxSearchPerson = new System.Windows.Forms.PictureBox();
            this.ctrlUserDetails1 = new DVLD.Presentation.People.Controls.CtrlUserDetails();
            this.GroupBoxUserDetailsFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxAddNewPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSearchPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBoxUserDetailsFilter
            // 
            this.GroupBoxUserDetailsFilter.Controls.Add(this.PictureBoxAddNewPerson);
            this.GroupBoxUserDetailsFilter.Controls.Add(this.PictureBoxSearchPerson);
            this.GroupBoxUserDetailsFilter.Controls.Add(this.ComboBoxFilterBy);
            this.GroupBoxUserDetailsFilter.Controls.Add(this.TextBoxFilterValue);
            this.GroupBoxUserDetailsFilter.Controls.Add(this.label1);
            this.GroupBoxUserDetailsFilter.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxUserDetailsFilter.Location = new System.Drawing.Point(3, 15);
            this.GroupBoxUserDetailsFilter.Name = "GroupBoxUserDetailsFilter";
            this.GroupBoxUserDetailsFilter.Size = new System.Drawing.Size(831, 100);
            this.GroupBoxUserDetailsFilter.TabIndex = 1;
            this.GroupBoxUserDetailsFilter.TabStop = false;
            this.GroupBoxUserDetailsFilter.Text = "Filter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find By : ";
            // 
            // ComboBoxFilterBy
            // 
            this.ComboBoxFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxFilterBy.FormattingEnabled = true;
            this.ComboBoxFilterBy.Items.AddRange(new object[] {
            "National No",
            "Person ID"});
            this.ComboBoxFilterBy.Location = new System.Drawing.Point(123, 45);
            this.ComboBoxFilterBy.Name = "ComboBoxFilterBy";
            this.ComboBoxFilterBy.Size = new System.Drawing.Size(185, 37);
            this.ComboBoxFilterBy.TabIndex = 1;
            // 
            // TextBoxFilterValue
            // 
            this.TextBoxFilterValue.Location = new System.Drawing.Point(326, 45);
            this.TextBoxFilterValue.Name = "TextBoxFilterValue";
            this.TextBoxFilterValue.Size = new System.Drawing.Size(205, 37);
            this.TextBoxFilterValue.TabIndex = 2;
            // 
            // PictureBoxAddNewPerson
            // 
            this.PictureBoxAddNewPerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBoxAddNewPerson.Image = global::DVLD.Presentation.Properties.Resources.Add_Person_40;
            this.PictureBoxAddNewPerson.InitialImage = global::DVLD.Presentation.Properties.Resources.SearchPerson;
            this.PictureBoxAddNewPerson.Location = new System.Drawing.Point(620, 47);
            this.PictureBoxAddNewPerson.Name = "PictureBoxAddNewPerson";
            this.PictureBoxAddNewPerson.Size = new System.Drawing.Size(39, 38);
            this.PictureBoxAddNewPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxAddNewPerson.TabIndex = 4;
            this.PictureBoxAddNewPerson.TabStop = false;
            this.PictureBoxAddNewPerson.Click += new System.EventHandler(this.PictureBoxAddNewPerson_Click);
            // 
            // PictureBoxSearchPerson
            // 
            this.PictureBoxSearchPerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBoxSearchPerson.Image = global::DVLD.Presentation.Properties.Resources.SearchPerson;
            this.PictureBoxSearchPerson.InitialImage = global::DVLD.Presentation.Properties.Resources.SearchPerson;
            this.PictureBoxSearchPerson.Location = new System.Drawing.Point(562, 47);
            this.PictureBoxSearchPerson.Name = "PictureBoxSearchPerson";
            this.PictureBoxSearchPerson.Size = new System.Drawing.Size(39, 38);
            this.PictureBoxSearchPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxSearchPerson.TabIndex = 3;
            this.PictureBoxSearchPerson.TabStop = false;
            this.PictureBoxSearchPerson.Click += new System.EventHandler(this.PictureBoxSearchPerson_Click);
            // 
            // ctrlUserDetails1
            // 
            this.ctrlUserDetails1.Location = new System.Drawing.Point(0, 121);
            this.ctrlUserDetails1.Name = "ctrlUserDetails1";
            this.ctrlUserDetails1.Size = new System.Drawing.Size(832, 304);
            this.ctrlUserDetails1.TabIndex = 0;
            // 
            // CtrlUserDetailsWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GroupBoxUserDetailsFilter);
            this.Controls.Add(this.ctrlUserDetails1);
            this.Name = "CtrlUserDetailsWithFilter";
            this.Size = new System.Drawing.Size(839, 427);
            this.Load += new System.EventHandler(this.CtrlUserDetailsWithFilter_Load);
            this.GroupBoxUserDetailsFilter.ResumeLayout(false);
            this.GroupBoxUserDetailsFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxAddNewPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSearchPerson)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CtrlUserDetails ctrlUserDetails1;
        private System.Windows.Forms.GroupBox GroupBoxUserDetailsFilter;
        private System.Windows.Forms.ComboBox ComboBoxFilterBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxFilterValue;
        private System.Windows.Forms.PictureBox PictureBoxAddNewPerson;
        private System.Windows.Forms.PictureBox PictureBoxSearchPerson;
    }
}
