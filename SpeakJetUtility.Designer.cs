
namespace PhraseALator
{
	partial class frmUtility
	{

		#region "Upgrade Support "
		private static frmUtility m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static frmUtility DefInstance
		{
			get
			{
				if (m_vb6FormDefInstance == null || m_vb6FormDefInstance.IsDisposed)
				{
					m_InitializingDefInstance = true;
					m_vb6FormDefInstance = CreateInstance();
					m_InitializingDefInstance = false;
				}
				return m_vb6FormDefInstance;
			}
			set
			{
				m_vb6FormDefInstance = value;
			}
		}

		#endregion
		#region "Windows Form Designer generated code "
		public static frmUtility CreateInstance()
		{
			frmUtility theInstance = new frmUtility();
			theInstance.Form_Load();
			return theInstance;
		}
		private string[] visualControls = new string[]{"components", "ToolTipMain", "btnDone", "Timer1", "btnDictEdit", "Command1", "btnSynth", "chkFlow", "cmdTestSerialPort", "txtComPort", "Label2", "Label1", "Frame13", "btnSetSerialPort", "EditEEPROM", "EditPhrases", "MSComm1"};
		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ToolTip ToolTipMain;
		public System.Windows.Forms.Button btnDone;
		public System.Windows.Forms.Timer Timer1;
		public System.Windows.Forms.Button btnDictEdit;
		public System.Windows.Forms.Button Command1;
		public System.Windows.Forms.Button btnSynth;
		public System.Windows.Forms.CheckBox chkFlow;
		public System.Windows.Forms.Button cmdTestSerialPort;
		public System.Windows.Forms.TextBox txtComPort;
		public System.Windows.Forms.Label Label2;
		public System.Windows.Forms.Label Label1;
		public System.Windows.Forms.GroupBox Frame13;
		public System.Windows.Forms.Button btnSetSerialPort;
		public System.Windows.Forms.Button EditEEPROM;
		public System.Windows.Forms.Button EditPhrases;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUtility));
            this.ToolTipMain = new System.Windows.Forms.ToolTip(this.components);
            this.btnDone = new System.Windows.Forms.Button();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnDictEdit = new System.Windows.Forms.Button();
            this.Command1 = new System.Windows.Forms.Button();
            this.btnSynth = new System.Windows.Forms.Button();
            this.Frame13 = new System.Windows.Forms.GroupBox();
            this.chkFlow = new System.Windows.Forms.CheckBox();
            this.cmdTestSerialPort = new System.Windows.Forms.Button();
            this.txtComPort = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnSetSerialPort = new System.Windows.Forms.Button();
            this.EditEEPROM = new System.Windows.Forms.Button();
            this.EditPhrases = new System.Windows.Forms.Button();
            this.Frame13.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDone
            // 
            this.btnDone.AllowDrop = true;
            this.btnDone.BackColor = System.Drawing.SystemColors.Control;
            this.btnDone.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDone.Location = new System.Drawing.Point(696, 223);
            this.btnDone.Margin = new System.Windows.Forms.Padding(6);
            this.btnDone.Name = "btnDone";
            this.btnDone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDone.Size = new System.Drawing.Size(130, 56);
            this.btnDone.TabIndex = 10;
            this.btnDone.Text = "Done";
            this.btnDone.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // Timer1
            // 
            this.Timer1.Interval = 1;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // btnDictEdit
            // 
            this.btnDictEdit.AllowDrop = true;
            this.btnDictEdit.BackColor = System.Drawing.SystemColors.Control;
            this.btnDictEdit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDictEdit.Location = new System.Drawing.Point(292, 88);
            this.btnDictEdit.Margin = new System.Windows.Forms.Padding(6);
            this.btnDictEdit.Name = "btnDictEdit";
            this.btnDictEdit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDictEdit.Size = new System.Drawing.Size(266, 63);
            this.btnDictEdit.TabIndex = 9;
            this.btnDictEdit.Text = "Dictionary Editor";
            this.btnDictEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDictEdit.UseVisualStyleBackColor = false;
            this.btnDictEdit.Click += new System.EventHandler(this.btnDictEdit_Click);
            // 
            // Command1
            // 
            this.Command1.AllowDrop = true;
            this.Command1.BackColor = System.Drawing.SystemColors.Control;
            this.Command1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Command1.Location = new System.Drawing.Point(568, 88);
            this.Command1.Margin = new System.Windows.Forms.Padding(6);
            this.Command1.Name = "Command1";
            this.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Command1.Size = new System.Drawing.Size(266, 63);
            this.Command1.TabIndex = 8;
            this.Command1.Text = "Baud Rate and Detune";
            this.Command1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Command1.UseVisualStyleBackColor = false;
            this.Command1.Click += new System.EventHandler(this.Command1_Click);
            // 
            // btnSynth
            // 
            this.btnSynth.AllowDrop = true;
            this.btnSynth.BackColor = System.Drawing.SystemColors.Control;
            this.btnSynth.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSynth.Location = new System.Drawing.Point(16, 88);
            this.btnSynth.Margin = new System.Windows.Forms.Padding(6);
            this.btnSynth.Name = "btnSynth";
            this.btnSynth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSynth.Size = new System.Drawing.Size(266, 63);
            this.btnSynth.TabIndex = 7;
            this.btnSynth.Text = "Synth Control";
            this.btnSynth.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSynth.UseVisualStyleBackColor = false;
            this.btnSynth.Click += new System.EventHandler(this.btnSynth_Click);
            // 
            // Frame13
            // 
            this.Frame13.AllowDrop = true;
            this.Frame13.BackColor = System.Drawing.SystemColors.Control;
            this.Frame13.Controls.Add(this.chkFlow);
            this.Frame13.Controls.Add(this.cmdTestSerialPort);
            this.Frame13.Controls.Add(this.txtComPort);
            this.Frame13.Controls.Add(this.Label2);
            this.Frame13.Controls.Add(this.Label1);
            this.Frame13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Frame13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Frame13.Location = new System.Drawing.Point(16, 165);
            this.Frame13.Margin = new System.Windows.Forms.Padding(6);
            this.Frame13.Name = "Frame13";
            this.Frame13.Padding = new System.Windows.Forms.Padding(6);
            this.Frame13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Frame13.Size = new System.Drawing.Size(642, 110);
            this.Frame13.TabIndex = 3;
            this.Frame13.TabStop = false;
            this.Frame13.Text = "Communication Settings";
            // 
            // chkFlow
            // 
            this.chkFlow.AllowDrop = true;
            this.chkFlow.BackColor = System.Drawing.SystemColors.Control;
            this.chkFlow.Checked = true;
            this.chkFlow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFlow.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkFlow.Location = new System.Drawing.Point(504, 50);
            this.chkFlow.Margin = new System.Windows.Forms.Padding(6);
            this.chkFlow.Name = "chkFlow";
            this.chkFlow.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkFlow.Size = new System.Drawing.Size(126, 37);
            this.chkFlow.TabIndex = 11;
            this.chkFlow.Text = "Control";
            this.chkFlow.UseVisualStyleBackColor = false;
            // 
            // cmdTestSerialPort
            // 
            this.cmdTestSerialPort.AllowDrop = true;
            this.cmdTestSerialPort.BackColor = System.Drawing.SystemColors.Control;
            this.cmdTestSerialPort.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdTestSerialPort.Location = new System.Drawing.Point(240, 38);
            this.cmdTestSerialPort.Margin = new System.Windows.Forms.Padding(6);
            this.cmdTestSerialPort.Name = "cmdTestSerialPort";
            this.cmdTestSerialPort.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdTestSerialPort.Size = new System.Drawing.Size(250, 40);
            this.cmdTestSerialPort.TabIndex = 6;
            this.cmdTestSerialPort.Text = "Test Serial Connection";
            this.cmdTestSerialPort.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdTestSerialPort.UseVisualStyleBackColor = false;
            this.cmdTestSerialPort.Click += new System.EventHandler(this.cmdTestSerialPort_Click);
            // 
            // txtComPort
            // 
            this.txtComPort.AcceptsReturn = true;
            this.txtComPort.AllowDrop = true;
            this.txtComPort.BackColor = System.Drawing.SystemColors.Window;
            this.txtComPort.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtComPort.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtComPort.Location = new System.Drawing.Point(160, 42);
            this.txtComPort.Margin = new System.Windows.Forms.Padding(6);
            this.txtComPort.MaxLength = 0;
            this.txtComPort.Name = "txtComPort";
            this.txtComPort.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtComPort.Size = new System.Drawing.Size(54, 32);
            this.txtComPort.TabIndex = 4;
            this.txtComPort.Text = "1";
            this.txtComPort.Leave += new System.EventHandler(this.txtComPort_Leave);
            // 
            // Label2
            // 
            this.Label2.AllowDrop = true;
            this.Label2.BackColor = System.Drawing.SystemColors.Control;
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2.Location = new System.Drawing.Point(532, 23);
            this.Label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2.Size = new System.Drawing.Size(106, 29);
            this.Label2.TabIndex = 12;
            this.Label2.Text = "Use Flow";
            // 
            // Label1
            // 
            this.Label1.AllowDrop = true;
            this.Label1.BackColor = System.Drawing.SystemColors.Control;
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.Location = new System.Drawing.Point(8, 50);
            this.Label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(146, 33);
            this.Label1.TabIndex = 5;
            this.Label1.Text = "Serial Port:";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnSetSerialPort
            // 
            this.btnSetSerialPort.AllowDrop = true;
            this.btnSetSerialPort.BackColor = System.Drawing.SystemColors.Control;
            this.btnSetSerialPort.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSetSerialPort.Location = new System.Drawing.Point(568, 15);
            this.btnSetSerialPort.Margin = new System.Windows.Forms.Padding(6);
            this.btnSetSerialPort.Name = "btnSetSerialPort";
            this.btnSetSerialPort.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSetSerialPort.Size = new System.Drawing.Size(266, 63);
            this.btnSetSerialPort.TabIndex = 2;
            this.btnSetSerialPort.Text = "Event Config";
            this.btnSetSerialPort.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSetSerialPort.UseVisualStyleBackColor = false;
            this.btnSetSerialPort.Click += new System.EventHandler(this.btnSetSerialPort_Click);
            // 
            // EditEEPROM
            // 
            this.EditEEPROM.AllowDrop = true;
            this.EditEEPROM.BackColor = System.Drawing.SystemColors.Control;
            this.EditEEPROM.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EditEEPROM.Location = new System.Drawing.Point(292, 15);
            this.EditEEPROM.Margin = new System.Windows.Forms.Padding(6);
            this.EditEEPROM.Name = "EditEEPROM";
            this.EditEEPROM.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EditEEPROM.Size = new System.Drawing.Size(266, 63);
            this.EditEEPROM.TabIndex = 1;
            this.EditEEPROM.Text = "EEPROM Editor";
            this.EditEEPROM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EditEEPROM.UseVisualStyleBackColor = false;
            this.EditEEPROM.Click += new System.EventHandler(this.EditEEPROM_Click);
            // 
            // EditPhrases
            // 
            this.EditPhrases.AllowDrop = true;
            this.EditPhrases.BackColor = System.Drawing.SystemColors.Control;
            this.EditPhrases.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EditPhrases.Location = new System.Drawing.Point(16, 15);
            this.EditPhrases.Margin = new System.Windows.Forms.Padding(6);
            this.EditPhrases.Name = "EditPhrases";
            this.EditPhrases.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EditPhrases.Size = new System.Drawing.Size(266, 63);
            this.EditPhrases.TabIndex = 0;
            this.EditPhrases.Text = "Phrase Editor";
            this.EditPhrases.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EditPhrases.UseVisualStyleBackColor = false;
            this.EditPhrases.Click += new System.EventHandler(this.EditPhrases_Click);
            // 
            // frmUtility
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(846, 290);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnDictEdit);
            this.Controls.Add(this.Command1);
            this.Controls.Add(this.btnSynth);
            this.Controls.Add(this.Frame13);
            this.Controls.Add(this.btnSetSerialPort);
            this.Controls.Add(this.EditEEPROM);
            this.Controls.Add(this.EditPhrases);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(4, 30);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "frmUtility";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Magnevation Phrase Translator for SpeakJet  V.1.4";
            this.Closed += new System.EventHandler(this.Form_Closed);
            this.Frame13.ResumeLayout(false);
            this.Frame13.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion
	}
}