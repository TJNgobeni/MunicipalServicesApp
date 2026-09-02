using System;
using System.Windows.Forms;
using MunicipalServicesApp.Models;

namespace MunicipalServicesApp.Forms
{
    /// <summary>
    /// The application's main menu. Presents the three top-level tasks
    /// required by the brief: Report Issues (implemented), Local Events and
    /// Announcements (disabled, future phase), and Service Request Status
    /// (disabled, future phase).
    /// </summary>
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            RefreshFooter();
        }

        private void btnReportIssues_Click(object sender, EventArgs e)
        {
            using (var reportForm = new ReportIssueForm())
            {
                this.Hide();
                reportForm.ShowDialog();
                this.Show();
                RefreshFooter();
            }
        }

        /// <summary>
        /// Shows a small piece of ongoing feedback on the main menu itself,
        /// reinforcing the same "your input is being tracked" engagement idea
        /// used inside the Report Issues form.
        /// </summary>
        private void RefreshFooter()
        {
            lblFooter.Text = IssueRepository.Count == 0
                ? "No issues reported yet in this session."
                : string.Format(
                    "{0} issue(s) reported so far in this session. Thank you for helping improve our community!",
                    IssueRepository.Count);
        }
    }
}
