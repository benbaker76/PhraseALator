using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;

namespace PhraseALator
{
    internal partial class frmUtility : Form
    {
        public SerialPort SerialPort;

        public string PhraseToMove = "";
        public string WordToMove = "";
        public string SpeakJetCodes = "";

        public frmUtility()
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

        private void btnDictEdit_Click(Object eventSender, EventArgs eventArgs)
        {
            frmDictEdit.DefInstance.ShowDialog(this);
        }

        private void btnDone_Click(Object eventSender, EventArgs eventArgs)
        {
            this.Close();
        }

        private void Command1_Click(Object eventSender, EventArgs eventArgs)
        {
            frmBaudRate.DefInstance.ShowDialog(this);
        }

        private void btnSetSerialPort_Click(Object eventSender, EventArgs eventArgs)
        {
            frmButtons.DefInstance.ShowDialog(this);
        }

        private void btnSynth_Click(Object eventSender, EventArgs eventArgs)
        {
            FrmSynthCtrl.DefInstance.ShowDialog(this);
        }

        private void cmdTestSerialPort_Click(Object eventSender, EventArgs eventArgs)
        {
            Module1.SendDataToSpeakJet(Strings.Chr(Module1.cvRESET).ToString() + "\\0VX", false);
        }

        private void EditEEPROM_Click(Object eventSender, EventArgs eventArgs)
        {
            frmEEPROM.DefInstance.ShowDialog(this);
        }

        private void EditPhrases_Click(Object eventSender, EventArgs eventArgs)
        {
            frmUtility.DefInstance.PhraseToMove = "";
            frmUtility.DefInstance.WordToMove = "";
            frmPhrase.DefInstance.ShowDialog(this);
        }

        private void Form_Load()
        {
            SerialPort = new SerialPort();
            frmUtility.DefInstance.txtComPort.Text = Module1.ReadINI("Serial", "Port", "1");
            frmUtility.DefInstance.chkFlow.CheckState = Module1.ReadINI("Serial", "FlowControl", CheckState.Checked);
            Module1.InitPhoneneNames();
        }

        private void Timer1_Tick(Object eventSender, EventArgs eventArgs)
        {
            Module1.CloseSerialPort();
            Timer1.Enabled = false;
        }

        private void txtComPort_Leave(Object eventSender, EventArgs eventArgs)
        {
            Module1.CloseSerialPort();
            txtComPort.BackColor = Color.White;
        }

        private void Form_Closed(Object eventSender, EventArgs eventArgs)
        {
            Module1.CloseSerialPort();
            Module1.WriteINI("Serial", "Port", frmUtility.DefInstance.txtComPort.Text);
            Module1.WriteINI("Serial", "FlowControl", frmUtility.DefInstance.chkFlow.CheckState);
        }

        [STAThread]
        static void Main()
        {
            Application.Run(CreateInstance());
        }
    }
}