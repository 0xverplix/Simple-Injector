using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Simple_Injector.Etc;

namespace Simple_Injector
{
    public partial class Interface : Form
    {
        private readonly Config _config = new Config();

        private readonly DataTable _processTable = new DataTable();

        public Interface()
        {
            InitializeComponent();
        }

        private void Interface_Load(object sender, EventArgs e)
        {
            // Fill ProcessDataGrid

            _processTable.Columns.Add("Name", typeof(string));

            ProcessDataGrid.DataSource = _processTable;

            PopulateDataTable();

            // Sort the processes alphabetically

            ProcessDataGrid.Sort(ProcessDataGrid.Columns["Name"], ListSortDirection.Ascending);
        }

        private void PopulateDataTable()
        {
            var processes = Process.GetProcesses();


            foreach (var process in processes)
            {
                _processTable.Rows.Add(process.ProcessName);
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            _processTable.Rows.Clear();

            // Refresh the process list

            PopulateDataTable();

            // Scroll to the top

            ProcessDataGrid.CurrentCell = ProcessDataGrid.Rows[0].Cells[0];
        }

        private void ChooseDLLButton_Click(object sender, EventArgs e)
        {
            FileDialog.ShowDialog();
            
            // Get the path to the dll

            var dll = _config.DllPath = FileDialog.FileName;

            DLLFileTextBox.Text = Path.GetFileNameWithoutExtension(dll);

        }

        private void InjectDllButton_Click(object sender, EventArgs e)
        {
            // Inject the DLL

            var status = Program.Inject(_config);

            // Update the status text

            StatusLabel.Text = "";

            if (status.InjectionOutcome)
            {
                StatusLabel.Text += "Successfully Injected DLL" + Environment.NewLine + Environment.NewLine;
            }

            if (status.EraseHeadersOutcome)
            {
                StatusLabel.Text += "Successfully Erased PE Headers" + Environment.NewLine + Environment.NewLine;
            }
        }

        private void ProcessDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var process = ProcessDataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex];

            SelectedProcessTextBox.Text = _config.ProcessName = process.FormattedValue?.ToString();
        }

        private void MethodComboBox_TextChanged(object sender, EventArgs e)
        {
            _config.InjectionMethod = MethodComboBox.Text;
        }

        private void CloseAfterInjectCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _config.CloseAfterInject = CloseAfterInjectCheckBox.Checked;
        }

        private void EraseHeadersCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _config.EraseHeaders = EraseHeadersCheckBox.Checked;
        }
    }
}