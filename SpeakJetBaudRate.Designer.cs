
namespace PhraseALator
{
	partial class frmBaudRate
	{

		#region "Upgrade Support "
		private static frmBaudRate m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static frmBaudRate DefInstance
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
		public static frmBaudRate CreateInstance()
		{
			frmBaudRate theInstance = new frmBaudRate();
			theInstance.Form_Load();
			return theInstance;
		}
		private string[] visualControls = new string[]{"components", "ToolTipMain", "txtClockAdj", "btnSendDetuneValue", "Label23", "Frame2", "btnSendSyncChar", "_Option1_1", "_Option1_2", "_Option1_3", "_Option1_4", "Label1", "Frame1", "btnDone", "Option1"};
		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ToolTip ToolTipMain;
		public System.Windows.Forms.TextBox txtClockAdj;
		public System.Windows.Forms.Button btnSendDetuneValue;
		public System.Windows.Forms.Label Label23;
		public System.Windows.Forms.GroupBox Frame2;
		public System.Windows.Forms.Button btnSendSyncChar;
		private System.Windows.Forms.RadioButton _Option1_1;
		private System.Windows.Forms.RadioButton _Option1_2;
		private System.Windows.Forms.RadioButton _Option1_3;
		private System.Windows.Forms.RadioButton _Option1_4;
		public System.Windows.Forms.Label Label1;
		public System.Windows.Forms.GroupBox Frame1;
		public System.Windows.Forms.Button btnDone;
		public System.Windows.Forms.RadioButton[] Option1 = new System.Windows.Forms.RadioButton[5];
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaudRate));
			this.ToolTipMain = new System.Windows.Forms.ToolTip(this.components);
			this.Frame2 = new System.Windows.Forms.GroupBox();
			this.txtClockAdj = new System.Windows.Forms.TextBox();
			this.btnSendDetuneValue = new System.Windows.Forms.Button();
			this.Label23 = new System.Windows.Forms.Label();
			this.Frame1 = new System.Windows.Forms.GroupBox();
			this.btnSendSyncChar = new System.Windows.Forms.Button();
			this._Option1_1 = new System.Windows.Forms.RadioButton();
			this._Option1_2 = new System.Windows.Forms.RadioButton();
			this._Option1_3 = new System.Windows.Forms.RadioButton();
			this._Option1_4 = new System.Windows.Forms.RadioButton();
			this.Label1 = new System.Windows.Forms.Label();
			this.btnDone = new System.Windows.Forms.Button();
			this.Frame2.SuspendLayout();
			this.Frame1.SuspendLayout();
			this.SuspendLayout();
			// 
			// Frame2
			// 
			this.Frame2.AllowDrop = true;
			this.Frame2.BackColor = System.Drawing.SystemColors.Control;
			this.Frame2.Controls.Add(this.txtClockAdj);
			this.Frame2.Controls.Add(this.btnSendDetuneValue);
			this.Frame2.Controls.Add(this.Label23);
			this.Frame2.Enabled = true;
			this.Frame2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame2.Location = new System.Drawing.Point(8, 120);
			this.Frame2.Name = "Frame2";
			this.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame2.Size = new System.Drawing.Size(305, 57);
			this.Frame2.TabIndex = 7;
			this.Frame2.Text = "Chip Detune";
			this.Frame2.Visible = true;
			// 
			// txtClockAdj
			// 
			this.txtClockAdj.AcceptsReturn = true;
			this.txtClockAdj.AllowDrop = true;
			this.txtClockAdj.BackColor = System.Drawing.SystemColors.Window;
			this.txtClockAdj.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtClockAdj.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtClockAdj.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtClockAdj.Location = new System.Drawing.Point(76, 24);
			this.txtClockAdj.MaxLength = 0;
			this.txtClockAdj.Name = "txtClockAdj";
			this.txtClockAdj.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtClockAdj.Size = new System.Drawing.Size(37, 19);
			this.txtClockAdj.TabIndex = 9;
			this.txtClockAdj.Text = "&HFF";
			// 
			// btnSendDetuneValue
			// 
			this.btnSendDetuneValue.AllowDrop = true;
			this.btnSendDetuneValue.BackColor = System.Drawing.SystemColors.Control;
			this.btnSendDetuneValue.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnSendDetuneValue.Location = new System.Drawing.Point(148, 16);
			this.btnSendDetuneValue.Name = "btnSendDetuneValue";
			this.btnSendDetuneValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnSendDetuneValue.Size = new System.Drawing.Size(149, 33);
			this.btnSendDetuneValue.TabIndex = 8;
			this.btnSendDetuneValue.Text = "Send Detune Value";
			this.btnSendDetuneValue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnSendDetuneValue.UseVisualStyleBackColor = false;
			this.btnSendDetuneValue.Click += new System.EventHandler(this.btnSendDetuneValue_Click);
			// 
			// Label23
			// 
			this.Label23.AllowDrop = true;
			this.Label23.BackColor = System.Drawing.SystemColors.Control;
			this.Label23.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label23.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label23.Location = new System.Drawing.Point(4, 24);
			this.Label23.Name = "Label23";
			this.Label23.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label23.Size = new System.Drawing.Size(65, 21);
			this.Label23.TabIndex = 10;
			this.Label23.Text = "Detune:";
			this.Label23.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// Frame1
			// 
			this.Frame1.AllowDrop = true;
			this.Frame1.BackColor = System.Drawing.SystemColors.Control;
			this.Frame1.Controls.Add(this.btnSendSyncChar);
			this.Frame1.Controls.Add(this._Option1_1);
			this.Frame1.Controls.Add(this._Option1_2);
			this.Frame1.Controls.Add(this._Option1_3);
			this.Frame1.Controls.Add(this._Option1_4);
			this.Frame1.Controls.Add(this.Label1);
			this.Frame1.Enabled = true;
			this.Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame1.Location = new System.Drawing.Point(8, 8);
			this.Frame1.Name = "Frame1";
			this.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame1.Size = new System.Drawing.Size(305, 109);
			this.Frame1.TabIndex = 1;
			this.Frame1.Text = "Buad Rate";
			this.Frame1.Visible = true;
			// 
			// btnSendSyncChar
			// 
			this.btnSendSyncChar.AllowDrop = true;
			this.btnSendSyncChar.BackColor = System.Drawing.SystemColors.Control;
			this.btnSendSyncChar.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnSendSyncChar.Location = new System.Drawing.Point(118, 74);
			this.btnSendSyncChar.Name = "btnSendSyncChar";
			this.btnSendSyncChar.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnSendSyncChar.Size = new System.Drawing.Size(143, 25);
			this.btnSendSyncChar.TabIndex = 6;
			this.btnSendSyncChar.Text = "Send Sync Character";
			this.btnSendSyncChar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnSendSyncChar.UseVisualStyleBackColor = false;
			this.btnSendSyncChar.Click += new System.EventHandler(this.btnSendSyncChar_Click);
			// 
			// _Option1_1
			// 
			this._Option1_1.AllowDrop = true;
			this._Option1_1.Appearance = System.Windows.Forms.Appearance.Normal;
			this._Option1_1.BackColor = System.Drawing.SystemColors.Control;
			this._Option1_1.CausesValidation = true;
			this._Option1_1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._Option1_1.Checked = false;
			this._Option1_1.Enabled = true;
			this._Option1_1.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Option1_1.Location = new System.Drawing.Point(12, 20);
			this._Option1_1.Name = "_Option1_1";
			this._Option1_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Option1_1.Size = new System.Drawing.Size(61, 17);
			this._Option1_1.TabIndex = 5;
			this._Option1_1.TabStop = true;
			this._Option1_1.Text = "2400";
			this._Option1_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._Option1_1.Visible = true;
			this._Option1_1.CheckedChanged += new System.EventHandler(this.Option1_CheckedChanged);
			// 
			// _Option1_2
			// 
			this._Option1_2.AllowDrop = true;
			this._Option1_2.Appearance = System.Windows.Forms.Appearance.Normal;
			this._Option1_2.BackColor = System.Drawing.SystemColors.Control;
			this._Option1_2.CausesValidation = true;
			this._Option1_2.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._Option1_2.Checked = false;
			this._Option1_2.Enabled = true;
			this._Option1_2.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Option1_2.Location = new System.Drawing.Point(12, 40);
			this._Option1_2.Name = "_Option1_2";
			this._Option1_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Option1_2.Size = new System.Drawing.Size(61, 17);
			this._Option1_2.TabIndex = 4;
			this._Option1_2.TabStop = true;
			this._Option1_2.Text = "4800";
			this._Option1_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._Option1_2.Visible = true;
			this._Option1_2.CheckedChanged += new System.EventHandler(this.Option1_CheckedChanged);
			// 
			// _Option1_3
			// 
			this._Option1_3.AllowDrop = true;
			this._Option1_3.Appearance = System.Windows.Forms.Appearance.Normal;
			this._Option1_3.BackColor = System.Drawing.SystemColors.Control;
			this._Option1_3.CausesValidation = true;
			this._Option1_3.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._Option1_3.Checked = false;
			this._Option1_3.Enabled = true;
			this._Option1_3.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Option1_3.Location = new System.Drawing.Point(12, 60);
			this._Option1_3.Name = "_Option1_3";
			this._Option1_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Option1_3.Size = new System.Drawing.Size(61, 17);
			this._Option1_3.TabIndex = 3;
			this._Option1_3.TabStop = true;
			this._Option1_3.Text = "9600";
			this._Option1_3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._Option1_3.Visible = true;
			this._Option1_3.CheckedChanged += new System.EventHandler(this.Option1_CheckedChanged);
			// 
			// _Option1_4
			// 
			this._Option1_4.AllowDrop = true;
			this._Option1_4.Appearance = System.Windows.Forms.Appearance.Normal;
			this._Option1_4.BackColor = System.Drawing.SystemColors.Control;
			this._Option1_4.CausesValidation = true;
			this._Option1_4.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._Option1_4.Checked = false;
			this._Option1_4.Enabled = true;
			this._Option1_4.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Option1_4.Location = new System.Drawing.Point(12, 80);
			this._Option1_4.Name = "_Option1_4";
			this._Option1_4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Option1_4.Size = new System.Drawing.Size(61, 17);
			this._Option1_4.TabIndex = 2;
			this._Option1_4.TabStop = true;
			this._Option1_4.Text = "19200";
			this._Option1_4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._Option1_4.Visible = true;
			this._Option1_4.CheckedChanged += new System.EventHandler(this.Option1_CheckedChanged);
			// 
			// Label1
			// 
			this.Label1.AllowDrop = true;
			this.Label1.BackColor = System.Drawing.SystemColors.Control;
			this.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label1.Location = new System.Drawing.Point(84, 14);
			this.Label1.Name = "Label1";
			this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label1.Size = new System.Drawing.Size(213, 57);
			this.Label1.TabIndex = 11;
			this.Label1.Text = "To set the Baud Rate, the SpeakJet must be set to Baud Rate Configure Mode at which time, a Sync Character is sent.  See the Speak Jet Manual for more details.";
			this.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// btnDone
			// 
			this.btnDone.AllowDrop = true;
			this.btnDone.BackColor = System.Drawing.SystemColors.Control;
			this.btnDone.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnDone.Location = new System.Drawing.Point(238, 184);
			this.btnDone.Name = "btnDone";
			this.btnDone.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnDone.Size = new System.Drawing.Size(77, 29);
			this.btnDone.TabIndex = 0;
			this.btnDone.Text = "Done";
			this.btnDone.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnDone.UseVisualStyleBackColor = false;
			this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
			// 
			// frmBaudRate
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(319, 218);
			this.Controls.Add(this.Frame2);
			this.Controls.Add(this.Frame1);
			this.Controls.Add(this.btnDone);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Location = new System.Drawing.Point(3, 23);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmBaudRate";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SpeakJet Baud Rate and Detune";
			this.Closed += new System.EventHandler(this.Form_Closed);
			this.Frame2.ResumeLayout(false);
			this.Frame1.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		void ReLoadForm(bool addEvents)
		{
			InitializeOption1();
		}
		void InitializeOption1()
		{
			this.Option1 = new System.Windows.Forms.RadioButton[5];
			this.Option1[1] = _Option1_1;
			this.Option1[2] = _Option1_2;
			this.Option1[3] = _Option1_3;
			this.Option1[4] = _Option1_4;
		}
		#endregion
	}
}