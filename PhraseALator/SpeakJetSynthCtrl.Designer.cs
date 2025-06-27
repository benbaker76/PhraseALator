
namespace PhraseALator
{
	partial class FrmSynthCtrl
	{

		#region "Upgrade Support "
		private static FrmSynthCtrl m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static FrmSynthCtrl DefInstance
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
		public static FrmSynthCtrl CreateInstance()
		{
			FrmSynthCtrl theInstance = new FrmSynthCtrl();
			theInstance.Form_Load();
			return theInstance;
		}
		private string[] visualControls = new string[]{"components", "ToolTipMain", "btnSave", "btnLoad", "txtSound", "scFreqAdjTone", "Command3", "txtHFreq", "Command1", "scVolAdjTone", "Command2", "Label5", "Line2", "Line1", "Label4", "Label2", "Frame2", "_Check2_1", "_txtVol_1", "_txtFreq_1", "_scFreq_1", "_scVol_1", "_Label1_1", "_lbl1_1", "_FrameOsc_1", "_txtVol_2", "_txtFreq_2", "_scFreq_2", "_scVol_2", "_Label1_2", "_lbl1_2", "_FrameOsc_2", "_txtVol_3", "_txtFreq_3", "_scFreq_3", "_scVol_3", "_Label1_3", "_lbl1_3", "_FrameOsc_3", "Frame1", "btnDone", "btnShutUp", "txtEnvFreq", "_txtLevel_1", "scEnvolopeFreq", "_Option1_0", "_Option1_1", "_Option1_2", "_Option1_3", "_scLevel_1", "_lbl1_8", "_lbl1_0", "_lbl1_7", "_FrameOsc_7", "_txtLevel_0", "_Check2_0", "_txtVol_5", "_txtFreq_5", "_scVol_5", "_scFreq_5", "_lbl1_5", "_Label1_5", "_FrameOsc_5", "_txtVol_4", "_txtFreq_4", "_scFreq_4", "_scVol_4", "_Label1_4", "_lbl1_4", "_FrameOsc_4", "_scLevel_0", "_lbl1_6", "_FrameOsc_6", "Label3", "Check2", "FrameOsc", "Label1", "Option1", "lbl1", "scFreq", "scLevel", "scVol", "txtFreq", "txtLevel", "txtVol"};
		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ToolTip ToolTipMain;
		public System.Windows.Forms.Button btnSave;
		public System.Windows.Forms.Button btnLoad;
		public System.Windows.Forms.TextBox txtSound;
		public System.Windows.Forms.HScrollBar scFreqAdjTone;
		public System.Windows.Forms.Button Command3;
		public System.Windows.Forms.TextBox txtHFreq;
		public System.Windows.Forms.Button Command1;
		public System.Windows.Forms.HScrollBar scVolAdjTone;
		public System.Windows.Forms.Button Command2;
		public System.Windows.Forms.Label Label5;
		public System.Windows.Forms.Label Line2;
		public System.Windows.Forms.Label Line1;
		public System.Windows.Forms.Label Label4;
		public System.Windows.Forms.Label Label2;
		public System.Windows.Forms.GroupBox Frame2;
		private System.Windows.Forms.CheckBox _Check2_1;
		private System.Windows.Forms.TextBox _txtVol_1;
		private System.Windows.Forms.TextBox _txtFreq_1;
		private System.Windows.Forms.HScrollBar _scFreq_1;
		private System.Windows.Forms.HScrollBar _scVol_1;
		private System.Windows.Forms.Label _Label1_1;
		private System.Windows.Forms.Label _lbl1_1;
		private System.Windows.Forms.GroupBox _FrameOsc_1;
		private System.Windows.Forms.TextBox _txtVol_2;
		private System.Windows.Forms.TextBox _txtFreq_2;
		private System.Windows.Forms.HScrollBar _scFreq_2;
		private System.Windows.Forms.HScrollBar _scVol_2;
		private System.Windows.Forms.Label _Label1_2;
		private System.Windows.Forms.Label _lbl1_2;
		private System.Windows.Forms.GroupBox _FrameOsc_2;
		private System.Windows.Forms.TextBox _txtVol_3;
		private System.Windows.Forms.TextBox _txtFreq_3;
		private System.Windows.Forms.HScrollBar _scFreq_3;
		private System.Windows.Forms.HScrollBar _scVol_3;
		private System.Windows.Forms.Label _Label1_3;
		private System.Windows.Forms.Label _lbl1_3;
		private System.Windows.Forms.GroupBox _FrameOsc_3;
		public System.Windows.Forms.GroupBox Frame1;
		public System.Windows.Forms.Button btnDone;
		public System.Windows.Forms.Button btnShutUp;
		public System.Windows.Forms.TextBox txtEnvFreq;
		private System.Windows.Forms.TextBox _txtLevel_1;
		public System.Windows.Forms.HScrollBar scEnvolopeFreq;
		private System.Windows.Forms.RadioButton _Option1_0;
		private System.Windows.Forms.RadioButton _Option1_1;
		private System.Windows.Forms.RadioButton _Option1_2;
		private System.Windows.Forms.RadioButton _Option1_3;
		private System.Windows.Forms.HScrollBar _scLevel_1;
		private System.Windows.Forms.Label _lbl1_8;
		private System.Windows.Forms.Label _lbl1_0;
		private System.Windows.Forms.Label _lbl1_7;
		private System.Windows.Forms.GroupBox _FrameOsc_7;
		private System.Windows.Forms.TextBox _txtLevel_0;
		private System.Windows.Forms.CheckBox _Check2_0;
		private System.Windows.Forms.TextBox _txtVol_5;
		private System.Windows.Forms.TextBox _txtFreq_5;
		private System.Windows.Forms.HScrollBar _scVol_5;
		private System.Windows.Forms.HScrollBar _scFreq_5;
		private System.Windows.Forms.Label _lbl1_5;
		private System.Windows.Forms.Label _Label1_5;
		private System.Windows.Forms.GroupBox _FrameOsc_5;
		private System.Windows.Forms.TextBox _txtVol_4;
		private System.Windows.Forms.TextBox _txtFreq_4;
		private System.Windows.Forms.HScrollBar _scFreq_4;
		private System.Windows.Forms.HScrollBar _scVol_4;
		private System.Windows.Forms.Label _Label1_4;
		private System.Windows.Forms.Label _lbl1_4;
		private System.Windows.Forms.GroupBox _FrameOsc_4;
		private System.Windows.Forms.HScrollBar _scLevel_0;
		private System.Windows.Forms.Label _lbl1_6;
		private System.Windows.Forms.GroupBox _FrameOsc_6;
		public System.Windows.Forms.Label Label3;
		public System.Windows.Forms.CheckBox[] Check2 = new System.Windows.Forms.CheckBox[2];
		public System.Windows.Forms.GroupBox[] FrameOsc = new System.Windows.Forms.GroupBox[8];
		public System.Windows.Forms.Label[] Label1 = new System.Windows.Forms.Label[6];
		public System.Windows.Forms.RadioButton[] Option1 = new System.Windows.Forms.RadioButton[4];
		public System.Windows.Forms.Label[] lbl1 = new System.Windows.Forms.Label[9];
		public System.Windows.Forms.HScrollBar[] scFreq = new System.Windows.Forms.HScrollBar[6];
		public System.Windows.Forms.HScrollBar[] scLevel = new System.Windows.Forms.HScrollBar[2];
		public System.Windows.Forms.HScrollBar[] scVol = new System.Windows.Forms.HScrollBar[6];
		public System.Windows.Forms.TextBox[] txtFreq = new System.Windows.Forms.TextBox[6];
		public System.Windows.Forms.TextBox[] txtLevel = new System.Windows.Forms.TextBox[2];
		public System.Windows.Forms.TextBox[] txtVol = new System.Windows.Forms.TextBox[6];
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSynthCtrl));
			this.ToolTipMain = new System.Windows.Forms.ToolTip(this.components);
			this.btnSave = new System.Windows.Forms.Button();
			this.btnLoad = new System.Windows.Forms.Button();
			this.txtSound = new System.Windows.Forms.TextBox();
			this.Frame1 = new System.Windows.Forms.GroupBox();
			this.Frame2 = new System.Windows.Forms.GroupBox();
			this.scFreqAdjTone = new System.Windows.Forms.HScrollBar();
			this.Command3 = new System.Windows.Forms.Button();
			this.txtHFreq = new System.Windows.Forms.TextBox();
			this.Command1 = new System.Windows.Forms.Button();
			this.scVolAdjTone = new System.Windows.Forms.HScrollBar();
			this.Command2 = new System.Windows.Forms.Button();
			this.Label5 = new System.Windows.Forms.Label();
			this.Line2 = new System.Windows.Forms.Label();
			this.Line1 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this._Check2_1 = new System.Windows.Forms.CheckBox();
			this._FrameOsc_1 = new System.Windows.Forms.GroupBox();
			this._txtVol_1 = new System.Windows.Forms.TextBox();
			this._txtFreq_1 = new System.Windows.Forms.TextBox();
			this._scFreq_1 = new System.Windows.Forms.HScrollBar();
			this._scVol_1 = new System.Windows.Forms.HScrollBar();
			this._Label1_1 = new System.Windows.Forms.Label();
			this._lbl1_1 = new System.Windows.Forms.Label();
			this._FrameOsc_2 = new System.Windows.Forms.GroupBox();
			this._txtVol_2 = new System.Windows.Forms.TextBox();
			this._txtFreq_2 = new System.Windows.Forms.TextBox();
			this._scFreq_2 = new System.Windows.Forms.HScrollBar();
			this._scVol_2 = new System.Windows.Forms.HScrollBar();
			this._Label1_2 = new System.Windows.Forms.Label();
			this._lbl1_2 = new System.Windows.Forms.Label();
			this._FrameOsc_3 = new System.Windows.Forms.GroupBox();
			this._txtVol_3 = new System.Windows.Forms.TextBox();
			this._txtFreq_3 = new System.Windows.Forms.TextBox();
			this._scFreq_3 = new System.Windows.Forms.HScrollBar();
			this._scVol_3 = new System.Windows.Forms.HScrollBar();
			this._Label1_3 = new System.Windows.Forms.Label();
			this._lbl1_3 = new System.Windows.Forms.Label();
			this.btnDone = new System.Windows.Forms.Button();
			this.btnShutUp = new System.Windows.Forms.Button();
			this._FrameOsc_7 = new System.Windows.Forms.GroupBox();
			this.txtEnvFreq = new System.Windows.Forms.TextBox();
			this._txtLevel_1 = new System.Windows.Forms.TextBox();
			this.scEnvolopeFreq = new System.Windows.Forms.HScrollBar();
			this._Option1_0 = new System.Windows.Forms.RadioButton();
			this._Option1_1 = new System.Windows.Forms.RadioButton();
			this._Option1_2 = new System.Windows.Forms.RadioButton();
			this._Option1_3 = new System.Windows.Forms.RadioButton();
			this._scLevel_1 = new System.Windows.Forms.HScrollBar();
			this._lbl1_8 = new System.Windows.Forms.Label();
			this._lbl1_0 = new System.Windows.Forms.Label();
			this._lbl1_7 = new System.Windows.Forms.Label();
			this._FrameOsc_6 = new System.Windows.Forms.GroupBox();
			this._txtLevel_0 = new System.Windows.Forms.TextBox();
			this._Check2_0 = new System.Windows.Forms.CheckBox();
			this._FrameOsc_5 = new System.Windows.Forms.GroupBox();
			this._txtVol_5 = new System.Windows.Forms.TextBox();
			this._txtFreq_5 = new System.Windows.Forms.TextBox();
			this._scVol_5 = new System.Windows.Forms.HScrollBar();
			this._scFreq_5 = new System.Windows.Forms.HScrollBar();
			this._lbl1_5 = new System.Windows.Forms.Label();
			this._Label1_5 = new System.Windows.Forms.Label();
			this._FrameOsc_4 = new System.Windows.Forms.GroupBox();
			this._txtVol_4 = new System.Windows.Forms.TextBox();
			this._txtFreq_4 = new System.Windows.Forms.TextBox();
			this._scFreq_4 = new System.Windows.Forms.HScrollBar();
			this._scVol_4 = new System.Windows.Forms.HScrollBar();
			this._Label1_4 = new System.Windows.Forms.Label();
			this._lbl1_4 = new System.Windows.Forms.Label();
			this._scLevel_0 = new System.Windows.Forms.HScrollBar();
			this._lbl1_6 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Frame1.SuspendLayout();
			this.Frame2.SuspendLayout();
			this._FrameOsc_1.SuspendLayout();
			this._FrameOsc_2.SuspendLayout();
			this._FrameOsc_3.SuspendLayout();
			this._FrameOsc_7.SuspendLayout();
			this._FrameOsc_6.SuspendLayout();
			this._FrameOsc_5.SuspendLayout();
			this._FrameOsc_4.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnSave
			// 
			this.btnSave.AllowDrop = true;
			this.btnSave.BackColor = System.Drawing.SystemColors.Control;
			this.btnSave.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnSave.Location = new System.Drawing.Point(284, 496);
			this.btnSave.Name = "btnSave";
			this.btnSave.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnSave.Size = new System.Drawing.Size(77, 25);
			this.btnSave.TabIndex = 59;
			this.btnSave.Text = "Save";
			this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnLoad
			// 
			this.btnLoad.AllowDrop = true;
			this.btnLoad.BackColor = System.Drawing.SystemColors.Control;
			this.btnLoad.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnLoad.Location = new System.Drawing.Point(204, 496);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnLoad.Size = new System.Drawing.Size(77, 25);
			this.btnLoad.TabIndex = 58;
			this.btnLoad.Text = "Load";
			this.btnLoad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnLoad.UseVisualStyleBackColor = false;
			this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
			// 
			// txtSound
			// 
			this.txtSound.AcceptsReturn = true;
			this.txtSound.AllowDrop = true;
			this.txtSound.BackColor = System.Drawing.SystemColors.Window;
			this.txtSound.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtSound.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtSound.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtSound.Location = new System.Drawing.Point(104, 496);
			this.txtSound.MaxLength = 0;
			this.txtSound.Name = "txtSound";
			this.txtSound.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtSound.Size = new System.Drawing.Size(93, 23);
			this.txtSound.TabIndex = 56;
			// 
			// Frame1
			// 
			this.Frame1.AllowDrop = true;
			this.Frame1.BackColor = System.Drawing.SystemColors.Control;
			this.Frame1.Controls.Add(this.Frame2);
			this.Frame1.Controls.Add(this._Check2_1);
			this.Frame1.Controls.Add(this._FrameOsc_1);
			this.Frame1.Controls.Add(this._FrameOsc_2);
			this.Frame1.Controls.Add(this._FrameOsc_3);
			this.Frame1.Enabled = true;
			this.Frame1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame1.Location = new System.Drawing.Point(4, 80);
			this.Frame1.Name = "Frame1";
			this.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame1.Size = new System.Drawing.Size(617, 225);
			this.Frame1.TabIndex = 44;
			this.Frame1.Text = "Tone Generators";
			this.Frame1.Visible = true;
			// 
			// Frame2
			// 
			this.Frame2.AllowDrop = true;
			this.Frame2.BackColor = System.Drawing.SystemColors.Control;
			this.Frame2.Controls.Add(this.scFreqAdjTone);
			this.Frame2.Controls.Add(this.Command3);
			this.Frame2.Controls.Add(this.txtHFreq);
			this.Frame2.Controls.Add(this.Command1);
			this.Frame2.Controls.Add(this.scVolAdjTone);
			this.Frame2.Controls.Add(this.Command2);
			this.Frame2.Controls.Add(this.Label5);
			this.Frame2.Controls.Add(this.Line2);
			this.Frame2.Controls.Add(this.Line1);
			this.Frame2.Controls.Add(this.Label4);
			this.Frame2.Controls.Add(this.Label2);
			this.Frame2.Enabled = true;
			this.Frame2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Frame2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame2.Location = new System.Drawing.Point(8, 44);
			this.Frame2.Name = "Frame2";
			this.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame2.Size = new System.Drawing.Size(117, 173);
			this.Frame2.TabIndex = 60;
			this.Frame2.Text = "Tools";
			this.Frame2.Visible = true;
			// 
			// scFreqAdjTone
			// 
			this.scFreqAdjTone.AllowDrop = true;
			this.scFreqAdjTone.CausesValidation = true;
			this.scFreqAdjTone.Enabled = true;
			this.scFreqAdjTone.LargeChange = 1;
			this.scFreqAdjTone.Location = new System.Drawing.Point(4, 100);
			this.scFreqAdjTone.Maximum = 200;
			this.scFreqAdjTone.Minimum = 0;
			this.scFreqAdjTone.Name = "scFreqAdjTone";
			this.scFreqAdjTone.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.scFreqAdjTone.Size = new System.Drawing.Size(109, 17);
			this.scFreqAdjTone.SmallChange = 1;
			this.scFreqAdjTone.TabIndex = 68;
			this.scFreqAdjTone.TabStop = true;
			this.scFreqAdjTone.Value = 100;
			this.scFreqAdjTone.Visible = true;
			this.scFreqAdjTone.Enter += new System.EventHandler(this.scFreqAdjTone_Enter);
			this.scFreqAdjTone.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scFreqAdjTone_Scroll);
			this.scFreqAdjTone.ValueChanged += new System.EventHandler(this.scFreqAdjTone_ValueChanged);
			// 
			// Command3
			// 
			this.Command3.AllowDrop = true;
			this.Command3.BackColor = System.Drawing.SystemColors.Control;
			this.Command3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Command3.Location = new System.Drawing.Point(96, 80);
			this.Command3.Name = "Command3";
			this.Command3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Command3.Size = new System.Drawing.Size(17, 17);
			this.Command3.TabIndex = 67;
			this.Command3.Text = "Z";
			this.Command3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.Command3.UseVisualStyleBackColor = false;
			this.Command3.Click += new System.EventHandler(this.Command3_Click);
			// 
			// txtHFreq
			// 
			this.txtHFreq.AcceptsReturn = true;
			this.txtHFreq.AllowDrop = true;
			this.txtHFreq.BackColor = System.Drawing.SystemColors.Window;
			this.txtHFreq.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtHFreq.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtHFreq.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtHFreq.Location = new System.Drawing.Point(60, 44);
			this.txtHFreq.MaxLength = 0;
			this.txtHFreq.Name = "txtHFreq";
			this.txtHFreq.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtHFreq.Size = new System.Drawing.Size(41, 19);
			this.txtHFreq.TabIndex = 65;
			this.txtHFreq.Text = "110";
			// 
			// Command1
			// 
			this.Command1.AllowDrop = true;
			this.Command1.BackColor = System.Drawing.SystemColors.Control;
			this.Command1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Command1.Location = new System.Drawing.Point(16, 20);
			this.Command1.Name = "Command1";
			this.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Command1.Size = new System.Drawing.Size(85, 17);
			this.Command1.TabIndex = 63;
			this.Command1.Text = "Harmonise";
			this.Command1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.Command1.UseVisualStyleBackColor = false;
			this.Command1.Click += new System.EventHandler(this.Command1_Click);
			// 
			// scVolAdjTone
			// 
			this.scVolAdjTone.AllowDrop = true;
			this.scVolAdjTone.CausesValidation = true;
			this.scVolAdjTone.Enabled = true;
			this.scVolAdjTone.LargeChange = 1;
			this.scVolAdjTone.Location = new System.Drawing.Point(4, 152);
			this.scVolAdjTone.Maximum = 200;
			this.scVolAdjTone.Minimum = 0;
			this.scVolAdjTone.Name = "scVolAdjTone";
			this.scVolAdjTone.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.scVolAdjTone.Size = new System.Drawing.Size(109, 17);
			this.scVolAdjTone.SmallChange = 1;
			this.scVolAdjTone.TabIndex = 62;
			this.scVolAdjTone.TabStop = true;
			this.scVolAdjTone.Value = 100;
			this.scVolAdjTone.Visible = true;
			this.scVolAdjTone.Enter += new System.EventHandler(this.scVolAdjTone_Enter);
			this.scVolAdjTone.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scVolAdjTone_Scroll);
			this.scVolAdjTone.ValueChanged += new System.EventHandler(this.scVolAdjTone_ValueChanged);
			// 
			// Command2
			// 
			this.Command2.AllowDrop = true;
			this.Command2.BackColor = System.Drawing.SystemColors.Control;
			this.Command2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Command2.Location = new System.Drawing.Point(96, 132);
			this.Command2.Name = "Command2";
			this.Command2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Command2.Size = new System.Drawing.Size(17, 17);
			this.Command2.TabIndex = 61;
			this.Command2.Text = "Z";
			this.Command2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.Command2.UseVisualStyleBackColor = false;
			this.Command2.Click += new System.EventHandler(this.Command2_Click);
			// 
			// Label5
			// 
			this.Label5.AllowDrop = true;
			this.Label5.BackColor = System.Drawing.SystemColors.Control;
			this.Label5.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label5.Location = new System.Drawing.Point(28, 80);
			this.Label5.Name = "Label5";
			this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label5.Size = new System.Drawing.Size(61, 13);
			this.Label5.TabIndex = 69;
			this.Label5.Text = "Freq Adj";
			this.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// Line2
			// 
			this.Line2.AllowDrop = true;
			this.Line2.BackColor = System.Drawing.SystemColors.ControlDark;
			this.Line2.Enabled = false;
			this.Line2.Location = new System.Drawing.Point(0, 1800);
			this.Line2.Name = "Line2";
			this.Line2.Size = new System.Drawing.Size(1740, 1);
			this.Line2.Visible = true;
			// 
			// Line1
			// 
			this.Line1.AllowDrop = true;
			this.Line1.BackColor = System.Drawing.SystemColors.ControlDark;
			this.Line1.Enabled = false;
			this.Line1.Location = new System.Drawing.Point(0, 1020);
			this.Line1.Name = "Line1";
			this.Line1.Size = new System.Drawing.Size(1740, 1);
			this.Line1.Visible = true;
			// 
			// Label4
			// 
			this.Label4.AllowDrop = true;
			this.Label4.BackColor = System.Drawing.SystemColors.Control;
			this.Label4.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label4.Location = new System.Drawing.Point(20, 48);
			this.Label4.Name = "Label4";
			this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label4.Size = new System.Drawing.Size(37, 13);
			this.Label4.TabIndex = 66;
			this.Label4.Text = "H-Freq:";
			this.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// Label2
			// 
			this.Label2.AllowDrop = true;
			this.Label2.BackColor = System.Drawing.SystemColors.Control;
			this.Label2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label2.Location = new System.Drawing.Point(28, 132);
			this.Label2.Name = "Label2";
			this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label2.Size = new System.Drawing.Size(61, 13);
			this.Label2.TabIndex = 64;
			this.Label2.Text = "Volume Adj";
			this.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// _Check2_1
			// 
			this._Check2_1.AllowDrop = true;
			this._Check2_1.Appearance = System.Windows.Forms.Appearance.Normal;
			this._Check2_1.BackColor = System.Drawing.SystemColors.Control;
			this._Check2_1.CausesValidation = true;
			this._Check2_1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._Check2_1.CheckState = System.Windows.Forms.CheckState.Unchecked;
			this._Check2_1.Enabled = true;
			this._Check2_1.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Check2_1.Location = new System.Drawing.Point(52, 24);
			this._Check2_1.Name = "_Check2_1";
			this._Check2_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Check2_1.Size = new System.Drawing.Size(73, 13);
			this._Check2_1.TabIndex = 32;
			this._Check2_1.TabStop = true;
			this._Check2_1.Text = "Enveloped";
			this._Check2_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._Check2_1.Visible = true;
			this._Check2_1.CheckStateChanged += new System.EventHandler(this.Check2_CheckStateChanged);
			// 
			// _FrameOsc_1
			// 
			this._FrameOsc_1.AllowDrop = true;
			this._FrameOsc_1.BackColor = System.Drawing.SystemColors.Control;
			this._FrameOsc_1.Controls.Add(this._txtVol_1);
			this._FrameOsc_1.Controls.Add(this._txtFreq_1);
			this._FrameOsc_1.Controls.Add(this._scFreq_1);
			this._FrameOsc_1.Controls.Add(this._scVol_1);
			this._FrameOsc_1.Controls.Add(this._Label1_1);
			this._FrameOsc_1.Controls.Add(this._lbl1_1);
			this._FrameOsc_1.Enabled = true;
			this._FrameOsc_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this._FrameOsc_1.ForeColor = System.Drawing.SystemColors.ControlText;
			this._FrameOsc_1.Location = new System.Drawing.Point(132, 16);
			this._FrameOsc_1.Name = "_FrameOsc_1";
			this._FrameOsc_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._FrameOsc_1.Size = new System.Drawing.Size(473, 65);
			this._FrameOsc_1.TabIndex = 51;
			this._FrameOsc_1.Text = "Oscillator #1";
			this._FrameOsc_1.Visible = true;
			// 
			// _txtVol_1
			// 
			this._txtVol_1.AcceptsReturn = true;
			this._txtVol_1.AllowDrop = true;
			this._txtVol_1.BackColor = System.Drawing.SystemColors.Window;
			this._txtVol_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._txtVol_1.Cursor = System.Windows.Forms.Cursors.IBeam;
			this._txtVol_1.ForeColor = System.Drawing.SystemColors.WindowText;
			this._txtVol_1.Location = new System.Drawing.Point(68, 40);
			this._txtVol_1.MaxLength = 0;
			this._txtVol_1.Name = "_txtVol_1";
			this._txtVol_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._txtVol_1.Size = new System.Drawing.Size(45, 19);
			this._txtVol_1.TabIndex = 3;
			this._txtVol_1.Leave += new System.EventHandler(this.txtVol_Leave);
			// 
			// _txtFreq_1
			// 
			this._txtFreq_1.AcceptsReturn = true;
			this._txtFreq_1.AllowDrop = true;
			this._txtFreq_1.BackColor = System.Drawing.SystemColors.Window;
			this._txtFreq_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._txtFreq_1.Cursor = System.Windows.Forms.Cursors.IBeam;
			this._txtFreq_1.ForeColor = System.Drawing.SystemColors.WindowText;
			this._txtFreq_1.Location = new System.Drawing.Point(68, 20);
			this._txtFreq_1.MaxLength = 0;
			this._txtFreq_1.Name = "_txtFreq_1";
			this._txtFreq_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._txtFreq_1.Size = new System.Drawing.Size(45, 19);
			this._txtFreq_1.TabIndex = 2;
			this._txtFreq_1.Leave += new System.EventHandler(this.txtFreq_Leave);
			// 
			// _scFreq_1
			// 
			this._scFreq_1.AllowDrop = true;
			this._scFreq_1.CausesValidation = true;
			this._scFreq_1.Enabled = true;
			this._scFreq_1.LargeChange = 22;
			this._scFreq_1.Location = new System.Drawing.Point(116, 20);
			this._scFreq_1.Maximum = 4020;
			this._scFreq_1.Minimum = 0;
			this._scFreq_1.Name = "_scFreq_1";
			this._scFreq_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._scFreq_1.Size = new System.Drawing.Size(345, 17);
			this._scFreq_1.SmallChange = 1;
			this._scFreq_1.TabIndex = 15;
			this._scFreq_1.TabStop = true;
			this._scFreq_1.Value = 1;
			this._scFreq_1.Visible = true;
			this._scFreq_1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scFreq_Scroll);
			this._scFreq_1.ValueChanged += new System.EventHandler(this.scFreq_ValueChanged);
			// 
			// _scVol_1
			// 
			this._scVol_1.AllowDrop = true;
			this._scVol_1.CausesValidation = true;
			this._scVol_1.Enabled = true;
			this._scVol_1.LargeChange = 4;
			this._scVol_1.Location = new System.Drawing.Point(116, 40);
			this._scVol_1.Maximum = 34;
			this._scVol_1.Minimum = 0;
			this._scVol_1.Name = "_scVol_1";
			this._scVol_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._scVol_1.Size = new System.Drawing.Size(345, 17);
			this._scVol_1.SmallChange = 1;
			this._scVol_1.TabIndex = 16;
			this._scVol_1.TabStop = true;
			this._scVol_1.Value = 1;
			this._scVol_1.Visible = true;
			this._scVol_1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scVol_Scroll);
			this._scVol_1.ValueChanged += new System.EventHandler(this.scVol_ValueChanged);
			// 
			// _Label1_1
			// 
			this._Label1_1.AllowDrop = true;
			this._Label1_1.BackColor = System.Drawing.SystemColors.Control;
			this._Label1_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._Label1_1.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Label1_1.Location = new System.Drawing.Point(8, 40);
			this._Label1_1.Name = "_Label1_1";
			this._Label1_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Label1_1.Size = new System.Drawing.Size(53, 17);
			this._Label1_1.TabIndex = 53;
			this._Label1_1.Text = "Volume:";
			this._Label1_1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _lbl1_1
			// 
			this._lbl1_1.AllowDrop = true;
			this._lbl1_1.BackColor = System.Drawing.SystemColors.Control;
			this._lbl1_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._lbl1_1.ForeColor = System.Drawing.SystemColors.ControlText;
			this._lbl1_1.Location = new System.Drawing.Point(8, 20);
			this._lbl1_1.Name = "_lbl1_1";
			this._lbl1_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._lbl1_1.Size = new System.Drawing.Size(53, 17);
			this._lbl1_1.TabIndex = 52;
			this._lbl1_1.Text = "Frequency:";
			this._lbl1_1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _FrameOsc_2
			// 
			this._FrameOsc_2.AllowDrop = true;
			this._FrameOsc_2.BackColor = System.Drawing.SystemColors.Control;
			this._FrameOsc_2.Controls.Add(this._txtVol_2);
			this._FrameOsc_2.Controls.Add(this._txtFreq_2);
			this._FrameOsc_2.Controls.Add(this._scFreq_2);
			this._FrameOsc_2.Controls.Add(this._scVol_2);
			this._FrameOsc_2.Controls.Add(this._Label1_2);
			this._FrameOsc_2.Controls.Add(this._lbl1_2);
			this._FrameOsc_2.Enabled = true;
			this._FrameOsc_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this._FrameOsc_2.ForeColor = System.Drawing.SystemColors.ControlText;
			this._FrameOsc_2.Location = new System.Drawing.Point(132, 84);
			this._FrameOsc_2.Name = "_FrameOsc_2";
			this._FrameOsc_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._FrameOsc_2.Size = new System.Drawing.Size(473, 65);
			this._FrameOsc_2.TabIndex = 48;
			this._FrameOsc_2.Text = "Oscillator #2";
			this._FrameOsc_2.Visible = true;
			// 
			// _txtVol_2
			// 
			this._txtVol_2.AcceptsReturn = true;
			this._txtVol_2.AllowDrop = true;
			this._txtVol_2.BackColor = System.Drawing.SystemColors.Window;
			this._txtVol_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._txtVol_2.Cursor = System.Windows.Forms.Cursors.IBeam;
			this._txtVol_2.ForeColor = System.Drawing.SystemColors.WindowText;
			this._txtVol_2.Location = new System.Drawing.Point(68, 40);
			this._txtVol_2.MaxLength = 0;
			this._txtVol_2.Name = "_txtVol_2";
			this._txtVol_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._txtVol_2.Size = new System.Drawing.Size(45, 19);
			this._txtVol_2.TabIndex = 5;
			this._txtVol_2.Leave += new System.EventHandler(this.txtVol_Leave);
			// 
			// _txtFreq_2
			// 
			this._txtFreq_2.AcceptsReturn = true;
			this._txtFreq_2.AllowDrop = true;
			this._txtFreq_2.BackColor = System.Drawing.SystemColors.Window;
			this._txtFreq_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._txtFreq_2.Cursor = System.Windows.Forms.Cursors.IBeam;
			this._txtFreq_2.ForeColor = System.Drawing.SystemColors.WindowText;
			this._txtFreq_2.Location = new System.Drawing.Point(68, 20);
			this._txtFreq_2.MaxLength = 0;
			this._txtFreq_2.Name = "_txtFreq_2";
			this._txtFreq_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._txtFreq_2.Size = new System.Drawing.Size(45, 19);
			this._txtFreq_2.TabIndex = 4;
			this._txtFreq_2.Leave += new System.EventHandler(this.txtFreq_Leave);
			// 
			// _scFreq_2
			// 
			this._scFreq_2.AllowDrop = true;
			this._scFreq_2.CausesValidation = true;
			this._scFreq_2.Enabled = true;
			this._scFreq_2.LargeChange = 22;
			this._scFreq_2.Location = new System.Drawing.Point(116, 20);
			this._scFreq_2.Maximum = 4020;
			this._scFreq_2.Minimum = 0;
			this._scFreq_2.Name = "_scFreq_2";
			this._scFreq_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._scFreq_2.Size = new System.Drawing.Size(345, 17);
			this._scFreq_2.SmallChange = 1;
			this._scFreq_2.TabIndex = 17;
			this._scFreq_2.TabStop = true;
			this._scFreq_2.Value = 1;
			this._scFreq_2.Visible = true;
			this._scFreq_2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scFreq_Scroll);
			this._scFreq_2.ValueChanged += new System.EventHandler(this.scFreq_ValueChanged);
			// 
			// _scVol_2
			// 
			this._scVol_2.AllowDrop = true;
			this._scVol_2.CausesValidation = true;
			this._scVol_2.Enabled = true;
			this._scVol_2.LargeChange = 4;
			this._scVol_2.Location = new System.Drawing.Point(116, 40);
			this._scVol_2.Maximum = 34;
			this._scVol_2.Minimum = 0;
			this._scVol_2.Name = "_scVol_2";
			this._scVol_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._scVol_2.Size = new System.Drawing.Size(345, 17);
			this._scVol_2.SmallChange = 1;
			this._scVol_2.TabIndex = 18;
			this._scVol_2.TabStop = true;
			this._scVol_2.Value = 1;
			this._scVol_2.Visible = true;
			this._scVol_2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scVol_Scroll);
			this._scVol_2.ValueChanged += new System.EventHandler(this.scVol_ValueChanged);
			// 
			// _Label1_2
			// 
			this._Label1_2.AllowDrop = true;
			this._Label1_2.BackColor = System.Drawing.SystemColors.Control;
			this._Label1_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._Label1_2.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Label1_2.Location = new System.Drawing.Point(8, 40);
			this._Label1_2.Name = "_Label1_2";
			this._Label1_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Label1_2.Size = new System.Drawing.Size(53, 17);
			this._Label1_2.TabIndex = 50;
			this._Label1_2.Text = "Volume:";
			this._Label1_2.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _lbl1_2
			// 
			this._lbl1_2.AllowDrop = true;
			this._lbl1_2.BackColor = System.Drawing.SystemColors.Control;
			this._lbl1_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._lbl1_2.ForeColor = System.Drawing.SystemColors.ControlText;
			this._lbl1_2.Location = new System.Drawing.Point(8, 20);
			this._lbl1_2.Name = "_lbl1_2";
			this._lbl1_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._lbl1_2.Size = new System.Drawing.Size(53, 17);
			this._lbl1_2.TabIndex = 49;
			this._lbl1_2.Text = "Frequency:";
			this._lbl1_2.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _FrameOsc_3
			// 
			this._FrameOsc_3.AllowDrop = true;
			this._FrameOsc_3.BackColor = System.Drawing.SystemColors.Control;
			this._FrameOsc_3.Controls.Add(this._txtVol_3);
			this._FrameOsc_3.Controls.Add(this._txtFreq_3);
			this._FrameOsc_3.Controls.Add(this._scFreq_3);
			this._FrameOsc_3.Controls.Add(this._scVol_3);
			this._FrameOsc_3.Controls.Add(this._Label1_3);
			this._FrameOsc_3.Controls.Add(this._lbl1_3);
			this._FrameOsc_3.Enabled = true;
			this._FrameOsc_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this._FrameOsc_3.ForeColor = System.Drawing.SystemColors.ControlText;
			this._FrameOsc_3.Location = new System.Drawing.Point(132, 152);
			this._FrameOsc_3.Name = "_FrameOsc_3";
			this._FrameOsc_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._FrameOsc_3.Size = new System.Drawing.Size(473, 65);
			this._FrameOsc_3.TabIndex = 45;
			this._FrameOsc_3.Text = "Oscillator #3";
			this._FrameOsc_3.Visible = true;
			// 
			// _txtVol_3
			// 
			this._txtVol_3.AcceptsReturn = true;
			this._txtVol_3.AllowDrop = true;
			this._txtVol_3.BackColor = System.Drawing.SystemColors.Window;
			this._txtVol_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._txtVol_3.Cursor = System.Windows.Forms.Cursors.IBeam;
			this._txtVol_3.ForeColor = System.Drawing.SystemColors.WindowText;
			this._txtVol_3.Location = new System.Drawing.Point(68, 40);
			this._txtVol_3.MaxLength = 0;
			this._txtVol_3.Name = "_txtVol_3";
			this._txtVol_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._txtVol_3.Size = new System.Drawing.Size(45, 19);
			this._txtVol_3.TabIndex = 7;
			this._txtVol_3.Leave += new System.EventHandler(this.txtVol_Leave);
			// 
			// _txtFreq_3
			// 
			this._txtFreq_3.AcceptsReturn = true;
			this._txtFreq_3.AllowDrop = true;
			this._txtFreq_3.BackColor = System.Drawing.SystemColors.Window;
			this._txtFreq_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._txtFreq_3.Cursor = System.Windows.Forms.Cursors.IBeam;
			this._txtFreq_3.ForeColor = System.Drawing.SystemColors.WindowText;
			this._txtFreq_3.Location = new System.Drawing.Point(68, 20);
			this._txtFreq_3.MaxLength = 0;
			this._txtFreq_3.Name = "_txtFreq_3";
			this._txtFreq_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._txtFreq_3.Size = new System.Drawing.Size(45, 19);
			this._txtFreq_3.TabIndex = 6;
			this._txtFreq_3.Leave += new System.EventHandler(this.txtFreq_Leave);
			// 
			// _scFreq_3
			// 
			this._scFreq_3.AllowDrop = true;
			this._scFreq_3.CausesValidation = true;
			this._scFreq_3.Enabled = true;
			this._scFreq_3.LargeChange = 22;
			this._scFreq_3.Location = new System.Drawing.Point(116, 20);
			this._scFreq_3.Maximum = 4020;
			this._scFreq_3.Minimum = 0;
			this._scFreq_3.Name = "_scFreq_3";
			this._scFreq_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._scFreq_3.Size = new System.Drawing.Size(345, 17);
			this._scFreq_3.SmallChange = 1;
			this._scFreq_3.TabIndex = 19;
			this._scFreq_3.TabStop = true;
			this._scFreq_3.Value = 1;
			this._scFreq_3.Visible = true;
			this._scFreq_3.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scFreq_Scroll);
			this._scFreq_3.ValueChanged += new System.EventHandler(this.scFreq_ValueChanged);
			// 
			// _scVol_3
			// 
			this._scVol_3.AllowDrop = true;
			this._scVol_3.CausesValidation = true;
			this._scVol_3.Enabled = true;
			this._scVol_3.LargeChange = 4;
			this._scVol_3.Location = new System.Drawing.Point(116, 40);
			this._scVol_3.Maximum = 34;
			this._scVol_3.Minimum = 0;
			this._scVol_3.Name = "_scVol_3";
			this._scVol_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._scVol_3.Size = new System.Drawing.Size(345, 17);
			this._scVol_3.SmallChange = 1;
			this._scVol_3.TabIndex = 20;
			this._scVol_3.TabStop = true;
			this._scVol_3.Value = 1;
			this._scVol_3.Visible = true;
			this._scVol_3.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scVol_Scroll);
			this._scVol_3.ValueChanged += new System.EventHandler(this.scVol_ValueChanged);
			// 
			// _Label1_3
			// 
			this._Label1_3.AllowDrop = true;
			this._Label1_3.BackColor = System.Drawing.SystemColors.Control;
			this._Label1_3.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._Label1_3.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Label1_3.Location = new System.Drawing.Point(8, 40);
			this._Label1_3.Name = "_Label1_3";
			this._Label1_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Label1_3.Size = new System.Drawing.Size(53, 17);
			this._Label1_3.TabIndex = 47;
			this._Label1_3.Text = "Volume:";
			this._Label1_3.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _lbl1_3
			// 
			this._lbl1_3.AllowDrop = true;
			this._lbl1_3.BackColor = System.Drawing.SystemColors.Control;
			this._lbl1_3.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._lbl1_3.ForeColor = System.Drawing.SystemColors.ControlText;
			this._lbl1_3.Location = new System.Drawing.Point(8, 20);
			this._lbl1_3.Name = "_lbl1_3";
			this._lbl1_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._lbl1_3.Size = new System.Drawing.Size(53, 17);
			this._lbl1_3.TabIndex = 46;
			this._lbl1_3.Text = "Frequency:";
			this._lbl1_3.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// btnDone
			// 
			this.btnDone.AllowDrop = true;
			this.btnDone.BackColor = System.Drawing.SystemColors.Control;
			this.btnDone.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnDone.Location = new System.Drawing.Point(544, 496);
			this.btnDone.Name = "btnDone";
			this.btnDone.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnDone.Size = new System.Drawing.Size(77, 25);
			this.btnDone.TabIndex = 27;
			this.btnDone.Text = "Done";
			this.btnDone.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnDone.UseVisualStyleBackColor = false;
			this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
			// 
			// btnShutUp
			// 
			this.btnShutUp.AllowDrop = true;
			this.btnShutUp.BackColor = System.Drawing.SystemColors.Control;
			this.btnShutUp.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnShutUp.Location = new System.Drawing.Point(460, 496);
			this.btnShutUp.Name = "btnShutUp";
			this.btnShutUp.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnShutUp.Size = new System.Drawing.Size(77, 25);
			this.btnShutUp.TabIndex = 26;
			this.btnShutUp.Text = "Shut Up";
			this.btnShutUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnShutUp.UseVisualStyleBackColor = false;
			this.btnShutUp.Click += new System.EventHandler(this.btnShutUp_Click);
			// 
			// _FrameOsc_7
			// 
			this._FrameOsc_7.AllowDrop = true;
			this._FrameOsc_7.BackColor = System.Drawing.SystemColors.Control;
			this._FrameOsc_7.Controls.Add(this.txtEnvFreq);
			this._FrameOsc_7.Controls.Add(this._txtLevel_1);
			this._FrameOsc_7.Controls.Add(this.scEnvolopeFreq);
			this._FrameOsc_7.Controls.Add(this._Option1_0);
			this._FrameOsc_7.Controls.Add(this._Option1_1);
			this._FrameOsc_7.Controls.Add(this._Option1_2);
			this._FrameOsc_7.Controls.Add(this._Option1_3);
			this._FrameOsc_7.Controls.Add(this._scLevel_1);
			this._FrameOsc_7.Controls.Add(this._lbl1_8);
			this._FrameOsc_7.Controls.Add(this._lbl1_0);
			this._FrameOsc_7.Controls.Add(this._lbl1_7);
			this._FrameOsc_7.Enabled = true;
			this._FrameOsc_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this._FrameOsc_7.ForeColor = System.Drawing.SystemColors.ControlText;
			this._FrameOsc_7.Location = new System.Drawing.Point(4, 4);
			this._FrameOsc_7.Name = "_FrameOsc_7";
			this._FrameOsc_7.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._FrameOsc_7.Size = new System.Drawing.Size(617, 73);
			this._FrameOsc_7.TabIndex = 36;
			this._FrameOsc_7.Text = "Mains";
			this._FrameOsc_7.Visible = true;
			// 
			// txtEnvFreq
			// 
			this.txtEnvFreq.AcceptsReturn = true;
			this.txtEnvFreq.AllowDrop = true;
			this.txtEnvFreq.BackColor = System.Drawing.SystemColors.Window;
			this.txtEnvFreq.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtEnvFreq.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtEnvFreq.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtEnvFreq.Location = new System.Drawing.Point(116, 44);
			this.txtEnvFreq.MaxLength = 0;
			this.txtEnvFreq.Name = "txtEnvFreq";
			this.txtEnvFreq.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtEnvFreq.Size = new System.Drawing.Size(45, 19);
			this.txtEnvFreq.TabIndex = 1;
			this.txtEnvFreq.Leave += new System.EventHandler(this.txtEnvFreq_Leave);
			// 
			// _txtLevel_1
			// 
			this._txtLevel_1.AcceptsReturn = true;
			this._txtLevel_1.AllowDrop = true;
			this._txtLevel_1.BackColor = System.Drawing.SystemColors.Window;
			this._txtLevel_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._txtLevel_1.Cursor = System.Windows.Forms.Cursors.IBeam;
			this._txtLevel_1.ForeColor = System.Drawing.SystemColors.WindowText;
			this._txtLevel_1.Location = new System.Drawing.Point(116, 20);
			this._txtLevel_1.MaxLength = 0;
			this._txtLevel_1.Name = "_txtLevel_1";
			this._txtLevel_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._txtLevel_1.Size = new System.Drawing.Size(45, 19);
			this._txtLevel_1.TabIndex = 0;
			this._txtLevel_1.Leave += new System.EventHandler(this.txtLevel_Leave);
			// 
			// scEnvolopeFreq
			// 
			this.scEnvolopeFreq.AllowDrop = true;
			this.scEnvolopeFreq.CausesValidation = true;
			this.scEnvolopeFreq.Enabled = true;
			this.scEnvolopeFreq.LargeChange = 22;
			this.scEnvolopeFreq.Location = new System.Drawing.Point(164, 44);
			this.scEnvolopeFreq.Maximum = 276;
			this.scEnvolopeFreq.Minimum = 0;
			this.scEnvolopeFreq.Name = "scEnvolopeFreq";
			this.scEnvolopeFreq.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.scEnvolopeFreq.Size = new System.Drawing.Size(289, 17);
			this.scEnvolopeFreq.SmallChange = 1;
			this.scEnvolopeFreq.TabIndex = 14;
			this.scEnvolopeFreq.TabStop = true;
			this.scEnvolopeFreq.Value = 1;
			this.scEnvolopeFreq.Visible = true;
			this.scEnvolopeFreq.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scEnvolopeFreq_Scroll);
			this.scEnvolopeFreq.ValueChanged += new System.EventHandler(this.scEnvolopeFreq_ValueChanged);
			// 
			// _Option1_0
			// 
			this._Option1_0.AllowDrop = true;
			this._Option1_0.Appearance = System.Windows.Forms.Appearance.Normal;
			this._Option1_0.BackColor = System.Drawing.SystemColors.Control;
			this._Option1_0.CausesValidation = true;
			this._Option1_0.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._Option1_0.Checked = false;
			this._Option1_0.Enabled = true;
			this._Option1_0.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Option1_0.Location = new System.Drawing.Point(472, 36);
			this._Option1_0.Name = "_Option1_0";
			this._Option1_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Option1_0.Size = new System.Drawing.Size(65, 13);
			this._Option1_0.TabIndex = 28;
			this._Option1_0.TabStop = true;
			this._Option1_0.Text = "Saw";
			this._Option1_0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._Option1_0.Visible = true;
			this._Option1_0.CheckedChanged += new System.EventHandler(this.Option1_CheckedChanged);
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
			this._Option1_1.Location = new System.Drawing.Point(472, 52);
			this._Option1_1.Name = "_Option1_1";
			this._Option1_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Option1_1.Size = new System.Drawing.Size(65, 13);
			this._Option1_1.TabIndex = 29;
			this._Option1_1.TabStop = true;
			this._Option1_1.Text = "Sine";
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
			this._Option1_2.Location = new System.Drawing.Point(540, 36);
			this._Option1_2.Name = "_Option1_2";
			this._Option1_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Option1_2.Size = new System.Drawing.Size(65, 13);
			this._Option1_2.TabIndex = 30;
			this._Option1_2.TabStop = true;
			this._Option1_2.Text = "Triangle";
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
			this._Option1_3.Location = new System.Drawing.Point(540, 52);
			this._Option1_3.Name = "_Option1_3";
			this._Option1_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Option1_3.Size = new System.Drawing.Size(65, 13);
			this._Option1_3.TabIndex = 31;
			this._Option1_3.TabStop = true;
			this._Option1_3.Text = "Square";
			this._Option1_3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._Option1_3.Visible = true;
			this._Option1_3.CheckedChanged += new System.EventHandler(this.Option1_CheckedChanged);
			// 
			// _scLevel_1
			// 
			this._scLevel_1.AllowDrop = true;
			this._scLevel_1.CausesValidation = true;
			this._scLevel_1.Enabled = true;
			this._scLevel_1.LargeChange = 4;
			this._scLevel_1.Location = new System.Drawing.Point(164, 20);
			this._scLevel_1.Maximum = 130;
			this._scLevel_1.Minimum = 0;
			this._scLevel_1.Name = "_scLevel_1";
			this._scLevel_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._scLevel_1.Size = new System.Drawing.Size(289, 17);
			this._scLevel_1.SmallChange = 1;
			this._scLevel_1.TabIndex = 13;
			this._scLevel_1.TabStop = true;
			this._scLevel_1.Value = 1;
			this._scLevel_1.Visible = true;
			this._scLevel_1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scLevel_Scroll);
			this._scLevel_1.ValueChanged += new System.EventHandler(this.scLevel_ValueChanged);
			// 
			// _lbl1_8
			// 
			this._lbl1_8.AllowDrop = true;
			this._lbl1_8.BackColor = System.Drawing.SystemColors.Control;
			this._lbl1_8.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._lbl1_8.ForeColor = System.Drawing.SystemColors.ControlText;
			this._lbl1_8.Location = new System.Drawing.Point(480, 16);
			this._lbl1_8.Name = "_lbl1_8";
			this._lbl1_8.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._lbl1_8.Size = new System.Drawing.Size(113, 13);
			this._lbl1_8.TabIndex = 55;
			this._lbl1_8.Text = "Envelope Type:";
			this._lbl1_8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// _lbl1_0
			// 
			this._lbl1_0.AllowDrop = true;
			this._lbl1_0.BackColor = System.Drawing.SystemColors.Control;
			this._lbl1_0.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._lbl1_0.ForeColor = System.Drawing.SystemColors.ControlText;
			this._lbl1_0.Location = new System.Drawing.Point(8, 44);
			this._lbl1_0.Name = "_lbl1_0";
			this._lbl1_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._lbl1_0.Size = new System.Drawing.Size(101, 17);
			this._lbl1_0.TabIndex = 54;
			this._lbl1_0.Text = "Envelope Frequency:";
			this._lbl1_0.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _lbl1_7
			// 
			this._lbl1_7.AllowDrop = true;
			this._lbl1_7.BackColor = System.Drawing.SystemColors.Control;
			this._lbl1_7.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._lbl1_7.ForeColor = System.Drawing.SystemColors.ControlText;
			this._lbl1_7.Location = new System.Drawing.Point(8, 20);
			this._lbl1_7.Name = "_lbl1_7";
			this._lbl1_7.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._lbl1_7.Size = new System.Drawing.Size(101, 17);
			this._lbl1_7.TabIndex = 37;
			this._lbl1_7.Text = "Master Volume:";
			this._lbl1_7.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _FrameOsc_6
			// 
			this._FrameOsc_6.AllowDrop = true;
			this._FrameOsc_6.BackColor = System.Drawing.SystemColors.Control;
			this._FrameOsc_6.Controls.Add(this._txtLevel_0);
			this._FrameOsc_6.Controls.Add(this._Check2_0);
			this._FrameOsc_6.Controls.Add(this._FrameOsc_5);
			this._FrameOsc_6.Controls.Add(this._FrameOsc_4);
			this._FrameOsc_6.Controls.Add(this._scLevel_0);
			this._FrameOsc_6.Controls.Add(this._lbl1_6);
			this._FrameOsc_6.Enabled = true;
			this._FrameOsc_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this._FrameOsc_6.ForeColor = System.Drawing.SystemColors.ControlText;
			this._FrameOsc_6.Location = new System.Drawing.Point(4, 308);
			this._FrameOsc_6.Name = "_FrameOsc_6";
			this._FrameOsc_6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._FrameOsc_6.Size = new System.Drawing.Size(617, 185);
			this._FrameOsc_6.TabIndex = 34;
			this._FrameOsc_6.Text = "Noise Generators";
			this._FrameOsc_6.Visible = true;
			// 
			// _txtLevel_0
			// 
			this._txtLevel_0.AcceptsReturn = true;
			this._txtLevel_0.AllowDrop = true;
			this._txtLevel_0.BackColor = System.Drawing.SystemColors.Window;
			this._txtLevel_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._txtLevel_0.Cursor = System.Windows.Forms.Cursors.IBeam;
			this._txtLevel_0.ForeColor = System.Drawing.SystemColors.WindowText;
			this._txtLevel_0.Location = new System.Drawing.Point(200, 20);
			this._txtLevel_0.MaxLength = 0;
			this._txtLevel_0.Name = "_txtLevel_0";
			this._txtLevel_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._txtLevel_0.Size = new System.Drawing.Size(45, 19);
			this._txtLevel_0.TabIndex = 8;
			this._txtLevel_0.Leave += new System.EventHandler(this.txtLevel_Leave);
			// 
			// _Check2_0
			// 
			this._Check2_0.AllowDrop = true;
			this._Check2_0.Appearance = System.Windows.Forms.Appearance.Normal;
			this._Check2_0.BackColor = System.Drawing.SystemColors.Control;
			this._Check2_0.CausesValidation = true;
			this._Check2_0.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._Check2_0.CheckState = System.Windows.Forms.CheckState.Unchecked;
			this._Check2_0.Enabled = true;
			this._Check2_0.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Check2_0.Location = new System.Drawing.Point(12, 28);
			this._Check2_0.Name = "_Check2_0";
			this._Check2_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Check2_0.Size = new System.Drawing.Size(77, 25);
			this._Check2_0.TabIndex = 33;
			this._Check2_0.TabStop = true;
			this._Check2_0.Text = "One Half Enveloped";
			this._Check2_0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._Check2_0.Visible = true;
			this._Check2_0.CheckStateChanged += new System.EventHandler(this.Check2_CheckStateChanged);
			// 
			// _FrameOsc_5
			// 
			this._FrameOsc_5.AllowDrop = true;
			this._FrameOsc_5.BackColor = System.Drawing.SystemColors.Control;
			this._FrameOsc_5.Controls.Add(this._txtVol_5);
			this._FrameOsc_5.Controls.Add(this._txtFreq_5);
			this._FrameOsc_5.Controls.Add(this._scVol_5);
			this._FrameOsc_5.Controls.Add(this._scFreq_5);
			this._FrameOsc_5.Controls.Add(this._lbl1_5);
			this._FrameOsc_5.Controls.Add(this._Label1_5);
			this._FrameOsc_5.Enabled = true;
			this._FrameOsc_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this._FrameOsc_5.ForeColor = System.Drawing.SystemColors.ControlText;
			this._FrameOsc_5.Location = new System.Drawing.Point(132, 112);
			this._FrameOsc_5.Name = "_FrameOsc_5";
			this._FrameOsc_5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._FrameOsc_5.Size = new System.Drawing.Size(473, 65);
			this._FrameOsc_5.TabIndex = 41;
			this._FrameOsc_5.Text = "Oscillator #5";
			this._FrameOsc_5.Visible = true;
			// 
			// _txtVol_5
			// 
			this._txtVol_5.AcceptsReturn = true;
			this._txtVol_5.AllowDrop = true;
			this._txtVol_5.BackColor = System.Drawing.SystemColors.Window;
			this._txtVol_5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._txtVol_5.Cursor = System.Windows.Forms.Cursors.IBeam;
			this._txtVol_5.ForeColor = System.Drawing.SystemColors.WindowText;
			this._txtVol_5.Location = new System.Drawing.Point(68, 40);
			this._txtVol_5.MaxLength = 0;
			this._txtVol_5.Name = "_txtVol_5";
			this._txtVol_5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._txtVol_5.Size = new System.Drawing.Size(45, 19);
			this._txtVol_5.TabIndex = 12;
			this._txtVol_5.Leave += new System.EventHandler(this.txtVol_Leave);
			// 
			// _txtFreq_5
			// 
			this._txtFreq_5.AcceptsReturn = true;
			this._txtFreq_5.AllowDrop = true;
			this._txtFreq_5.BackColor = System.Drawing.SystemColors.Window;
			this._txtFreq_5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._txtFreq_5.Cursor = System.Windows.Forms.Cursors.IBeam;
			this._txtFreq_5.ForeColor = System.Drawing.SystemColors.WindowText;
			this._txtFreq_5.Location = new System.Drawing.Point(68, 20);
			this._txtFreq_5.MaxLength = 0;
			this._txtFreq_5.Name = "_txtFreq_5";
			this._txtFreq_5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._txtFreq_5.Size = new System.Drawing.Size(45, 19);
			this._txtFreq_5.TabIndex = 11;
			this._txtFreq_5.Leave += new System.EventHandler(this.txtFreq_Leave);
			// 
			// _scVol_5
			// 
			this._scVol_5.AllowDrop = true;
			this._scVol_5.CausesValidation = true;
			this._scVol_5.Enabled = true;
			this._scVol_5.LargeChange = 4;
			this._scVol_5.Location = new System.Drawing.Point(116, 40);
			this._scVol_5.Maximum = 34;
			this._scVol_5.Minimum = 0;
			this._scVol_5.Name = "_scVol_5";
			this._scVol_5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._scVol_5.Size = new System.Drawing.Size(345, 17);
			this._scVol_5.SmallChange = 1;
			this._scVol_5.TabIndex = 25;
			this._scVol_5.TabStop = true;
			this._scVol_5.Value = 1;
			this._scVol_5.Visible = true;
			this._scVol_5.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scVol_Scroll);
			this._scVol_5.ValueChanged += new System.EventHandler(this.scVol_ValueChanged);
			// 
			// _scFreq_5
			// 
			this._scFreq_5.AllowDrop = true;
			this._scFreq_5.CausesValidation = true;
			this._scFreq_5.Enabled = true;
			this._scFreq_5.LargeChange = 22;
			this._scFreq_5.Location = new System.Drawing.Point(116, 20);
			this._scFreq_5.Maximum = 4020;
			this._scFreq_5.Minimum = 0;
			this._scFreq_5.Name = "_scFreq_5";
			this._scFreq_5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._scFreq_5.Size = new System.Drawing.Size(345, 17);
			this._scFreq_5.SmallChange = 1;
			this._scFreq_5.TabIndex = 24;
			this._scFreq_5.TabStop = true;
			this._scFreq_5.Value = 1;
			this._scFreq_5.Visible = true;
			this._scFreq_5.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scFreq_Scroll);
			this._scFreq_5.ValueChanged += new System.EventHandler(this.scFreq_ValueChanged);
			// 
			// _lbl1_5
			// 
			this._lbl1_5.AllowDrop = true;
			this._lbl1_5.BackColor = System.Drawing.SystemColors.Control;
			this._lbl1_5.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._lbl1_5.ForeColor = System.Drawing.SystemColors.ControlText;
			this._lbl1_5.Location = new System.Drawing.Point(8, 20);
			this._lbl1_5.Name = "_lbl1_5";
			this._lbl1_5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._lbl1_5.Size = new System.Drawing.Size(53, 17);
			this._lbl1_5.TabIndex = 43;
			this._lbl1_5.Text = "Frequency:";
			this._lbl1_5.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _Label1_5
			// 
			this._Label1_5.AllowDrop = true;
			this._Label1_5.BackColor = System.Drawing.SystemColors.Control;
			this._Label1_5.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._Label1_5.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Label1_5.Location = new System.Drawing.Point(8, 40);
			this._Label1_5.Name = "_Label1_5";
			this._Label1_5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Label1_5.Size = new System.Drawing.Size(53, 17);
			this._Label1_5.TabIndex = 42;
			this._Label1_5.Text = "Volume:";
			this._Label1_5.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _FrameOsc_4
			// 
			this._FrameOsc_4.AllowDrop = true;
			this._FrameOsc_4.BackColor = System.Drawing.SystemColors.Control;
			this._FrameOsc_4.Controls.Add(this._txtVol_4);
			this._FrameOsc_4.Controls.Add(this._txtFreq_4);
			this._FrameOsc_4.Controls.Add(this._scFreq_4);
			this._FrameOsc_4.Controls.Add(this._scVol_4);
			this._FrameOsc_4.Controls.Add(this._Label1_4);
			this._FrameOsc_4.Controls.Add(this._lbl1_4);
			this._FrameOsc_4.Enabled = true;
			this._FrameOsc_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this._FrameOsc_4.ForeColor = System.Drawing.SystemColors.ControlText;
			this._FrameOsc_4.Location = new System.Drawing.Point(132, 44);
			this._FrameOsc_4.Name = "_FrameOsc_4";
			this._FrameOsc_4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._FrameOsc_4.Size = new System.Drawing.Size(473, 65);
			this._FrameOsc_4.TabIndex = 38;
			this._FrameOsc_4.Text = "Oscillator #4";
			this._FrameOsc_4.Visible = true;
			// 
			// _txtVol_4
			// 
			this._txtVol_4.AcceptsReturn = true;
			this._txtVol_4.AllowDrop = true;
			this._txtVol_4.BackColor = System.Drawing.SystemColors.Window;
			this._txtVol_4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._txtVol_4.Cursor = System.Windows.Forms.Cursors.IBeam;
			this._txtVol_4.ForeColor = System.Drawing.SystemColors.WindowText;
			this._txtVol_4.Location = new System.Drawing.Point(68, 40);
			this._txtVol_4.MaxLength = 0;
			this._txtVol_4.Name = "_txtVol_4";
			this._txtVol_4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._txtVol_4.Size = new System.Drawing.Size(45, 19);
			this._txtVol_4.TabIndex = 10;
			this._txtVol_4.Leave += new System.EventHandler(this.txtVol_Leave);
			// 
			// _txtFreq_4
			// 
			this._txtFreq_4.AcceptsReturn = true;
			this._txtFreq_4.AllowDrop = true;
			this._txtFreq_4.BackColor = System.Drawing.SystemColors.Window;
			this._txtFreq_4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._txtFreq_4.Cursor = System.Windows.Forms.Cursors.IBeam;
			this._txtFreq_4.ForeColor = System.Drawing.SystemColors.WindowText;
			this._txtFreq_4.Location = new System.Drawing.Point(68, 20);
			this._txtFreq_4.MaxLength = 0;
			this._txtFreq_4.Name = "_txtFreq_4";
			this._txtFreq_4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._txtFreq_4.Size = new System.Drawing.Size(45, 19);
			this._txtFreq_4.TabIndex = 9;
			this._txtFreq_4.Leave += new System.EventHandler(this.txtFreq_Leave);
			// 
			// _scFreq_4
			// 
			this._scFreq_4.AllowDrop = true;
			this._scFreq_4.CausesValidation = true;
			this._scFreq_4.Enabled = true;
			this._scFreq_4.LargeChange = 22;
			this._scFreq_4.Location = new System.Drawing.Point(116, 20);
			this._scFreq_4.Maximum = 4020;
			this._scFreq_4.Minimum = 0;
			this._scFreq_4.Name = "_scFreq_4";
			this._scFreq_4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._scFreq_4.Size = new System.Drawing.Size(345, 17);
			this._scFreq_4.SmallChange = 1;
			this._scFreq_4.TabIndex = 22;
			this._scFreq_4.TabStop = true;
			this._scFreq_4.Value = 1;
			this._scFreq_4.Visible = true;
			this._scFreq_4.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scFreq_Scroll);
			this._scFreq_4.ValueChanged += new System.EventHandler(this.scFreq_ValueChanged);
			// 
			// _scVol_4
			// 
			this._scVol_4.AllowDrop = true;
			this._scVol_4.CausesValidation = true;
			this._scVol_4.Enabled = true;
			this._scVol_4.LargeChange = 4;
			this._scVol_4.Location = new System.Drawing.Point(116, 40);
			this._scVol_4.Maximum = 34;
			this._scVol_4.Minimum = 0;
			this._scVol_4.Name = "_scVol_4";
			this._scVol_4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._scVol_4.Size = new System.Drawing.Size(345, 17);
			this._scVol_4.SmallChange = 1;
			this._scVol_4.TabIndex = 23;
			this._scVol_4.TabStop = true;
			this._scVol_4.Value = 1;
			this._scVol_4.Visible = true;
			this._scVol_4.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scVol_Scroll);
			this._scVol_4.ValueChanged += new System.EventHandler(this.scVol_ValueChanged);
			// 
			// _Label1_4
			// 
			this._Label1_4.AllowDrop = true;
			this._Label1_4.BackColor = System.Drawing.SystemColors.Control;
			this._Label1_4.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._Label1_4.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Label1_4.Location = new System.Drawing.Point(8, 40);
			this._Label1_4.Name = "_Label1_4";
			this._Label1_4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Label1_4.Size = new System.Drawing.Size(53, 17);
			this._Label1_4.TabIndex = 40;
			this._Label1_4.Text = "Volume:";
			this._Label1_4.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _lbl1_4
			// 
			this._lbl1_4.AllowDrop = true;
			this._lbl1_4.BackColor = System.Drawing.SystemColors.Control;
			this._lbl1_4.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._lbl1_4.ForeColor = System.Drawing.SystemColors.ControlText;
			this._lbl1_4.Location = new System.Drawing.Point(8, 20);
			this._lbl1_4.Name = "_lbl1_4";
			this._lbl1_4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._lbl1_4.Size = new System.Drawing.Size(53, 17);
			this._lbl1_4.TabIndex = 39;
			this._lbl1_4.Text = "Frequency:";
			this._lbl1_4.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _scLevel_0
			// 
			this._scLevel_0.AllowDrop = true;
			this._scLevel_0.CausesValidation = true;
			this._scLevel_0.Enabled = true;
			this._scLevel_0.LargeChange = 16;
			this._scLevel_0.Location = new System.Drawing.Point(248, 20);
			this._scLevel_0.Maximum = 270;
			this._scLevel_0.Minimum = 0;
			this._scLevel_0.Name = "_scLevel_0";
			this._scLevel_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._scLevel_0.Size = new System.Drawing.Size(345, 17);
			this._scLevel_0.SmallChange = 1;
			this._scLevel_0.TabIndex = 21;
			this._scLevel_0.TabStop = true;
			this._scLevel_0.Value = 1;
			this._scLevel_0.Visible = true;
			this._scLevel_0.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scLevel_Scroll);
			this._scLevel_0.ValueChanged += new System.EventHandler(this.scLevel_ValueChanged);
			// 
			// _lbl1_6
			// 
			this._lbl1_6.AllowDrop = true;
			this._lbl1_6.BackColor = System.Drawing.SystemColors.Control;
			this._lbl1_6.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._lbl1_6.ForeColor = System.Drawing.SystemColors.ControlText;
			this._lbl1_6.Location = new System.Drawing.Point(140, 20);
			this._lbl1_6.Name = "_lbl1_6";
			this._lbl1_6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._lbl1_6.Size = new System.Drawing.Size(53, 17);
			this._lbl1_6.TabIndex = 35;
			this._lbl1_6.Text = "Distortion:";
			this._lbl1_6.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// Label3
			// 
			this.Label3.AllowDrop = true;
			this.Label3.BackColor = System.Drawing.SystemColors.Control;
			this.Label3.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label3.Location = new System.Drawing.Point(4, 500);
			this.Label3.Name = "Label3";
			this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label3.Size = new System.Drawing.Size(97, 17);
			this.Label3.TabIndex = 57;
			this.Label3.Text = "Sound:";
			this.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// FrmSynthCtrl
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(625, 524);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnLoad);
			this.Controls.Add(this.txtSound);
			this.Controls.Add(this.Frame1);
			this.Controls.Add(this.btnDone);
			this.Controls.Add(this.btnShutUp);
			this.Controls.Add(this._FrameOsc_7);
			this.Controls.Add(this._FrameOsc_6);
			this.Controls.Add(this.Label3);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Location = new System.Drawing.Point(3, 23);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmSynthCtrl";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SpeakJet Synth Control";
			this.ToolTipMain.SetToolTip(this.btnSave, "Stop the SpeakJet now.");
			this.ToolTipMain.SetToolTip(this.btnLoad, "Stop the SpeakJet now.");
			this.ToolTipMain.SetToolTip(this.btnShutUp, "Stop the SpeakJet now.");
			this.Closed += new System.EventHandler(this.Form_Closed);
			this.Frame1.ResumeLayout(false);
			this.Frame2.ResumeLayout(false);
			this._FrameOsc_1.ResumeLayout(false);
			this._FrameOsc_2.ResumeLayout(false);
			this._FrameOsc_3.ResumeLayout(false);
			this._FrameOsc_7.ResumeLayout(false);
			this._FrameOsc_6.ResumeLayout(false);
			this._FrameOsc_5.ResumeLayout(false);
			this._FrameOsc_4.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		void ReLoadForm(bool addEvents)
		{
			InitializetxtVol();
			InitializetxtLevel();
			InitializetxtFreq();
			InitializescVol();
			InitializescLevel();
			InitializescFreq();
			Initializelbl1();
			InitializeOption1();
			InitializeLabel1();
			InitializeFrameOsc();
			InitializeCheck2();
		}
		void InitializetxtVol()
		{
			this.txtVol = new System.Windows.Forms.TextBox[6];
			this.txtVol[1] = _txtVol_1;
			this.txtVol[2] = _txtVol_2;
			this.txtVol[3] = _txtVol_3;
			this.txtVol[5] = _txtVol_5;
			this.txtVol[4] = _txtVol_4;
		}
		void InitializetxtLevel()
		{
			this.txtLevel = new System.Windows.Forms.TextBox[2];
			this.txtLevel[1] = _txtLevel_1;
			this.txtLevel[0] = _txtLevel_0;
		}
		void InitializetxtFreq()
		{
			this.txtFreq = new System.Windows.Forms.TextBox[6];
			this.txtFreq[1] = _txtFreq_1;
			this.txtFreq[2] = _txtFreq_2;
			this.txtFreq[3] = _txtFreq_3;
			this.txtFreq[5] = _txtFreq_5;
			this.txtFreq[4] = _txtFreq_4;
		}
		void InitializescVol()
		{
			this.scVol = new System.Windows.Forms.HScrollBar[6];
			this.scVol[1] = _scVol_1;
			this.scVol[2] = _scVol_2;
			this.scVol[3] = _scVol_3;
			this.scVol[5] = _scVol_5;
			this.scVol[4] = _scVol_4;
		}
		void InitializescLevel()
		{
			this.scLevel = new System.Windows.Forms.HScrollBar[2];
			this.scLevel[1] = _scLevel_1;
			this.scLevel[0] = _scLevel_0;
		}
		void InitializescFreq()
		{
			this.scFreq = new System.Windows.Forms.HScrollBar[6];
			this.scFreq[1] = _scFreq_1;
			this.scFreq[2] = _scFreq_2;
			this.scFreq[3] = _scFreq_3;
			this.scFreq[5] = _scFreq_5;
			this.scFreq[4] = _scFreq_4;
		}
		void Initializelbl1()
		{
			this.lbl1 = new System.Windows.Forms.Label[9];
			this.lbl1[1] = _lbl1_1;
			this.lbl1[2] = _lbl1_2;
			this.lbl1[3] = _lbl1_3;
			this.lbl1[8] = _lbl1_8;
			this.lbl1[0] = _lbl1_0;
			this.lbl1[7] = _lbl1_7;
			this.lbl1[5] = _lbl1_5;
			this.lbl1[4] = _lbl1_4;
			this.lbl1[6] = _lbl1_6;
		}
		void InitializeOption1()
		{
			this.Option1 = new System.Windows.Forms.RadioButton[4];
			this.Option1[0] = _Option1_0;
			this.Option1[1] = _Option1_1;
			this.Option1[2] = _Option1_2;
			this.Option1[3] = _Option1_3;
		}
		void InitializeLabel1()
		{
			this.Label1 = new System.Windows.Forms.Label[6];
			this.Label1[1] = _Label1_1;
			this.Label1[2] = _Label1_2;
			this.Label1[3] = _Label1_3;
			this.Label1[5] = _Label1_5;
			this.Label1[4] = _Label1_4;
		}
		void InitializeFrameOsc()
		{
			this.FrameOsc = new System.Windows.Forms.GroupBox[8];
			this.FrameOsc[1] = _FrameOsc_1;
			this.FrameOsc[2] = _FrameOsc_2;
			this.FrameOsc[3] = _FrameOsc_3;
			this.FrameOsc[7] = _FrameOsc_7;
			this.FrameOsc[5] = _FrameOsc_5;
			this.FrameOsc[4] = _FrameOsc_4;
			this.FrameOsc[6] = _FrameOsc_6;
		}
		void InitializeCheck2()
		{
			this.Check2 = new System.Windows.Forms.CheckBox[2];
			this.Check2[1] = _Check2_1;
			this.Check2[0] = _Check2_0;
		}
		#endregion
	}
}