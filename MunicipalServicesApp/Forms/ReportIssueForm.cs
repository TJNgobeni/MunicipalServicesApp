using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using MunicipalServicesApp.Models;

namespace MunicipalServicesApp.Forms
{
    /// <summary>
    /// Lets a citizen report a municipal issue: location, category,
    /// description, and optional attachments. Includes the dynamic
    /// engagement feature (progress bar + encouraging messages) that
    /// implements the strategy selected and justified in Task 1: real-time
    /// feedback and gamified progress engagement.
    /// </summary>
    public partial class ReportIssueForm : Form
    {
        private readonly List<string> _attachmentPaths = new List<string>();

        public ReportIssueForm()
        {
            InitializeComponent();
            UpdateEngagementFeedback();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (var file in openFileDialog1.FileNames)
                {
                    if (!_attachmentPaths.Contains(file))
                    {
                        _attachmentPaths.Add(file);
                        lstAttachments.Items.Add(Path.GetFileName(file));
                    }
                }

                UpdateEngagementFeedback();
            }
        }

        private void OnFormFieldChanged(object sender, EventArgs e)
        {
            UpdateEngagementFeedback();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                return;
            }

            var issue = IssueRepository.Add(
                txtLocation.Text.Trim(),
                cmbCategory.SelectedItem.ToString(),
                rtbDescription.Text.Trim(),
                _attachmentPaths);

            MessageBox.Show(
                string.Format(
                    "Thank you! Your report (Reference #{0}) has been logged successfully.{1}{1}" +
                    "Our team will review it, and you will be able to check its progress once " +
                    "Service Request Status is available.",
                    issue.Id,
                    Environment.NewLine),
                "Report Submitted",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            ResetForm();
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtLocation.Text))
            {
                MessageBox.Show(
                    "Please enter the location of the issue.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtLocation.Focus();
                return false;
            }

            if (cmbCategory.SelectedItem == null)
            {
                MessageBox.Show(
                    "Please select a category for the issue.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                cmbCategory.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(rtbDescription.Text))
            {
                MessageBox.Show(
                    "Please provide a description of the issue.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                rtbDescription.Focus();
                return false;
            }

            return true;
        }

        private void ResetForm()
        {
            txtLocation.Clear();
            cmbCategory.SelectedIndex = -1;
            rtbDescription.Clear();
            lstAttachments.Items.Clear();
            _attachmentPaths.Clear();
            UpdateEngagementFeedback();
            txtLocation.Focus();
        }

        /// <summary>
        /// Drives the dynamic engagement feature: a progress bar and an
        /// encouraging message that update in real time as the user completes
        /// the four parts of the form (location, category, description,
        /// attachment). This gives the user immediate, visible feedback that
        /// their input is being registered, which is the engagement strategy
        /// chosen and justified in the Task 1 research document.
        /// </summary>
        private void UpdateEngagementFeedback()
        {
            const int totalSteps = 4;
            int completedSteps = 0;

            if (!string.IsNullOrWhiteSpace(txtLocation.Text)) completedSteps++;
            if (cmbCategory.SelectedItem != null) completedSteps++;
            if (!string.IsNullOrWhiteSpace(rtbDescription.Text)) completedSteps++;
            if (_attachmentPaths.Count > 0) completedSteps++;

            int percentage = (completedSteps * 100) / totalSteps;
            progressBarEngagement.Value = Math.Min(Math.Max(percentage, 0), 100);

            switch (completedSteps)
            {
                case 0:
                    lblEngagement.Text = "Let's get started - tell us where the problem is.";
                    break;
                case 1:
                    lblEngagement.Text = "Great start! Now choose a category for the issue.";
                    break;
                case 2:
                    lblEngagement.Text = "Good progress! Add a short description of the problem.";
                    break;
                case 3:
                    lblEngagement.Text = "Almost there! Attaching a photo helps us respond faster.";
                    break;
                case 4:
                    lblEngagement.Text = "All set - thank you for the detailed report! Click Submit.";
                    break;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
