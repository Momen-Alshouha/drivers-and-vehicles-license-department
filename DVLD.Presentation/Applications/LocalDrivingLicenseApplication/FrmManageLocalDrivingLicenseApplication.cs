﻿using System;
using System.Data;
using System.Windows.Forms;

namespace DVLD.Presentation.Applications.LocalDrivingLicenseApplication
{
    public partial class FrmManageLocalDrivingLicenseApplication : Form
    {
        DataTable LocalDrivingLicenseApplicationsData_View;

        public FrmManageLocalDrivingLicenseApplication()
        {
            InitializeComponent();
            _LoadDataInDataGridViewAndLoadNumberOfRecords();
            InitializeDataGridView();
            TextBoxFilterByManageLocalDrivingLicenseForm.TextChanged += TextBoxFilterByManageLocalDrivingLicenseForm_TextChanged;
        }

        private void _LoadDataInDataGridViewAndLoadNumberOfRecords()
        {
            this.LocalDrivingLicenseApplicationsData_View = BusinessLogic.ClsLocalDrivingLicenseApplication.GetAllLocalDrivingLicenseApplications_View();
            LblNumberOfApplications.Text = LocalDrivingLicenseApplicationsData_View.Rows.Count.ToString();
            DataGridViewLocalDrivingLicenseApplications_View.DataSource = LocalDrivingLicenseApplicationsData_View;
        }

        private void InitializeDataGridView()
        {
            DataGridViewLocalDrivingLicenseApplications_View.Columns[0].HeaderText = "L.D.L.AppID";
            DataGridViewLocalDrivingLicenseApplications_View.Columns[0].Width = 50;
        }

        private void PictureBoxAddNewLocalDrivingLicenseApplication_Click(object sender, EventArgs e)
        {
            FrmLocalDrivingLicenseApplication frmLocalDrivingLicenseApplication = new FrmLocalDrivingLicenseApplication();
            frmLocalDrivingLicenseApplication.ShowDialog();
            _LoadDataInDataGridViewAndLoadNumberOfRecords();
            ApplyFilter(); 
        }

        private void ComboBoxFilterByManageLocalDrivingLicenseForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxFilterByManageLocalDrivingLicenseForm.SelectedIndex != 0)
            {
                TextBoxFilterByManageLocalDrivingLicenseForm.Visible = true;
                ApplyFilter();
            }
            else
            {
                TextBoxFilterByManageLocalDrivingLicenseForm.Visible = false;
                TextBoxFilterByManageLocalDrivingLicenseForm.Clear();
                LocalDrivingLicenseApplicationsData_View.DefaultView.RowFilter = string.Empty;
                LblNumberOfApplications.Text = LocalDrivingLicenseApplicationsData_View.Rows.Count.ToString();
            }
        }

        private void TextBoxFilterByManageLocalDrivingLicenseForm_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void ApplyFilter()
        {
            string filterColumn = string.Empty;
            switch (ComboBoxFilterByManageLocalDrivingLicenseForm.SelectedItem.ToString())
            {
                case "L.D.L App ID":
                    filterColumn = "LocalDrivingLicenseApplicationID"; 
                    break;
                case "National No.":
                    filterColumn = "NationalNo";
                    break;
                case "Full Name":
                    filterColumn = "FullName"; 
                    break;
                case "Status":
                    filterColumn = "Status"; 
                    break;
                default:
                    filterColumn = string.Empty;
                    break;
            }

            // Reset the filters in case nothing is selected or the filter value contains nothing.
            if (TextBoxFilterByManageLocalDrivingLicenseForm.Text.Trim() == "" || filterColumn == string.Empty)
            {
                LocalDrivingLicenseApplicationsData_View.DefaultView.RowFilter = string.Empty;
                LblNumberOfApplications.Text = LocalDrivingLicenseApplicationsData_View.Rows.Count.ToString();
                return;
            }

            try
            {
                if (filterColumn == "LocalDrivingLicenseApplicationID")
                {
                    // In this case, we deal with integers
                    if (int.TryParse(TextBoxFilterByManageLocalDrivingLicenseForm.Text.Trim(), out int filterValue))
                    {
                        LocalDrivingLicenseApplicationsData_View.DefaultView.RowFilter = string.Format("[{0}] = {1}", filterColumn, filterValue);
                    }
                    else
                    {
                        LocalDrivingLicenseApplicationsData_View.DefaultView.RowFilter = "1 = 0"; // Invalid number filter, no matches
                    }
                }
                else
                {
                    LocalDrivingLicenseApplicationsData_View.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", filterColumn, TextBoxFilterByManageLocalDrivingLicenseForm.Text.Trim());
                }

                LblNumberOfApplications.Text = LocalDrivingLicenseApplicationsData_View.DefaultView.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while applying the filter: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}