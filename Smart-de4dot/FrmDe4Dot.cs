namespace Smart_de4dot;

public partial class FrmDe4Dot : Form
{
    public FrmDe4Dot()
    {
        InitializeComponent();
    }

    #region Load/Save

    private void FrmDe4Dot_Load(object sender, EventArgs e)
    {
        if (Program.Settings.ListDe4Dot is { Count: 0 }) return;
        LoadItems(dataList);
    }

    private static void LoadItems(DataGridView dataList)
    {
        dataList.DataSource = null;
        dataList.Rows.Clear();
        foreach (var item in Program.Settings.ListDe4Dot)
        {
            dataList.Rows.Add(item.Name, item.Path, "...");
        }
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            var dialog = MessageBox.Show("Save Settings.\n\n" +
                                         "Click \"OK\" to confirm.\n\n" +
                                         "Click \"Cancel\" to cancel.",
                "Smart De4Dot",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                Program.Settings.ListDe4Dot = SaveItem(dataList);
                Program.Settings.Save();
                Close();
            }

            if (dialog == DialogResult.No)
            {
                Close();
            }
        }
        catch
        {
            //
        }
    }

    private static List<ItemInfo> SaveItem(DataGridView dataList)
    {
        return (from DataGridViewRow data in dataList.Rows
                select new ItemInfo
                {
                    Name = (string)data.Cells[0].Value,
                    Path = (string)data.Cells[1].Value
                }).ToList();
    }

    #endregion Load/Save

    #region Data List Manager

    private void dataList_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        var senderGrid = (DataGridView)sender;

        if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
        {
            var dialog = new FolderBrowserDialog();
            dialog.ShowNewFolderButton = true;
            dialog.Description = "Select De4dot directory";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (!De4DotFile(dialog.SelectedPath)) return;
                dataList.Rows[e.RowIndex].Cells[0].Value = "De4dot";
                dataList.Rows[e.RowIndex].Cells[1].Value = dialog.SelectedPath;
            }
        }
    }

    private static bool De4DotFile(string path)
    {
        if (!File.Exists(path + "\\de4dot.exe"))
        {
            MessageBox.Show("de4dot.exe not found, exiting...", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return false;
        }
        if (!File.Exists(path + "\\de4dot-x64.exe"))
        {
            MessageBox.Show("de4dot-x64.exe not found, exiting...", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        return true;
    }

    private void AddFunction()
    {
        dataList.Rows.Add("", "", "...");
    }

    private void dataList_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Delete)
        {
            RemoveRows();
        }
    }

    private void RemoveRows()
    {
        try
        {
            var selectedRowCount = dataList.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount != 0)
            {
                if (dataList.SelectedRows[0].Index > Program.Settings.ListDe4Dot.Count - 1)
                {
                    dataList.Rows.RemoveAt(dataList.SelectedRows[0].Index);
                    return;
                }

                var listRemove = new List<int>();
                for (var i = 0; i < selectedRowCount; i++)
                {
                    listRemove.Add(dataList.SelectedRows[i].Index);
                }

                foreach (var row in listRemove)
                {
                    Program.Settings.ListDe4Dot.RemoveAt(row);
                    dataList.Rows.RemoveAt(row);
                }

                dataList.ClearSelection();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void MoveUpDown(int type)
    {
        try
        {
            var selectedRowCount = dataList.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount != 0)
            {
                var selectedRows = dataList.SelectedRows[0].Index;
                var newIndex = type == 0 ? selectedRows - 1 : selectedRows + 1;
                var item = Program.Settings.ListDe4Dot[selectedRows];
                Program.Settings.ListDe4Dot.RemoveAt(selectedRows);
                Program.Settings.ListDe4Dot.Insert(newIndex, item);
                LoadItems(dataList);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void dataList_MouseDown(object sender, MouseEventArgs e)
    {
        var selectedRows = 0;
        var itemCount = 1;
        if (e.Button == MouseButtons.Right)
        {
            try
            {
                var hti = dataList.HitTest(e.X, e.Y);
                dataList.ClearSelection();
                dataList.Rows[hti.RowIndex].Selected = true;
                selectedRows = dataList.SelectedRows[0].Index;
                itemCount = dataList.RowCount - 1;
            }
            catch
            {
                //
            }
        }

        if (dataList.SelectedRows.Count > 0)
        {
            addToolStripMenuItem.Enabled = false;
            removeToolStripMenuItem.Enabled = true;
            moveUpToolStripMenuItem.Enabled = selectedRows != 0;
            moveDownToolStripMenuItem.Enabled = selectedRows != itemCount;
        }
        else
        {
            addToolStripMenuItem.Enabled = true;
            removeToolStripMenuItem.Enabled = false;
            moveUpToolStripMenuItem.Enabled = false;
            moveDownToolStripMenuItem.Enabled = false;
        }
    }

    #endregion Data List Manager

    #region ToolStripMenuItem

    private void addToolStripMenuItem_Click(object sender, EventArgs e)
    {
        AddFunction();
    }

    private void removeToolStripMenuItem_Click(object sender, EventArgs e)
    {
        RemoveRows();
    }

    private void moveUpToolStripMenuItem_Click(object sender, EventArgs e)
    {
        MoveUpDown(0);
    }

    private void moveDownToolStripMenuItem_Click(object sender, EventArgs e)
    {
        MoveUpDown(1);
    }

    #endregion ToolStripMenuItem
}