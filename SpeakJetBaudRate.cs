using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

namespace PhraseALator
{
    internal partial class frmBaudRate : Form
    {
        public frmBaudRate()
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
                        //For the start-up form, the first instance created is the default instance.
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

            isInitializingComponent = true;
            InitializeComponent();
            isInitializingComponent = false;
            ReLoadForm(false);
        }


        private void frmBaudRate_Activated(Object eventSender, EventArgs eventArgs)
        {
            if (Globals.ActiveForm != eventSender)
            {
                Globals.ActiveForm = (Form)eventSender;
            }
        }

        private void btnDone_Click(Object eventSender, EventArgs eventArgs)
        {
            this.Close();
        }

        private void btnSendDetuneValue_Click(Object eventSender, EventArgs eventArgs)
        {
            byte DetuneValue = 0;
            string ProgramString = "";

            if (MessageBox.Show("If you do not know what you are doing..." + Environment.NewLine + "then hit Cancel and DO NOT change the Detune value!" + Environment.NewLine + Environment.NewLine + "Do you know how to properly set this value?", Application.ProductName, MessageBoxButtons.YesNoCancel) == System.Windows.Forms.DialogResult.Yes)
            {
                if (MessageBox.Show("Do you want to do abort this function.", Application.ProductName, MessageBoxButtons.YesNoCancel) == System.Windows.Forms.DialogResult.No)
                {
                    if (MessageBox.Show("Do you want to set the detune value to " + txtClockAdj.Text + "?", Application.ProductName, MessageBoxButtons.YesNoCancel) == System.Windows.Forms.DialogResult.Yes)
                    {
                        // Clock Adjust
                        if (txtClockAdj.Text.StartsWith("&H"))
                        {
                            DetuneValue = Convert.ToByte(Convert.ToInt32(txtClockAdj.Text) % 255);
                            ProgramString = ProgramString + "\\0";
                            ProgramString = ProgramString + "235" + "J";
                            ProgramString = ProgramString + "32" + "H";
                            ProgramString = ProgramString + Module1.dhex(DetuneValue) + "N";
                        }
                    }
                }
            }

            Module1.SendDataToSpeakJet(ProgramString, false);
        }

        private void btnSendSyncChar_Click(Object eventSender, EventArgs eventArgs)
        {
            Module1.SendDataToSpeakJet(Strings.Chr(85).ToString(), false);
        }

        private void Form_Load()
        {

            string tempRefParam = "Serial";
            string tempRefParam2 = "9600";
            string BaudRate = Module1.ReadINI(tempRefParam, "BaudRate", tempRefParam2);
            switch (BaudRate)
            {
                case "2400":
                    Option1[1].Checked = true;
                    break;
                case "4800":
                    Option1[2].Checked = true;
                    break;
                case "9600":
                    Option1[3].Checked = true;
                    break;
                case "19200":
                    Option1[4].Checked = true;
                    break;
            }
        }

        private bool isInitializingComponent;
        private void Option1_CheckedChanged(Object eventSender, EventArgs eventArgs)
        {
            int Index = Array.IndexOf(this.Option1, eventSender);
            if (((RadioButton)eventSender).Checked)
            {
                if (isInitializingComponent)
                {
                    return;
                }
                string BaudRate = "";

                switch (Index)
                {
                    case 1:
                        BaudRate = "2400";
                        break;
                    case 2:
                        BaudRate = "4800";
                        break;
                    case 3:
                        BaudRate = "9600";
                        break;
                    case 4:
                        BaudRate = "19200";
                        break;
                }

                Module1.CloseSerialPort();
                Module1.WriteINI("Serial", "BaudRate", BaudRate);
            }
        }
        private void Form_Closed(Object eventSender, EventArgs eventArgs)
        {
        }
    }
}