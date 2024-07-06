namespace DVLD.Presentation.People
{
    partial class FrmManagePeople
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvPeople = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.LblNumberOfPeople = new System.Windows.Forms.Label();
            this.contextMenuStripPeopleDataGridView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LblManagePeopleFormTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboBoxFilterByManagePeopleForm = new System.Windows.Forms.ComboBox();
            this.TextBoxFilterManagePeopleForm = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxAddPerson = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).BeginInit();
            this.contextMenuStripPeopleDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPeople
            // 
            this.dgvPeople.AllowUserToAddRows = false;
            this.dgvPeople.AllowUserToDeleteRows = false;
            this.dgvPeople.AllowUserToOrderColumns = true;
            this.dgvPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeople.Location = new System.Drawing.Point(13, 210);
            this.dgvPeople.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvPeople.MultiSelect = false;
            this.dgvPeople.Name = "dgvPeople";
            this.dgvPeople.ReadOnly = true;
            this.dgvPeople.RowHeadersWidth = 51;
            this.dgvPeople.RowTemplate.Height = 24;
            this.dgvPeople.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPeople.Size = new System.Drawing.Size(1148, 339);
            this.dgvPeople.StandardTab = true;
            this.dgvPeople.TabIndex = 0;
            this.dgvPeople.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvPeople_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 560);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "#Records :";
            // 
            // LblNumberOfPeople
            // 
            this.LblNumberOfPeople.AutoSize = true;
            this.LblNumberOfPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumberOfPeople.Location = new System.Drawing.Point(90, 560);
            this.LblNumberOfPeople.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNumberOfPeople.Name = "LblNumberOfPeople";
            this.LblNumberOfPeople.Size = new System.Drawing.Size(18, 20);
            this.LblNumberOfPeople.TabIndex = 2;
            this.LblNumberOfPeople.Text = "0";
            // 
            // contextMenuStripPeopleDataGridView
            // 
            this.contextMenuStripPeopleDataGridView.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripPeopleDataGridView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.editPersonToolStripMenuItem,
            this.addNewPersonToolStripMenuItem,
            this.deletePersonToolStripMenuItem});
            this.contextMenuStripPeopleDataGridView.Name = "contextMenuStripPeopleDataGridView";
            this.contextMenuStripPeopleDataGridView.Size = new System.Drawing.Size(163, 92);
            this.contextMenuStripPeopleDataGridView.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripPeopleDataGridView_Opening);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.showDetailsToolStripMenuItem.Text = "Show Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // editPersonToolStripMenuItem
            // 
            this.editPersonToolStripMenuItem.Name = "editPersonToolStripMenuItem";
            this.editPersonToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.editPersonToolStripMenuItem.Text = "Edit Person";
            this.editPersonToolStripMenuItem.Click += new System.EventHandler(this.editPersonToolStripMenuItem_Click);
            // 
            // addNewPersonToolStripMenuItem
            // 
            this.addNewPersonToolStripMenuItem.Name = "addNewPersonToolStripMenuItem";
            this.addNewPersonToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.addNewPersonToolStripMenuItem.Text = "Add New Person";
            this.addNewPersonToolStripMenuItem.Click += new System.EventHandler(this.addNewPersonToolStripMenuItem_Click);
            // 
            // deletePersonToolStripMenuItem
            // 
            this.deletePersonToolStripMenuItem.Name = "deletePersonToolStripMenuItem";
            this.deletePersonToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.deletePersonToolStripMenuItem.Text = "Delete Person";
            this.deletePersonToolStripMenuItem.Click += new System.EventHandler(this.deletePersonToolStripMenuItem_Click);
            // 
            // LblManagePeopleFormTitle
            // 
            this.LblManagePeopleFormTitle.AutoSize = true;
            this.LblManagePeopleFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblManagePeopleFormTitle.Location = new System.Drawing.Point(450, 156);
            this.LblManagePeopleFormTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblManagePeopleFormTitle.Name = "LblManagePeopleFormTitle";
            this.LblManagePeopleFormTitle.Size = new System.Drawing.Size(252, 37);
            this.LblManagePeopleFormTitle.TabIndex = 4;
            this.LblManagePeopleFormTitle.Text = "Manage People";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 167);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Filter By";
            // 
            // ComboBoxFilterByManagePeopleForm
            // 
            this.ComboBoxFilterByManagePeopleForm.DropDownHeight = 100;
            this.ComboBoxFilterByManagePeopleForm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxFilterByManagePeopleForm.FormattingEnabled = true;
            this.ComboBoxFilterByManagePeopleForm.IntegralHeight = false;
            this.ComboBoxFilterByManagePeopleForm.Items.AddRange(new object[] {
            "None",
            "Person ID",
            "National No.",
            "First Name",
            "Email",
            "Country Name"});
            this.ComboBoxFilterByManagePeopleForm.Location = new System.Drawing.Point(93, 171);
            this.ComboBoxFilterByManagePeopleForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ComboBoxFilterByManagePeopleForm.MinimumSize = new System.Drawing.Size(76, 0);
            this.ComboBoxFilterByManagePeopleForm.Name = "ComboBoxFilterByManagePeopleForm";
            this.ComboBoxFilterByManagePeopleForm.Size = new System.Drawing.Size(114, 21);
            this.ComboBoxFilterByManagePeopleForm.TabIndex = 7;
            this.ComboBoxFilterByManagePeopleForm.SelectedIndexChanged += new System.EventHandler(this.ComboBoxFilterByManagePeopleForm_SelectedIndexChanged);
            // 
            // TextBoxFilterManagePeopleForm
            // 
            this.TextBoxFilterManagePeopleForm.Location = new System.Drawing.Point(218, 171);
            this.TextBoxFilterManagePeopleForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextBoxFilterManagePeopleForm.Name = "TextBoxFilterManagePeopleForm";
            this.TextBoxFilterManagePeopleForm.Size = new System.Drawing.Size(119, 20);
            this.TextBoxFilterManagePeopleForm.TabIndex = 8;
            this.TextBoxFilterManagePeopleForm.Visible = false;
            this.TextBoxFilterManagePeopleForm.TextChanged += new System.EventHandler(this.TextBoxFilterManagePeopleForm_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Presentation.Properties.Resources.People_400;
            this.pictureBox1.Location = new System.Drawing.Point(499, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxAddPerson
            // 
            this.pictureBoxAddPerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxAddPerson.Image = global::DVLD.Presentation.Properties.Resources.Add_Person_72;
            this.pictureBoxAddPerson.Location = new System.Drawing.Point(1097, 146);
            this.pictureBoxAddPerson.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxAddPerson.Name = "pictureBoxAddPerson";
            this.pictureBoxAddPerson.Size = new System.Drawing.Size(50, 60);
            this.pictureBoxAddPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAddPerson.TabIndex = 3;
            this.pictureBoxAddPerson.TabStop = false;
            this.pictureBoxAddPerson.Click += new System.EventHandler(this.pictureBoxAddPerson_Click);
            // 
            // FrmManagePeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 620);
            this.Controls.Add(this.TextBoxFilterManagePeopleForm);
            this.Controls.Add(this.ComboBoxFilterByManagePeopleForm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LblManagePeopleFormTitle);
            this.Controls.Add(this.pictureBoxAddPerson);
            this.Controls.Add(this.LblNumberOfPeople);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPeople);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmManagePeople";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manage People";
            this.Load += new System.EventHandler(this.FrmManagePeople_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).EndInit();
            this.contextMenuStripPeopleDataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddPerson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPeople;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblNumberOfPeople;
        private System.Windows.Forms.PictureBox pictureBoxAddPerson;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripPeopleDataGridView;
        private System.Windows.Forms.ToolStripMenuItem editPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletePersonToolStripMenuItem;
        private System.Windows.Forms.Label LblManagePeopleFormTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboBoxFilterByManagePeopleForm;
        private System.Windows.Forms.TextBox TextBoxFilterManagePeopleForm;
    }
}