namespace MunicipalServicesApp.Forms
{
    partial class ReportIssueForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.btnAttach = new System.Windows.Forms.Button();
            this.lstAttachments = new System.Windows.Forms.ListBox();
            this.lblEngagement = new System.Windows.Forms.Label();
            this.progressBarEngagement = new System.Windows.Forms.ProgressBar();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            //
            // lblTitle
            //
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(0, 78, 56);
            this.lblTitle.Location = new System.Drawing.Point(24, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(200, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Report an Issue";
            //
            // lblLocation
            //
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(28, 66);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(55, 15);
            this.lblLocation.TabIndex = 1;
            this.lblLocation.Text = "Location:";
            //
            // txtLocation
            //
            this.txtLocation.Location = new System.Drawing.Point(28, 84);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(500, 23);
            this.txtLocation.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtLocation, "e.g. 12 Main Road, Ward 4, Springfield");
            this.txtLocation.TextChanged += new System.EventHandler(this.OnFormFieldChanged);
            //
            // lblCategory
            //
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(28, 120);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(58, 15);
            this.lblCategory.TabIndex = 3;
            this.lblCategory.Text = "Category:";
            //
            // cmbCategory
            //
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Sanitation",
            "Roads and Stormwater",
            "Water and Electricity (Utilities)",
            "Waste Management",
            "Public Safety",
            "Parks and Recreation",
            "Other"});
            this.cmbCategory.Location = new System.Drawing.Point(28, 138);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(260, 23);
            this.cmbCategory.TabIndex = 4;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.OnFormFieldChanged);
            //
            // lblDescription
            //
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(28, 174);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(120, 15);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Description of issue:";
            //
            // rtbDescription
            //
            this.rtbDescription.Location = new System.Drawing.Point(28, 192);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(500, 110);
            this.rtbDescription.TabIndex = 6;
            this.rtbDescription.Text = "";
            this.rtbDescription.TextChanged += new System.EventHandler(this.OnFormFieldChanged);
            //
            // btnAttach
            //
            this.btnAttach.Location = new System.Drawing.Point(28, 314);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Size = new System.Drawing.Size(180, 30);
            this.btnAttach.TabIndex = 7;
            this.btnAttach.Text = "Attach Image / Document";
            this.btnAttach.UseVisualStyleBackColor = true;
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
            //
            // lstAttachments
            //
            this.lstAttachments.FormattingEnabled = true;
            this.lstAttachments.ItemHeight = 15;
            this.lstAttachments.Location = new System.Drawing.Point(220, 314);
            this.lstAttachments.Name = "lstAttachments";
            this.lstAttachments.Size = new System.Drawing.Size(308, 64);
            this.lstAttachments.TabIndex = 8;
            //
            // lblEngagement
            //
            this.lblEngagement.AutoSize = true;
            this.lblEngagement.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblEngagement.ForeColor = System.Drawing.Color.FromArgb(0, 120, 86);
            this.lblEngagement.Location = new System.Drawing.Point(28, 392);
            this.lblEngagement.Name = "lblEngagement";
            this.lblEngagement.Size = new System.Drawing.Size(300, 15);
            this.lblEngagement.TabIndex = 9;
            this.lblEngagement.Text = "Let\'s get started - tell us where the problem is.";
            //
            // progressBarEngagement
            //
            this.progressBarEngagement.Location = new System.Drawing.Point(28, 412);
            this.progressBarEngagement.Name = "progressBarEngagement";
            this.progressBarEngagement.Size = new System.Drawing.Size(500, 20);
            this.progressBarEngagement.TabIndex = 10;
            //
            // btnSubmit
            //
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(0, 120, 86);
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(28, 448);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(160, 40);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "Submit Report";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            //
            // btnBack
            //
            this.btnBack.Location = new System.Drawing.Point(368, 448);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(160, 40);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Back to Main Menu";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            //
            // openFileDialog1
            //
            this.openFileDialog1.Filter = "Images and Documents|*.jpg;*.jpeg;*.png;*.bmp;*.gif;*.pdf;*.doc;*.docx;*.txt|All files|*.*";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.Title = "Attach images or documents related to the issue";
            //
            // ReportIssueForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(556, 512);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.progressBarEngagement);
            this.Controls.Add(this.lblEngagement);
            this.Controls.Add(this.lstAttachments);
            this.Controls.Add(this.btnAttach);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(572, 551);
            this.Name = "ReportIssueForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report Issues - Municipal Services Application";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Button btnAttach;
        private System.Windows.Forms.ListBox lstAttachments;
        private System.Windows.Forms.Label lblEngagement;
        private System.Windows.Forms.ProgressBar progressBarEngagement;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
