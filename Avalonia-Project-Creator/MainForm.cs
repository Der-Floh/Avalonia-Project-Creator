using System.Diagnostics;

namespace Avalonia_Project_Creator;

public partial class MainForm : Form
{
    private string ProjectName
    {
        get => _projectName;
        set
        {
            _projectName = value;
            if (NewProjectNameTextBox.Text != value)
                NewProjectNameTextBox.Text = value;
            Properties.Settings.Default.ProjectName = value;
            Properties.Settings.Default.Save();

            NewProjectCreateButton.Enabled = !string.IsNullOrEmpty(ProjectName);
        }
    }
    private string _projectName;
    private string ProjectPath
    {
        get => _projectPath;
        set
        {
            if (string.IsNullOrEmpty(value))
                value = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            _projectPath = value;
            if (NewProjectLocationTextBox.Text != value)
                NewProjectLocationTextBox.Text = value;
            Properties.Settings.Default.ProjectPath = value;
            Properties.Settings.Default.Save();

            NewProjectCreateButton.Enabled = !string.IsNullOrEmpty(ProjectPath);
        }
    }
    private string _projectPath;
    private int ProjectType
    {
        get => _projectType;
        set
        {
            _projectType = value;
            if (NewProjectTypeComboBox.SelectedIndex != value)
                NewProjectTypeComboBox.SelectedIndex = value;
            Properties.Settings.Default.ProjectType = value;
            Properties.Settings.Default.Save();
        }
    }
    private int _projectType;
    private bool ProjectOpen
    {
        get => _projectOpen;
        set
        {
            _projectOpen = value;
            if (NewProjectOpenCheckBox.Checked != value)
                NewProjectOpenCheckBox.Checked = value;
            Properties.Settings.Default.ProjectOpen = value;
            Properties.Settings.Default.Save();
        }
    }
    private bool _projectOpen;
    private bool ProjectFolderOpen
    {
        get => _projectFolderOpen;
        set
        {
            _projectFolderOpen = value;
            if (NewProjectFolderOpenCheckBox.Checked != value)
                NewProjectFolderOpenCheckBox.Checked = value;
            Properties.Settings.Default.ProjectFolderOpen = value;
            Properties.Settings.Default.Save();
        }
    }
    private bool _projectFolderOpen;
    private bool AppClose
    {
        get => _appClose;
        set
        {
            _appClose = value;
            if (CloseCheckBox.Checked != value)
                CloseCheckBox.Checked = value;
            Properties.Settings.Default.AppClose = value;
            Properties.Settings.Default.Save();
        }
    }
    private bool _appClose;
    private System.Threading.Timer _timer;
    private string _spinners = "◜◠◝◞◡◟";
    private int spinnerIndex = 0;

    public MainForm()
    {
        InitializeComponent();
    }

    private void _timer_Tick(object? state)
    {
        SpinnerLabel.BeginInvoke(new Action(() =>
        {
            SpinnerLabel.Text = _spinners[spinnerIndex].ToString();
            spinnerIndex++;
            if (spinnerIndex >= _spinners.Length)
                spinnerIndex = 0;
        }));
    }

    private async Task<bool> ReinstallTemplates()
    {
        await ExecuteCommand("dotnet new uninstall Avalonia.Templates");
        bool success = await ExecuteCommand("dotnet new install Avalonia.Templates");
        return success;
    }

    private async Task<bool> CreateWindowsProject(string name, string path)
    {
        return await ExecuteCommand("dotnet new avalonia.app -o " + name, path);
    }

    private async Task<bool> CreateCrossPlatformProject(string name, string path)
    {
        path = Path.Combine(path, name);
        Directory.CreateDirectory(path);
        return await ExecuteCommand("dotnet new avalonia.xplat", path);
    }

    private string? SelectFolder(string? initialDirectory = null)
    {
        using FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
        if (!string.IsNullOrEmpty(initialDirectory))
            folderBrowserDialog.SelectedPath = initialDirectory;
        DialogResult result = folderBrowserDialog.ShowDialog();

        if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
            return folderBrowserDialog.SelectedPath;
        return null;
    }

    private async Task<bool> ExecuteCommand(string command, string? workingDirectory = null)
    {
        ProcessStartInfo startInfo = new ProcessStartInfo
        {
            FileName = "cmd.exe",
            Arguments = "/c " + command,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
            CreateNoWindow = true
        };
        if (!string.IsNullOrEmpty(workingDirectory))
            startInfo.WorkingDirectory = workingDirectory;

        using Process process = new Process { StartInfo = startInfo };
        process.Start();

        string output = process.StandardOutput.ReadToEnd();
        string error = process.StandardError.ReadToEnd();

        await process.WaitForExitAsync();

        return process.ExitCode == 0;
    }

    private bool OpenProject(string pName, string pPath)
    {
        string path = Path.Combine(pPath, pName, pName + ".sln");
        if (File.Exists(path))
        {
            try
            {
                Process.Start("explorer", "\"" + path + "\"");
                return true;
            }
            catch
            {
                DialogResult result = MessageBox.Show("Failed to open Project '" + pName + "'. Do you want to open the Folder instead?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (result == DialogResult.Yes)
                    return OpenProjectFolder(pName, pPath);
                else
                    return false;
            }
        }
        else
        {
            DialogResult result = MessageBox.Show("Failed to open Project '" + pName + "'. '" + pName + ".sln' doesn't exist. Do you want to open the Folder instead?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (result == DialogResult.Yes)
                return OpenProjectFolder(pName, pPath);
            else
                return false;
        }
    }

    private bool OpenProjectFolder(string pName, string pPath)
    {
        string path = Path.Combine(pPath, pName);
        if (Directory.Exists(path))
        {
            try
            {
                Process.Start("explorer", "\"" + path + "\"");
                return true;
            }
            catch
            {
                MessageBox.Show("Failed to open Folder '" + pName + "'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        else
            MessageBox.Show("Failed to open Folder '" + pName + "'. Folder doesn't exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return false;
    }

    private async Task<bool> HandleProjectCreation()
    {
        StartSpinner();
        bool success = false;
        switch (ProjectType)
        {
            case 0:
                success = await CreateCrossPlatformProject(ProjectName, ProjectPath);
                break;
            case 1:
                success = await CreateWindowsProject(ProjectName, ProjectPath);
                break;
        }

        if (success)
        {
            if (ProjectOpen)
                OpenProject(ProjectName, ProjectPath);
            else if (ProjectFolderOpen)
                OpenProjectFolder(ProjectName, ProjectPath);
        }

        StopSpinner();
        SpinnerLabel.BeginInvoke(new Action(() =>
        {
            if (success)
            {
                SpinnerLabel.ForeColor = Color.Green;
                SpinnerLabel.Text = "success";
            }
            else
            {
                SpinnerLabel.ForeColor = Color.Red;
                SpinnerLabel.Text = "failed";
            }
            SpinnerLabel.Visible = true;
        }));
        if (AppClose)
            BeginInvoke(new Action(Close));
        return success;
    }

    private void StartSpinner()
    {
        SpinnerLabel.BeginInvoke(new Action(() =>
        {
            SpinnerLabel.ForeColor = SystemColors.ControlText;
            SpinnerLabel.Text = _spinners[0].ToString();
            SpinnerLabel.Visible = true;
        }));
        _timer = new System.Threading.Timer(_timer_Tick, null, 0, 100);
    }

    private void StopSpinner()
    {
        SpinnerLabel.BeginInvoke(new Action(() => SpinnerLabel.Visible = false));
        _timer.Dispose();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        ProjectName = Properties.Settings.Default.ProjectName;
        ProjectPath = Properties.Settings.Default.ProjectPath;
        ProjectType = Properties.Settings.Default.ProjectType;
        ProjectOpen = Properties.Settings.Default.ProjectOpen;
        ProjectFolderOpen = Properties.Settings.Default.ProjectFolderOpen;
        AppClose = Properties.Settings.Default.AppClose;
    }

    private void NewProjectNameTextBox_TextChanged(object sender, EventArgs e)
    {
        ProjectName = NewProjectNameTextBox.Text;
    }

    private void NewProjectLocationPickButton_Click(object sender, EventArgs e)
    {
        ProjectPath = SelectFolder(Properties.Settings.Default.ProjectPath);
    }

    private void NewProjectTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        ProjectType = NewProjectTypeComboBox.SelectedIndex;
    }

    private void NewProjectOpenCheckBox_CheckedChanged(object sender, EventArgs e)
    {
        ProjectOpen = NewProjectOpenCheckBox.Checked;
    }

    private void NewProjectFolderOpenCheckBox_CheckedChanged(object sender, EventArgs e)
    {
        ProjectFolderOpen = NewProjectFolderOpenCheckBox.Checked;
    }

    private void CloseCheckBox_CheckedChanged(object sender, EventArgs e)
    {
        AppClose = CloseCheckBox.Checked;
    }

    private void NewProjectCreateButton_Click(object sender, EventArgs e)
    {
        Task.Run(HandleProjectCreation);
    }

    private void ReinstallTemplatesButton_Click(object sender, EventArgs e)
    {
        ReinstallTemplates();
    }
}
