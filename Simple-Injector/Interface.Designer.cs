namespace Simple_Injector
{
    partial class Interface
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.OpenProcessesGroupBox = new System.Windows.Forms.GroupBox();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.ProcessDataGrid = new System.Windows.Forms.DataGridView();
            this.InjectorGroupBox = new System.Windows.Forms.GroupBox();
            this.InjectDllButton = new System.Windows.Forms.Button();
            this.ChooseDLLButton = new System.Windows.Forms.Button();
            this.SelectedProcessTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DLLFileTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.EraseHeadersCheckBox = new System.Windows.Forms.CheckBox();
            this.CloseAfterInjectCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MethodComboBox = new System.Windows.Forms.ComboBox();
            this.StatusGroupBox = new System.Windows.Forms.GroupBox();
            this.FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.OpenProcessesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessDataGrid)).BeginInit();
            this.InjectorGroupBox.SuspendLayout();
            this.OptionsGroupBox.SuspendLayout();
            this.StatusGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(424, 44);
            this.TopPanel.TabIndex = 0;
            // 
            // OpenProcessesGroupBox
            // 
            this.OpenProcessesGroupBox.Controls.Add(this.RefreshButton);
            this.OpenProcessesGroupBox.Controls.Add(this.ProcessDataGrid);
            this.OpenProcessesGroupBox.Location = new System.Drawing.Point(12, 50);
            this.OpenProcessesGroupBox.Name = "OpenProcessesGroupBox";
            this.OpenProcessesGroupBox.Size = new System.Drawing.Size(193, 429);
            this.OpenProcessesGroupBox.TabIndex = 1;
            this.OpenProcessesGroupBox.TabStop = false;
            this.OpenProcessesGroupBox.Text = "Open Processes";
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.RefreshButton.Location = new System.Drawing.Point(6, 19);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(181, 23);
            this.RefreshButton.TabIndex = 3;
            this.RefreshButton.TabStop = false;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = false;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // ProcessDataGrid
            // 
            this.ProcessDataGrid.AllowUserToAddRows = false;
            this.ProcessDataGrid.AllowUserToDeleteRows = false;
            this.ProcessDataGrid.AllowUserToResizeColumns = false;
            this.ProcessDataGrid.AllowUserToResizeRows = false;
            this.ProcessDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProcessDataGrid.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.ProcessDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProcessDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ProcessDataGrid.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProcessDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.ProcessDataGrid.Location = new System.Drawing.Point(6, 48);
            this.ProcessDataGrid.Name = "ProcessDataGrid";
            this.ProcessDataGrid.ReadOnly = true;
            this.ProcessDataGrid.RowHeadersVisible = false;
            this.ProcessDataGrid.RowTemplate.ReadOnly = true;
            this.ProcessDataGrid.ShowCellErrors = false;
            this.ProcessDataGrid.ShowEditingIcon = false;
            this.ProcessDataGrid.ShowRowErrors = false;
            this.ProcessDataGrid.Size = new System.Drawing.Size(181, 375);
            this.ProcessDataGrid.TabIndex = 0;
            this.ProcessDataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProcessDataGrid_CellDoubleClick);
            // 
            // InjectorGroupBox
            // 
            this.InjectorGroupBox.Controls.Add(this.InjectDllButton);
            this.InjectorGroupBox.Controls.Add(this.ChooseDLLButton);
            this.InjectorGroupBox.Controls.Add(this.SelectedProcessTextBox);
            this.InjectorGroupBox.Controls.Add(this.label2);
            this.InjectorGroupBox.Controls.Add(this.DLLFileTextBox);
            this.InjectorGroupBox.Controls.Add(this.label1);
            this.InjectorGroupBox.Location = new System.Drawing.Point(219, 50);
            this.InjectorGroupBox.Name = "InjectorGroupBox";
            this.InjectorGroupBox.Size = new System.Drawing.Size(193, 138);
            this.InjectorGroupBox.TabIndex = 2;
            this.InjectorGroupBox.TabStop = false;
            this.InjectorGroupBox.Text = "Injector";
            // 
            // InjectDllButton
            // 
            this.InjectDllButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.InjectDllButton.Location = new System.Drawing.Point(98, 107);
            this.InjectDllButton.Name = "InjectDllButton";
            this.InjectDllButton.Size = new System.Drawing.Size(89, 23);
            this.InjectDllButton.TabIndex = 9;
            this.InjectDllButton.Text = "Inject DLL";
            this.InjectDllButton.UseVisualStyleBackColor = false;
            this.InjectDllButton.Click += new System.EventHandler(this.InjectDllButton_Click);
            // 
            // ChooseDLLButton
            // 
            this.ChooseDLLButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ChooseDLLButton.Location = new System.Drawing.Point(6, 107);
            this.ChooseDLLButton.Name = "ChooseDLLButton";
            this.ChooseDLLButton.Size = new System.Drawing.Size(89, 23);
            this.ChooseDLLButton.TabIndex = 8;
            this.ChooseDLLButton.Text = "Choose DLL";
            this.ChooseDLLButton.UseVisualStyleBackColor = false;
            this.ChooseDLLButton.Click += new System.EventHandler(this.ChooseDLLButton_Click);
            // 
            // SelectedProcessTextBox
            // 
            this.SelectedProcessTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.SelectedProcessTextBox.Location = new System.Drawing.Point(6, 81);
            this.SelectedProcessTextBox.Name = "SelectedProcessTextBox";
            this.SelectedProcessTextBox.ReadOnly = true;
            this.SelectedProcessTextBox.Size = new System.Drawing.Size(181, 20);
            this.SelectedProcessTextBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Selected Process";
            // 
            // DLLFileTextBox
            // 
            this.DLLFileTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.DLLFileTextBox.Location = new System.Drawing.Point(6, 35);
            this.DLLFileTextBox.Name = "DLLFileTextBox";
            this.DLLFileTextBox.ReadOnly = true;
            this.DLLFileTextBox.Size = new System.Drawing.Size(181, 20);
            this.DLLFileTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "DLL File";
            // 
            // OptionsGroupBox
            // 
            this.OptionsGroupBox.Controls.Add(this.EraseHeadersCheckBox);
            this.OptionsGroupBox.Controls.Add(this.CloseAfterInjectCheckBox);
            this.OptionsGroupBox.Controls.Add(this.label3);
            this.OptionsGroupBox.Controls.Add(this.MethodComboBox);
            this.OptionsGroupBox.Location = new System.Drawing.Point(219, 194);
            this.OptionsGroupBox.Name = "OptionsGroupBox";
            this.OptionsGroupBox.Size = new System.Drawing.Size(193, 104);
            this.OptionsGroupBox.TabIndex = 3;
            this.OptionsGroupBox.TabStop = false;
            this.OptionsGroupBox.Text = "Options";
            // 
            // EraseHeadersCheckBox
            // 
            this.EraseHeadersCheckBox.AutoSize = true;
            this.EraseHeadersCheckBox.Location = new System.Drawing.Point(6, 82);
            this.EraseHeadersCheckBox.Name = "EraseHeadersCheckBox";
            this.EraseHeadersCheckBox.Size = new System.Drawing.Size(96, 17);
            this.EraseHeadersCheckBox.TabIndex = 4;
            this.EraseHeadersCheckBox.Text = "Erase Headers";
            this.EraseHeadersCheckBox.UseVisualStyleBackColor = true;
            this.EraseHeadersCheckBox.CheckedChanged += new System.EventHandler(this.EraseHeadersCheckBox_CheckedChanged);
            // 
            // CloseAfterInjectCheckBox
            // 
            this.CloseAfterInjectCheckBox.AutoSize = true;
            this.CloseAfterInjectCheckBox.Location = new System.Drawing.Point(6, 59);
            this.CloseAfterInjectCheckBox.Name = "CloseAfterInjectCheckBox";
            this.CloseAfterInjectCheckBox.Size = new System.Drawing.Size(106, 17);
            this.CloseAfterInjectCheckBox.TabIndex = 3;
            this.CloseAfterInjectCheckBox.Text = "Close After Inject";
            this.CloseAfterInjectCheckBox.UseVisualStyleBackColor = true;
            this.CloseAfterInjectCheckBox.CheckedChanged += new System.EventHandler(this.CloseAfterInjectCheckBox_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Injection Method";
            // 
            // MethodComboBox
            // 
            this.MethodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MethodComboBox.FormattingEnabled = true;
            this.MethodComboBox.Items.AddRange(new object[] {
            "CreateRemoteThread",
            "RtlCreateUserThread",
            "SetThreadContext"});
            this.MethodComboBox.Location = new System.Drawing.Point(6, 32);
            this.MethodComboBox.Name = "MethodComboBox";
            this.MethodComboBox.Size = new System.Drawing.Size(181, 21);
            this.MethodComboBox.TabIndex = 0;
            this.MethodComboBox.TextChanged += new System.EventHandler(this.MethodComboBox_TextChanged);
            // 
            // StatusGroupBox
            // 
            this.StatusGroupBox.Controls.Add(this.StatusLabel);
            this.StatusGroupBox.Location = new System.Drawing.Point(219, 304);
            this.StatusGroupBox.Name = "StatusGroupBox";
            this.StatusGroupBox.Size = new System.Drawing.Size(193, 175);
            this.StatusGroupBox.TabIndex = 0;
            this.StatusGroupBox.TabStop = false;
            this.StatusGroupBox.Text = "Status";
            // 
            // FileDialog
            // 
            this.FileDialog.Filter = "Dynamic Link Library (*.dll)| *.dll";
            this.FileDialog.InitialDirectory = "@\"C:\\\"";
            this.FileDialog.Title = "Choose a DLL";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(7, 16);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 13);
            this.StatusLabel.TabIndex = 0;
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 491);
            this.Controls.Add(this.StatusGroupBox);
            this.Controls.Add(this.OptionsGroupBox);
            this.Controls.Add(this.InjectorGroupBox);
            this.Controls.Add(this.OpenProcessesGroupBox);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Interface";
            this.ShowIcon = false;
            this.Text = "Simple Injector";
            this.Load += new System.EventHandler(this.Interface_Load);
            this.OpenProcessesGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProcessDataGrid)).EndInit();
            this.InjectorGroupBox.ResumeLayout(false);
            this.InjectorGroupBox.PerformLayout();
            this.OptionsGroupBox.ResumeLayout(false);
            this.OptionsGroupBox.PerformLayout();
            this.StatusGroupBox.ResumeLayout(false);
            this.StatusGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.GroupBox OpenProcessesGroupBox;
        private System.Windows.Forms.GroupBox InjectorGroupBox;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.DataGridView ProcessDataGrid;
        private System.Windows.Forms.GroupBox OptionsGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DLLFileTextBox;
        private System.Windows.Forms.TextBox SelectedProcessTextBox;
        private System.Windows.Forms.Button InjectDllButton;
        private System.Windows.Forms.Button ChooseDLLButton;
        private System.Windows.Forms.CheckBox CloseAfterInjectCheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox MethodComboBox;
        private System.Windows.Forms.GroupBox StatusGroupBox;
        private System.Windows.Forms.OpenFileDialog FileDialog;
        private System.Windows.Forms.CheckBox EraseHeadersCheckBox;
        private System.Windows.Forms.Label StatusLabel;
    }
}

