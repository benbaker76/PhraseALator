using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace PhraseALator
{
    internal partial class frmPhrase : Form
    {
        public frmPhrase()
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

        private void btnCodes_Click(Object eventSender, EventArgs eventArgs)
        {
            frmCodes frmCodes = null;
            string SpeakJetCodes = "";

            btnSaySelection.Enabled = false;
            Cursor = Cursors.WaitCursor;
            Application.DoEvents();

            string AlloPhoneList = Module1.ExtractAllophoneListFromSayData(txtSayData.Text);

            if (chkApplyControlsBeforeSayData.CheckState == CheckState.Checked)
            {
                SpeakJetCodes = GetControlCodes();
                //Else
                //SpeakJetCodes = Chr$(cvRESET)
            }

            SpeakJetCodes += Module1.GetSpeakJetCodes(AlloPhoneList);

            Cursor = Cursors.Default;
            Application.DoEvents();
            btnSaySelection.Enabled = true;
            txtSayData.Focus();

            ShowThisCodeList(SpeakJetCodes);

        }

        private void btnDone_Click(Object eventSender, EventArgs eventArgs)
        {
            frmUtility.DefInstance.WordToMove = txtDict.Text;
            frmUtility.DefInstance.PhraseToMove = txtSayData.Text;
            this.Close();
        }

        private void cmdLoadInsert_Click(Object eventSender, EventArgs eventArgs)
        {
            LoadWordsIntoSayData();
        }

        private void cmdLoadOver_Click(Object eventSender, EventArgs eventArgs)
        {
            txtSayData.Text = "";
            LoadWordsIntoSayData();
        }

        private void LoadWordsIntoSayData()
        {
            string WordToLookUp = "";
            int LocationOfSpace = 0;
            string SoundCodesInWord = "";

            string LookUpText = txtDict.Text.Trim();
            if (String.CompareOrdinal(LookUpText, "") > 0)
            {
                while (LookUpText != "")
                {
                    LocationOfSpace = ((LookUpText + " ").IndexOf(' ') + 1);
                    WordToLookUp = LookUpText.Substring(0, Math.Min(LocationOfSpace - 1, LookUpText.Length)).Trim();
                    LookUpText = LookUpText.Substring(LocationOfSpace - 1).Trim();
                    SoundCodesInWord = Module1.ReadDict("Words", WordToLookUp, "");
                    AddToText(SoundCodesInWord);
                };
            }
            txtSayData.Focus();
        }

        private void cmdSave_Click(Object eventSender, EventArgs eventArgs)
        {
            if (String.CompareOrdinal(txtDict.Text.Trim(), "") > 0)
            {
                if (txtDict.Text.Trim().IndexOf(' ') >= 0)
                {
                    MessageBox.Show("Cannot save mutil-word Dictionary entries.  Remove the spaces and try again.", Application.ProductName);
                }
                else
                {
                    Module1.WriteDict("Words", txtDict.Text.Trim(), Module1.FormatSayData(txtSayData.Text));
                }
            }
            txtSayData.Focus();
        }

        private void Command1_Click(Object eventSender, EventArgs eventArgs)
        {
            int Index = Array.IndexOf(this.Command1, eventSender);
            string SayData = "";

            Cursor = Cursors.WaitCursor;
            Application.DoEvents();

            if (Module1.gLastWasRepeat)
            {
                Module1.gLastWasRepeat = false;
            }
            else
            {
                if (chkApplyControlsBeforeSounds.CheckState == CheckState.Checked)
                {
                    SayData = GetControlCodes();
                    //Else
                    //SayData = Chr$(cvRESET)
                }
            }

            int SoundCode = Module1.GetSoundCode("\\" + Command1[Index].Text);

            if (SoundCode == Module1.cvWAIT)
            {
                if (MessageBox.Show("This control code will cause set the SpeakJet to stop until restarted." + Environment.NewLine + "To restart the SpeakJet you must do one of the following;" + Environment.NewLine + Environment.NewLine + " 1. Activate an event that has been tied to the Restart function." + Environment.NewLine + " 2. Send an SCP Restart command." + Environment.NewLine + " 3. Reset the SpeakJet with the Reset line. " + Environment.NewLine + " 4. Reset the SpeakJet with the SCP Reset command." + Environment.NewLine + "       Note that the \"Shut Up\" Button in the phrase editor" + Environment.NewLine + "       sends the SCP Reset command." + Environment.NewLine + Environment.NewLine + "-OR-" + Environment.NewLine + Environment.NewLine + " Press the Cancel button to not send this command to the SpeakJet.", "Notice", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.Cancel)
                {
                    Cursor = Cursors.Default;
                    return;
                }
            }

            if (SoundCode == Module1.cvRESET)
            {
                SetDefaults();
            }

            if (SoundCode < 256)
            {
                SayData = SayData + Strings.Chr(SoundCode).ToString();
            }
            else
            {
                scPitch.Value = Module1.GetNoteFreq(SoundCode);
                SayData = SayData + Strings.Chr(Module1.cvPITCH).ToString() + Strings.Chr(scPitch.Value).ToString();
            }

            switch (SoundCode)
            {
                case Module1.cvREPEAT:
                    SayData = SayData + Strings.Chr(Convert.ToInt32(txtRepeat.Text)).ToString();
                    Module1.gLastWasRepeat = true;
                    break;
                case Module1.cvCALL:
                    SayData = SayData + Strings.Chr(Convert.ToInt32(txtCall.Text)).ToString();
                    break;
                case Module1.cvDELAY:
                    SayData = SayData + Strings.Chr(Convert.ToInt32(TxtDelay.Text)).ToString();
                    break;
                case Module1.cvPLAY:
                    SayData = SayData + Strings.Chr(Convert.ToInt32(txtPlay.Text)).ToString();
                    break;
                case Module1.cvPCTRL:
                    SayData = SayData + Strings.Chr(Convert.ToInt32(txtPCtrl.Text)).ToString();
                    break;
                case Module1.cvPOUT:
                    SayData = SayData + Strings.Chr(Convert.ToInt32(txtPOut.Text)).ToString();
                    break;
            }

            Module1.SendDataToSpeakJet(SayData, true);

            Cursor = Cursors.Default;
            Application.DoEvents();
        }

        private void Command1_DoubleClick(Object eventSender, EventArgs eventArgs)
        {
            int Index = Array.IndexOf(this.Command1, eventSender);
            string Allophones = "\\" + Command1[Index].Text;
            int AllophoneCode = Module1.GetSoundCode(Allophones);

            switch (AllophoneCode)
            {
                case Module1.cvREPEAT:
                    Allophones = Allophones + " \\" + txtRepeat.Text;
                    break;
                case Module1.cvCALL:
                    Allophones = Allophones + " \\" + txtCall.Text;
                    break;
                case Module1.cvDELAY:
                    Allophones = Allophones + " \\" + TxtDelay.Text;
                    break;
                case Module1.cvPLAY:
                    Allophones = Allophones + " \\" + txtPlay.Text;
                    break;
                case Module1.cvPCTRL:
                    Allophones = Allophones + " \\" + txtPCtrl.Text;
                    break;
                case Module1.cvPOUT:
                    Allophones = Allophones + " \\" + txtPOut.Text;
                    break;
            }

            AddToText(Allophones);
        }

        public string GetControlCodes()
        {
            string result = "";

            result += Strings.Chr(Module1.cvVOLUME);
            result += Strings.Chr(scVolume.Value);

            result += Strings.Chr(Module1.cvSPEED);
            result += Strings.Chr(scSpeed.Value);

            result += Strings.Chr(Module1.cvPITCH);
            result += Strings.Chr(scPitch.Value);

            result += Strings.Chr(Module1.cvBEND);
            result += Strings.Chr(scBend.Value);

            return result.ToString();
        }

        private void AddToText(string zTextToAdd)
        {
            if (txtSayData.SelectionLength == 0)
            {
                while (txtSayData.Text.Substring(txtSayData.SelectionStart, Math.Min(1, txtSayData.Text.Length - txtSayData.SelectionStart)) == " ")
                    txtSayData.SelectionStart++;
            }

            txtSayData.SelectedText = zTextToAdd + " ";
        }

        private void bntSayIt_Click(Object eventSender, EventArgs eventArgs)
        {
            bntSayIt.Enabled = false;
            Cursor = Cursors.WaitCursor;
            Application.DoEvents();

            SayThisAllophoneList(Module1.ExtractAllophoneListFromSayData(txtSayData.Text));

            Cursor = Cursors.Default;
            Application.DoEvents();
            bntSayIt.Enabled = true;
            txtSayData.Focus();
        }

        public void SayThisAllophoneList(string zAllophoneList)
        {
            string SpeakJetCodes = "";

            if (chkApplyControlsBeforeSayData.CheckState == CheckState.Checked)
            {
                SpeakJetCodes = GetControlCodes();
                //Else
                //SpeakJetCodes = Chr$(cvRESET)
            }

            SpeakJetCodes = SpeakJetCodes + Module1.GetSpeakJetCodes(zAllophoneList);

            Module1.SendDataToSpeakJet(SpeakJetCodes, true);
        }

        private void btnClear_Click(Object eventSender, EventArgs eventArgs)
        {
            txtSayData.Text = "";
            txtSayData.Focus();
        }

        public void SetDefaults()
        {
            scVolume.Value = 96;
            scPitch.Value = 88;
            scSpeed.Value = 114;
            scBend.Value = 5;
        }

        private void btnShutUp_Click(Object eventSender, EventArgs eventArgs)
        {
            Module1.gSerialDataBeingSent = "";
            Module1.SendDataToSpeakJet("\\0RX" + Strings.Chr(Module1.cvRESET).ToString() + Strings.Chr(Module1.cvP0).ToString(), false);
            txtSayData.Focus();
        }

        private void btnSaySelection_Click(Object eventSender, EventArgs eventArgs)
        {
            string SpeakJetCodes = "";
            string AlloPhoneList = "";

            btnSaySelection.Enabled = false;
            Cursor = Cursors.WaitCursor;
            Application.DoEvents();

            SayThisAllophoneList(Module1.ExtractAllophoneListFromSayData(txtSayData.SelectedText));

            Cursor = Cursors.Default;
            Application.DoEvents();
            btnSaySelection.Enabled = true;
            txtSayData.Focus();
        }

        private void btnNextWord_Click(Object eventSender, EventArgs eventArgs)
        {
            if ((chkWith.CheckState == CheckState.Checked) && (chkWithout.CheckState == CheckState.Unchecked))
            {
                do
                {
                    GetNextWord();
                }
                while (!((String.CompareOrdinal(txtSayData.Text.Trim(), "") > 0) && ((String.CompareOrdinal(txtfindwith.Text, "") > 0) ? txtSayData.Text.IndexOf(txtfindwith.Text.ToUpper()) >= 0 : true)));
                SayThisAllophoneList(Module1.ExtractAllophoneListFromSayData(txtSayData.Text));
            }
            else if ((chkWith.CheckState == CheckState.Unchecked) && (chkWithout.CheckState == CheckState.Checked))
            {
                bool tempBool = false;
                string auxVar = (txtSayData.Text == "").ToString().Trim();
                do
                {
                    GetNextWord();
                }
                while (!((Boolean.TryParse(auxVar, out tempBool)) ? tempBool : Convert.ToBoolean(Double.Parse(auxVar))));
            }
            else if ((chkWith.CheckState == CheckState.Checked) && (chkWithout.CheckState == CheckState.Checked))
            {
                GetNextWord();
                SayThisAllophoneList(Module1.ExtractAllophoneListFromSayData(txtSayData.Text));
            }
            else
            {
                MessageBox.Show("Must select either With Data or Without Data or Both", Application.ProductName);
            }
        }

        public void GetNextWord()
        {
            int LocationOfEqual = 0;

            string CurrentWord = txtDict.Text.ToLower();
            string NewWord = "";
            string NextWord = "zzzzzzzzz!!!";
            string[] LineArray = File.ReadAllLines(Path.Combine(Application.StartupPath, "PhraseALator.Dic"));

            foreach (string Line in LineArray)
            {
                NewWord = Line;
                LocationOfEqual = (NewWord.IndexOf('=') + 1);
                if (LocationOfEqual > 0)
                {
                    NewWord = NewWord.Substring(0, Math.Min(LocationOfEqual - 1, NewWord.Length)).ToLower().Trim();
                    if (String.CompareOrdinal(NewWord, CurrentWord) > 0)
                    {
                        if (String.CompareOrdinal(NewWord, NextWord) < 0)
                        {
                            NextWord = NewWord;
                        }
                    }
                }
            }

            if (txtDict.Text.Trim() == "zzzzzzzzz!!!")
            {
                txtDict.Text = "";
                GetNextWord();
            }
            else
            {
                txtDict.Text = NextWord;
                if (txtDict.Text.Trim() == "zzzzzzzzz!!!")
                {
                    txtDict.Text = "";
                    GetNextWord();
                }
                else
                {
                    txtSayData.Text = "";
                    LoadWordsIntoSayData();
                }
            }
        }

        private void Command2_Click(Object eventSender, EventArgs eventArgs)
        {
            string SpeakJetCodes = "";

            btnSaySelection.Enabled = false;
            Cursor = Cursors.WaitCursor;
            Application.DoEvents();

            string AlloPhoneList = Module1.ExtractAllophoneListFromSayData(txtSayData.SelectedText);

            if (chkApplyControlsBeforeSayData.CheckState == CheckState.Checked)
            {
                SpeakJetCodes = GetControlCodes();
            }
            else
            {
                //SpeakJetCodes = Chr$(cvRESET)
            }

            SpeakJetCodes = SpeakJetCodes + Module1.GetSpeakJetCodes(AlloPhoneList);

            Cursor = Cursors.Default;
            Application.DoEvents();
            btnSaySelection.Enabled = true;
            txtSayData.Focus();

            ShowThisCodeList(SpeakJetCodes);
        }

        private void Form_Activated(Object eventSender, EventArgs eventArgs)
        {
            if (Globals.ActiveForm != eventSender)
            {
                Globals.ActiveForm = (Form)eventSender;

                txtSayData.Focus();
            }
        }

        private void Form_Load()
        {
            if (String.CompareOrdinal(frmUtility.DefInstance.WordToMove, "") > 0)
            {
                txtDict.Text = frmUtility.DefInstance.WordToMove;
            }
            if (String.CompareOrdinal(frmUtility.DefInstance.PhraseToMove, "") > 0)
            {
                txtSayData.Text = frmUtility.DefInstance.PhraseToMove;
            }
            SetDefaults();
        }

        private void lblBend_DoubleClick(Object eventSender, EventArgs eventArgs)
        {
            txtBend_Leave(txtBend, new EventArgs());
            AddToText(Module1.GetPhonemeName(Module1.cvBEND) + " \\" + scBend.Value.ToString());
        }

        private void lblPitch_DoubleClick(Object eventSender, EventArgs eventArgs)
        {
            txtPitch_Leave(txtPitch, new EventArgs());
            AddToText(Module1.GetPhonemeName(Module1.cvPITCH) + " \\" + scPitch.Value.ToString());
        }

        private void lblSpeed_DoubleClick(Object eventSender, EventArgs eventArgs)
        {
            txtSpeed_Leave(txtSpeed, new EventArgs());
            AddToText(Module1.GetPhonemeName(Module1.cvSPEED) + " \\" + scSpeed.Value.ToString());
        }

        private void lblVolume_DoubleClick(Object eventSender, EventArgs eventArgs)
        {
            txtVolume_Leave(txtVolume, new EventArgs());
            AddToText(Module1.GetPhonemeName(Module1.cvVOLUME) + " \\" + scVolume.Value.ToString());
        }

        private void scBend_ValueChanged(Object eventSender, EventArgs eventArgs)
        {
            txtBend.Text = scBend.Value.ToString();
        }

        private void scBend_Scroll_Renamed(int newScrollValue)
        {
            txtBend.Text = newScrollValue.ToString();
        }

        private void scPitch_ValueChanged(Object eventSender, EventArgs eventArgs)
        {
            txtPitch.Text = scPitch.Value.ToString();
        }

        private void scPitch_Scroll_Renamed(int newScrollValue)
        {
            txtPitch.Text = newScrollValue.ToString();
        }

        private void scSpeed_ValueChanged(Object eventSender, EventArgs eventArgs)
        {
            txtSpeed.Text = scSpeed.Value.ToString();
        }

        private void scSpeed_Scroll_Renamed(int newScrollValue)
        {
            txtSpeed.Text = newScrollValue.ToString();
        }

        private void scVolume_ValueChanged(Object eventSender, EventArgs eventArgs)
        {
            txtVolume.Text = scVolume.Value.ToString();
        }

        private void scVolume_Scroll_Renamed(int newScrollValue)
        {
            txtVolume.Text = newScrollValue.ToString();
        }

        private void txtBend_Leave(Object eventSender, EventArgs eventArgs)
        {
            if (Convert.ToInt32(txtBend.Text) > 15)
            {
                txtBend.Text = "15";
            }
            if (Convert.ToInt32(txtBend.Text) < 0)
            {
                txtBend.Text = "0";
            }
            scBend.Value = Convert.ToInt32(txtBend.Text);
        }

        private void txtPitch_Leave(Object eventSender, EventArgs eventArgs)
        {
            if (Convert.ToInt32(txtPitch.Text) > 255)
            {
                txtPitch.Text = "255";
            }
            if (Convert.ToInt32(txtPitch.Text) < 0)
            {
                txtPitch.Text = "0";
            }
            scPitch.Value = Convert.ToInt32(txtPitch.Text);
        }

        private void txtSpeed_Leave(Object eventSender, EventArgs eventArgs)
        {
            if (Convert.ToInt32(txtSpeed.Text) > 127)
            {
                txtSpeed.Text = "127";
            }
            if (Convert.ToInt32(txtSpeed.Text) < 0)
            {
                txtSpeed.Text = "0";
            }
            scSpeed.Value = Convert.ToInt32(txtSpeed.Text);
        }

        private void txtVolume_Leave(Object eventSender, EventArgs eventArgs)
        {
            if (Convert.ToInt32(txtVolume.Text) > 127)
            {
                txtVolume.Text = "127";
            }
            if (Convert.ToInt32(txtVolume.Text) < 0)
            {
                txtVolume.Text = "0";
            }
            scVolume.Value = Convert.ToInt32(txtVolume.Text);
        }

        public void ShowThisCodeList(string zSpeakJetCodes)
        {
            StringBuilder NumericCodes = new StringBuilder();

            int tempForEndVar = zSpeakJetCodes.Length;
            for (int X = 1; X <= tempForEndVar; X++)
            {
                NumericCodes.Append(", " + Strings.Asc(zSpeakJetCodes.Substring(X - 1, Math.Min(1, zSpeakJetCodes.Length - (X - 1)))[0]).ToString());
            }
            frmUtility.DefInstance.SpeakJetCodes = NumericCodes.ToString().Substring(2);
            frmCodes.DefInstance.ShowDialog(this);

        }
        private void Form_Closed(Object eventSender, EventArgs eventArgs)
        {
        }
        private void scBend_Scroll(Object eventSender, ScrollEventArgs eventArgs)
        {
            switch (eventArgs.Type)
            {
                case ScrollEventType.ThumbTrack:
                    scBend_Scroll_Renamed(eventArgs.NewValue);
                    break;
            }
        }
        private void scPitch_Scroll(Object eventSender, ScrollEventArgs eventArgs)
        {
            switch (eventArgs.Type)
            {
                case ScrollEventType.ThumbTrack:
                    scPitch_Scroll_Renamed(eventArgs.NewValue);
                    break;
            }
        }
        private void scSpeed_Scroll(Object eventSender, ScrollEventArgs eventArgs)
        {
            switch (eventArgs.Type)
            {
                case ScrollEventType.ThumbTrack:
                    scSpeed_Scroll_Renamed(eventArgs.NewValue);
                    break;
            }
        }
        private void scVolume_Scroll(Object eventSender, ScrollEventArgs eventArgs)
        {
            switch (eventArgs.Type)
            {
                case ScrollEventType.ThumbTrack:
                    scVolume_Scroll_Renamed(eventArgs.NewValue);
                    break;
            }
        }
    }
}