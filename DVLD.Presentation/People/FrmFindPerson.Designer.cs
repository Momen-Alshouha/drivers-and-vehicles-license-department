﻿namespace DVLD.Presentation.People
{
    partial class FrmFindPerson
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
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonCloseFindPersonForm = new System.Windows.Forms.Button();
            this.ctrlUserDetailsWithFilter1 = new DVLD.Presentation.People.Controls.CtrlPersonDetailsWithFilter();
            this.ctrlUserDetailsWithFilter2 = new DVLD.Presentation.People.Controls.CtrlPersonDetailsWithFilter();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(344, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find Person";
            // 
            // ButtonCloseFindPersonForm
            // 
            this.ButtonCloseFindPersonForm.Location = new System.Drawing.Point(726, 509);
            this.ButtonCloseFindPersonForm.Name = "ButtonCloseFindPersonForm";
            this.ButtonCloseFindPersonForm.Size = new System.Drawing.Size(134, 49);
            this.ButtonCloseFindPersonForm.TabIndex = 2;
            this.ButtonCloseFindPersonForm.Text = "Close";
            this.ButtonCloseFindPersonForm.UseVisualStyleBackColor = true;
            this.ButtonCloseFindPersonForm.Click += new System.EventHandler(this.ButtonCloseFindPersonForm_Click);
            // 
            // ctrlUserDetailsWithFilter1
            // 
            this.ctrlUserDetailsWithFilter1.Location = new System.Drawing.Point(21, 75);
            this.ctrlUserDetailsWithFilter1.Name = "ctrlUserDetailsWithFilter1";
            this.ctrlUserDetailsWithFilter1.Size = new System.Drawing.Size(839, 427);
            this.ctrlUserDetailsWithFilter1.TabIndex = 1;
            // 
            // ctrlUserDetailsWithFilter2
            // 
            this.ctrlUserDetailsWithFilter2.Location = new System.Drawing.Point(29, 83);
            this.ctrlUserDetailsWithFilter2.Name = "ctrlUserDetailsWithFilter2";
            this.ctrlUserDetailsWithFilter2.Size = new System.Drawing.Size(839, 427);
            this.ctrlUserDetailsWithFilter2.TabIndex = 3;
            // 
            // FrmFindPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 570);
            this.Controls.Add(this.ctrlUserDetailsWithFilter2);
            this.Controls.Add(this.ButtonCloseFindPersonForm);
            this.Controls.Add(this.ctrlUserDetailsWithFilter1);
            this.Controls.Add(this.label1);
            this.Name = "FrmFindPerson";
            this.Text = "FrmFindPerson";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Controls.CtrlPersonDetailsWithFilter ctrlUserDetailsWithFilter1;
        private System.Windows.Forms.Button ButtonCloseFindPersonForm;
        private Controls.CtrlPersonDetailsWithFilter ctrlUserDetailsWithFilter2;
    }
}