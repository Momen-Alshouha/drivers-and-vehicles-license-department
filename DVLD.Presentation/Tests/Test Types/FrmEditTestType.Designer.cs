namespace DVLD.Presentation.Tests.Test_Types
{
    partial class FrmEditTestType
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
            this.LblEditTestTypeFormTitle = new System.Windows.Forms.Label();
            this.LblTestTypeNameTitle = new System.Windows.Forms.Label();
            this.LblTestTypeID = new System.Windows.Forms.Label();
            this.LblTestTypeName = new System.Windows.Forms.Label();
            this.LblTestTypeDescription = new System.Windows.Forms.Label();
            this.TextBoxTestTypeIDValue = new System.Windows.Forms.TextBox();
            this.TextBoxTestTypeNameValue = new System.Windows.Forms.TextBox();
            this.TextBoxTestTypeDescriptionValue = new System.Windows.Forms.RichTextBox();
            this.BtnEditTestTypeFormSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblEditTestTypeFormTitle
            // 
            this.LblEditTestTypeFormTitle.AutoSize = true;
            this.LblEditTestTypeFormTitle.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEditTestTypeFormTitle.Location = new System.Drawing.Point(156, 9);
            this.LblEditTestTypeFormTitle.Name = "LblEditTestTypeFormTitle";
            this.LblEditTestTypeFormTitle.Size = new System.Drawing.Size(42, 22);
            this.LblEditTestTypeFormTitle.TabIndex = 0;
            this.LblEditTestTypeFormTitle.Text = "Edit";
            // 
            // LblTestTypeNameTitle
            // 
            this.LblTestTypeNameTitle.AutoSize = true;
            this.LblTestTypeNameTitle.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTestTypeNameTitle.Location = new System.Drawing.Point(199, 9);
            this.LblTestTypeNameTitle.Name = "LblTestTypeNameTitle";
            this.LblTestTypeNameTitle.Size = new System.Drawing.Size(25, 22);
            this.LblTestTypeNameTitle.TabIndex = 1;
            this.LblTestTypeNameTitle.Text = "...";
            // 
            // LblTestTypeID
            // 
            this.LblTestTypeID.AutoSize = true;
            this.LblTestTypeID.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTestTypeID.Location = new System.Drawing.Point(85, 56);
            this.LblTestTypeID.Name = "LblTestTypeID";
            this.LblTestTypeID.Size = new System.Drawing.Size(43, 22);
            this.LblTestTypeID.TabIndex = 2;
            this.LblTestTypeID.Text = "ID : ";
            // 
            // LblTestTypeName
            // 
            this.LblTestTypeName.AutoSize = true;
            this.LblTestTypeName.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTestTypeName.Location = new System.Drawing.Point(55, 95);
            this.LblTestTypeName.Name = "LblTestTypeName";
            this.LblTestTypeName.Size = new System.Drawing.Size(73, 22);
            this.LblTestTypeName.TabIndex = 3;
            this.LblTestTypeName.Text = "Name : ";
            // 
            // LblTestTypeDescription
            // 
            this.LblTestTypeDescription.AutoSize = true;
            this.LblTestTypeDescription.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTestTypeDescription.Location = new System.Drawing.Point(9, 139);
            this.LblTestTypeDescription.Name = "LblTestTypeDescription";
            this.LblTestTypeDescription.Size = new System.Drawing.Size(119, 22);
            this.LblTestTypeDescription.TabIndex = 4;
            this.LblTestTypeDescription.Text = "Description : ";
            // 
            // TextBoxTestTypeIDValue
            // 
            this.TextBoxTestTypeIDValue.Enabled = false;
            this.TextBoxTestTypeIDValue.Location = new System.Drawing.Point(155, 56);
            this.TextBoxTestTypeIDValue.Name = "TextBoxTestTypeIDValue";
            this.TextBoxTestTypeIDValue.ReadOnly = true;
            this.TextBoxTestTypeIDValue.Size = new System.Drawing.Size(172, 20);
            this.TextBoxTestTypeIDValue.TabIndex = 5;
            // 
            // TextBoxTestTypeNameValue
            // 
            this.TextBoxTestTypeNameValue.Location = new System.Drawing.Point(155, 98);
            this.TextBoxTestTypeNameValue.Name = "TextBoxTestTypeNameValue";
            this.TextBoxTestTypeNameValue.Size = new System.Drawing.Size(172, 20);
            this.TextBoxTestTypeNameValue.TabIndex = 6;
            // 
            // TextBoxTestTypeDescriptionValue
            // 
            this.TextBoxTestTypeDescriptionValue.Location = new System.Drawing.Point(155, 139);
            this.TextBoxTestTypeDescriptionValue.Name = "TextBoxTestTypeDescriptionValue";
            this.TextBoxTestTypeDescriptionValue.Size = new System.Drawing.Size(172, 96);
            this.TextBoxTestTypeDescriptionValue.TabIndex = 7;
            this.TextBoxTestTypeDescriptionValue.Text = "";
            // 
            // BtnEditTestTypeFormSave
            // 
            this.BtnEditTestTypeFormSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEditTestTypeFormSave.Location = new System.Drawing.Point(283, 252);
            this.BtnEditTestTypeFormSave.Name = "BtnEditTestTypeFormSave";
            this.BtnEditTestTypeFormSave.Size = new System.Drawing.Size(112, 51);
            this.BtnEditTestTypeFormSave.TabIndex = 8;
            this.BtnEditTestTypeFormSave.Text = "Save";
            this.BtnEditTestTypeFormSave.UseVisualStyleBackColor = true;
            this.BtnEditTestTypeFormSave.Click += new System.EventHandler(this.BtnEditTestTypeFormSave_Click);
            // 
            // FrmEditTestType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 315);
            this.Controls.Add(this.BtnEditTestTypeFormSave);
            this.Controls.Add(this.TextBoxTestTypeDescriptionValue);
            this.Controls.Add(this.TextBoxTestTypeNameValue);
            this.Controls.Add(this.TextBoxTestTypeIDValue);
            this.Controls.Add(this.LblTestTypeDescription);
            this.Controls.Add(this.LblTestTypeName);
            this.Controls.Add(this.LblTestTypeID);
            this.Controls.Add(this.LblTestTypeNameTitle);
            this.Controls.Add(this.LblEditTestTypeFormTitle);
            this.Name = "FrmEditTestType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Test Type";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblEditTestTypeFormTitle;
        private System.Windows.Forms.Label LblTestTypeNameTitle;
        private System.Windows.Forms.Label LblTestTypeID;
        private System.Windows.Forms.Label LblTestTypeName;
        private System.Windows.Forms.Label LblTestTypeDescription;
        private System.Windows.Forms.TextBox TextBoxTestTypeIDValue;
        private System.Windows.Forms.TextBox TextBoxTestTypeNameValue;
        private System.Windows.Forms.RichTextBox TextBoxTestTypeDescriptionValue;
        private System.Windows.Forms.Button BtnEditTestTypeFormSave;
    }
}