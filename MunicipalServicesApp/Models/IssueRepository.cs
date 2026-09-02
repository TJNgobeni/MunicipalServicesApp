using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MunicipalServicesApp.Models
{
    /// <summary>
    /// Provides simple, centralised storage for reported issues.
    ///
    /// A generic <see cref="List{T}"/> is used as the core data structure
    /// because reports are added one at a time, need to preserve the order in
    /// which they were submitted, and must support fast iteration when the
    /// "Service Request Status" module is implemented in a later phase.
    ///
    /// As a convenience, every submission is also appended to a plain text log
    /// file on disk so that a record of what was reported survives after the
    /// application is closed, even though the in-memory list itself only
    /// lasts for the current session.
    /// </summary>
    public static class IssueRepository
    {
        private static readonly List<Issue> _issues = new List<Issue>();
        private static readonly string LogFilePath =
            Path.Combine(GetStartupPathSafe(), "ReportedIssues.log");

        /// <summary>
        /// A read-only view of all issues reported during this session.
        /// </summary>
        public static IReadOnlyList<Issue> Issues
        {
            get { return _issues.AsReadOnly(); }
        }

        /// <summary>
        /// The number of issues reported so far in this session.
        /// </summary>
        public static int Count
        {
            get { return _issues.Count; }
        }

        /// <summary>
        /// Creates a new <see cref="Issue"/> from the supplied details, stores
        /// it, and appends a record of it to the log file.
        /// </summary>
        public static Issue Add(string location, string category, string description, IEnumerable<string> attachmentPaths)
        {
            var issue = new Issue
            {
                Id = _issues.Count + 1,
                Location = location,
                Category = category,
                Description = description,
                AttachmentPaths = attachmentPaths != null ? attachmentPaths.ToList() : new List<string>()
            };

            _issues.Add(issue);
            AppendToLog(issue);
            return issue;
        }

        private static void AppendToLog(Issue issue)
        {
            try
            {
                var line = new StringBuilder();
                line.Append(issue.Id).Append(" | ");
                line.Append(issue.DateReported.ToString("yyyy-MM-dd HH:mm")).Append(" | ");
                line.Append(issue.Category).Append(" | ");
                line.Append(issue.Location).Append(" | ");
                line.Append(issue.Description.Replace(Environment.NewLine, " ")).Append(" | ");
                line.Append("Attachments: ");
                line.Append(issue.AttachmentPaths.Count == 0
                    ? "None"
                    : string.Join(", ", issue.AttachmentPaths.Select(Path.GetFileName)));

                File.AppendAllText(LogFilePath, line + Environment.NewLine);
            }
            catch
            {
                // Writing the log file is a convenience feature only. A failure
                // here (e.g. a read-only folder) must never stop the issue from
                // being recorded in memory or block the user from submitting.
            }
        }

        private static string GetStartupPathSafe()
        {
            try
            {
                return System.Windows.Forms.Application.StartupPath;
            }
            catch
            {
                return AppDomain.CurrentDomain.BaseDirectory;
            }
        }
    }
}
