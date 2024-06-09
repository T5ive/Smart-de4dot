namespace Smart_de4dot;

public partial class FrmMain : Form
{
    #region Variable

    private static List<string> _commandLine = [];
    private Thread _thread;
    private Process _process;
    private static string? _de4dot;

    #endregion Variable

    public FrmMain(string[] args)
    {
        InitializeComponent();
        CheckForIllegalCrossThreadCalls = false;

        if (args is { Length: 0 }) return;
        txtFile.Text = args[0];
    }

    #region Load

    private void FrmMain_Load(object sender, EventArgs e)
    {
        Program.Settings = AppSettings.Load();
        UpdateList();
    }

    private void UpdateList()
    {
        if (Program.Settings.ListDe4Dot is { Count: 0 }) return;
        cbDe4dot.Items.Clear();
        foreach (var item in Program.Settings.ListDe4Dot)
        {
            cbDe4dot.Items.Add(item.Name);
        }
        cbDe4dot.SelectedIndex = 0;
    }

    #endregion Load

    #region Target

    private void btnBrowse_Click(object sender, EventArgs e)
    {
        var file = new OpenFileDialog();
        if (file.ShowDialog() != DialogResult.OK) return;
        txtFile.Text = file.FileName;
        GetDetail();
    }

    private void GetDetail()
    {
        var info = FileVersionInfo.GetVersionInfo(txtFile.Text);
        if (!File.Exists(txtFile.Text)) return;
        txtTargetInfo.Text = $"Name: [{info.ProductName}]" + Environment.NewLine +
                             $"Version: [{info.FileVersion}]";
    }

    #endregion Target

    #region Target Controller

    private void TargetOver(object sender, DragEventArgs e)
    {
        if (e.Data == null) return;
        e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.Move : DragDropEffects.None;
    }

    private void TargetDrop(object sender, DragEventArgs e)
    {
        if (e.Data == null) return;
        var files = (string[])e.Data.GetData(DataFormats.FileDrop);
        if (files is { Length: 0 }) return;
        txtFile.Text = files?[0];
        GetDetail();
    }

    #endregion Target Controller

    #region De4Dot, Input

    private void btnDe4dot_Click(object sender, EventArgs e)
    {
        var frmDe4dot = new FrmDe4Dot();
        frmDe4dot.ShowDialog();
        frmDe4dot.Dispose();
        UpdateList();
        InputUpdate();
    }

    private void InputUpdate()
    {
        string path;
        try
        {
            path = Program.Settings.ListDe4Dot[cbDe4dot.SelectedIndex].Path + "\\";
        }
        catch
        {
            MessageBox.Show("Can not get de4dot path", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        var de4dotPath = Path.Combine(path, "de4dot.exe");
        var de4dot64Path = Path.Combine(path, "de4dot-x64.exe");
        if (!File.Exists(de4dot64Path))
        {
            MessageBox.Show("de4dot-x64.exe not found, exiting...", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            chk64.Checked = false;
            return;
        }

        _commandLine = GetCommandLine();

        _de4dot = chk64.Checked ? de4dot64Path : de4dotPath;
        txtInput.Text = _de4dot + " " + string.Join(" ", _commandLine);
    }

    private List<string> GetCommandLine()
    {
        var commandLine = new List<string>();

        if (!string.IsNullOrWhiteSpace(txtFile.Text))
        {
            commandLine.Add($"\"{txtFile.Text}\"");
        }

        if (chkPreserveToken.Checked)
        {
            commandLine.Add("--preserve-tokens");
        }

        if (chkKeepType.Checked)
        {
            commandLine.Add("--keep-types");
        }

        if (chkRename.Checked)
        {
            commandLine.Add("--dont-rename");
        }

        if (chkForce.Checked)
        {
            commandLine.Add("-p");
            if (cbType.SelectedIndex == -1)
            {
                MessageBox.Show(@"Invalid obfuscator index");
                return new List<string>();
            }
            commandLine.Add(((string)cbType.SelectedItem).Split(' ')[0]);
        }

        if (chkStrtyp.Checked)
        {
            commandLine.Add("--strtyp");
            if (cbStrtyp.SelectedIndex == -1)
            {
                MessageBox.Show(@"Invalid string type index");
                return new List<string>();
            }
            commandLine.Add((string)cbStrtyp.SelectedItem);

            var tokens = txtStrtok.Text.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            if (tokens.Length > 0)
            {
                foreach (var tok in tokens)
                {
                    commandLine.Add("--strtok");
                    commandLine.Add(tok);
                }
            }
        }

        if (!string.IsNullOrWhiteSpace(txtCustom.Text))
        {
            commandLine.Add($"{txtCustom.Text}");
        }

        return commandLine;
    }

    private void All_CheckedChanged(object sender, EventArgs e)
    {
        InputUpdate();
    }

    private void All_SelectedIndexChanged(object sender, EventArgs e)
    {
        InputUpdate();
    }

    private void All_TextChanged(object sender, EventArgs e)
    {
        InputUpdate();
    }

    #endregion De4Dot, Input

    #region Start&Log

    private void btnClear_Click(object sender, EventArgs e)
    {
        txtLog.Clear();
    }

    private void btnStart_Click(object sender, EventArgs e)
    {
        //if (string.IsNullOrWhiteSpace(txtFile.Text)) return;
        _thread?.Interrupt();
        if (_process is { HasExited: false })
            _process.Kill();
        _thread = new Thread(StartDe4dot);
        _thread.Start();
    }

    private void StartDe4dot()
    {
        _process = new Process();
        var startInfo = new ProcessStartInfo
        {
            Arguments = string.Join(" ", _commandLine),
            FileName = _de4dot,
            RedirectStandardOutput = true,
            UseShellExecute = false,
            CreateNoWindow = true,
        };
        startInfo.EnvironmentVariables.Add("SHELL", "");

        _process.OutputDataReceived += DataReceived;
        _process.StartInfo = startInfo;

        if (_process.Start())
        {
            _process.BeginOutputReadLine();
            _process.WaitForExit();
        }
        else
        {
            txtLog.AppendText("!Failed to start process" + Environment.NewLine);
        }
    }

    private void DataReceived(object sender, DataReceivedEventArgs e)
    {
        txtLog.AppendText(e.Data + Environment.NewLine);
    }

    #endregion Start&Log
}