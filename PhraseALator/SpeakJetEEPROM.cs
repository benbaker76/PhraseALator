using System;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PhraseALator
{
    internal partial class frmEEPROM : Form
    {
        public frmEEPROM()
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

        private void btnDone_Click(Object eventSender, EventArgs eventArgs)
        {
            this.Close();
        }

        private void btnWrite_Click(Object eventSender, EventArgs eventArgs)
        {
            string ProgramString = "";

            btnWrite.Enabled = false;
            Cursor = Cursors.WaitCursor;
            Application.DoEvents();
            string EEPROMPhraseString = GetEEPROMPhraseString();
            if (EEPROMPhraseString.Length > 235)
            {
                MessageBox.Show("EEPROM Phrases too large." + Environment.NewLine + "Reduce and try again.", Application.ProductName);
            }
            else
            {
                for (byte xChar = 0; xChar <= 15; xChar = (byte)(xChar + 1))
                {
                    ProgramString += "\\0";
                    ProgramString += xChar.ToString() + "J";
                    ProgramString += "32" + "H";
                    ProgramString += Module1.dhex((byte)Strings.Asc(EEPROMPhraseString.Substring(xChar, Math.Min(1, EEPROMPhraseString.Length - xChar))[0])) + "N";
                }
                int tempForEndVar2 = EEPROMPhraseString.Length - 1;
                for (byte xChar = 16; xChar <= tempForEndVar2; xChar = (byte)(xChar + 1))
                {
                    ProgramString += "\\0";
                    ProgramString += xChar.ToString() + "J";
                    ProgramString += "32" + "H";
                    ProgramString += Module1.dhex((byte)Strings.Asc(EEPROMPhraseString.Substring(xChar, Math.Min(1, EEPROMPhraseString.Length - xChar))[0])) + "N";
                }
                ProgramString += "\\0VX";

                Module1.SendDataToSpeakJet(ProgramString, false);
            }
            Cursor = Cursors.Default;
            btnWrite.Enabled = true;
            Application.DoEvents();
        }

        public string GetEEPROMPhraseString()
        {
            string result = "";
            string AlloPhoneList = "";
            StringBuilder PhrasePointerList = new StringBuilder();

            for (byte xPhrase = 0; xPhrase <= 15; xPhrase = (byte)(xPhrase + 1))
            {
                AlloPhoneList = Module1.ExtractAllophoneListFromSayData(Phrase[xPhrase].Text);

                if (String.CompareOrdinal(AlloPhoneList, "") > 0)
                {
                    PhrasePointerList.Append(Strings.Chr((result.Length + 16) % 256));
                    result += Module1.GetSpeakJetCodes(AlloPhoneList);
                    result += Strings.Chr(255);
                }
                else
                {
                    PhrasePointerList.Append(Strings.Chr(255));
                }
            }

            return PhrasePointerList + result;
        }

        private void btnShutUp_Click(Object eventSender, EventArgs eventArgs)
        {
            Module1.gSerialDataBeingSent = "";
            Module1.SendDataToSpeakJet("\\0RX" + Strings.Chr(Module1.cvRESET) + Strings.Chr(Module1.cvP0), false);
        }

        private void Form_Load()
        {
            for (byte xPhrase = 0; xPhrase <= 15; xPhrase = (byte)(xPhrase + 1))
            {
                Phrase[xPhrase].Text = Module1.ReadINI("EEPROM", "Phrase" + xPhrase.ToString(), "");
            }
            ReportUsed();

        }

        private void Form_Closed(Object eventSender, EventArgs eventArgs)
        {
            for (byte xPhrase = 0; xPhrase <= 15; xPhrase = (byte)(xPhrase + 1))
            {
                Module1.WriteINI("EEPROM", "Phrase" + xPhrase.ToString(), Phrase[xPhrase].Text);
            }
        }

        private void lbs_Click(Object eventSender, EventArgs eventArgs)
        {
            int Index = Array.IndexOf(this.lbs, eventSender);

            Module1.SendDataToSpeakJet(Strings.Chr(Module1.cvPLAY).ToString() + Strings.Chr(Index).ToString(), true);
        }

        private void Phrase_Click(Object eventSender, EventArgs eventArgs)
        {
            int Index = Array.IndexOf(this.Phrase, eventSender);

            frmUtility.DefInstance.WordToMove = "";
            frmUtility.DefInstance.PhraseToMove = Phrase[Index].Text;
            frmPhrase.DefInstance.ShowDialog(this);
            Phrase[Index].Text = frmUtility.DefInstance.PhraseToMove;
            ReportUsed();
        }

        public void ReportUsed()
        {
            string TotalEEPROMCodes = GetEEPROMPhraseString();
            int CountEEPROMCodes = TotalEEPROMCodes.Length + 21;
            txtUsed.Text = CountEEPROMCodes.ToString() + " used of 256";
            if (CountEEPROMCodes > 256)
            {
                txtUsed.BackColor = Color.Red;
            }
            else if (CountEEPROMCodes > 240)
            {
                txtUsed.BackColor = Color.Yellow;
            }
            else
            {
                txtUsed.BackColor = SystemColors.Control;
            }
        }
    }
}