# Municipal Services Application — Report Issues Module

A C# .NET Framework Windows Forms application that lets citizens report
municipal issues (potholes, water leaks, illegal dumping, etc.) to their
local municipality. This is Part 1, Task 2 of the Portfolio of Evidence:
only the **Report Issues** feature is implemented; **Local Events and
Announcements** and **Service Request Status** are visible on the main
menu but disabled, as required by the brief.

## Requirements

- Windows 10/11
- Visual Studio 2019 or later (Community edition is fine), with the
  **".NET desktop development"** workload installed
- .NET Framework 4.8 Developer Pack (Visual Studio will prompt you to
  install this automatically if it is missing)

No third-party NuGet packages are used — the project only references the
standard .NET Framework Base Class Library (`System.Windows.Forms`,
`System.Drawing`, etc.), so there is nothing extra to restore.

## How to Compile and Run

1. Extract the ZIP file to a folder on your computer.
2. Double-click `MunicipalServicesApp.sln` to open the solution in Visual
   Studio (or open Visual Studio first and use **File → Open → Project/
   Solution**).
3. If prompted to install a missing component (e.g. the .NET Framework 4.8
   targeting pack), allow Visual Studio to install it.
4. Press **F5** (or click **Start**) to build and run the application.
   - You can also build only, without running, via
     **Build → Build Solution** (Ctrl+Shift+B).
   - The compiled executable will appear in
     `MunicipalServicesApp\bin\Debug\MunicipalServicesApp.exe`.

## How to Use the Application

1. **Main Menu** — On startup you'll see three options:
   - **Report Issues** — enabled, click to continue.
   - **Local Events and Announcements** — disabled (coming in a later
     phase of the project).
   - **Service Request Status** — disabled (coming in a later phase of
     the project).

2. **Report an Issue** — After clicking "Report Issues":
   - Type the **Location** of the issue in the textbox.
   - Choose a **Category** from the dropdown (Sanitation, Roads and
     Stormwater, Water and Electricity, Waste Management, Public Safety,
     Parks and Recreation, or Other).
   - Type a **Description** of the issue in the large text box.
   - Optionally click **Attach Image / Document** to open a file picker
     and attach one or more photos or documents related to the issue
     (multiple files can be selected at once).
   - As you fill in each field, watch the **progress bar and message**
     near the bottom of the form update in real time — this is the
     engagement feature described in Task 1 (real-time feedback and
     gamified progress), designed to reassure residents that their input
     is being registered as they type.
   - Click **Submit Report**. If any required field (location, category,
     description) is missing, you'll see a warning message telling you
     what to fill in. Once all required fields are complete, a
     confirmation message box shows your report's reference number.
   - Click **Back to Main Menu** at any time to return without submitting.

3. **Where your data goes** — Each submitted report is stored in memory
   for the lifetime of the running application (using a `List<Issue>`,
   see `Models/IssueRepository.cs`), and a line summarising it is also
   appended to a plain-text log file, `ReportedIssues.log`, created next
   to the compiled `.exe`, so a record survives after you close the
   program.

## Project Structure

```
MunicipalServicesApp.sln
MunicipalServicesApp/
├── App.config                       # Targets .NET Framework 4.8
├── Program.cs                       # Application entry point
├── Models/
│   ├── Issue.cs                     # Data model for a single reported issue
│   └── IssueRepository.cs           # In-memory List<Issue> + log-file writer
├── Forms/
│   ├── MainMenuForm.cs / .Designer.cs / .resx    # Startup menu (3 options)
│   └── ReportIssueForm.cs / .Designer.cs / .resx # Report Issues screen
└── Properties/
    └── AssemblyInfo.cs
```

## Design Notes

- **Engagement strategy**: the progress bar and encouraging label on the
  Report Issues form implement the "real-time feedback and gamified
  progress engagement" strategy selected and justified in the Task 1
  research document, chosen because it needs no internet connection, SMS
  gateway, or third-party service, and directly addresses the
  accountability gap identified in the research (residents rarely being
  told their input was received).
- **Data structure**: reported issues are stored in a `List<Issue>`
  because reports arrive one at a time, order of submission should be
  preserved, and the list needs to support fast iteration later when the
  Service Request Status module is built.
- **Validation**: Location, Category, and Description are required before
  a report can be submitted; attachments are optional.
- **Consistency**: both forms share the same colour scheme (dark green
  accents on white) and font (Segoe UI) for a consistent, familiar look.

## Known Limitations (by design, for this phase)

- Local Events and Announcements and Service Request Status are
  intentionally disabled — they are out of scope for this task.
- Reported issues persist only in memory while the application is
  running (plus the append-only text log); there is no database in this
  phase.
