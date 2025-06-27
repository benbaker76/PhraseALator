
namespace PhraseALator
{
	partial class frmDictEdit
	{

		#region "Upgrade Support "
		private static frmDictEdit m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static frmDictEdit DefInstance
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
		public static frmDictEdit CreateInstance()
		{
			frmDictEdit theInstance = new frmDictEdit();
			theInstance.Form_Load();
			return theInstance;
		}
		private string[] visualControls = new string[]{"components", "ToolTipMain", "btnEraseBlank", "btnFind", "btnDone", "btnSort", "btnSaveChanges", "txtDictionary", "btnReadTerms"};
		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ToolTip ToolTipMain;
		public System.Windows.Forms.Button btnEraseBlank;
		public System.Windows.Forms.Button btnFind;
		public System.Windows.Forms.Button btnDone;
		public System.Windows.Forms.Button btnSort;
		public System.Windows.Forms.Button btnSaveChanges;
		public System.Windows.Forms.RichTextBox txtDictionary;
		public System.Windows.Forms.Button btnReadTerms;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDictEdit));
			this.ToolTipMain = new System.Windows.Forms.ToolTip(this.components);
			this.btnEraseBlank = new System.Windows.Forms.Button();
			this.btnFind = new System.Windows.Forms.Button();
			this.btnDone = new System.Windows.Forms.Button();
			this.btnSort = new System.Windows.Forms.Button();
			this.btnSaveChanges = new System.Windows.Forms.Button();
			this.txtDictionary = new System.Windows.Forms.RichTextBox();
			this.btnReadTerms = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnEraseBlank
			// 
			this.btnEraseBlank.AllowDrop = true;
			this.btnEraseBlank.BackColor = System.Drawing.SystemColors.Control;
			this.btnEraseBlank.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnEraseBlank.Location = new System.Drawing.Point(604, 62);
			this.btnEraseBlank.Name = "btnEraseBlank";
			this.btnEraseBlank.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnEraseBlank.Size = new System.Drawing.Size(83, 39);
			this.btnEraseBlank.TabIndex = 6;
			this.btnEraseBlank.Text = "Erase Blank Entries";
			this.btnEraseBlank.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnEraseBlank.UseVisualStyleBackColor = false;
			this.btnEraseBlank.Click += new System.EventHandler(this.btnEraseBlank_Click);
			// 
			// btnFind
			// 
			this.btnFind.AllowDrop = true;
			this.btnFind.BackColor = System.Drawing.SystemColors.Control;
			this.btnFind.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnFind.Location = new System.Drawing.Point(604, 236);
			this.btnFind.Name = "btnFind";
			this.btnFind.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnFind.Size = new System.Drawing.Size(83, 29);
			this.btnFind.TabIndex = 5;
			this.btnFind.Text = "Find";
			this.btnFind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnFind.UseVisualStyleBackColor = false;
			this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
			// 
			// btnDone
			// 
			this.btnDone.AllowDrop = true;
			this.btnDone.BackColor = System.Drawing.SystemColors.Control;
			this.btnDone.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnDone.Location = new System.Drawing.Point(604, 464);
			this.btnDone.Name = "btnDone";
			this.btnDone.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnDone.Size = new System.Drawing.Size(83, 29);
			this.btnDone.TabIndex = 4;
			this.btnDone.Text = "Done";
			this.btnDone.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnDone.UseVisualStyleBackColor = false;
			this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
			// 
			// btnSort
			// 
			this.btnSort.AllowDrop = true;
			this.btnSort.BackColor = System.Drawing.SystemColors.Control;
			this.btnSort.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnSort.Location = new System.Drawing.Point(604, 364);
			this.btnSort.Name = "btnSort";
			this.btnSort.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnSort.Size = new System.Drawing.Size(83, 29);
			this.btnSort.TabIndex = 3;
			this.btnSort.Text = "Save && Sort";
			this.btnSort.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnSort.UseVisualStyleBackColor = false;
			this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
			// 
			// btnSaveChanges
			// 
			this.btnSaveChanges.AllowDrop = true;
			this.btnSaveChanges.BackColor = System.Drawing.SystemColors.Control;
			this.btnSaveChanges.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnSaveChanges.Location = new System.Drawing.Point(604, 400);
			this.btnSaveChanges.Name = "btnSaveChanges";
			this.btnSaveChanges.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnSaveChanges.Size = new System.Drawing.Size(83, 29);
			this.btnSaveChanges.TabIndex = 2;
			this.btnSaveChanges.Text = "Save Changes";
			this.btnSaveChanges.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnSaveChanges.UseVisualStyleBackColor = false;
			this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
			// 
			// txtDictionary
			// 
			this.txtDictionary.AllowDrop = true;
			this.txtDictionary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtDictionary.Location = new System.Drawing.Point(4, 4);
			this.txtDictionary.Name = "txtDictionary";
			this.txtDictionary.RightMargin = 6667;
			this.txtDictionary.Rtf = resources.GetString("txtDictionary.TextRTF");
			this.txtDictionary.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Both;
			this.txtDictionary.Size = new System.Drawing.Size(595, 493);
			this.txtDictionary.TabIndex = 1;
			// 
			// btnReadTerms
			// 
			this.btnReadTerms.AllowDrop = true;
			this.btnReadTerms.BackColor = System.Drawing.SystemColors.Control;
			this.btnReadTerms.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnReadTerms.Location = new System.Drawing.Point(604, 14);
			this.btnReadTerms.Name = "btnReadTerms";
			this.btnReadTerms.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnReadTerms.Size = new System.Drawing.Size(83, 41);
			this.btnReadTerms.TabIndex = 0;
			this.btnReadTerms.Text = "Import New Words";
			this.btnReadTerms.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnReadTerms.UseVisualStyleBackColor = false;
			this.btnReadTerms.Click += new System.EventHandler(this.btnReadTerms_Click);
			// 
			// frmDictEdit
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(690, 500);
			this.Controls.Add(this.btnEraseBlank);
			this.Controls.Add(this.btnFind);
			this.Controls.Add(this.btnDone);
			this.Controls.Add(this.btnSort);
			this.Controls.Add(this.btnSaveChanges);
			this.Controls.Add(this.txtDictionary);
			this.Controls.Add(this.btnReadTerms);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Location = new System.Drawing.Point(3, 23);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmDictEdit";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SpeakJet Dictionary Editor";
			this.Closed += new System.EventHandler(this.Form_Closed);
			this.ResumeLayout(false);
		}
		#endregion
	}
}