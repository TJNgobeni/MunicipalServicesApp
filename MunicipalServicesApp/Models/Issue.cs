using System;
using System.Collections.Generic;

namespace MunicipalServicesApp.Models
{
    /// <summary>
    /// Represents a single municipal issue reported by a citizen through the
    /// "Report Issues" module of the Municipal Services Application.
    /// </summary>
    public class Issue
    {
        /// <summary>
        /// A sequential reference number assigned when the issue is stored.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The location of the reported issue, as typed by the user.
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// The category selected by the user (e.g. Sanitation, Roads, Utilities).
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// The detailed description of the issue provided by the user.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Full file paths of any images or documents the user attached.
        /// </summary>
        public List<string> AttachmentPaths { get; set; }

        /// <summary>
        /// The date and time the issue was submitted.
        /// </summary>
        public DateTime DateReported { get; set; }

        public Issue()
        {
            AttachmentPaths = new List<string>();
            DateReported = DateTime.Now;
        }

        public override string ToString()
        {
            return string.Format(
                "#{0} | {1} | {2} | {3:yyyy-MM-dd HH:mm}",
                Id, Category, Location, DateReported);
        }
    }
}
