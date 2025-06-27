
namespace PhraseALator
{
	partial class frmEEPROM
	{

		#region "Upgrade Support "
		private static frmEEPROM m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static frmEEPROM DefInstance
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
		public static frmEEPROM CreateInstance()
		{
			frmEEPROM theInstance = new frmEEPROM();
			theInstance.Form_Load();
			return theInstance;
		}
		private string[] visualControls = new string[]{"components", "ToolTipMain", "btnShutUp", "btnDone", "btnWrite", "MSComm1", "txtUsed", "_Phrase_12", "_Phrase_13", "_Phrase_14", "_Phrase_15", "_Phrase_8", "_Phrase_9", "_Phrase_10", "_Phrase_11", "_Phrase_7", "_Phrase_6", "_Phrase_5", "_Phrase_4", "_Phrase_3", "_Phrase_2", "_Phrase_1", "_Phrase_0", "_lbs_15", "_lbs_14", "_lbs_13", "_lbs_12", "_lbs_11", "_lbs_10", "_lbs_9", "_lbs_8", "_lbs_7", "_lbs_6", "_lbs_5", "_lbs_4", "_lbs_3", "_lbs_2", "_lbs_1", "_lbs_0", "Phrase", "lbs"};
		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ToolTip ToolTipMain;
		public System.Windows.Forms.Button btnShutUp;
		public System.Windows.Forms.Button btnDone;
		public System.Windows.Forms.Button btnWrite;
		public System.Windows.Forms.Label txtUsed;
		private System.Windows.Forms.Label _Phrase_12;
		private System.Windows.Forms.Label _Phrase_13;
		private System.Windows.Forms.Label _Phrase_14;
		private System.Windows.Forms.Label _Phrase_15;
		private System.Windows.Forms.Label _Phrase_8;
		private System.Windows.Forms.Label _Phrase_9;
		private System.Windows.Forms.Label _Phrase_10;
		private System.Windows.Forms.Label _Phrase_11;
		private System.Windows.Forms.Label _Phrase_7;
		private System.Windows.Forms.Label _Phrase_6;
		private System.Windows.Forms.Label _Phrase_5;
		private System.Windows.Forms.Label _Phrase_4;
		private System.Windows.Forms.Label _Phrase_3;
		private System.Windows.Forms.Label _Phrase_2;
		private System.Windows.Forms.Label _Phrase_1;
		private System.Windows.Forms.Label _Phrase_0;
		private System.Windows.Forms.Label _lbs_15;
		private System.Windows.Forms.Label _lbs_14;
		private System.Windows.Forms.Label _lbs_13;
		private System.Windows.Forms.Label _lbs_12;
		private System.Windows.Forms.Label _lbs_11;
		private System.Windows.Forms.Label _lbs_10;
		private System.Windows.Forms.Label _lbs_9;
		private System.Windows.Forms.Label _lbs_8;
		private System.Windows.Forms.Label _lbs_7;
		private System.Windows.Forms.Label _lbs_6;
		private System.Windows.Forms.Label _lbs_5;
		private System.Windows.Forms.Label _lbs_4;
		private System.Windows.Forms.Label _lbs_3;
		private System.Windows.Forms.Label _lbs_2;
		private System.Windows.Forms.Label _lbs_1;
		private System.Windows.Forms.Label _lbs_0;
		public System.Windows.Forms.Label[] Phrase = new System.Windows.Forms.Label[16];
		public System.Windows.Forms.Label[] lbs = new System.Windows.Forms.Label[16];
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEEPROM));
			this.ToolTipMain = new System.Windows.Forms.ToolTip(this.components);
			this.btnShutUp = new System.Windows.Forms.Button();
			this.btnDone = new System.Windows.Forms.Button();
			this.btnWrite = new System.Windows.Forms.Button();
			this.txtUsed = new System.Windows.Forms.Label();
			this._Phrase_12 = new System.Windows.Forms.Label();
			this._Phrase_13 = new System.Windows.Forms.Label();
			this._Phrase_14 = new System.Windows.Forms.Label();
			this._Phrase_15 = new System.Windows.Forms.Label();
			this._Phrase_8 = new System.Windows.Forms.Label();
			this._Phrase_9 = new System.Windows.Forms.Label();
			this._Phrase_10 = new System.Windows.Forms.Label();
			this._Phrase_11 = new System.Windows.Forms.Label();
			this._Phrase_7 = new System.Windows.Forms.Label();
			this._Phrase_6 = new System.Windows.Forms.Label();
			this._Phrase_5 = new System.Windows.Forms.Label();
			this._Phrase_4 = new System.Windows.Forms.Label();
			this._Phrase_3 = new System.Windows.Forms.Label();
			this._Phrase_2 = new System.Windows.Forms.Label();
			this._Phrase_1 = new System.Windows.Forms.Label();
			this._Phrase_0 = new System.Windows.Forms.Label();
			this._lbs_15 = new System.Windows.Forms.Label();
			this._lbs_14 = new System.Windows.Forms.Label();
			this._lbs_13 = new System.Windows.Forms.Label();
			this._lbs_12 = new System.Windows.Forms.Label();
			this._lbs_11 = new System.Windows.Forms.Label();
			this._lbs_10 = new System.Windows.Forms.Label();
			this._lbs_9 = new System.Windows.Forms.Label();
			this._lbs_8 = new System.Windows.Forms.Label();
			this._lbs_7 = new System.Windows.Forms.Label();
			this._lbs_6 = new System.Windows.Forms.Label();
			this._lbs_5 = new System.Windows.Forms.Label();
			this._lbs_4 = new System.Windows.Forms.Label();
			this._lbs_3 = new System.Windows.Forms.Label();
			this._lbs_2 = new System.Windows.Forms.Label();
			this._lbs_1 = new System.Windows.Forms.Label();
			this._lbs_0 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnShutUp
			// 
			this.btnShutUp.AllowDrop = true;
			this.btnShutUp.BackColor = System.Drawing.SystemColors.Control;
			this.btnShutUp.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnShutUp.Location = new System.Drawing.Point(532, 492);
			this.btnShutUp.Name = "btnShutUp";
			this.btnShutUp.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnShutUp.Size = new System.Drawing.Size(77, 29);
			this.btnShutUp.TabIndex = 35;
			this.btnShutUp.Text = "Shut Up";
			this.btnShutUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnShutUp.UseVisualStyleBackColor = false;
			this.btnShutUp.Click += new System.EventHandler(this.btnShutUp_Click);
			// 
			// btnDone
			// 
			this.btnDone.AllowDrop = true;
			this.btnDone.BackColor = System.Drawing.SystemColors.Control;
			this.btnDone.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnDone.Location = new System.Drawing.Point(616, 492);
			this.btnDone.Name = "btnDone";
			this.btnDone.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnDone.Size = new System.Drawing.Size(77, 29);
			this.btnDone.TabIndex = 33;
			this.btnDone.Text = "Done";
			this.btnDone.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnDone.UseVisualStyleBackColor = false;
			this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
			// 
			// btnWrite
			// 
			this.btnWrite.AllowDrop = true;
			this.btnWrite.BackColor = System.Drawing.SystemColors.Control;
			this.btnWrite.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnWrite.Location = new System.Drawing.Point(196, 492);
			this.btnWrite.Name = "btnWrite";
			this.btnWrite.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnWrite.Size = new System.Drawing.Size(153, 25);
			this.btnWrite.TabIndex = 32;
			this.btnWrite.Text = "Write Data to SpeakJet";
			this.btnWrite.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnWrite.UseVisualStyleBackColor = false;
			this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
			// 
			// txtUsed
			// 
			this.txtUsed.AllowDrop = true;
			this.txtUsed.BackColor = System.Drawing.SystemColors.Control;
			this.txtUsed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtUsed.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtUsed.Location = new System.Drawing.Point(24, 492);
			this.txtUsed.Name = "txtUsed";
			this.txtUsed.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtUsed.Size = new System.Drawing.Size(161, 21);
			this.txtUsed.TabIndex = 34;
			// 
			// _Phrase_12
			// 
			this._Phrase_12.AllowDrop = true;
			this._Phrase_12.BackColor = System.Drawing.SystemColors.Control;
			this._Phrase_12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._Phrase_12.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Phrase_12.Location = new System.Drawing.Point(372, 244);
			this._Phrase_12.Name = "_Phrase_12";
			this._Phrase_12.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Phrase_12.Size = new System.Drawing.Size(321, 57);
			this._Phrase_12.TabIndex = 15;
			this._Phrase_12.Click += new System.EventHandler(this.Phrase_Click);
			// 
			// _Phrase_13
			// 
			this._Phrase_13.AllowDrop = true;
			this._Phrase_13.BackColor = System.Drawing.SystemColors.Control;
			this._Phrase_13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._Phrase_13.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Phrase_13.Location = new System.Drawing.Point(372, 304);
			this._Phrase_13.Name = "_Phrase_13";
			this._Phrase_13.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Phrase_13.Size = new System.Drawing.Size(321, 58);
			this._Phrase_13.TabIndex = 14;
			this._Phrase_13.Click += new System.EventHandler(this.Phrase_Click);
			// 
			// _Phrase_14
			// 
			this._Phrase_14.AllowDrop = true;
			this._Phrase_14.BackColor = System.Drawing.SystemColors.Control;
			this._Phrase_14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._Phrase_14.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Phrase_14.Location = new System.Drawing.Point(372, 364);
			this._Phrase_14.Name = "_Phrase_14";
			this._Phrase_14.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Phrase_14.Size = new System.Drawing.Size(321, 58);
			this._Phrase_14.TabIndex = 13;
			this._Phrase_14.Click += new System.EventHandler(this.Phrase_Click);
			// 
			// _Phrase_15
			// 
			this._Phrase_15.AllowDrop = true;
			this._Phrase_15.BackColor = System.Drawing.SystemColors.Control;
			this._Phrase_15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._Phrase_15.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Phrase_15.Location = new System.Drawing.Point(372, 424);
			this._Phrase_15.Name = "_Phrase_15";
			this._Phrase_15.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Phrase_15.Size = new System.Drawing.Size(321, 58);
			this._Phrase_15.TabIndex = 12;
			this._Phrase_15.Click += new System.EventHandler(this.Phrase_Click);
			// 
			// _Phrase_8
			// 
			this._Phrase_8.AllowDrop = true;
			this._Phrase_8.BackColor = System.Drawing.SystemColors.Control;
			this._Phrase_8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._Phrase_8.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Phrase_8.Location = new System.Drawing.Point(372, 4);
			this._Phrase_8.Name = "_Phrase_8";
			this._Phrase_8.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Phrase_8.Size = new System.Drawing.Size(321, 57);
			this._Phrase_8.TabIndex = 11;
			this._Phrase_8.Click += new System.EventHandler(this.Phrase_Click);
			// 
			// _Phrase_9
			// 
			this._Phrase_9.AllowDrop = true;
			this._Phrase_9.BackColor = System.Drawing.SystemColors.Control;
			this._Phrase_9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._Phrase_9.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Phrase_9.Location = new System.Drawing.Point(372, 64);
			this._Phrase_9.Name = "_Phrase_9";
			this._Phrase_9.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Phrase_9.Size = new System.Drawing.Size(321, 58);
			this._Phrase_9.TabIndex = 10;
			this._Phrase_9.Click += new System.EventHandler(this.Phrase_Click);
			// 
			// _Phrase_10
			// 
			this._Phrase_10.AllowDrop = true;
			this._Phrase_10.BackColor = System.Drawing.SystemColors.Control;
			this._Phrase_10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._Phrase_10.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Phrase_10.Location = new System.Drawing.Point(372, 124);
			this._Phrase_10.Name = "_Phrase_10";
			this._Phrase_10.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Phrase_10.Size = new System.Drawing.Size(321, 58);
			this._Phrase_10.TabIndex = 9;
			this._Phrase_10.Click += new System.EventHandler(this.Phrase_Click);
			// 
			// _Phrase_11
			// 
			this._Phrase_11.AllowDrop = true;
			this._Phrase_11.BackColor = System.Drawing.SystemColors.Control;
			this._Phrase_11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._Phrase_11.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Phrase_11.Location = new System.Drawing.Point(372, 184);
			this._Phrase_11.Name = "_Phrase_11";
			this._Phrase_11.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Phrase_11.Size = new System.Drawing.Size(321, 58);
			this._Phrase_11.TabIndex = 8;
			this._Phrase_11.Click += new System.EventHandler(this.Phrase_Click);
			// 
			// _Phrase_7
			// 
			this._Phrase_7.AllowDrop = true;
			this._Phrase_7.BackColor = System.Drawing.SystemColors.Control;
			this._Phrase_7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._Phrase_7.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Phrase_7.Location = new System.Drawing.Point(24, 424);
			this._Phrase_7.Name = "_Phrase_7";
			this._Phrase_7.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Phrase_7.Size = new System.Drawing.Size(321, 58);
			this._Phrase_7.TabIndex = 4;
			this._Phrase_7.Click += new System.EventHandler(this.Phrase_Click);
			// 
			// _Phrase_6
			// 
			this._Phrase_6.AllowDrop = true;
			this._Phrase_6.BackColor = System.Drawing.SystemColors.Control;
			this._Phrase_6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._Phrase_6.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Phrase_6.Location = new System.Drawing.Point(24, 364);
			this._Phrase_6.Name = "_Phrase_6";
			this._Phrase_6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Phrase_6.Size = new System.Drawing.Size(321, 58);
			this._Phrase_6.TabIndex = 5;
			this._Phrase_6.Click += new System.EventHandler(this.Phrase_Click);
			// 
			// _Phrase_5
			// 
			this._Phrase_5.AllowDrop = true;
			this._Phrase_5.BackColor = System.Drawing.SystemColors.Control;
			this._Phrase_5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._Phrase_5.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Phrase_5.Location = new System.Drawing.Point(24, 304);
			this._Phrase_5.Name = "_Phrase_5";
			this._Phrase_5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Phrase_5.Size = new System.Drawing.Size(321, 58);
			this._Phrase_5.TabIndex = 6;
			this._Phrase_5.Click += new System.EventHandler(this.Phrase_Click);
			// 
			// _Phrase_4
			// 
			this._Phrase_4.AllowDrop = true;
			this._Phrase_4.BackColor = System.Drawing.SystemColors.Control;
			this._Phrase_4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._Phrase_4.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Phrase_4.Location = new System.Drawing.Point(24, 244);
			this._Phrase_4.Name = "_Phrase_4";
			this._Phrase_4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Phrase_4.Size = new System.Drawing.Size(321, 57);
			this._Phrase_4.TabIndex = 7;
			this._Phrase_4.Click += new System.EventHandler(this.Phrase_Click);
			// 
			// _Phrase_3
			// 
			this._Phrase_3.AllowDrop = true;
			this._Phrase_3.BackColor = System.Drawing.SystemColors.Control;
			this._Phrase_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._Phrase_3.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Phrase_3.Location = new System.Drawing.Point(24, 184);
			this._Phrase_3.Name = "_Phrase_3";
			this._Phrase_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Phrase_3.Size = new System.Drawing.Size(321, 58);
			this._Phrase_3.TabIndex = 3;
			this._Phrase_3.Click += new System.EventHandler(this.Phrase_Click);
			// 
			// _Phrase_2
			// 
			this._Phrase_2.AllowDrop = true;
			this._Phrase_2.BackColor = System.Drawing.SystemColors.Control;
			this._Phrase_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._Phrase_2.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Phrase_2.Location = new System.Drawing.Point(24, 124);
			this._Phrase_2.Name = "_Phrase_2";
			this._Phrase_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Phrase_2.Size = new System.Drawing.Size(321, 58);
			this._Phrase_2.TabIndex = 2;
			this._Phrase_2.Click += new System.EventHandler(this.Phrase_Click);
			// 
			// _Phrase_1
			// 
			this._Phrase_1.AllowDrop = true;
			this._Phrase_1.BackColor = System.Drawing.SystemColors.Control;
			this._Phrase_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._Phrase_1.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Phrase_1.Location = new System.Drawing.Point(24, 64);
			this._Phrase_1.Name = "_Phrase_1";
			this._Phrase_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Phrase_1.Size = new System.Drawing.Size(321, 58);
			this._Phrase_1.TabIndex = 1;
			this._Phrase_1.Click += new System.EventHandler(this.Phrase_Click);
			// 
			// _Phrase_0
			// 
			this._Phrase_0.AllowDrop = true;
			this._Phrase_0.BackColor = System.Drawing.SystemColors.Control;
			this._Phrase_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._Phrase_0.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Phrase_0.Location = new System.Drawing.Point(24, 4);
			this._Phrase_0.Name = "_Phrase_0";
			this._Phrase_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Phrase_0.Size = new System.Drawing.Size(321, 57);
			this._Phrase_0.TabIndex = 0;
			this._Phrase_0.Click += new System.EventHandler(this.Phrase_Click);
			// 
			// _lbs_15
			// 
			this._lbs_15.AllowDrop = true;
			this._lbs_15.BackColor = System.Drawing.SystemColors.Window;
			this._lbs_15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._lbs_15.ForeColor = System.Drawing.SystemColors.WindowText;
			this._lbs_15.Location = new System.Drawing.Point(352, 448);
			this._lbs_15.Name = "_lbs_15";
			this._lbs_15.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._lbs_15.Size = new System.Drawing.Size(21, 17);
			this._lbs_15.TabIndex = 31;
			this._lbs_15.Text = "15 ";
			this._lbs_15.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this._lbs_15.Click += new System.EventHandler(this.lbs_Click);
			// 
			// _lbs_14
			// 
			this._lbs_14.AllowDrop = true;
			this._lbs_14.BackColor = System.Drawing.SystemColors.Window;
			this._lbs_14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._lbs_14.ForeColor = System.Drawing.SystemColors.WindowText;
			this._lbs_14.Location = new System.Drawing.Point(352, 388);
			this._lbs_14.Name = "_lbs_14";
			this._lbs_14.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._lbs_14.Size = new System.Drawing.Size(21, 17);
			this._lbs_14.TabIndex = 30;
			this._lbs_14.Text = "14 ";
			this._lbs_14.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this._lbs_14.Click += new System.EventHandler(this.lbs_Click);
			// 
			// _lbs_13
			// 
			this._lbs_13.AllowDrop = true;
			this._lbs_13.BackColor = System.Drawing.SystemColors.Window;
			this._lbs_13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._lbs_13.ForeColor = System.Drawing.SystemColors.WindowText;
			this._lbs_13.Location = new System.Drawing.Point(352, 328);
			this._lbs_13.Name = "_lbs_13";
			this._lbs_13.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._lbs_13.Size = new System.Drawing.Size(21, 17);
			this._lbs_13.TabIndex = 29;
			this._lbs_13.Text = "13 ";
			this._lbs_13.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this._lbs_13.Click += new System.EventHandler(this.lbs_Click);
			// 
			// _lbs_12
			// 
			this._lbs_12.AllowDrop = true;
			this._lbs_12.BackColor = System.Drawing.SystemColors.Window;
			this._lbs_12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._lbs_12.ForeColor = System.Drawing.SystemColors.WindowText;
			this._lbs_12.Location = new System.Drawing.Point(352, 268);
			this._lbs_12.Name = "_lbs_12";
			this._lbs_12.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._lbs_12.Size = new System.Drawing.Size(21, 17);
			this._lbs_12.TabIndex = 28;
			this._lbs_12.Text = "12 ";
			this._lbs_12.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this._lbs_12.Click += new System.EventHandler(this.lbs_Click);
			// 
			// _lbs_11
			// 
			this._lbs_11.AllowDrop = true;
			this._lbs_11.BackColor = System.Drawing.SystemColors.Window;
			this._lbs_11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._lbs_11.ForeColor = System.Drawing.SystemColors.WindowText;
			this._lbs_11.Location = new System.Drawing.Point(352, 208);
			this._lbs_11.Name = "_lbs_11";
			this._lbs_11.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._lbs_11.Size = new System.Drawing.Size(21, 17);
			this._lbs_11.TabIndex = 27;
			this._lbs_11.Text = "11 ";
			this._lbs_11.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this._lbs_11.Click += new System.EventHandler(this.lbs_Click);
			// 
			// _lbs_10
			// 
			this._lbs_10.AllowDrop = true;
			this._lbs_10.BackColor = System.Drawing.SystemColors.Window;
			this._lbs_10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._lbs_10.ForeColor = System.Drawing.SystemColors.WindowText;
			this._lbs_10.Location = new System.Drawing.Point(352, 148);
			this._lbs_10.Name = "_lbs_10";
			this._lbs_10.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._lbs_10.Size = new System.Drawing.Size(21, 17);
			this._lbs_10.TabIndex = 26;
			this._lbs_10.Text = "10 ";
			this._lbs_10.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this._lbs_10.Click += new System.EventHandler(this.lbs_Click);
			// 
			// _lbs_9
			// 
			this._lbs_9.AllowDrop = true;
			this._lbs_9.BackColor = System.Drawing.SystemColors.Window;
			this._lbs_9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._lbs_9.ForeColor = System.Drawing.SystemColors.WindowText;
			this._lbs_9.Location = new System.Drawing.Point(352, 88);
			this._lbs_9.Name = "_lbs_9";
			this._lbs_9.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._lbs_9.Size = new System.Drawing.Size(21, 17);
			this._lbs_9.TabIndex = 25;
			this._lbs_9.Text = "9 ";
			this._lbs_9.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this._lbs_9.Click += new System.EventHandler(this.lbs_Click);
			// 
			// _lbs_8
			// 
			this._lbs_8.AllowDrop = true;
			this._lbs_8.BackColor = System.Drawing.SystemColors.Window;
			this._lbs_8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._lbs_8.ForeColor = System.Drawing.SystemColors.WindowText;
			this._lbs_8.Location = new System.Drawing.Point(352, 24);
			this._lbs_8.Name = "_lbs_8";
			this._lbs_8.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._lbs_8.Size = new System.Drawing.Size(21, 17);
			this._lbs_8.TabIndex = 24;
			this._lbs_8.Text = "8 ";
			this._lbs_8.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this._lbs_8.Click += new System.EventHandler(this.lbs_Click);
			// 
			// _lbs_7
			// 
			this._lbs_7.AllowDrop = true;
			this._lbs_7.BackColor = System.Drawing.SystemColors.Window;
			this._lbs_7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._lbs_7.ForeColor = System.Drawing.SystemColors.WindowText;
			this._lbs_7.Location = new System.Drawing.Point(4, 444);
			this._lbs_7.Name = "_lbs_7";
			this._lbs_7.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._lbs_7.Size = new System.Drawing.Size(21, 17);
			this._lbs_7.TabIndex = 23;
			this._lbs_7.Text = "7 ";
			this._lbs_7.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this._lbs_7.Click += new System.EventHandler(this.lbs_Click);
			// 
			// _lbs_6
			// 
			this._lbs_6.AllowDrop = true;
			this._lbs_6.BackColor = System.Drawing.SystemColors.Window;
			this._lbs_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._lbs_6.ForeColor = System.Drawing.SystemColors.WindowText;
			this._lbs_6.Location = new System.Drawing.Point(4, 384);
			this._lbs_6.Name = "_lbs_6";
			this._lbs_6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._lbs_6.Size = new System.Drawing.Size(21, 17);
			this._lbs_6.TabIndex = 22;
			this._lbs_6.Text = "6 ";
			this._lbs_6.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this._lbs_6.Click += new System.EventHandler(this.lbs_Click);
			// 
			// _lbs_5
			// 
			this._lbs_5.AllowDrop = true;
			this._lbs_5.BackColor = System.Drawing.SystemColors.Window;
			this._lbs_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._lbs_5.ForeColor = System.Drawing.SystemColors.WindowText;
			this._lbs_5.Location = new System.Drawing.Point(4, 328);
			this._lbs_5.Name = "_lbs_5";
			this._lbs_5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._lbs_5.Size = new System.Drawing.Size(21, 17);
			this._lbs_5.TabIndex = 21;
			this._lbs_5.Text = "5 ";
			this._lbs_5.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this._lbs_5.Click += new System.EventHandler(this.lbs_Click);
			// 
			// _lbs_4
			// 
			this._lbs_4.AllowDrop = true;
			this._lbs_4.BackColor = System.Drawing.SystemColors.Window;
			this._lbs_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._lbs_4.ForeColor = System.Drawing.SystemColors.WindowText;
			this._lbs_4.Location = new System.Drawing.Point(4, 268);
			this._lbs_4.Name = "_lbs_4";
			this._lbs_4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._lbs_4.Size = new System.Drawing.Size(21, 17);
			this._lbs_4.TabIndex = 20;
			this._lbs_4.Text = "4 ";
			this._lbs_4.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this._lbs_4.Click += new System.EventHandler(this.lbs_Click);
			// 
			// _lbs_3
			// 
			this._lbs_3.AllowDrop = true;
			this._lbs_3.BackColor = System.Drawing.SystemColors.Window;
			this._lbs_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._lbs_3.ForeColor = System.Drawing.SystemColors.WindowText;
			this._lbs_3.Location = new System.Drawing.Point(4, 208);
			this._lbs_3.Name = "_lbs_3";
			this._lbs_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._lbs_3.Size = new System.Drawing.Size(21, 17);
			this._lbs_3.TabIndex = 19;
			this._lbs_3.Text = "3 ";
			this._lbs_3.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this._lbs_3.Click += new System.EventHandler(this.lbs_Click);
			// 
			// _lbs_2
			// 
			this._lbs_2.AllowDrop = true;
			this._lbs_2.BackColor = System.Drawing.SystemColors.Window;
			this._lbs_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._lbs_2.ForeColor = System.Drawing.SystemColors.WindowText;
			this._lbs_2.Location = new System.Drawing.Point(4, 144);
			this._lbs_2.Name = "_lbs_2";
			this._lbs_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._lbs_2.Size = new System.Drawing.Size(21, 17);
			this._lbs_2.TabIndex = 18;
			this._lbs_2.Text = "2 ";
			this._lbs_2.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this._lbs_2.Click += new System.EventHandler(this.lbs_Click);
			// 
			// _lbs_1
			// 
			this._lbs_1.AllowDrop = true;
			this._lbs_1.BackColor = System.Drawing.SystemColors.Window;
			this._lbs_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._lbs_1.ForeColor = System.Drawing.SystemColors.WindowText;
			this._lbs_1.Location = new System.Drawing.Point(4, 84);
			this._lbs_1.Name = "_lbs_1";
			this._lbs_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._lbs_1.Size = new System.Drawing.Size(21, 17);
			this._lbs_1.TabIndex = 17;
			this._lbs_1.Text = "1 ";
			this._lbs_1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this._lbs_1.Click += new System.EventHandler(this.lbs_Click);
			// 
			// _lbs_0
			// 
			this._lbs_0.AllowDrop = true;
			this._lbs_0.BackColor = System.Drawing.SystemColors.Window;
			this._lbs_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._lbs_0.ForeColor = System.Drawing.SystemColors.WindowText;
			this._lbs_0.Location = new System.Drawing.Point(4, 24);
			this._lbs_0.Name = "_lbs_0";
			this._lbs_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._lbs_0.Size = new System.Drawing.Size(21, 17);
			this._lbs_0.TabIndex = 16;
			this._lbs_0.Text = "0 ";
			this._lbs_0.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this._lbs_0.Click += new System.EventHandler(this.lbs_Click);
			// 
			// frmEEPROM
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(697, 528);
			this.Controls.Add(this.btnShutUp);
			this.Controls.Add(this.btnDone);
			this.Controls.Add(this.btnWrite);
			this.Controls.Add(this.txtUsed);
			this.Controls.Add(this._Phrase_12);
			this.Controls.Add(this._Phrase_13);
			this.Controls.Add(this._Phrase_14);
			this.Controls.Add(this._Phrase_15);
			this.Controls.Add(this._Phrase_8);
			this.Controls.Add(this._Phrase_9);
			this.Controls.Add(this._Phrase_10);
			this.Controls.Add(this._Phrase_11);
			this.Controls.Add(this._Phrase_7);
			this.Controls.Add(this._Phrase_6);
			this.Controls.Add(this._Phrase_5);
			this.Controls.Add(this._Phrase_4);
			this.Controls.Add(this._Phrase_3);
			this.Controls.Add(this._Phrase_2);
			this.Controls.Add(this._Phrase_1);
			this.Controls.Add(this._Phrase_0);
			this.Controls.Add(this._lbs_15);
			this.Controls.Add(this._lbs_14);
			this.Controls.Add(this._lbs_13);
			this.Controls.Add(this._lbs_12);
			this.Controls.Add(this._lbs_11);
			this.Controls.Add(this._lbs_10);
			this.Controls.Add(this._lbs_9);
			this.Controls.Add(this._lbs_8);
			this.Controls.Add(this._lbs_7);
			this.Controls.Add(this._lbs_6);
			this.Controls.Add(this._lbs_5);
			this.Controls.Add(this._lbs_4);
			this.Controls.Add(this._lbs_3);
			this.Controls.Add(this._lbs_2);
			this.Controls.Add(this._lbs_1);
			this.Controls.Add(this._lbs_0);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Location = new System.Drawing.Point(10, 30);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmEEPROM";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SpeakJet EEPROM Editor";
			this.ToolTipMain.SetToolTip(this.btnShutUp, "Stop the SpeakJet now.");
			this.Closed += new System.EventHandler(this.Form_Closed);
			this.ResumeLayout(false);
		}
		void ReLoadForm(bool addEvents)
		{
			Initializelbs();
			InitializePhrase();
		}
		void Initializelbs()
		{
			this.lbs = new System.Windows.Forms.Label[16];
			this.lbs[15] = _lbs_15;
			this.lbs[14] = _lbs_14;
			this.lbs[13] = _lbs_13;
			this.lbs[12] = _lbs_12;
			this.lbs[11] = _lbs_11;
			this.lbs[10] = _lbs_10;
			this.lbs[9] = _lbs_9;
			this.lbs[8] = _lbs_8;
			this.lbs[7] = _lbs_7;
			this.lbs[6] = _lbs_6;
			this.lbs[5] = _lbs_5;
			this.lbs[4] = _lbs_4;
			this.lbs[3] = _lbs_3;
			this.lbs[2] = _lbs_2;
			this.lbs[1] = _lbs_1;
			this.lbs[0] = _lbs_0;
		}
		void InitializePhrase()
		{
			this.Phrase = new System.Windows.Forms.Label[16];
			this.Phrase[12] = _Phrase_12;
			this.Phrase[13] = _Phrase_13;
			this.Phrase[14] = _Phrase_14;
			this.Phrase[15] = _Phrase_15;
			this.Phrase[8] = _Phrase_8;
			this.Phrase[9] = _Phrase_9;
			this.Phrase[10] = _Phrase_10;
			this.Phrase[11] = _Phrase_11;
			this.Phrase[7] = _Phrase_7;
			this.Phrase[6] = _Phrase_6;
			this.Phrase[5] = _Phrase_5;
			this.Phrase[4] = _Phrase_4;
			this.Phrase[3] = _Phrase_3;
			this.Phrase[2] = _Phrase_2;
			this.Phrase[1] = _Phrase_1;
			this.Phrase[0] = _Phrase_0;
		}
		#endregion
	}
}