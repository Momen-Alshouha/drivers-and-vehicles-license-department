namespace DVLD.Presentation.Tests
{
    partial class FrmTakeTest
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
            this.RadioButtonPassTest = new System.Windows.Forms.RadioButton();
            this.RadioButtonFailTest = new System.Windows.Forms.RadioButton();
            this.LblResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RichTextBoxNoteOnResultTest = new System.Windows.Forms.RichTextBox();
            this.BtnSaveTakeTestFrm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RadioButtonPassTest
            // 
            this.RadioButtonPassTest.AutoSize = true;
            this.RadioButtonPassTest.Location = new System.Drawing.Point(177, 117);
            this.RadioButtonPassTest.Name = "RadioButtonPassTest";
            this.RadioButtonPassTest.Size = new System.Drawing.Size(65, 23);
            this.RadioButtonPassTest.TabIndex = 0;
            this.RadioButtonPassTest.TabStop = true;
            this.RadioButtonPassTest.Text = "Pass";
            this.RadioButtonPassTest.UseVisualStyleBackColor = true;
            // 
            // RadioButtonFailTest
            // 
            this.RadioButtonFailTest.AutoSize = true;
            this.RadioButtonFailTest.Location = new System.Drawing.Point(250, 118);
            this.RadioButtonFailTest.Name = "RadioButtonFailTest";
            this.RadioButtonFailTest.Size = new System.Drawing.Size(58, 23);
            this.RadioButtonFailTest.TabIndex = 1;
            this.RadioButtonFailTest.TabStop = true;
            this.RadioButtonFailTest.Text = "Fail";
            this.RadioButtonFailTest.UseVisualStyleBackColor = true;
            // 
            // LblResult
            // 
            this.LblResult.AutoSize = true;
            this.LblResult.Font = new System.Drawing.Font("Tahoma", 14F);
            this.LblResult.Location = new System.Drawing.Point(52, 106);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(119, 34);
            this.LblResult.TabIndex = 2;
            this.LblResult.Text = "Result : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label1.Location = new System.Drawing.Point(60, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "Notes :";
            // 
            // RichTextBoxNoteOnResultTest
            // 
            this.RichTextBoxNoteOnResultTest.Location = new System.Drawing.Point(168, 165);
            this.RichTextBoxNoteOnResultTest.Name = "RichTextBoxNoteOnResultTest";
            this.RichTextBoxNoteOnResultTest.Size = new System.Drawing.Size(315, 151);
            this.RichTextBoxNoteOnResultTest.TabIndex = 4;
            this.RichTextBoxNoteOnResultTest.Text = "";
            // 
            // BtnSaveTakeTestFrm
            // 
            this.BtnSaveTakeTestFrm.Location = new System.Drawing.Point(661, 353);
            this.BtnSaveTakeTestFrm.Name = "BtnSaveTakeTestFrm";
            this.BtnSaveTakeTestFrm.Size = new System.Drawing.Size(127, 62);
            this.BtnSaveTakeTestFrm.TabIndex = 5;
            this.BtnSaveTakeTestFrm.Text = "Save";
            this.BtnSaveTakeTestFrm.UseVisualStyleBackColor = true;
            this.BtnSaveTakeTestFrm.Click += new System.EventHandler(this.BtnSaveTakeTestFrm_Click);
            // 
            // FrmTakeTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSaveTakeTestFrm);
            this.Controls.Add(this.RichTextBoxNoteOnResultTest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblResult);
            this.Controls.Add(this.RadioButtonFailTest);
            this.Controls.Add(this.RadioButtonPassTest);
            this.Name = "FrmTakeTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Take Test";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmTakeTest_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RadioButtonPassTest;
        private System.Windows.Forms.RadioButton RadioButtonFailTest;
        private System.Windows.Forms.Label LblResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox RichTextBoxNoteOnResultTest;
        private System.Windows.Forms.Button BtnSaveTakeTestFrm;
    }
}