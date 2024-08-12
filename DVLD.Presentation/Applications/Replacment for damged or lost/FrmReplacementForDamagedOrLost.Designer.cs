namespace DVLD.Presentation.Applications.ReplacementForDamagedOrLost
{
    partial class FrmReplacementForDamagedOrLost
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
            this.LblReplacmentFrmTitle = new System.Windows.Forms.Label();
            this.groupBoxRadioDamagedOrLost = new System.Windows.Forms.GroupBox();
            this.radioButtonLost = new System.Windows.Forms.RadioButton();
            this.radioButtonDamaged = new System.Windows.Forms.RadioButton();
            this.linkLabelNewLicenseInfoReplacedOrDamaged = new System.Windows.Forms.LinkLabel();
            this.linkLabelShowLicensesHistory = new System.Windows.Forms.LinkLabel();
            this.BtnReplacmentOrDamagedApply = new System.Windows.Forms.Button();
            this.buttonFrmReplacementOrDamagedClose = new System.Windows.Forms.Button();
            this.ctrlApplicationNewLicenseInfo1 = new DVLD.Presentation.Controls.CtrlApplicationNewLicenseInfo();
            this.ctrlLicenseInfoDetailsWithFilter1 = new DVLD.Presentation.Controls.CtrlLicenseInfoDetailsWithFilter();
            this.groupBoxRadioDamagedOrLost.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblReplacmentFrmTitle
            // 
            this.LblReplacmentFrmTitle.AutoSize = true;
            this.LblReplacmentFrmTitle.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblReplacmentFrmTitle.ForeColor = System.Drawing.Color.Firebrick;
            this.LblReplacmentFrmTitle.Location = new System.Drawing.Point(389, 9);
            this.LblReplacmentFrmTitle.Name = "LblReplacmentFrmTitle";
            this.LblReplacmentFrmTitle.Size = new System.Drawing.Size(398, 31);
            this.LblReplacmentFrmTitle.TabIndex = 2;
            this.LblReplacmentFrmTitle.Text = "Replacment For Damaged Or Lost";
            // 
            // groupBoxRadioDamagedOrLost
            // 
            this.groupBoxRadioDamagedOrLost.Controls.Add(this.radioButtonLost);
            this.groupBoxRadioDamagedOrLost.Controls.Add(this.radioButtonDamaged);
            this.groupBoxRadioDamagedOrLost.Location = new System.Drawing.Point(483, 74);
            this.groupBoxRadioDamagedOrLost.Name = "groupBoxRadioDamagedOrLost";
            this.groupBoxRadioDamagedOrLost.Size = new System.Drawing.Size(372, 83);
            this.groupBoxRadioDamagedOrLost.TabIndex = 3;
            this.groupBoxRadioDamagedOrLost.TabStop = false;
            this.groupBoxRadioDamagedOrLost.Text = "Damaged Or Lost ?";
            // 
            // radioButtonLost
            // 
            this.radioButtonLost.AutoSize = true;
            this.radioButtonLost.Location = new System.Drawing.Point(179, 35);
            this.radioButtonLost.Name = "radioButtonLost";
            this.radioButtonLost.Size = new System.Drawing.Size(63, 23);
            this.radioButtonLost.TabIndex = 1;
            this.radioButtonLost.TabStop = true;
            this.radioButtonLost.Text = "Lost";
            this.radioButtonLost.UseVisualStyleBackColor = true;
            this.radioButtonLost.CheckedChanged += new System.EventHandler(this.radioButtonDamagedOrLost_CheckedChanged);
            // 
            // radioButtonDamaged
            // 
            this.radioButtonDamaged.AutoSize = true;
            this.radioButtonDamaged.Location = new System.Drawing.Point(16, 35);
            this.radioButtonDamaged.Name = "radioButtonDamaged";
            this.radioButtonDamaged.Size = new System.Drawing.Size(101, 23);
            this.radioButtonDamaged.TabIndex = 0;
            this.radioButtonDamaged.TabStop = true;
            this.radioButtonDamaged.Text = "Damaged";
            this.radioButtonDamaged.UseVisualStyleBackColor = true;
            this.radioButtonDamaged.CheckedChanged += new System.EventHandler(this.radioButtonDamagedOrLost_CheckedChanged);
            // 
            // linkLabelNewLicenseInfoReplacedOrDamaged
            // 
            this.linkLabelNewLicenseInfoReplacedOrDamaged.AutoSize = true;
            this.linkLabelNewLicenseInfoReplacedOrDamaged.Location = new System.Drawing.Point(738, 719);
            this.linkLabelNewLicenseInfoReplacedOrDamaged.Name = "linkLabelNewLicenseInfoReplacedOrDamaged";
            this.linkLabelNewLicenseInfoReplacedOrDamaged.Size = new System.Drawing.Size(174, 19);
            this.linkLabelNewLicenseInfoReplacedOrDamaged.TabIndex = 4;
            this.linkLabelNewLicenseInfoReplacedOrDamaged.TabStop = true;
            this.linkLabelNewLicenseInfoReplacedOrDamaged.Text = "Show New License Info";
            this.linkLabelNewLicenseInfoReplacedOrDamaged.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelNewLicenseInfoReplacedOrDamaged_LinkClicked);
            // 
            // linkLabelShowLicensesHistory
            // 
            this.linkLabelShowLicensesHistory.AutoSize = true;
            this.linkLabelShowLicensesHistory.Location = new System.Drawing.Point(738, 754);
            this.linkLabelShowLicensesHistory.Name = "linkLabelShowLicensesHistory";
            this.linkLabelShowLicensesHistory.Size = new System.Drawing.Size(166, 19);
            this.linkLabelShowLicensesHistory.TabIndex = 5;
            this.linkLabelShowLicensesHistory.TabStop = true;
            this.linkLabelShowLicensesHistory.Text = "Show Licenses History";
            this.linkLabelShowLicensesHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelShowLicensesHistory_LinkClicked);
            // 
            // BtnReplacmentOrDamagedApply
            // 
            this.BtnReplacmentOrDamagedApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReplacmentOrDamagedApply.Enabled = false;
            this.BtnReplacmentOrDamagedApply.Location = new System.Drawing.Point(738, 817);
            this.BtnReplacmentOrDamagedApply.Name = "BtnReplacmentOrDamagedApply";
            this.BtnReplacmentOrDamagedApply.Size = new System.Drawing.Size(139, 57);
            this.BtnReplacmentOrDamagedApply.TabIndex = 6;
            this.BtnReplacmentOrDamagedApply.Text = "Apply";
            this.BtnReplacmentOrDamagedApply.UseVisualStyleBackColor = true;
            this.BtnReplacmentOrDamagedApply.Click += new System.EventHandler(this.BtnReplacmentOrDamagedApply_Click);
            // 
            // buttonFrmReplacementOrDamagedClose
            // 
            this.buttonFrmReplacementOrDamagedClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFrmReplacementOrDamagedClose.Location = new System.Drawing.Point(904, 817);
            this.buttonFrmReplacementOrDamagedClose.Name = "buttonFrmReplacementOrDamagedClose";
            this.buttonFrmReplacementOrDamagedClose.Size = new System.Drawing.Size(139, 57);
            this.buttonFrmReplacementOrDamagedClose.TabIndex = 7;
            this.buttonFrmReplacementOrDamagedClose.Text = "Close";
            this.buttonFrmReplacementOrDamagedClose.UseVisualStyleBackColor = true;
            this.buttonFrmReplacementOrDamagedClose.Click += new System.EventHandler(this.buttonFrmReplacementOrDamagedClose_Click);
            // 
            // ctrlApplicationNewLicenseInfo1
            // 
            this.ctrlApplicationNewLicenseInfo1.Location = new System.Drawing.Point(12, 538);
            this.ctrlApplicationNewLicenseInfo1.Name = "ctrlApplicationNewLicenseInfo1";
            this.ctrlApplicationNewLicenseInfo1.Size = new System.Drawing.Size(720, 336);
            this.ctrlApplicationNewLicenseInfo1.TabIndex = 1;
            // 
            // ctrlLicenseInfoDetailsWithFilter1
            // 
            this.ctrlLicenseInfoDetailsWithFilter1.Location = new System.Drawing.Point(12, 58);
            this.ctrlLicenseInfoDetailsWithFilter1.Name = "ctrlLicenseInfoDetailsWithFilter1";
            this.ctrlLicenseInfoDetailsWithFilter1.Size = new System.Drawing.Size(1083, 474);
            this.ctrlLicenseInfoDetailsWithFilter1.TabIndex = 0;
            // 
            // FrmReplacementForDamagedOrLost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1099, 906);
            this.Controls.Add(this.buttonFrmReplacementOrDamagedClose);
            this.Controls.Add(this.BtnReplacmentOrDamagedApply);
            this.Controls.Add(this.linkLabelShowLicensesHistory);
            this.Controls.Add(this.linkLabelNewLicenseInfoReplacedOrDamaged);
            this.Controls.Add(this.groupBoxRadioDamagedOrLost);
            this.Controls.Add(this.LblReplacmentFrmTitle);
            this.Controls.Add(this.ctrlApplicationNewLicenseInfo1);
            this.Controls.Add(this.ctrlLicenseInfoDetailsWithFilter1);
            this.Name = "FrmReplacementForDamagedOrLost";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Replacment For Damaged Or Lost";
            this.groupBoxRadioDamagedOrLost.ResumeLayout(false);
            this.groupBoxRadioDamagedOrLost.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.CtrlLicenseInfoDetailsWithFilter ctrlLicenseInfoDetailsWithFilter1;
        private Controls.CtrlApplicationNewLicenseInfo ctrlApplicationNewLicenseInfo1;
        private System.Windows.Forms.Label LblReplacmentFrmTitle;
        private System.Windows.Forms.GroupBox groupBoxRadioDamagedOrLost;
        private System.Windows.Forms.RadioButton radioButtonLost;
        private System.Windows.Forms.RadioButton radioButtonDamaged;
        private System.Windows.Forms.LinkLabel linkLabelNewLicenseInfoReplacedOrDamaged;
        private System.Windows.Forms.LinkLabel linkLabelShowLicensesHistory;
        private System.Windows.Forms.Button BtnReplacmentOrDamagedApply;
        private System.Windows.Forms.Button buttonFrmReplacementOrDamagedClose;
    }
}