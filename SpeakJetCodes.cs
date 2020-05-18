using System;
using System.Windows.Forms;

namespace PhraseALator
{
    internal partial class frmCodes : Form
    {
        public frmCodes()
            : base()
        {
            if (m_vb6FormDefInstance == null)
            {
                if (m_InitializingDefInstance)
                {
                    m_vb6FormDefInstance = this;
                }
                else
                {
                    try
                    {
                        if (System.Reflection.Assembly.GetExecutingAssembly().EntryPoint != null && System.Reflection.Assembly.GetExecutingAssembly().EntryPoint.DeclaringType == this.GetType())
                        {
                            m_vb6FormDefInstance = this;
                        }
                    }
                    catch
                    {
                    }
                }
            }

            InitializeComponent();
        }


        private void frmCodes_Activated(Object eventSender, EventArgs eventArgs)
        {
            if (Globals.ActiveForm != eventSender)
            {
                Globals.ActiveForm = (Form)eventSender;
            }
        }

        private void btnCopy_Click(Object eventSender, EventArgs eventArgs)
        {
            Clipboard.Clear();
            Clipboard.SetText(txtCodes.Text);
        }

        private void btnDone_Click(Object eventSender, EventArgs eventArgs)
        {
            this.Close();
        }

        private void Form_Load()
        {
            txtCodes.Text = frmUtility.DefInstance.SpeakJetCodes;
        }

        private void Form_Closed(Object eventSender, EventArgs eventArgs)
        {
        }
    }
}