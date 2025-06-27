
namespace PhraseALator
{
	partial class frmCodes
	{

		#region "Upgrade Support "
		private static frmCodes m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static frmCodes DefInstance
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
		public static frmCodes CreateInstance()
		{
			frmCodes theInstance = new frmCodes();
			theInstance.Form_Load();
			return theInstance;
		}
		private string[] visualControls = new string[]{"components", "ToolTipMain", "btnDone", "btnCopy", "txtCodes"};
		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ToolTip ToolTipMain;
		public System.Windows.Forms.Button btnDone;
		public System.Windows.Forms.Button btnCopy;
		public System.Windows.Forms.RichTextBox txtCodes;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.ToolTipMain = new System.Windows.Forms.ToolTip(this.components);
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.txtCodes = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnCopy
            // 
            this.btnCopy.AllowDrop = true;
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.BackColor = System.Drawing.SystemColors.Control;
            this.btnCopy.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCopy.Location = new System.Drawing.Point(716, 670);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCopy.Size = new System.Drawing.Size(226, 56);
            this.btnCopy.TabIndex = 1;
            this.btnCopy.Text = "Copy to Clipboard";
            this.btnCopy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ToolTipMain.SetToolTip(this.btnCopy, "Copy the numeric SpeakJet codes to the windows Clipboard.");
            this.btnCopy.UseVisualStyleBackColor = false;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnDone
            // 
            this.btnDone.AllowDrop = true;
            this.btnDone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDone.BackColor = System.Drawing.SystemColors.Control;
            this.btnDone.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDone.Location = new System.Drawing.Point(24, 670);
            this.btnDone.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnDone.Name = "btnDone";
            this.btnDone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDone.Size = new System.Drawing.Size(154, 56);
            this.btnDone.TabIndex = 2;
            this.btnDone.Text = "Done";
            this.btnDone.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // txtCodes
            // 
            this.txtCodes.AllowDrop = true;
            this.txtCodes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodes.Location = new System.Drawing.Point(24, 35);
            this.txtCodes.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtCodes.Name = "txtCodes";
            this.txtCodes.Size = new System.Drawing.Size(918, 602);
            this.txtCodes.TabIndex = 0;
            this.txtCodes.Text = "";
            // 
            // frmCodes
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(978, 758);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.txtCodes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Location = new System.Drawing.Point(4, 24);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCodes";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SpeakJet Codes";
            this.Closed += new System.EventHandler(this.Form_Closed);
            this.ResumeLayout(false);

		}
		#endregion
	}
}