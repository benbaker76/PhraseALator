
namespace PhraseALator
{
	partial class frmPhrase
	{

		#region "Upgrade Support "
		private static frmPhrase m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static frmPhrase DefInstance
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
		public static frmPhrase CreateInstance()
		{
			frmPhrase theInstance = new frmPhrase();
			theInstance.Form_Load();
			return theInstance;
		}
		private string[] visualControls = new string[]{"components", "ToolTipMain", "txtCall", "txtPlay", "txtPCtrl", "txtPOut", "_Command1_156", "_Command1_127", "_Command1_137", "_Command1_138", "Frame16", "btnShutUp", "btnDone", "txtfindwith", "chkWithout", "chkWith", "btnNextWord", "cmdLoadOver", "cmdSave", "txtDict", "cmdLoadInsert", "Frame15", "TxtDelay", "_Command1_158", "_Command1_129", "_Command1_131", "_Command1_134", "_Command1_132", "_Command1_130", "_Command1_133", "_Command1_128", "_Command1_139", "Frame14", "Label9", "Label8", "Label7", "_Command1_197", "_Command1_192", "_Command1_187", "_Command1_182", "_Command1_177", "_Command1_175", "_Command1_172", "_Command1_170", "_Command1_165", "_Command1_160", "_Command1_152", "_Command1_147", "_Command1_196", "_Command1_195", "_Command1_194", "_Command1_191", "_Command1_190", "_Command1_189", "_Command1_186", "_Command1_185", "_Command1_184", "_Command1_181", "_Command1_180", "_Command1_179", "_Command1_176", "_Command1_174", "_Command1_171", "_Command1_169", "_Command1_166", "_Command1_164", "_Command1_161", "_Command1_159", "_Command1_153", "_Command1_151", "_Command1_148", "_Command1_146", "Frame13", "_Command1_24", "_Command1_23", "_Command1_22", "_Command1_21", "_Command1_20", "_Command1_19", "Frame12", "txtRepeat", "_Command1_141", "_Command1_154", "_Command1_142", "_Command1_143", "_Command1_136", "_Command1_135", "Frame11", "btnSaySelection", "bntSayIt", "btnClear", "txtSayData", "Command2", "btnCodes", "Frame10", "txtBend", "txtPitch", "txtSpeed", "txtVolume", "scVolume", "scSpeed", "scPitch", "scBend", "chkApplyControlsBeforeSounds", "chkApplyControlsBeforeSayData", "_Command1_140", "lblVolume", "lblSpeed", "lblPitch", "lblBend", "Frame9", "_Command1_126", "_Command1_123", "_Command1_122", "_Command1_91", "_Command1_101", "_Command1_81", "_Command1_111", "_Command1_121", "_Command1_90", "_Command1_100", "_Command1_80", "_Command1_110", "_Command1_120", "_Command1_89", "_Command1_99", "_Command1_79", "_Command1_109", "_Command1_119", "_Command1_88", "_Command1_98", "_Command1_78", "_Command1_108", "_Command1_118", "_Command1_87", "_Command1_97", "_Command1_77", "_Command1_107", "_Command1_117", "_Command1_86", "_Command1_96", "_Command1_76", "_Command1_106", "_Command1_116", "_Command1_85", "_Command1_95", "_Command1_75", "_Command1_105", "_Command1_115", "_Command1_84", "_Command1_94", "_Command1_74", "_Command1_104", "_Command1_114", "_Command1_83", "_Command1_93", "_Command1_73", "_Command1_103", "_Command1_113", "_Command1_82", "_Command1_92", "_Command1_72", "_Command1_102", "_Command1_112", "Label3", "Label4", "Label5", "Label2", "Label6", "_Command1_124", "_Command1_125", "Frame8", "_Command1_54", "_Command1_55", "_Command1_56", "_Command1_57", "_Command1_58", "_Command1_59", "_Command1_60", "_Command1_61", "_Command1_62", "Frame7", "_Command1_37", "_Command1_38", "_Command1_39", "_Command1_40", "_Command1_41", "Frame2", "_Command1_63", "_Command1_64", "_Command1_65", "_Command1_66", "_Command1_67", "_Command1_68", "_Command1_69", "_Command1_70", "_Command1_71", "Frame6", "_Command1_42", "_Command1_43", "_Command1_44", "_Command1_45", "_Command1_46", "_Command1_47", "_Command1_48", "_Command1_49", "_Command1_50", "_Command1_51", "_Command1_52", "_Command1_53", "Frame5", "_Command1_25", "_Command1_26", "_Command1_27", "_Command1_30", "_Command1_28", "_Command1_31", "_Command1_34", "_Command1_33", "_Command1_35", "_Command1_36", "_Command1_29", "Frame4", "_Command1_11", "_Command1_12", "_Command1_13", "_Command1_14", "_Command1_15", "_Command1_16", "_Command1_17", "_Command1_18", "Frame3", "_Command1_4", "_Command1_3", "_Command1_2", "_Command1_1", "_Command1_32", "_Command1_0", "_Command1_5", "_Command1_6", "_Command1_7", "_Command1_8", "_Command1_9", "_Command1_10", "Frame1", "Command1"};
		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ToolTip ToolTipMain;
		public System.Windows.Forms.TextBox txtCall;
		public System.Windows.Forms.TextBox txtPlay;
		public System.Windows.Forms.TextBox txtPCtrl;
		public System.Windows.Forms.TextBox txtPOut;
		private System.Windows.Forms.Label _Command1_156;
		private System.Windows.Forms.Label _Command1_127;
		private System.Windows.Forms.Label _Command1_137;
		private System.Windows.Forms.Label _Command1_138;
		public System.Windows.Forms.GroupBox Frame16;
		public System.Windows.Forms.Button btnShutUp;
		public System.Windows.Forms.Button btnDone;
		public System.Windows.Forms.TextBox txtfindwith;
		public System.Windows.Forms.CheckBox chkWithout;
		public System.Windows.Forms.CheckBox chkWith;
		public System.Windows.Forms.Button btnNextWord;
		public System.Windows.Forms.Button cmdLoadOver;
		public System.Windows.Forms.Button cmdSave;
		public System.Windows.Forms.TextBox txtDict;
		public System.Windows.Forms.Button cmdLoadInsert;
		public System.Windows.Forms.GroupBox Frame15;
		public System.Windows.Forms.TextBox TxtDelay;
		private System.Windows.Forms.Label _Command1_158;
		private System.Windows.Forms.Label _Command1_129;
		private System.Windows.Forms.Label _Command1_131;
		private System.Windows.Forms.Label _Command1_134;
		private System.Windows.Forms.Label _Command1_132;
		private System.Windows.Forms.Label _Command1_130;
		private System.Windows.Forms.Label _Command1_133;
		private System.Windows.Forms.Label _Command1_128;
		private System.Windows.Forms.Label _Command1_139;
		public System.Windows.Forms.GroupBox Frame14;
		public System.Windows.Forms.Label Label9;
		public System.Windows.Forms.Label Label8;
		public System.Windows.Forms.Label Label7;
		private System.Windows.Forms.Label _Command1_197;
		private System.Windows.Forms.Label _Command1_192;
		private System.Windows.Forms.Label _Command1_187;
		private System.Windows.Forms.Label _Command1_182;
		private System.Windows.Forms.Label _Command1_177;
		private System.Windows.Forms.Label _Command1_175;
		private System.Windows.Forms.Label _Command1_172;
		private System.Windows.Forms.Label _Command1_170;
		private System.Windows.Forms.Label _Command1_165;
		private System.Windows.Forms.Label _Command1_160;
		private System.Windows.Forms.Label _Command1_152;
		private System.Windows.Forms.Label _Command1_147;
		private System.Windows.Forms.Label _Command1_196;
		private System.Windows.Forms.Label _Command1_195;
		private System.Windows.Forms.Label _Command1_194;
		private System.Windows.Forms.Label _Command1_191;
		private System.Windows.Forms.Label _Command1_190;
		private System.Windows.Forms.Label _Command1_189;
		private System.Windows.Forms.Label _Command1_186;
		private System.Windows.Forms.Label _Command1_185;
		private System.Windows.Forms.Label _Command1_184;
		private System.Windows.Forms.Label _Command1_181;
		private System.Windows.Forms.Label _Command1_180;
		private System.Windows.Forms.Label _Command1_179;
		private System.Windows.Forms.Label _Command1_176;
		private System.Windows.Forms.Label _Command1_174;
		private System.Windows.Forms.Label _Command1_171;
		private System.Windows.Forms.Label _Command1_169;
		private System.Windows.Forms.Label _Command1_166;
		private System.Windows.Forms.Label _Command1_164;
		private System.Windows.Forms.Label _Command1_161;
		private System.Windows.Forms.Label _Command1_159;
		private System.Windows.Forms.Label _Command1_153;
		private System.Windows.Forms.Label _Command1_151;
		private System.Windows.Forms.Label _Command1_148;
		private System.Windows.Forms.Label _Command1_146;
		public System.Windows.Forms.GroupBox Frame13;
		private System.Windows.Forms.Label _Command1_24;
		private System.Windows.Forms.Label _Command1_23;
		private System.Windows.Forms.Label _Command1_22;
		private System.Windows.Forms.Label _Command1_21;
		private System.Windows.Forms.Label _Command1_20;
		private System.Windows.Forms.Label _Command1_19;
		public System.Windows.Forms.GroupBox Frame12;
		public System.Windows.Forms.TextBox txtRepeat;
		private System.Windows.Forms.Label _Command1_141;
		private System.Windows.Forms.Label _Command1_154;
		private System.Windows.Forms.Label _Command1_142;
		private System.Windows.Forms.Label _Command1_143;
		private System.Windows.Forms.Label _Command1_136;
		private System.Windows.Forms.Label _Command1_135;
		public System.Windows.Forms.GroupBox Frame11;
		public System.Windows.Forms.Button btnSaySelection;
		public System.Windows.Forms.Button bntSayIt;
		public System.Windows.Forms.Button btnClear;
		public System.Windows.Forms.TextBox txtSayData;
		public System.Windows.Forms.Button Command2;
		public System.Windows.Forms.Button btnCodes;
		public System.Windows.Forms.GroupBox Frame10;
		public System.Windows.Forms.TextBox txtBend;
		public System.Windows.Forms.TextBox txtPitch;
		public System.Windows.Forms.TextBox txtSpeed;
		public System.Windows.Forms.TextBox txtVolume;
		public System.Windows.Forms.HScrollBar scVolume;
		public System.Windows.Forms.HScrollBar scSpeed;
		public System.Windows.Forms.HScrollBar scPitch;
		public System.Windows.Forms.HScrollBar scBend;
		public System.Windows.Forms.CheckBox chkApplyControlsBeforeSounds;
		public System.Windows.Forms.CheckBox chkApplyControlsBeforeSayData;
		private System.Windows.Forms.Label _Command1_140;
		public System.Windows.Forms.Label lblVolume;
		public System.Windows.Forms.Label lblSpeed;
		public System.Windows.Forms.Label lblPitch;
		public System.Windows.Forms.Label lblBend;
		public System.Windows.Forms.GroupBox Frame9;
		private System.Windows.Forms.Label _Command1_126;
		private System.Windows.Forms.Label _Command1_123;
		private System.Windows.Forms.Label _Command1_122;
		private System.Windows.Forms.Label _Command1_91;
		private System.Windows.Forms.Label _Command1_101;
		private System.Windows.Forms.Label _Command1_81;
		private System.Windows.Forms.Label _Command1_111;
		private System.Windows.Forms.Label _Command1_121;
		private System.Windows.Forms.Label _Command1_90;
		private System.Windows.Forms.Label _Command1_100;
		private System.Windows.Forms.Label _Command1_80;
		private System.Windows.Forms.Label _Command1_110;
		private System.Windows.Forms.Label _Command1_120;
		private System.Windows.Forms.Label _Command1_89;
		private System.Windows.Forms.Label _Command1_99;
		private System.Windows.Forms.Label _Command1_79;
		private System.Windows.Forms.Label _Command1_109;
		private System.Windows.Forms.Label _Command1_119;
		private System.Windows.Forms.Label _Command1_88;
		private System.Windows.Forms.Label _Command1_98;
		private System.Windows.Forms.Label _Command1_78;
		private System.Windows.Forms.Label _Command1_108;
		private System.Windows.Forms.Label _Command1_118;
		private System.Windows.Forms.Label _Command1_87;
		private System.Windows.Forms.Label _Command1_97;
		private System.Windows.Forms.Label _Command1_77;
		private System.Windows.Forms.Label _Command1_107;
		private System.Windows.Forms.Label _Command1_117;
		private System.Windows.Forms.Label _Command1_86;
		private System.Windows.Forms.Label _Command1_96;
		private System.Windows.Forms.Label _Command1_76;
		private System.Windows.Forms.Label _Command1_106;
		private System.Windows.Forms.Label _Command1_116;
		private System.Windows.Forms.Label _Command1_85;
		private System.Windows.Forms.Label _Command1_95;
		private System.Windows.Forms.Label _Command1_75;
		private System.Windows.Forms.Label _Command1_105;
		private System.Windows.Forms.Label _Command1_115;
		private System.Windows.Forms.Label _Command1_84;
		private System.Windows.Forms.Label _Command1_94;
		private System.Windows.Forms.Label _Command1_74;
		private System.Windows.Forms.Label _Command1_104;
		private System.Windows.Forms.Label _Command1_114;
		private System.Windows.Forms.Label _Command1_83;
		private System.Windows.Forms.Label _Command1_93;
		private System.Windows.Forms.Label _Command1_73;
		private System.Windows.Forms.Label _Command1_103;
		private System.Windows.Forms.Label _Command1_113;
		private System.Windows.Forms.Label _Command1_82;
		private System.Windows.Forms.Label _Command1_92;
		private System.Windows.Forms.Label _Command1_72;
		private System.Windows.Forms.Label _Command1_102;
		private System.Windows.Forms.Label _Command1_112;
		public System.Windows.Forms.Label Label3;
		public System.Windows.Forms.Label Label4;
		public System.Windows.Forms.Label Label5;
		public System.Windows.Forms.Label Label2;
		public System.Windows.Forms.Label Label6;
		private System.Windows.Forms.Label _Command1_124;
		private System.Windows.Forms.Label _Command1_125;
		public System.Windows.Forms.GroupBox Frame8;
		private System.Windows.Forms.Label _Command1_54;
		private System.Windows.Forms.Label _Command1_55;
		private System.Windows.Forms.Label _Command1_56;
		private System.Windows.Forms.Label _Command1_57;
		private System.Windows.Forms.Label _Command1_58;
		private System.Windows.Forms.Label _Command1_59;
		private System.Windows.Forms.Label _Command1_60;
		private System.Windows.Forms.Label _Command1_61;
		private System.Windows.Forms.Label _Command1_62;
		public System.Windows.Forms.GroupBox Frame7;
		private System.Windows.Forms.Label _Command1_37;
		private System.Windows.Forms.Label _Command1_38;
		private System.Windows.Forms.Label _Command1_39;
		private System.Windows.Forms.Label _Command1_40;
		private System.Windows.Forms.Label _Command1_41;
		public System.Windows.Forms.GroupBox Frame2;
		private System.Windows.Forms.Label _Command1_63;
		private System.Windows.Forms.Label _Command1_64;
		private System.Windows.Forms.Label _Command1_65;
		private System.Windows.Forms.Label _Command1_66;
		private System.Windows.Forms.Label _Command1_67;
		private System.Windows.Forms.Label _Command1_68;
		private System.Windows.Forms.Label _Command1_69;
		private System.Windows.Forms.Label _Command1_70;
		private System.Windows.Forms.Label _Command1_71;
		public System.Windows.Forms.GroupBox Frame6;
		private System.Windows.Forms.Label _Command1_42;
		private System.Windows.Forms.Label _Command1_43;
		private System.Windows.Forms.Label _Command1_44;
		private System.Windows.Forms.Label _Command1_45;
		private System.Windows.Forms.Label _Command1_46;
		private System.Windows.Forms.Label _Command1_47;
		private System.Windows.Forms.Label _Command1_48;
		private System.Windows.Forms.Label _Command1_49;
		private System.Windows.Forms.Label _Command1_50;
		private System.Windows.Forms.Label _Command1_51;
		private System.Windows.Forms.Label _Command1_52;
		private System.Windows.Forms.Label _Command1_53;
		public System.Windows.Forms.GroupBox Frame5;
		private System.Windows.Forms.Label _Command1_25;
		private System.Windows.Forms.Label _Command1_26;
		private System.Windows.Forms.Label _Command1_27;
		private System.Windows.Forms.Label _Command1_30;
		private System.Windows.Forms.Label _Command1_28;
		private System.Windows.Forms.Label _Command1_31;
		private System.Windows.Forms.Label _Command1_34;
		private System.Windows.Forms.Label _Command1_33;
		private System.Windows.Forms.Label _Command1_35;
		private System.Windows.Forms.Label _Command1_36;
		private System.Windows.Forms.Label _Command1_29;
		public System.Windows.Forms.GroupBox Frame4;
		private System.Windows.Forms.Label _Command1_11;
		private System.Windows.Forms.Label _Command1_12;
		private System.Windows.Forms.Label _Command1_13;
		private System.Windows.Forms.Label _Command1_14;
		private System.Windows.Forms.Label _Command1_15;
		private System.Windows.Forms.Label _Command1_16;
		private System.Windows.Forms.Label _Command1_17;
		private System.Windows.Forms.Label _Command1_18;
		public System.Windows.Forms.GroupBox Frame3;
		private System.Windows.Forms.Label _Command1_4;
		private System.Windows.Forms.Label _Command1_3;
		private System.Windows.Forms.Label _Command1_2;
		private System.Windows.Forms.Label _Command1_1;
		private System.Windows.Forms.Label _Command1_32;
		private System.Windows.Forms.Label _Command1_0;
		private System.Windows.Forms.Label _Command1_5;
		private System.Windows.Forms.Label _Command1_6;
		private System.Windows.Forms.Label _Command1_7;
		private System.Windows.Forms.Label _Command1_8;
		private System.Windows.Forms.Label _Command1_9;
		private System.Windows.Forms.Label _Command1_10;
		public System.Windows.Forms.GroupBox Frame1;
		public System.Windows.Forms.Label[] Command1 = new System.Windows.Forms.Label[198];
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhrase));
			this.ToolTipMain = new System.Windows.Forms.ToolTip(this.components);
			this.Frame16 = new System.Windows.Forms.GroupBox();
			this.txtCall = new System.Windows.Forms.TextBox();
			this.txtPlay = new System.Windows.Forms.TextBox();
			this.txtPCtrl = new System.Windows.Forms.TextBox();
			this.txtPOut = new System.Windows.Forms.TextBox();
			this._Command1_156 = new System.Windows.Forms.Label();
			this._Command1_127 = new System.Windows.Forms.Label();
			this._Command1_137 = new System.Windows.Forms.Label();
			this._Command1_138 = new System.Windows.Forms.Label();
			this.btnShutUp = new System.Windows.Forms.Button();
			this.btnDone = new System.Windows.Forms.Button();
			this.Frame15 = new System.Windows.Forms.GroupBox();
			this.txtfindwith = new System.Windows.Forms.TextBox();
			this.chkWithout = new System.Windows.Forms.CheckBox();
			this.chkWith = new System.Windows.Forms.CheckBox();
			this.btnNextWord = new System.Windows.Forms.Button();
			this.cmdLoadOver = new System.Windows.Forms.Button();
			this.cmdSave = new System.Windows.Forms.Button();
			this.txtDict = new System.Windows.Forms.TextBox();
			this.cmdLoadInsert = new System.Windows.Forms.Button();
			this.Frame14 = new System.Windows.Forms.GroupBox();
			this.TxtDelay = new System.Windows.Forms.TextBox();
			this._Command1_158 = new System.Windows.Forms.Label();
			this._Command1_129 = new System.Windows.Forms.Label();
			this._Command1_131 = new System.Windows.Forms.Label();
			this._Command1_134 = new System.Windows.Forms.Label();
			this._Command1_132 = new System.Windows.Forms.Label();
			this._Command1_130 = new System.Windows.Forms.Label();
			this._Command1_133 = new System.Windows.Forms.Label();
			this._Command1_128 = new System.Windows.Forms.Label();
			this._Command1_139 = new System.Windows.Forms.Label();
			this.Frame13 = new System.Windows.Forms.GroupBox();
			this.Label9 = new System.Windows.Forms.Label();
			this.Label8 = new System.Windows.Forms.Label();
			this.Label7 = new System.Windows.Forms.Label();
			this._Command1_197 = new System.Windows.Forms.Label();
			this._Command1_192 = new System.Windows.Forms.Label();
			this._Command1_187 = new System.Windows.Forms.Label();
			this._Command1_182 = new System.Windows.Forms.Label();
			this._Command1_177 = new System.Windows.Forms.Label();
			this._Command1_175 = new System.Windows.Forms.Label();
			this._Command1_172 = new System.Windows.Forms.Label();
			this._Command1_170 = new System.Windows.Forms.Label();
			this._Command1_165 = new System.Windows.Forms.Label();
			this._Command1_160 = new System.Windows.Forms.Label();
			this._Command1_152 = new System.Windows.Forms.Label();
			this._Command1_147 = new System.Windows.Forms.Label();
			this._Command1_196 = new System.Windows.Forms.Label();
			this._Command1_195 = new System.Windows.Forms.Label();
			this._Command1_194 = new System.Windows.Forms.Label();
			this._Command1_191 = new System.Windows.Forms.Label();
			this._Command1_190 = new System.Windows.Forms.Label();
			this._Command1_189 = new System.Windows.Forms.Label();
			this._Command1_186 = new System.Windows.Forms.Label();
			this._Command1_185 = new System.Windows.Forms.Label();
			this._Command1_184 = new System.Windows.Forms.Label();
			this._Command1_181 = new System.Windows.Forms.Label();
			this._Command1_180 = new System.Windows.Forms.Label();
			this._Command1_179 = new System.Windows.Forms.Label();
			this._Command1_176 = new System.Windows.Forms.Label();
			this._Command1_174 = new System.Windows.Forms.Label();
			this._Command1_171 = new System.Windows.Forms.Label();
			this._Command1_169 = new System.Windows.Forms.Label();
			this._Command1_166 = new System.Windows.Forms.Label();
			this._Command1_164 = new System.Windows.Forms.Label();
			this._Command1_161 = new System.Windows.Forms.Label();
			this._Command1_159 = new System.Windows.Forms.Label();
			this._Command1_153 = new System.Windows.Forms.Label();
			this._Command1_151 = new System.Windows.Forms.Label();
			this._Command1_148 = new System.Windows.Forms.Label();
			this._Command1_146 = new System.Windows.Forms.Label();
			this.Frame12 = new System.Windows.Forms.GroupBox();
			this._Command1_24 = new System.Windows.Forms.Label();
			this._Command1_23 = new System.Windows.Forms.Label();
			this._Command1_22 = new System.Windows.Forms.Label();
			this._Command1_21 = new System.Windows.Forms.Label();
			this._Command1_20 = new System.Windows.Forms.Label();
			this._Command1_19 = new System.Windows.Forms.Label();
			this.Frame11 = new System.Windows.Forms.GroupBox();
			this.txtRepeat = new System.Windows.Forms.TextBox();
			this._Command1_141 = new System.Windows.Forms.Label();
			this._Command1_154 = new System.Windows.Forms.Label();
			this._Command1_142 = new System.Windows.Forms.Label();
			this._Command1_143 = new System.Windows.Forms.Label();
			this._Command1_136 = new System.Windows.Forms.Label();
			this._Command1_135 = new System.Windows.Forms.Label();
			this.Frame10 = new System.Windows.Forms.GroupBox();
			this.btnSaySelection = new System.Windows.Forms.Button();
			this.bntSayIt = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.txtSayData = new System.Windows.Forms.TextBox();
			this.Command2 = new System.Windows.Forms.Button();
			this.btnCodes = new System.Windows.Forms.Button();
			this.Frame9 = new System.Windows.Forms.GroupBox();
			this.txtBend = new System.Windows.Forms.TextBox();
			this.txtPitch = new System.Windows.Forms.TextBox();
			this.txtSpeed = new System.Windows.Forms.TextBox();
			this.txtVolume = new System.Windows.Forms.TextBox();
			this.scVolume = new System.Windows.Forms.HScrollBar();
			this.scSpeed = new System.Windows.Forms.HScrollBar();
			this.scPitch = new System.Windows.Forms.HScrollBar();
			this.scBend = new System.Windows.Forms.HScrollBar();
			this.chkApplyControlsBeforeSounds = new System.Windows.Forms.CheckBox();
			this.chkApplyControlsBeforeSayData = new System.Windows.Forms.CheckBox();
			this._Command1_140 = new System.Windows.Forms.Label();
			this.lblVolume = new System.Windows.Forms.Label();
			this.lblSpeed = new System.Windows.Forms.Label();
			this.lblPitch = new System.Windows.Forms.Label();
			this.lblBend = new System.Windows.Forms.Label();
			this.Frame8 = new System.Windows.Forms.GroupBox();
			this._Command1_126 = new System.Windows.Forms.Label();
			this._Command1_123 = new System.Windows.Forms.Label();
			this._Command1_122 = new System.Windows.Forms.Label();
			this._Command1_91 = new System.Windows.Forms.Label();
			this._Command1_101 = new System.Windows.Forms.Label();
			this._Command1_81 = new System.Windows.Forms.Label();
			this._Command1_111 = new System.Windows.Forms.Label();
			this._Command1_121 = new System.Windows.Forms.Label();
			this._Command1_90 = new System.Windows.Forms.Label();
			this._Command1_100 = new System.Windows.Forms.Label();
			this._Command1_80 = new System.Windows.Forms.Label();
			this._Command1_110 = new System.Windows.Forms.Label();
			this._Command1_120 = new System.Windows.Forms.Label();
			this._Command1_89 = new System.Windows.Forms.Label();
			this._Command1_99 = new System.Windows.Forms.Label();
			this._Command1_79 = new System.Windows.Forms.Label();
			this._Command1_109 = new System.Windows.Forms.Label();
			this._Command1_119 = new System.Windows.Forms.Label();
			this._Command1_88 = new System.Windows.Forms.Label();
			this._Command1_98 = new System.Windows.Forms.Label();
			this._Command1_78 = new System.Windows.Forms.Label();
			this._Command1_108 = new System.Windows.Forms.Label();
			this._Command1_118 = new System.Windows.Forms.Label();
			this._Command1_87 = new System.Windows.Forms.Label();
			this._Command1_97 = new System.Windows.Forms.Label();
			this._Command1_77 = new System.Windows.Forms.Label();
			this._Command1_107 = new System.Windows.Forms.Label();
			this._Command1_117 = new System.Windows.Forms.Label();
			this._Command1_86 = new System.Windows.Forms.Label();
			this._Command1_96 = new System.Windows.Forms.Label();
			this._Command1_76 = new System.Windows.Forms.Label();
			this._Command1_106 = new System.Windows.Forms.Label();
			this._Command1_116 = new System.Windows.Forms.Label();
			this._Command1_85 = new System.Windows.Forms.Label();
			this._Command1_95 = new System.Windows.Forms.Label();
			this._Command1_75 = new System.Windows.Forms.Label();
			this._Command1_105 = new System.Windows.Forms.Label();
			this._Command1_115 = new System.Windows.Forms.Label();
			this._Command1_84 = new System.Windows.Forms.Label();
			this._Command1_94 = new System.Windows.Forms.Label();
			this._Command1_74 = new System.Windows.Forms.Label();
			this._Command1_104 = new System.Windows.Forms.Label();
			this._Command1_114 = new System.Windows.Forms.Label();
			this._Command1_83 = new System.Windows.Forms.Label();
			this._Command1_93 = new System.Windows.Forms.Label();
			this._Command1_73 = new System.Windows.Forms.Label();
			this._Command1_103 = new System.Windows.Forms.Label();
			this._Command1_113 = new System.Windows.Forms.Label();
			this._Command1_82 = new System.Windows.Forms.Label();
			this._Command1_92 = new System.Windows.Forms.Label();
			this._Command1_72 = new System.Windows.Forms.Label();
			this._Command1_102 = new System.Windows.Forms.Label();
			this._Command1_112 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this._Command1_124 = new System.Windows.Forms.Label();
			this._Command1_125 = new System.Windows.Forms.Label();
			this.Frame7 = new System.Windows.Forms.GroupBox();
			this._Command1_54 = new System.Windows.Forms.Label();
			this._Command1_55 = new System.Windows.Forms.Label();
			this._Command1_56 = new System.Windows.Forms.Label();
			this._Command1_57 = new System.Windows.Forms.Label();
			this._Command1_58 = new System.Windows.Forms.Label();
			this._Command1_59 = new System.Windows.Forms.Label();
			this._Command1_60 = new System.Windows.Forms.Label();
			this._Command1_61 = new System.Windows.Forms.Label();
			this._Command1_62 = new System.Windows.Forms.Label();
			this.Frame2 = new System.Windows.Forms.GroupBox();
			this._Command1_37 = new System.Windows.Forms.Label();
			this._Command1_38 = new System.Windows.Forms.Label();
			this._Command1_39 = new System.Windows.Forms.Label();
			this._Command1_40 = new System.Windows.Forms.Label();
			this._Command1_41 = new System.Windows.Forms.Label();
			this.Frame6 = new System.Windows.Forms.GroupBox();
			this._Command1_63 = new System.Windows.Forms.Label();
			this._Command1_64 = new System.Windows.Forms.Label();
			this._Command1_65 = new System.Windows.Forms.Label();
			this._Command1_66 = new System.Windows.Forms.Label();
			this._Command1_67 = new System.Windows.Forms.Label();
			this._Command1_68 = new System.Windows.Forms.Label();
			this._Command1_69 = new System.Windows.Forms.Label();
			this._Command1_70 = new System.Windows.Forms.Label();
			this._Command1_71 = new System.Windows.Forms.Label();
			this.Frame5 = new System.Windows.Forms.GroupBox();
			this._Command1_42 = new System.Windows.Forms.Label();
			this._Command1_43 = new System.Windows.Forms.Label();
			this._Command1_44 = new System.Windows.Forms.Label();
			this._Command1_45 = new System.Windows.Forms.Label();
			this._Command1_46 = new System.Windows.Forms.Label();
			this._Command1_47 = new System.Windows.Forms.Label();
			this._Command1_48 = new System.Windows.Forms.Label();
			this._Command1_49 = new System.Windows.Forms.Label();
			this._Command1_50 = new System.Windows.Forms.Label();
			this._Command1_51 = new System.Windows.Forms.Label();
			this._Command1_52 = new System.Windows.Forms.Label();
			this._Command1_53 = new System.Windows.Forms.Label();
			this.Frame4 = new System.Windows.Forms.GroupBox();
			this._Command1_25 = new System.Windows.Forms.Label();
			this._Command1_26 = new System.Windows.Forms.Label();
			this._Command1_27 = new System.Windows.Forms.Label();
			this._Command1_30 = new System.Windows.Forms.Label();
			this._Command1_28 = new System.Windows.Forms.Label();
			this._Command1_31 = new System.Windows.Forms.Label();
			this._Command1_34 = new System.Windows.Forms.Label();
			this._Command1_33 = new System.Windows.Forms.Label();
			this._Command1_35 = new System.Windows.Forms.Label();
			this._Command1_36 = new System.Windows.Forms.Label();
			this._Command1_29 = new System.Windows.Forms.Label();
			this.Frame3 = new System.Windows.Forms.GroupBox();
			this._Command1_11 = new System.Windows.Forms.Label();
			this._Command1_12 = new System.Windows.Forms.Label();
			this._Command1_13 = new System.Windows.Forms.Label();
			this._Command1_14 = new System.Windows.Forms.Label();
			this._Command1_15 = new System.Windows.Forms.Label();
			this._Command1_16 = new System.Windows.Forms.Label();
			this._Command1_17 = new System.Windows.Forms.Label();
			this._Command1_18 = new System.Windows.Forms.Label();
			this.Frame1 = new System.Windows.Forms.GroupBox();
			this._Command1_4 = new System.Windows.Forms.Label();
			this._Command1_3 = new System.Windows.Forms.Label();
			this._Command1_2 = new System.Windows.Forms.Label();
			this._Command1_1 = new System.Windows.Forms.Label();
			this._Command1_32 = new System.Windows.Forms.Label();
			this._Command1_0 = new System.Windows.Forms.Label();
			this._Command1_5 = new System.Windows.Forms.Label();
			this._Command1_6 = new System.Windows.Forms.Label();
			this._Command1_7 = new System.Windows.Forms.Label();
			this._Command1_8 = new System.Windows.Forms.Label();
			this._Command1_9 = new System.Windows.Forms.Label();
			this._Command1_10 = new System.Windows.Forms.Label();
			this.Frame16.SuspendLayout();
			this.Frame15.SuspendLayout();
			this.Frame14.SuspendLayout();
			this.Frame13.SuspendLayout();
			this.Frame12.SuspendLayout();
			this.Frame11.SuspendLayout();
			this.Frame10.SuspendLayout();
			this.Frame9.SuspendLayout();
			this.Frame8.SuspendLayout();
			this.Frame7.SuspendLayout();
			this.Frame2.SuspendLayout();
			this.Frame6.SuspendLayout();
			this.Frame5.SuspendLayout();
			this.Frame4.SuspendLayout();
			this.Frame3.SuspendLayout();
			this.Frame1.SuspendLayout();
			this.SuspendLayout();
			// 
			// Frame16
			// 
			this.Frame16.AllowDrop = true;
			this.Frame16.BackColor = System.Drawing.SystemColors.Control;
			this.Frame16.Controls.Add(this.txtCall);
			this.Frame16.Controls.Add(this.txtPlay);
			this.Frame16.Controls.Add(this.txtPCtrl);
			this.Frame16.Controls.Add(this.txtPOut);
			this.Frame16.Controls.Add(this._Command1_156);
			this.Frame16.Controls.Add(this._Command1_127);
			this.Frame16.Controls.Add(this._Command1_137);
			this.Frame16.Controls.Add(this._Command1_138);
			this.Frame16.Enabled = true;
			this.Frame16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Frame16.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame16.Location = new System.Drawing.Point(676, 176);
			this.Frame16.Name = "Frame16";
			this.Frame16.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame16.Size = new System.Drawing.Size(97, 113);
			this.Frame16.TabIndex = 234;
			this.Frame16.Text = "Commands";
			this.Frame16.Visible = true;
			// 
			// txtCall
			// 
			this.txtCall.AcceptsReturn = true;
			this.txtCall.AllowDrop = true;
			this.txtCall.BackColor = System.Drawing.SystemColors.Window;
			this.txtCall.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtCall.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtCall.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtCall.Location = new System.Drawing.Point(60, 20);
			this.txtCall.MaxLength = 0;
			this.txtCall.Name = "txtCall";
			this.txtCall.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtCall.Size = new System.Drawing.Size(27, 19);
			this.txtCall.TabIndex = 238;
			this.txtCall.Text = "0";
			// 
			// txtPlay
			// 
			this.txtPlay.AcceptsReturn = true;
			this.txtPlay.AllowDrop = true;
			this.txtPlay.BackColor = System.Drawing.SystemColors.Window;
			this.txtPlay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtPlay.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtPlay.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtPlay.Location = new System.Drawing.Point(60, 42);
			this.txtPlay.MaxLength = 0;
			this.txtPlay.Name = "txtPlay";
			this.txtPlay.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtPlay.Size = new System.Drawing.Size(27, 19);
			this.txtPlay.TabIndex = 237;
			this.txtPlay.Text = "0";
			// 
			// txtPCtrl
			// 
			this.txtPCtrl.AcceptsReturn = true;
			this.txtPCtrl.AllowDrop = true;
			this.txtPCtrl.BackColor = System.Drawing.SystemColors.Window;
			this.txtPCtrl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtPCtrl.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtPCtrl.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtPCtrl.Location = new System.Drawing.Point(60, 64);
			this.txtPCtrl.MaxLength = 0;
			this.txtPCtrl.Name = "txtPCtrl";
			this.txtPCtrl.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtPCtrl.Size = new System.Drawing.Size(27, 19);
			this.txtPCtrl.TabIndex = 236;
			this.txtPCtrl.Text = "7";
			// 
			// txtPOut
			// 
			this.txtPOut.AcceptsReturn = true;
			this.txtPOut.AllowDrop = true;
			this.txtPOut.BackColor = System.Drawing.SystemColors.Window;
			this.txtPOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtPOut.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtPOut.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtPOut.Location = new System.Drawing.Point(60, 86);
			this.txtPOut.MaxLength = 0;
			this.txtPOut.Name = "txtPOut";
			this.txtPOut.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtPOut.Size = new System.Drawing.Size(27, 19);
			this.txtPOut.TabIndex = 235;
			this.txtPOut.Text = "7";
			// 
			// _Command1_156
			// 
			this._Command1_156.AllowDrop = true;
			this._Command1_156.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_156.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_156.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_156.Location = new System.Drawing.Point(6, 20);
			this._Command1_156.Name = "_Command1_156";
			this._Command1_156.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_156.Size = new System.Drawing.Size(51, 17);
			this._Command1_156.TabIndex = 242;
			this._Command1_156.Text = "Call";
			this._Command1_156.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_156.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_156.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_127
			// 
			this._Command1_127.AllowDrop = true;
			this._Command1_127.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_127.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_127.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_127.Location = new System.Drawing.Point(6, 42);
			this._Command1_127.Name = "_Command1_127";
			this._Command1_127.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_127.Size = new System.Drawing.Size(51, 17);
			this._Command1_127.TabIndex = 241;
			this._Command1_127.Text = "Play";
			this._Command1_127.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_127.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_127.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_137
			// 
			this._Command1_137.AllowDrop = true;
			this._Command1_137.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_137.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_137.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_137.Location = new System.Drawing.Point(6, 64);
			this._Command1_137.Name = "_Command1_137";
			this._Command1_137.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_137.Size = new System.Drawing.Size(51, 17);
			this._Command1_137.TabIndex = 240;
			this._Command1_137.Text = "PCtrl";
			this._Command1_137.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_137.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_137.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_138
			// 
			this._Command1_138.AllowDrop = true;
			this._Command1_138.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_138.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_138.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_138.Location = new System.Drawing.Point(6, 86);
			this._Command1_138.Name = "_Command1_138";
			this._Command1_138.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_138.Size = new System.Drawing.Size(51, 17);
			this._Command1_138.TabIndex = 239;
			this._Command1_138.Text = "POut";
			this._Command1_138.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_138.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_138.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// btnShutUp
			// 
			this.btnShutUp.AllowDrop = true;
			this.btnShutUp.BackColor = System.Drawing.SystemColors.Control;
			this.btnShutUp.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnShutUp.Location = new System.Drawing.Point(622, 494);
			this.btnShutUp.Name = "btnShutUp";
			this.btnShutUp.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnShutUp.Size = new System.Drawing.Size(65, 29);
			this.btnShutUp.TabIndex = 229;
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
			this.btnDone.Location = new System.Drawing.Point(692, 494);
			this.btnDone.Name = "btnDone";
			this.btnDone.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnDone.Size = new System.Drawing.Size(65, 29);
			this.btnDone.TabIndex = 228;
			this.btnDone.Text = "Done";
			this.btnDone.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnDone.UseVisualStyleBackColor = false;
			this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
			// 
			// Frame15
			// 
			this.Frame15.AllowDrop = true;
			this.Frame15.BackColor = System.Drawing.SystemColors.Control;
			this.Frame15.Controls.Add(this.txtfindwith);
			this.Frame15.Controls.Add(this.chkWithout);
			this.Frame15.Controls.Add(this.chkWith);
			this.Frame15.Controls.Add(this.btnNextWord);
			this.Frame15.Controls.Add(this.cmdLoadOver);
			this.Frame15.Controls.Add(this.cmdSave);
			this.Frame15.Controls.Add(this.txtDict);
			this.Frame15.Controls.Add(this.cmdLoadInsert);
			this.Frame15.Enabled = true;
			this.Frame15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Frame15.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame15.Location = new System.Drawing.Point(4, 484);
			this.Frame15.Name = "Frame15";
			this.Frame15.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame15.Size = new System.Drawing.Size(591, 41);
			this.Frame15.TabIndex = 220;
			this.Frame15.Text = "Dictionary";
			this.Frame15.Visible = true;
			// 
			// txtfindwith
			// 
			this.txtfindwith.AcceptsReturn = true;
			this.txtfindwith.AllowDrop = true;
			this.txtfindwith.BackColor = System.Drawing.SystemColors.Window;
			this.txtfindwith.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtfindwith.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtfindwith.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtfindwith.Location = new System.Drawing.Point(598, 18);
			this.txtfindwith.MaxLength = 0;
			this.txtfindwith.Name = "txtfindwith";
			this.txtfindwith.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtfindwith.Size = new System.Drawing.Size(41, 19);
			this.txtfindwith.TabIndex = 231;
			this.txtfindwith.Visible = false;
			// 
			// chkWithout
			// 
			this.chkWithout.AllowDrop = true;
			this.chkWithout.Appearance = System.Windows.Forms.Appearance.Normal;
			this.chkWithout.BackColor = System.Drawing.SystemColors.Control;
			this.chkWithout.CausesValidation = true;
			this.chkWithout.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.chkWithout.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkWithout.Enabled = true;
			this.chkWithout.ForeColor = System.Drawing.SystemColors.ControlText;
			this.chkWithout.Location = new System.Drawing.Point(444, 30);
			this.chkWithout.Name = "chkWithout";
			this.chkWithout.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.chkWithout.Size = new System.Drawing.Size(93, 13);
			this.chkWithout.TabIndex = 227;
			this.chkWithout.TabStop = true;
			this.chkWithout.Text = "Without Data";
			this.chkWithout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.chkWithout.Visible = false;
			// 
			// chkWith
			// 
			this.chkWith.AllowDrop = true;
			this.chkWith.Appearance = System.Windows.Forms.Appearance.Normal;
			this.chkWith.BackColor = System.Drawing.SystemColors.Control;
			this.chkWith.CausesValidation = true;
			this.chkWith.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.chkWith.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkWith.Enabled = true;
			this.chkWith.ForeColor = System.Drawing.SystemColors.ControlText;
			this.chkWith.Location = new System.Drawing.Point(444, 14);
			this.chkWith.Name = "chkWith";
			this.chkWith.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.chkWith.Size = new System.Drawing.Size(73, 13);
			this.chkWith.TabIndex = 226;
			this.chkWith.TabStop = true;
			this.chkWith.Text = "With Data";
			this.chkWith.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.chkWith.Visible = false;
			// 
			// btnNextWord
			// 
			this.btnNextWord.AllowDrop = true;
			this.btnNextWord.BackColor = System.Drawing.SystemColors.Control;
			this.btnNextWord.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnNextWord.Location = new System.Drawing.Point(308, 16);
			this.btnNextWord.Name = "btnNextWord";
			this.btnNextWord.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnNextWord.Size = new System.Drawing.Size(127, 19);
			this.btnNextWord.TabIndex = 225;
			this.btnNextWord.Text = "Load && Say  Next Word";
			this.btnNextWord.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnNextWord.UseVisualStyleBackColor = false;
			this.btnNextWord.Click += new System.EventHandler(this.btnNextWord_Click);
			// 
			// cmdLoadOver
			// 
			this.cmdLoadOver.AllowDrop = true;
			this.cmdLoadOver.BackColor = System.Drawing.SystemColors.Control;
			this.cmdLoadOver.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdLoadOver.Location = new System.Drawing.Point(146, 16);
			this.cmdLoadOver.Name = "cmdLoadOver";
			this.cmdLoadOver.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmdLoadOver.Size = new System.Drawing.Size(85, 19);
			this.cmdLoadOver.TabIndex = 224;
			this.cmdLoadOver.Text = "Load Overwrite";
			this.cmdLoadOver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cmdLoadOver.UseVisualStyleBackColor = false;
			this.cmdLoadOver.Click += new System.EventHandler(this.cmdLoadOver_Click);
			// 
			// cmdSave
			// 
			this.cmdSave.AllowDrop = true;
			this.cmdSave.BackColor = System.Drawing.SystemColors.Control;
			this.cmdSave.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdSave.Location = new System.Drawing.Point(542, 16);
			this.cmdSave.Name = "cmdSave";
			this.cmdSave.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmdSave.Size = new System.Drawing.Size(35, 19);
			this.cmdSave.TabIndex = 223;
			this.cmdSave.Text = "Save";
			this.cmdSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cmdSave.UseVisualStyleBackColor = false;
			this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
			// 
			// txtDict
			// 
			this.txtDict.AcceptsReturn = true;
			this.txtDict.AllowDrop = true;
			this.txtDict.BackColor = System.Drawing.SystemColors.Window;
			this.txtDict.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtDict.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtDict.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtDict.Location = new System.Drawing.Point(8, 16);
			this.txtDict.MaxLength = 0;
			this.txtDict.Name = "txtDict";
			this.txtDict.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtDict.Size = new System.Drawing.Size(133, 19);
			this.txtDict.TabIndex = 222;
			// 
			// cmdLoadInsert
			// 
			this.cmdLoadInsert.AllowDrop = true;
			this.cmdLoadInsert.BackColor = System.Drawing.SystemColors.Control;
			this.cmdLoadInsert.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdLoadInsert.Location = new System.Drawing.Point(234, 16);
			this.cmdLoadInsert.Name = "cmdLoadInsert";
			this.cmdLoadInsert.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmdLoadInsert.Size = new System.Drawing.Size(69, 19);
			this.cmdLoadInsert.TabIndex = 221;
			this.cmdLoadInsert.Text = "Load Insert";
			this.cmdLoadInsert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cmdLoadInsert.UseVisualStyleBackColor = false;
			this.cmdLoadInsert.Click += new System.EventHandler(this.cmdLoadInsert_Click);
			// 
			// Frame14
			// 
			this.Frame14.AllowDrop = true;
			this.Frame14.BackColor = System.Drawing.SystemColors.Control;
			this.Frame14.Controls.Add(this.TxtDelay);
			this.Frame14.Controls.Add(this._Command1_158);
			this.Frame14.Controls.Add(this._Command1_129);
			this.Frame14.Controls.Add(this._Command1_131);
			this.Frame14.Controls.Add(this._Command1_134);
			this.Frame14.Controls.Add(this._Command1_132);
			this.Frame14.Controls.Add(this._Command1_130);
			this.Frame14.Controls.Add(this._Command1_133);
			this.Frame14.Controls.Add(this._Command1_128);
			this.Frame14.Controls.Add(this._Command1_139);
			this.Frame14.Enabled = true;
			this.Frame14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Frame14.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame14.Location = new System.Drawing.Point(4, 4);
			this.Frame14.Name = "Frame14";
			this.Frame14.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame14.Size = new System.Drawing.Size(137, 111);
			this.Frame14.TabIndex = 209;
			this.Frame14.Text = "Pauses";
			this.Frame14.Visible = true;
			// 
			// TxtDelay
			// 
			this.TxtDelay.AcceptsReturn = true;
			this.TxtDelay.AllowDrop = true;
			this.TxtDelay.BackColor = System.Drawing.SystemColors.Window;
			this.TxtDelay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.TxtDelay.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.TxtDelay.ForeColor = System.Drawing.SystemColors.WindowText;
			this.TxtDelay.Location = new System.Drawing.Point(92, 78);
			this.TxtDelay.MaxLength = 0;
			this.TxtDelay.Name = "TxtDelay";
			this.TxtDelay.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.TxtDelay.Size = new System.Drawing.Size(29, 19);
			this.TxtDelay.TabIndex = 218;
			this.TxtDelay.Text = "100";
			// 
			// _Command1_158
			// 
			this._Command1_158.AllowDrop = true;
			this._Command1_158.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_158.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_158.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_158.Location = new System.Drawing.Point(48, 78);
			this._Command1_158.Name = "_Command1_158";
			this._Command1_158.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_158.Size = new System.Drawing.Size(43, 17);
			this._Command1_158.TabIndex = 219;
			this._Command1_158.Text = "Delay";
			this._Command1_158.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_158.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_158.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_129
			// 
			this._Command1_129.AllowDrop = true;
			this._Command1_129.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_129.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_129.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_129.Location = new System.Drawing.Point(8, 42);
			this._Command1_129.Name = "_Command1_129";
			this._Command1_129.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_129.Size = new System.Drawing.Size(31, 17);
			this._Command1_129.TabIndex = 217;
			this._Command1_129.Text = "P1";
			this._Command1_129.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_129.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_129.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_131
			// 
			this._Command1_131.AllowDrop = true;
			this._Command1_131.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_131.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_131.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_131.Location = new System.Drawing.Point(8, 78);
			this._Command1_131.Name = "_Command1_131";
			this._Command1_131.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_131.Size = new System.Drawing.Size(31, 17);
			this._Command1_131.TabIndex = 216;
			this._Command1_131.Text = "P3";
			this._Command1_131.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_131.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_131.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_134
			// 
			this._Command1_134.AllowDrop = true;
			this._Command1_134.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_134.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_134.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_134.Location = new System.Drawing.Point(48, 60);
			this._Command1_134.Name = "_Command1_134";
			this._Command1_134.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_134.Size = new System.Drawing.Size(31, 17);
			this._Command1_134.TabIndex = 215;
			this._Command1_134.Text = "P6";
			this._Command1_134.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_134.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_134.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_132
			// 
			this._Command1_132.AllowDrop = true;
			this._Command1_132.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_132.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_132.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_132.Location = new System.Drawing.Point(48, 24);
			this._Command1_132.Name = "_Command1_132";
			this._Command1_132.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_132.Size = new System.Drawing.Size(31, 17);
			this._Command1_132.TabIndex = 214;
			this._Command1_132.Text = "P4";
			this._Command1_132.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_132.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_132.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_130
			// 
			this._Command1_130.AllowDrop = true;
			this._Command1_130.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_130.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_130.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_130.Location = new System.Drawing.Point(8, 60);
			this._Command1_130.Name = "_Command1_130";
			this._Command1_130.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_130.Size = new System.Drawing.Size(31, 17);
			this._Command1_130.TabIndex = 213;
			this._Command1_130.Text = "P2";
			this._Command1_130.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_130.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_130.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_133
			// 
			this._Command1_133.AllowDrop = true;
			this._Command1_133.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_133.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_133.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_133.Location = new System.Drawing.Point(48, 42);
			this._Command1_133.Name = "_Command1_133";
			this._Command1_133.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_133.Size = new System.Drawing.Size(31, 17);
			this._Command1_133.TabIndex = 212;
			this._Command1_133.Text = "P5";
			this._Command1_133.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_133.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_133.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_128
			// 
			this._Command1_128.AllowDrop = true;
			this._Command1_128.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_128.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_128.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_128.Location = new System.Drawing.Point(8, 24);
			this._Command1_128.Name = "_Command1_128";
			this._Command1_128.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_128.Size = new System.Drawing.Size(31, 17);
			this._Command1_128.TabIndex = 211;
			this._Command1_128.Text = "P0";
			this._Command1_128.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_128.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_128.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_139
			// 
			this._Command1_139.AllowDrop = true;
			this._Command1_139.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_139.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_139.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_139.Location = new System.Drawing.Point(88, 24);
			this._Command1_139.Name = "_Command1_139";
			this._Command1_139.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_139.Size = new System.Drawing.Size(35, 17);
			this._Command1_139.TabIndex = 210;
			this._Command1_139.Text = "Wait";
			this._Command1_139.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_139.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_139.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// Frame13
			// 
			this.Frame13.AllowDrop = true;
			this.Frame13.BackColor = System.Drawing.SystemColors.Control;
			this.Frame13.Controls.Add(this.Label9);
			this.Frame13.Controls.Add(this.Label8);
			this.Frame13.Controls.Add(this.Label7);
			this.Frame13.Controls.Add(this._Command1_197);
			this.Frame13.Controls.Add(this._Command1_192);
			this.Frame13.Controls.Add(this._Command1_187);
			this.Frame13.Controls.Add(this._Command1_182);
			this.Frame13.Controls.Add(this._Command1_177);
			this.Frame13.Controls.Add(this._Command1_175);
			this.Frame13.Controls.Add(this._Command1_172);
			this.Frame13.Controls.Add(this._Command1_170);
			this.Frame13.Controls.Add(this._Command1_165);
			this.Frame13.Controls.Add(this._Command1_160);
			this.Frame13.Controls.Add(this._Command1_152);
			this.Frame13.Controls.Add(this._Command1_147);
			this.Frame13.Controls.Add(this._Command1_196);
			this.Frame13.Controls.Add(this._Command1_195);
			this.Frame13.Controls.Add(this._Command1_194);
			this.Frame13.Controls.Add(this._Command1_191);
			this.Frame13.Controls.Add(this._Command1_190);
			this.Frame13.Controls.Add(this._Command1_189);
			this.Frame13.Controls.Add(this._Command1_186);
			this.Frame13.Controls.Add(this._Command1_185);
			this.Frame13.Controls.Add(this._Command1_184);
			this.Frame13.Controls.Add(this._Command1_181);
			this.Frame13.Controls.Add(this._Command1_180);
			this.Frame13.Controls.Add(this._Command1_179);
			this.Frame13.Controls.Add(this._Command1_176);
			this.Frame13.Controls.Add(this._Command1_174);
			this.Frame13.Controls.Add(this._Command1_171);
			this.Frame13.Controls.Add(this._Command1_169);
			this.Frame13.Controls.Add(this._Command1_166);
			this.Frame13.Controls.Add(this._Command1_164);
			this.Frame13.Controls.Add(this._Command1_161);
			this.Frame13.Controls.Add(this._Command1_159);
			this.Frame13.Controls.Add(this._Command1_153);
			this.Frame13.Controls.Add(this._Command1_151);
			this.Frame13.Controls.Add(this._Command1_148);
			this.Frame13.Controls.Add(this._Command1_146);
			this.Frame13.Enabled = true;
			this.Frame13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Frame13.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame13.Location = new System.Drawing.Point(4, 116);
			this.Frame13.Name = "Frame13";
			this.Frame13.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame13.Size = new System.Drawing.Size(137, 275);
			this.Frame13.TabIndex = 168;
			this.Frame13.Text = "Musical Scale";
			this.Frame13.Visible = true;
			// 
			// Label9
			// 
			this.Label9.AllowDrop = true;
			this.Label9.BackColor = System.Drawing.SystemColors.Control;
			this.Label9.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label9.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label9.Location = new System.Drawing.Point(92, 22);
			this.Label9.Name = "Label9";
			this.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label9.Size = new System.Drawing.Size(37, 13);
			this.Label9.TabIndex = 207;
			this.Label9.Text = "Octive3";
			// 
			// Label8
			// 
			this.Label8.AllowDrop = true;
			this.Label8.BackColor = System.Drawing.SystemColors.Control;
			this.Label8.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label8.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label8.Location = new System.Drawing.Point(48, 22);
			this.Label8.Name = "Label8";
			this.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label8.Size = new System.Drawing.Size(37, 13);
			this.Label8.TabIndex = 206;
			this.Label8.Text = "Octive2";
			// 
			// Label7
			// 
			this.Label7.AllowDrop = true;
			this.Label7.BackColor = System.Drawing.SystemColors.Control;
			this.Label7.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label7.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label7.Location = new System.Drawing.Point(4, 22);
			this.Label7.Name = "Label7";
			this.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label7.Size = new System.Drawing.Size(37, 13);
			this.Label7.TabIndex = 205;
			this.Label7.Text = "Octive1";
			// 
			// _Command1_197
			// 
			this._Command1_197.AllowDrop = true;
			this._Command1_197.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_197.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_197.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_197.Location = new System.Drawing.Point(92, 150);
			this._Command1_197.Name = "_Command1_197";
			this._Command1_197.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_197.Size = new System.Drawing.Size(41, 17);
			this._Command1_197.TabIndex = 204;
			this._Command1_197.Text = "NTF#3";
			this._Command1_197.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_197.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_192
			// 
			this._Command1_192.AllowDrop = true;
			this._Command1_192.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_192.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_192.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_192.Location = new System.Drawing.Point(92, 168);
			this._Command1_192.Name = "_Command1_192";
			this._Command1_192.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_192.Size = new System.Drawing.Size(41, 17);
			this._Command1_192.TabIndex = 203;
			this._Command1_192.Text = "NTG3";
			this._Command1_192.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_192.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_187
			// 
			this._Command1_187.AllowDrop = true;
			this._Command1_187.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_187.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_187.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_187.Location = new System.Drawing.Point(92, 186);
			this._Command1_187.Name = "_Command1_187";
			this._Command1_187.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_187.Size = new System.Drawing.Size(41, 17);
			this._Command1_187.TabIndex = 202;
			this._Command1_187.Text = "NTG#3";
			this._Command1_187.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_187.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_182
			// 
			this._Command1_182.AllowDrop = true;
			this._Command1_182.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_182.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_182.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_182.Location = new System.Drawing.Point(92, 204);
			this._Command1_182.Name = "_Command1_182";
			this._Command1_182.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_182.Size = new System.Drawing.Size(41, 17);
			this._Command1_182.TabIndex = 201;
			this._Command1_182.Text = "NTA3";
			this._Command1_182.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_182.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_177
			// 
			this._Command1_177.AllowDrop = true;
			this._Command1_177.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_177.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_177.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_177.Location = new System.Drawing.Point(92, 222);
			this._Command1_177.Name = "_Command1_177";
			this._Command1_177.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_177.Size = new System.Drawing.Size(41, 17);
			this._Command1_177.TabIndex = 200;
			this._Command1_177.Text = "NTA#3";
			this._Command1_177.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_177.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_175
			// 
			this._Command1_175.AllowDrop = true;
			this._Command1_175.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_175.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_175.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_175.Location = new System.Drawing.Point(92, 42);
			this._Command1_175.Name = "_Command1_175";
			this._Command1_175.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_175.Size = new System.Drawing.Size(41, 17);
			this._Command1_175.TabIndex = 199;
			this._Command1_175.Text = "NTC3";
			this._Command1_175.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_175.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_172
			// 
			this._Command1_172.AllowDrop = true;
			this._Command1_172.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_172.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_172.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_172.Location = new System.Drawing.Point(92, 240);
			this._Command1_172.Name = "_Command1_172";
			this._Command1_172.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_172.Size = new System.Drawing.Size(41, 17);
			this._Command1_172.TabIndex = 198;
			this._Command1_172.Text = "NTB3";
			this._Command1_172.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_172.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_170
			// 
			this._Command1_170.AllowDrop = true;
			this._Command1_170.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_170.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_170.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_170.Location = new System.Drawing.Point(92, 60);
			this._Command1_170.Name = "_Command1_170";
			this._Command1_170.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_170.Size = new System.Drawing.Size(41, 17);
			this._Command1_170.TabIndex = 197;
			this._Command1_170.Text = "NTC#3";
			this._Command1_170.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_170.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_165
			// 
			this._Command1_165.AllowDrop = true;
			this._Command1_165.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_165.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_165.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_165.Location = new System.Drawing.Point(92, 78);
			this._Command1_165.Name = "_Command1_165";
			this._Command1_165.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_165.Size = new System.Drawing.Size(41, 17);
			this._Command1_165.TabIndex = 196;
			this._Command1_165.Text = "NTD3";
			this._Command1_165.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_165.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_160
			// 
			this._Command1_160.AllowDrop = true;
			this._Command1_160.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_160.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_160.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_160.Location = new System.Drawing.Point(92, 96);
			this._Command1_160.Name = "_Command1_160";
			this._Command1_160.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_160.Size = new System.Drawing.Size(41, 17);
			this._Command1_160.TabIndex = 195;
			this._Command1_160.Text = "NTD#3";
			this._Command1_160.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_160.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_152
			// 
			this._Command1_152.AllowDrop = true;
			this._Command1_152.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_152.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_152.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_152.Location = new System.Drawing.Point(92, 114);
			this._Command1_152.Name = "_Command1_152";
			this._Command1_152.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_152.Size = new System.Drawing.Size(41, 17);
			this._Command1_152.TabIndex = 194;
			this._Command1_152.Text = "NTE3";
			this._Command1_152.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_152.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_147
			// 
			this._Command1_147.AllowDrop = true;
			this._Command1_147.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_147.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_147.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_147.Location = new System.Drawing.Point(92, 132);
			this._Command1_147.Name = "_Command1_147";
			this._Command1_147.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_147.Size = new System.Drawing.Size(41, 17);
			this._Command1_147.TabIndex = 193;
			this._Command1_147.Text = "NTF3";
			this._Command1_147.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_147.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_196
			// 
			this._Command1_196.AllowDrop = true;
			this._Command1_196.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_196.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_196.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_196.Location = new System.Drawing.Point(4, 42);
			this._Command1_196.Name = "_Command1_196";
			this._Command1_196.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_196.Size = new System.Drawing.Size(41, 17);
			this._Command1_196.TabIndex = 192;
			this._Command1_196.Text = "NTC1";
			this._Command1_196.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_196.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_195
			// 
			this._Command1_195.AllowDrop = true;
			this._Command1_195.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_195.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_195.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_195.Location = new System.Drawing.Point(48, 186);
			this._Command1_195.Name = "_Command1_195";
			this._Command1_195.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_195.Size = new System.Drawing.Size(41, 17);
			this._Command1_195.TabIndex = 191;
			this._Command1_195.Text = "NTG#2";
			this._Command1_195.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_195.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_194
			// 
			this._Command1_194.AllowDrop = true;
			this._Command1_194.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_194.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_194.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_194.Location = new System.Drawing.Point(4, 222);
			this._Command1_194.Name = "_Command1_194";
			this._Command1_194.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_194.Size = new System.Drawing.Size(41, 17);
			this._Command1_194.TabIndex = 190;
			this._Command1_194.Text = "NTA#1";
			this._Command1_194.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_194.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_191
			// 
			this._Command1_191.AllowDrop = true;
			this._Command1_191.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_191.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_191.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_191.Location = new System.Drawing.Point(4, 60);
			this._Command1_191.Name = "_Command1_191";
			this._Command1_191.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_191.Size = new System.Drawing.Size(41, 17);
			this._Command1_191.TabIndex = 189;
			this._Command1_191.Text = "NTC#1";
			this._Command1_191.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_191.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_190
			// 
			this._Command1_190.AllowDrop = true;
			this._Command1_190.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_190.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_190.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_190.Location = new System.Drawing.Point(48, 204);
			this._Command1_190.Name = "_Command1_190";
			this._Command1_190.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_190.Size = new System.Drawing.Size(41, 17);
			this._Command1_190.TabIndex = 188;
			this._Command1_190.Text = "NTA2";
			this._Command1_190.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_190.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_189
			// 
			this._Command1_189.AllowDrop = true;
			this._Command1_189.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_189.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_189.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_189.Location = new System.Drawing.Point(4, 240);
			this._Command1_189.Name = "_Command1_189";
			this._Command1_189.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_189.Size = new System.Drawing.Size(41, 17);
			this._Command1_189.TabIndex = 187;
			this._Command1_189.Text = "NTB1";
			this._Command1_189.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_189.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_186
			// 
			this._Command1_186.AllowDrop = true;
			this._Command1_186.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_186.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_186.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_186.Location = new System.Drawing.Point(4, 78);
			this._Command1_186.Name = "_Command1_186";
			this._Command1_186.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_186.Size = new System.Drawing.Size(41, 17);
			this._Command1_186.TabIndex = 186;
			this._Command1_186.Text = "NTD1";
			this._Command1_186.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_186.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_185
			// 
			this._Command1_185.AllowDrop = true;
			this._Command1_185.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_185.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_185.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_185.Location = new System.Drawing.Point(48, 222);
			this._Command1_185.Name = "_Command1_185";
			this._Command1_185.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_185.Size = new System.Drawing.Size(41, 17);
			this._Command1_185.TabIndex = 185;
			this._Command1_185.Text = "NTA#2";
			this._Command1_185.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_185.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_184
			// 
			this._Command1_184.AllowDrop = true;
			this._Command1_184.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_184.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_184.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_184.Location = new System.Drawing.Point(48, 42);
			this._Command1_184.Name = "_Command1_184";
			this._Command1_184.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_184.Size = new System.Drawing.Size(41, 17);
			this._Command1_184.TabIndex = 184;
			this._Command1_184.Text = "NTC2";
			this._Command1_184.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_184.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_181
			// 
			this._Command1_181.AllowDrop = true;
			this._Command1_181.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_181.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_181.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_181.Location = new System.Drawing.Point(4, 96);
			this._Command1_181.Name = "_Command1_181";
			this._Command1_181.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_181.Size = new System.Drawing.Size(41, 17);
			this._Command1_181.TabIndex = 183;
			this._Command1_181.Text = "NTD#1";
			this._Command1_181.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_181.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_180
			// 
			this._Command1_180.AllowDrop = true;
			this._Command1_180.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_180.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_180.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_180.Location = new System.Drawing.Point(48, 240);
			this._Command1_180.Name = "_Command1_180";
			this._Command1_180.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_180.Size = new System.Drawing.Size(41, 17);
			this._Command1_180.TabIndex = 182;
			this._Command1_180.Text = "NTB2";
			this._Command1_180.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_180.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_179
			// 
			this._Command1_179.AllowDrop = true;
			this._Command1_179.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_179.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_179.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_179.Location = new System.Drawing.Point(48, 60);
			this._Command1_179.Name = "_Command1_179";
			this._Command1_179.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_179.Size = new System.Drawing.Size(41, 17);
			this._Command1_179.TabIndex = 181;
			this._Command1_179.Text = "NTC#2";
			this._Command1_179.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_179.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_176
			// 
			this._Command1_176.AllowDrop = true;
			this._Command1_176.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_176.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_176.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_176.Location = new System.Drawing.Point(4, 114);
			this._Command1_176.Name = "_Command1_176";
			this._Command1_176.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_176.Size = new System.Drawing.Size(41, 17);
			this._Command1_176.TabIndex = 180;
			this._Command1_176.Text = "NTE1";
			this._Command1_176.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_176.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_174
			// 
			this._Command1_174.AllowDrop = true;
			this._Command1_174.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_174.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_174.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_174.Location = new System.Drawing.Point(48, 78);
			this._Command1_174.Name = "_Command1_174";
			this._Command1_174.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_174.Size = new System.Drawing.Size(41, 17);
			this._Command1_174.TabIndex = 179;
			this._Command1_174.Text = "NTD2";
			this._Command1_174.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_174.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_171
			// 
			this._Command1_171.AllowDrop = true;
			this._Command1_171.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_171.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_171.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_171.Location = new System.Drawing.Point(4, 132);
			this._Command1_171.Name = "_Command1_171";
			this._Command1_171.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_171.Size = new System.Drawing.Size(41, 17);
			this._Command1_171.TabIndex = 178;
			this._Command1_171.Text = "NTF1";
			this._Command1_171.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_171.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_169
			// 
			this._Command1_169.AllowDrop = true;
			this._Command1_169.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_169.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_169.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_169.Location = new System.Drawing.Point(48, 96);
			this._Command1_169.Name = "_Command1_169";
			this._Command1_169.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_169.Size = new System.Drawing.Size(41, 17);
			this._Command1_169.TabIndex = 177;
			this._Command1_169.Text = "NTD#2";
			this._Command1_169.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_169.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_166
			// 
			this._Command1_166.AllowDrop = true;
			this._Command1_166.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_166.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_166.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_166.Location = new System.Drawing.Point(4, 150);
			this._Command1_166.Name = "_Command1_166";
			this._Command1_166.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_166.Size = new System.Drawing.Size(41, 17);
			this._Command1_166.TabIndex = 176;
			this._Command1_166.Text = "NTF#1";
			this._Command1_166.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_166.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_164
			// 
			this._Command1_164.AllowDrop = true;
			this._Command1_164.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_164.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_164.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_164.Location = new System.Drawing.Point(48, 114);
			this._Command1_164.Name = "_Command1_164";
			this._Command1_164.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_164.Size = new System.Drawing.Size(41, 17);
			this._Command1_164.TabIndex = 175;
			this._Command1_164.Text = "NTE2";
			this._Command1_164.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_164.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_161
			// 
			this._Command1_161.AllowDrop = true;
			this._Command1_161.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_161.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_161.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_161.Location = new System.Drawing.Point(4, 168);
			this._Command1_161.Name = "_Command1_161";
			this._Command1_161.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_161.Size = new System.Drawing.Size(41, 17);
			this._Command1_161.TabIndex = 174;
			this._Command1_161.Text = "NTG1";
			this._Command1_161.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_161.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_159
			// 
			this._Command1_159.AllowDrop = true;
			this._Command1_159.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_159.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_159.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_159.Location = new System.Drawing.Point(48, 132);
			this._Command1_159.Name = "_Command1_159";
			this._Command1_159.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_159.Size = new System.Drawing.Size(41, 17);
			this._Command1_159.TabIndex = 173;
			this._Command1_159.Text = "NTF2";
			this._Command1_159.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_159.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_153
			// 
			this._Command1_153.AllowDrop = true;
			this._Command1_153.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_153.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_153.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_153.Location = new System.Drawing.Point(4, 186);
			this._Command1_153.Name = "_Command1_153";
			this._Command1_153.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_153.Size = new System.Drawing.Size(41, 17);
			this._Command1_153.TabIndex = 172;
			this._Command1_153.Text = "NG#1";
			this._Command1_153.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_153.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_151
			// 
			this._Command1_151.AllowDrop = true;
			this._Command1_151.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_151.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_151.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_151.Location = new System.Drawing.Point(48, 150);
			this._Command1_151.Name = "_Command1_151";
			this._Command1_151.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_151.Size = new System.Drawing.Size(41, 17);
			this._Command1_151.TabIndex = 171;
			this._Command1_151.Text = "NTF#2";
			this._Command1_151.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_151.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_148
			// 
			this._Command1_148.AllowDrop = true;
			this._Command1_148.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_148.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_148.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_148.Location = new System.Drawing.Point(4, 204);
			this._Command1_148.Name = "_Command1_148";
			this._Command1_148.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_148.Size = new System.Drawing.Size(41, 17);
			this._Command1_148.TabIndex = 170;
			this._Command1_148.Text = "NTA1";
			this._Command1_148.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_148.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_146
			// 
			this._Command1_146.AllowDrop = true;
			this._Command1_146.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_146.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_146.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_146.Location = new System.Drawing.Point(48, 168);
			this._Command1_146.Name = "_Command1_146";
			this._Command1_146.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_146.Size = new System.Drawing.Size(41, 17);
			this._Command1_146.TabIndex = 169;
			this._Command1_146.Text = "NTG2";
			this._Command1_146.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_146.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// Frame12
			// 
			this.Frame12.AllowDrop = true;
			this.Frame12.BackColor = System.Drawing.SystemColors.Control;
			this.Frame12.Controls.Add(this._Command1_24);
			this.Frame12.Controls.Add(this._Command1_23);
			this.Frame12.Controls.Add(this._Command1_22);
			this.Frame12.Controls.Add(this._Command1_21);
			this.Frame12.Controls.Add(this._Command1_20);
			this.Frame12.Controls.Add(this._Command1_19);
			this.Frame12.Enabled = true;
			this.Frame12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Frame12.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame12.Location = new System.Drawing.Point(658, 4);
			this.Frame12.Name = "Frame12";
			this.Frame12.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame12.Size = new System.Drawing.Size(117, 75);
			this.Frame12.TabIndex = 159;
			this.Frame12.Text = "R's";
			this.Frame12.Visible = true;
			// 
			// _Command1_24
			// 
			this._Command1_24.AllowDrop = true;
			this._Command1_24.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_24.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_24.Location = new System.Drawing.Point(60, 52);
			this._Command1_24.Name = "_Command1_24";
			this._Command1_24.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_24.Size = new System.Drawing.Size(47, 17);
			this._Command1_24.TabIndex = 165;
			this._Command1_24.Text = "OWRR";
			this._Command1_24.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_24.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_24.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_23
			// 
			this._Command1_23.AllowDrop = true;
			this._Command1_23.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_23.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_23.Location = new System.Drawing.Point(60, 34);
			this._Command1_23.Name = "_Command1_23";
			this._Command1_23.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_23.Size = new System.Drawing.Size(47, 17);
			this._Command1_23.TabIndex = 164;
			this._Command1_23.Text = "AWRR";
			this._Command1_23.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_23.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_23.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_22
			// 
			this._Command1_22.AllowDrop = true;
			this._Command1_22.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_22.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_22.Location = new System.Drawing.Point(60, 16);
			this._Command1_22.Name = "_Command1_22";
			this._Command1_22.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_22.Size = new System.Drawing.Size(47, 17);
			this._Command1_22.TabIndex = 163;
			this._Command1_22.Text = "AXRR";
			this._Command1_22.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_22.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_22.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_21
			// 
			this._Command1_21.AllowDrop = true;
			this._Command1_21.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_21.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_21.Location = new System.Drawing.Point(10, 52);
			this._Command1_21.Name = "_Command1_21";
			this._Command1_21.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_21.Size = new System.Drawing.Size(47, 17);
			this._Command1_21.TabIndex = 162;
			this._Command1_21.Text = "EYRR";
			this._Command1_21.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_21.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_21.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_20
			// 
			this._Command1_20.AllowDrop = true;
			this._Command1_20.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_20.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_20.Location = new System.Drawing.Point(10, 34);
			this._Command1_20.Name = "_Command1_20";
			this._Command1_20.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_20.Size = new System.Drawing.Size(47, 17);
			this._Command1_20.TabIndex = 161;
			this._Command1_20.Text = "IYRR";
			this._Command1_20.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_20.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_20.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_19
			// 
			this._Command1_19.AllowDrop = true;
			this._Command1_19.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_19.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_19.Location = new System.Drawing.Point(10, 16);
			this._Command1_19.Name = "_Command1_19";
			this._Command1_19.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_19.Size = new System.Drawing.Size(47, 17);
			this._Command1_19.TabIndex = 160;
			this._Command1_19.Text = "RR";
			this._Command1_19.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_19.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_19.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// Frame11
			// 
			this.Frame11.AllowDrop = true;
			this.Frame11.BackColor = System.Drawing.SystemColors.Control;
			this.Frame11.Controls.Add(this.txtRepeat);
			this.Frame11.Controls.Add(this._Command1_141);
			this.Frame11.Controls.Add(this._Command1_154);
			this.Frame11.Controls.Add(this._Command1_142);
			this.Frame11.Controls.Add(this._Command1_143);
			this.Frame11.Controls.Add(this._Command1_136);
			this.Frame11.Controls.Add(this._Command1_135);
			this.Frame11.Enabled = true;
			this.Frame11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Frame11.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame11.Location = new System.Drawing.Point(676, 290);
			this.Frame11.Name = "Frame11";
			this.Frame11.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame11.Size = new System.Drawing.Size(97, 101);
			this.Frame11.TabIndex = 153;
			this.Frame11.Text = "Modifiers";
			this.Frame11.Visible = true;
			// 
			// txtRepeat
			// 
			this.txtRepeat.AcceptsReturn = true;
			this.txtRepeat.AllowDrop = true;
			this.txtRepeat.BackColor = System.Drawing.SystemColors.Window;
			this.txtRepeat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtRepeat.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtRepeat.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtRepeat.Location = new System.Drawing.Point(62, 72);
			this.txtRepeat.MaxLength = 0;
			this.txtRepeat.Name = "txtRepeat";
			this.txtRepeat.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtRepeat.Size = new System.Drawing.Size(29, 19);
			this.txtRepeat.TabIndex = 8;
			this.txtRepeat.Text = "5";
			// 
			// _Command1_141
			// 
			this._Command1_141.AllowDrop = true;
			this._Command1_141.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_141.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_141.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_141.Location = new System.Drawing.Point(6, 102);
			this._Command1_141.Name = "_Command1_141";
			this._Command1_141.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_141.Size = new System.Drawing.Size(55, 17);
			this._Command1_141.TabIndex = 230;
			this._Command1_141.Text = "Soft";
			this._Command1_141.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_141.Visible = false;
			this._Command1_141.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_141.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_154
			// 
			this._Command1_154.AllowDrop = true;
			this._Command1_154.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_154.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_154.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_154.Location = new System.Drawing.Point(6, 74);
			this._Command1_154.Name = "_Command1_154";
			this._Command1_154.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_154.Size = new System.Drawing.Size(53, 17);
			this._Command1_154.TabIndex = 166;
			this._Command1_154.Text = "Repeat";
			this._Command1_154.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_154.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_154.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_142
			// 
			this._Command1_142.AllowDrop = true;
			this._Command1_142.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_142.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_142.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_142.Location = new System.Drawing.Point(48, 24);
			this._Command1_142.Name = "_Command1_142";
			this._Command1_142.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_142.Size = new System.Drawing.Size(43, 17);
			this._Command1_142.TabIndex = 157;
			this._Command1_142.Text = "Stress";
			this._Command1_142.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_142.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_142.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_143
			// 
			this._Command1_143.AllowDrop = true;
			this._Command1_143.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_143.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_143.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_143.Location = new System.Drawing.Point(48, 44);
			this._Command1_143.Name = "_Command1_143";
			this._Command1_143.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_143.Size = new System.Drawing.Size(43, 17);
			this._Command1_143.TabIndex = 156;
			this._Command1_143.Text = "Relax";
			this._Command1_143.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_143.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_143.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_136
			// 
			this._Command1_136.AllowDrop = true;
			this._Command1_136.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_136.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_136.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_136.Location = new System.Drawing.Point(6, 44);
			this._Command1_136.Name = "_Command1_136";
			this._Command1_136.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_136.Size = new System.Drawing.Size(39, 17);
			this._Command1_136.TabIndex = 155;
			this._Command1_136.Text = "Slow";
			this._Command1_136.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_136.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_136.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_135
			// 
			this._Command1_135.AllowDrop = true;
			this._Command1_135.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_135.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_135.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_135.Location = new System.Drawing.Point(6, 24);
			this._Command1_135.Name = "_Command1_135";
			this._Command1_135.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_135.Size = new System.Drawing.Size(39, 17);
			this._Command1_135.TabIndex = 154;
			this._Command1_135.Text = "Fast";
			this._Command1_135.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_135.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_135.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// Frame10
			// 
			this.Frame10.AllowDrop = true;
			this.Frame10.BackColor = System.Drawing.SystemColors.Control;
			this.Frame10.Controls.Add(this.btnSaySelection);
			this.Frame10.Controls.Add(this.bntSayIt);
			this.Frame10.Controls.Add(this.btnClear);
			this.Frame10.Controls.Add(this.txtSayData);
			this.Frame10.Controls.Add(this.Command2);
			this.Frame10.Controls.Add(this.btnCodes);
			this.Frame10.Enabled = true;
			this.Frame10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Frame10.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame10.Location = new System.Drawing.Point(4, 392);
			this.Frame10.Name = "Frame10";
			this.Frame10.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame10.Size = new System.Drawing.Size(771, 91);
			this.Frame10.TabIndex = 21;
			this.Frame10.Text = "Say Data";
			this.Frame10.Visible = true;
			// 
			// btnSaySelection
			// 
			this.btnSaySelection.AllowDrop = true;
			this.btnSaySelection.BackColor = System.Drawing.SystemColors.Control;
			this.btnSaySelection.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnSaySelection.Location = new System.Drawing.Point(598, 40);
			this.btnSaySelection.Name = "btnSaySelection";
			this.btnSaySelection.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnSaySelection.Size = new System.Drawing.Size(85, 17);
			this.btnSaySelection.TabIndex = 10;
			this.btnSaySelection.Text = "Say Selection";
			this.btnSaySelection.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnSaySelection.UseVisualStyleBackColor = false;
			this.btnSaySelection.Click += new System.EventHandler(this.btnSaySelection_Click);
			// 
			// bntSayIt
			// 
			this.bntSayIt.AllowDrop = true;
			this.bntSayIt.BackColor = System.Drawing.SystemColors.Control;
			this.bntSayIt.ForeColor = System.Drawing.SystemColors.ControlText;
			this.bntSayIt.Location = new System.Drawing.Point(598, 20);
			this.bntSayIt.Name = "bntSayIt";
			this.bntSayIt.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.bntSayIt.Size = new System.Drawing.Size(85, 17);
			this.bntSayIt.TabIndex = 9;
			this.bntSayIt.Text = "Say It";
			this.bntSayIt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.bntSayIt.UseVisualStyleBackColor = false;
			this.bntSayIt.Click += new System.EventHandler(this.bntSayIt_Click);
			// 
			// btnClear
			// 
			this.btnClear.AllowDrop = true;
			this.btnClear.BackColor = System.Drawing.SystemColors.Control;
			this.btnClear.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnClear.Location = new System.Drawing.Point(598, 60);
			this.btnClear.Name = "btnClear";
			this.btnClear.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnClear.Size = new System.Drawing.Size(85, 17);
			this.btnClear.TabIndex = 11;
			this.btnClear.Text = "Clear Say Data";
			this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnClear.UseVisualStyleBackColor = false;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// txtSayData
			// 
			this.txtSayData.AcceptsReturn = true;
			this.txtSayData.AllowDrop = true;
			this.txtSayData.BackColor = System.Drawing.SystemColors.Window;
			this.txtSayData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtSayData.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtSayData.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtSayData.Location = new System.Drawing.Point(8, 14);
			this.txtSayData.MaxLength = 0;
			this.txtSayData.Multiline = true;
			this.txtSayData.Name = "txtSayData";
			this.txtSayData.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtSayData.Size = new System.Drawing.Size(585, 71);
			this.txtSayData.TabIndex = 22;
			// 
			// Command2
			// 
			this.Command2.AllowDrop = true;
			this.Command2.BackColor = System.Drawing.SystemColors.Control;
			this.Command2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Command2.Location = new System.Drawing.Point(688, 40);
			this.Command2.Name = "Command2";
			this.Command2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Command2.Size = new System.Drawing.Size(77, 37);
			this.Command2.TabIndex = 232;
			this.Command2.Text = "View Codes for Selection";
			this.Command2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.Command2.UseVisualStyleBackColor = false;
			this.Command2.Click += new System.EventHandler(this.Command2_Click);
			// 
			// btnCodes
			// 
			this.btnCodes.AllowDrop = true;
			this.btnCodes.BackColor = System.Drawing.SystemColors.Control;
			this.btnCodes.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnCodes.Location = new System.Drawing.Point(688, 20);
			this.btnCodes.Name = "btnCodes";
			this.btnCodes.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnCodes.Size = new System.Drawing.Size(77, 17);
			this.btnCodes.TabIndex = 233;
			this.btnCodes.Text = "View Codes";
			this.btnCodes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnCodes.UseVisualStyleBackColor = false;
			this.btnCodes.Click += new System.EventHandler(this.btnCodes_Click);
			// 
			// Frame9
			// 
			this.Frame9.AllowDrop = true;
			this.Frame9.BackColor = System.Drawing.SystemColors.Control;
			this.Frame9.Controls.Add(this.txtBend);
			this.Frame9.Controls.Add(this.txtPitch);
			this.Frame9.Controls.Add(this.txtSpeed);
			this.Frame9.Controls.Add(this.txtVolume);
			this.Frame9.Controls.Add(this.scVolume);
			this.Frame9.Controls.Add(this.scSpeed);
			this.Frame9.Controls.Add(this.scPitch);
			this.Frame9.Controls.Add(this.scBend);
			this.Frame9.Controls.Add(this.chkApplyControlsBeforeSounds);
			this.Frame9.Controls.Add(this.chkApplyControlsBeforeSayData);
			this.Frame9.Controls.Add(this._Command1_140);
			this.Frame9.Controls.Add(this.lblVolume);
			this.Frame9.Controls.Add(this.lblSpeed);
			this.Frame9.Controls.Add(this.lblPitch);
			this.Frame9.Controls.Add(this.lblBend);
			this.Frame9.Enabled = true;
			this.Frame9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Frame9.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame9.Location = new System.Drawing.Point(144, 290);
			this.Frame9.Name = "Frame9";
			this.Frame9.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame9.Size = new System.Drawing.Size(529, 101);
			this.Frame9.TabIndex = 20;
			this.Frame9.Text = "Controls";
			this.Frame9.Visible = true;
			// 
			// txtBend
			// 
			this.txtBend.AcceptsReturn = true;
			this.txtBend.AllowDrop = true;
			this.txtBend.BackColor = System.Drawing.SystemColors.Window;
			this.txtBend.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtBend.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtBend.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtBend.Location = new System.Drawing.Point(53, 76);
			this.txtBend.MaxLength = 0;
			this.txtBend.Name = "txtBend";
			this.txtBend.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtBend.Size = new System.Drawing.Size(29, 19);
			this.txtBend.TabIndex = 6;
			this.txtBend.Text = "5";
			this.txtBend.Leave += new System.EventHandler(this.txtBend_Leave);
			// 
			// txtPitch
			// 
			this.txtPitch.AcceptsReturn = true;
			this.txtPitch.AllowDrop = true;
			this.txtPitch.BackColor = System.Drawing.SystemColors.Window;
			this.txtPitch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtPitch.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtPitch.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtPitch.Location = new System.Drawing.Point(53, 56);
			this.txtPitch.MaxLength = 0;
			this.txtPitch.Name = "txtPitch";
			this.txtPitch.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtPitch.Size = new System.Drawing.Size(29, 19);
			this.txtPitch.TabIndex = 4;
			this.txtPitch.Text = "5";
			this.txtPitch.Leave += new System.EventHandler(this.txtPitch_Leave);
			// 
			// txtSpeed
			// 
			this.txtSpeed.AcceptsReturn = true;
			this.txtSpeed.AllowDrop = true;
			this.txtSpeed.BackColor = System.Drawing.SystemColors.Window;
			this.txtSpeed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtSpeed.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtSpeed.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtSpeed.Location = new System.Drawing.Point(53, 36);
			this.txtSpeed.MaxLength = 0;
			this.txtSpeed.Name = "txtSpeed";
			this.txtSpeed.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtSpeed.Size = new System.Drawing.Size(29, 19);
			this.txtSpeed.TabIndex = 2;
			this.txtSpeed.Text = "5";
			this.txtSpeed.Leave += new System.EventHandler(this.txtSpeed_Leave);
			// 
			// txtVolume
			// 
			this.txtVolume.AcceptsReturn = true;
			this.txtVolume.AllowDrop = true;
			this.txtVolume.BackColor = System.Drawing.SystemColors.Window;
			this.txtVolume.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtVolume.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtVolume.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtVolume.Location = new System.Drawing.Point(53, 16);
			this.txtVolume.MaxLength = 0;
			this.txtVolume.Name = "txtVolume";
			this.txtVolume.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtVolume.Size = new System.Drawing.Size(29, 19);
			this.txtVolume.TabIndex = 0;
			this.txtVolume.Text = "5";
			this.txtVolume.Leave += new System.EventHandler(this.txtVolume_Leave);
			// 
			// scVolume
			// 
			this.scVolume.AllowDrop = true;
			this.scVolume.CausesValidation = true;
			this.scVolume.Enabled = true;
			this.scVolume.LargeChange = 8;
			this.scVolume.Location = new System.Drawing.Point(88, 16);
			this.scVolume.Maximum = 134;
			this.scVolume.Minimum = 0;
			this.scVolume.Name = "scVolume";
			this.scVolume.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.scVolume.Size = new System.Drawing.Size(277, 17);
			this.scVolume.SmallChange = 1;
			this.scVolume.TabIndex = 1;
			this.scVolume.TabStop = true;
			this.scVolume.Value = 0;
			this.scVolume.Visible = true;
			this.scVolume.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scVolume_Scroll);
			this.scVolume.ValueChanged += new System.EventHandler(this.scVolume_ValueChanged);
			// 
			// scSpeed
			// 
			this.scSpeed.AllowDrop = true;
			this.scSpeed.CausesValidation = true;
			this.scSpeed.Enabled = true;
			this.scSpeed.LargeChange = 8;
			this.scSpeed.Location = new System.Drawing.Point(88, 36);
			this.scSpeed.Maximum = 134;
			this.scSpeed.Minimum = 0;
			this.scSpeed.Name = "scSpeed";
			this.scSpeed.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.scSpeed.Size = new System.Drawing.Size(277, 17);
			this.scSpeed.SmallChange = 1;
			this.scSpeed.TabIndex = 3;
			this.scSpeed.TabStop = true;
			this.scSpeed.Value = 0;
			this.scSpeed.Visible = true;
			this.scSpeed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scSpeed_Scroll);
			this.scSpeed.ValueChanged += new System.EventHandler(this.scSpeed_ValueChanged);
			// 
			// scPitch
			// 
			this.scPitch.AllowDrop = true;
			this.scPitch.CausesValidation = true;
			this.scPitch.Enabled = true;
			this.scPitch.LargeChange = 8;
			this.scPitch.Location = new System.Drawing.Point(88, 56);
			this.scPitch.Maximum = 262;
			this.scPitch.Minimum = 0;
			this.scPitch.Name = "scPitch";
			this.scPitch.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.scPitch.Size = new System.Drawing.Size(277, 17);
			this.scPitch.SmallChange = 1;
			this.scPitch.TabIndex = 5;
			this.scPitch.TabStop = true;
			this.scPitch.Value = 0;
			this.scPitch.Visible = true;
			this.scPitch.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scPitch_Scroll);
			this.scPitch.ValueChanged += new System.EventHandler(this.scPitch_ValueChanged);
			// 
			// scBend
			// 
			this.scBend.AllowDrop = true;
			this.scBend.CausesValidation = true;
			this.scBend.Enabled = true;
			this.scBend.LargeChange = 1;
			this.scBend.Location = new System.Drawing.Point(88, 76);
			this.scBend.Maximum = 15;
			this.scBend.Minimum = 0;
			this.scBend.Name = "scBend";
			this.scBend.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.scBend.Size = new System.Drawing.Size(277, 17);
			this.scBend.SmallChange = 1;
			this.scBend.TabIndex = 7;
			this.scBend.TabStop = true;
			this.scBend.Value = 0;
			this.scBend.Visible = true;
			this.scBend.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scBend_Scroll);
			this.scBend.ValueChanged += new System.EventHandler(this.scBend_ValueChanged);
			// 
			// chkApplyControlsBeforeSounds
			// 
			this.chkApplyControlsBeforeSounds.AllowDrop = true;
			this.chkApplyControlsBeforeSounds.Appearance = System.Windows.Forms.Appearance.Normal;
			this.chkApplyControlsBeforeSounds.BackColor = System.Drawing.SystemColors.Control;
			this.chkApplyControlsBeforeSounds.CausesValidation = true;
			this.chkApplyControlsBeforeSounds.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.chkApplyControlsBeforeSounds.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkApplyControlsBeforeSounds.Enabled = true;
			this.chkApplyControlsBeforeSounds.ForeColor = System.Drawing.SystemColors.ControlText;
			this.chkApplyControlsBeforeSounds.Location = new System.Drawing.Point(372, 12);
			this.chkApplyControlsBeforeSounds.Name = "chkApplyControlsBeforeSounds";
			this.chkApplyControlsBeforeSounds.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.chkApplyControlsBeforeSounds.Size = new System.Drawing.Size(149, 29);
			this.chkApplyControlsBeforeSounds.TabIndex = 151;
			this.chkApplyControlsBeforeSounds.TabStop = true;
			this.chkApplyControlsBeforeSounds.Text = "Apply Controls Before Playing Individual Sounds";
			this.chkApplyControlsBeforeSounds.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.chkApplyControlsBeforeSounds.Visible = true;
			// 
			// chkApplyControlsBeforeSayData
			// 
			this.chkApplyControlsBeforeSayData.AllowDrop = true;
			this.chkApplyControlsBeforeSayData.Appearance = System.Windows.Forms.Appearance.Normal;
			this.chkApplyControlsBeforeSayData.BackColor = System.Drawing.SystemColors.Control;
			this.chkApplyControlsBeforeSayData.CausesValidation = true;
			this.chkApplyControlsBeforeSayData.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.chkApplyControlsBeforeSayData.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkApplyControlsBeforeSayData.Enabled = true;
			this.chkApplyControlsBeforeSayData.ForeColor = System.Drawing.SystemColors.ControlText;
			this.chkApplyControlsBeforeSayData.Location = new System.Drawing.Point(372, 44);
			this.chkApplyControlsBeforeSayData.Name = "chkApplyControlsBeforeSayData";
			this.chkApplyControlsBeforeSayData.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.chkApplyControlsBeforeSayData.Size = new System.Drawing.Size(141, 25);
			this.chkApplyControlsBeforeSayData.TabIndex = 152;
			this.chkApplyControlsBeforeSayData.TabStop = true;
			this.chkApplyControlsBeforeSayData.Text = "Apply Controls Before Playing 'Say Data'";
			this.chkApplyControlsBeforeSayData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.chkApplyControlsBeforeSayData.Visible = true;
			// 
			// _Command1_140
			// 
			this._Command1_140.AllowDrop = true;
			this._Command1_140.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_140.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_140.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_140.Location = new System.Drawing.Point(392, 76);
			this._Command1_140.Name = "_Command1_140";
			this._Command1_140.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_140.Size = new System.Drawing.Size(43, 17);
			this._Command1_140.TabIndex = 208;
			this._Command1_140.Text = "Reset";
			this._Command1_140.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_140.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_140.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// lblVolume
			// 
			this.lblVolume.AllowDrop = true;
			this.lblVolume.BackColor = System.Drawing.SystemColors.Window;
			this.lblVolume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblVolume.ForeColor = System.Drawing.SystemColors.WindowText;
			this.lblVolume.Location = new System.Drawing.Point(8, 16);
			this.lblVolume.Name = "lblVolume";
			this.lblVolume.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblVolume.Size = new System.Drawing.Size(45, 17);
			this.lblVolume.TabIndex = 150;
			this.lblVolume.Text = "Volume";
			this.lblVolume.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.lblVolume.DoubleClick += new System.EventHandler(this.lblVolume_DoubleClick);
			// 
			// lblSpeed
			// 
			this.lblSpeed.AllowDrop = true;
			this.lblSpeed.BackColor = System.Drawing.SystemColors.Window;
			this.lblSpeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblSpeed.ForeColor = System.Drawing.SystemColors.WindowText;
			this.lblSpeed.Location = new System.Drawing.Point(8, 36);
			this.lblSpeed.Name = "lblSpeed";
			this.lblSpeed.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblSpeed.Size = new System.Drawing.Size(45, 17);
			this.lblSpeed.TabIndex = 149;
			this.lblSpeed.Text = "Speed";
			this.lblSpeed.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.lblSpeed.DoubleClick += new System.EventHandler(this.lblSpeed_DoubleClick);
			// 
			// lblPitch
			// 
			this.lblPitch.AllowDrop = true;
			this.lblPitch.BackColor = System.Drawing.SystemColors.Window;
			this.lblPitch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblPitch.ForeColor = System.Drawing.SystemColors.WindowText;
			this.lblPitch.Location = new System.Drawing.Point(8, 56);
			this.lblPitch.Name = "lblPitch";
			this.lblPitch.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblPitch.Size = new System.Drawing.Size(45, 17);
			this.lblPitch.TabIndex = 148;
			this.lblPitch.Text = "Pitch";
			this.lblPitch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.lblPitch.DoubleClick += new System.EventHandler(this.lblPitch_DoubleClick);
			// 
			// lblBend
			// 
			this.lblBend.AllowDrop = true;
			this.lblBend.BackColor = System.Drawing.SystemColors.Window;
			this.lblBend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblBend.ForeColor = System.Drawing.SystemColors.WindowText;
			this.lblBend.Location = new System.Drawing.Point(8, 76);
			this.lblBend.Name = "lblBend";
			this.lblBend.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblBend.Size = new System.Drawing.Size(45, 17);
			this.lblBend.TabIndex = 147;
			this.lblBend.Text = "Bend";
			this.lblBend.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.lblBend.DoubleClick += new System.EventHandler(this.lblBend_DoubleClick);
			// 
			// Frame8
			// 
			this.Frame8.AllowDrop = true;
			this.Frame8.BackColor = System.Drawing.SystemColors.Control;
			this.Frame8.Controls.Add(this._Command1_126);
			this.Frame8.Controls.Add(this._Command1_123);
			this.Frame8.Controls.Add(this._Command1_122);
			this.Frame8.Controls.Add(this._Command1_91);
			this.Frame8.Controls.Add(this._Command1_101);
			this.Frame8.Controls.Add(this._Command1_81);
			this.Frame8.Controls.Add(this._Command1_111);
			this.Frame8.Controls.Add(this._Command1_121);
			this.Frame8.Controls.Add(this._Command1_90);
			this.Frame8.Controls.Add(this._Command1_100);
			this.Frame8.Controls.Add(this._Command1_80);
			this.Frame8.Controls.Add(this._Command1_110);
			this.Frame8.Controls.Add(this._Command1_120);
			this.Frame8.Controls.Add(this._Command1_89);
			this.Frame8.Controls.Add(this._Command1_99);
			this.Frame8.Controls.Add(this._Command1_79);
			this.Frame8.Controls.Add(this._Command1_109);
			this.Frame8.Controls.Add(this._Command1_119);
			this.Frame8.Controls.Add(this._Command1_88);
			this.Frame8.Controls.Add(this._Command1_98);
			this.Frame8.Controls.Add(this._Command1_78);
			this.Frame8.Controls.Add(this._Command1_108);
			this.Frame8.Controls.Add(this._Command1_118);
			this.Frame8.Controls.Add(this._Command1_87);
			this.Frame8.Controls.Add(this._Command1_97);
			this.Frame8.Controls.Add(this._Command1_77);
			this.Frame8.Controls.Add(this._Command1_107);
			this.Frame8.Controls.Add(this._Command1_117);
			this.Frame8.Controls.Add(this._Command1_86);
			this.Frame8.Controls.Add(this._Command1_96);
			this.Frame8.Controls.Add(this._Command1_76);
			this.Frame8.Controls.Add(this._Command1_106);
			this.Frame8.Controls.Add(this._Command1_116);
			this.Frame8.Controls.Add(this._Command1_85);
			this.Frame8.Controls.Add(this._Command1_95);
			this.Frame8.Controls.Add(this._Command1_75);
			this.Frame8.Controls.Add(this._Command1_105);
			this.Frame8.Controls.Add(this._Command1_115);
			this.Frame8.Controls.Add(this._Command1_84);
			this.Frame8.Controls.Add(this._Command1_94);
			this.Frame8.Controls.Add(this._Command1_74);
			this.Frame8.Controls.Add(this._Command1_104);
			this.Frame8.Controls.Add(this._Command1_114);
			this.Frame8.Controls.Add(this._Command1_83);
			this.Frame8.Controls.Add(this._Command1_93);
			this.Frame8.Controls.Add(this._Command1_73);
			this.Frame8.Controls.Add(this._Command1_103);
			this.Frame8.Controls.Add(this._Command1_113);
			this.Frame8.Controls.Add(this._Command1_82);
			this.Frame8.Controls.Add(this._Command1_92);
			this.Frame8.Controls.Add(this._Command1_72);
			this.Frame8.Controls.Add(this._Command1_102);
			this.Frame8.Controls.Add(this._Command1_112);
			this.Frame8.Controls.Add(this.Label3);
			this.Frame8.Controls.Add(this.Label4);
			this.Frame8.Controls.Add(this.Label5);
			this.Frame8.Controls.Add(this.Label2);
			this.Frame8.Controls.Add(this.Label6);
			this.Frame8.Controls.Add(this._Command1_124);
			this.Frame8.Controls.Add(this._Command1_125);
			this.Frame8.Enabled = true;
			this.Frame8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Frame8.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame8.Location = new System.Drawing.Point(144, 176);
			this.Frame8.Name = "Frame8";
			this.Frame8.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame8.Size = new System.Drawing.Size(529, 113);
			this.Frame8.TabIndex = 19;
			this.Frame8.Text = "Misc Sounds";
			this.Frame8.Visible = true;
			// 
			// _Command1_126
			// 
			this._Command1_126.AllowDrop = true;
			this._Command1_126.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_126.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_126.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_126.Location = new System.Drawing.Point(472, 64);
			this._Command1_126.Name = "_Command1_126";
			this._Command1_126.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_126.Size = new System.Drawing.Size(31, 17);
			this._Command1_126.TabIndex = 158;
			this._Command1_126.Text = "M2";
			this._Command1_126.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_126.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_126.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_123
			// 
			this._Command1_123.AllowDrop = true;
			this._Command1_123.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_123.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_123.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_123.Location = new System.Drawing.Point(488, 88);
			this._Command1_123.Name = "_Command1_123";
			this._Command1_123.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_123.Size = new System.Drawing.Size(35, 17);
			this._Command1_123.TabIndex = 90;
			this._Command1_123.Text = "D11";
			this._Command1_123.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_123.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_123.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_122
			// 
			this._Command1_122.AllowDrop = true;
			this._Command1_122.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_122.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_122.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_122.Location = new System.Drawing.Point(450, 88);
			this._Command1_122.Name = "_Command1_122";
			this._Command1_122.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_122.Size = new System.Drawing.Size(35, 17);
			this._Command1_122.TabIndex = 91;
			this._Command1_122.Text = "D10";
			this._Command1_122.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_122.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_122.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_91
			// 
			this._Command1_91.AllowDrop = true;
			this._Command1_91.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_91.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_91.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_91.Location = new System.Drawing.Point(412, 34);
			this._Command1_91.Name = "_Command1_91";
			this._Command1_91.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_91.Size = new System.Drawing.Size(35, 17);
			this._Command1_91.TabIndex = 137;
			this._Command1_91.Text = "A9";
			this._Command1_91.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_91.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_91.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_101
			// 
			this._Command1_101.AllowDrop = true;
			this._Command1_101.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_101.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_101.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_101.Location = new System.Drawing.Point(412, 52);
			this._Command1_101.Name = "_Command1_101";
			this._Command1_101.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_101.Size = new System.Drawing.Size(35, 17);
			this._Command1_101.TabIndex = 136;
			this._Command1_101.Text = "B9";
			this._Command1_101.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_101.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_101.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_81
			// 
			this._Command1_81.AllowDrop = true;
			this._Command1_81.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_81.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_81.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_81.Location = new System.Drawing.Point(412, 16);
			this._Command1_81.Name = "_Command1_81";
			this._Command1_81.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_81.Size = new System.Drawing.Size(35, 17);
			this._Command1_81.TabIndex = 117;
			this._Command1_81.Text = "R9";
			this._Command1_81.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_81.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_81.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_111
			// 
			this._Command1_111.AllowDrop = true;
			this._Command1_111.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_111.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_111.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_111.Location = new System.Drawing.Point(412, 70);
			this._Command1_111.Name = "_Command1_111";
			this._Command1_111.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_111.Size = new System.Drawing.Size(35, 17);
			this._Command1_111.TabIndex = 103;
			this._Command1_111.Text = "C9";
			this._Command1_111.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_111.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_111.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_121
			// 
			this._Command1_121.AllowDrop = true;
			this._Command1_121.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_121.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_121.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_121.Location = new System.Drawing.Point(412, 88);
			this._Command1_121.Name = "_Command1_121";
			this._Command1_121.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_121.Size = new System.Drawing.Size(35, 17);
			this._Command1_121.TabIndex = 92;
			this._Command1_121.Text = "D9";
			this._Command1_121.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_121.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_121.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_90
			// 
			this._Command1_90.AllowDrop = true;
			this._Command1_90.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_90.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_90.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_90.Location = new System.Drawing.Point(374, 34);
			this._Command1_90.Name = "_Command1_90";
			this._Command1_90.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_90.Size = new System.Drawing.Size(35, 17);
			this._Command1_90.TabIndex = 143;
			this._Command1_90.Text = "A8";
			this._Command1_90.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_90.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_90.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_100
			// 
			this._Command1_100.AllowDrop = true;
			this._Command1_100.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_100.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_100.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_100.Location = new System.Drawing.Point(374, 52);
			this._Command1_100.Name = "_Command1_100";
			this._Command1_100.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_100.Size = new System.Drawing.Size(35, 17);
			this._Command1_100.TabIndex = 130;
			this._Command1_100.Text = "B8";
			this._Command1_100.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_100.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_100.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_80
			// 
			this._Command1_80.AllowDrop = true;
			this._Command1_80.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_80.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_80.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_80.Location = new System.Drawing.Point(374, 16);
			this._Command1_80.Name = "_Command1_80";
			this._Command1_80.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_80.Size = new System.Drawing.Size(35, 17);
			this._Command1_80.TabIndex = 123;
			this._Command1_80.Text = "R8";
			this._Command1_80.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_80.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_80.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_110
			// 
			this._Command1_110.AllowDrop = true;
			this._Command1_110.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_110.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_110.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_110.Location = new System.Drawing.Point(374, 70);
			this._Command1_110.Name = "_Command1_110";
			this._Command1_110.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_110.Size = new System.Drawing.Size(35, 17);
			this._Command1_110.TabIndex = 109;
			this._Command1_110.Text = "C8";
			this._Command1_110.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_110.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_110.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_120
			// 
			this._Command1_120.AllowDrop = true;
			this._Command1_120.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_120.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_120.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_120.Location = new System.Drawing.Point(374, 88);
			this._Command1_120.Name = "_Command1_120";
			this._Command1_120.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_120.Size = new System.Drawing.Size(35, 17);
			this._Command1_120.TabIndex = 93;
			this._Command1_120.Text = "D8";
			this._Command1_120.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_120.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_120.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_89
			// 
			this._Command1_89.AllowDrop = true;
			this._Command1_89.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_89.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_89.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_89.Location = new System.Drawing.Point(336, 34);
			this._Command1_89.Name = "_Command1_89";
			this._Command1_89.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_89.Size = new System.Drawing.Size(35, 17);
			this._Command1_89.TabIndex = 142;
			this._Command1_89.Text = "A7";
			this._Command1_89.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_89.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_89.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_99
			// 
			this._Command1_99.AllowDrop = true;
			this._Command1_99.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_99.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_99.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_99.Location = new System.Drawing.Point(336, 52);
			this._Command1_99.Name = "_Command1_99";
			this._Command1_99.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_99.Size = new System.Drawing.Size(35, 17);
			this._Command1_99.TabIndex = 131;
			this._Command1_99.Text = "B7";
			this._Command1_99.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_99.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_99.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_79
			// 
			this._Command1_79.AllowDrop = true;
			this._Command1_79.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_79.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_79.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_79.Location = new System.Drawing.Point(336, 16);
			this._Command1_79.Name = "_Command1_79";
			this._Command1_79.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_79.Size = new System.Drawing.Size(35, 17);
			this._Command1_79.TabIndex = 122;
			this._Command1_79.Text = "R7";
			this._Command1_79.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_79.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_79.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_109
			// 
			this._Command1_109.AllowDrop = true;
			this._Command1_109.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_109.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_109.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_109.Location = new System.Drawing.Point(336, 70);
			this._Command1_109.Name = "_Command1_109";
			this._Command1_109.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_109.Size = new System.Drawing.Size(35, 17);
			this._Command1_109.TabIndex = 108;
			this._Command1_109.Text = "C7";
			this._Command1_109.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_109.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_109.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_119
			// 
			this._Command1_119.AllowDrop = true;
			this._Command1_119.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_119.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_119.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_119.Location = new System.Drawing.Point(336, 88);
			this._Command1_119.Name = "_Command1_119";
			this._Command1_119.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_119.Size = new System.Drawing.Size(35, 17);
			this._Command1_119.TabIndex = 94;
			this._Command1_119.Text = "D7";
			this._Command1_119.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_119.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_119.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_88
			// 
			this._Command1_88.AllowDrop = true;
			this._Command1_88.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_88.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_88.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_88.Location = new System.Drawing.Point(298, 34);
			this._Command1_88.Name = "_Command1_88";
			this._Command1_88.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_88.Size = new System.Drawing.Size(35, 17);
			this._Command1_88.TabIndex = 141;
			this._Command1_88.Text = "A6";
			this._Command1_88.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_88.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_88.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_98
			// 
			this._Command1_98.AllowDrop = true;
			this._Command1_98.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_98.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_98.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_98.Location = new System.Drawing.Point(298, 52);
			this._Command1_98.Name = "_Command1_98";
			this._Command1_98.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_98.Size = new System.Drawing.Size(35, 17);
			this._Command1_98.TabIndex = 132;
			this._Command1_98.Text = "B6";
			this._Command1_98.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_98.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_98.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_78
			// 
			this._Command1_78.AllowDrop = true;
			this._Command1_78.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_78.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_78.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_78.Location = new System.Drawing.Point(298, 16);
			this._Command1_78.Name = "_Command1_78";
			this._Command1_78.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_78.Size = new System.Drawing.Size(35, 17);
			this._Command1_78.TabIndex = 121;
			this._Command1_78.Text = "R6";
			this._Command1_78.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_78.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_78.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_108
			// 
			this._Command1_108.AllowDrop = true;
			this._Command1_108.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_108.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_108.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_108.Location = new System.Drawing.Point(298, 70);
			this._Command1_108.Name = "_Command1_108";
			this._Command1_108.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_108.Size = new System.Drawing.Size(35, 17);
			this._Command1_108.TabIndex = 107;
			this._Command1_108.Text = "C6";
			this._Command1_108.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_108.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_108.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_118
			// 
			this._Command1_118.AllowDrop = true;
			this._Command1_118.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_118.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_118.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_118.Location = new System.Drawing.Point(298, 88);
			this._Command1_118.Name = "_Command1_118";
			this._Command1_118.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_118.Size = new System.Drawing.Size(35, 17);
			this._Command1_118.TabIndex = 95;
			this._Command1_118.Text = "D6";
			this._Command1_118.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_118.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_118.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_87
			// 
			this._Command1_87.AllowDrop = true;
			this._Command1_87.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_87.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_87.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_87.Location = new System.Drawing.Point(260, 34);
			this._Command1_87.Name = "_Command1_87";
			this._Command1_87.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_87.Size = new System.Drawing.Size(35, 17);
			this._Command1_87.TabIndex = 146;
			this._Command1_87.Text = "A5";
			this._Command1_87.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_87.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_87.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_97
			// 
			this._Command1_97.AllowDrop = true;
			this._Command1_97.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_97.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_97.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_97.Location = new System.Drawing.Point(260, 52);
			this._Command1_97.Name = "_Command1_97";
			this._Command1_97.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_97.Size = new System.Drawing.Size(35, 17);
			this._Command1_97.TabIndex = 127;
			this._Command1_97.Text = "B5";
			this._Command1_97.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_97.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_97.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_77
			// 
			this._Command1_77.AllowDrop = true;
			this._Command1_77.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_77.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_77.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_77.Location = new System.Drawing.Point(260, 16);
			this._Command1_77.Name = "_Command1_77";
			this._Command1_77.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_77.Size = new System.Drawing.Size(35, 17);
			this._Command1_77.TabIndex = 126;
			this._Command1_77.Text = "R5";
			this._Command1_77.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_77.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_77.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_107
			// 
			this._Command1_107.AllowDrop = true;
			this._Command1_107.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_107.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_107.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_107.Location = new System.Drawing.Point(260, 70);
			this._Command1_107.Name = "_Command1_107";
			this._Command1_107.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_107.Size = new System.Drawing.Size(35, 17);
			this._Command1_107.TabIndex = 112;
			this._Command1_107.Text = "C5";
			this._Command1_107.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_107.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_107.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_117
			// 
			this._Command1_117.AllowDrop = true;
			this._Command1_117.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_117.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_117.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_117.Location = new System.Drawing.Point(260, 88);
			this._Command1_117.Name = "_Command1_117";
			this._Command1_117.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_117.Size = new System.Drawing.Size(35, 17);
			this._Command1_117.TabIndex = 96;
			this._Command1_117.Text = "D5";
			this._Command1_117.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_117.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_117.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_86
			// 
			this._Command1_86.AllowDrop = true;
			this._Command1_86.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_86.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_86.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_86.Location = new System.Drawing.Point(222, 34);
			this._Command1_86.Name = "_Command1_86";
			this._Command1_86.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_86.Size = new System.Drawing.Size(35, 17);
			this._Command1_86.TabIndex = 145;
			this._Command1_86.Text = "A4";
			this._Command1_86.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_86.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_86.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_96
			// 
			this._Command1_96.AllowDrop = true;
			this._Command1_96.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_96.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_96.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_96.Location = new System.Drawing.Point(222, 52);
			this._Command1_96.Name = "_Command1_96";
			this._Command1_96.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_96.Size = new System.Drawing.Size(35, 17);
			this._Command1_96.TabIndex = 128;
			this._Command1_96.Text = "B4";
			this._Command1_96.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_96.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_96.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_76
			// 
			this._Command1_76.AllowDrop = true;
			this._Command1_76.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_76.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_76.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_76.Location = new System.Drawing.Point(222, 16);
			this._Command1_76.Name = "_Command1_76";
			this._Command1_76.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_76.Size = new System.Drawing.Size(35, 17);
			this._Command1_76.TabIndex = 125;
			this._Command1_76.Text = "R4";
			this._Command1_76.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_76.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_76.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_106
			// 
			this._Command1_106.AllowDrop = true;
			this._Command1_106.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_106.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_106.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_106.Location = new System.Drawing.Point(222, 70);
			this._Command1_106.Name = "_Command1_106";
			this._Command1_106.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_106.Size = new System.Drawing.Size(35, 17);
			this._Command1_106.TabIndex = 111;
			this._Command1_106.Text = "C4";
			this._Command1_106.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_106.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_106.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_116
			// 
			this._Command1_116.AllowDrop = true;
			this._Command1_116.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_116.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_116.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_116.Location = new System.Drawing.Point(222, 88);
			this._Command1_116.Name = "_Command1_116";
			this._Command1_116.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_116.Size = new System.Drawing.Size(35, 17);
			this._Command1_116.TabIndex = 97;
			this._Command1_116.Text = "D4";
			this._Command1_116.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_116.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_116.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_85
			// 
			this._Command1_85.AllowDrop = true;
			this._Command1_85.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_85.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_85.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_85.Location = new System.Drawing.Point(184, 34);
			this._Command1_85.Name = "_Command1_85";
			this._Command1_85.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_85.Size = new System.Drawing.Size(35, 17);
			this._Command1_85.TabIndex = 144;
			this._Command1_85.Text = "A3";
			this._Command1_85.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_85.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_85.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_95
			// 
			this._Command1_95.AllowDrop = true;
			this._Command1_95.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_95.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_95.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_95.Location = new System.Drawing.Point(184, 52);
			this._Command1_95.Name = "_Command1_95";
			this._Command1_95.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_95.Size = new System.Drawing.Size(35, 17);
			this._Command1_95.TabIndex = 129;
			this._Command1_95.Text = "B3";
			this._Command1_95.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_95.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_95.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_75
			// 
			this._Command1_75.AllowDrop = true;
			this._Command1_75.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_75.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_75.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_75.Location = new System.Drawing.Point(184, 16);
			this._Command1_75.Name = "_Command1_75";
			this._Command1_75.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_75.Size = new System.Drawing.Size(35, 17);
			this._Command1_75.TabIndex = 124;
			this._Command1_75.Text = "R3";
			this._Command1_75.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_75.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_75.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_105
			// 
			this._Command1_105.AllowDrop = true;
			this._Command1_105.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_105.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_105.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_105.Location = new System.Drawing.Point(184, 70);
			this._Command1_105.Name = "_Command1_105";
			this._Command1_105.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_105.Size = new System.Drawing.Size(35, 17);
			this._Command1_105.TabIndex = 110;
			this._Command1_105.Text = "C3";
			this._Command1_105.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_105.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_105.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_115
			// 
			this._Command1_115.AllowDrop = true;
			this._Command1_115.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_115.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_115.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_115.Location = new System.Drawing.Point(184, 88);
			this._Command1_115.Name = "_Command1_115";
			this._Command1_115.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_115.Size = new System.Drawing.Size(35, 17);
			this._Command1_115.TabIndex = 98;
			this._Command1_115.Text = "D3";
			this._Command1_115.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_115.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_115.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_84
			// 
			this._Command1_84.AllowDrop = true;
			this._Command1_84.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_84.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_84.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_84.Location = new System.Drawing.Point(146, 34);
			this._Command1_84.Name = "_Command1_84";
			this._Command1_84.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_84.Size = new System.Drawing.Size(35, 17);
			this._Command1_84.TabIndex = 140;
			this._Command1_84.Text = "A2";
			this._Command1_84.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_84.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_84.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_94
			// 
			this._Command1_94.AllowDrop = true;
			this._Command1_94.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_94.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_94.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_94.Location = new System.Drawing.Point(146, 52);
			this._Command1_94.Name = "_Command1_94";
			this._Command1_94.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_94.Size = new System.Drawing.Size(35, 17);
			this._Command1_94.TabIndex = 133;
			this._Command1_94.Text = "B2";
			this._Command1_94.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_94.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_94.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_74
			// 
			this._Command1_74.AllowDrop = true;
			this._Command1_74.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_74.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_74.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_74.Location = new System.Drawing.Point(146, 16);
			this._Command1_74.Name = "_Command1_74";
			this._Command1_74.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_74.Size = new System.Drawing.Size(35, 17);
			this._Command1_74.TabIndex = 120;
			this._Command1_74.Text = "R2";
			this._Command1_74.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_74.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_74.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_104
			// 
			this._Command1_104.AllowDrop = true;
			this._Command1_104.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_104.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_104.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_104.Location = new System.Drawing.Point(146, 70);
			this._Command1_104.Name = "_Command1_104";
			this._Command1_104.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_104.Size = new System.Drawing.Size(35, 17);
			this._Command1_104.TabIndex = 106;
			this._Command1_104.Text = "C2";
			this._Command1_104.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_104.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_104.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_114
			// 
			this._Command1_114.AllowDrop = true;
			this._Command1_114.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_114.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_114.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_114.Location = new System.Drawing.Point(146, 88);
			this._Command1_114.Name = "_Command1_114";
			this._Command1_114.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_114.Size = new System.Drawing.Size(35, 17);
			this._Command1_114.TabIndex = 99;
			this._Command1_114.Text = "D2";
			this._Command1_114.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_114.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_114.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_83
			// 
			this._Command1_83.AllowDrop = true;
			this._Command1_83.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_83.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_83.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_83.Location = new System.Drawing.Point(108, 34);
			this._Command1_83.Name = "_Command1_83";
			this._Command1_83.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_83.Size = new System.Drawing.Size(35, 17);
			this._Command1_83.TabIndex = 139;
			this._Command1_83.Text = "A1";
			this._Command1_83.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_83.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_83.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_93
			// 
			this._Command1_93.AllowDrop = true;
			this._Command1_93.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_93.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_93.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_93.Location = new System.Drawing.Point(108, 52);
			this._Command1_93.Name = "_Command1_93";
			this._Command1_93.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_93.Size = new System.Drawing.Size(35, 17);
			this._Command1_93.TabIndex = 134;
			this._Command1_93.Text = "B1";
			this._Command1_93.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_93.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_93.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_73
			// 
			this._Command1_73.AllowDrop = true;
			this._Command1_73.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_73.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_73.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_73.Location = new System.Drawing.Point(108, 16);
			this._Command1_73.Name = "_Command1_73";
			this._Command1_73.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_73.Size = new System.Drawing.Size(35, 17);
			this._Command1_73.TabIndex = 119;
			this._Command1_73.Text = "R1";
			this._Command1_73.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_73.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_73.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_103
			// 
			this._Command1_103.AllowDrop = true;
			this._Command1_103.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_103.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_103.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_103.Location = new System.Drawing.Point(108, 70);
			this._Command1_103.Name = "_Command1_103";
			this._Command1_103.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_103.Size = new System.Drawing.Size(35, 17);
			this._Command1_103.TabIndex = 105;
			this._Command1_103.Text = "C1";
			this._Command1_103.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_103.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_103.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_113
			// 
			this._Command1_113.AllowDrop = true;
			this._Command1_113.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_113.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_113.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_113.Location = new System.Drawing.Point(108, 88);
			this._Command1_113.Name = "_Command1_113";
			this._Command1_113.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_113.Size = new System.Drawing.Size(35, 17);
			this._Command1_113.TabIndex = 100;
			this._Command1_113.Text = "D1";
			this._Command1_113.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_113.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_113.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_82
			// 
			this._Command1_82.AllowDrop = true;
			this._Command1_82.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_82.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_82.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_82.Location = new System.Drawing.Point(70, 34);
			this._Command1_82.Name = "_Command1_82";
			this._Command1_82.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_82.Size = new System.Drawing.Size(35, 17);
			this._Command1_82.TabIndex = 138;
			this._Command1_82.Text = "A0";
			this._Command1_82.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_82.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_82.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_92
			// 
			this._Command1_92.AllowDrop = true;
			this._Command1_92.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_92.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_92.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_92.Location = new System.Drawing.Point(70, 52);
			this._Command1_92.Name = "_Command1_92";
			this._Command1_92.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_92.Size = new System.Drawing.Size(35, 17);
			this._Command1_92.TabIndex = 135;
			this._Command1_92.Text = "B0";
			this._Command1_92.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_92.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_92.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_72
			// 
			this._Command1_72.AllowDrop = true;
			this._Command1_72.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_72.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_72.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_72.Location = new System.Drawing.Point(70, 16);
			this._Command1_72.Name = "_Command1_72";
			this._Command1_72.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_72.Size = new System.Drawing.Size(35, 17);
			this._Command1_72.TabIndex = 118;
			this._Command1_72.Text = "R0";
			this._Command1_72.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_72.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_72.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_102
			// 
			this._Command1_102.AllowDrop = true;
			this._Command1_102.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_102.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_102.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_102.Location = new System.Drawing.Point(70, 70);
			this._Command1_102.Name = "_Command1_102";
			this._Command1_102.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_102.Size = new System.Drawing.Size(35, 17);
			this._Command1_102.TabIndex = 104;
			this._Command1_102.Text = "C0";
			this._Command1_102.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_102.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_102.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_112
			// 
			this._Command1_112.AllowDrop = true;
			this._Command1_112.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_112.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_112.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_112.Location = new System.Drawing.Point(70, 88);
			this._Command1_112.Name = "_Command1_112";
			this._Command1_112.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_112.Size = new System.Drawing.Size(35, 17);
			this._Command1_112.TabIndex = 102;
			this._Command1_112.Text = "D0";
			this._Command1_112.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_112.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_112.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// Label3
			// 
			this.Label3.AllowDrop = true;
			this.Label3.BackColor = System.Drawing.SystemColors.Control;
			this.Label3.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label3.Location = new System.Drawing.Point(2, 16);
			this.Label3.Name = "Label3";
			this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label3.Size = new System.Drawing.Size(65, 17);
			this.Label3.TabIndex = 116;
			this.Label3.Text = "Robot:";
			this.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// Label4
			// 
			this.Label4.AllowDrop = true;
			this.Label4.BackColor = System.Drawing.SystemColors.Control;
			this.Label4.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label4.Location = new System.Drawing.Point(2, 34);
			this.Label4.Name = "Label4";
			this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label4.Size = new System.Drawing.Size(65, 17);
			this.Label4.TabIndex = 115;
			this.Label4.Text = "Alarms:";
			this.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// Label5
			// 
			this.Label5.AllowDrop = true;
			this.Label5.BackColor = System.Drawing.SystemColors.Control;
			this.Label5.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label5.Location = new System.Drawing.Point(2, 52);
			this.Label5.Name = "Label5";
			this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label5.Size = new System.Drawing.Size(65, 17);
			this.Label5.TabIndex = 114;
			this.Label5.Text = "Beeps:";
			this.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// Label2
			// 
			this.Label2.AllowDrop = true;
			this.Label2.BackColor = System.Drawing.SystemColors.Control;
			this.Label2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label2.Location = new System.Drawing.Point(2, 70);
			this.Label2.Name = "Label2";
			this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label2.Size = new System.Drawing.Size(65, 17);
			this.Label2.TabIndex = 113;
			this.Label2.Text = "Bio Sounds:";
			this.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// Label6
			// 
			this.Label6.AllowDrop = true;
			this.Label6.BackColor = System.Drawing.SystemColors.Control;
			this.Label6.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label6.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label6.Location = new System.Drawing.Point(2, 88);
			this.Label6.Name = "Label6";
			this.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label6.Size = new System.Drawing.Size(65, 17);
			this.Label6.TabIndex = 101;
			this.Label6.Text = "Touch Tone:";
			this.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _Command1_124
			// 
			this._Command1_124.AllowDrop = true;
			this._Command1_124.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_124.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_124.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_124.Location = new System.Drawing.Point(472, 28);
			this._Command1_124.Name = "_Command1_124";
			this._Command1_124.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_124.Size = new System.Drawing.Size(31, 17);
			this._Command1_124.TabIndex = 89;
			this._Command1_124.Text = "M0";
			this._Command1_124.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_124.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_124.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_125
			// 
			this._Command1_125.AllowDrop = true;
			this._Command1_125.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_125.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_125.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_125.Location = new System.Drawing.Point(472, 46);
			this._Command1_125.Name = "_Command1_125";
			this._Command1_125.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_125.Size = new System.Drawing.Size(31, 17);
			this._Command1_125.TabIndex = 88;
			this._Command1_125.Text = "M1";
			this._Command1_125.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_125.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_125.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// Frame7
			// 
			this.Frame7.AllowDrop = true;
			this.Frame7.BackColor = System.Drawing.SystemColors.Control;
			this.Frame7.Controls.Add(this._Command1_54);
			this.Frame7.Controls.Add(this._Command1_55);
			this.Frame7.Controls.Add(this._Command1_56);
			this.Frame7.Controls.Add(this._Command1_57);
			this.Frame7.Controls.Add(this._Command1_58);
			this.Frame7.Controls.Add(this._Command1_59);
			this.Frame7.Controls.Add(this._Command1_60);
			this.Frame7.Controls.Add(this._Command1_61);
			this.Frame7.Controls.Add(this._Command1_62);
			this.Frame7.Enabled = true;
			this.Frame7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Frame7.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame7.Location = new System.Drawing.Point(596, 80);
			this.Frame7.Name = "Frame7";
			this.Frame7.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame7.Size = new System.Drawing.Size(179, 95);
			this.Frame7.TabIndex = 18;
			this.Frame7.Text = "Voiceless Fricatives";
			this.Frame7.Visible = true;
			// 
			// _Command1_54
			// 
			this._Command1_54.AllowDrop = true;
			this._Command1_54.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_54.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_54.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_54.Location = new System.Drawing.Point(130, 16);
			this._Command1_54.Name = "_Command1_54";
			this._Command1_54.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_54.Size = new System.Drawing.Size(37, 17);
			this._Command1_54.TabIndex = 59;
			this._Command1_54.Text = "CH";
			this._Command1_54.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_54.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_54.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_55
			// 
			this._Command1_55.AllowDrop = true;
			this._Command1_55.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_55.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_55.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_55.Location = new System.Drawing.Point(10, 16);
			this._Command1_55.Name = "_Command1_55";
			this._Command1_55.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_55.Size = new System.Drawing.Size(37, 17);
			this._Command1_55.TabIndex = 58;
			this._Command1_55.Text = "HE";
			this._Command1_55.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_55.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_55.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_56
			// 
			this._Command1_56.AllowDrop = true;
			this._Command1_56.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_56.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_56.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_56.Location = new System.Drawing.Point(10, 36);
			this._Command1_56.Name = "_Command1_56";
			this._Command1_56.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_56.Size = new System.Drawing.Size(37, 17);
			this._Command1_56.TabIndex = 57;
			this._Command1_56.Text = "HO";
			this._Command1_56.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_56.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_56.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_57
			// 
			this._Command1_57.AllowDrop = true;
			this._Command1_57.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_57.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_57.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_57.Location = new System.Drawing.Point(10, 56);
			this._Command1_57.Name = "_Command1_57";
			this._Command1_57.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_57.Size = new System.Drawing.Size(37, 17);
			this._Command1_57.TabIndex = 56;
			this._Command1_57.Text = "WH";
			this._Command1_57.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_57.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_57.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_58
			// 
			this._Command1_58.AllowDrop = true;
			this._Command1_58.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_58.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_58.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_58.Location = new System.Drawing.Point(130, 36);
			this._Command1_58.Name = "_Command1_58";
			this._Command1_58.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_58.Size = new System.Drawing.Size(37, 17);
			this._Command1_58.TabIndex = 55;
			this._Command1_58.Text = "FF";
			this._Command1_58.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_58.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_58.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_59
			// 
			this._Command1_59.AllowDrop = true;
			this._Command1_59.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_59.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_59.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_59.Location = new System.Drawing.Point(50, 16);
			this._Command1_59.Name = "_Command1_59";
			this._Command1_59.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_59.Size = new System.Drawing.Size(37, 17);
			this._Command1_59.TabIndex = 54;
			this._Command1_59.Text = "SE";
			this._Command1_59.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_59.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_59.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_60
			// 
			this._Command1_60.AllowDrop = true;
			this._Command1_60.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_60.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_60.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_60.Location = new System.Drawing.Point(50, 36);
			this._Command1_60.Name = "_Command1_60";
			this._Command1_60.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_60.Size = new System.Drawing.Size(37, 17);
			this._Command1_60.TabIndex = 53;
			this._Command1_60.Text = "SO";
			this._Command1_60.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_60.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_60.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_61
			// 
			this._Command1_61.AllowDrop = true;
			this._Command1_61.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_61.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_61.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_61.Location = new System.Drawing.Point(90, 16);
			this._Command1_61.Name = "_Command1_61";
			this._Command1_61.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_61.Size = new System.Drawing.Size(37, 17);
			this._Command1_61.TabIndex = 52;
			this._Command1_61.Text = "SH";
			this._Command1_61.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_61.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_61.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_62
			// 
			this._Command1_62.AllowDrop = true;
			this._Command1_62.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_62.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_62.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_62.Location = new System.Drawing.Point(90, 36);
			this._Command1_62.Name = "_Command1_62";
			this._Command1_62.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_62.Size = new System.Drawing.Size(37, 17);
			this._Command1_62.TabIndex = 51;
			this._Command1_62.Text = "TH";
			this._Command1_62.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_62.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_62.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// Frame2
			// 
			this.Frame2.AllowDrop = true;
			this.Frame2.BackColor = System.Drawing.SystemColors.Control;
			this.Frame2.Controls.Add(this._Command1_37);
			this.Frame2.Controls.Add(this._Command1_38);
			this.Frame2.Controls.Add(this._Command1_39);
			this.Frame2.Controls.Add(this._Command1_40);
			this.Frame2.Controls.Add(this._Command1_41);
			this.Frame2.Enabled = true;
			this.Frame2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Frame2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame2.Location = new System.Drawing.Point(144, 116);
			this.Frame2.Name = "Frame2";
			this.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame2.Size = new System.Drawing.Size(145, 59);
			this.Frame2.TabIndex = 17;
			this.Frame2.Text = "Voiced Fricatives";
			this.Frame2.Visible = true;
			// 
			// _Command1_37
			// 
			this._Command1_37.AllowDrop = true;
			this._Command1_37.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_37.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_37.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_37.Location = new System.Drawing.Point(8, 16);
			this._Command1_37.Name = "_Command1_37";
			this._Command1_37.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_37.Size = new System.Drawing.Size(41, 17);
			this._Command1_37.TabIndex = 50;
			this._Command1_37.Text = "JH";
			this._Command1_37.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_37.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_37.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_38
			// 
			this._Command1_38.AllowDrop = true;
			this._Command1_38.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_38.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_38.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_38.Location = new System.Drawing.Point(52, 16);
			this._Command1_38.Name = "_Command1_38";
			this._Command1_38.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_38.Size = new System.Drawing.Size(41, 17);
			this._Command1_38.TabIndex = 49;
			this._Command1_38.Text = "VV";
			this._Command1_38.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_38.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_38.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_39
			// 
			this._Command1_39.AllowDrop = true;
			this._Command1_39.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_39.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_39.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_39.Location = new System.Drawing.Point(96, 16);
			this._Command1_39.Name = "_Command1_39";
			this._Command1_39.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_39.Size = new System.Drawing.Size(41, 17);
			this._Command1_39.TabIndex = 48;
			this._Command1_39.Text = "ZZ";
			this._Command1_39.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_39.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_39.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_40
			// 
			this._Command1_40.AllowDrop = true;
			this._Command1_40.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_40.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_40.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_40.Location = new System.Drawing.Point(8, 34);
			this._Command1_40.Name = "_Command1_40";
			this._Command1_40.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_40.Size = new System.Drawing.Size(41, 17);
			this._Command1_40.TabIndex = 47;
			this._Command1_40.Text = "ZH";
			this._Command1_40.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_40.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_40.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_41
			// 
			this._Command1_41.AllowDrop = true;
			this._Command1_41.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_41.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_41.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_41.Location = new System.Drawing.Point(52, 34);
			this._Command1_41.Name = "_Command1_41";
			this._Command1_41.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_41.Size = new System.Drawing.Size(41, 17);
			this._Command1_41.TabIndex = 46;
			this._Command1_41.Text = "DH";
			this._Command1_41.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_41.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_41.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// Frame6
			// 
			this.Frame6.AllowDrop = true;
			this.Frame6.BackColor = System.Drawing.SystemColors.Control;
			this.Frame6.Controls.Add(this._Command1_63);
			this.Frame6.Controls.Add(this._Command1_64);
			this.Frame6.Controls.Add(this._Command1_65);
			this.Frame6.Controls.Add(this._Command1_66);
			this.Frame6.Controls.Add(this._Command1_67);
			this.Frame6.Controls.Add(this._Command1_68);
			this.Frame6.Controls.Add(this._Command1_69);
			this.Frame6.Controls.Add(this._Command1_70);
			this.Frame6.Controls.Add(this._Command1_71);
			this.Frame6.Enabled = true;
			this.Frame6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Frame6.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame6.Location = new System.Drawing.Point(440, 80);
			this.Frame6.Name = "Frame6";
			this.Frame6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame6.Size = new System.Drawing.Size(153, 95);
			this.Frame6.TabIndex = 16;
			this.Frame6.Text = "Voiceless Stops";
			this.Frame6.Visible = true;
			// 
			// _Command1_63
			// 
			this._Command1_63.AllowDrop = true;
			this._Command1_63.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_63.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_63.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_63.Location = new System.Drawing.Point(54, 16);
			this._Command1_63.Name = "_Command1_63";
			this._Command1_63.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_63.Size = new System.Drawing.Size(43, 17);
			this._Command1_63.TabIndex = 79;
			this._Command1_63.Text = "TT";
			this._Command1_63.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_63.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_63.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_64
			// 
			this._Command1_64.AllowDrop = true;
			this._Command1_64.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_64.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_64.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_64.Location = new System.Drawing.Point(54, 34);
			this._Command1_64.Name = "_Command1_64";
			this._Command1_64.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_64.Size = new System.Drawing.Size(43, 17);
			this._Command1_64.TabIndex = 78;
			this._Command1_64.Text = "TU";
			this._Command1_64.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_64.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_64.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_65
			// 
			this._Command1_65.AllowDrop = true;
			this._Command1_65.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_65.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_65.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_65.Location = new System.Drawing.Point(54, 52);
			this._Command1_65.Name = "_Command1_65";
			this._Command1_65.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_65.Size = new System.Drawing.Size(43, 17);
			this._Command1_65.TabIndex = 77;
			this._Command1_65.Text = "TS";
			this._Command1_65.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_65.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_65.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_66
			// 
			this._Command1_66.AllowDrop = true;
			this._Command1_66.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_66.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_66.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_66.Location = new System.Drawing.Point(8, 16);
			this._Command1_66.Name = "_Command1_66";
			this._Command1_66.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_66.Size = new System.Drawing.Size(43, 17);
			this._Command1_66.TabIndex = 76;
			this._Command1_66.Text = "KE";
			this._Command1_66.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_66.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_66.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_67
			// 
			this._Command1_67.AllowDrop = true;
			this._Command1_67.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_67.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_67.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_67.Location = new System.Drawing.Point(8, 34);
			this._Command1_67.Name = "_Command1_67";
			this._Command1_67.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_67.Size = new System.Drawing.Size(43, 17);
			this._Command1_67.TabIndex = 75;
			this._Command1_67.Text = "KO";
			this._Command1_67.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_67.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_67.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_68
			// 
			this._Command1_68.AllowDrop = true;
			this._Command1_68.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_68.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_68.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_68.Location = new System.Drawing.Point(8, 52);
			this._Command1_68.Name = "_Command1_68";
			this._Command1_68.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_68.Size = new System.Drawing.Size(43, 17);
			this._Command1_68.TabIndex = 74;
			this._Command1_68.Text = "EK";
			this._Command1_68.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_68.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_68.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_69
			// 
			this._Command1_69.AllowDrop = true;
			this._Command1_69.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_69.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_69.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_69.Location = new System.Drawing.Point(8, 70);
			this._Command1_69.Name = "_Command1_69";
			this._Command1_69.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_69.Size = new System.Drawing.Size(43, 17);
			this._Command1_69.TabIndex = 73;
			this._Command1_69.Text = "OK";
			this._Command1_69.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_69.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_69.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_70
			// 
			this._Command1_70.AllowDrop = true;
			this._Command1_70.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_70.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_70.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_70.Location = new System.Drawing.Point(100, 16);
			this._Command1_70.Name = "_Command1_70";
			this._Command1_70.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_70.Size = new System.Drawing.Size(43, 17);
			this._Command1_70.TabIndex = 72;
			this._Command1_70.Text = "PE";
			this._Command1_70.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_70.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_70.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_71
			// 
			this._Command1_71.AllowDrop = true;
			this._Command1_71.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_71.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_71.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_71.Location = new System.Drawing.Point(100, 34);
			this._Command1_71.Name = "_Command1_71";
			this._Command1_71.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_71.Size = new System.Drawing.Size(43, 17);
			this._Command1_71.TabIndex = 71;
			this._Command1_71.Text = "PO";
			this._Command1_71.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_71.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_71.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// Frame5
			// 
			this.Frame5.AllowDrop = true;
			this.Frame5.BackColor = System.Drawing.SystemColors.Control;
			this.Frame5.Controls.Add(this._Command1_42);
			this.Frame5.Controls.Add(this._Command1_43);
			this.Frame5.Controls.Add(this._Command1_44);
			this.Frame5.Controls.Add(this._Command1_45);
			this.Frame5.Controls.Add(this._Command1_46);
			this.Frame5.Controls.Add(this._Command1_47);
			this.Frame5.Controls.Add(this._Command1_48);
			this.Frame5.Controls.Add(this._Command1_49);
			this.Frame5.Controls.Add(this._Command1_50);
			this.Frame5.Controls.Add(this._Command1_51);
			this.Frame5.Controls.Add(this._Command1_52);
			this.Frame5.Controls.Add(this._Command1_53);
			this.Frame5.Enabled = true;
			this.Frame5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Frame5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame5.Location = new System.Drawing.Point(292, 80);
			this.Frame5.Name = "Frame5";
			this.Frame5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame5.Size = new System.Drawing.Size(145, 95);
			this.Frame5.TabIndex = 15;
			this.Frame5.Text = "Voiced Stops";
			this.Frame5.Visible = true;
			// 
			// _Command1_42
			// 
			this._Command1_42.AllowDrop = true;
			this._Command1_42.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_42.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_42.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_42.Location = new System.Drawing.Point(12, 16);
			this._Command1_42.Name = "_Command1_42";
			this._Command1_42.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_42.Size = new System.Drawing.Size(39, 17);
			this._Command1_42.TabIndex = 45;
			this._Command1_42.Text = "BE";
			this._Command1_42.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_42.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_42.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_43
			// 
			this._Command1_43.AllowDrop = true;
			this._Command1_43.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_43.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_43.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_43.Location = new System.Drawing.Point(12, 34);
			this._Command1_43.Name = "_Command1_43";
			this._Command1_43.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_43.Size = new System.Drawing.Size(39, 17);
			this._Command1_43.TabIndex = 44;
			this._Command1_43.Text = "BO";
			this._Command1_43.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_43.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_43.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_44
			// 
			this._Command1_44.AllowDrop = true;
			this._Command1_44.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_44.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_44.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_44.Location = new System.Drawing.Point(12, 52);
			this._Command1_44.Name = "_Command1_44";
			this._Command1_44.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_44.Size = new System.Drawing.Size(39, 17);
			this._Command1_44.TabIndex = 43;
			this._Command1_44.Text = "EB";
			this._Command1_44.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_44.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_44.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_45
			// 
			this._Command1_45.AllowDrop = true;
			this._Command1_45.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_45.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_45.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_45.Location = new System.Drawing.Point(12, 70);
			this._Command1_45.Name = "_Command1_45";
			this._Command1_45.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_45.Size = new System.Drawing.Size(39, 17);
			this._Command1_45.TabIndex = 42;
			this._Command1_45.Text = "OB";
			this._Command1_45.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_45.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_45.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_46
			// 
			this._Command1_46.AllowDrop = true;
			this._Command1_46.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_46.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_46.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_46.Location = new System.Drawing.Point(54, 16);
			this._Command1_46.Name = "_Command1_46";
			this._Command1_46.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_46.Size = new System.Drawing.Size(39, 17);
			this._Command1_46.TabIndex = 41;
			this._Command1_46.Text = "DE";
			this._Command1_46.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_46.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_46.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_47
			// 
			this._Command1_47.AllowDrop = true;
			this._Command1_47.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_47.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_47.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_47.Location = new System.Drawing.Point(54, 34);
			this._Command1_47.Name = "_Command1_47";
			this._Command1_47.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_47.Size = new System.Drawing.Size(39, 17);
			this._Command1_47.TabIndex = 40;
			this._Command1_47.Text = "DO";
			this._Command1_47.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_47.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_47.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_48
			// 
			this._Command1_48.AllowDrop = true;
			this._Command1_48.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_48.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_48.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_48.Location = new System.Drawing.Point(54, 52);
			this._Command1_48.Name = "_Command1_48";
			this._Command1_48.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_48.Size = new System.Drawing.Size(39, 17);
			this._Command1_48.TabIndex = 39;
			this._Command1_48.Text = "ED";
			this._Command1_48.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_48.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_48.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_49
			// 
			this._Command1_49.AllowDrop = true;
			this._Command1_49.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_49.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_49.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_49.Location = new System.Drawing.Point(54, 70);
			this._Command1_49.Name = "_Command1_49";
			this._Command1_49.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_49.Size = new System.Drawing.Size(39, 17);
			this._Command1_49.TabIndex = 38;
			this._Command1_49.Text = "OD";
			this._Command1_49.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_49.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_49.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_50
			// 
			this._Command1_50.AllowDrop = true;
			this._Command1_50.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_50.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_50.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_50.Location = new System.Drawing.Point(96, 16);
			this._Command1_50.Name = "_Command1_50";
			this._Command1_50.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_50.Size = new System.Drawing.Size(39, 17);
			this._Command1_50.TabIndex = 37;
			this._Command1_50.Text = "GE";
			this._Command1_50.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_50.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_50.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_51
			// 
			this._Command1_51.AllowDrop = true;
			this._Command1_51.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_51.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_51.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_51.Location = new System.Drawing.Point(96, 34);
			this._Command1_51.Name = "_Command1_51";
			this._Command1_51.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_51.Size = new System.Drawing.Size(39, 17);
			this._Command1_51.TabIndex = 36;
			this._Command1_51.Text = "GO";
			this._Command1_51.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_51.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_51.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_52
			// 
			this._Command1_52.AllowDrop = true;
			this._Command1_52.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_52.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_52.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_52.Location = new System.Drawing.Point(96, 52);
			this._Command1_52.Name = "_Command1_52";
			this._Command1_52.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_52.Size = new System.Drawing.Size(39, 17);
			this._Command1_52.TabIndex = 35;
			this._Command1_52.Text = "EG";
			this._Command1_52.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_52.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_52.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_53
			// 
			this._Command1_53.AllowDrop = true;
			this._Command1_53.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_53.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_53.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_53.Location = new System.Drawing.Point(96, 70);
			this._Command1_53.Name = "_Command1_53";
			this._Command1_53.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_53.Size = new System.Drawing.Size(39, 17);
			this._Command1_53.TabIndex = 34;
			this._Command1_53.Text = "OG";
			this._Command1_53.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_53.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_53.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// Frame4
			// 
			this.Frame4.AllowDrop = true;
			this.Frame4.BackColor = System.Drawing.SystemColors.Control;
			this.Frame4.Controls.Add(this._Command1_25);
			this.Frame4.Controls.Add(this._Command1_26);
			this.Frame4.Controls.Add(this._Command1_27);
			this.Frame4.Controls.Add(this._Command1_30);
			this.Frame4.Controls.Add(this._Command1_28);
			this.Frame4.Controls.Add(this._Command1_31);
			this.Frame4.Controls.Add(this._Command1_34);
			this.Frame4.Controls.Add(this._Command1_33);
			this.Frame4.Controls.Add(this._Command1_35);
			this.Frame4.Controls.Add(this._Command1_36);
			this.Frame4.Controls.Add(this._Command1_29);
			this.Frame4.Enabled = true;
			this.Frame4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Frame4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame4.Location = new System.Drawing.Point(292, 4);
			this.Frame4.Name = "Frame4";
			this.Frame4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame4.Size = new System.Drawing.Size(215, 75);
			this.Frame4.TabIndex = 14;
			this.Frame4.Text = "Diphthongs";
			this.Frame4.Visible = true;
			// 
			// _Command1_25
			// 
			this._Command1_25.AllowDrop = true;
			this._Command1_25.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_25.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_25.Location = new System.Drawing.Point(8, 16);
			this._Command1_25.Name = "_Command1_25";
			this._Command1_25.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_25.Size = new System.Drawing.Size(47, 17);
			this._Command1_25.TabIndex = 70;
			this._Command1_25.Text = "EYIY";
			this._Command1_25.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_25.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_25.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_26
			// 
			this._Command1_26.AllowDrop = true;
			this._Command1_26.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_26.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_26.Location = new System.Drawing.Point(8, 34);
			this._Command1_26.Name = "_Command1_26";
			this._Command1_26.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_26.Size = new System.Drawing.Size(47, 17);
			this._Command1_26.TabIndex = 69;
			this._Command1_26.Text = "OHIY";
			this._Command1_26.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_26.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_26.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_27
			// 
			this._Command1_27.AllowDrop = true;
			this._Command1_27.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_27.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_27.Location = new System.Drawing.Point(8, 52);
			this._Command1_27.Name = "_Command1_27";
			this._Command1_27.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_27.Size = new System.Drawing.Size(47, 17);
			this._Command1_27.TabIndex = 68;
			this._Command1_27.Text = "OWIY";
			this._Command1_27.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_27.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_27.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_30
			// 
			this._Command1_30.AllowDrop = true;
			this._Command1_30.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_30.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_30.Location = new System.Drawing.Point(58, 52);
			this._Command1_30.Name = "_Command1_30";
			this._Command1_30.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_30.Size = new System.Drawing.Size(47, 17);
			this._Command1_30.TabIndex = 61;
			this._Command1_30.Text = "EHLE";
			this._Command1_30.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_30.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_30.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_28
			// 
			this._Command1_28.AllowDrop = true;
			this._Command1_28.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_28.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_28.Location = new System.Drawing.Point(58, 34);
			this._Command1_28.Name = "_Command1_28";
			this._Command1_28.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_28.Size = new System.Drawing.Size(47, 17);
			this._Command1_28.TabIndex = 67;
			this._Command1_28.Text = "OHIH";
			this._Command1_28.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_28.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_28.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_31
			// 
			this._Command1_31.AllowDrop = true;
			this._Command1_31.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_31.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_31.Location = new System.Drawing.Point(108, 16);
			this._Command1_31.Name = "_Command1_31";
			this._Command1_31.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_31.Size = new System.Drawing.Size(47, 17);
			this._Command1_31.TabIndex = 65;
			this._Command1_31.Text = "IYUW";
			this._Command1_31.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_31.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_31.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_34
			// 
			this._Command1_34.AllowDrop = true;
			this._Command1_34.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_34.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_34.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_34.Location = new System.Drawing.Point(158, 52);
			this._Command1_34.Name = "_Command1_34";
			this._Command1_34.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_34.Size = new System.Drawing.Size(47, 17);
			this._Command1_34.TabIndex = 64;
			this._Command1_34.Text = "IHWW";
			this._Command1_34.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_34.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_34.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_33
			// 
			this._Command1_33.AllowDrop = true;
			this._Command1_33.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_33.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_33.Location = new System.Drawing.Point(108, 34);
			this._Command1_33.Name = "_Command1_33";
			this._Command1_33.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_33.Size = new System.Drawing.Size(47, 17);
			this._Command1_33.TabIndex = 63;
			this._Command1_33.Text = "AXUW";
			this._Command1_33.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_33.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_33.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_35
			// 
			this._Command1_35.AllowDrop = true;
			this._Command1_35.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_35.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_35.Location = new System.Drawing.Point(158, 16);
			this._Command1_35.Name = "_Command1_35";
			this._Command1_35.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_35.Size = new System.Drawing.Size(47, 17);
			this._Command1_35.TabIndex = 62;
			this._Command1_35.Text = "AYWW";
			this._Command1_35.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_35.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_35.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_36
			// 
			this._Command1_36.AllowDrop = true;
			this._Command1_36.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_36.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_36.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_36.Location = new System.Drawing.Point(158, 34);
			this._Command1_36.Name = "_Command1_36";
			this._Command1_36.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_36.Size = new System.Drawing.Size(47, 17);
			this._Command1_36.TabIndex = 60;
			this._Command1_36.Text = "OWWW";
			this._Command1_36.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_36.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_36.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_29
			// 
			this._Command1_29.AllowDrop = true;
			this._Command1_29.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_29.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_29.Location = new System.Drawing.Point(58, 16);
			this._Command1_29.Name = "_Command1_29";
			this._Command1_29.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_29.Size = new System.Drawing.Size(47, 17);
			this._Command1_29.TabIndex = 66;
			this._Command1_29.Text = "IYEH";
			this._Command1_29.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_29.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_29.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// Frame3
			// 
			this.Frame3.AllowDrop = true;
			this.Frame3.BackColor = System.Drawing.SystemColors.Control;
			this.Frame3.Controls.Add(this._Command1_11);
			this.Frame3.Controls.Add(this._Command1_12);
			this.Frame3.Controls.Add(this._Command1_13);
			this.Frame3.Controls.Add(this._Command1_14);
			this.Frame3.Controls.Add(this._Command1_15);
			this.Frame3.Controls.Add(this._Command1_16);
			this.Frame3.Controls.Add(this._Command1_17);
			this.Frame3.Controls.Add(this._Command1_18);
			this.Frame3.Enabled = true;
			this.Frame3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Frame3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame3.Location = new System.Drawing.Point(510, 4);
			this.Frame3.Name = "Frame3";
			this.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame3.Size = new System.Drawing.Size(145, 75);
			this.Frame3.TabIndex = 13;
			this.Frame3.Text = "Resonate && Nasal";
			this.Frame3.Visible = true;
			// 
			// _Command1_11
			// 
			this._Command1_11.AllowDrop = true;
			this._Command1_11.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_11.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_11.Location = new System.Drawing.Point(52, 52);
			this._Command1_11.Name = "_Command1_11";
			this._Command1_11.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_11.Size = new System.Drawing.Size(39, 17);
			this._Command1_11.TabIndex = 87;
			this._Command1_11.Text = "MM";
			this._Command1_11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_11.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_11.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_12
			// 
			this._Command1_12.AllowDrop = true;
			this._Command1_12.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_12.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_12.Location = new System.Drawing.Point(52, 16);
			this._Command1_12.Name = "_Command1_12";
			this._Command1_12.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_12.Size = new System.Drawing.Size(39, 17);
			this._Command1_12.TabIndex = 86;
			this._Command1_12.Text = "NE";
			this._Command1_12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_12.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_12.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_13
			// 
			this._Command1_13.AllowDrop = true;
			this._Command1_13.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_13.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_13.Location = new System.Drawing.Point(52, 34);
			this._Command1_13.Name = "_Command1_13";
			this._Command1_13.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_13.Size = new System.Drawing.Size(39, 17);
			this._Command1_13.TabIndex = 85;
			this._Command1_13.Text = "NO";
			this._Command1_13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_13.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_13.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_14
			// 
			this._Command1_14.AllowDrop = true;
			this._Command1_14.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_14.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_14.Location = new System.Drawing.Point(94, 16);
			this._Command1_14.Name = "_Command1_14";
			this._Command1_14.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_14.Size = new System.Drawing.Size(39, 17);
			this._Command1_14.TabIndex = 84;
			this._Command1_14.Text = "NGE";
			this._Command1_14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_14.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_14.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_15
			// 
			this._Command1_15.AllowDrop = true;
			this._Command1_15.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_15.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_15.Location = new System.Drawing.Point(94, 34);
			this._Command1_15.Name = "_Command1_15";
			this._Command1_15.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_15.Size = new System.Drawing.Size(39, 17);
			this._Command1_15.TabIndex = 83;
			this._Command1_15.Text = "NGO";
			this._Command1_15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_15.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_15.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_16
			// 
			this._Command1_16.AllowDrop = true;
			this._Command1_16.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_16.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_16.Location = new System.Drawing.Point(10, 16);
			this._Command1_16.Name = "_Command1_16";
			this._Command1_16.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_16.Size = new System.Drawing.Size(39, 17);
			this._Command1_16.TabIndex = 82;
			this._Command1_16.Text = "LE";
			this._Command1_16.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_16.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_16.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_17
			// 
			this._Command1_17.AllowDrop = true;
			this._Command1_17.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_17.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_17.Location = new System.Drawing.Point(10, 34);
			this._Command1_17.Name = "_Command1_17";
			this._Command1_17.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_17.Size = new System.Drawing.Size(39, 17);
			this._Command1_17.TabIndex = 81;
			this._Command1_17.Text = "LO";
			this._Command1_17.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_17.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_17.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_18
			// 
			this._Command1_18.AllowDrop = true;
			this._Command1_18.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_18.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_18.Location = new System.Drawing.Point(10, 52);
			this._Command1_18.Name = "_Command1_18";
			this._Command1_18.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_18.Size = new System.Drawing.Size(39, 17);
			this._Command1_18.TabIndex = 80;
			this._Command1_18.Text = "WW";
			this._Command1_18.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_18.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_18.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// Frame1
			// 
			this.Frame1.AllowDrop = true;
			this.Frame1.BackColor = System.Drawing.SystemColors.Control;
			this.Frame1.Controls.Add(this._Command1_4);
			this.Frame1.Controls.Add(this._Command1_3);
			this.Frame1.Controls.Add(this._Command1_2);
			this.Frame1.Controls.Add(this._Command1_1);
			this.Frame1.Controls.Add(this._Command1_32);
			this.Frame1.Controls.Add(this._Command1_0);
			this.Frame1.Controls.Add(this._Command1_5);
			this.Frame1.Controls.Add(this._Command1_6);
			this.Frame1.Controls.Add(this._Command1_7);
			this.Frame1.Controls.Add(this._Command1_8);
			this.Frame1.Controls.Add(this._Command1_9);
			this.Frame1.Controls.Add(this._Command1_10);
			this.Frame1.Enabled = true;
			this.Frame1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame1.Location = new System.Drawing.Point(144, 4);
			this.Frame1.Name = "Frame1";
			this.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame1.Size = new System.Drawing.Size(145, 111);
			this.Frame1.TabIndex = 12;
			this.Frame1.Text = "Vowels";
			this.Frame1.Visible = true;
			// 
			// _Command1_4
			// 
			this._Command1_4.AllowDrop = true;
			this._Command1_4.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_4.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_4.Location = new System.Drawing.Point(8, 88);
			this._Command1_4.Name = "_Command1_4";
			this._Command1_4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_4.Size = new System.Drawing.Size(41, 17);
			this._Command1_4.TabIndex = 29;
			this._Command1_4.Text = "AY";
			this._Command1_4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_4.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_4.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_3
			// 
			this._Command1_3.AllowDrop = true;
			this._Command1_3.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_3.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_3.Location = new System.Drawing.Point(28, 70);
			this._Command1_3.Name = "_Command1_3";
			this._Command1_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_3.Size = new System.Drawing.Size(41, 17);
			this._Command1_3.TabIndex = 30;
			this._Command1_3.Text = "EH";
			this._Command1_3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_3.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_3.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_2
			// 
			this._Command1_2.AllowDrop = true;
			this._Command1_2.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_2.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_2.Location = new System.Drawing.Point(8, 52);
			this._Command1_2.Name = "_Command1_2";
			this._Command1_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_2.Size = new System.Drawing.Size(41, 17);
			this._Command1_2.TabIndex = 31;
			this._Command1_2.Text = "EY";
			this._Command1_2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_2.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_2.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_1
			// 
			this._Command1_1.AllowDrop = true;
			this._Command1_1.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_1.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_1.Location = new System.Drawing.Point(28, 34);
			this._Command1_1.Name = "_Command1_1";
			this._Command1_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_1.Size = new System.Drawing.Size(41, 17);
			this._Command1_1.TabIndex = 32;
			this._Command1_1.Text = "IH";
			this._Command1_1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_1.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_1.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_32
			// 
			this._Command1_32.AllowDrop = true;
			this._Command1_32.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_32.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_32.Location = new System.Drawing.Point(52, 88);
			this._Command1_32.Name = "_Command1_32";
			this._Command1_32.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_32.Size = new System.Drawing.Size(41, 17);
			this._Command1_32.TabIndex = 167;
			this._Command1_32.Text = "UX";
			this._Command1_32.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_32.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_32.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_0
			// 
			this._Command1_0.AllowDrop = true;
			this._Command1_0.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_0.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_0.Location = new System.Drawing.Point(8, 16);
			this._Command1_0.Name = "_Command1_0";
			this._Command1_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_0.Size = new System.Drawing.Size(41, 17);
			this._Command1_0.TabIndex = 33;
			this._Command1_0.Text = "IY";
			this._Command1_0.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_0.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_0.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_5
			// 
			this._Command1_5.AllowDrop = true;
			this._Command1_5.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_5.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_5.Location = new System.Drawing.Point(52, 52);
			this._Command1_5.Name = "_Command1_5";
			this._Command1_5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_5.Size = new System.Drawing.Size(41, 17);
			this._Command1_5.TabIndex = 28;
			this._Command1_5.Text = "AX";
			this._Command1_5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_5.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_5.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_6
			// 
			this._Command1_6.AllowDrop = true;
			this._Command1_6.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_6.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_6.Location = new System.Drawing.Point(96, 88);
			this._Command1_6.Name = "_Command1_6";
			this._Command1_6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_6.Size = new System.Drawing.Size(41, 17);
			this._Command1_6.TabIndex = 27;
			this._Command1_6.Text = "AW";
			this._Command1_6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_6.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_6.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_7
			// 
			this._Command1_7.AllowDrop = true;
			this._Command1_7.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_7.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_7.Location = new System.Drawing.Point(76, 70);
			this._Command1_7.Name = "_Command1_7";
			this._Command1_7.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_7.Size = new System.Drawing.Size(41, 17);
			this._Command1_7.TabIndex = 26;
			this._Command1_7.Text = "OH";
			this._Command1_7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_7.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_7.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_8
			// 
			this._Command1_8.AllowDrop = true;
			this._Command1_8.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_8.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_8.Location = new System.Drawing.Point(96, 52);
			this._Command1_8.Name = "_Command1_8";
			this._Command1_8.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_8.Size = new System.Drawing.Size(41, 17);
			this._Command1_8.TabIndex = 25;
			this._Command1_8.Text = "OW";
			this._Command1_8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_8.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_8.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_9
			// 
			this._Command1_9.AllowDrop = true;
			this._Command1_9.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_9.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_9.Location = new System.Drawing.Point(76, 34);
			this._Command1_9.Name = "_Command1_9";
			this._Command1_9.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_9.Size = new System.Drawing.Size(41, 17);
			this._Command1_9.TabIndex = 24;
			this._Command1_9.Text = "UH";
			this._Command1_9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_9.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_9.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// _Command1_10
			// 
			this._Command1_10.AllowDrop = true;
			this._Command1_10.BackColor = System.Drawing.SystemColors.Window;
			this._Command1_10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Command1_10.ForeColor = System.Drawing.SystemColors.WindowText;
			this._Command1_10.Location = new System.Drawing.Point(96, 16);
			this._Command1_10.Name = "_Command1_10";
			this._Command1_10.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Command1_10.Size = new System.Drawing.Size(41, 17);
			this._Command1_10.TabIndex = 23;
			this._Command1_10.Text = "UW";
			this._Command1_10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this._Command1_10.Click += new System.EventHandler(this.Command1_Click);
			this._Command1_10.DoubleClick += new System.EventHandler(this.Command1_DoubleClick);
			// 
			// frmPhrase
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(780, 529);
			this.Controls.Add(this.Frame16);
			this.Controls.Add(this.btnShutUp);
			this.Controls.Add(this.btnDone);
			this.Controls.Add(this.Frame15);
			this.Controls.Add(this.Frame14);
			this.Controls.Add(this.Frame13);
			this.Controls.Add(this.Frame12);
			this.Controls.Add(this.Frame11);
			this.Controls.Add(this.Frame10);
			this.Controls.Add(this.Frame9);
			this.Controls.Add(this.Frame8);
			this.Controls.Add(this.Frame7);
			this.Controls.Add(this.Frame2);
			this.Controls.Add(this.Frame6);
			this.Controls.Add(this.Frame5);
			this.Controls.Add(this.Frame4);
			this.Controls.Add(this.Frame3);
			this.Controls.Add(this.Frame1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Location = new System.Drawing.Point(10, 30);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmPhrase";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = " SpeakJet Phrase Editor";
			this.ToolTipMain.SetToolTip(this._Command1_156, "Call EEPROM Phrase x.");
			this.ToolTipMain.SetToolTip(this._Command1_127, "Play EEPROM Phrase x.");
			this.ToolTipMain.SetToolTip(this._Command1_137, "Set the Output Pin's Control to x.");
			this.ToolTipMain.SetToolTip(this._Command1_138, "Set the Output Pin's Output state to x.");
			this.ToolTipMain.SetToolTip(this.btnShutUp, "Stop the SpeakJet now.");
			this.ToolTipMain.SetToolTip(this.btnNextWord, "Find and load the next word in the Dictionary");
			this.ToolTipMain.SetToolTip(this.cmdLoadOver, "Load the dictionary words into the Say Data window.");
			this.ToolTipMain.SetToolTip(this.cmdSave, "Save the Say Data to the Dictionary.");
			this.ToolTipMain.SetToolTip(this.cmdLoadInsert, "Load the dictionary words into the Say Data window.");
			this.ToolTipMain.SetToolTip(this._Command1_158, "Delay 10xMS before playing the next sound.");
			this.ToolTipMain.SetToolTip(this._Command1_129, "100ms Pause /wout transition");
			this.ToolTipMain.SetToolTip(this._Command1_131, "700ms Pause /wout transition");
			this.ToolTipMain.SetToolTip(this._Command1_134, "60ms Pause /w transition");
			this.ToolTipMain.SetToolTip(this._Command1_132, "10ms Pause /w transition");
			this.ToolTipMain.SetToolTip(this._Command1_130, "300ms Pause /wout transition");
			this.ToolTipMain.SetToolTip(this._Command1_133, "36ms Pause /w transition");
			this.ToolTipMain.SetToolTip(this._Command1_128, "0ms Pause /wout transition");
			this.ToolTipMain.SetToolTip(this._Command1_139, "Stop sound until restarted.");
			this.ToolTipMain.SetToolTip(this._Command1_197, "Set the Pitch to the Frequency for F#3");
			this.ToolTipMain.SetToolTip(this._Command1_192, "Set the Pitch to the Frequency for G3");
			this.ToolTipMain.SetToolTip(this._Command1_187, "Set the Pitch to the Frequency for G#3");
			this.ToolTipMain.SetToolTip(this._Command1_182, "Set the Pitch to the Frequency for A3");
			this.ToolTipMain.SetToolTip(this._Command1_177, "Set the Pitch to the Frequency for A#3");
			this.ToolTipMain.SetToolTip(this._Command1_175, "Set the Pitch to the Frequency for C3");
			this.ToolTipMain.SetToolTip(this._Command1_172, "Set the Pitch to the Frequency for B3");
			this.ToolTipMain.SetToolTip(this._Command1_170, "Set the Pitch to the Frequency for C#3");
			this.ToolTipMain.SetToolTip(this._Command1_165, "Set the Pitch to the Frequency for D3");
			this.ToolTipMain.SetToolTip(this._Command1_160, "Set the Pitch to the Frequency for D#3");
			this.ToolTipMain.SetToolTip(this._Command1_152, "Set the Pitch to the Frequency for E3");
			this.ToolTipMain.SetToolTip(this._Command1_147, "Set the Pitch to the Frequency for F3");
			this.ToolTipMain.SetToolTip(this._Command1_196, "Set the Pitch to the Frequency for C1");
			this.ToolTipMain.SetToolTip(this._Command1_195, "Set the Pitch to the Frequency for G#2");
			this.ToolTipMain.SetToolTip(this._Command1_194, "Set the Pitch to the Frequency for A#1");
			this.ToolTipMain.SetToolTip(this._Command1_191, "Set the Pitch to the Frequency for C#1");
			this.ToolTipMain.SetToolTip(this._Command1_190, "Set the Pitch to the Frequency for A2");
			this.ToolTipMain.SetToolTip(this._Command1_189, "Set the Pitch to the Frequency for B1");
			this.ToolTipMain.SetToolTip(this._Command1_186, "Set the Pitch to the Frequency for D1");
			this.ToolTipMain.SetToolTip(this._Command1_185, "Set the Pitch to the Frequency for A#2");
			this.ToolTipMain.SetToolTip(this._Command1_184, "Set the Pitch to the Frequency for C2");
			this.ToolTipMain.SetToolTip(this._Command1_181, "Set the Pitch to the Frequency for D#1");
			this.ToolTipMain.SetToolTip(this._Command1_180, "Set the Pitch to the Frequency for B2");
			this.ToolTipMain.SetToolTip(this._Command1_179, "Set the Pitch to the Frequency for C#2");
			this.ToolTipMain.SetToolTip(this._Command1_176, "Set the Pitch to the Frequency for E1");
			this.ToolTipMain.SetToolTip(this._Command1_174, "Set the Pitch to the Frequency for D2");
			this.ToolTipMain.SetToolTip(this._Command1_171, "Set the Pitch to the Frequency for F1");
			this.ToolTipMain.SetToolTip(this._Command1_169, "Set the Pitch to the Frequency for D#2");
			this.ToolTipMain.SetToolTip(this._Command1_166, "Set the Pitch to the Frequency for F#1");
			this.ToolTipMain.SetToolTip(this._Command1_164, "Set the Pitch to the Frequency for E2");
			this.ToolTipMain.SetToolTip(this._Command1_161, "Set the Pitch to the Frequency for G1");
			this.ToolTipMain.SetToolTip(this._Command1_159, "Set the Pitch to the Frequency for F2");
			this.ToolTipMain.SetToolTip(this._Command1_153, "Set the Pitch to the Frequency for G#1");
			this.ToolTipMain.SetToolTip(this._Command1_151, "Set the Pitch to the Frequency for F#2");
			this.ToolTipMain.SetToolTip(this._Command1_148, "Set the Pitch to the Frequency for A1");
			this.ToolTipMain.SetToolTip(this._Command1_146, "Set the Pitch to the Frequency for G2");
			this.ToolTipMain.SetToolTip(this._Command1_24, "Corn, Four, Your");
			this.ToolTipMain.SetToolTip(this._Command1_23, "Part, Farm, Yarn");
			this.ToolTipMain.SetToolTip(this._Command1_22, "Fir, Bird, Burn");
			this.ToolTipMain.SetToolTip(this._Command1_21, "Hair, Stair, Repair");
			this.ToolTipMain.SetToolTip(this._Command1_20, "Clear, Hear, Year");
			this.ToolTipMain.SetToolTip(this._Command1_19, "Ray, Brain, Over");
			this.ToolTipMain.SetToolTip(this._Command1_141, "Play the Next Sound Soft.");
			this.ToolTipMain.SetToolTip(this._Command1_154, "Repeat the following Sound x Times");
			this.ToolTipMain.SetToolTip(this._Command1_142, "Play the Next Sound with Stress.");
			this.ToolTipMain.SetToolTip(this._Command1_143, "Play the Next Sound Relaxed.");
			this.ToolTipMain.SetToolTip(this._Command1_136, "Play the Next Sound at 1/2 speed");
			this.ToolTipMain.SetToolTip(this._Command1_135, "Play the Next Sound at 1 1/2 speed");
			this.ToolTipMain.SetToolTip(this.btnSaySelection, "Send the sound codes in the Say Data window to the SpeakJet.");
			this.ToolTipMain.SetToolTip(this.bntSayIt, "Send the sound codes in the Say Data window to the SpeakJet.");
			this.ToolTipMain.SetToolTip(this.btnClear, "Clear the Say Data window.");
			this.ToolTipMain.SetToolTip(this.Command2, "View the sound codes in the Say Data window.");
			this.ToolTipMain.SetToolTip(this.btnCodes, "View the sound codes in the Say Data window.");
			this.ToolTipMain.SetToolTip(this._Command1_140, "Reset all controls back to defaults");
			this.ToolTipMain.SetToolTip(this.lblVolume, "Set the Master Volume Level");
			this.ToolTipMain.SetToolTip(this.lblSpeed, "Set the Play Speed");
			this.ToolTipMain.SetToolTip(this.lblPitch, "Set the Vocalization Pitch");
			this.ToolTipMain.SetToolTip(this.lblBend, "Set the Frequency Bend");
			this.ToolTipMain.SetToolTip(this._Command1_126, "WOW effect");
			this.ToolTipMain.SetToolTip(this._Command1_124, "Sonar Ping");
			this.ToolTipMain.SetToolTip(this._Command1_125, "Pistol Shot");
			this.ToolTipMain.SetToolTip(this._Command1_54, "Church, Feature, March");
			this.ToolTipMain.SetToolTip(this._Command1_55, "Help, Hand, Hair");
			this.ToolTipMain.SetToolTip(this._Command1_56, "Hoe, Hot, Hug");
			this.ToolTipMain.SetToolTip(this._Command1_57, "who, whale, White");
			this.ToolTipMain.SetToolTip(this._Command1_58, "Food, Effort, Off");
			this.ToolTipMain.SetToolTip(this._Command1_59, "See, Vest, Plus");
			this.ToolTipMain.SetToolTip(this._Command1_60, "So, Sweat");
			this.ToolTipMain.SetToolTip(this._Command1_61, "Ship, Fiction, Leash");
			this.ToolTipMain.SetToolTip(this._Command1_62, "Thin, month");
			this.ToolTipMain.SetToolTip(this._Command1_37, "Dodge, Jet, Savage");
			this.ToolTipMain.SetToolTip(this._Command1_38, "Vest, Even, Twelve");
			this.ToolTipMain.SetToolTip(this._Command1_39, "Zoo, Zap");
			this.ToolTipMain.SetToolTip(this._Command1_40, "Azure, Treasure");
			this.ToolTipMain.SetToolTip(this._Command1_41, "There, That, This");
			this.ToolTipMain.SetToolTip(this._Command1_63, "Part, Little, Sit");
			this.ToolTipMain.SetToolTip(this._Command1_64, "To, Talk, Ten");
			this.ToolTipMain.SetToolTip(this._Command1_65, "Parts, Costs, Robots");
			this.ToolTipMain.SetToolTip(this._Command1_66, "Can't, Clown, Key");
			this.ToolTipMain.SetToolTip(this._Command1_67, "Comb, Quick, Fox");
			this.ToolTipMain.SetToolTip(this._Command1_68, "Speak, Task");
			this.ToolTipMain.SetToolTip(this._Command1_69, "Book, Took, October");
			this.ToolTipMain.SetToolTip(this._Command1_70, "People, Computer");
			this.ToolTipMain.SetToolTip(this._Command1_71, "Pow, Copy");
			this.ToolTipMain.SetToolTip(this._Command1_42, "Bear, Bird, Beed");
			this.ToolTipMain.SetToolTip(this._Command1_43, "Bone, Book Brown");
			this.ToolTipMain.SetToolTip(this._Command1_44, "Cab, Crib, Web");
			this.ToolTipMain.SetToolTip(this._Command1_45, "Bob, Sub, Tub");
			this.ToolTipMain.SetToolTip(this._Command1_46, "Deep, Date, Divide");
			this.ToolTipMain.SetToolTip(this._Command1_47, "Do, Dust, Dog");
			this.ToolTipMain.SetToolTip(this._Command1_48, "Could, Bird");
			this.ToolTipMain.SetToolTip(this._Command1_49, "Bud, Food");
			this.ToolTipMain.SetToolTip(this._Command1_50, "Get, Gate, Guest,");
			this.ToolTipMain.SetToolTip(this._Command1_51, "Got, Glue, Goo");
			this.ToolTipMain.SetToolTip(this._Command1_52, "Peg, Wig");
			this.ToolTipMain.SetToolTip(this._Command1_53, "Dog, Hog");
			this.ToolTipMain.SetToolTip(this._Command1_25, "Gate, Ate, Ray");
			this.ToolTipMain.SetToolTip(this._Command1_26, "Mice, Fight, White");
			this.ToolTipMain.SetToolTip(this._Command1_27, "Boy, Toy, Voice");
			this.ToolTipMain.SetToolTip(this._Command1_30, "Saddle, Angle, Spell");
			this.ToolTipMain.SetToolTip(this._Command1_28, "Sky, Five, I");
			this.ToolTipMain.SetToolTip(this._Command1_31, "Cute, Few, Computer");
			this.ToolTipMain.SetToolTip(this._Command1_34, "Two, New, Zoo");
			this.ToolTipMain.SetToolTip(this._Command1_33, "Brown, Clown, Thousand");
			this.ToolTipMain.SetToolTip(this._Command1_35, "Our, Ouch, Owl");
			this.ToolTipMain.SetToolTip(this._Command1_36, "Go, Hello, Snow");
			this.ToolTipMain.SetToolTip(this._Command1_29, "Yes, Yarn, Million");
			this.ToolTipMain.SetToolTip(this._Command1_11, "Milk, Famous, Broom");
			this.ToolTipMain.SetToolTip(this._Command1_12, "Nip, Danger, Thin");
			this.ToolTipMain.SetToolTip(this._Command1_13, "No, Snow, On");
			this.ToolTipMain.SetToolTip(this._Command1_14, "Think, Ping");
			this.ToolTipMain.SetToolTip(this._Command1_15, "Hung, Song");
			this.ToolTipMain.SetToolTip(this._Command1_16, "Lake, Alarm, Lapel");
			this.ToolTipMain.SetToolTip(this._Command1_17, "Clock, Plus, Hello");
			this.ToolTipMain.SetToolTip(this._Command1_18, "Wool, Sweat");
			this.ToolTipMain.SetToolTip(this._Command1_4, "Hat, Fast, Fan");
			this.ToolTipMain.SetToolTip(this._Command1_3, "Met, Check, Red");
			this.ToolTipMain.SetToolTip(this._Command1_2, "Hair, Gate, Beige");
			this.ToolTipMain.SetToolTip(this._Command1_1, "Sit, Fix, Pin");
			this.ToolTipMain.SetToolTip(this._Command1_32, "Blue, Food");
			this.ToolTipMain.SetToolTip(this._Command1_0, "See, Even, Feed");
			this.ToolTipMain.SetToolTip(this._Command1_5, "Luck, Jump, Plus");
			this.ToolTipMain.SetToolTip(this._Command1_6, "Father, Fall");
			this.ToolTipMain.SetToolTip(this._Command1_7, "Hot, Clock, Fox");
			this.ToolTipMain.SetToolTip(this._Command1_8, "Comb, Over, Hold");
			this.ToolTipMain.SetToolTip(this._Command1_9, "Book, Could, Should");
			this.ToolTipMain.SetToolTip(this._Command1_10, "Food, June");
			this.Activated += new System.EventHandler(this.Form_Activated);
			this.Closed += new System.EventHandler(this.Form_Closed);
			this.Frame16.ResumeLayout(false);
			this.Frame15.ResumeLayout(false);
			this.Frame14.ResumeLayout(false);
			this.Frame13.ResumeLayout(false);
			this.Frame12.ResumeLayout(false);
			this.Frame11.ResumeLayout(false);
			this.Frame10.ResumeLayout(false);
			this.Frame9.ResumeLayout(false);
			this.Frame8.ResumeLayout(false);
			this.Frame7.ResumeLayout(false);
			this.Frame2.ResumeLayout(false);
			this.Frame6.ResumeLayout(false);
			this.Frame5.ResumeLayout(false);
			this.Frame4.ResumeLayout(false);
			this.Frame3.ResumeLayout(false);
			this.Frame1.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		void ReLoadForm(bool addEvents)
		{
			InitializeCommand1();
		}
		void InitializeCommand1()
		{
			this.Command1 = new System.Windows.Forms.Label[198];
			this.Command1[156] = _Command1_156;
			this.Command1[127] = _Command1_127;
			this.Command1[137] = _Command1_137;
			this.Command1[138] = _Command1_138;
			this.Command1[158] = _Command1_158;
			this.Command1[129] = _Command1_129;
			this.Command1[131] = _Command1_131;
			this.Command1[134] = _Command1_134;
			this.Command1[132] = _Command1_132;
			this.Command1[130] = _Command1_130;
			this.Command1[133] = _Command1_133;
			this.Command1[128] = _Command1_128;
			this.Command1[139] = _Command1_139;
			this.Command1[197] = _Command1_197;
			this.Command1[192] = _Command1_192;
			this.Command1[187] = _Command1_187;
			this.Command1[182] = _Command1_182;
			this.Command1[177] = _Command1_177;
			this.Command1[175] = _Command1_175;
			this.Command1[172] = _Command1_172;
			this.Command1[170] = _Command1_170;
			this.Command1[165] = _Command1_165;
			this.Command1[160] = _Command1_160;
			this.Command1[152] = _Command1_152;
			this.Command1[147] = _Command1_147;
			this.Command1[196] = _Command1_196;
			this.Command1[195] = _Command1_195;
			this.Command1[194] = _Command1_194;
			this.Command1[191] = _Command1_191;
			this.Command1[190] = _Command1_190;
			this.Command1[189] = _Command1_189;
			this.Command1[186] = _Command1_186;
			this.Command1[185] = _Command1_185;
			this.Command1[184] = _Command1_184;
			this.Command1[181] = _Command1_181;
			this.Command1[180] = _Command1_180;
			this.Command1[179] = _Command1_179;
			this.Command1[176] = _Command1_176;
			this.Command1[174] = _Command1_174;
			this.Command1[171] = _Command1_171;
			this.Command1[169] = _Command1_169;
			this.Command1[166] = _Command1_166;
			this.Command1[164] = _Command1_164;
			this.Command1[161] = _Command1_161;
			this.Command1[159] = _Command1_159;
			this.Command1[153] = _Command1_153;
			this.Command1[151] = _Command1_151;
			this.Command1[148] = _Command1_148;
			this.Command1[146] = _Command1_146;
			this.Command1[24] = _Command1_24;
			this.Command1[23] = _Command1_23;
			this.Command1[22] = _Command1_22;
			this.Command1[21] = _Command1_21;
			this.Command1[20] = _Command1_20;
			this.Command1[19] = _Command1_19;
			this.Command1[141] = _Command1_141;
			this.Command1[154] = _Command1_154;
			this.Command1[142] = _Command1_142;
			this.Command1[143] = _Command1_143;
			this.Command1[136] = _Command1_136;
			this.Command1[135] = _Command1_135;
			this.Command1[140] = _Command1_140;
			this.Command1[126] = _Command1_126;
			this.Command1[123] = _Command1_123;
			this.Command1[122] = _Command1_122;
			this.Command1[91] = _Command1_91;
			this.Command1[101] = _Command1_101;
			this.Command1[81] = _Command1_81;
			this.Command1[111] = _Command1_111;
			this.Command1[121] = _Command1_121;
			this.Command1[90] = _Command1_90;
			this.Command1[100] = _Command1_100;
			this.Command1[80] = _Command1_80;
			this.Command1[110] = _Command1_110;
			this.Command1[120] = _Command1_120;
			this.Command1[89] = _Command1_89;
			this.Command1[99] = _Command1_99;
			this.Command1[79] = _Command1_79;
			this.Command1[109] = _Command1_109;
			this.Command1[119] = _Command1_119;
			this.Command1[88] = _Command1_88;
			this.Command1[98] = _Command1_98;
			this.Command1[78] = _Command1_78;
			this.Command1[108] = _Command1_108;
			this.Command1[118] = _Command1_118;
			this.Command1[87] = _Command1_87;
			this.Command1[97] = _Command1_97;
			this.Command1[77] = _Command1_77;
			this.Command1[107] = _Command1_107;
			this.Command1[117] = _Command1_117;
			this.Command1[86] = _Command1_86;
			this.Command1[96] = _Command1_96;
			this.Command1[76] = _Command1_76;
			this.Command1[106] = _Command1_106;
			this.Command1[116] = _Command1_116;
			this.Command1[85] = _Command1_85;
			this.Command1[95] = _Command1_95;
			this.Command1[75] = _Command1_75;
			this.Command1[105] = _Command1_105;
			this.Command1[115] = _Command1_115;
			this.Command1[84] = _Command1_84;
			this.Command1[94] = _Command1_94;
			this.Command1[74] = _Command1_74;
			this.Command1[104] = _Command1_104;
			this.Command1[114] = _Command1_114;
			this.Command1[83] = _Command1_83;
			this.Command1[93] = _Command1_93;
			this.Command1[73] = _Command1_73;
			this.Command1[103] = _Command1_103;
			this.Command1[113] = _Command1_113;
			this.Command1[82] = _Command1_82;
			this.Command1[92] = _Command1_92;
			this.Command1[72] = _Command1_72;
			this.Command1[102] = _Command1_102;
			this.Command1[112] = _Command1_112;
			this.Command1[124] = _Command1_124;
			this.Command1[125] = _Command1_125;
			this.Command1[54] = _Command1_54;
			this.Command1[55] = _Command1_55;
			this.Command1[56] = _Command1_56;
			this.Command1[57] = _Command1_57;
			this.Command1[58] = _Command1_58;
			this.Command1[59] = _Command1_59;
			this.Command1[60] = _Command1_60;
			this.Command1[61] = _Command1_61;
			this.Command1[62] = _Command1_62;
			this.Command1[37] = _Command1_37;
			this.Command1[38] = _Command1_38;
			this.Command1[39] = _Command1_39;
			this.Command1[40] = _Command1_40;
			this.Command1[41] = _Command1_41;
			this.Command1[63] = _Command1_63;
			this.Command1[64] = _Command1_64;
			this.Command1[65] = _Command1_65;
			this.Command1[66] = _Command1_66;
			this.Command1[67] = _Command1_67;
			this.Command1[68] = _Command1_68;
			this.Command1[69] = _Command1_69;
			this.Command1[70] = _Command1_70;
			this.Command1[71] = _Command1_71;
			this.Command1[42] = _Command1_42;
			this.Command1[43] = _Command1_43;
			this.Command1[44] = _Command1_44;
			this.Command1[45] = _Command1_45;
			this.Command1[46] = _Command1_46;
			this.Command1[47] = _Command1_47;
			this.Command1[48] = _Command1_48;
			this.Command1[49] = _Command1_49;
			this.Command1[50] = _Command1_50;
			this.Command1[51] = _Command1_51;
			this.Command1[52] = _Command1_52;
			this.Command1[53] = _Command1_53;
			this.Command1[25] = _Command1_25;
			this.Command1[26] = _Command1_26;
			this.Command1[27] = _Command1_27;
			this.Command1[30] = _Command1_30;
			this.Command1[28] = _Command1_28;
			this.Command1[31] = _Command1_31;
			this.Command1[34] = _Command1_34;
			this.Command1[33] = _Command1_33;
			this.Command1[35] = _Command1_35;
			this.Command1[36] = _Command1_36;
			this.Command1[29] = _Command1_29;
			this.Command1[11] = _Command1_11;
			this.Command1[12] = _Command1_12;
			this.Command1[13] = _Command1_13;
			this.Command1[14] = _Command1_14;
			this.Command1[15] = _Command1_15;
			this.Command1[16] = _Command1_16;
			this.Command1[17] = _Command1_17;
			this.Command1[18] = _Command1_18;
			this.Command1[4] = _Command1_4;
			this.Command1[3] = _Command1_3;
			this.Command1[2] = _Command1_2;
			this.Command1[1] = _Command1_1;
			this.Command1[32] = _Command1_32;
			this.Command1[0] = _Command1_0;
			this.Command1[5] = _Command1_5;
			this.Command1[6] = _Command1_6;
			this.Command1[7] = _Command1_7;
			this.Command1[8] = _Command1_8;
			this.Command1[9] = _Command1_9;
			this.Command1[10] = _Command1_10;
		}
		#endregion
	}
}