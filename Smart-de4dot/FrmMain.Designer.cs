namespace Smart_de4dot
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTargetInfo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCustom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtStrtok = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbStrtyp = new System.Windows.Forms.ComboBox();
            this.chkStrtyp = new System.Windows.Forms.CheckBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.chkForce = new System.Windows.Forms.CheckBox();
            this.chkRename = new System.Windows.Forms.CheckBox();
            this.chkKeepType = new System.Windows.Forms.CheckBox();
            this.chkPreserveToken = new System.Windows.Forms.CheckBox();
            this.btnDe4dot = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDe4dot = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.chk64 = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.tipStrtok = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Target File: ";
            // 
            // txtFile
            // 
            this.txtFile.AllowDrop = true;
            this.txtFile.Location = new System.Drawing.Point(81, 22);
            this.txtFile.Name = "txtFile";
            this.txtFile.ReadOnly = true;
            this.txtFile.Size = new System.Drawing.Size(287, 23);
            this.txtFile.TabIndex = 1;
            this.txtFile.TextChanged += new System.EventHandler(this.All_TextChanged);
            this.txtFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.TargetDrop);
            this.txtFile.DragOver += new System.Windows.Forms.DragEventHandler(this.TargetOver);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTargetInfo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Controls.Add(this.txtFile);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 96);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Target Infomation";
            this.groupBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.TargetDrop);
            this.groupBox1.DragOver += new System.Windows.Forms.DragEventHandler(this.TargetOver);
            // 
            // txtTargetInfo
            // 
            this.txtTargetInfo.BackColor = System.Drawing.SystemColors.Control;
            this.txtTargetInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTargetInfo.Location = new System.Drawing.Point(81, 51);
            this.txtTargetInfo.Multiline = true;
            this.txtTargetInfo.Name = "txtTargetInfo";
            this.txtTargetInfo.ReadOnly = true;
            this.txtTargetInfo.Size = new System.Drawing.Size(323, 39);
            this.txtTargetInfo.TabIndex = 5;
            this.txtTargetInfo.DragDrop += new System.Windows.Forms.DragEventHandler(this.TargetDrop);
            this.txtTargetInfo.DragOver += new System.Windows.Forms.DragEventHandler(this.TargetOver);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Target Info: ";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(374, 21);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(30, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtCustom);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtInput);
            this.groupBox2.Controls.Add(this.txtStrtok);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cbStrtyp);
            this.groupBox2.Controls.Add(this.chkStrtyp);
            this.groupBox2.Controls.Add(this.cbType);
            this.groupBox2.Controls.Add(this.chkForce);
            this.groupBox2.Controls.Add(this.chkRename);
            this.groupBox2.Controls.Add(this.chkKeepType);
            this.groupBox2.Controls.Add(this.chkPreserveToken);
            this.groupBox2.Controls.Add(this.btnDe4dot);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbDe4dot);
            this.groupBox2.Location = new System.Drawing.Point(12, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(410, 239);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "De4Dot Information";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Custom: ";
            // 
            // txtCustom
            // 
            this.txtCustom.Location = new System.Drawing.Point(70, 113);
            this.txtCustom.Multiline = true;
            this.txtCustom.Name = "txtCustom";
            this.txtCustom.Size = new System.Drawing.Size(334, 49);
            this.txtCustom.TabIndex = 15;
            this.txtCustom.TextChanged += new System.EventHandler(this.All_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Input: ";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(6, 168);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.ReadOnly = true;
            this.txtInput.Size = new System.Drawing.Size(395, 65);
            this.txtInput.TabIndex = 13;
            // 
            // txtStrtok
            // 
            this.txtStrtok.Location = new System.Drawing.Point(202, 84);
            this.txtStrtok.Name = "txtStrtok";
            this.txtStrtok.Size = new System.Drawing.Size(202, 23);
            this.txtStrtok.TabIndex = 11;
            this.tipStrtok.SetToolTip(this.txtStrtok, "can use many tokens, separate them with space");
            this.txtStrtok.TextChanged += new System.EventHandler(this.All_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "--strtok";
            // 
            // cbStrtyp
            // 
            this.cbStrtyp.FormattingEnabled = true;
            this.cbStrtyp.Items.AddRange(new object[] {
            "delegate",
            "emulate"});
            this.cbStrtyp.Location = new System.Drawing.Point(63, 84);
            this.cbStrtyp.Name = "cbStrtyp";
            this.cbStrtyp.Size = new System.Drawing.Size(80, 23);
            this.cbStrtyp.TabIndex = 9;
            this.cbStrtyp.Text = "delegate";
            this.cbStrtyp.SelectedIndexChanged += new System.EventHandler(this.All_SelectedIndexChanged);
            // 
            // chkStrtyp
            // 
            this.chkStrtyp.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkStrtyp.AutoSize = true;
            this.chkStrtyp.Location = new System.Drawing.Point(9, 82);
            this.chkStrtyp.Name = "chkStrtyp";
            this.chkStrtyp.Size = new System.Drawing.Size(48, 25);
            this.chkStrtyp.TabIndex = 8;
            this.chkStrtyp.Text = "Strtyp";
            this.chkStrtyp.UseVisualStyleBackColor = true;
            this.chkStrtyp.CheckedChanged += new System.EventHandler(this.All_CheckedChanged);
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "un (Unknown)",
            "an (Agile.NET)",
            "bl (Babel .NET)",
            "cf (CodeFort)",
            "cv (CodeVeil)",
            "cw (CodeWall)",
            "cr (Confuser)",
            "co (Crypto Obfuscator)",
            "ds (DeepSea)",
            "df (Dotfuscator)",
            "dr3 (.NET Reactor)",
            "dr4 (.NET Reactor)",
            "ef (Eazfuscator.NET)",
            "go (Goliath.NET)",
            "il (ILProtector)",
            "mc (MaxtoCode)",
            "mp (MPRESS)",
            "rm (Rummage)",
            "sk (Skater .NET)",
            "sa (SmartAssembly)",
            "sn (Spices.Net)",
            "xc (Xenocode)"});
            this.cbType.Location = new System.Drawing.Point(324, 53);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(80, 23);
            this.cbType.TabIndex = 8;
            this.cbType.Text = "un (Unknown)";
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.All_SelectedIndexChanged);
            // 
            // chkForce
            // 
            this.chkForce.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkForce.AutoSize = true;
            this.chkForce.Location = new System.Drawing.Point(294, 51);
            this.chkForce.Name = "chkForce";
            this.chkForce.Size = new System.Drawing.Size(24, 25);
            this.chkForce.TabIndex = 7;
            this.chkForce.Text = "P";
            this.chkForce.UseVisualStyleBackColor = true;
            this.chkForce.CheckedChanged += new System.EventHandler(this.All_CheckedChanged);
            // 
            // chkRename
            // 
            this.chkRename.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkRename.AutoSize = true;
            this.chkRename.Location = new System.Drawing.Point(196, 51);
            this.chkRename.Name = "chkRename";
            this.chkRename.Size = new System.Drawing.Size(92, 25);
            this.chkRename.TabIndex = 6;
            this.chkRename.Text = "Don\'t Rename";
            this.chkRename.UseVisualStyleBackColor = true;
            this.chkRename.CheckedChanged += new System.EventHandler(this.All_CheckedChanged);
            // 
            // chkKeepType
            // 
            this.chkKeepType.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkKeepType.AutoSize = true;
            this.chkKeepType.Location = new System.Drawing.Point(115, 51);
            this.chkKeepType.Name = "chkKeepType";
            this.chkKeepType.Size = new System.Drawing.Size(75, 25);
            this.chkKeepType.TabIndex = 5;
            this.chkKeepType.Text = "Keep Types";
            this.chkKeepType.UseVisualStyleBackColor = true;
            this.chkKeepType.CheckedChanged += new System.EventHandler(this.All_CheckedChanged);
            // 
            // chkPreserveToken
            // 
            this.chkPreserveToken.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkPreserveToken.AutoSize = true;
            this.chkPreserveToken.Location = new System.Drawing.Point(9, 51);
            this.chkPreserveToken.Name = "chkPreserveToken";
            this.chkPreserveToken.Size = new System.Drawing.Size(100, 25);
            this.chkPreserveToken.TabIndex = 4;
            this.chkPreserveToken.Text = "Preserve Tokens";
            this.chkPreserveToken.UseVisualStyleBackColor = true;
            this.chkPreserveToken.CheckedChanged += new System.EventHandler(this.All_CheckedChanged);
            // 
            // btnDe4dot
            // 
            this.btnDe4dot.Location = new System.Drawing.Point(374, 22);
            this.btnDe4dot.Name = "btnDe4dot";
            this.btnDe4dot.Size = new System.Drawing.Size(30, 23);
            this.btnDe4dot.TabIndex = 3;
            this.btnDe4dot.Text = "...";
            this.btnDe4dot.UseVisualStyleBackColor = true;
            this.btnDe4dot.Click += new System.EventHandler(this.btnDe4dot_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "De4Dot: ";
            // 
            // cbDe4dot
            // 
            this.cbDe4dot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDe4dot.FormattingEnabled = true;
            this.cbDe4dot.Location = new System.Drawing.Point(81, 22);
            this.cbDe4dot.Name = "cbDe4dot";
            this.cbDe4dot.Size = new System.Drawing.Size(287, 23);
            this.cbDe4dot.TabIndex = 0;
            this.cbDe4dot.SelectedIndexChanged += new System.EventHandler(this.All_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtLog);
            this.groupBox3.Location = new System.Drawing.Point(12, 359);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(410, 185);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Logs";
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.Color.Black;
            this.txtLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.ForeColor = System.Drawing.Color.Silver;
            this.txtLog.Location = new System.Drawing.Point(3, 19);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLog.Size = new System.Drawing.Size(404, 163);
            this.txtLog.TabIndex = 14;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 576);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(410, 23);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // chk64
            // 
            this.chk64.AutoSize = true;
            this.chk64.Location = new System.Drawing.Point(378, 551);
            this.chk64.Name = "chk64";
            this.chk64.Size = new System.Drawing.Size(44, 19);
            this.chk64.TabIndex = 5;
            this.chk64.Text = "x64";
            this.chk64.UseVisualStyleBackColor = true;
            this.chk64.CheckedChanged += new System.EventHandler(this.All_CheckedChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 550);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(45, 20);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tipStrtok
            // 
            this.tipStrtok.ToolTipTitle = "Infomation";
            // 
            // FrmMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 611);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.chk64);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smart De4Dot";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtFile;
        private GroupBox groupBox1;
        private Label label2;
        private Button btnBrowse;
        private GroupBox groupBox2;
        private Label label6;
        private TextBox txtInput;
        private TextBox txtStrtok;
        private Label label4;
        private ComboBox cbStrtyp;
        private CheckBox chkStrtyp;
        private ComboBox cbType;
        private CheckBox chkForce;
        private CheckBox chkRename;
        private CheckBox chkKeepType;
        private CheckBox chkPreserveToken;
        private Button btnDe4dot;
        private Label label3;
        private ComboBox cbDe4dot;
        private GroupBox groupBox3;
        private TextBox txtLog;
        private Button btnStart;
        private CheckBox chk64;
        private Button btnClear;
        private TextBox txtTargetInfo;
        private Label label5;
        private TextBox txtCustom;
        private ToolTip tipStrtok;
    }
}