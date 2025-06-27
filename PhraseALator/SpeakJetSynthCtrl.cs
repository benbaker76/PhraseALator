using Microsoft.VisualBasic;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PhraseALator
{
    internal partial class FrmSynthCtrl : Form
    {
        int gVolAdjTone1 = 0;
        int gVolAdjTone2 = 0;
        int gVolAdjTone3 = 0;
        int gFreqAdjTone1 = 0;
        int gFreqAdjTone2 = 0;
        int gFreqAdjTone3 = 0;

        public FrmSynthCtrl()
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

            isInitializingComponent = true;
            InitializeComponent();
            isInitializingComponent = false;
            ReLoadForm(false);
        }


        private void FrmSynthCtrl_Activated(Object eventSender, EventArgs eventArgs)
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

        private void btnLoad_Click(Object eventSender, EventArgs eventArgs)
        {
            for (byte X = 1; X <= 5; X = (byte)(X + 1))
            {
                scFreq[X].Value = Convert.ToInt32(Module1.ReadSound(txtSound.Text, "Freq" + X.ToString(), "0"));
                scVol[X].Value = Convert.ToInt32(Module1.ReadSound(txtSound.Text, "Vol" + X.ToString(), "0"));
            }
        }

        private void btnSave_Click(Object eventSender, EventArgs eventArgs)
        {
            for (byte X = 1; X <= 5; X = (byte)(X + 1))
            {
                Module1.WriteSound(txtSound.Text, "Freq" + X.ToString(), scFreq[X].Value);
                Module1.WriteSound(txtSound.Text, "Vol" + X.ToString(), scVol[X].Value);
            }
        }

        private void Check2_CheckStateChanged(Object eventSender, EventArgs eventArgs)
        {
            SendEnvolopeControlToSpeakJet(GetEnvolopeCtrlValue());
        }

        private void Command1_Click(Object eventSender, EventArgs eventArgs)
        {
            for (byte X = 1; X <= 3; X = (byte)(X + 1))
            {
                scFreq[X].Value = Convert.ToInt32(Math.Floor(((double)scFreq[X].Value + Convert.ToInt32((Double.Parse(txtHFreq.Text) / 2).ToString())) / (Convert.ToInt32(txtHFreq.Text))) * (Convert.ToInt32(txtHFreq.Text)));
            }
        }

        private void Command2_Click(Object eventSender, EventArgs eventArgs)
        {
            gVolAdjTone1 = scVol[1].Value;
            gVolAdjTone2 = scVol[2].Value;
            gVolAdjTone3 = scVol[3].Value;
            scVolAdjTone.Value = 100;
        }

        private void Command3_Click(Object eventSender, EventArgs eventArgs)
        {
            gFreqAdjTone1 = scFreq[1].Value;
            gFreqAdjTone2 = scFreq[2].Value;
            gFreqAdjTone3 = scFreq[3].Value;
            scFreqAdjTone.Value = 100;
        }

        private void btnShutUp_Click(Object eventSender, EventArgs eventArgs)
        {
            Module1.gSerialDataBeingSent = "";
            SynthShutUp();
        }

        public void SynthShutUp()
        {
            // Clear the input buffer.
            Module1.SendDataToSpeakJet("\\0RX", false);

            // Zero out the Oscillator's volume levels
            for (int Index = 1; Index <= 5; Index++)
            {
                scVol[Index].Value = 0;
                //Call SendOscillatorVolumeToSpeakJet(Index, scVol(Index).Value)
            }

            // Zero out the Envolope Frequency setting
            scEnvolopeFreq.Value = 88;
            //Call SendOscillatorFrequencyToSpeakJet(0, scEnvolopeFreq.Value)

            // Zero out the Oscillator's Frequency settings
            for (int Index = 1; Index <= 5; Index++)
            {
                scFreq[Index].Value = 0;
                //Call SendOscillatorFrequencyToSpeakJet(Index, scFreq(Index).Value)
            }

            // Zero out the Noise Level
            scLevel[0].Value = 0;
            //Call SendRegisterLevelToSpeakJet(0, scLevel(0).Value)

            // Set the Master volume to 1/2
            scLevel[1].Value = 96;
            //Call SendRegisterLevelToSpeakJet(1, scLevel(1).Value)

            // Configure the Envolope for Sine wave But set the Oscillator to not use it.
            Option1[0].Checked = true;
            Check2[0].CheckState = CheckState.Unchecked;
            Check2[1].CheckState = CheckState.Unchecked;
            //Call SendEnvolopeControlToSpeakJet(GetEnvolopeCtrlValue)
        }

        private void Form_Load()
        {
            SynthShutUp();
        }

        private void Form_Closed(Object eventSender, EventArgs eventArgs)
        {
            Module1.gSerialDataBeingSent = "";
            SynthShutUp();
            SendEnvolopeControlToSpeakJet(0);
        }

        private bool isInitializingComponent;
        private void Option1_CheckedChanged(Object eventSender, EventArgs eventArgs)
        {
            if (((RadioButton)eventSender).Checked)
            {
                if (isInitializingComponent)
                {
                    return;
                }
                SendEnvolopeControlToSpeakJet(GetEnvolopeCtrlValue());
            }
        }

        private void scEnvolopeFreq_ValueChanged(Object eventSender, EventArgs eventArgs)
        {
            txtEnvFreq.Text = scEnvolopeFreq.Value.ToString();
            SendOscillatorFrequencyToSpeakJet(0, scEnvolopeFreq.Value);
        }

        private void scEnvolopeFreq_Scroll(int newScrollValue)
        {
            txtEnvFreq.Text = newScrollValue.ToString();
            SendOscillatorFrequencyToSpeakJet(0, newScrollValue);
        }

        private void scFreq_ValueChanged(Object eventSender, EventArgs eventArgs)
        {
            int Index = Array.IndexOf(scFreq, eventSender);
            txtFreq[Index].Text = scFreq[Index].Value.ToString();
            SendOscillatorFrequencyToSpeakJet(Index, scFreq[Index].Value);
        }

        private void scFreq_Scroll(int Index, int newScrollValue)
        {
            txtFreq[Index].Text = scFreq[Index].Value.ToString();
            SendOscillatorFrequencyToSpeakJet(Index, scFreq[Index].Value);
        }

        private void scLevel_ValueChanged(Object eventSender, EventArgs eventArgs)
        {
            int Index = Array.IndexOf(scLevel, eventSender);
            txtLevel[Index].Text = scLevel[Index].Value.ToString();
            SendRegisterLevelToSpeakJet(Index, scLevel[Index].Value);
        }

        private void scLevel_Scroll_Renamed(int Index, int newScrollValue)
        {
            txtLevel[Index].Text = scLevel[Index].Value.ToString();
            SendRegisterLevelToSpeakJet(Index, scLevel[Index].Value);
        }

        private void scVol_ValueChanged(Object eventSender, EventArgs eventArgs)
        {
            int Index = Array.IndexOf(scVol, eventSender);
            txtVol[Index].Text = scVol[Index].Value.ToString();
            SendOscillatorVolumeToSpeakJet(Index, scVol[Index].Value);
            CheckVolumeLimits();
        }

        private void scVol_Scroll_Renamed(int Index, int newScrollValue)
        {
            txtVol[Index].Text = scVol[Index].Value.ToString();
            SendOscillatorVolumeToSpeakJet(Index, scVol[Index].Value);
            CheckVolumeLimits();
        }

        public void CheckVolumeLimits()
        {
            if ((scVol[1].Value) + (scVol[2].Value) + (scVol[3].Value) > 63)
            {
                txtVol[1].BackColor = Color.Red;
                txtVol[2].BackColor = Color.Red;
                txtVol[3].BackColor = Color.Red;
            }
            else if ((scVol[1].Value) + (scVol[2].Value) + (scVol[3].Value) > 59)
            {
                txtVol[1].BackColor = Color.Yellow;
                txtVol[2].BackColor = Color.Yellow;
                txtVol[3].BackColor = Color.Yellow;
            }
            else
            {
                txtVol[1].BackColor = SystemColors.Control;
                txtVol[2].BackColor = SystemColors.Control;
                txtVol[3].BackColor = SystemColors.Control;
            }
        }

        public void SendRegisterLevelToSpeakJet(int zRegister, int zLevel)
        {
            string ProgramString = "";
            ProgramString = ProgramString + "\\0";
            ProgramString = ProgramString + (zRegister + 6).ToString() + "J";
            ProgramString = ProgramString + zLevel.ToString() + "N";
            ProgramString = ProgramString + "X";
            Module1.SendDataToSpeakJet(ProgramString, false);
        }

        public void SendOscillatorVolumeToSpeakJet(int zOscillator, int zVolume)
        {
            string ProgramString = "";

            ProgramString = ProgramString + "\\0";
            ProgramString = ProgramString + (zOscillator + 10).ToString() + "J";
            ProgramString = ProgramString + zVolume.ToString() + "N";
            ProgramString = ProgramString + "X";
            Module1.SendDataToSpeakJet(ProgramString, false);

        }

        public void SendOscillatorFrequencyToSpeakJet(int zOscillator, int zFrequency)
        {
            string ProgramString = "";

            ProgramString = ProgramString + "\\0";
            ProgramString = ProgramString + zOscillator.ToString() + "J";
            ProgramString = ProgramString + zFrequency.ToString() + "N";
            ProgramString = ProgramString + "X";
            Module1.SendDataToSpeakJet(ProgramString, false);

        }

        public void SendEnvolopeControlToSpeakJet(byte zControlValue)
        {
            string ProgramString = "";

            ProgramString = ProgramString + "\\0";
            ProgramString = ProgramString + "8" + "J";
            ProgramString = ProgramString + zControlValue.ToString() + "N";
            ProgramString = ProgramString + "X";
            Module1.SendDataToSpeakJet(ProgramString, false);

        }

        public byte GetEnvolopeCtrlValue()
        {

            byte result = 0;
            int tempForEndVar = Option1.Length - 1;
            for (result = 0; result <= tempForEndVar; result = (byte)(result + 1))
            {
                if (Option1[result].Checked)
                {
                    break;
                }
            }

            if (Check2[0].CheckState == CheckState.Checked)
            {
                result = (byte)(result + 128);
            }
            if (Check2[1].CheckState == CheckState.Checked)
            {
                result = (byte)(result + 64);
            }

            return result;
        }

        private void scVolAdjTone_ValueChanged(Object eventSender, EventArgs eventArgs)
        {
            scVol[1].Value = max(Convert.ToInt32(gVolAdjTone1 * scVolAdjTone.Value / 100), 31);
            scVol[2].Value = max(Convert.ToInt32(gVolAdjTone2 * scVolAdjTone.Value / 100), 31);
            scVol[3].Value = max(Convert.ToInt32(gVolAdjTone3 * scVolAdjTone.Value / 100), 31);
        }

        private void scVolAdjTone_Enter(Object eventSender, EventArgs eventArgs)
        {
            gVolAdjTone1 = scVol[1].Value;
            gVolAdjTone2 = scVol[2].Value;
            gVolAdjTone3 = scVol[3].Value;
            scVolAdjTone.Value = 100;
        }

        private void scVolAdjTone_Scroll_Renamed(int newScrollValue)
        {
            scVol[1].Value = max(Convert.ToInt32(gVolAdjTone1 * newScrollValue / 100), 31);
            scVol[2].Value = max(Convert.ToInt32(gVolAdjTone2 * newScrollValue / 100), 31);
            scVol[3].Value = max(Convert.ToInt32(gVolAdjTone3 * newScrollValue / 100), 31);
        }

        private void scFreqAdjTone_ValueChanged(Object eventSender, EventArgs eventArgs)
        {
            scFreq[1].Value = max(Convert.ToInt32(gFreqAdjTone1 * scFreqAdjTone.Value / 100), 3999);
            scFreq[2].Value = max(Convert.ToInt32(gFreqAdjTone2 * scFreqAdjTone.Value / 100), 3999);
            scFreq[3].Value = max(Convert.ToInt32(gFreqAdjTone3 * scFreqAdjTone.Value / 100), 3999);
        }

        private void scFreqAdjTone_Enter(Object eventSender, EventArgs eventArgs)
        {
            gFreqAdjTone1 = scFreq[1].Value;
            gFreqAdjTone2 = scFreq[2].Value;
            gFreqAdjTone3 = scFreq[3].Value;
            scFreqAdjTone.Value = 100;
        }

        private void scFreqAdjTone_Scroll_Renamed(int newScrollValue)
        {
            scFreq[1].Value = max(Convert.ToInt32(gFreqAdjTone1 * newScrollValue / 100), 3999);
            scFreq[2].Value = max(Convert.ToInt32(gFreqAdjTone2 * newScrollValue / 100), 3999);
            scFreq[3].Value = max(Convert.ToInt32(gFreqAdjTone3 * newScrollValue / 100), 3999);
        }

        public int max(int zValue, int zMax)
        {
            if (zValue > zMax)
            {
                return zMax;
            }
            else
            {
                return zValue;
            }
        }

        private void txtEnvFreq_Leave(Object eventSender, EventArgs eventArgs)
        {
            if (Convert.ToInt32(txtEnvFreq.Text) > 255)
            {
                txtEnvFreq.Text = "255";
            }
            scEnvolopeFreq.Value = Convert.ToInt32(txtEnvFreq.Text);
        }

        private void txtFreq_Leave(Object eventSender, EventArgs eventArgs)
        {
            int Index = Array.IndexOf(this.txtFreq, eventSender);
            if (Convert.ToInt32(txtFreq[Index].Text) > 3999)
            {
                txtFreq[Index].Text = "3999";
            }
            scFreq[Index].Value = Convert.ToInt32(txtFreq[Index].Text);
        }

        private void txtLevel_Leave(Object eventSender, EventArgs eventArgs)
        {
            int Index = Array.IndexOf(this.txtLevel, eventSender);
            if (Convert.ToInt32(txtLevel[Index].Text) > 255)
            {
                txtLevel[Index].Text = "255";
            }
            scLevel[Index].Value = Convert.ToInt32(txtLevel[Index].Text);

        }

        private void txtVol_Leave(Object eventSender, EventArgs eventArgs)
        {
            int Index = Array.IndexOf(this.txtVol, eventSender);
            if (Convert.ToInt32(txtVol[Index].Text) > 31)
            {
                txtVol[Index].Text = "31";
            }
            scVol[Index].Value = Convert.ToInt32(txtVol[Index].Text);
        }
        private void scEnvolopeFreq_Scroll(Object eventSender, ScrollEventArgs eventArgs)
        {
            switch (eventArgs.Type)
            {
                case ScrollEventType.ThumbTrack:
                    scEnvolopeFreq_Scroll(eventArgs.NewValue);
                    break;
            }
        }
        private void scFreq_Scroll(Object eventSender, ScrollEventArgs eventArgs)
        {
            int Index = Array.IndexOf(scFreq, eventSender);
            switch (eventArgs.Type)
            {
                case ScrollEventType.ThumbTrack:
                    scFreq_Scroll(Index, eventArgs.NewValue);
                    break;
            }
        }
        private void scLevel_Scroll(Object eventSender, ScrollEventArgs eventArgs)
        {
            int Index = Array.IndexOf(scLevel, eventSender);
            switch (eventArgs.Type)
            {
                case ScrollEventType.ThumbTrack:
                    scLevel_Scroll_Renamed(Index, eventArgs.NewValue);
                    break;
            }
        }
        private void scVol_Scroll(Object eventSender, ScrollEventArgs eventArgs)
        {
            int Index = Array.IndexOf(scVol, eventSender);
            switch (eventArgs.Type)
            {
                case ScrollEventType.ThumbTrack:
                    scVol_Scroll_Renamed(Index, eventArgs.NewValue);
                    break;
            }
        }
        private void scVolAdjTone_Scroll(Object eventSender, ScrollEventArgs eventArgs)
        {
            switch (eventArgs.Type)
            {
                case ScrollEventType.ThumbTrack:
                    scVolAdjTone_Scroll_Renamed(eventArgs.NewValue);
                    break;
            }
        }
        private void scFreqAdjTone_Scroll(Object eventSender, ScrollEventArgs eventArgs)
        {
            switch (eventArgs.Type)
            {
                case ScrollEventType.ThumbTrack:
                    scFreqAdjTone_Scroll_Renamed(eventArgs.NewValue);
                    break;
            }
        }
    }
}