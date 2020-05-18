
namespace PhraseALator
{
	partial class frmButtons
	{

		#region "Upgrade Support "
		private static frmButtons m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static frmButtons DefInstance
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
		public static frmButtons CreateInstance()
		{
			frmButtons theInstance = new frmButtons();
			theInstance.Form_Load();
			return theInstance;
		}
		private string[] visualControls = new string[]{"components", "ToolTipMain", "btnShutUp", "txtSCPNode", "chAutoSil", "Label22", "Frame13", "_optIO_4", "_optIO_5", "Frame5", "_optIO_7", "_optIO_6", "Frame6", "_optIO_9", "_optIO_8", "Frame7", "Label16", "Label10", "Label11", "Label12", "Label15", "Frame12", "_optIO_10", "_optIO_11", "Frame9", "_optIO_13", "_optIO_12", "Frame10", "_optIO_15", "_optIO_14", "Frame11", "Label17", "Label18", "Label19", "Label20", "Label21", "Frame8", "btnWrite", "btnDone", "_optIO_1", "_optIO_0", "Frame3", "_optIO_2", "_optIO_3", "Frame4", "Label13", "Label9", "Label8", "Label14", "Frame2", "_txtPhrase_16", "_chPlay_16", "_txtPhrase_15", "_chRestart_15", "_chInt_15", "_chClear_15", "_chPlay_15", "_txtPhrase_14", "_chRestart_14", "_chInt_14", "_chClear_14", "_chPlay_14", "_txtPhrase_13", "_chRestart_13", "_chInt_13", "_chClear_13", "_chPlay_13", "_txtPhrase_12", "_chRestart_12", "_chInt_12", "_chClear_12", "_chPlay_12", "_txtPhrase_11", "_chRestart_11", "_chInt_11", "_chClear_11", "_chPlay_11", "_txtPhrase_10", "_chRestart_10", "_chInt_10", "_chClear_10", "_chPlay_10", "_txtPhrase_9", "_chRestart_9", "_chInt_9", "_chClear_9", "_chPlay_9", "_txtPhrase_8", "_chRestart_8", "_chInt_8", "_chClear_8", "_chPlay_8", "_txtPhrase_7", "_chRestart_7", "_chInt_7", "_chClear_7", "_chPlay_7", "_txtPhrase_6", "_chRestart_6", "_chInt_6", "_chClear_6", "_chPlay_6", "_txtPhrase_5", "_chRestart_5", "_chInt_5", "_chClear_5", "_chPlay_5", "_txtPhrase_4", "_chRestart_4", "_chInt_4", "_chClear_4", "_chPlay_4", "_txtPhrase_3", "_chRestart_3", "_chInt_3", "_chClear_3", "_chPlay_3", "_txtPhrase_2", "_chRestart_2", "_chInt_2", "_chClear_2", "_chPlay_2", "_txtPhrase_1", "_chRestart_1", "_chInt_1", "_chClear_1", "_chPlay_1", "_txtPhrase_0", "_chRestart_0", "_chInt_0", "_chClear_0", "_chPlay_0", "Line2", "Line1", "_Label1_16", "_Label1_15", "_Label1_14", "_Label1_13", "_Label1_12", "_Label1_11", "_Label1_10", "_Label1_9", "_Label1_8", "_Label1_7", "_Label1_6", "_Label1_5", "_Label1_4", "_Label1_3", "_Label1_2", "_Label1_1", "Label7", "Label6", "Label5", "Label4", "Label3", "Label2", "_Label1_0", "Frame1", "Label1", "chClear", "chInt", "chPlay", "chRestart", "optIO", "txtPhrase"};
		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ToolTip ToolTipMain;
		public System.Windows.Forms.Button btnShutUp;
		public System.Windows.Forms.TextBox txtSCPNode;
		public System.Windows.Forms.CheckBox chAutoSil;
		public System.Windows.Forms.Label Label22;
		public System.Windows.Forms.GroupBox Frame13;
		private System.Windows.Forms.RadioButton _optIO_4;
		private System.Windows.Forms.RadioButton _optIO_5;
		public System.Windows.Forms.GroupBox Frame5;
		private System.Windows.Forms.RadioButton _optIO_7;
		private System.Windows.Forms.RadioButton _optIO_6;
		public System.Windows.Forms.GroupBox Frame6;
		private System.Windows.Forms.RadioButton _optIO_9;
		private System.Windows.Forms.RadioButton _optIO_8;
		public System.Windows.Forms.GroupBox Frame7;
		public System.Windows.Forms.Label Label16;
		public System.Windows.Forms.Label Label10;
		public System.Windows.Forms.Label Label11;
		public System.Windows.Forms.Label Label12;
		public System.Windows.Forms.Label Label15;
		public System.Windows.Forms.GroupBox Frame12;
		private System.Windows.Forms.RadioButton _optIO_10;
		private System.Windows.Forms.RadioButton _optIO_11;
		public System.Windows.Forms.GroupBox Frame9;
		private System.Windows.Forms.RadioButton _optIO_13;
		private System.Windows.Forms.RadioButton _optIO_12;
		public System.Windows.Forms.GroupBox Frame10;
		private System.Windows.Forms.RadioButton _optIO_15;
		private System.Windows.Forms.RadioButton _optIO_14;
		public System.Windows.Forms.GroupBox Frame11;
		public System.Windows.Forms.Label Label17;
		public System.Windows.Forms.Label Label18;
		public System.Windows.Forms.Label Label19;
		public System.Windows.Forms.Label Label20;
		public System.Windows.Forms.Label Label21;
		public System.Windows.Forms.GroupBox Frame8;
		public System.Windows.Forms.Button btnWrite;
		public System.Windows.Forms.Button btnDone;
		private System.Windows.Forms.RadioButton _optIO_1;
		private System.Windows.Forms.RadioButton _optIO_0;
		public System.Windows.Forms.GroupBox Frame3;
		private System.Windows.Forms.RadioButton _optIO_2;
		private System.Windows.Forms.RadioButton _optIO_3;
		public System.Windows.Forms.GroupBox Frame4;
		public System.Windows.Forms.Label Label13;
		public System.Windows.Forms.Label Label9;
		public System.Windows.Forms.Label Label8;
		public System.Windows.Forms.Label Label14;
		public System.Windows.Forms.GroupBox Frame2;
		private System.Windows.Forms.TextBox _txtPhrase_16;
		private System.Windows.Forms.CheckBox _chPlay_16;
		private System.Windows.Forms.TextBox _txtPhrase_15;
		private System.Windows.Forms.CheckBox _chRestart_15;
		private System.Windows.Forms.CheckBox _chInt_15;
		private System.Windows.Forms.CheckBox _chClear_15;
		private System.Windows.Forms.CheckBox _chPlay_15;
		private System.Windows.Forms.TextBox _txtPhrase_14;
		private System.Windows.Forms.CheckBox _chRestart_14;
		private System.Windows.Forms.CheckBox _chInt_14;
		private System.Windows.Forms.CheckBox _chClear_14;
		private System.Windows.Forms.CheckBox _chPlay_14;
		private System.Windows.Forms.TextBox _txtPhrase_13;
		private System.Windows.Forms.CheckBox _chRestart_13;
		private System.Windows.Forms.CheckBox _chInt_13;
		private System.Windows.Forms.CheckBox _chClear_13;
		private System.Windows.Forms.CheckBox _chPlay_13;
		private System.Windows.Forms.TextBox _txtPhrase_12;
		private System.Windows.Forms.CheckBox _chRestart_12;
		private System.Windows.Forms.CheckBox _chInt_12;
		private System.Windows.Forms.CheckBox _chClear_12;
		private System.Windows.Forms.CheckBox _chPlay_12;
		private System.Windows.Forms.TextBox _txtPhrase_11;
		private System.Windows.Forms.CheckBox _chRestart_11;
		private System.Windows.Forms.CheckBox _chInt_11;
		private System.Windows.Forms.CheckBox _chClear_11;
		private System.Windows.Forms.CheckBox _chPlay_11;
		private System.Windows.Forms.TextBox _txtPhrase_10;
		private System.Windows.Forms.CheckBox _chRestart_10;
		private System.Windows.Forms.CheckBox _chInt_10;
		private System.Windows.Forms.CheckBox _chClear_10;
		private System.Windows.Forms.CheckBox _chPlay_10;
		private System.Windows.Forms.TextBox _txtPhrase_9;
		private System.Windows.Forms.CheckBox _chRestart_9;
		private System.Windows.Forms.CheckBox _chInt_9;
		private System.Windows.Forms.CheckBox _chClear_9;
		private System.Windows.Forms.CheckBox _chPlay_9;
		private System.Windows.Forms.TextBox _txtPhrase_8;
		private System.Windows.Forms.CheckBox _chRestart_8;
		private System.Windows.Forms.CheckBox _chInt_8;
		private System.Windows.Forms.CheckBox _chClear_8;
		private System.Windows.Forms.CheckBox _chPlay_8;
		private System.Windows.Forms.TextBox _txtPhrase_7;
		private System.Windows.Forms.CheckBox _chRestart_7;
		private System.Windows.Forms.CheckBox _chInt_7;
		private System.Windows.Forms.CheckBox _chClear_7;
		private System.Windows.Forms.CheckBox _chPlay_7;
		private System.Windows.Forms.TextBox _txtPhrase_6;
		private System.Windows.Forms.CheckBox _chRestart_6;
		private System.Windows.Forms.CheckBox _chInt_6;
		private System.Windows.Forms.CheckBox _chClear_6;
		private System.Windows.Forms.CheckBox _chPlay_6;
		private System.Windows.Forms.TextBox _txtPhrase_5;
		private System.Windows.Forms.CheckBox _chRestart_5;
		private System.Windows.Forms.CheckBox _chInt_5;
		private System.Windows.Forms.CheckBox _chClear_5;
		private System.Windows.Forms.CheckBox _chPlay_5;
		private System.Windows.Forms.TextBox _txtPhrase_4;
		private System.Windows.Forms.CheckBox _chRestart_4;
		private System.Windows.Forms.CheckBox _chInt_4;
		private System.Windows.Forms.CheckBox _chClear_4;
		private System.Windows.Forms.CheckBox _chPlay_4;
		private System.Windows.Forms.TextBox _txtPhrase_3;
		private System.Windows.Forms.CheckBox _chRestart_3;
		private System.Windows.Forms.CheckBox _chInt_3;
		private System.Windows.Forms.CheckBox _chClear_3;
		private System.Windows.Forms.CheckBox _chPlay_3;
		private System.Windows.Forms.TextBox _txtPhrase_2;
		private System.Windows.Forms.CheckBox _chRestart_2;
		private System.Windows.Forms.CheckBox _chInt_2;
		private System.Windows.Forms.CheckBox _chClear_2;
		private System.Windows.Forms.CheckBox _chPlay_2;
		private System.Windows.Forms.TextBox _txtPhrase_1;
		private System.Windows.Forms.CheckBox _chRestart_1;
		private System.Windows.Forms.CheckBox _chInt_1;
		private System.Windows.Forms.CheckBox _chClear_1;
		private System.Windows.Forms.CheckBox _chPlay_1;
		private System.Windows.Forms.TextBox _txtPhrase_0;
		private System.Windows.Forms.CheckBox _chRestart_0;
		private System.Windows.Forms.CheckBox _chInt_0;
		private System.Windows.Forms.CheckBox _chClear_0;
		private System.Windows.Forms.CheckBox _chPlay_0;
		public System.Windows.Forms.Label Line2;
		public System.Windows.Forms.Label Line1;
		private System.Windows.Forms.Label _Label1_16;
		private System.Windows.Forms.Label _Label1_15;
		private System.Windows.Forms.Label _Label1_14;
		private System.Windows.Forms.Label _Label1_13;
		private System.Windows.Forms.Label _Label1_12;
		private System.Windows.Forms.Label _Label1_11;
		private System.Windows.Forms.Label _Label1_10;
		private System.Windows.Forms.Label _Label1_9;
		private System.Windows.Forms.Label _Label1_8;
		private System.Windows.Forms.Label _Label1_7;
		private System.Windows.Forms.Label _Label1_6;
		private System.Windows.Forms.Label _Label1_5;
		private System.Windows.Forms.Label _Label1_4;
		private System.Windows.Forms.Label _Label1_3;
		private System.Windows.Forms.Label _Label1_2;
		private System.Windows.Forms.Label _Label1_1;
		public System.Windows.Forms.Label Label7;
		public System.Windows.Forms.Label Label6;
		public System.Windows.Forms.Label Label5;
		public System.Windows.Forms.Label Label4;
		public System.Windows.Forms.Label Label3;
		public System.Windows.Forms.Label Label2;
		private System.Windows.Forms.Label _Label1_0;
		public System.Windows.Forms.GroupBox Frame1;
		public System.Windows.Forms.Label[] Label1 = new System.Windows.Forms.Label[17];
		public System.Windows.Forms.CheckBox[] chClear = new System.Windows.Forms.CheckBox[16];
		public System.Windows.Forms.CheckBox[] chInt = new System.Windows.Forms.CheckBox[16];
		public System.Windows.Forms.CheckBox[] chPlay = new System.Windows.Forms.CheckBox[17];
		public System.Windows.Forms.CheckBox[] chRestart = new System.Windows.Forms.CheckBox[16];
		public System.Windows.Forms.RadioButton[] optIO = new System.Windows.Forms.RadioButton[16];
		public System.Windows.Forms.TextBox[] txtPhrase = new System.Windows.Forms.TextBox[17];
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmButtons));
			this.ToolTipMain = new System.Windows.Forms.ToolTip(this.components);
			this.btnShutUp = new System.Windows.Forms.Button();
			this.Frame13 = new System.Windows.Forms.GroupBox();
			this.txtSCPNode = new System.Windows.Forms.TextBox();
			this.chAutoSil = new System.Windows.Forms.CheckBox();
			this.Label22 = new System.Windows.Forms.Label();
			this.Frame12 = new System.Windows.Forms.GroupBox();
			this.Frame5 = new System.Windows.Forms.GroupBox();
			this._optIO_4 = new System.Windows.Forms.RadioButton();
			this._optIO_5 = new System.Windows.Forms.RadioButton();
			this.Frame6 = new System.Windows.Forms.GroupBox();
			this._optIO_7 = new System.Windows.Forms.RadioButton();
			this._optIO_6 = new System.Windows.Forms.RadioButton();
			this.Frame7 = new System.Windows.Forms.GroupBox();
			this._optIO_9 = new System.Windows.Forms.RadioButton();
			this._optIO_8 = new System.Windows.Forms.RadioButton();
			this.Label16 = new System.Windows.Forms.Label();
			this.Label10 = new System.Windows.Forms.Label();
			this.Label11 = new System.Windows.Forms.Label();
			this.Label12 = new System.Windows.Forms.Label();
			this.Label15 = new System.Windows.Forms.Label();
			this.Frame8 = new System.Windows.Forms.GroupBox();
			this.Frame9 = new System.Windows.Forms.GroupBox();
			this._optIO_10 = new System.Windows.Forms.RadioButton();
			this._optIO_11 = new System.Windows.Forms.RadioButton();
			this.Frame10 = new System.Windows.Forms.GroupBox();
			this._optIO_13 = new System.Windows.Forms.RadioButton();
			this._optIO_12 = new System.Windows.Forms.RadioButton();
			this.Frame11 = new System.Windows.Forms.GroupBox();
			this._optIO_15 = new System.Windows.Forms.RadioButton();
			this._optIO_14 = new System.Windows.Forms.RadioButton();
			this.Label17 = new System.Windows.Forms.Label();
			this.Label18 = new System.Windows.Forms.Label();
			this.Label19 = new System.Windows.Forms.Label();
			this.Label20 = new System.Windows.Forms.Label();
			this.Label21 = new System.Windows.Forms.Label();
			this.btnWrite = new System.Windows.Forms.Button();
			this.btnDone = new System.Windows.Forms.Button();
			this.Frame2 = new System.Windows.Forms.GroupBox();
			this.Frame3 = new System.Windows.Forms.GroupBox();
			this._optIO_1 = new System.Windows.Forms.RadioButton();
			this._optIO_0 = new System.Windows.Forms.RadioButton();
			this.Frame4 = new System.Windows.Forms.GroupBox();
			this._optIO_2 = new System.Windows.Forms.RadioButton();
			this._optIO_3 = new System.Windows.Forms.RadioButton();
			this.Label13 = new System.Windows.Forms.Label();
			this.Label9 = new System.Windows.Forms.Label();
			this.Label8 = new System.Windows.Forms.Label();
			this.Label14 = new System.Windows.Forms.Label();
			this.Frame1 = new System.Windows.Forms.GroupBox();
			this._txtPhrase_16 = new System.Windows.Forms.TextBox();
			this._chPlay_16 = new System.Windows.Forms.CheckBox();
			this._txtPhrase_15 = new System.Windows.Forms.TextBox();
			this._chRestart_15 = new System.Windows.Forms.CheckBox();
			this._chInt_15 = new System.Windows.Forms.CheckBox();
			this._chClear_15 = new System.Windows.Forms.CheckBox();
			this._chPlay_15 = new System.Windows.Forms.CheckBox();
			this._txtPhrase_14 = new System.Windows.Forms.TextBox();
			this._chRestart_14 = new System.Windows.Forms.CheckBox();
			this._chInt_14 = new System.Windows.Forms.CheckBox();
			this._chClear_14 = new System.Windows.Forms.CheckBox();
			this._chPlay_14 = new System.Windows.Forms.CheckBox();
			this._txtPhrase_13 = new System.Windows.Forms.TextBox();
			this._chRestart_13 = new System.Windows.Forms.CheckBox();
			this._chInt_13 = new System.Windows.Forms.CheckBox();
			this._chClear_13 = new System.Windows.Forms.CheckBox();
			this._chPlay_13 = new System.Windows.Forms.CheckBox();
			this._txtPhrase_12 = new System.Windows.Forms.TextBox();
			this._chRestart_12 = new System.Windows.Forms.CheckBox();
			this._chInt_12 = new System.Windows.Forms.CheckBox();
			this._chClear_12 = new System.Windows.Forms.CheckBox();
			this._chPlay_12 = new System.Windows.Forms.CheckBox();
			this._txtPhrase_11 = new System.Windows.Forms.TextBox();
			this._chRestart_11 = new System.Windows.Forms.CheckBox();
			this._chInt_11 = new System.Windows.Forms.CheckBox();
			this._chClear_11 = new System.Windows.Forms.CheckBox();
			this._chPlay_11 = new System.Windows.Forms.CheckBox();
			this._txtPhrase_10 = new System.Windows.Forms.TextBox();
			this._chRestart_10 = new System.Windows.Forms.CheckBox();
			this._chInt_10 = new System.Windows.Forms.CheckBox();
			this._chClear_10 = new System.Windows.Forms.CheckBox();
			this._chPlay_10 = new System.Windows.Forms.CheckBox();
			this._txtPhrase_9 = new System.Windows.Forms.TextBox();
			this._chRestart_9 = new System.Windows.Forms.CheckBox();
			this._chInt_9 = new System.Windows.Forms.CheckBox();
			this._chClear_9 = new System.Windows.Forms.CheckBox();
			this._chPlay_9 = new System.Windows.Forms.CheckBox();
			this._txtPhrase_8 = new System.Windows.Forms.TextBox();
			this._chRestart_8 = new System.Windows.Forms.CheckBox();
			this._chInt_8 = new System.Windows.Forms.CheckBox();
			this._chClear_8 = new System.Windows.Forms.CheckBox();
			this._chPlay_8 = new System.Windows.Forms.CheckBox();
			this._txtPhrase_7 = new System.Windows.Forms.TextBox();
			this._chRestart_7 = new System.Windows.Forms.CheckBox();
			this._chInt_7 = new System.Windows.Forms.CheckBox();
			this._chClear_7 = new System.Windows.Forms.CheckBox();
			this._chPlay_7 = new System.Windows.Forms.CheckBox();
			this._txtPhrase_6 = new System.Windows.Forms.TextBox();
			this._chRestart_6 = new System.Windows.Forms.CheckBox();
			this._chInt_6 = new System.Windows.Forms.CheckBox();
			this._chClear_6 = new System.Windows.Forms.CheckBox();
			this._chPlay_6 = new System.Windows.Forms.CheckBox();
			this._txtPhrase_5 = new System.Windows.Forms.TextBox();
			this._chRestart_5 = new System.Windows.Forms.CheckBox();
			this._chInt_5 = new System.Windows.Forms.CheckBox();
			this._chClear_5 = new System.Windows.Forms.CheckBox();
			this._chPlay_5 = new System.Windows.Forms.CheckBox();
			this._txtPhrase_4 = new System.Windows.Forms.TextBox();
			this._chRestart_4 = new System.Windows.Forms.CheckBox();
			this._chInt_4 = new System.Windows.Forms.CheckBox();
			this._chClear_4 = new System.Windows.Forms.CheckBox();
			this._chPlay_4 = new System.Windows.Forms.CheckBox();
			this._txtPhrase_3 = new System.Windows.Forms.TextBox();
			this._chRestart_3 = new System.Windows.Forms.CheckBox();
			this._chInt_3 = new System.Windows.Forms.CheckBox();
			this._chClear_3 = new System.Windows.Forms.CheckBox();
			this._chPlay_3 = new System.Windows.Forms.CheckBox();
			this._txtPhrase_2 = new System.Windows.Forms.TextBox();
			this._chRestart_2 = new System.Windows.Forms.CheckBox();
			this._chInt_2 = new System.Windows.Forms.CheckBox();
			this._chClear_2 = new System.Windows.Forms.CheckBox();
			this._chPlay_2 = new System.Windows.Forms.CheckBox();
			this._txtPhrase_1 = new System.Windows.Forms.TextBox();
			this._chRestart_1 = new System.Windows.Forms.CheckBox();
			this._chInt_1 = new System.Windows.Forms.CheckBox();
			this._chClear_1 = new System.Windows.Forms.CheckBox();
			this._chPlay_1 = new System.Windows.Forms.CheckBox();
			this._txtPhrase_0 = new System.Windows.Forms.TextBox();
			this._chRestart_0 = new System.Windows.Forms.CheckBox();
			this._chInt_0 = new System.Windows.Forms.CheckBox();
			this._chClear_0 = new System.Windows.Forms.CheckBox();
			this._chPlay_0 = new System.Windows.Forms.CheckBox();
			this.Line2 = new System.Windows.Forms.Label();
			this.Line1 = new System.Windows.Forms.Label();
			this._Label1_16 = new System.Windows.Forms.Label();
			this._Label1_15 = new System.Windows.Forms.Label();
			this._Label1_14 = new System.Windows.Forms.Label();
			this._Label1_13 = new System.Windows.Forms.Label();
			this._Label1_12 = new System.Windows.Forms.Label();
			this._Label1_11 = new System.Windows.Forms.Label();
			this._Label1_10 = new System.Windows.Forms.Label();
			this._Label1_9 = new System.Windows.Forms.Label();
			this._Label1_8 = new System.Windows.Forms.Label();
			this._Label1_7 = new System.Windows.Forms.Label();
			this._Label1_6 = new System.Windows.Forms.Label();
			this._Label1_5 = new System.Windows.Forms.Label();
			this._Label1_4 = new System.Windows.Forms.Label();
			this._Label1_3 = new System.Windows.Forms.Label();
			this._Label1_2 = new System.Windows.Forms.Label();
			this._Label1_1 = new System.Windows.Forms.Label();
			this.Label7 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this._Label1_0 = new System.Windows.Forms.Label();
			this.Frame13.SuspendLayout();
			this.Frame12.SuspendLayout();
			this.Frame5.SuspendLayout();
			this.Frame6.SuspendLayout();
			this.Frame7.SuspendLayout();
			this.Frame8.SuspendLayout();
			this.Frame9.SuspendLayout();
			this.Frame10.SuspendLayout();
			this.Frame11.SuspendLayout();
			this.Frame2.SuspendLayout();
			this.Frame3.SuspendLayout();
			this.Frame4.SuspendLayout();
			this.Frame1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnShutUp
			// 
			this.btnShutUp.AllowDrop = true;
			this.btnShutUp.BackColor = System.Drawing.SystemColors.Control;
			this.btnShutUp.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnShutUp.Location = new System.Drawing.Point(412, 416);
			this.btnShutUp.Name = "btnShutUp";
			this.btnShutUp.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnShutUp.Size = new System.Drawing.Size(77, 29);
			this.btnShutUp.TabIndex = 151;
			this.btnShutUp.Text = "Shut Up";
			this.btnShutUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnShutUp.UseVisualStyleBackColor = false;
			this.btnShutUp.Click += new System.EventHandler(this.btnShutUp_Click);
			// 
			// Frame13
			// 
			this.Frame13.AllowDrop = true;
			this.Frame13.BackColor = System.Drawing.SystemColors.Control;
			this.Frame13.Controls.Add(this.txtSCPNode);
			this.Frame13.Controls.Add(this.chAutoSil);
			this.Frame13.Controls.Add(this.Label22);
			this.Frame13.Enabled = true;
			this.Frame13.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame13.Location = new System.Drawing.Point(4, 404);
			this.Frame13.Name = "Frame13";
			this.Frame13.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame13.Size = new System.Drawing.Size(393, 45);
			this.Frame13.TabIndex = 149;
			this.Frame13.Text = "Miscellaneous";
			this.Frame13.Visible = true;
			// 
			// txtSCPNode
			// 
			this.txtSCPNode.AcceptsReturn = true;
			this.txtSCPNode.AllowDrop = true;
			this.txtSCPNode.BackColor = System.Drawing.SystemColors.Window;
			this.txtSCPNode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtSCPNode.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtSCPNode.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtSCPNode.Location = new System.Drawing.Point(352, 18);
			this.txtSCPNode.MaxLength = 0;
			this.txtSCPNode.Name = "txtSCPNode";
			this.txtSCPNode.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtSCPNode.Size = new System.Drawing.Size(25, 19);
			this.txtSCPNode.TabIndex = 152;
			this.txtSCPNode.Text = "0";
			// 
			// chAutoSil
			// 
			this.chAutoSil.AllowDrop = true;
			this.chAutoSil.Appearance = System.Windows.Forms.Appearance.Normal;
			this.chAutoSil.BackColor = System.Drawing.SystemColors.Control;
			this.chAutoSil.CausesValidation = true;
			this.chAutoSil.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.chAutoSil.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chAutoSil.Enabled = true;
			this.chAutoSil.ForeColor = System.Drawing.SystemColors.ControlText;
			this.chAutoSil.Location = new System.Drawing.Point(24, 16);
			this.chAutoSil.Name = "chAutoSil";
			this.chAutoSil.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.chAutoSil.Size = new System.Drawing.Size(85, 21);
			this.chAutoSil.TabIndex = 150;
			this.chAutoSil.TabStop = true;
			this.chAutoSil.Text = "Auto Silence";
			this.chAutoSil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.chAutoSil.Visible = true;
			// 
			// Label22
			// 
			this.Label22.AllowDrop = true;
			this.Label22.BackColor = System.Drawing.SystemColors.Control;
			this.Label22.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label22.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label22.Location = new System.Drawing.Point(288, 20);
			this.Label22.Name = "Label22";
			this.Label22.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label22.Size = new System.Drawing.Size(57, 21);
			this.Label22.TabIndex = 153;
			this.Label22.Text = "SCP Node:";
			this.Label22.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// Frame12
			// 
			this.Frame12.AllowDrop = true;
			this.Frame12.BackColor = System.Drawing.SystemColors.Control;
			this.Frame12.Controls.Add(this.Frame5);
			this.Frame12.Controls.Add(this.Frame6);
			this.Frame12.Controls.Add(this.Frame7);
			this.Frame12.Controls.Add(this.Label16);
			this.Frame12.Controls.Add(this.Label10);
			this.Frame12.Controls.Add(this.Label11);
			this.Frame12.Controls.Add(this.Label12);
			this.Frame12.Controls.Add(this.Label15);
			this.Frame12.Enabled = true;
			this.Frame12.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame12.Location = new System.Drawing.Point(400, 112);
			this.Frame12.Name = "Frame12";
			this.Frame12.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame12.Size = new System.Drawing.Size(185, 121);
			this.Frame12.TabIndex = 134;
			this.Frame12.Text = "Output Controled by";
			this.Frame12.Visible = true;
			// 
			// Frame5
			// 
			this.Frame5.AllowDrop = true;
			this.Frame5.BackColor = System.Drawing.SystemColors.Control;
			this.Frame5.Controls.Add(this._optIO_4);
			this.Frame5.Controls.Add(this._optIO_5);
			this.Frame5.Enabled = true;
			this.Frame5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame5.Location = new System.Drawing.Point(76, 36);
			this.Frame5.Name = "Frame5";
			this.Frame5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame5.Size = new System.Drawing.Size(97, 29);
			this.Frame5.TabIndex = 140;
			this.Frame5.Visible = true;
			// 
			// _optIO_4
			// 
			this._optIO_4.AllowDrop = true;
			this._optIO_4.Appearance = System.Windows.Forms.Appearance.Normal;
			this._optIO_4.BackColor = System.Drawing.SystemColors.Control;
			this._optIO_4.CausesValidation = true;
			this._optIO_4.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._optIO_4.Checked = true;
			this._optIO_4.Enabled = true;
			this._optIO_4.ForeColor = System.Drawing.SystemColors.ControlText;
			this._optIO_4.Location = new System.Drawing.Point(12, 12);
			this._optIO_4.Name = "_optIO_4";
			this._optIO_4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._optIO_4.Size = new System.Drawing.Size(21, 13);
			this._optIO_4.TabIndex = 142;
			this._optIO_4.TabStop = true;
			this._optIO_4.Tag = "Out0Chip";
			this._optIO_4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._optIO_4.Visible = true;
			// 
			// _optIO_5
			// 
			this._optIO_5.AllowDrop = true;
			this._optIO_5.Appearance = System.Windows.Forms.Appearance.Normal;
			this._optIO_5.BackColor = System.Drawing.SystemColors.Control;
			this._optIO_5.CausesValidation = true;
			this._optIO_5.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._optIO_5.Checked = false;
			this._optIO_5.Enabled = true;
			this._optIO_5.ForeColor = System.Drawing.SystemColors.ControlText;
			this._optIO_5.Location = new System.Drawing.Point(64, 12);
			this._optIO_5.Name = "_optIO_5";
			this._optIO_5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._optIO_5.Size = new System.Drawing.Size(21, 13);
			this._optIO_5.TabIndex = 141;
			this._optIO_5.TabStop = true;
			this._optIO_5.Tag = "Out0Phrase";
			this._optIO_5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._optIO_5.Visible = true;
			// 
			// Frame6
			// 
			this.Frame6.AllowDrop = true;
			this.Frame6.BackColor = System.Drawing.SystemColors.Control;
			this.Frame6.Controls.Add(this._optIO_7);
			this.Frame6.Controls.Add(this._optIO_6);
			this.Frame6.Enabled = true;
			this.Frame6.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame6.Location = new System.Drawing.Point(76, 60);
			this.Frame6.Name = "Frame6";
			this.Frame6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame6.Size = new System.Drawing.Size(97, 29);
			this.Frame6.TabIndex = 143;
			this.Frame6.Visible = true;
			// 
			// _optIO_7
			// 
			this._optIO_7.AllowDrop = true;
			this._optIO_7.Appearance = System.Windows.Forms.Appearance.Normal;
			this._optIO_7.BackColor = System.Drawing.SystemColors.Control;
			this._optIO_7.CausesValidation = true;
			this._optIO_7.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._optIO_7.Checked = false;
			this._optIO_7.Enabled = true;
			this._optIO_7.ForeColor = System.Drawing.SystemColors.ControlText;
			this._optIO_7.Location = new System.Drawing.Point(64, 12);
			this._optIO_7.Name = "_optIO_7";
			this._optIO_7.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._optIO_7.Size = new System.Drawing.Size(21, 13);
			this._optIO_7.TabIndex = 145;
			this._optIO_7.TabStop = true;
			this._optIO_7.Tag = "Out1Phrase";
			this._optIO_7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._optIO_7.Visible = true;
			// 
			// _optIO_6
			// 
			this._optIO_6.AllowDrop = true;
			this._optIO_6.Appearance = System.Windows.Forms.Appearance.Normal;
			this._optIO_6.BackColor = System.Drawing.SystemColors.Control;
			this._optIO_6.CausesValidation = true;
			this._optIO_6.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._optIO_6.Checked = true;
			this._optIO_6.Enabled = true;
			this._optIO_6.ForeColor = System.Drawing.SystemColors.ControlText;
			this._optIO_6.Location = new System.Drawing.Point(12, 12);
			this._optIO_6.Name = "_optIO_6";
			this._optIO_6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._optIO_6.Size = new System.Drawing.Size(21, 13);
			this._optIO_6.TabIndex = 144;
			this._optIO_6.TabStop = true;
			this._optIO_6.Tag = "Out1Chip";
			this._optIO_6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._optIO_6.Visible = true;
			// 
			// Frame7
			// 
			this.Frame7.AllowDrop = true;
			this.Frame7.BackColor = System.Drawing.SystemColors.Control;
			this.Frame7.Controls.Add(this._optIO_9);
			this.Frame7.Controls.Add(this._optIO_8);
			this.Frame7.Enabled = true;
			this.Frame7.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame7.Location = new System.Drawing.Point(76, 84);
			this.Frame7.Name = "Frame7";
			this.Frame7.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame7.Size = new System.Drawing.Size(97, 29);
			this.Frame7.TabIndex = 146;
			this.Frame7.Visible = true;
			// 
			// _optIO_9
			// 
			this._optIO_9.AllowDrop = true;
			this._optIO_9.Appearance = System.Windows.Forms.Appearance.Normal;
			this._optIO_9.BackColor = System.Drawing.SystemColors.Control;
			this._optIO_9.CausesValidation = true;
			this._optIO_9.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._optIO_9.Checked = false;
			this._optIO_9.Enabled = true;
			this._optIO_9.ForeColor = System.Drawing.SystemColors.ControlText;
			this._optIO_9.Location = new System.Drawing.Point(64, 12);
			this._optIO_9.Name = "_optIO_9";
			this._optIO_9.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._optIO_9.Size = new System.Drawing.Size(21, 13);
			this._optIO_9.TabIndex = 148;
			this._optIO_9.TabStop = true;
			this._optIO_9.Tag = "Out2Phrase";
			this._optIO_9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._optIO_9.Visible = true;
			// 
			// _optIO_8
			// 
			this._optIO_8.AllowDrop = true;
			this._optIO_8.Appearance = System.Windows.Forms.Appearance.Normal;
			this._optIO_8.BackColor = System.Drawing.SystemColors.Control;
			this._optIO_8.CausesValidation = true;
			this._optIO_8.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._optIO_8.Checked = true;
			this._optIO_8.Enabled = true;
			this._optIO_8.ForeColor = System.Drawing.SystemColors.ControlText;
			this._optIO_8.Location = new System.Drawing.Point(12, 12);
			this._optIO_8.Name = "_optIO_8";
			this._optIO_8.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._optIO_8.Size = new System.Drawing.Size(21, 13);
			this._optIO_8.TabIndex = 147;
			this._optIO_8.TabStop = true;
			this._optIO_8.Tag = "Out2Chip";
			this._optIO_8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._optIO_8.Visible = true;
			// 
			// Label16
			// 
			this.Label16.AllowDrop = true;
			this.Label16.BackColor = System.Drawing.SystemColors.Control;
			this.Label16.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label16.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label16.Location = new System.Drawing.Point(124, 20);
			this.Label16.Name = "Label16";
			this.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label16.Size = new System.Drawing.Size(49, 29);
			this.Label16.TabIndex = 139;
			this.Label16.Text = "Phrase";
			this.Label16.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// Label10
			// 
			this.Label10.AllowDrop = true;
			this.Label10.BackColor = System.Drawing.SystemColors.Control;
			this.Label10.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label10.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label10.Location = new System.Drawing.Point(8, 48);
			this.Label10.Name = "Label10";
			this.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label10.Size = new System.Drawing.Size(57, 17);
			this.Label10.TabIndex = 138;
			this.Label10.Text = "Output #0";
			this.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// Label11
			// 
			this.Label11.AllowDrop = true;
			this.Label11.BackColor = System.Drawing.SystemColors.Control;
			this.Label11.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label11.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label11.Location = new System.Drawing.Point(8, 72);
			this.Label11.Name = "Label11";
			this.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label11.Size = new System.Drawing.Size(57, 17);
			this.Label11.TabIndex = 137;
			this.Label11.Text = "Output #1";
			this.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// Label12
			// 
			this.Label12.AllowDrop = true;
			this.Label12.BackColor = System.Drawing.SystemColors.Control;
			this.Label12.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label12.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label12.Location = new System.Drawing.Point(8, 96);
			this.Label12.Name = "Label12";
			this.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label12.Size = new System.Drawing.Size(57, 17);
			this.Label12.TabIndex = 136;
			this.Label12.Text = "Output #2";
			this.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// Label15
			// 
			this.Label15.AllowDrop = true;
			this.Label15.BackColor = System.Drawing.SystemColors.Control;
			this.Label15.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label15.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label15.Location = new System.Drawing.Point(68, 20);
			this.Label15.Name = "Label15";
			this.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label15.Size = new System.Drawing.Size(45, 33);
			this.Label15.TabIndex = 135;
			this.Label15.Text = "Chip";
			this.Label15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// Frame8
			// 
			this.Frame8.AllowDrop = true;
			this.Frame8.BackColor = System.Drawing.SystemColors.Control;
			this.Frame8.Controls.Add(this.Frame9);
			this.Frame8.Controls.Add(this.Frame10);
			this.Frame8.Controls.Add(this.Frame11);
			this.Frame8.Controls.Add(this.Label17);
			this.Frame8.Controls.Add(this.Label18);
			this.Frame8.Controls.Add(this.Label19);
			this.Frame8.Controls.Add(this.Label20);
			this.Frame8.Controls.Add(this.Label21);
			this.Frame8.Enabled = true;
			this.Frame8.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame8.Location = new System.Drawing.Point(400, 236);
			this.Frame8.Name = "Frame8";
			this.Frame8.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame8.Size = new System.Drawing.Size(185, 117);
			this.Frame8.TabIndex = 119;
			this.Frame8.Text = "Output Startup State";
			this.Frame8.Visible = true;
			// 
			// Frame9
			// 
			this.Frame9.AllowDrop = true;
			this.Frame9.BackColor = System.Drawing.SystemColors.Control;
			this.Frame9.Controls.Add(this._optIO_10);
			this.Frame9.Controls.Add(this._optIO_11);
			this.Frame9.Enabled = true;
			this.Frame9.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame9.Location = new System.Drawing.Point(76, 32);
			this.Frame9.Name = "Frame9";
			this.Frame9.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame9.Size = new System.Drawing.Size(97, 29);
			this.Frame9.TabIndex = 126;
			this.Frame9.Visible = true;
			// 
			// _optIO_10
			// 
			this._optIO_10.AllowDrop = true;
			this._optIO_10.Appearance = System.Windows.Forms.Appearance.Normal;
			this._optIO_10.BackColor = System.Drawing.SystemColors.Control;
			this._optIO_10.CausesValidation = true;
			this._optIO_10.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._optIO_10.Checked = true;
			this._optIO_10.Enabled = true;
			this._optIO_10.ForeColor = System.Drawing.SystemColors.ControlText;
			this._optIO_10.Location = new System.Drawing.Point(12, 12);
			this._optIO_10.Name = "_optIO_10";
			this._optIO_10.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._optIO_10.Size = new System.Drawing.Size(21, 13);
			this._optIO_10.TabIndex = 128;
			this._optIO_10.TabStop = true;
			this._optIO_10.Tag = "Out0On";
			this._optIO_10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._optIO_10.Visible = true;
			// 
			// _optIO_11
			// 
			this._optIO_11.AllowDrop = true;
			this._optIO_11.Appearance = System.Windows.Forms.Appearance.Normal;
			this._optIO_11.BackColor = System.Drawing.SystemColors.Control;
			this._optIO_11.CausesValidation = true;
			this._optIO_11.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._optIO_11.Checked = false;
			this._optIO_11.Enabled = true;
			this._optIO_11.ForeColor = System.Drawing.SystemColors.ControlText;
			this._optIO_11.Location = new System.Drawing.Point(64, 12);
			this._optIO_11.Name = "_optIO_11";
			this._optIO_11.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._optIO_11.Size = new System.Drawing.Size(21, 13);
			this._optIO_11.TabIndex = 127;
			this._optIO_11.TabStop = true;
			this._optIO_11.Tag = "Out0Off";
			this._optIO_11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._optIO_11.Visible = true;
			// 
			// Frame10
			// 
			this.Frame10.AllowDrop = true;
			this.Frame10.BackColor = System.Drawing.SystemColors.Control;
			this.Frame10.Controls.Add(this._optIO_13);
			this.Frame10.Controls.Add(this._optIO_12);
			this.Frame10.Enabled = true;
			this.Frame10.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame10.Location = new System.Drawing.Point(76, 56);
			this.Frame10.Name = "Frame10";
			this.Frame10.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame10.Size = new System.Drawing.Size(97, 29);
			this.Frame10.TabIndex = 123;
			this.Frame10.Visible = true;
			// 
			// _optIO_13
			// 
			this._optIO_13.AllowDrop = true;
			this._optIO_13.Appearance = System.Windows.Forms.Appearance.Normal;
			this._optIO_13.BackColor = System.Drawing.SystemColors.Control;
			this._optIO_13.CausesValidation = true;
			this._optIO_13.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._optIO_13.Checked = false;
			this._optIO_13.Enabled = true;
			this._optIO_13.ForeColor = System.Drawing.SystemColors.ControlText;
			this._optIO_13.Location = new System.Drawing.Point(64, 12);
			this._optIO_13.Name = "_optIO_13";
			this._optIO_13.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._optIO_13.Size = new System.Drawing.Size(21, 13);
			this._optIO_13.TabIndex = 125;
			this._optIO_13.TabStop = true;
			this._optIO_13.Tag = "Out1Off";
			this._optIO_13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._optIO_13.Visible = true;
			// 
			// _optIO_12
			// 
			this._optIO_12.AllowDrop = true;
			this._optIO_12.Appearance = System.Windows.Forms.Appearance.Normal;
			this._optIO_12.BackColor = System.Drawing.SystemColors.Control;
			this._optIO_12.CausesValidation = true;
			this._optIO_12.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._optIO_12.Checked = true;
			this._optIO_12.Enabled = true;
			this._optIO_12.ForeColor = System.Drawing.SystemColors.ControlText;
			this._optIO_12.Location = new System.Drawing.Point(12, 12);
			this._optIO_12.Name = "_optIO_12";
			this._optIO_12.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._optIO_12.Size = new System.Drawing.Size(21, 13);
			this._optIO_12.TabIndex = 124;
			this._optIO_12.TabStop = true;
			this._optIO_12.Tag = "Out1On";
			this._optIO_12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._optIO_12.Visible = true;
			// 
			// Frame11
			// 
			this.Frame11.AllowDrop = true;
			this.Frame11.BackColor = System.Drawing.SystemColors.Control;
			this.Frame11.Controls.Add(this._optIO_15);
			this.Frame11.Controls.Add(this._optIO_14);
			this.Frame11.Enabled = true;
			this.Frame11.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame11.Location = new System.Drawing.Point(76, 80);
			this.Frame11.Name = "Frame11";
			this.Frame11.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame11.Size = new System.Drawing.Size(97, 29);
			this.Frame11.TabIndex = 120;
			this.Frame11.Visible = true;
			// 
			// _optIO_15
			// 
			this._optIO_15.AllowDrop = true;
			this._optIO_15.Appearance = System.Windows.Forms.Appearance.Normal;
			this._optIO_15.BackColor = System.Drawing.SystemColors.Control;
			this._optIO_15.CausesValidation = true;
			this._optIO_15.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._optIO_15.Checked = false;
			this._optIO_15.Enabled = true;
			this._optIO_15.ForeColor = System.Drawing.SystemColors.ControlText;
			this._optIO_15.Location = new System.Drawing.Point(64, 12);
			this._optIO_15.Name = "_optIO_15";
			this._optIO_15.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._optIO_15.Size = new System.Drawing.Size(21, 13);
			this._optIO_15.TabIndex = 122;
			this._optIO_15.TabStop = true;
			this._optIO_15.Tag = "Out2Off";
			this._optIO_15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._optIO_15.Visible = true;
			// 
			// _optIO_14
			// 
			this._optIO_14.AllowDrop = true;
			this._optIO_14.Appearance = System.Windows.Forms.Appearance.Normal;
			this._optIO_14.BackColor = System.Drawing.SystemColors.Control;
			this._optIO_14.CausesValidation = true;
			this._optIO_14.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._optIO_14.Checked = true;
			this._optIO_14.Enabled = true;
			this._optIO_14.ForeColor = System.Drawing.SystemColors.ControlText;
			this._optIO_14.Location = new System.Drawing.Point(12, 12);
			this._optIO_14.Name = "_optIO_14";
			this._optIO_14.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._optIO_14.Size = new System.Drawing.Size(21, 13);
			this._optIO_14.TabIndex = 121;
			this._optIO_14.TabStop = true;
			this._optIO_14.Tag = "Out2On";
			this._optIO_14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._optIO_14.Visible = true;
			// 
			// Label17
			// 
			this.Label17.AllowDrop = true;
			this.Label17.BackColor = System.Drawing.SystemColors.Control;
			this.Label17.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label17.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label17.Location = new System.Drawing.Point(72, 20);
			this.Label17.Name = "Label17";
			this.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label17.Size = new System.Drawing.Size(45, 33);
			this.Label17.TabIndex = 133;
			this.Label17.Text = "On";
			this.Label17.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// Label18
			// 
			this.Label18.AllowDrop = true;
			this.Label18.BackColor = System.Drawing.SystemColors.Control;
			this.Label18.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label18.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label18.Location = new System.Drawing.Point(8, 92);
			this.Label18.Name = "Label18";
			this.Label18.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label18.Size = new System.Drawing.Size(57, 17);
			this.Label18.TabIndex = 132;
			this.Label18.Text = "Output #2";
			this.Label18.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// Label19
			// 
			this.Label19.AllowDrop = true;
			this.Label19.BackColor = System.Drawing.SystemColors.Control;
			this.Label19.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label19.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label19.Location = new System.Drawing.Point(8, 68);
			this.Label19.Name = "Label19";
			this.Label19.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label19.Size = new System.Drawing.Size(57, 17);
			this.Label19.TabIndex = 131;
			this.Label19.Text = "Output #1";
			this.Label19.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// Label20
			// 
			this.Label20.AllowDrop = true;
			this.Label20.BackColor = System.Drawing.SystemColors.Control;
			this.Label20.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label20.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label20.Location = new System.Drawing.Point(8, 44);
			this.Label20.Name = "Label20";
			this.Label20.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label20.Size = new System.Drawing.Size(57, 17);
			this.Label20.TabIndex = 130;
			this.Label20.Text = "Output #0";
			this.Label20.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// Label21
			// 
			this.Label21.AllowDrop = true;
			this.Label21.BackColor = System.Drawing.SystemColors.Control;
			this.Label21.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label21.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label21.Location = new System.Drawing.Point(124, 20);
			this.Label21.Name = "Label21";
			this.Label21.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label21.Size = new System.Drawing.Size(49, 29);
			this.Label21.TabIndex = 129;
			this.Label21.Text = "Off";
			this.Label21.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// btnWrite
			// 
			this.btnWrite.AllowDrop = true;
			this.btnWrite.BackColor = System.Drawing.SystemColors.Control;
			this.btnWrite.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnWrite.Location = new System.Drawing.Point(412, 372);
			this.btnWrite.Name = "btnWrite";
			this.btnWrite.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnWrite.Size = new System.Drawing.Size(165, 29);
			this.btnWrite.TabIndex = 112;
			this.btnWrite.Text = "Write Data to SpeakJet";
			this.btnWrite.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnWrite.UseVisualStyleBackColor = false;
			this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
			// 
			// btnDone
			// 
			this.btnDone.AllowDrop = true;
			this.btnDone.BackColor = System.Drawing.SystemColors.Control;
			this.btnDone.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnDone.Location = new System.Drawing.Point(500, 416);
			this.btnDone.Name = "btnDone";
			this.btnDone.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnDone.Size = new System.Drawing.Size(77, 29);
			this.btnDone.TabIndex = 111;
			this.btnDone.Text = "Done";
			this.btnDone.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnDone.UseVisualStyleBackColor = false;
			this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
			// 
			// Frame2
			// 
			this.Frame2.AllowDrop = true;
			this.Frame2.BackColor = System.Drawing.SystemColors.Control;
			this.Frame2.Controls.Add(this.Frame3);
			this.Frame2.Controls.Add(this.Frame4);
			this.Frame2.Controls.Add(this.Label13);
			this.Frame2.Controls.Add(this.Label9);
			this.Frame2.Controls.Add(this.Label8);
			this.Frame2.Controls.Add(this.Label14);
			this.Frame2.Enabled = true;
			this.Frame2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame2.Location = new System.Drawing.Point(400, 4);
			this.Frame2.Name = "Frame2";
			this.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame2.Size = new System.Drawing.Size(185, 105);
			this.Frame2.TabIndex = 106;
			this.Frame2.Text = "Input Style";
			this.Frame2.Visible = true;
			// 
			// Frame3
			// 
			this.Frame3.AllowDrop = true;
			this.Frame3.BackColor = System.Drawing.SystemColors.Control;
			this.Frame3.Controls.Add(this._optIO_1);
			this.Frame3.Controls.Add(this._optIO_0);
			this.Frame3.Enabled = true;
			this.Frame3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame3.Location = new System.Drawing.Point(76, 44);
			this.Frame3.Name = "Frame3";
			this.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame3.Size = new System.Drawing.Size(97, 29);
			this.Frame3.TabIndex = 113;
			this.Frame3.Visible = true;
			// 
			// _optIO_1
			// 
			this._optIO_1.AllowDrop = true;
			this._optIO_1.Appearance = System.Windows.Forms.Appearance.Normal;
			this._optIO_1.BackColor = System.Drawing.SystemColors.Control;
			this._optIO_1.CausesValidation = true;
			this._optIO_1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._optIO_1.Checked = false;
			this._optIO_1.Enabled = true;
			this._optIO_1.ForeColor = System.Drawing.SystemColors.ControlText;
			this._optIO_1.Location = new System.Drawing.Point(64, 12);
			this._optIO_1.Name = "_optIO_1";
			this._optIO_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._optIO_1.Size = new System.Drawing.Size(21, 13);
			this._optIO_1.TabIndex = 114;
			this._optIO_1.TabStop = true;
			this._optIO_1.Tag = "In7TTL";
			this._optIO_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._optIO_1.Visible = true;
			// 
			// _optIO_0
			// 
			this._optIO_0.AllowDrop = true;
			this._optIO_0.Appearance = System.Windows.Forms.Appearance.Normal;
			this._optIO_0.BackColor = System.Drawing.SystemColors.Control;
			this._optIO_0.CausesValidation = true;
			this._optIO_0.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._optIO_0.Checked = true;
			this._optIO_0.Enabled = true;
			this._optIO_0.ForeColor = System.Drawing.SystemColors.ControlText;
			this._optIO_0.Location = new System.Drawing.Point(12, 12);
			this._optIO_0.Name = "_optIO_0";
			this._optIO_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._optIO_0.Size = new System.Drawing.Size(21, 13);
			this._optIO_0.TabIndex = 115;
			this._optIO_0.TabStop = true;
			this._optIO_0.Tag = "In7RC";
			this._optIO_0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._optIO_0.Visible = true;
			// 
			// Frame4
			// 
			this.Frame4.AllowDrop = true;
			this.Frame4.BackColor = System.Drawing.SystemColors.Control;
			this.Frame4.Controls.Add(this._optIO_2);
			this.Frame4.Controls.Add(this._optIO_3);
			this.Frame4.Enabled = true;
			this.Frame4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame4.Location = new System.Drawing.Point(76, 68);
			this.Frame4.Name = "Frame4";
			this.Frame4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame4.Size = new System.Drawing.Size(97, 29);
			this.Frame4.TabIndex = 116;
			this.Frame4.Visible = true;
			// 
			// _optIO_2
			// 
			this._optIO_2.AllowDrop = true;
			this._optIO_2.Appearance = System.Windows.Forms.Appearance.Normal;
			this._optIO_2.BackColor = System.Drawing.SystemColors.Control;
			this._optIO_2.CausesValidation = true;
			this._optIO_2.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._optIO_2.Checked = true;
			this._optIO_2.Enabled = true;
			this._optIO_2.ForeColor = System.Drawing.SystemColors.ControlText;
			this._optIO_2.Location = new System.Drawing.Point(12, 12);
			this._optIO_2.Name = "_optIO_2";
			this._optIO_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._optIO_2.Size = new System.Drawing.Size(21, 13);
			this._optIO_2.TabIndex = 118;
			this._optIO_2.TabStop = true;
			this._optIO_2.Tag = "In6RC";
			this._optIO_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._optIO_2.Visible = true;
			// 
			// _optIO_3
			// 
			this._optIO_3.AllowDrop = true;
			this._optIO_3.Appearance = System.Windows.Forms.Appearance.Normal;
			this._optIO_3.BackColor = System.Drawing.SystemColors.Control;
			this._optIO_3.CausesValidation = true;
			this._optIO_3.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._optIO_3.Checked = false;
			this._optIO_3.Enabled = true;
			this._optIO_3.ForeColor = System.Drawing.SystemColors.ControlText;
			this._optIO_3.Location = new System.Drawing.Point(64, 12);
			this._optIO_3.Name = "_optIO_3";
			this._optIO_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._optIO_3.Size = new System.Drawing.Size(21, 13);
			this._optIO_3.TabIndex = 117;
			this._optIO_3.TabStop = true;
			this._optIO_3.Tag = "In6TTL";
			this._optIO_3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._optIO_3.Visible = true;
			// 
			// Label13
			// 
			this.Label13.AllowDrop = true;
			this.Label13.BackColor = System.Drawing.SystemColors.Control;
			this.Label13.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label13.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label13.Location = new System.Drawing.Point(132, 16);
			this.Label13.Name = "Label13";
			this.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label13.Size = new System.Drawing.Size(33, 25);
			this.Label13.TabIndex = 109;
			this.Label13.Text = "RC Pulse";
			this.Label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// Label9
			// 
			this.Label9.AllowDrop = true;
			this.Label9.BackColor = System.Drawing.SystemColors.Control;
			this.Label9.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label9.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label9.Location = new System.Drawing.Point(8, 80);
			this.Label9.Name = "Label9";
			this.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label9.Size = new System.Drawing.Size(57, 17);
			this.Label9.TabIndex = 108;
			this.Label9.Text = "Input #6";
			this.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// Label8
			// 
			this.Label8.AllowDrop = true;
			this.Label8.BackColor = System.Drawing.SystemColors.Control;
			this.Label8.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label8.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label8.Location = new System.Drawing.Point(8, 56);
			this.Label8.Name = "Label8";
			this.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label8.Size = new System.Drawing.Size(57, 17);
			this.Label8.TabIndex = 107;
			this.Label8.Text = "Input #7";
			this.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// Label14
			// 
			this.Label14.AllowDrop = true;
			this.Label14.BackColor = System.Drawing.SystemColors.Control;
			this.Label14.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label14.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label14.Location = new System.Drawing.Point(80, 16);
			this.Label14.Name = "Label14";
			this.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label14.Size = new System.Drawing.Size(33, 29);
			this.Label14.TabIndex = 110;
			this.Label14.Text = "TTL Signal";
			this.Label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// Frame1
			// 
			this.Frame1.AllowDrop = true;
			this.Frame1.BackColor = System.Drawing.SystemColors.Control;
			this.Frame1.Controls.Add(this._txtPhrase_16);
			this.Frame1.Controls.Add(this._chPlay_16);
			this.Frame1.Controls.Add(this._txtPhrase_15);
			this.Frame1.Controls.Add(this._chRestart_15);
			this.Frame1.Controls.Add(this._chInt_15);
			this.Frame1.Controls.Add(this._chClear_15);
			this.Frame1.Controls.Add(this._chPlay_15);
			this.Frame1.Controls.Add(this._txtPhrase_14);
			this.Frame1.Controls.Add(this._chRestart_14);
			this.Frame1.Controls.Add(this._chInt_14);
			this.Frame1.Controls.Add(this._chClear_14);
			this.Frame1.Controls.Add(this._chPlay_14);
			this.Frame1.Controls.Add(this._txtPhrase_13);
			this.Frame1.Controls.Add(this._chRestart_13);
			this.Frame1.Controls.Add(this._chInt_13);
			this.Frame1.Controls.Add(this._chClear_13);
			this.Frame1.Controls.Add(this._chPlay_13);
			this.Frame1.Controls.Add(this._txtPhrase_12);
			this.Frame1.Controls.Add(this._chRestart_12);
			this.Frame1.Controls.Add(this._chInt_12);
			this.Frame1.Controls.Add(this._chClear_12);
			this.Frame1.Controls.Add(this._chPlay_12);
			this.Frame1.Controls.Add(this._txtPhrase_11);
			this.Frame1.Controls.Add(this._chRestart_11);
			this.Frame1.Controls.Add(this._chInt_11);
			this.Frame1.Controls.Add(this._chClear_11);
			this.Frame1.Controls.Add(this._chPlay_11);
			this.Frame1.Controls.Add(this._txtPhrase_10);
			this.Frame1.Controls.Add(this._chRestart_10);
			this.Frame1.Controls.Add(this._chInt_10);
			this.Frame1.Controls.Add(this._chClear_10);
			this.Frame1.Controls.Add(this._chPlay_10);
			this.Frame1.Controls.Add(this._txtPhrase_9);
			this.Frame1.Controls.Add(this._chRestart_9);
			this.Frame1.Controls.Add(this._chInt_9);
			this.Frame1.Controls.Add(this._chClear_9);
			this.Frame1.Controls.Add(this._chPlay_9);
			this.Frame1.Controls.Add(this._txtPhrase_8);
			this.Frame1.Controls.Add(this._chRestart_8);
			this.Frame1.Controls.Add(this._chInt_8);
			this.Frame1.Controls.Add(this._chClear_8);
			this.Frame1.Controls.Add(this._chPlay_8);
			this.Frame1.Controls.Add(this._txtPhrase_7);
			this.Frame1.Controls.Add(this._chRestart_7);
			this.Frame1.Controls.Add(this._chInt_7);
			this.Frame1.Controls.Add(this._chClear_7);
			this.Frame1.Controls.Add(this._chPlay_7);
			this.Frame1.Controls.Add(this._txtPhrase_6);
			this.Frame1.Controls.Add(this._chRestart_6);
			this.Frame1.Controls.Add(this._chInt_6);
			this.Frame1.Controls.Add(this._chClear_6);
			this.Frame1.Controls.Add(this._chPlay_6);
			this.Frame1.Controls.Add(this._txtPhrase_5);
			this.Frame1.Controls.Add(this._chRestart_5);
			this.Frame1.Controls.Add(this._chInt_5);
			this.Frame1.Controls.Add(this._chClear_5);
			this.Frame1.Controls.Add(this._chPlay_5);
			this.Frame1.Controls.Add(this._txtPhrase_4);
			this.Frame1.Controls.Add(this._chRestart_4);
			this.Frame1.Controls.Add(this._chInt_4);
			this.Frame1.Controls.Add(this._chClear_4);
			this.Frame1.Controls.Add(this._chPlay_4);
			this.Frame1.Controls.Add(this._txtPhrase_3);
			this.Frame1.Controls.Add(this._chRestart_3);
			this.Frame1.Controls.Add(this._chInt_3);
			this.Frame1.Controls.Add(this._chClear_3);
			this.Frame1.Controls.Add(this._chPlay_3);
			this.Frame1.Controls.Add(this._txtPhrase_2);
			this.Frame1.Controls.Add(this._chRestart_2);
			this.Frame1.Controls.Add(this._chInt_2);
			this.Frame1.Controls.Add(this._chClear_2);
			this.Frame1.Controls.Add(this._chPlay_2);
			this.Frame1.Controls.Add(this._txtPhrase_1);
			this.Frame1.Controls.Add(this._chRestart_1);
			this.Frame1.Controls.Add(this._chInt_1);
			this.Frame1.Controls.Add(this._chClear_1);
			this.Frame1.Controls.Add(this._chPlay_1);
			this.Frame1.Controls.Add(this._txtPhrase_0);
			this.Frame1.Controls.Add(this._chRestart_0);
			this.Frame1.Controls.Add(this._chInt_0);
			this.Frame1.Controls.Add(this._chClear_0);
			this.Frame1.Controls.Add(this._chPlay_0);
			this.Frame1.Controls.Add(this.Line2);
			this.Frame1.Controls.Add(this.Line1);
			this.Frame1.Controls.Add(this._Label1_16);
			this.Frame1.Controls.Add(this._Label1_15);
			this.Frame1.Controls.Add(this._Label1_14);
			this.Frame1.Controls.Add(this._Label1_13);
			this.Frame1.Controls.Add(this._Label1_12);
			this.Frame1.Controls.Add(this._Label1_11);
			this.Frame1.Controls.Add(this._Label1_10);
			this.Frame1.Controls.Add(this._Label1_9);
			this.Frame1.Controls.Add(this._Label1_8);
			this.Frame1.Controls.Add(this._Label1_7);
			this.Frame1.Controls.Add(this._Label1_6);
			this.Frame1.Controls.Add(this._Label1_5);
			this.Frame1.Controls.Add(this._Label1_4);
			this.Frame1.Controls.Add(this._Label1_3);
			this.Frame1.Controls.Add(this._Label1_2);
			this.Frame1.Controls.Add(this._Label1_1);
			this.Frame1.Controls.Add(this.Label7);
			this.Frame1.Controls.Add(this.Label6);
			this.Frame1.Controls.Add(this.Label5);
			this.Frame1.Controls.Add(this.Label4);
			this.Frame1.Controls.Add(this.Label3);
			this.Frame1.Controls.Add(this.Label2);
			this.Frame1.Controls.Add(this._Label1_0);
			this.Frame1.Enabled = true;
			this.Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame1.Location = new System.Drawing.Point(4, 4);
			this.Frame1.Name = "Frame1";
			this.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame1.Size = new System.Drawing.Size(393, 397);
			this.Frame1.TabIndex = 0;
			this.Frame1.Text = "Events";
			this.Frame1.Visible = true;
			// 
			// _txtPhrase_16
			// 
			this._txtPhrase_16.AcceptsReturn = true;
			this._txtPhrase_16.AllowDrop = true;
			this._txtPhrase_16.BackColor = System.Drawing.SystemColors.Window;
			this._txtPhrase_16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._txtPhrase_16.Cursor = System.Windows.Forms.Cursors.IBeam;
			this._txtPhrase_16.ForeColor = System.Drawing.SystemColors.WindowText;
			this._txtPhrase_16.Location = new System.Drawing.Point(192, 368);
			this._txtPhrase_16.MaxLength = 0;
			this._txtPhrase_16.Name = "_txtPhrase_16";
			this._txtPhrase_16.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._txtPhrase_16.Size = new System.Drawing.Size(45, 19);
			this._txtPhrase_16.TabIndex = 105;
			this._txtPhrase_16.Text = "0";
			this._txtPhrase_16.Leave += new System.EventHandler(this.txtPhrase_Leave);
			// 
			// _chPlay_16
			// 
			this._chPlay_16.AllowDrop = true;
			this._chPlay_16.Appearance = System.Windows.Forms.Appearance.Normal;
			this._chPlay_16.BackColor = System.Drawing.SystemColors.Control;
			this._chPlay_16.CausesValidation = true;
			this._chPlay_16.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chPlay_16.CheckState = System.Windows.Forms.CheckState.Unchecked;
			this._chPlay_16.Enabled = true;
			this._chPlay_16.ForeColor = System.Drawing.SystemColors.ControlText;
			this._chPlay_16.Location = new System.Drawing.Point(156, 368);
			this._chPlay_16.Name = "_chPlay_16";
			this._chPlay_16.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._chPlay_16.Size = new System.Drawing.Size(13, 17);
			this._chPlay_16.TabIndex = 104;
			this._chPlay_16.TabStop = true;
			this._chPlay_16.Text = "";
			this._chPlay_16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chPlay_16.Visible = true;
			// 
			// _txtPhrase_15
			// 
			this._txtPhrase_15.AcceptsReturn = true;
			this._txtPhrase_15.AllowDrop = true;
			this._txtPhrase_15.BackColor = System.Drawing.SystemColors.Window;
			this._txtPhrase_15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._txtPhrase_15.Cursor = System.Windows.Forms.Cursors.IBeam;
			this._txtPhrase_15.ForeColor = System.Drawing.SystemColors.WindowText;
			this._txtPhrase_15.Location = new System.Drawing.Point(192, 348);
			this._txtPhrase_15.MaxLength = 0;
			this._txtPhrase_15.Name = "_txtPhrase_15";
			this._txtPhrase_15.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._txtPhrase_15.Size = new System.Drawing.Size(45, 19);
			this._txtPhrase_15.TabIndex = 103;
			this._txtPhrase_15.Text = "0";
			this._txtPhrase_15.Leave += new System.EventHandler(this.txtPhrase_Leave);
			// 
			// _chRestart_15
			// 
			this._chRestart_15.AllowDrop = true;
			this._chRestart_15.Appearance = System.Windows.Forms.Appearance.Normal;
			this._chRestart_15.BackColor = System.Drawing.SystemColors.Control;
			this._chRestart_15.CausesValidation = true;
			this._chRestart_15.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chRestart_15.CheckState = System.Windows.Forms.CheckState.Unchecked;
			this._chRestart_15.Enabled = true;
			this._chRestart_15.ForeColor = System.Drawing.SystemColors.ControlText;
			this._chRestart_15.Location = new System.Drawing.Point(356, 348);
			this._chRestart_15.Name = "_chRestart_15";
			this._chRestart_15.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._chRestart_15.Size = new System.Drawing.Size(13, 17);
			this._chRestart_15.TabIndex = 102;
			this._chRestart_15.TabStop = true;
			this._chRestart_15.Text = "";
			this._chRestart_15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chRestart_15.Visible = true;
			// 
			// _chInt_15
			// 
			this._chInt_15.AllowDrop = true;
			this._chInt_15.Appearance = System.Windows.Forms.Appearance.Normal;
			this._chInt_15.BackColor = System.Drawing.SystemColors.Control;
			this._chInt_15.CausesValidation = true;
			this._chInt_15.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chInt_15.CheckState = System.Windows.Forms.CheckState.Unchecked;
			this._chInt_15.Enabled = true;
			this._chInt_15.ForeColor = System.Drawing.SystemColors.ControlText;
			this._chInt_15.Location = new System.Drawing.Point(312, 348);
			this._chInt_15.Name = "_chInt_15";
			this._chInt_15.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._chInt_15.Size = new System.Drawing.Size(13, 17);
			this._chInt_15.TabIndex = 101;
			this._chInt_15.TabStop = true;
			this._chInt_15.Text = "";
			this._chInt_15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chInt_15.Visible = true;
			// 
			// _chClear_15
			// 
			this._chClear_15.AllowDrop = true;
			this._chClear_15.Appearance = System.Windows.Forms.Appearance.Normal;
			this._chClear_15.BackColor = System.Drawing.SystemColors.Control;
			this._chClear_15.CausesValidation = true;
			this._chClear_15.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chClear_15.CheckState = System.Windows.Forms.CheckState.Unchecked;
			this._chClear_15.Enabled = true;
			this._chClear_15.ForeColor = System.Drawing.SystemColors.ControlText;
			this._chClear_15.Location = new System.Drawing.Point(264, 348);
			this._chClear_15.Name = "_chClear_15";
			this._chClear_15.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._chClear_15.Size = new System.Drawing.Size(13, 17);
			this._chClear_15.TabIndex = 100;
			this._chClear_15.TabStop = true;
			this._chClear_15.Text = "";
			this._chClear_15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chClear_15.Visible = true;
			// 
			// _chPlay_15
			// 
			this._chPlay_15.AllowDrop = true;
			this._chPlay_15.Appearance = System.Windows.Forms.Appearance.Normal;
			this._chPlay_15.BackColor = System.Drawing.SystemColors.Control;
			this._chPlay_15.CausesValidation = true;
			this._chPlay_15.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chPlay_15.CheckState = System.Windows.Forms.CheckState.Unchecked;
			this._chPlay_15.Enabled = true;
			this._chPlay_15.ForeColor = System.Drawing.SystemColors.ControlText;
			this._chPlay_15.Location = new System.Drawing.Point(156, 348);
			this._chPlay_15.Name = "_chPlay_15";
			this._chPlay_15.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._chPlay_15.Size = new System.Drawing.Size(13, 17);
			this._chPlay_15.TabIndex = 99;
			this._chPlay_15.TabStop = true;
			this._chPlay_15.Text = "";
			this._chPlay_15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chPlay_15.Visible = true;
			// 
			// _txtPhrase_14
			// 
			this._txtPhrase_14.AcceptsReturn = true;
			this._txtPhrase_14.AllowDrop = true;
			this._txtPhrase_14.BackColor = System.Drawing.SystemColors.Window;
			this._txtPhrase_14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._txtPhrase_14.Cursor = System.Windows.Forms.Cursors.IBeam;
			this._txtPhrase_14.ForeColor = System.Drawing.SystemColors.WindowText;
			this._txtPhrase_14.Location = new System.Drawing.Point(192, 328);
			this._txtPhrase_14.MaxLength = 0;
			this._txtPhrase_14.Name = "_txtPhrase_14";
			this._txtPhrase_14.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._txtPhrase_14.Size = new System.Drawing.Size(45, 19);
			this._txtPhrase_14.TabIndex = 98;
			this._txtPhrase_14.Text = "0";
			this._txtPhrase_14.Leave += new System.EventHandler(this.txtPhrase_Leave);
			// 
			// _chRestart_14
			// 
			this._chRestart_14.AllowDrop = true;
			this._chRestart_14.Appearance = System.Windows.Forms.Appearance.Normal;
			this._chRestart_14.BackColor = System.Drawing.SystemColors.Control;
			this._chRestart_14.CausesValidation = true;
			this._chRestart_14.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chRestart_14.CheckState = System.Windows.Forms.CheckState.Unchecked;
			this._chRestart_14.Enabled = true;
			this._chRestart_14.ForeColor = System.Drawing.SystemColors.ControlText;
			this._chRestart_14.Location = new System.Drawing.Point(356, 328);
			this._chRestart_14.Name = "_chRestart_14";
			this._chRestart_14.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._chRestart_14.Size = new System.Drawing.Size(13, 17);
			this._chRestart_14.TabIndex = 97;
			this._chRestart_14.TabStop = true;
			this._chRestart_14.Text = "";
			this._chRestart_14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chRestart_14.Visible = true;
			// 
			// _chInt_14
			// 
			this._chInt_14.AllowDrop = true;
			this._chInt_14.Appearance = System.Windows.Forms.Appearance.Normal;
			this._chInt_14.BackColor = System.Drawing.SystemColors.Control;
			this._chInt_14.CausesValidation = true;
			this._chInt_14.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chInt_14.CheckState = System.Windows.Forms.CheckState.Unchecked;
			this._chInt_14.Enabled = true;
			this._chInt_14.ForeColor = System.Drawing.SystemColors.ControlText;
			this._chInt_14.Location = new System.Drawing.Point(312, 328);
			this._chInt_14.Name = "_chInt_14";
			this._chInt_14.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._chInt_14.Size = new System.Drawing.Size(13, 17);
			this._chInt_14.TabIndex = 96;
			this._chInt_14.TabStop = true;
			this._chInt_14.Text = "";
			this._chInt_14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chInt_14.Visible = true;
			// 
			// _chClear_14
			// 
			this._chClear_14.AllowDrop = true;
			this._chClear_14.Appearance = System.Windows.Forms.Appearance.Normal;
			this._chClear_14.BackColor = System.Drawing.SystemColors.Control;
			this._chClear_14.CausesValidation = true;
			this._chClear_14.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chClear_14.CheckState = System.Windows.Forms.CheckState.Unchecked;
			this._chClear_14.Enabled = true;
			this._chClear_14.ForeColor = System.Drawing.SystemColors.ControlText;
			this._chClear_14.Location = new System.Drawing.Point(264, 328);
			this._chClear_14.Name = "_chClear_14";
			this._chClear_14.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._chClear_14.Size = new System.Drawing.Size(13, 17);
			this._chClear_14.TabIndex = 95;
			this._chClear_14.TabStop = true;
			this._chClear_14.Text = "";
			this._chClear_14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chClear_14.Visible = true;
			// 
			// _chPlay_14
			// 
			this._chPlay_14.AllowDrop = true;
			this._chPlay_14.Appearance = System.Windows.Forms.Appearance.Normal;
			this._chPlay_14.BackColor = System.Drawing.SystemColors.Control;
			this._chPlay_14.CausesValidation = true;
			this._chPlay_14.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chPlay_14.CheckState = System.Windows.Forms.CheckState.Unchecked;
			this._chPlay_14.Enabled = true;
			this._chPlay_14.ForeColor = System.Drawing.SystemColors.ControlText;
			this._chPlay_14.Location = new System.Drawing.Point(156, 328);
			this._chPlay_14.Name = "_chPlay_14";
			this._chPlay_14.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._chPlay_14.Size = new System.Drawing.Size(13, 17);
			this._chPlay_14.TabIndex = 94;
			this._chPlay_14.TabStop = true;
			this._chPlay_14.Text = "";
			this._chPlay_14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chPlay_14.Visible = true;
			// 
			// _txtPhrase_13
			// 
			this._txtPhrase_13.AcceptsReturn = true;
			this._txtPhrase_13.AllowDrop = true;
			this._txtPhrase_13.BackColor = System.Drawing.SystemColors.Window;
			this._txtPhrase_13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._txtPhrase_13.Cursor = System.Windows.Forms.Cursors.IBeam;
			this._txtPhrase_13.ForeColor = System.Drawing.SystemColors.WindowText;
			this._txtPhrase_13.Location = new System.Drawing.Point(192, 308);
			this._txtPhrase_13.MaxLength = 0;
			this._txtPhrase_13.Name = "_txtPhrase_13";
			this._txtPhrase_13.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._txtPhrase_13.Size = new System.Drawing.Size(45, 19);
			this._txtPhrase_13.TabIndex = 93;
			this._txtPhrase_13.Text = "0";
			this._txtPhrase_13.Leave += new System.EventHandler(this.txtPhrase_Leave);
			// 
			// _chRestart_13
			// 
			this._chRestart_13.AllowDrop = true;
			this._chRestart_13.Appearance = System.Windows.Forms.Appearance.Normal;
			this._chRestart_13.BackColor = System.Drawing.SystemColors.Control;
			this._chRestart_13.CausesValidation = true;
			this._chRestart_13.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chRestart_13.CheckState = System.Windows.Forms.CheckState.Unchecked;
			this._chRestart_13.Enabled = true;
			this._chRestart_13.ForeColor = System.Drawing.SystemColors.ControlText;
			this._chRestart_13.Location = new System.Drawing.Point(356, 308);
			this._chRestart_13.Name = "_chRestart_13";
			this._chRestart_13.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._chRestart_13.Size = new System.Drawing.Size(13, 17);
			this._chRestart_13.TabIndex = 92;
			this._chRestart_13.TabStop = true;
			this._chRestart_13.Text = "";
			this._chRestart_13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chRestart_13.Visible = true;
			// 
			// _chInt_13
			// 
			this._chInt_13.AllowDrop = true;
			this._chInt_13.Appearance = System.Windows.Forms.Appearance.Normal;
			this._chInt_13.BackColor = System.Drawing.SystemColors.Control;
			this._chInt_13.CausesValidation = true;
			this._chInt_13.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chInt_13.CheckState = System.Windows.Forms.CheckState.Unchecked;
			this._chInt_13.Enabled = true;
			this._chInt_13.ForeColor = System.Drawing.SystemColors.ControlText;
			this._chInt_13.Location = new System.Drawing.Point(312, 308);
			this._chInt_13.Name = "_chInt_13";
			this._chInt_13.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._chInt_13.Size = new System.Drawing.Size(13, 17);
			this._chInt_13.TabIndex = 91;
			this._chInt_13.TabStop = true;
			this._chInt_13.Text = "";
			this._chInt_13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chInt_13.Visible = true;
			// 
			// _chClear_13
			// 
			this._chClear_13.AllowDrop = true;
			this._chClear_13.Appearance = System.Windows.Forms.Appearance.Normal;
			this._chClear_13.BackColor = System.Drawing.SystemColors.Control;
			this._chClear_13.CausesValidation = true;
			this._chClear_13.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chClear_13.CheckState = System.Windows.Forms.CheckState.Unchecked;
			this._chClear_13.Enabled = true;
			this._chClear_13.ForeColor = System.Drawing.SystemColors.ControlText;
			this._chClear_13.Location = new System.Drawing.Point(264, 308);
			this._chClear_13.Name = "_chClear_13";
			this._chClear_13.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._chClear_13.Size = new System.Drawing.Size(13, 17);
			this._chClear_13.TabIndex = 90;
			this._chClear_13.TabStop = true;
			this._chClear_13.Text = "";
			this._chClear_13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chClear_13.Visible = true;
			// 
			// _chPlay_13
			// 
			this._chPlay_13.AllowDrop = true;
			this._chPlay_13.Appearance = System.Windows.Forms.Appearance.Normal;
			this._chPlay_13.BackColor = System.Drawing.SystemColors.Control;
			this._chPlay_13.CausesValidation = true;
			this._chPlay_13.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chPlay_13.CheckState = System.Windows.Forms.CheckState.Unchecked;
			this._chPlay_13.Enabled = true;
			this._chPlay_13.ForeColor = System.Drawing.SystemColors.ControlText;
			this._chPlay_13.Location = new System.Drawing.Point(156, 308);
			this._chPlay_13.Name = "_chPlay_13";
			this._chPlay_13.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._chPlay_13.Size = new System.Drawing.Size(13, 17);
			this._chPlay_13.TabIndex = 89;
			this._chPlay_13.TabStop = true;
			this._chPlay_13.Text = "";
			this._chPlay_13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chPlay_13.Visible = true;
			// 
			// _txtPhrase_12
			// 
			this._txtPhrase_12.AcceptsReturn = true;
			this._txtPhrase_12.AllowDrop = true;
			this._txtPhrase_12.BackColor = System.Drawing.SystemColors.Window;
			this._txtPhrase_12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._txtPhrase_12.Cursor = System.Windows.Forms.Cursors.IBeam;
			this._txtPhrase_12.ForeColor = System.Drawing.SystemColors.WindowText;
			this._txtPhrase_12.Location = new System.Drawing.Point(192, 288);
			this._txtPhrase_12.MaxLength = 0;
			this._txtPhrase_12.Name = "_txtPhrase_12";
			this._txtPhrase_12.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._txtPhrase_12.Size = new System.Drawing.Size(45, 19);
			this._txtPhrase_12.TabIndex = 88;
			this._txtPhrase_12.Text = "0";
			this._txtPhrase_12.Leave += new System.EventHandler(this.txtPhrase_Leave);
			// 
			// _chRestart_12
			// 
			this._chRestart_12.AllowDrop = true;
			this._chRestart_12.Appearance = System.Windows.Forms.Appearance.Normal;
			this._chRestart_12.BackColor = System.Drawing.SystemColors.Control;
			this._chRestart_12.CausesValidation = true;
			this._chRestart_12.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chRestart_12.CheckState = System.Windows.Forms.CheckState.Unchecked;
			this._chRestart_12.Enabled = true;
			this._chRestart_12.ForeColor = System.Drawing.SystemColors.ControlText;
			this._chRestart_12.Location = new System.Drawing.Point(356, 288);
			this._chRestart_12.Name = "_chRestart_12";
			this._chRestart_12.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._chRestart_12.Size = new System.Drawing.Size(13, 17);
			this._chRestart_12.TabIndex = 87;
			this._chRestart_12.TabStop = true;
			this._chRestart_12.Text = "";
			this._chRestart_12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chRestart_12.Visible = true;
			// 
			// _chInt_12
			// 
			this._chInt_12.AllowDrop = true;
			this._chInt_12.Appearance = System.Windows.Forms.Appearance.Normal;
			this._chInt_12.BackColor = System.Drawing.SystemColors.Control;
			this._chInt_12.CausesValidation = true;
			this._chInt_12.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chInt_12.CheckState = System.Windows.Forms.CheckState.Unchecked;
			this._chInt_12.Enabled = true;
			this._chInt_12.ForeColor = System.Drawing.SystemColors.ControlText;
			this._chInt_12.Location = new System.Drawing.Point(312, 288);
			this._chInt_12.Name = "_chInt_12";
			this._chInt_12.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._chInt_12.Size = new System.Drawing.Size(13, 17);
			this._chInt_12.TabIndex = 86;
			this._chInt_12.TabStop = true;
			this._chInt_12.Text = "";
			this._chInt_12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chInt_12.Visible = true;
			// 
			// _chClear_12
			// 
			this._chClear_12.AllowDrop = true;
			this._chClear_12.Appearance = System.Windows.Forms.Appearance.Normal;
			this._chClear_12.BackColor = System.Drawing.SystemColors.Control;
			this._chClear_12.CausesValidation = true;
			this._chClear_12.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chClear_12.CheckState = System.Windows.Forms.CheckState.Unchecked;
			this._chClear_12.Enabled = true;
			this._chClear_12.ForeColor = System.Drawing.SystemColors.ControlText;
			this._chClear_12.Location = new System.Drawing.Point(264, 288);
			this._chClear_12.Name = "_chClear_12";
			this._chClear_12.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._chClear_12.Size = new System.Drawing.Size(13, 17);
			this._chClear_12.TabIndex = 85;
			this._chClear_12.TabStop = true;
			this._chClear_12.Text = "";
			this._chClear_12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chClear_12.Visible = true;
			// 
			// _chPlay_12
			// 
			this._chPlay_12.AllowDrop = true;
			this._chPlay_12.Appearance = System.Windows.Forms.Appearance.Normal;
			this._chPlay_12.BackColor = System.Drawing.SystemColors.Control;
			this._chPlay_12.CausesValidation = true;
			this._chPlay_12.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chPlay_12.CheckState = System.Windows.Forms.CheckState.Unchecked;
			this._chPlay_12.Enabled = true;
			this._chPlay_12.ForeColor = System.Drawing.SystemColors.ControlText;
			this._chPlay_12.Location = new System.Drawing.Point(156, 288);
			this._chPlay_12.Name = "_chPlay_12";
			this._chPlay_12.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._chPlay_12.Size = new System.Drawing.Size(13, 17);
			this._chPlay_12.TabIndex = 84;
			this._chPlay_12.TabStop = true;
			this._chPlay_12.Text = "";
			this._chPlay_12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chPlay_12.Visible = true;
			// 
			// _txtPhrase_11
			// 
			this._txtPhrase_11.AcceptsReturn = true;
			this._txtPhrase_11.AllowDrop = true;
			this._txtPhrase_11.BackColor = System.Drawing.SystemColors.Window;
			this._txtPhrase_11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._txtPhrase_11.Cursor = System.Windows.Forms.Cursors.IBeam;
			this._txtPhrase_11.ForeColor = System.Drawing.SystemColors.WindowText;
			this._txtPhrase_11.Location = new System.Drawing.Point(192, 268);
			this._txtPhrase_11.MaxLength = 0;
			this._txtPhrase_11.Name = "_txtPhrase_11";
			this._txtPhrase_11.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._txtPhrase_11.Size = new System.Drawing.Size(45, 19);
			this._txtPhrase_11.TabIndex = 83;
			this._txtPhrase_11.Text = "0";
			this._txtPhrase_11.Leave += new System.EventHandler(this.txtPhrase_Leave);
			// 
			// _chRestart_11
			// 
			this._chRestart_11.AllowDrop = true;
			this._chRestart_11.Appearance = System.Windows.Forms.Appearance.Normal;
			this._chRestart_11.BackColor = System.Drawing.SystemColors.Control;
			this._chRestart_11.CausesValidation = true;
			this._chRestart_11.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chRestart_11.CheckState = System.Windows.Forms.CheckState.Unchecked;
			this._chRestart_11.Enabled = true;
			this._chRestart_11.ForeColor = System.Drawing.SystemColors.ControlText;
			this._chRestart_11.Location = new System.Drawing.Point(356, 268);
			this._chRestart_11.Name = "_chRestart_11";
			this._chRestart_11.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._chRestart_11.Size = new System.Drawing.Size(13, 17);
			this._chRestart_11.TabIndex = 82;
			this._chRestart_11.TabStop = true;
			this._chRestart_11.Text = "";
			this._chRestart_11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chRestart_11.Visible = true;
			// 
			// _chInt_11
			// 
			this._chInt_11.AllowDrop = true;
			this._chInt_11.Appearance = System.Windows.Forms.Appearance.Normal;
			this._chInt_11.BackColor = System.Drawing.SystemColors.Control;
			this._chInt_11.CausesValidation = true;
			this._chInt_11.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chInt_11.CheckState = System.Windows.Forms.CheckState.Unchecked;
			this._chInt_11.Enabled = true;
			this._chInt_11.ForeColor = System.Drawing.SystemColors.ControlText;
			this._chInt_11.Location = new System.Drawing.Point(312, 268);
			this._chInt_11.Name = "_chInt_11";
			this._chInt_11.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._chInt_11.Size = new System.Drawing.Size(13, 17);
			this._chInt_11.TabIndex = 81;
			this._chInt_11.TabStop = true;
			this._chInt_11.Text = "";
			this._chInt_11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chInt_11.Visible = true;
			// 
			// _chClear_11
			// 
			this._chClear_11.AllowDrop = true;
			this._chClear_11.Appearance = System.Windows.Forms.Appearance.Normal;
			this._chClear_11.BackColor = System.Drawing.SystemColors.Control;
			this._chClear_11.CausesValidation = true;
			this._chClear_11.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chClear_11.CheckState = System.Windows.Forms.CheckState.Unchecked;
			this._chClear_11.Enabled = true;
			this._chClear_11.ForeColor = System.Drawing.SystemColors.ControlText;
			this._chClear_11.Location = new System.Drawing.Point(264, 268);
			this._chClear_11.Name = "_chClear_11";
			this._chClear_11.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._chClear_11.Size = new System.Drawing.Size(13, 17);
			this._chClear_11.TabIndex = 80;
			this._chClear_11.TabStop = true;
			this._chClear_11.Text = "";
			this._chClear_11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chClear_11.Visible = true;
			// 
			// _chPlay_11
			// 
			this._chPlay_11.AllowDrop = true;
			this._chPlay_11.Appearance = System.Windows.Forms.Appearance.Normal;
			this._chPlay_11.BackColor = System.Drawing.SystemColors.Control;
			this._chPlay_11.CausesValidation = true;
			this._chPlay_11.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chPlay_11.CheckState = System.Windows.Forms.CheckState.Unchecked;
			this._chPlay_11.Enabled = true;
			this._chPlay_11.ForeColor = System.Drawing.SystemColors.ControlText;
			this._chPlay_11.Location = new System.Drawing.Point(156, 268);
			this._chPlay_11.Name = "_chPlay_11";
			this._chPlay_11.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._chPlay_11.Size = new System.Drawing.Size(13, 17);
			this._chPlay_11.TabIndex = 79;
			this._chPlay_11.TabStop = true;
			this._chPlay_11.Text = "";
			this._chPlay_11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chPlay_11.Visible = true;
			// 
			// _txtPhrase_10
			// 
			this._txtPhrase_10.AcceptsReturn = true;
			this._txtPhrase_10.AllowDrop = true;
			this._txtPhrase_10.BackColor = System.Drawing.SystemColors.Window;
			this._txtPhrase_10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._txtPhrase_10.Cursor = System.Windows.Forms.Cursors.IBeam;
			this._txtPhrase_10.ForeColor = System.Drawing.SystemColors.WindowText;
			this._txtPhrase_10.Location = new System.Drawing.Point(192, 248);
			this._txtPhrase_10.MaxLength = 0;
			this._txtPhrase_10.Name = "_txtPhrase_10";
			this._txtPhrase_10.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._txtPhrase_10.Size = new System.Drawing.Size(45, 19);
			this._txtPhrase_10.TabIndex = 78;
			this._txtPhrase_10.Text = "0";
			this._txtPhrase_10.Leave += new System.EventHandler(this.txtPhrase_Leave);
			// 
			// _chRestart_10
			// 
			this._chRestart_10.AllowDrop = true;
			this._chRestart_10.Appearance = System.Windows.Forms.Appearance.Normal;
			this._chRestart_10.BackColor = System.Drawing.SystemColors.Control;
			this._chRestart_10.CausesValidation = true;
			this._chRestart_10.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chRestart_10.CheckState = System.Windows.Forms.CheckState.Unchecked;
			this._chRestart_10.Enabled = true;
			this._chRestart_10.ForeColor = System.Drawing.SystemColors.ControlText;
			this._chRestart_10.Location = new System.Drawing.Point(356, 248);
			this._chRestart_10.Name = "_chRestart_10";
			this._chRestart_10.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._chRestart_10.Size = new System.Drawing.Size(13, 17);
			this._chRestart_10.TabIndex = 77;
			this._chRestart_10.TabStop = true;
			this._chRestart_10.Text = "";
			this._chRestart_10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chRestart_10.Visible = true;
			// 
			// _chInt_10
			// 
			this._chInt_10.AllowDrop = true;
			this._chInt_10.Appearance = System.Windows.Forms.Appearance.Normal;
			this._chInt_10.BackColor = System.Drawing.SystemColors.Control;
			this._chInt_10.CausesValidation = true;
			this._chInt_10.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chInt_10.CheckState = System.Windows.Forms.CheckState.Unchecked;
			this._chInt_10.Enabled = true;
			this._chInt_10.ForeColor = System.Drawing.SystemColors.ControlText;
			this._chInt_10.Location = new System.Drawing.Point(312, 248);
			this._chInt_10.Name = "_chInt_10";
			this._chInt_10.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._chInt_10.Size = new System.Drawing.Size(13, 17);
			this._chInt_10.TabIndex = 76;
			this._chInt_10.TabStop = true;
			this._chInt_10.Text = "";
			this._chInt_10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chInt_10.Visible = true;
			// 
			// _chClear_10
			// 
			this._chClear_10.AllowDrop = true;
			this._chClear_10.Appearance = System.Windows.Forms.Appearance.Normal;
			this._chClear_10.BackColor = System.Drawing.SystemColors.Control;
			this._chClear_10.CausesValidation = true;
			this._chClear_10.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chClear_10.CheckState = System.Windows.Forms.CheckState.Unchecked;
			this._chClear_10.Enabled = true;
			this._chClear_10.ForeColor = System.Drawing.SystemColors.ControlText;
			this._chClear_10.Location = new System.Drawing.Point(264, 248);
			this._chClear_10.Name = "_chClear_10";
			this._chClear_10.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._chClear_10.Size = new System.Drawing.Size(13, 17);
			this._chClear_10.TabIndex = 75;
			this._chClear_10.TabStop = true;
			this._chClear_10.Text = "";
			this._chClear_10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chClear_10.Visible = true;
			// 
			// _chPlay_10
			// 
			this._chPlay_10.AllowDrop = true;
			this._chPlay_10.Appearance = System.Windows.Forms.Appearance.Normal;
			this._chPlay_10.BackColor = System.Drawing.SystemColors.Control;
			this._chPlay_10.CausesValidation = true;
			this._chPlay_10.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chPlay_10.CheckState = System.Windows.Forms.CheckState.Unchecked;
			this._chPlay_10.Enabled = true;
			this._chPlay_10.ForeColor = System.Drawing.SystemColors.ControlText;
			this._chPlay_10.Location = new System.Drawing.Point(156, 248);
			this._chPlay_10.Name = "_chPlay_10";
			this._chPlay_10.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._chPlay_10.Size = new System.Drawing.Size(13, 17);
			this._chPlay_10.TabIndex = 74;
			this._chPlay_10.TabStop = true;
			this._chPlay_10.Text = "";
			this._chPlay_10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chPlay_10.Visible = true;
			// 
			// _txtPhrase_9
			// 
			this._txtPhrase_9.AcceptsReturn = true;
			this._txtPhrase_9.AllowDrop = true;
			this._txtPhrase_9.BackColor = System.Drawing.SystemColors.Window;
			this._txtPhrase_9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._txtPhrase_9.Cursor = System.Windows.Forms.Cursors.IBeam;
			this._txtPhrase_9.ForeColor = System.Drawing.SystemColors.WindowText;
			this._txtPhrase_9.Location = new System.Drawing.Point(192, 228);
			this._txtPhrase_9.MaxLength = 0;
			this._txtPhrase_9.Name = "_txtPhrase_9";
			this._txtPhrase_9.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._txtPhrase_9.Size = new System.Drawing.Size(45, 19);
			this._txtPhrase_9.TabIndex = 73;
			this._txtPhrase_9.Text = "0";
			this._txtPhrase_9.Leave += new System.EventHandler(this.txtPhrase_Leave);
			// 
			// _chRestart_9
			// 
			this._chRestart_9.AllowDrop = true;
			this._chRestart_9.Appearance = System.Windows.Forms.Appearance.Normal;
			this._chRestart_9.BackColor = System.Drawing.SystemColors.Control;
			this._chRestart_9.CausesValidation = true;
			this._chRestart_9.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chRestart_9.CheckState = System.Windows.Forms.CheckState.Unchecked;
			this._chRestart_9.Enabled = true;
			this._chRestart_9.ForeColor = System.Drawing.SystemColors.ControlText;
			this._chRestart_9.Location = new System.Drawing.Point(356, 228);
			this._chRestart_9.Name = "_chRestart_9";
			this._chRestart_9.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._chRestart_9.Size = new System.Drawing.Size(13, 17);
			this._chRestart_9.TabIndex = 72;
			this._chRestart_9.TabStop = true;
			this._chRestart_9.Text = "";
			this._chRestart_9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chRestart_9.Visible = true;
			// 
			// _chInt_9
			// 
			this._chInt_9.AllowDrop = true;
			this._chInt_9.Appearance = System.Windows.Forms.Appearance.Normal;
			this._chInt_9.BackColor = System.Drawing.SystemColors.Control;
			this._chInt_9.CausesValidation = true;
			this._chInt_9.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chInt_9.CheckState = System.Windows.Forms.CheckState.Unchecked;
			this._chInt_9.Enabled = true;
			this._chInt_9.ForeColor = System.Drawing.SystemColors.ControlText;
			this._chInt_9.Location = new System.Drawing.Point(312, 228);
			this._chInt_9.Name = "_chInt_9";
			this._chInt_9.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._chInt_9.Size = new System.Drawing.Size(13, 17);
			this._chInt_9.TabIndex = 71;
			this._chInt_9.TabStop = true;
			this._chInt_9.Text = "";
			this._chInt_9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chInt_9.Visible = true;
			// 
			// _chClear_9
			// 
			this._chClear_9.AllowDrop = true;
			this._chClear_9.Appearance = System.Windows.Forms.Appearance.Normal;
			this._chClear_9.BackColor = System.Drawing.SystemColors.Control;
			this._chClear_9.CausesValidation = true;
			this._chClear_9.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chClear_9.CheckState = System.Windows.Forms.CheckState.Unchecked;
			this._chClear_9.Enabled = true;
			this._chClear_9.ForeColor = System.Drawing.SystemColors.ControlText;
			this._chClear_9.Location = new System.Drawing.Point(264, 228);
			this._chClear_9.Name = "_chClear_9";
			this._chClear_9.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._chClear_9.Size = new System.Drawing.Size(13, 17);
			this._chClear_9.TabIndex = 70;
			this._chClear_9.TabStop = true;
			this._chClear_9.Text = "";
			this._chClear_9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chClear_9.Visible = true;
			// 
			// _chPlay_9
			// 
			this._chPlay_9.AllowDrop = true;
			this._chPlay_9.Appearance = System.Windows.Forms.Appearance.Normal;
			this._chPlay_9.BackColor = System.Drawing.SystemColors.Control;
			this._chPlay_9.CausesValidation = true;
			this._chPlay_9.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chPlay_9.CheckState = System.Windows.Forms.CheckState.Unchecked;
			this._chPlay_9.Enabled = true;
			this._chPlay_9.ForeColor = System.Drawing.SystemColors.ControlText;
			this._chPlay_9.Location = new System.Drawing.Point(156, 228);
			this._chPlay_9.Name = "_chPlay_9";
			this._chPlay_9.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._chPlay_9.Size = new System.Drawing.Size(13, 17);
			this._chPlay_9.TabIndex = 69;
			this._chPlay_9.TabStop = true;
			this._chPlay_9.Text = "";
			this._chPlay_9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chPlay_9.Visible = true;
			// 
			// _txtPhrase_8
			// 
			this._txtPhrase_8.AcceptsReturn = true;
			this._txtPhrase_8.AllowDrop = true;
			this._txtPhrase_8.BackColor = System.Drawing.SystemColors.Window;
			this._txtPhrase_8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._txtPhrase_8.Cursor = System.Windows.Forms.Cursors.IBeam;
			this._txtPhrase_8.ForeColor = System.Drawing.SystemColors.WindowText;
			this._txtPhrase_8.Location = new System.Drawing.Point(192, 208);
			this._txtPhrase_8.MaxLength = 0;
			this._txtPhrase_8.Name = "_txtPhrase_8";
			this._txtPhrase_8.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._txtPhrase_8.Size = new System.Drawing.Size(45, 19);
			this._txtPhrase_8.TabIndex = 68;
			this._txtPhrase_8.Text = "0";
			this._txtPhrase_8.Leave += new System.EventHandler(this.txtPhrase_Leave);
			// 
			// _chRestart_8
			// 
			this._chRestart_8.AllowDrop = true;
			this._chRestart_8.Appearance = System.Windows.Forms.Appearance.Normal;
			this._chRestart_8.BackColor = System.Drawing.SystemColors.Control;
			this._chRestart_8.CausesValidation = true;
			this._chRestart_8.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chRestart_8.CheckState = System.Windows.Forms.CheckState.Unchecked;
			this._chRestart_8.Enabled = true;
			this._chRestart_8.ForeColor = System.Drawing.SystemColors.ControlText;
			this._chRestart_8.Location = new System.Drawing.Point(356, 208);
			this._chRestart_8.Name = "_chRestart_8";
			this._chRestart_8.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._chRestart_8.Size = new System.Drawing.Size(13, 17);
			this._chRestart_8.TabIndex = 67;
			this._chRestart_8.TabStop = true;
			this._chRestart_8.Text = "";
			this._chRestart_8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chRestart_8.Visible = true;
			// 
			// _chInt_8
			// 
			this._chInt_8.AllowDrop = true;
			this._chInt_8.Appearance = System.Windows.Forms.Appearance.Normal;
			this._chInt_8.BackColor = System.Drawing.SystemColors.Control;
			this._chInt_8.CausesValidation = true;
			this._chInt_8.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chInt_8.CheckState = System.Windows.Forms.CheckState.Unchecked;
			this._chInt_8.Enabled = true;
			this._chInt_8.ForeColor = System.Drawing.SystemColors.ControlText;
			this._chInt_8.Location = new System.Drawing.Point(312, 208);
			this._chInt_8.Name = "_chInt_8";
			this._chInt_8.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._chInt_8.Size = new System.Drawing.Size(13, 17);
			this._chInt_8.TabIndex = 66;
			this._chInt_8.TabStop = true;
			this._chInt_8.Text = "";
			this._chInt_8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chInt_8.Visible = true;
			// 
			// _chClear_8
			// 
			this._chClear_8.AllowDrop = true;
			this._chClear_8.Appearance = System.Windows.Forms.Appearance.Normal;
			this._chClear_8.BackColor = System.Drawing.SystemColors.Control;
			this._chClear_8.CausesValidation = true;
			this._chClear_8.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chClear_8.CheckState = System.Windows.Forms.CheckState.Unchecked;
			this._chClear_8.Enabled = true;
			this._chClear_8.ForeColor = System.Drawing.SystemColors.ControlText;
			this._chClear_8.Location = new System.Drawing.Point(264, 208);
			this._chClear_8.Name = "_chClear_8";
			this._chClear_8.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._chClear_8.Size = new System.Drawing.Size(13, 17);
			this._chClear_8.TabIndex = 65;
			this._chClear_8.TabStop = true;
			this._chClear_8.Text = "";
			this._chClear_8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chClear_8.Visible = true;
			// 
			// _chPlay_8
			// 
			this._chPlay_8.AllowDrop = true;
			this._chPlay_8.Appearance = System.Windows.Forms.Appearance.Normal;
			this._chPlay_8.BackColor = System.Drawing.SystemColors.Control;
			this._chPlay_8.CausesValidation = true;
			this._chPlay_8.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chPlay_8.CheckState = System.Windows.Forms.CheckState.Unchecked;
			this._chPlay_8.Enabled = true;
			this._chPlay_8.ForeColor = System.Drawing.SystemColors.ControlText;
			this._chPlay_8.Location = new System.Drawing.Point(156, 208);
			this._chPlay_8.Name = "_chPlay_8";
			this._chPlay_8.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._chPlay_8.Size = new System.Drawing.Size(13, 17);
			this._chPlay_8.TabIndex = 64;
			this._chPlay_8.TabStop = true;
			this._chPlay_8.Text = "";
			this._chPlay_8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chPlay_8.Visible = true;
			// 
			// _txtPhrase_7
			// 
			this._txtPhrase_7.AcceptsReturn = true;
			this._txtPhrase_7.AllowDrop = true;
			this._txtPhrase_7.BackColor = System.Drawing.SystemColors.Window;
			this._txtPhrase_7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._txtPhrase_7.Cursor = System.Windows.Forms.Cursors.IBeam;
			this._txtPhrase_7.ForeColor = System.Drawing.SystemColors.WindowText;
			this._txtPhrase_7.Location = new System.Drawing.Point(192, 188);
			this._txtPhrase_7.MaxLength = 0;
			this._txtPhrase_7.Name = "_txtPhrase_7";
			this._txtPhrase_7.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._txtPhrase_7.Size = new System.Drawing.Size(45, 19);
			this._txtPhrase_7.TabIndex = 63;
			this._txtPhrase_7.Text = "0";
			this._txtPhrase_7.Leave += new System.EventHandler(this.txtPhrase_Leave);
			// 
			// _chRestart_7
			// 
			this._chRestart_7.AllowDrop = true;
			this._chRestart_7.Appearance = System.Windows.Forms.Appearance.Normal;
			this._chRestart_7.BackColor = System.Drawing.SystemColors.Control;
			this._chRestart_7.CausesValidation = true;
			this._chRestart_7.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chRestart_7.CheckState = System.Windows.Forms.CheckState.Unchecked;
			this._chRestart_7.Enabled = true;
			this._chRestart_7.ForeColor = System.Drawing.SystemColors.ControlText;
			this._chRestart_7.Location = new System.Drawing.Point(356, 188);
			this._chRestart_7.Name = "_chRestart_7";
			this._chRestart_7.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._chRestart_7.Size = new System.Drawing.Size(13, 17);
			this._chRestart_7.TabIndex = 62;
			this._chRestart_7.TabStop = true;
			this._chRestart_7.Text = "";
			this._chRestart_7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chRestart_7.Visible = true;
			// 
			// _chInt_7
			// 
			this._chInt_7.AllowDrop = true;
			this._chInt_7.Appearance = System.Windows.Forms.Appearance.Normal;
			this._chInt_7.BackColor = System.Drawing.SystemColors.Control;
			this._chInt_7.CausesValidation = true;
			this._chInt_7.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chInt_7.CheckState = System.Windows.Forms.CheckState.Unchecked;
			this._chInt_7.Enabled = true;
			this._chInt_7.ForeColor = System.Drawing.SystemColors.ControlText;
			this._chInt_7.Location = new System.Drawing.Point(312, 188);
			this._chInt_7.Name = "_chInt_7";
			this._chInt_7.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._chInt_7.Size = new System.Drawing.Size(13, 17);
			this._chInt_7.TabIndex = 61;
			this._chInt_7.TabStop = true;
			this._chInt_7.Text = "";
			this._chInt_7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chInt_7.Visible = true;
			// 
			// _chClear_7
			// 
			this._chClear_7.AllowDrop = true;
			this._chClear_7.Appearance = System.Windows.Forms.Appearance.Normal;
			this._chClear_7.BackColor = System.Drawing.SystemColors.Control;
			this._chClear_7.CausesValidation = true;
			this._chClear_7.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chClear_7.CheckState = System.Windows.Forms.CheckState.Unchecked;
			this._chClear_7.Enabled = true;
			this._chClear_7.ForeColor = System.Drawing.SystemColors.ControlText;
			this._chClear_7.Location = new System.Drawing.Point(264, 188);
			this._chClear_7.Name = "_chClear_7";
			this._chClear_7.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._chClear_7.Size = new System.Drawing.Size(13, 17);
			this._chClear_7.TabIndex = 60;
			this._chClear_7.TabStop = true;
			this._chClear_7.Text = "";
			this._chClear_7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chClear_7.Visible = true;
			// 
			// _chPlay_7
			// 
			this._chPlay_7.AllowDrop = true;
			this._chPlay_7.Appearance = System.Windows.Forms.Appearance.Normal;
			this._chPlay_7.BackColor = System.Drawing.SystemColors.Control;
			this._chPlay_7.CausesValidation = true;
			this._chPlay_7.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chPlay_7.CheckState = System.Windows.Forms.CheckState.Unchecked;
			this._chPlay_7.Enabled = true;
			this._chPlay_7.ForeColor = System.Drawing.SystemColors.ControlText;
			this._chPlay_7.Location = new System.Drawing.Point(156, 188);
			this._chPlay_7.Name = "_chPlay_7";
			this._chPlay_7.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._chPlay_7.Size = new System.Drawing.Size(13, 17);
			this._chPlay_7.TabIndex = 59;
			this._chPlay_7.TabStop = true;
			this._chPlay_7.Text = "";
			this._chPlay_7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chPlay_7.Visible = true;
			// 
			// _txtPhrase_6
			// 
			this._txtPhrase_6.AcceptsReturn = true;
			this._txtPhrase_6.AllowDrop = true;
			this._txtPhrase_6.BackColor = System.Drawing.SystemColors.Window;
			this._txtPhrase_6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._txtPhrase_6.Cursor = System.Windows.Forms.Cursors.IBeam;
			this._txtPhrase_6.ForeColor = System.Drawing.SystemColors.WindowText;
			this._txtPhrase_6.Location = new System.Drawing.Point(192, 168);
			this._txtPhrase_6.MaxLength = 0;
			this._txtPhrase_6.Name = "_txtPhrase_6";
			this._txtPhrase_6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._txtPhrase_6.Size = new System.Drawing.Size(45, 19);
			this._txtPhrase_6.TabIndex = 58;
			this._txtPhrase_6.Text = "0";
			this._txtPhrase_6.Leave += new System.EventHandler(this.txtPhrase_Leave);
			// 
			// _chRestart_6
			// 
			this._chRestart_6.AllowDrop = true;
			this._chRestart_6.Appearance = System.Windows.Forms.Appearance.Normal;
			this._chRestart_6.BackColor = System.Drawing.SystemColors.Control;
			this._chRestart_6.CausesValidation = true;
			this._chRestart_6.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chRestart_6.CheckState = System.Windows.Forms.CheckState.Unchecked;
			this._chRestart_6.Enabled = true;
			this._chRestart_6.ForeColor = System.Drawing.SystemColors.ControlText;
			this._chRestart_6.Location = new System.Drawing.Point(356, 168);
			this._chRestart_6.Name = "_chRestart_6";
			this._chRestart_6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._chRestart_6.Size = new System.Drawing.Size(13, 17);
			this._chRestart_6.TabIndex = 57;
			this._chRestart_6.TabStop = true;
			this._chRestart_6.Text = "";
			this._chRestart_6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chRestart_6.Visible = true;
			// 
			// _chInt_6
			// 
			this._chInt_6.AllowDrop = true;
			this._chInt_6.Appearance = System.Windows.Forms.Appearance.Normal;
			this._chInt_6.BackColor = System.Drawing.SystemColors.Control;
			this._chInt_6.CausesValidation = true;
			this._chInt_6.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chInt_6.CheckState = System.Windows.Forms.CheckState.Unchecked;
			this._chInt_6.Enabled = true;
			this._chInt_6.ForeColor = System.Drawing.SystemColors.ControlText;
			this._chInt_6.Location = new System.Drawing.Point(312, 168);
			this._chInt_6.Name = "_chInt_6";
			this._chInt_6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._chInt_6.Size = new System.Drawing.Size(13, 17);
			this._chInt_6.TabIndex = 56;
			this._chInt_6.TabStop = true;
			this._chInt_6.Text = "";
			this._chInt_6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chInt_6.Visible = true;
			// 
			// _chClear_6
			// 
			this._chClear_6.AllowDrop = true;
			this._chClear_6.Appearance = System.Windows.Forms.Appearance.Normal;
			this._chClear_6.BackColor = System.Drawing.SystemColors.Control;
			this._chClear_6.CausesValidation = true;
			this._chClear_6.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chClear_6.CheckState = System.Windows.Forms.CheckState.Unchecked;
			this._chClear_6.Enabled = true;
			this._chClear_6.ForeColor = System.Drawing.SystemColors.ControlText;
			this._chClear_6.Location = new System.Drawing.Point(264, 168);
			this._chClear_6.Name = "_chClear_6";
			this._chClear_6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._chClear_6.Size = new System.Drawing.Size(13, 17);
			this._chClear_6.TabIndex = 55;
			this._chClear_6.TabStop = true;
			this._chClear_6.Text = "";
			this._chClear_6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chClear_6.Visible = true;
			// 
			// _chPlay_6
			// 
			this._chPlay_6.AllowDrop = true;
			this._chPlay_6.Appearance = System.Windows.Forms.Appearance.Normal;
			this._chPlay_6.BackColor = System.Drawing.SystemColors.Control;
			this._chPlay_6.CausesValidation = true;
			this._chPlay_6.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chPlay_6.CheckState = System.Windows.Forms.CheckState.Unchecked;
			this._chPlay_6.Enabled = true;
			this._chPlay_6.ForeColor = System.Drawing.SystemColors.ControlText;
			this._chPlay_6.Location = new System.Drawing.Point(156, 168);
			this._chPlay_6.Name = "_chPlay_6";
			this._chPlay_6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._chPlay_6.Size = new System.Drawing.Size(13, 17);
			this._chPlay_6.TabIndex = 54;
			this._chPlay_6.TabStop = true;
			this._chPlay_6.Text = "";
			this._chPlay_6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chPlay_6.Visible = true;
			// 
			// _txtPhrase_5
			// 
			this._txtPhrase_5.AcceptsReturn = true;
			this._txtPhrase_5.AllowDrop = true;
			this._txtPhrase_5.BackColor = System.Drawing.SystemColors.Window;
			this._txtPhrase_5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._txtPhrase_5.Cursor = System.Windows.Forms.Cursors.IBeam;
			this._txtPhrase_5.ForeColor = System.Drawing.SystemColors.WindowText;
			this._txtPhrase_5.Location = new System.Drawing.Point(192, 148);
			this._txtPhrase_5.MaxLength = 0;
			this._txtPhrase_5.Name = "_txtPhrase_5";
			this._txtPhrase_5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._txtPhrase_5.Size = new System.Drawing.Size(45, 19);
			this._txtPhrase_5.TabIndex = 53;
			this._txtPhrase_5.Text = "0";
			this._txtPhrase_5.Leave += new System.EventHandler(this.txtPhrase_Leave);
			// 
			// _chRestart_5
			// 
			this._chRestart_5.AllowDrop = true;
			this._chRestart_5.Appearance = System.Windows.Forms.Appearance.Normal;
			this._chRestart_5.BackColor = System.Drawing.SystemColors.Control;
			this._chRestart_5.CausesValidation = true;
			this._chRestart_5.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chRestart_5.CheckState = System.Windows.Forms.CheckState.Unchecked;
			this._chRestart_5.Enabled = true;
			this._chRestart_5.ForeColor = System.Drawing.SystemColors.ControlText;
			this._chRestart_5.Location = new System.Drawing.Point(356, 148);
			this._chRestart_5.Name = "_chRestart_5";
			this._chRestart_5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._chRestart_5.Size = new System.Drawing.Size(13, 17);
			this._chRestart_5.TabIndex = 52;
			this._chRestart_5.TabStop = true;
			this._chRestart_5.Text = "";
			this._chRestart_5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chRestart_5.Visible = true;
			// 
			// _chInt_5
			// 
			this._chInt_5.AllowDrop = true;
			this._chInt_5.Appearance = System.Windows.Forms.Appearance.Normal;
			this._chInt_5.BackColor = System.Drawing.SystemColors.Control;
			this._chInt_5.CausesValidation = true;
			this._chInt_5.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chInt_5.CheckState = System.Windows.Forms.CheckState.Unchecked;
			this._chInt_5.Enabled = true;
			this._chInt_5.ForeColor = System.Drawing.SystemColors.ControlText;
			this._chInt_5.Location = new System.Drawing.Point(312, 148);
			this._chInt_5.Name = "_chInt_5";
			this._chInt_5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._chInt_5.Size = new System.Drawing.Size(13, 17);
			this._chInt_5.TabIndex = 51;
			this._chInt_5.TabStop = true;
			this._chInt_5.Text = "";
			this._chInt_5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chInt_5.Visible = true;
			// 
			// _chClear_5
			// 
			this._chClear_5.AllowDrop = true;
			this._chClear_5.Appearance = System.Windows.Forms.Appearance.Normal;
			this._chClear_5.BackColor = System.Drawing.SystemColors.Control;
			this._chClear_5.CausesValidation = true;
			this._chClear_5.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chClear_5.CheckState = System.Windows.Forms.CheckState.Unchecked;
			this._chClear_5.Enabled = true;
			this._chClear_5.ForeColor = System.Drawing.SystemColors.ControlText;
			this._chClear_5.Location = new System.Drawing.Point(264, 148);
			this._chClear_5.Name = "_chClear_5";
			this._chClear_5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._chClear_5.Size = new System.Drawing.Size(13, 17);
			this._chClear_5.TabIndex = 50;
			this._chClear_5.TabStop = true;
			this._chClear_5.Text = "";
			this._chClear_5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chClear_5.Visible = true;
			// 
			// _chPlay_5
			// 
			this._chPlay_5.AllowDrop = true;
			this._chPlay_5.Appearance = System.Windows.Forms.Appearance.Normal;
			this._chPlay_5.BackColor = System.Drawing.SystemColors.Control;
			this._chPlay_5.CausesValidation = true;
			this._chPlay_5.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chPlay_5.CheckState = System.Windows.Forms.CheckState.Unchecked;
			this._chPlay_5.Enabled = true;
			this._chPlay_5.ForeColor = System.Drawing.SystemColors.ControlText;
			this._chPlay_5.Location = new System.Drawing.Point(156, 148);
			this._chPlay_5.Name = "_chPlay_5";
			this._chPlay_5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._chPlay_5.Size = new System.Drawing.Size(13, 17);
			this._chPlay_5.TabIndex = 49;
			this._chPlay_5.TabStop = true;
			this._chPlay_5.Text = "";
			this._chPlay_5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chPlay_5.Visible = true;
			// 
			// _txtPhrase_4
			// 
			this._txtPhrase_4.AcceptsReturn = true;
			this._txtPhrase_4.AllowDrop = true;
			this._txtPhrase_4.BackColor = System.Drawing.SystemColors.Window;
			this._txtPhrase_4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._txtPhrase_4.Cursor = System.Windows.Forms.Cursors.IBeam;
			this._txtPhrase_4.ForeColor = System.Drawing.SystemColors.WindowText;
			this._txtPhrase_4.Location = new System.Drawing.Point(192, 128);
			this._txtPhrase_4.MaxLength = 0;
			this._txtPhrase_4.Name = "_txtPhrase_4";
			this._txtPhrase_4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._txtPhrase_4.Size = new System.Drawing.Size(45, 19);
			this._txtPhrase_4.TabIndex = 48;
			this._txtPhrase_4.Text = "0";
			this._txtPhrase_4.Leave += new System.EventHandler(this.txtPhrase_Leave);
			// 
			// _chRestart_4
			// 
			this._chRestart_4.AllowDrop = true;
			this._chRestart_4.Appearance = System.Windows.Forms.Appearance.Normal;
			this._chRestart_4.BackColor = System.Drawing.SystemColors.Control;
			this._chRestart_4.CausesValidation = true;
			this._chRestart_4.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chRestart_4.CheckState = System.Windows.Forms.CheckState.Unchecked;
			this._chRestart_4.Enabled = true;
			this._chRestart_4.ForeColor = System.Drawing.SystemColors.ControlText;
			this._chRestart_4.Location = new System.Drawing.Point(356, 128);
			this._chRestart_4.Name = "_chRestart_4";
			this._chRestart_4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._chRestart_4.Size = new System.Drawing.Size(13, 17);
			this._chRestart_4.TabIndex = 47;
			this._chRestart_4.TabStop = true;
			this._chRestart_4.Text = "";
			this._chRestart_4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chRestart_4.Visible = true;
			// 
			// _chInt_4
			// 
			this._chInt_4.AllowDrop = true;
			this._chInt_4.Appearance = System.Windows.Forms.Appearance.Normal;
			this._chInt_4.BackColor = System.Drawing.SystemColors.Control;
			this._chInt_4.CausesValidation = true;
			this._chInt_4.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chInt_4.CheckState = System.Windows.Forms.CheckState.Unchecked;
			this._chInt_4.Enabled = true;
			this._chInt_4.ForeColor = System.Drawing.SystemColors.ControlText;
			this._chInt_4.Location = new System.Drawing.Point(312, 128);
			this._chInt_4.Name = "_chInt_4";
			this._chInt_4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._chInt_4.Size = new System.Drawing.Size(13, 17);
			this._chInt_4.TabIndex = 46;
			this._chInt_4.TabStop = true;
			this._chInt_4.Text = "";
			this._chInt_4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chInt_4.Visible = true;
			// 
			// _chClear_4
			// 
			this._chClear_4.AllowDrop = true;
			this._chClear_4.Appearance = System.Windows.Forms.Appearance.Normal;
			this._chClear_4.BackColor = System.Drawing.SystemColors.Control;
			this._chClear_4.CausesValidation = true;
			this._chClear_4.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chClear_4.CheckState = System.Windows.Forms.CheckState.Unchecked;
			this._chClear_4.Enabled = true;
			this._chClear_4.ForeColor = System.Drawing.SystemColors.ControlText;
			this._chClear_4.Location = new System.Drawing.Point(264, 128);
			this._chClear_4.Name = "_chClear_4";
			this._chClear_4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._chClear_4.Size = new System.Drawing.Size(13, 17);
			this._chClear_4.TabIndex = 45;
			this._chClear_4.TabStop = true;
			this._chClear_4.Text = "";
			this._chClear_4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chClear_4.Visible = true;
			// 
			// _chPlay_4
			// 
			this._chPlay_4.AllowDrop = true;
			this._chPlay_4.Appearance = System.Windows.Forms.Appearance.Normal;
			this._chPlay_4.BackColor = System.Drawing.SystemColors.Control;
			this._chPlay_4.CausesValidation = true;
			this._chPlay_4.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chPlay_4.CheckState = System.Windows.Forms.CheckState.Unchecked;
			this._chPlay_4.Enabled = true;
			this._chPlay_4.ForeColor = System.Drawing.SystemColors.ControlText;
			this._chPlay_4.Location = new System.Drawing.Point(156, 128);
			this._chPlay_4.Name = "_chPlay_4";
			this._chPlay_4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._chPlay_4.Size = new System.Drawing.Size(13, 17);
			this._chPlay_4.TabIndex = 44;
			this._chPlay_4.TabStop = true;
			this._chPlay_4.Text = "";
			this._chPlay_4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chPlay_4.Visible = true;
			// 
			// _txtPhrase_3
			// 
			this._txtPhrase_3.AcceptsReturn = true;
			this._txtPhrase_3.AllowDrop = true;
			this._txtPhrase_3.BackColor = System.Drawing.SystemColors.Window;
			this._txtPhrase_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._txtPhrase_3.Cursor = System.Windows.Forms.Cursors.IBeam;
			this._txtPhrase_3.ForeColor = System.Drawing.SystemColors.WindowText;
			this._txtPhrase_3.Location = new System.Drawing.Point(192, 108);
			this._txtPhrase_3.MaxLength = 0;
			this._txtPhrase_3.Name = "_txtPhrase_3";
			this._txtPhrase_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._txtPhrase_3.Size = new System.Drawing.Size(45, 19);
			this._txtPhrase_3.TabIndex = 43;
			this._txtPhrase_3.Text = "0";
			this._txtPhrase_3.Leave += new System.EventHandler(this.txtPhrase_Leave);
			// 
			// _chRestart_3
			// 
			this._chRestart_3.AllowDrop = true;
			this._chRestart_3.Appearance = System.Windows.Forms.Appearance.Normal;
			this._chRestart_3.BackColor = System.Drawing.SystemColors.Control;
			this._chRestart_3.CausesValidation = true;
			this._chRestart_3.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chRestart_3.CheckState = System.Windows.Forms.CheckState.Unchecked;
			this._chRestart_3.Enabled = true;
			this._chRestart_3.ForeColor = System.Drawing.SystemColors.ControlText;
			this._chRestart_3.Location = new System.Drawing.Point(356, 108);
			this._chRestart_3.Name = "_chRestart_3";
			this._chRestart_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._chRestart_3.Size = new System.Drawing.Size(13, 17);
			this._chRestart_3.TabIndex = 42;
			this._chRestart_3.TabStop = true;
			this._chRestart_3.Text = "";
			this._chRestart_3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chRestart_3.Visible = true;
			// 
			// _chInt_3
			// 
			this._chInt_3.AllowDrop = true;
			this._chInt_3.Appearance = System.Windows.Forms.Appearance.Normal;
			this._chInt_3.BackColor = System.Drawing.SystemColors.Control;
			this._chInt_3.CausesValidation = true;
			this._chInt_3.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chInt_3.CheckState = System.Windows.Forms.CheckState.Unchecked;
			this._chInt_3.Enabled = true;
			this._chInt_3.ForeColor = System.Drawing.SystemColors.ControlText;
			this._chInt_3.Location = new System.Drawing.Point(312, 108);
			this._chInt_3.Name = "_chInt_3";
			this._chInt_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._chInt_3.Size = new System.Drawing.Size(13, 17);
			this._chInt_3.TabIndex = 41;
			this._chInt_3.TabStop = true;
			this._chInt_3.Text = "";
			this._chInt_3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chInt_3.Visible = true;
			// 
			// _chClear_3
			// 
			this._chClear_3.AllowDrop = true;
			this._chClear_3.Appearance = System.Windows.Forms.Appearance.Normal;
			this._chClear_3.BackColor = System.Drawing.SystemColors.Control;
			this._chClear_3.CausesValidation = true;
			this._chClear_3.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chClear_3.CheckState = System.Windows.Forms.CheckState.Unchecked;
			this._chClear_3.Enabled = true;
			this._chClear_3.ForeColor = System.Drawing.SystemColors.ControlText;
			this._chClear_3.Location = new System.Drawing.Point(264, 108);
			this._chClear_3.Name = "_chClear_3";
			this._chClear_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._chClear_3.Size = new System.Drawing.Size(13, 17);
			this._chClear_3.TabIndex = 40;
			this._chClear_3.TabStop = true;
			this._chClear_3.Text = "";
			this._chClear_3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chClear_3.Visible = true;
			// 
			// _chPlay_3
			// 
			this._chPlay_3.AllowDrop = true;
			this._chPlay_3.Appearance = System.Windows.Forms.Appearance.Normal;
			this._chPlay_3.BackColor = System.Drawing.SystemColors.Control;
			this._chPlay_3.CausesValidation = true;
			this._chPlay_3.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chPlay_3.CheckState = System.Windows.Forms.CheckState.Unchecked;
			this._chPlay_3.Enabled = true;
			this._chPlay_3.ForeColor = System.Drawing.SystemColors.ControlText;
			this._chPlay_3.Location = new System.Drawing.Point(156, 108);
			this._chPlay_3.Name = "_chPlay_3";
			this._chPlay_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._chPlay_3.Size = new System.Drawing.Size(13, 17);
			this._chPlay_3.TabIndex = 39;
			this._chPlay_3.TabStop = true;
			this._chPlay_3.Text = "";
			this._chPlay_3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chPlay_3.Visible = true;
			// 
			// _txtPhrase_2
			// 
			this._txtPhrase_2.AcceptsReturn = true;
			this._txtPhrase_2.AllowDrop = true;
			this._txtPhrase_2.BackColor = System.Drawing.SystemColors.Window;
			this._txtPhrase_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._txtPhrase_2.Cursor = System.Windows.Forms.Cursors.IBeam;
			this._txtPhrase_2.ForeColor = System.Drawing.SystemColors.WindowText;
			this._txtPhrase_2.Location = new System.Drawing.Point(192, 88);
			this._txtPhrase_2.MaxLength = 0;
			this._txtPhrase_2.Name = "_txtPhrase_2";
			this._txtPhrase_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._txtPhrase_2.Size = new System.Drawing.Size(45, 19);
			this._txtPhrase_2.TabIndex = 38;
			this._txtPhrase_2.Text = "0";
			this._txtPhrase_2.Leave += new System.EventHandler(this.txtPhrase_Leave);
			// 
			// _chRestart_2
			// 
			this._chRestart_2.AllowDrop = true;
			this._chRestart_2.Appearance = System.Windows.Forms.Appearance.Normal;
			this._chRestart_2.BackColor = System.Drawing.SystemColors.Control;
			this._chRestart_2.CausesValidation = true;
			this._chRestart_2.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chRestart_2.CheckState = System.Windows.Forms.CheckState.Unchecked;
			this._chRestart_2.Enabled = true;
			this._chRestart_2.ForeColor = System.Drawing.SystemColors.ControlText;
			this._chRestart_2.Location = new System.Drawing.Point(356, 88);
			this._chRestart_2.Name = "_chRestart_2";
			this._chRestart_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._chRestart_2.Size = new System.Drawing.Size(13, 17);
			this._chRestart_2.TabIndex = 37;
			this._chRestart_2.TabStop = true;
			this._chRestart_2.Text = "";
			this._chRestart_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chRestart_2.Visible = true;
			// 
			// _chInt_2
			// 
			this._chInt_2.AllowDrop = true;
			this._chInt_2.Appearance = System.Windows.Forms.Appearance.Normal;
			this._chInt_2.BackColor = System.Drawing.SystemColors.Control;
			this._chInt_2.CausesValidation = true;
			this._chInt_2.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chInt_2.CheckState = System.Windows.Forms.CheckState.Unchecked;
			this._chInt_2.Enabled = true;
			this._chInt_2.ForeColor = System.Drawing.SystemColors.ControlText;
			this._chInt_2.Location = new System.Drawing.Point(312, 88);
			this._chInt_2.Name = "_chInt_2";
			this._chInt_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._chInt_2.Size = new System.Drawing.Size(13, 17);
			this._chInt_2.TabIndex = 36;
			this._chInt_2.TabStop = true;
			this._chInt_2.Text = "";
			this._chInt_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chInt_2.Visible = true;
			// 
			// _chClear_2
			// 
			this._chClear_2.AllowDrop = true;
			this._chClear_2.Appearance = System.Windows.Forms.Appearance.Normal;
			this._chClear_2.BackColor = System.Drawing.SystemColors.Control;
			this._chClear_2.CausesValidation = true;
			this._chClear_2.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chClear_2.CheckState = System.Windows.Forms.CheckState.Unchecked;
			this._chClear_2.Enabled = true;
			this._chClear_2.ForeColor = System.Drawing.SystemColors.ControlText;
			this._chClear_2.Location = new System.Drawing.Point(264, 88);
			this._chClear_2.Name = "_chClear_2";
			this._chClear_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._chClear_2.Size = new System.Drawing.Size(13, 17);
			this._chClear_2.TabIndex = 35;
			this._chClear_2.TabStop = true;
			this._chClear_2.Text = "";
			this._chClear_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chClear_2.Visible = true;
			// 
			// _chPlay_2
			// 
			this._chPlay_2.AllowDrop = true;
			this._chPlay_2.Appearance = System.Windows.Forms.Appearance.Normal;
			this._chPlay_2.BackColor = System.Drawing.SystemColors.Control;
			this._chPlay_2.CausesValidation = true;
			this._chPlay_2.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chPlay_2.CheckState = System.Windows.Forms.CheckState.Unchecked;
			this._chPlay_2.Enabled = true;
			this._chPlay_2.ForeColor = System.Drawing.SystemColors.ControlText;
			this._chPlay_2.Location = new System.Drawing.Point(156, 88);
			this._chPlay_2.Name = "_chPlay_2";
			this._chPlay_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._chPlay_2.Size = new System.Drawing.Size(13, 17);
			this._chPlay_2.TabIndex = 34;
			this._chPlay_2.TabStop = true;
			this._chPlay_2.Text = "";
			this._chPlay_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chPlay_2.Visible = true;
			// 
			// _txtPhrase_1
			// 
			this._txtPhrase_1.AcceptsReturn = true;
			this._txtPhrase_1.AllowDrop = true;
			this._txtPhrase_1.BackColor = System.Drawing.SystemColors.Window;
			this._txtPhrase_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._txtPhrase_1.Cursor = System.Windows.Forms.Cursors.IBeam;
			this._txtPhrase_1.ForeColor = System.Drawing.SystemColors.WindowText;
			this._txtPhrase_1.Location = new System.Drawing.Point(192, 68);
			this._txtPhrase_1.MaxLength = 0;
			this._txtPhrase_1.Name = "_txtPhrase_1";
			this._txtPhrase_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._txtPhrase_1.Size = new System.Drawing.Size(45, 19);
			this._txtPhrase_1.TabIndex = 33;
			this._txtPhrase_1.Text = "0";
			this._txtPhrase_1.Leave += new System.EventHandler(this.txtPhrase_Leave);
			// 
			// _chRestart_1
			// 
			this._chRestart_1.AllowDrop = true;
			this._chRestart_1.Appearance = System.Windows.Forms.Appearance.Normal;
			this._chRestart_1.BackColor = System.Drawing.SystemColors.Control;
			this._chRestart_1.CausesValidation = true;
			this._chRestart_1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chRestart_1.CheckState = System.Windows.Forms.CheckState.Unchecked;
			this._chRestart_1.Enabled = true;
			this._chRestart_1.ForeColor = System.Drawing.SystemColors.ControlText;
			this._chRestart_1.Location = new System.Drawing.Point(356, 68);
			this._chRestart_1.Name = "_chRestart_1";
			this._chRestart_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._chRestart_1.Size = new System.Drawing.Size(13, 17);
			this._chRestart_1.TabIndex = 32;
			this._chRestart_1.TabStop = true;
			this._chRestart_1.Text = "";
			this._chRestart_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chRestart_1.Visible = true;
			// 
			// _chInt_1
			// 
			this._chInt_1.AllowDrop = true;
			this._chInt_1.Appearance = System.Windows.Forms.Appearance.Normal;
			this._chInt_1.BackColor = System.Drawing.SystemColors.Control;
			this._chInt_1.CausesValidation = true;
			this._chInt_1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chInt_1.CheckState = System.Windows.Forms.CheckState.Unchecked;
			this._chInt_1.Enabled = true;
			this._chInt_1.ForeColor = System.Drawing.SystemColors.ControlText;
			this._chInt_1.Location = new System.Drawing.Point(312, 68);
			this._chInt_1.Name = "_chInt_1";
			this._chInt_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._chInt_1.Size = new System.Drawing.Size(13, 17);
			this._chInt_1.TabIndex = 31;
			this._chInt_1.TabStop = true;
			this._chInt_1.Text = "";
			this._chInt_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chInt_1.Visible = true;
			// 
			// _chClear_1
			// 
			this._chClear_1.AllowDrop = true;
			this._chClear_1.Appearance = System.Windows.Forms.Appearance.Normal;
			this._chClear_1.BackColor = System.Drawing.SystemColors.Control;
			this._chClear_1.CausesValidation = true;
			this._chClear_1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chClear_1.CheckState = System.Windows.Forms.CheckState.Unchecked;
			this._chClear_1.Enabled = true;
			this._chClear_1.ForeColor = System.Drawing.SystemColors.ControlText;
			this._chClear_1.Location = new System.Drawing.Point(264, 68);
			this._chClear_1.Name = "_chClear_1";
			this._chClear_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._chClear_1.Size = new System.Drawing.Size(13, 17);
			this._chClear_1.TabIndex = 30;
			this._chClear_1.TabStop = true;
			this._chClear_1.Text = "";
			this._chClear_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chClear_1.Visible = true;
			// 
			// _chPlay_1
			// 
			this._chPlay_1.AllowDrop = true;
			this._chPlay_1.Appearance = System.Windows.Forms.Appearance.Normal;
			this._chPlay_1.BackColor = System.Drawing.SystemColors.Control;
			this._chPlay_1.CausesValidation = true;
			this._chPlay_1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chPlay_1.CheckState = System.Windows.Forms.CheckState.Unchecked;
			this._chPlay_1.Enabled = true;
			this._chPlay_1.ForeColor = System.Drawing.SystemColors.ControlText;
			this._chPlay_1.Location = new System.Drawing.Point(156, 68);
			this._chPlay_1.Name = "_chPlay_1";
			this._chPlay_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._chPlay_1.Size = new System.Drawing.Size(13, 17);
			this._chPlay_1.TabIndex = 29;
			this._chPlay_1.TabStop = true;
			this._chPlay_1.Text = "";
			this._chPlay_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chPlay_1.Visible = true;
			// 
			// _txtPhrase_0
			// 
			this._txtPhrase_0.AcceptsReturn = true;
			this._txtPhrase_0.AllowDrop = true;
			this._txtPhrase_0.BackColor = System.Drawing.SystemColors.Window;
			this._txtPhrase_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._txtPhrase_0.Cursor = System.Windows.Forms.Cursors.IBeam;
			this._txtPhrase_0.ForeColor = System.Drawing.SystemColors.WindowText;
			this._txtPhrase_0.Location = new System.Drawing.Point(192, 48);
			this._txtPhrase_0.MaxLength = 0;
			this._txtPhrase_0.Name = "_txtPhrase_0";
			this._txtPhrase_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._txtPhrase_0.Size = new System.Drawing.Size(45, 19);
			this._txtPhrase_0.TabIndex = 6;
			this._txtPhrase_0.Text = "0";
			this._txtPhrase_0.Leave += new System.EventHandler(this.txtPhrase_Leave);
			// 
			// _chRestart_0
			// 
			this._chRestart_0.AllowDrop = true;
			this._chRestart_0.Appearance = System.Windows.Forms.Appearance.Normal;
			this._chRestart_0.BackColor = System.Drawing.SystemColors.Control;
			this._chRestart_0.CausesValidation = true;
			this._chRestart_0.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chRestart_0.CheckState = System.Windows.Forms.CheckState.Unchecked;
			this._chRestart_0.Enabled = true;
			this._chRestart_0.ForeColor = System.Drawing.SystemColors.ControlText;
			this._chRestart_0.Location = new System.Drawing.Point(356, 48);
			this._chRestart_0.Name = "_chRestart_0";
			this._chRestart_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._chRestart_0.Size = new System.Drawing.Size(13, 17);
			this._chRestart_0.TabIndex = 5;
			this._chRestart_0.TabStop = true;
			this._chRestart_0.Text = "";
			this._chRestart_0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chRestart_0.Visible = true;
			// 
			// _chInt_0
			// 
			this._chInt_0.AllowDrop = true;
			this._chInt_0.Appearance = System.Windows.Forms.Appearance.Normal;
			this._chInt_0.BackColor = System.Drawing.SystemColors.Control;
			this._chInt_0.CausesValidation = true;
			this._chInt_0.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chInt_0.CheckState = System.Windows.Forms.CheckState.Unchecked;
			this._chInt_0.Enabled = true;
			this._chInt_0.ForeColor = System.Drawing.SystemColors.ControlText;
			this._chInt_0.Location = new System.Drawing.Point(312, 48);
			this._chInt_0.Name = "_chInt_0";
			this._chInt_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._chInt_0.Size = new System.Drawing.Size(13, 17);
			this._chInt_0.TabIndex = 4;
			this._chInt_0.TabStop = true;
			this._chInt_0.Text = "";
			this._chInt_0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chInt_0.Visible = true;
			// 
			// _chClear_0
			// 
			this._chClear_0.AllowDrop = true;
			this._chClear_0.Appearance = System.Windows.Forms.Appearance.Normal;
			this._chClear_0.BackColor = System.Drawing.SystemColors.Control;
			this._chClear_0.CausesValidation = true;
			this._chClear_0.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chClear_0.CheckState = System.Windows.Forms.CheckState.Unchecked;
			this._chClear_0.Enabled = true;
			this._chClear_0.ForeColor = System.Drawing.SystemColors.ControlText;
			this._chClear_0.Location = new System.Drawing.Point(264, 48);
			this._chClear_0.Name = "_chClear_0";
			this._chClear_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._chClear_0.Size = new System.Drawing.Size(13, 17);
			this._chClear_0.TabIndex = 3;
			this._chClear_0.TabStop = true;
			this._chClear_0.Text = "";
			this._chClear_0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chClear_0.Visible = true;
			// 
			// _chPlay_0
			// 
			this._chPlay_0.AllowDrop = true;
			this._chPlay_0.Appearance = System.Windows.Forms.Appearance.Normal;
			this._chPlay_0.BackColor = System.Drawing.SystemColors.Control;
			this._chPlay_0.CausesValidation = true;
			this._chPlay_0.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chPlay_0.CheckState = System.Windows.Forms.CheckState.Unchecked;
			this._chPlay_0.Enabled = true;
			this._chPlay_0.ForeColor = System.Drawing.SystemColors.ControlText;
			this._chPlay_0.Location = new System.Drawing.Point(156, 48);
			this._chPlay_0.Name = "_chPlay_0";
			this._chPlay_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._chPlay_0.Size = new System.Drawing.Size(13, 17);
			this._chPlay_0.TabIndex = 2;
			this._chPlay_0.TabStop = true;
			this._chPlay_0.Text = "";
			this._chPlay_0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._chPlay_0.Visible = true;
			// 
			// Line2
			// 
			this.Line2.AllowDrop = true;
			this.Line2.BackColor = System.Drawing.SystemColors.WindowText;
			this.Line2.Enabled = false;
			this.Line2.Location = new System.Drawing.Point(2100, 240);
			this.Line2.Name = "Line2";
			this.Line2.Size = new System.Drawing.Size(1, 5640);
			this.Line2.Visible = true;
			// 
			// Line1
			// 
			this.Line1.AllowDrop = true;
			this.Line1.BackColor = System.Drawing.SystemColors.WindowText;
			this.Line1.Enabled = false;
			this.Line1.Location = new System.Drawing.Point(60, 660);
			this.Line1.Name = "Line1";
			this.Line1.Size = new System.Drawing.Size(5775, 1);
			this.Line1.Visible = true;
			// 
			// _Label1_16
			// 
			this._Label1_16.AllowDrop = true;
			this._Label1_16.BackColor = System.Drawing.SystemColors.Control;
			this._Label1_16.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._Label1_16.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Label1_16.Location = new System.Drawing.Point(4, 370);
			this._Label1_16.Name = "_Label1_16";
			this._Label1_16.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Label1_16.Size = new System.Drawing.Size(129, 17);
			this._Label1_16.TabIndex = 28;
			this._Label1_16.Text = "Power up && Reset";
			this._Label1_16.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _Label1_15
			// 
			this._Label1_15.AllowDrop = true;
			this._Label1_15.BackColor = System.Drawing.SystemColors.Control;
			this._Label1_15.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._Label1_15.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Label1_15.Location = new System.Drawing.Point(4, 350);
			this._Label1_15.Name = "_Label1_15";
			this._Label1_15.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Label1_15.Size = new System.Drawing.Size(129, 17);
			this._Label1_15.TabIndex = 27;
			this._Label1_15.Text = "Input #7 - Goes Low";
			this._Label1_15.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _Label1_14
			// 
			this._Label1_14.AllowDrop = true;
			this._Label1_14.BackColor = System.Drawing.SystemColors.Control;
			this._Label1_14.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._Label1_14.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Label1_14.Location = new System.Drawing.Point(4, 330);
			this._Label1_14.Name = "_Label1_14";
			this._Label1_14.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Label1_14.Size = new System.Drawing.Size(129, 17);
			this._Label1_14.TabIndex = 26;
			this._Label1_14.Text = "Input #7 - Goes High";
			this._Label1_14.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _Label1_13
			// 
			this._Label1_13.AllowDrop = true;
			this._Label1_13.BackColor = System.Drawing.SystemColors.Control;
			this._Label1_13.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._Label1_13.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Label1_13.Location = new System.Drawing.Point(4, 310);
			this._Label1_13.Name = "_Label1_13";
			this._Label1_13.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Label1_13.Size = new System.Drawing.Size(129, 17);
			this._Label1_13.TabIndex = 25;
			this._Label1_13.Text = "Input #6 - Goes Low";
			this._Label1_13.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _Label1_12
			// 
			this._Label1_12.AllowDrop = true;
			this._Label1_12.BackColor = System.Drawing.SystemColors.Control;
			this._Label1_12.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._Label1_12.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Label1_12.Location = new System.Drawing.Point(4, 290);
			this._Label1_12.Name = "_Label1_12";
			this._Label1_12.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Label1_12.Size = new System.Drawing.Size(129, 17);
			this._Label1_12.TabIndex = 24;
			this._Label1_12.Text = "Input #6 - Goes High";
			this._Label1_12.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _Label1_11
			// 
			this._Label1_11.AllowDrop = true;
			this._Label1_11.BackColor = System.Drawing.SystemColors.Control;
			this._Label1_11.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._Label1_11.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Label1_11.Location = new System.Drawing.Point(4, 270);
			this._Label1_11.Name = "_Label1_11";
			this._Label1_11.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Label1_11.Size = new System.Drawing.Size(129, 17);
			this._Label1_11.TabIndex = 23;
			this._Label1_11.Text = "Input #5 - Goes Low";
			this._Label1_11.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _Label1_10
			// 
			this._Label1_10.AllowDrop = true;
			this._Label1_10.BackColor = System.Drawing.SystemColors.Control;
			this._Label1_10.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._Label1_10.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Label1_10.Location = new System.Drawing.Point(4, 250);
			this._Label1_10.Name = "_Label1_10";
			this._Label1_10.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Label1_10.Size = new System.Drawing.Size(129, 17);
			this._Label1_10.TabIndex = 22;
			this._Label1_10.Text = "Input #5 - Goes High";
			this._Label1_10.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _Label1_9
			// 
			this._Label1_9.AllowDrop = true;
			this._Label1_9.BackColor = System.Drawing.SystemColors.Control;
			this._Label1_9.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._Label1_9.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Label1_9.Location = new System.Drawing.Point(4, 230);
			this._Label1_9.Name = "_Label1_9";
			this._Label1_9.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Label1_9.Size = new System.Drawing.Size(129, 17);
			this._Label1_9.TabIndex = 21;
			this._Label1_9.Text = "Input #4 - Goes Low";
			this._Label1_9.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _Label1_8
			// 
			this._Label1_8.AllowDrop = true;
			this._Label1_8.BackColor = System.Drawing.SystemColors.Control;
			this._Label1_8.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._Label1_8.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Label1_8.Location = new System.Drawing.Point(4, 210);
			this._Label1_8.Name = "_Label1_8";
			this._Label1_8.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Label1_8.Size = new System.Drawing.Size(129, 17);
			this._Label1_8.TabIndex = 20;
			this._Label1_8.Text = "Input #4 - Goes High";
			this._Label1_8.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _Label1_7
			// 
			this._Label1_7.AllowDrop = true;
			this._Label1_7.BackColor = System.Drawing.SystemColors.Control;
			this._Label1_7.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._Label1_7.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Label1_7.Location = new System.Drawing.Point(4, 190);
			this._Label1_7.Name = "_Label1_7";
			this._Label1_7.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Label1_7.Size = new System.Drawing.Size(129, 17);
			this._Label1_7.TabIndex = 19;
			this._Label1_7.Text = "Input #3 - Goes Low";
			this._Label1_7.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _Label1_6
			// 
			this._Label1_6.AllowDrop = true;
			this._Label1_6.BackColor = System.Drawing.SystemColors.Control;
			this._Label1_6.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._Label1_6.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Label1_6.Location = new System.Drawing.Point(4, 170);
			this._Label1_6.Name = "_Label1_6";
			this._Label1_6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Label1_6.Size = new System.Drawing.Size(129, 17);
			this._Label1_6.TabIndex = 18;
			this._Label1_6.Text = "Input #3 - Goes High";
			this._Label1_6.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _Label1_5
			// 
			this._Label1_5.AllowDrop = true;
			this._Label1_5.BackColor = System.Drawing.SystemColors.Control;
			this._Label1_5.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._Label1_5.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Label1_5.Location = new System.Drawing.Point(4, 150);
			this._Label1_5.Name = "_Label1_5";
			this._Label1_5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Label1_5.Size = new System.Drawing.Size(129, 17);
			this._Label1_5.TabIndex = 17;
			this._Label1_5.Text = "Input #2 - Goes Low";
			this._Label1_5.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _Label1_4
			// 
			this._Label1_4.AllowDrop = true;
			this._Label1_4.BackColor = System.Drawing.SystemColors.Control;
			this._Label1_4.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._Label1_4.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Label1_4.Location = new System.Drawing.Point(4, 130);
			this._Label1_4.Name = "_Label1_4";
			this._Label1_4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Label1_4.Size = new System.Drawing.Size(129, 17);
			this._Label1_4.TabIndex = 16;
			this._Label1_4.Text = "Input #2 - Goes High";
			this._Label1_4.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _Label1_3
			// 
			this._Label1_3.AllowDrop = true;
			this._Label1_3.BackColor = System.Drawing.SystemColors.Control;
			this._Label1_3.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._Label1_3.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Label1_3.Location = new System.Drawing.Point(4, 110);
			this._Label1_3.Name = "_Label1_3";
			this._Label1_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Label1_3.Size = new System.Drawing.Size(129, 17);
			this._Label1_3.TabIndex = 15;
			this._Label1_3.Text = "Input #1 - Goes Low";
			this._Label1_3.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _Label1_2
			// 
			this._Label1_2.AllowDrop = true;
			this._Label1_2.BackColor = System.Drawing.SystemColors.Control;
			this._Label1_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._Label1_2.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Label1_2.Location = new System.Drawing.Point(4, 90);
			this._Label1_2.Name = "_Label1_2";
			this._Label1_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Label1_2.Size = new System.Drawing.Size(129, 17);
			this._Label1_2.TabIndex = 14;
			this._Label1_2.Text = "Input #1 - Goes High";
			this._Label1_2.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _Label1_1
			// 
			this._Label1_1.AllowDrop = true;
			this._Label1_1.BackColor = System.Drawing.SystemColors.Control;
			this._Label1_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._Label1_1.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Label1_1.Location = new System.Drawing.Point(4, 70);
			this._Label1_1.Name = "_Label1_1";
			this._Label1_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Label1_1.Size = new System.Drawing.Size(129, 17);
			this._Label1_1.TabIndex = 13;
			this._Label1_1.Text = "Input #0 - Goes Low";
			this._Label1_1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// Label7
			// 
			this.Label7.AllowDrop = true;
			this.Label7.BackColor = System.Drawing.SystemColors.Control;
			this.Label7.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label7.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label7.Location = new System.Drawing.Point(340, 16);
			this.Label7.Name = "Label7";
			this.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label7.Size = new System.Drawing.Size(49, 25);
			this.Label7.TabIndex = 12;
			this.Label7.Text = "Restart From Wait";
			this.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// Label6
			// 
			this.Label6.AllowDrop = true;
			this.Label6.BackColor = System.Drawing.SystemColors.Control;
			this.Label6.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label6.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label6.Location = new System.Drawing.Point(300, 16);
			this.Label6.Name = "Label6";
			this.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label6.Size = new System.Drawing.Size(33, 29);
			this.Label6.TabIndex = 11;
			this.Label6.Text = "Call Phrase";
			this.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// Label5
			// 
			this.Label5.AllowDrop = true;
			this.Label5.BackColor = System.Drawing.SystemColors.Control;
			this.Label5.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label5.Location = new System.Drawing.Point(252, 16);
			this.Label5.Name = "Label5";
			this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label5.Size = new System.Drawing.Size(33, 29);
			this.Label5.TabIndex = 10;
			this.Label5.Text = "Clear Buffer";
			this.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// Label4
			// 
			this.Label4.AllowDrop = true;
			this.Label4.BackColor = System.Drawing.SystemColors.Control;
			this.Label4.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label4.Location = new System.Drawing.Point(196, 16);
			this.Label4.Name = "Label4";
			this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label4.Size = new System.Drawing.Size(41, 29);
			this.Label4.TabIndex = 9;
			this.Label4.Text = "Phrase# To Play";
			this.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// Label3
			// 
			this.Label3.AllowDrop = true;
			this.Label3.BackColor = System.Drawing.SystemColors.Control;
			this.Label3.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label3.Location = new System.Drawing.Point(144, 16);
			this.Label3.Name = "Label3";
			this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label3.Size = new System.Drawing.Size(37, 29);
			this.Label3.TabIndex = 8;
			this.Label3.Text = "Play Phrase";
			this.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// Label2
			// 
			this.Label2.AllowDrop = true;
			this.Label2.BackColor = System.Drawing.SystemColors.Control;
			this.Label2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label2.Location = new System.Drawing.Point(16, 28);
			this.Label2.Name = "Label2";
			this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label2.Size = new System.Drawing.Size(117, 13);
			this.Label2.TabIndex = 7;
			this.Label2.Text = "Event";
			this.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _Label1_0
			// 
			this._Label1_0.AllowDrop = true;
			this._Label1_0.BackColor = System.Drawing.SystemColors.Control;
			this._Label1_0.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._Label1_0.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Label1_0.Location = new System.Drawing.Point(4, 50);
			this._Label1_0.Name = "_Label1_0";
			this._Label1_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Label1_0.Size = new System.Drawing.Size(129, 17);
			this._Label1_0.TabIndex = 1;
			this._Label1_0.Text = "Input #0 - Goes High";
			this._Label1_0.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// frmButtons
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(589, 452);
			this.Controls.Add(this.btnShutUp);
			this.Controls.Add(this.Frame13);
			this.Controls.Add(this.Frame12);
			this.Controls.Add(this.Frame8);
			this.Controls.Add(this.btnWrite);
			this.Controls.Add(this.btnDone);
			this.Controls.Add(this.Frame2);
			this.Controls.Add(this.Frame1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Location = new System.Drawing.Point(3, 23);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmButtons";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SpeakJet Event Configuration";
			this.ToolTipMain.SetToolTip(this.btnShutUp, "Stop the SpeakJet now.");
			this.Closed += new System.EventHandler(this.Form_Closed);
			this.Frame13.ResumeLayout(false);
			this.Frame12.ResumeLayout(false);
			this.Frame5.ResumeLayout(false);
			this.Frame6.ResumeLayout(false);
			this.Frame7.ResumeLayout(false);
			this.Frame8.ResumeLayout(false);
			this.Frame9.ResumeLayout(false);
			this.Frame10.ResumeLayout(false);
			this.Frame11.ResumeLayout(false);
			this.Frame2.ResumeLayout(false);
			this.Frame3.ResumeLayout(false);
			this.Frame4.ResumeLayout(false);
			this.Frame1.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		void ReLoadForm(bool addEvents)
		{
			InitializetxtPhrase();
			InitializeoptIO();
			InitializechRestart();
			InitializechPlay();
			InitializechInt();
			InitializechClear();
			InitializeLabel1();
		}
		void InitializetxtPhrase()
		{
			this.txtPhrase = new System.Windows.Forms.TextBox[17];
			this.txtPhrase[16] = _txtPhrase_16;
			this.txtPhrase[15] = _txtPhrase_15;
			this.txtPhrase[14] = _txtPhrase_14;
			this.txtPhrase[13] = _txtPhrase_13;
			this.txtPhrase[12] = _txtPhrase_12;
			this.txtPhrase[11] = _txtPhrase_11;
			this.txtPhrase[10] = _txtPhrase_10;
			this.txtPhrase[9] = _txtPhrase_9;
			this.txtPhrase[8] = _txtPhrase_8;
			this.txtPhrase[7] = _txtPhrase_7;
			this.txtPhrase[6] = _txtPhrase_6;
			this.txtPhrase[5] = _txtPhrase_5;
			this.txtPhrase[4] = _txtPhrase_4;
			this.txtPhrase[3] = _txtPhrase_3;
			this.txtPhrase[2] = _txtPhrase_2;
			this.txtPhrase[1] = _txtPhrase_1;
			this.txtPhrase[0] = _txtPhrase_0;
		}
		void InitializeoptIO()
		{
			this.optIO = new System.Windows.Forms.RadioButton[16];
			this.optIO[4] = _optIO_4;
			this.optIO[5] = _optIO_5;
			this.optIO[7] = _optIO_7;
			this.optIO[6] = _optIO_6;
			this.optIO[9] = _optIO_9;
			this.optIO[8] = _optIO_8;
			this.optIO[10] = _optIO_10;
			this.optIO[11] = _optIO_11;
			this.optIO[13] = _optIO_13;
			this.optIO[12] = _optIO_12;
			this.optIO[15] = _optIO_15;
			this.optIO[14] = _optIO_14;
			this.optIO[1] = _optIO_1;
			this.optIO[0] = _optIO_0;
			this.optIO[2] = _optIO_2;
			this.optIO[3] = _optIO_3;
		}
		void InitializechRestart()
		{
			this.chRestart = new System.Windows.Forms.CheckBox[16];
			this.chRestart[15] = _chRestart_15;
			this.chRestart[14] = _chRestart_14;
			this.chRestart[13] = _chRestart_13;
			this.chRestart[12] = _chRestart_12;
			this.chRestart[11] = _chRestart_11;
			this.chRestart[10] = _chRestart_10;
			this.chRestart[9] = _chRestart_9;
			this.chRestart[8] = _chRestart_8;
			this.chRestart[7] = _chRestart_7;
			this.chRestart[6] = _chRestart_6;
			this.chRestart[5] = _chRestart_5;
			this.chRestart[4] = _chRestart_4;
			this.chRestart[3] = _chRestart_3;
			this.chRestart[2] = _chRestart_2;
			this.chRestart[1] = _chRestart_1;
			this.chRestart[0] = _chRestart_0;
		}
		void InitializechPlay()
		{
			this.chPlay = new System.Windows.Forms.CheckBox[17];
			this.chPlay[16] = _chPlay_16;
			this.chPlay[15] = _chPlay_15;
			this.chPlay[14] = _chPlay_14;
			this.chPlay[13] = _chPlay_13;
			this.chPlay[12] = _chPlay_12;
			this.chPlay[11] = _chPlay_11;
			this.chPlay[10] = _chPlay_10;
			this.chPlay[9] = _chPlay_9;
			this.chPlay[8] = _chPlay_8;
			this.chPlay[7] = _chPlay_7;
			this.chPlay[6] = _chPlay_6;
			this.chPlay[5] = _chPlay_5;
			this.chPlay[4] = _chPlay_4;
			this.chPlay[3] = _chPlay_3;
			this.chPlay[2] = _chPlay_2;
			this.chPlay[1] = _chPlay_1;
			this.chPlay[0] = _chPlay_0;
		}
		void InitializechInt()
		{
			this.chInt = new System.Windows.Forms.CheckBox[16];
			this.chInt[15] = _chInt_15;
			this.chInt[14] = _chInt_14;
			this.chInt[13] = _chInt_13;
			this.chInt[12] = _chInt_12;
			this.chInt[11] = _chInt_11;
			this.chInt[10] = _chInt_10;
			this.chInt[9] = _chInt_9;
			this.chInt[8] = _chInt_8;
			this.chInt[7] = _chInt_7;
			this.chInt[6] = _chInt_6;
			this.chInt[5] = _chInt_5;
			this.chInt[4] = _chInt_4;
			this.chInt[3] = _chInt_3;
			this.chInt[2] = _chInt_2;
			this.chInt[1] = _chInt_1;
			this.chInt[0] = _chInt_0;
		}
		void InitializechClear()
		{
			this.chClear = new System.Windows.Forms.CheckBox[16];
			this.chClear[15] = _chClear_15;
			this.chClear[14] = _chClear_14;
			this.chClear[13] = _chClear_13;
			this.chClear[12] = _chClear_12;
			this.chClear[11] = _chClear_11;
			this.chClear[10] = _chClear_10;
			this.chClear[9] = _chClear_9;
			this.chClear[8] = _chClear_8;
			this.chClear[7] = _chClear_7;
			this.chClear[6] = _chClear_6;
			this.chClear[5] = _chClear_5;
			this.chClear[4] = _chClear_4;
			this.chClear[3] = _chClear_3;
			this.chClear[2] = _chClear_2;
			this.chClear[1] = _chClear_1;
			this.chClear[0] = _chClear_0;
		}
		void InitializeLabel1()
		{
			this.Label1 = new System.Windows.Forms.Label[17];
			this.Label1[16] = _Label1_16;
			this.Label1[15] = _Label1_15;
			this.Label1[14] = _Label1_14;
			this.Label1[13] = _Label1_13;
			this.Label1[12] = _Label1_12;
			this.Label1[11] = _Label1_11;
			this.Label1[10] = _Label1_10;
			this.Label1[9] = _Label1_9;
			this.Label1[8] = _Label1_8;
			this.Label1[7] = _Label1_7;
			this.Label1[6] = _Label1_6;
			this.Label1[5] = _Label1_5;
			this.Label1[4] = _Label1_4;
			this.Label1[3] = _Label1_3;
			this.Label1[2] = _Label1_2;
			this.Label1[1] = _Label1_1;
			this.Label1[0] = _Label1_0;
		}
		#endregion
	}
}