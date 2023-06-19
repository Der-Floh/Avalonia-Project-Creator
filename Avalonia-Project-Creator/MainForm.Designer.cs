namespace Avalonia_Project_Creator;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        ReinstallTemplatesButton = new Button();
        NewProjectCreateButton = new Button();
        NewProjectLocationPickButton = new Button();
        NewProjectLocationLabel = new Label();
        NewProjectLocationTextBox = new TextBox();
        NewProjectTypeComboBox = new ComboBox();
        NewProjectPanel = new Panel();
        SpinnerLabel = new Label();
        NewProjectFolderOpenCheckBox = new CheckBox();
        NewProjectOpenCheckBox = new CheckBox();
        NewProjectTypeLabel = new Label();
        NewProjectNameLabel = new Label();
        NewProjectNameTextBox = new TextBox();
        NewProjectLabel = new Label();
        CloseCheckBox = new CheckBox();
        NewProjectPanel.SuspendLayout();
        SuspendLayout();
        // 
        // ReinstallTemplatesButton
        // 
        ReinstallTemplatesButton.Cursor = Cursors.Hand;
        ReinstallTemplatesButton.Location = new Point(12, 12);
        ReinstallTemplatesButton.Name = "ReinstallTemplatesButton";
        ReinstallTemplatesButton.Size = new Size(180, 44);
        ReinstallTemplatesButton.TabIndex = 0;
        ReinstallTemplatesButton.Text = "Reinstall Avalonia Templates";
        ReinstallTemplatesButton.UseVisualStyleBackColor = true;
        ReinstallTemplatesButton.Click += ReinstallTemplatesButton_Click;
        // 
        // NewProjectCreateButton
        // 
        NewProjectCreateButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        NewProjectCreateButton.Cursor = Cursors.Hand;
        NewProjectCreateButton.Location = new Point(328, 238);
        NewProjectCreateButton.Name = "NewProjectCreateButton";
        NewProjectCreateButton.Size = new Size(97, 34);
        NewProjectCreateButton.TabIndex = 1;
        NewProjectCreateButton.Text = "Create Project";
        NewProjectCreateButton.UseVisualStyleBackColor = true;
        NewProjectCreateButton.Click += NewProjectCreateButton_Click;
        // 
        // NewProjectLocationPickButton
        // 
        NewProjectLocationPickButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        NewProjectLocationPickButton.Cursor = Cursors.Hand;
        NewProjectLocationPickButton.Location = new Point(360, 106);
        NewProjectLocationPickButton.Name = "NewProjectLocationPickButton";
        NewProjectLocationPickButton.Size = new Size(65, 23);
        NewProjectLocationPickButton.TabIndex = 2;
        NewProjectLocationPickButton.Text = "Browse";
        NewProjectLocationPickButton.UseVisualStyleBackColor = true;
        NewProjectLocationPickButton.Click += NewProjectLocationPickButton_Click;
        // 
        // NewProjectLocationLabel
        // 
        NewProjectLocationLabel.AutoSize = true;
        NewProjectLocationLabel.Location = new Point(3, 88);
        NewProjectLocationLabel.Name = "NewProjectLocationLabel";
        NewProjectLocationLabel.Size = new Size(103, 15);
        NewProjectLocationLabel.TabIndex = 3;
        NewProjectLocationLabel.Text = "Destination Folder";
        // 
        // NewProjectLocationTextBox
        // 
        NewProjectLocationTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        NewProjectLocationTextBox.Location = new Point(3, 106);
        NewProjectLocationTextBox.Name = "NewProjectLocationTextBox";
        NewProjectLocationTextBox.ReadOnly = true;
        NewProjectLocationTextBox.Size = new Size(351, 23);
        NewProjectLocationTextBox.TabIndex = 4;
        // 
        // NewProjectTypeComboBox
        // 
        NewProjectTypeComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        NewProjectTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        NewProjectTypeComboBox.FormattingEnabled = true;
        NewProjectTypeComboBox.Items.AddRange(new object[] { "Cross-Platform Application", "Windows Application" });
        NewProjectTypeComboBox.Location = new Point(3, 166);
        NewProjectTypeComboBox.Name = "NewProjectTypeComboBox";
        NewProjectTypeComboBox.Size = new Size(203, 23);
        NewProjectTypeComboBox.TabIndex = 6;
        NewProjectTypeComboBox.SelectedIndexChanged += NewProjectTypeComboBox_SelectedIndexChanged;
        // 
        // NewProjectPanel
        // 
        NewProjectPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        NewProjectPanel.BorderStyle = BorderStyle.FixedSingle;
        NewProjectPanel.Controls.Add(SpinnerLabel);
        NewProjectPanel.Controls.Add(NewProjectFolderOpenCheckBox);
        NewProjectPanel.Controls.Add(NewProjectOpenCheckBox);
        NewProjectPanel.Controls.Add(NewProjectTypeLabel);
        NewProjectPanel.Controls.Add(NewProjectTypeComboBox);
        NewProjectPanel.Controls.Add(NewProjectCreateButton);
        NewProjectPanel.Controls.Add(NewProjectNameLabel);
        NewProjectPanel.Controls.Add(NewProjectNameTextBox);
        NewProjectPanel.Controls.Add(NewProjectLabel);
        NewProjectPanel.Controls.Add(NewProjectLocationPickButton);
        NewProjectPanel.Controls.Add(NewProjectLocationTextBox);
        NewProjectPanel.Controls.Add(NewProjectLocationLabel);
        NewProjectPanel.Location = new Point(12, 62);
        NewProjectPanel.Name = "NewProjectPanel";
        NewProjectPanel.Size = new Size(430, 277);
        NewProjectPanel.TabIndex = 7;
        // 
        // SpinnerLabel
        // 
        SpinnerLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        SpinnerLabel.Location = new Point(229, 248);
        SpinnerLabel.Name = "SpinnerLabel";
        SpinnerLabel.Size = new Size(93, 15);
        SpinnerLabel.TabIndex = 13;
        SpinnerLabel.Text = "\\";
        SpinnerLabel.TextAlign = ContentAlignment.MiddleRight;
        SpinnerLabel.Visible = false;
        // 
        // NewProjectFolderOpenCheckBox
        // 
        NewProjectFolderOpenCheckBox.AutoSize = true;
        NewProjectFolderOpenCheckBox.Cursor = Cursors.Hand;
        NewProjectFolderOpenCheckBox.Location = new Point(5, 234);
        NewProjectFolderOpenCheckBox.Name = "NewProjectFolderOpenCheckBox";
        NewProjectFolderOpenCheckBox.Size = new Size(166, 19);
        NewProjectFolderOpenCheckBox.TabIndex = 12;
        NewProjectFolderOpenCheckBox.Text = "Open Folder after Creation";
        NewProjectFolderOpenCheckBox.UseVisualStyleBackColor = true;
        NewProjectFolderOpenCheckBox.CheckedChanged += NewProjectFolderOpenCheckBox_CheckedChanged;
        // 
        // NewProjectOpenCheckBox
        // 
        NewProjectOpenCheckBox.AutoSize = true;
        NewProjectOpenCheckBox.Cursor = Cursors.Hand;
        NewProjectOpenCheckBox.Location = new Point(5, 209);
        NewProjectOpenCheckBox.Name = "NewProjectOpenCheckBox";
        NewProjectOpenCheckBox.Size = new Size(170, 19);
        NewProjectOpenCheckBox.TabIndex = 8;
        NewProjectOpenCheckBox.Text = "Open Project after Creation";
        NewProjectOpenCheckBox.UseVisualStyleBackColor = true;
        NewProjectOpenCheckBox.CheckedChanged += NewProjectOpenCheckBox_CheckedChanged;
        // 
        // NewProjectTypeLabel
        // 
        NewProjectTypeLabel.AutoSize = true;
        NewProjectTypeLabel.Location = new Point(3, 148);
        NewProjectTypeLabel.Name = "NewProjectTypeLabel";
        NewProjectTypeLabel.Size = new Size(71, 15);
        NewProjectTypeLabel.TabIndex = 11;
        NewProjectTypeLabel.Text = "Project Type";
        // 
        // NewProjectNameLabel
        // 
        NewProjectNameLabel.AutoSize = true;
        NewProjectNameLabel.Location = new Point(3, 30);
        NewProjectNameLabel.Name = "NewProjectNameLabel";
        NewProjectNameLabel.Size = new Size(39, 15);
        NewProjectNameLabel.TabIndex = 10;
        NewProjectNameLabel.Text = "Name";
        // 
        // NewProjectNameTextBox
        // 
        NewProjectNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        NewProjectNameTextBox.Location = new Point(3, 48);
        NewProjectNameTextBox.Name = "NewProjectNameTextBox";
        NewProjectNameTextBox.Size = new Size(282, 23);
        NewProjectNameTextBox.TabIndex = 9;
        NewProjectNameTextBox.TextChanged += NewProjectNameTextBox_TextChanged;
        // 
        // NewProjectLabel
        // 
        NewProjectLabel.AutoSize = true;
        NewProjectLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        NewProjectLabel.Location = new Point(3, 2);
        NewProjectLabel.Name = "NewProjectLabel";
        NewProjectLabel.Size = new Size(76, 15);
        NewProjectLabel.TabIndex = 8;
        NewProjectLabel.Text = "New Project";
        // 
        // CloseCheckBox
        // 
        CloseCheckBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        CloseCheckBox.AutoSize = true;
        CloseCheckBox.Cursor = Cursors.Hand;
        CloseCheckBox.Location = new Point(312, 12);
        CloseCheckBox.Name = "CloseCheckBox";
        CloseCheckBox.Size = new Size(130, 19);
        CloseCheckBox.TabIndex = 13;
        CloseCheckBox.Text = "Close after Creation";
        CloseCheckBox.UseVisualStyleBackColor = true;
        CloseCheckBox.CheckedChanged += CloseCheckBox_CheckedChanged;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(454, 351);
        Controls.Add(CloseCheckBox);
        Controls.Add(NewProjectPanel);
        Controls.Add(ReinstallTemplatesButton);
        MinimumSize = new Size(470, 390);
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Avalonia Project Creator";
        Load += MainForm_Load;
        NewProjectPanel.ResumeLayout(false);
        NewProjectPanel.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button ReinstallTemplatesButton;
    private Button NewProjectCreateButton;
    private Button NewProjectLocationPickButton;
    private Label NewProjectLocationLabel;
    private TextBox NewProjectLocationTextBox;
    private ComboBox NewProjectTypeComboBox;
    private Panel NewProjectPanel;
    private Label NewProjectLabel;
    private Label NewProjectNameLabel;
    private TextBox NewProjectNameTextBox;
    private Label NewProjectTypeLabel;
    private CheckBox NewProjectOpenCheckBox;
    private CheckBox NewProjectFolderOpenCheckBox;
    private CheckBox CloseCheckBox;
    private Label SpinnerLabel;
}
