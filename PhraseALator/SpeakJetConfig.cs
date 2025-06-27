using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

namespace PhraseALator
{
    internal partial class frmButtons : Form
    {

        public frmButtons()
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
            ReLoadForm(false);
        }


        private void frmButtons_Activated(Object eventSender, EventArgs eventArgs)
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

        private void btnWrite_Click(Object eventSender, EventArgs eventArgs)
        {
            byte ControlValue = 0;
            string EEPROMPhraseString = "";
            string ButtonString = "";

            btnWrite.Enabled = false;
            Cursor = Cursors.WaitCursor;
            Application.DoEvents();

            // Shut the SpeakJet up - just in case.
            string ProgramString = "\\0RX";

            // Calculate the Control Values for the 16 Button functions
            for (byte X = 0; X <= 15; X = (byte)(X + 1))
            {
                // Add up the Binary Bit values for each Button Control Byte
                ControlValue = Convert.ToByte(Convert.ToInt32((Convert.ToInt32(Double.Parse(txtPhrase[X].Text)) & 15).ToString()));
                if (chRestart[X].CheckState == CheckState.Unchecked)
                {
                    ControlValue = (byte)(ControlValue + 16);
                }
                if (chInt[X].CheckState == CheckState.Checked)
                {
                    ControlValue = (byte)(ControlValue + 32);
                }
                if (chClear[X].CheckState == CheckState.Unchecked)
                {
                    ControlValue = (byte)(ControlValue + 64);
                }
                if (chPlay[X].CheckState == CheckState.Unchecked)
                {
                    ControlValue = (byte)(ControlValue + 128);
                }
                // Send the Button Control Byte to the EEPROM
                ProgramString = ProgramString + "\\0";
                ProgramString = ProgramString + (X + 240).ToString() + "J";
                ProgramString = ProgramString + "32" + "H";
                ProgramString = ProgramString + Module1.dhex(ControlValue) + "N";
            }

            // Caclulate the Control Value for the Startup Phrase
            ControlValue = Convert.ToByte(Convert.ToInt32((Convert.ToInt32(Double.Parse(txtPhrase[16].Text)) & 15).ToString()));
            ControlValue = (byte)(ControlValue + 16);
            ControlValue = (byte)(ControlValue + 32);
            ControlValue = (byte)(ControlValue + 64);
            if (chPlay[16].CheckState == CheckState.Unchecked)
            {
                ControlValue = (byte)(ControlValue + 128);
            }
            // Send the Control Byte to the EEPROM
            ProgramString = ProgramString + "\\0";
            ProgramString = ProgramString + "237" + "J";
            ProgramString = ProgramString + "32" + "H";
            ProgramString = ProgramString + Module1.dhex(ControlValue) + "N";

            // Caclulate the Control Value for the PCtrl, Auto Silence, RC/TTL Mode
            ControlValue = 0;
            if (optIO[4].Checked)
            {
                ControlValue = (byte)(ControlValue + 1);
            }
            if (optIO[6].Checked)
            {
                ControlValue = (byte)(ControlValue + 2);
            }
            if (optIO[8].Checked)
            {
                ControlValue = (byte)(ControlValue + 4);
            }
            if (chAutoSil.CheckState == CheckState.Checked)
            {
                ControlValue = (byte)(ControlValue + 8);
            }
            if (optIO[0].Checked)
            {
                ControlValue = (byte)(ControlValue + 16);
            }
            if (optIO[2].Checked)
            {
                ControlValue = (byte)(ControlValue + 32);
            }
            ControlValue = (byte)(ControlValue + 64);
            ControlValue = (byte)(ControlValue + 128);
            // Send the Control Byte to the EEPROM
            ProgramString = ProgramString + "\\0";
            ProgramString = ProgramString + "238" + "J";
            ProgramString = ProgramString + "32" + "H";
            ProgramString = ProgramString + Module1.dhex(ControlValue) + "N";

            // Caclulate the Control Value for the SCP-node, POut
            ControlValue = 0;
            if (optIO[10].Checked)
            {
                ControlValue = (byte)(ControlValue + 1);
            }
            if (optIO[12].Checked)
            {
                ControlValue = (byte)(ControlValue + 2);
            }
            if (optIO[14].Checked)
            {
                ControlValue = (byte)(ControlValue + 4);
            }
            ControlValue = (byte)(ControlValue + 8);
            ControlValue = (byte)(ControlValue + ((Convert.ToInt32(txtSCPNode.Text) & 7) * 16));
            ControlValue = (byte)(ControlValue + 128);
            // Send the Control Byte to the EEPROM
            ProgramString = ProgramString + "\\0";
            ProgramString = ProgramString + "239" + "J";
            ProgramString = ProgramString + "32" + "H";
            ProgramString = ProgramString + Module1.dhex(ControlValue) + "N";

            // Do a hard reset of the chip
            ProgramString = ProgramString + "\\0W";

            // Send some pauses just to wait for the reset to finish
            ProgramString = ProgramString + Strings.Chr(Module1.cvP0).ToString() + Strings.Chr(Module1.cvP0).ToString() + Strings.Chr(Module1.cvP0).ToString() + Strings.Chr(Module1.cvP0).ToString() + Strings.Chr(Module1.cvP0).ToString();

            // Say "READY"
            ProgramString = ProgramString + "\\0VX";

            // Send all that to the SpeakJet
            Module1.SendDataToSpeakJet(ProgramString, false);

            Cursor = Cursors.Default;
            btnWrite.Enabled = true;
            Application.DoEvents();
        }

        private void btnShutUp_Click(Object eventSender, EventArgs eventArgs)
        {
            Module1.gSerialDataBeingSent = "";
            Module1.SendDataToSpeakJet("\\0RX" + Strings.Chr(Module1.cvRESET).ToString() + Strings.Chr(Module1.cvP0).ToString(), false);
        }

        private void Form_Load()
        {
            // Load the current state
            for (byte X = 0; X <= 15; X = (byte)(X + 1))
            {
                chPlay[X].CheckState = Module1.ReadINI("EEPROM", "Play" + X.ToString(), CheckState.Unchecked);
                chClear[X].CheckState = Module1.ReadINI("EEPROM", "Clear" + X.ToString(), CheckState.Unchecked);
                chRestart[X].CheckState = Module1.ReadINI("EEPROM", "Restart" + X.ToString(), CheckState.Unchecked);
                chInt[X].CheckState = Module1.ReadINI("EEPROM", "Interupt" + X.ToString(), CheckState.Unchecked);
                txtPhrase[X].Text = Module1.ReadINI("EEPROM", "PhraseToPlay" + X.ToString(), "0");
            }
            chPlay[16].CheckState = Module1.ReadINI("EEPROM", "Play" + "16", CheckState.Unchecked);
            txtPhrase[16].Text = Module1.ReadINI("EEPROM", "PhraseToPlay" + "16", "0");
            for (byte X = 0; X <= 15; X = (byte)(X + 1))
            {
                bool tempBool = false;
                string auxVar = Module1.ReadINI("EEPROM", Convert.ToString(optIO[X].Tag), "0");
                if (optIO[X].Checked != ((Boolean.TryParse(auxVar, out tempBool)) ? tempBool : Convert.ToBoolean(Double.Parse(auxVar))))
                {
                    bool tempBool2 = false;
                    string auxVar_2 = Module1.ReadINI("EEPROM", Convert.ToString(optIO[X].Tag), "0");
                    optIO[X].Checked = (Boolean.TryParse(auxVar_2, out tempBool2)) ? tempBool2 : Convert.ToBoolean(Double.Parse(auxVar_2));
                }
            }
            chAutoSil.CheckState = Module1.ReadINI("EEPROM", "AutoSilence", CheckState.Unchecked);
        }

        private void Form_Closed(Object eventSender, EventArgs eventArgs)
        {
            // Save the current state
            for (byte X = 0; X <= 15; X = (byte)(X + 1))
            {
                Module1.WriteINI("EEPROM", "Play" + X.ToString(), chPlay[X].CheckState);
                Module1.WriteINI("EEPROM", "Clear" + X.ToString(), chClear[X].CheckState);
                Module1.WriteINI("EEPROM", "Restart" + X.ToString(), chRestart[X].CheckState);
                Module1.WriteINI("EEPROM", "Interupt" + X.ToString(), chInt[X].CheckState);
                Module1.WriteINI("EEPROM", "PhraseToPlay" + X.ToString(), txtPhrase[X].Text);
            }
            Module1.WriteINI("EEPROM", "Play" + "16", chPlay[16].CheckState);
            Module1.WriteINI("EEPROM", "PhraseToPlay" + "16", txtPhrase[16].Text);
            for (byte X = 0; X <= 15; X = (byte)(X + 1))
            {
                Module1.WriteINI("EEPROM", Convert.ToString(optIO[X].Tag), optIO[X].Checked);
            }
            Module1.WriteINI("EEPROM", "AutoSilence", chAutoSil.CheckState);
        }

        private void txtPhrase_Leave(Object eventSender, EventArgs eventArgs)
        {
            int Index = Array.IndexOf(this.txtPhrase, eventSender);

            // Just in case the user typed in something other than a number...
            // Clear all text exept for the value of what was typed.
            txtPhrase[Index].Text = Convert.ToInt32(txtPhrase[Index].Text).ToString();
        }
    }
}